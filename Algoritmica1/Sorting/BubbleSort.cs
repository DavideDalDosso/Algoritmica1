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
        bool sorted = true;
        int index = 1;
        int startIndex = 1;
        while (!sorted)
        {
            sorted = true;
            for(int i = 1; i < arr.Length-1; i++)
            {
                if (arr[index-1].CompareTo( arr[index] ) == -1)//MODIFY LATER FOR ASC/DESC
                {
                    Swap.Execute(ref arr[index-1], ref arr[index]);
                    if (sorted)
                    {
                        startIndex = index + 1;
                        sorted = false;
                    }
                }
            }
            index = startIndex;
        }

        return arr;
    }
}
