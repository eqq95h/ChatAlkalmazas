namespace ChatAlkalmazas.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
    }
}