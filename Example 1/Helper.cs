using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.Example_1
{
    internal static class Helper<T> where T : IEquatable<T>
    {
        #region Generic Method
        #region Swap
        //public static void Swap<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region Linear Search
        public static int LinearSearch(T[] arr, T value)
        {
            if (arr.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value.Equals(arr[i]))
                    {
                        return i;
                    }

                }
            }
            return -1;
        }

        public static int LinearSearch(T[] arr, T value , IEqualityComparer<T> comparer)
        {
            if (arr.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (comparer.Equals(arr[i] , value))
                    {
                        return i;
                    }

                }
            }
            return -1;
        }

     


        #endregion

        #endregion


        #region Non Generic Method
        #region Swap
        //public static void Swap(ref decimal x , ref decimal  y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref Point  x,ref  Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}  
        #endregion

        #region Linear Search
        //public static int LinearSearch(int[] arr, int value)
        //{
        //    if (arr.Length>0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //            {
        //                return i; 
        //            }

        //        }       
        //    }
        //        return -1;
        //}



        #endregion
        #endregion




    }
}
