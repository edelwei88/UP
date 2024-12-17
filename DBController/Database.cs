using DBController.Enums;
using DBController.Models;
using Microsoft.Data.SqlClient;
namespace DBController;

public class Database
{
    private readonly string connectionString;

    public Database(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public User Auth(string login, string password)
    {
        using (SqlConnection conn = new(connectionString))
        {
            SqlCommand cmd = new("SELECT userTypeID FROM Users WHERE login = @login AND password = @password", conn);
            cmd.Parameters.Add(new SqlParameter("@login", login));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            conn.Open();
            object tmp = cmd.ExecuteScalar();
            return tmp == null ? User.None : (User)tmp;
        }
    }

    public IEnumerable<Request> GetAllRequests()
    {
        List<Request> ret = new List<Request>();
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new(@"SELECT requestID, startDate, problemDescription, completionDate, t1.requestStatusID, t2.requestStatus, t3.techTypeID, t3.techType, t3.techModelID, t3.techModel, t1.masterID, t4.fio, t1.clientID, t5.fio
                                    FROM Requests as t1
                                    LEFT JOIN RequestStatuses as t2
	                                    ON t1.requestStatusID = t2.requestStatusID
                                    LEFT JOIN ( SELECT t2.techTypeID, t2.techType, TechModel, techModelID FROM TechModels as t1
		                            	LEFT JOIN TechTypes as t2
		                                	ON t1.techTypeID = t2.techTypeID ) as t3
	                                    ON t1.techModelID = t3.techModelID
                                    LEFT JOIN Users as t4
                                    	ON t1.masterID = t4.userID
                                    LEFT JOIN Users as t5
                                    	ON t1.clientID = t5.userID", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(new Request(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.IsDBNull(3) ? null : reader.GetDateTime(3), new(reader.GetInt32(4), reader.GetString(5)), new(reader.GetInt32(6), reader.GetString(7)), new(reader.GetInt32(8), reader.GetString(9)), reader.IsDBNull(10) ? null : new(reader.GetInt32(10), reader.GetString(11)), new(reader.GetInt32(12), reader.GetString(13))));
            }
        }

        return ret;
    }

    public string GetUserNameByLogin(string login)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT fio FROM Users WHERE login = @login", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@login", login));
                object tmp = cmd.ExecuteScalar();
                return tmp == null ? "" : (string)tmp;
            }
        }
    }

    public int GetUserIdByLogin(string login)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT userID FROM Users WHERE login = @login", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@login", login));
                object tmp = cmd.ExecuteScalar();
                return tmp == null ? throw new Exception("User not found") : (int)tmp;
            }
        }
    }

    public Dictionary<int, string> GetTechTypes()
    {
        var ret = new Dictionary<int, string>();

        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT techTypeID, techType FROM TechTypes", conn))
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    ret.Add(reader.GetInt32(0), reader.GetString(1));

                return ret;
            }
        }
    }

    public Dictionary<int, string> GetTechModelsByType(KeyValuePair<int, string> tt)
    {
        var ret = new Dictionary<int, string>();

        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT techModelID, techModel FROM TechModels WHERE techTypeID = @techTypeID", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@techTypeID", tt.Key));
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    ret.Add(reader.GetInt32(0), reader.GetString(1));

                return ret;
            }
        }
    }

    public Dictionary<int, string> GetRequestStatuses()
    {
        var ret = new Dictionary<int, string>();

        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT * FROM RequestStatuses", conn))
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    ret.Add(reader.GetInt32(0), reader.GetString(1));

                return ret;
            }
        }
    }

    public void CreateRequest(DateTime startDate, string problemDescription, DateTime? completionDate, int requestStatusID, int techModelID, int? masterID, int clientID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("INSERT INTO Requests VALUES (@startDate, @problemDescription, @completionDate, @requestStatusID, @techModelID, @masterID, @clientID)", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@startDate", startDate.Date),
                    new("@problemDescription", problemDescription),
                    new("@completionDate", completionDate == null ? DBNull.Value : completionDate),
                    new("@requestStatusID", requestStatusID),
                    new("@techModelID", techModelID),
                    new("@masterID", masterID == null ? DBNull.Value : masterID),
                    new("@clientID", clientID),
                ]);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void EditRequest(int requestID, string problemDescription, int techModelID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("UPDATE Requests SET problemDescription = @problemDescription, techModelID = @techModelID WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@problemDescription", problemDescription),
                    new("@techModelID", techModelID),
                    new("@requestID", requestID),
                ]);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void FinishRequest(int requestID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("UPDATE Requests SET requestStatusID = 3  WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@requestID", requestID),
                ]);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void ChangeStatus(int requestID, int requestStatusID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("UPDATE Requests SET requestStatusID = @requestStatusID  WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@requestID", requestID),
                    new("@requestStatusID", requestStatusID),
                ]);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public void SetMasterForRequest(int requestID, int masterID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("UPDATE Requests SET masterID = @masterID  WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@requestID", requestID),
                    new("@masterID", masterID),
                ]);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void SetDateForRequest(int requestID, DateTime completionDate)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("UPDATE Requests SET completionDate = @completionDate  WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.AddRange(
                [
                    new("@requestID", requestID),
                    new("@completionDate", completionDate),
                ]);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public Dictionary<int, Comment> GetAllComments()
    {
        Dictionary<int, Comment> ret = new();
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT * FROM Comments", conn))
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    ret.Add(reader.GetInt32(0), new(reader.GetString(1), reader.GetInt32(2)));

                return ret;
            }
        }
    }

    public void CreateComment(int requestID, string comment)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("INSERT INTO Comments VALUES (@message, @requestID)", conn))
            {
                cmd.Parameters.AddRange([
                    new ("@message", comment),
                    new("@requestID", requestID),
                    ]);
                cmd.ExecuteNonQuery();
            }
        }

    }
    public void OrderRepairPart(int requestID, string repairPart)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("INSERT INTO RepairParts VALUES (@repairPart, @requestID)", conn))
            {
                cmd.Parameters.AddRange([
                    new ("@repairPart", repairPart),
                    new("@requestID", requestID),
                    ]);
                cmd.ExecuteNonQuery();
            }
        }

    }
    public Dictionary<int, string> GetAllSpecialists()
    {
        Dictionary<int, string> ret = new();
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("SELECT userID, fio FROM Users WHERE userTypeID = 2", conn))
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    ret.Add(reader.GetInt32(0), reader.GetString(1));

                return ret;
            }
        }
    }
    public void Delete(int requestID)
    {
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new("DELETE FROM Requests WHERE requestID = @requestID", conn))
            {
                cmd.Parameters.Add(new("@requestID", requestID));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
