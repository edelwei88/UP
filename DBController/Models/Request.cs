namespace DBController.Models
{
    public class Request
    {
        public readonly int requestID;
        public readonly DateTime startDate;
        public readonly string problemDescription;
        public readonly DateTime? completionDate;
        public readonly KeyValuePair<int, string> requestStatus;
        public readonly KeyValuePair<int, string> techType;
        public readonly KeyValuePair<int, string> techModel;
        public readonly KeyValuePair<int, string>? masterData;
        public readonly KeyValuePair<int, string> clientData;

        public Request(int requestID, DateTime startDate, string problemDescription, DateTime? completionDate, KeyValuePair<int, string> requestStatus, KeyValuePair<int, string> techType, KeyValuePair<int, string> techModel, KeyValuePair<int, string>? masterData, KeyValuePair<int, string> clientData)
        {
            this.requestID = requestID;
            this.startDate = startDate;
            this.problemDescription = problemDescription;
            this.completionDate = completionDate;
            this.requestStatus = requestStatus;
            this.techType = techType;
            this.techModel = techModel;
            this.masterData = masterData;
            this.clientData = clientData;
        }
    }
}
