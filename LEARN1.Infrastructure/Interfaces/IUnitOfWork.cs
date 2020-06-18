using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Infrastructure.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {/// <summary>
    /// 
    /// </summary>
        void Commit();
    }
}
