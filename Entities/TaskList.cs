using System.ComponentModel.DataAnnotations;
using Web.Entities;

namespace Web.Models
{
    public class TaskList
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
