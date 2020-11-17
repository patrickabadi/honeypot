using System;
using System.Collections.Generic;
using System.Text;

namespace honeypot.shared.Interfaces
{
    interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
    }
}
