namespace TaskManagerAPI.Models
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


        // Navigation property
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
