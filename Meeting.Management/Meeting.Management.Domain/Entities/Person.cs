namespace Meeting.Management.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Level Level { get; set; }
    }
}
