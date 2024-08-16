using weTasks.Enums;

namespace weTasks.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Status IsComplete { get; set; }
        public int UserId { get; set; }
    }
}
