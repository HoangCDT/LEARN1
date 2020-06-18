using LEARN1.Data.Entities;
using LEARN1.Data.IRepositoties;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.EF.Repositories
{
    public class ClewRepository : EFRepository<Clew, int>, IClewRepository
    {
       
        public ClewRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
