using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfaces
{
    internal interface IgenericMath<T>

    {
        T add(T x, T y);
        T Multiply(T x, T y);
    }
    class Math<T> : IgenericMath<T>
    {
        public T add(T x, T y)
        {
            throw new NotImplementedException();
        }

        public T Multiply(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}
