using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
