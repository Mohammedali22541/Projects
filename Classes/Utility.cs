using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.Classes
{
    internal static class Utility
    {
       public static void Swap(ref ArrayList arr)
        {
            for (int i = 0; i < arr.Count / 2; i++)
            {
                object? temp = arr[i];
                arr[i] = arr[arr.Count -1 -  i];
                arr[arr.Count - 1 - i] = temp;
            }
        }


  
    }
}
