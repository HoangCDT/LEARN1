using LEARN1.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
