using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Data.Models
{
    public class TaskModel
    {
        [Key]
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public bool Iscomplete { get; set; }
    }
}
