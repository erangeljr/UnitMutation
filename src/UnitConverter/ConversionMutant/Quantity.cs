using System;

namespace ConversionMutant
{
    /// <summary>
    ///     Base Class that represents a quantity with a specific amount and unit
    /// </summary>
    /// <typeparam name="TAmount">Amount value type and implement IComparable</typeparam>
    /// <typeparam name="TUnit">Type of Unit</typeparam>
    /// <remarks>
    ///     Follows the analysis pattern quantity descsribed by Martin Fowler
    /// </remarks>
    public abstract class Quantity<TAmount, TUnit> : IComparable, IComparable<Quantity<TAmount, TUnit>>,
        IEquatable<Quantity<TAmount, TUnit>>
        where TAmount : struct, IComparable
    {
        /// <summary>
        ///     Gets the amount
        /// </summary>
        public TAmount Amount { get; }

        /// <summary>
        ///     Gets the unit
        /// </summary>
        public TUnit Unit { get; }

        /// <summary>
        ///     Initializes a new Quantity with a specified amount and unit
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="unit">The unit</param>
        /// <exception cref="ArgumentNullException">unit is null</exception>
        protected Quantity(TAmount amount, TUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            Amount = amount;
            Unit = unit;
        }

 

        /// <summary>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Quantity<TAmount, TUnit> quantity = obj as Quantity<TAmount, TUnit>;
            if (quantity == null)
            {
                throw new ArgumentException(string.Format("Object must be of type {0}",
                    typeof (Quantity<TAmount, TUnit>)));
            }

            return Compare(this, quantity);
        }

        /// <summary>
        /// </summary>
        /// <param name="rightQuantity"></param>
        /// <returns></returns>
        public int CompareTo(Quantity<TAmount, TUnit> rightQuantity)
        {
            return CompareTo(rightQuantity.Amount);
        }

        /// <summary>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Quantity<TAmount, TUnit> other)
        {
            return AreEqual(this, other);
        }

        /// <summary>
        ///     Compares two Quantities. An implementation of this method must return a
        /// </summary>
        /// <param name="leftQuantity"></param>
        /// <param name="rightQuantity"></param>
        /// <returns></returns>
        private static int Compare(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> rightQuantity)
        {
            if (!leftQuantity.Unit.Equals(rightQuantity.Unit))
            {
                throw new Exception("Quantities must have equal units");
            }
            return leftQuantity.Amount.CompareTo(rightQuantity.Amount);
        }

        /// <summary>
        ///     Returns a string representation of this instance
        /// </summary>
        /// <returns>string representation</returns>
        public override string ToString()
        {
            return string.Format(@"{Amount} {Unit}");
        }

        /// <summary>
        ///     Returns the hash code for this instance
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            var type = GetType();

            return string.Format("{0}: {1}", type, ToString()).GetHashCode();
        }

        /// <summary>
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public override bool Equals(object right)
        {
            Quantity<TAmount, TUnit> quantity = right as Quantity<TAmount, TUnit>;
            if (quantity == null)
                return false;

            if (object.ReferenceEquals(this, quantity))
                return true;

            if (this.GetType() != quantity.GetType())
                return false;

            return AreEqual(this, quantity);
        }

        private static bool AreEqual(Quantity<TAmount, TUnit> quantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return quantity.Amount.Equals(righQuantity.Amount) && quantity.Unit.Equals(righQuantity.Unit);
        }


        #region Overloaded Operators

        public static bool operator ==(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return AreEqual(leftQuantity, righQuantity);
        }

        public static bool operator !=(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return !(leftQuantity == righQuantity);
        }

        public static bool operator >(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return Compare(leftQuantity, righQuantity) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftQuantity"></param>
        /// <param name="righQuantity"></param>
        /// <returns></returns>
        public static bool operator <(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return Compare(leftQuantity, righQuantity) < 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftQuantity"></param>
        /// <param name="righQuantity"></param>
        /// <returns></returns>
        public static bool operator >=(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return Compare(leftQuantity, righQuantity) >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="leftQuantity"></param>
        /// <param name="righQuantity"></param>
        /// <returns></returns>
        public static bool operator <=(Quantity<TAmount, TUnit> leftQuantity, Quantity<TAmount, TUnit> righQuantity)
        {
            return Compare(leftQuantity, righQuantity) <= 0;
        }

        #endregion

    }
}