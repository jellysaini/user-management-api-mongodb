namespace UserManagementAPI.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();  // Automatically generate a unique identifier
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
