using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Interfaces
{
    public interface IExtendFields
    {
        string s1 { get; set; }
        string s2 { get; set; }
        string s3 { get; set; }
        decimal? n1 { get; set; }
        decimal? n2 { get; set; }
        decimal? n3 { get; set; }
    }
}
