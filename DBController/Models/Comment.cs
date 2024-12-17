namespace DBController.Models
{
    public class Comment
    {
        public string Message { get; set; }
        public int RequestID { get; set; }

        public Comment(string message, int requestID)
        {
            Message = message;
            RequestID = requestID;
        }
    }
}
