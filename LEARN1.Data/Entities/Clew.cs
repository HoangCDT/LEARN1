using LEARN1.Data.Enums;
using LEARN1.Data.Interfaces;
using LEARN1.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LEARN1.Data.Entities
{
    public class Clew : DomainEntity<int>, IHasOwner, ISwitchable, IDateTracking, IExtendFields
    {
        public Clew()
        {
            Numerals = new List<Numeral>();
        }

        public string ClewCode { get; set; }
        [StringLength(512)]
        public string ClewName { get; set; }
        public string Type { get; set; }

        public int? CreateBy { get; set; }
        public int? ModifiBy { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string s1 { get; set; }
        public string s2 { get; set; }
        public string s3 { get; set; }
        public decimal? n1 { get; set; }
        public decimal? n2 { get; set; }
        public decimal? n3 { get; set; }

        public virtual ICollection<Numeral> Numerals { get; set; }
    }
}
