using honeypot.data.shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace honeypot.shared.Interfaces
{
    interface IUser: IEntityBase
    {
        string Username { get; set; }
        string First { get; set; }
        string Last { get; set; }
        string Email { get; set; }
        UserType Type { get; set; }

    }
}
