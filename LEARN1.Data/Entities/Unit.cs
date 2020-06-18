using LEARN1.Data.Enums;
using LEARN1.Data.Interfaces;
using LEARN1.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.Entities
{
    public class Unit : DomainEntity<int>, ISwitchable, IDateTracking, IHasOwner
    {
        public string UnitCode { get; set; }
        public string UnitName { get; set; }

        //ISwitch
        public Status Status { get; set; }
        //IDateTracking
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //IHasOwner
        public int? CreateBy { get; set; }
        public int? ModifiBy { get; set; }
    }
}
