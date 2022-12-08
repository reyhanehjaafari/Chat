namespace ChatProject.Models
{
    public class Message
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }
    }
}
