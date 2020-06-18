using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
