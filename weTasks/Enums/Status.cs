using System.ComponentModel;

namespace weTasks.Enums
{
    public enum Status
    {
        [Description("To Do")]
        ToDo = 0,
        [Description("In Progress")]
        InProgress = 1,
        [Description("Done")]
        Done = 2
    }
}
