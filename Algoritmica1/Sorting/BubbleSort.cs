using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

static class BubbleSort
{
    public static T[] Sort<T>(T[] arr) where T : IComparable<T>
    {
        bool sorted = false;
        int index = 1;
        while (!sorted)
        {
            //Console.WriteLine("Array: " + ArrayToString.Execute(arr));
            sorted = true;
            for(int i = index; i < arr.Length; i++)
            {
                if (arr[i-1].CompareTo( arr[i] ) == 1)//MODIFY LATER FOR ASC/DESC
                {
                    Swap.Execute(ref arr[i-1], ref arr[i]);
                    sorted = false;
                }
            }
        }

        return arr;
    }
}
