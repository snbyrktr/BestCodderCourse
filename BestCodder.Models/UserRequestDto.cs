﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCodder.Models
{
    public class UserRequestDto
    {
        [Required(ErrorMessage ="email is required")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and confirm password is not matched")]
        public string ConfirmPassword { get; set; }
    }
}
