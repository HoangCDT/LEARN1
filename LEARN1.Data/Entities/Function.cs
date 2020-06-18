using LEARN1.Data.Enums;
using LEARN1.Data.Interfaces;
using LEARN1.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Entities
{
    public class Function: DomainEntity<int>, ISwitchable, ISortable
    {
       
        public string Name { get; set; }
        public string URL { get; set; }
        public string ParentId { get; set; }
        public string Icon { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}
