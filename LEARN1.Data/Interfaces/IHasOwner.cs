using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface IHasOwner
    {
        int? CreateBy { set; get; }
        int? ModifiBy { set; get; }
    }
}
