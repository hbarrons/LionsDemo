namespace LionsDemo.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public bool Deleted { get; set; }
    }
}
