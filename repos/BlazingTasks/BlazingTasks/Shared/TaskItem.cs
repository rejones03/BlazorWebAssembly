using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazingTasks.Shared
{
    public class TaskItem
    {
        public const Priority DefaultPriority = Priority.Low;
        public const Priority MinimumPriority = Priority.Low;
        public const Priority MaximumPriority = Priority.High;

        public int TaskItemId { get; set; }
        public Guid UserId { get; set; }

        [Required]
        [Display(Name = "Name")] 
        public string TaskName { get; set; }

        public bool IsComplete { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Priority Priority { get; set; }
        public int? Hours { get; set; }
        public string Notes { get; set; }
        public List<TaskTag> Tags { get; set; }

        public bool IsNew()
        {
            return TaskItemId == 0;
        }
    }
}
