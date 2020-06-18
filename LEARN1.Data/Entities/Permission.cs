using LEARN1.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LEARN1.Data.Entities
{
    [Table("Permissions")]
    public class Permission : DomainEntity<int>
    {
        [Required]
        public Guid RoleId{ get; set; }
        public string FunctionId { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate{ get; set; }
        public bool CanDelete { get; set; }
        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
    }
}
