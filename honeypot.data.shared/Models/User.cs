using honeypot.data.shared.Enums;
using honeypot.shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace honeypot.shared.Models
{
    public class User:EntityBase, IUser
    {
        [Required]
        public string Username { get; set; }

        [MaxLength(256)]
        public string First { get; set; }

        [MaxLength(256)]
        public string Last { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public UserType Type { get; set; }
    }
}
