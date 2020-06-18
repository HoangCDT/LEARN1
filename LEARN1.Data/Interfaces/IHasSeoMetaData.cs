using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { get; set; }
        string SeoALias { get; set; }
        string SeoKeyWords{ get; set; }
        string SeoDescription { get; set; } 
    }
}
