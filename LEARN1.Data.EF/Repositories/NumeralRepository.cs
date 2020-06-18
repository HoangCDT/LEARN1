using LEARN1.Data.Entities;
using LEARN1.Data.IRepositoties;
using LEARN1.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Data.EF.Repositories
{
    public class NumeralRepository : EFRepository<Numeral, int>, INumeralRepository
    {
        public NumeralRepository(AppDbContext context) : base(context)
        {
        }
    }
}
