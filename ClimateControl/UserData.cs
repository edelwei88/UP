namespace ClimateControl
{
    public class UserData
    {
        public DateTime LoginDateTime { get; set; }
        public string Login { get; set; }
        public bool Result {get; set;}

        public UserData(DateTime dateTime, string login, bool result)
        {
            LoginDateTime = dateTime;
            Login = login;
            Result = result;
        }
    }
}
