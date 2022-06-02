﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(0, 25, ErrorMessage = "The default amount of days must be between 0 and 25.")]
        public int DefaultDays { get; set; }
    }
}
