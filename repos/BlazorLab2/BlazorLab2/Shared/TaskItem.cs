using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorLab2.Shared
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
    }
}
