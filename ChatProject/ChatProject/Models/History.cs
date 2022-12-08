namespace ChatProject.Models
{
    public class History
    {
        public int Id { get; set; }
        public Message message { get; set; }
        public User user { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
