using honeypot.entities.shared.Enums;
using honeypot.entities.shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CrossSync.Entity;

namespace honeypot.entities.shared.Models
{
    public class User:VersionableEntity
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
