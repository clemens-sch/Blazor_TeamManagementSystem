namespace TeamManagement.Shared
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position EPosition { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
    }
}