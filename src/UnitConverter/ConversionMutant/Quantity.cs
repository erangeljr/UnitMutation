using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMutant
{
    /// <summary>
    /// Base Class
    /// </summary>
    /// <typeparam name="TAmount"></typeparam>
    /// <typeparam name="TUnit"></typeparam>
    public abstract class Quantity<TAmount, TUnit> : IComparable, IComparable<Quantity<TAmount, TUnit>>,
         IEquatable<Quantity<TAmount, TUnit>>
        where TAmount : struct, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Quantity<TAmount, TUnit> other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Quantity<TAmount, TUnit> other)
        {
            throw new NotImplementedException();
        }
    }
}
