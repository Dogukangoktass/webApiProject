﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage ="Title is a required field.")]
        [MinLength(2, ErrorMessage = "Title must consist of at least 2 character")]
        [MaxLength(50, ErrorMessage = "Title must consist of at max 50 character")]
        public String Title { get; init; }
        [Required(ErrorMessage = "Price is a required field.")]
        [Range(10,10000 )]
        public decimal Price { get; init; }
    }
}
