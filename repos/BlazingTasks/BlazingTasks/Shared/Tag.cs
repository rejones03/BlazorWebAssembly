using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazingTasks.Shared
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(10, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 3)]
        public string TagName { get; set; }

        [Required]
        [Display(Name = "Color")]
        public string TagColor { get; set; }
    }
}
