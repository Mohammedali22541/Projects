using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.Classes
{
    internal class Range<T> where T : INumber<T>, IComparable<T>
    {
        #region Properties
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        #endregion

        #region Constructors
 

        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }




        #endregion
        #region Methods
        public bool IsInRange(T value)
        {
             return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
            
        }
        public T Length()
        {
          return Maximum - Minimum;
        }
        #endregion
    }
    }
