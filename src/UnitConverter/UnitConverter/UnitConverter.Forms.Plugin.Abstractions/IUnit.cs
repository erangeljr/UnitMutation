using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Forms.Plugin.Abstractions
{
    public interface IUnit<T> where T : IQuantity<T>
    {
        IDimension getDimension();
        IUnit<T> getSystemUnit();
        //Map<? extends Unit<?>, Integer> getProductUnits();

        bool isCompatible(IUnit<T> that);
    }
}
