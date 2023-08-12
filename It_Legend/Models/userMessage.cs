namespace It_Legend.Models
{
    public class userMessage
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? purposeOfMessage { get; set; }
        public string senderEmail { get; set; } = null!;
        public string? message { get; set; }
    }
}
