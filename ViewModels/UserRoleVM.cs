﻿using System.ComponentModel.DataAnnotations;

namespace WebSec3_IPN.ViewModels
{
    public class UserRoleVM
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
