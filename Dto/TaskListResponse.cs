using System.ComponentModel.DataAnnotations;
using Web.Entities;

namespace Web.Dto
{
    public class TaskListResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
