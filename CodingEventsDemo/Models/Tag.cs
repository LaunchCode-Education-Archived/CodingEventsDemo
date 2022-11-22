﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters long")]
        public string Name { get; set; }

        public Tag(string name)
        {
            Name = name;
        }

        public Tag()
        {
        }
    }
}

