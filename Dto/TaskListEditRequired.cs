using Web.Entities;

namespace Web.Dto
{
    public class TaskListEditRequired
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Status Status { get; set; }
    }
}
