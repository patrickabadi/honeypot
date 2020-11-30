using CrossSync.Entity;
using honeypot.entities.shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace honeypot.entities.shared.Interfaces
{
    interface IUser: IVersionableEntity
    {
        string Username { get; set; }
        string First { get; set; }
        string Last { get; set; }
        string Email { get; set; }
        UserType Type { get; set; }

    }
}
