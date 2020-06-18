using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
