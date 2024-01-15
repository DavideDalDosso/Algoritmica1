using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    public static T[] Sort<T>(T[] arr) where T : IComparable<T>
    {
        return Sort(arr, 0, arr.Length);
    }
    private static T[] Sort<T>(T[] arr, int start, int bound) where T : IComparable<T>
    {
        if (arr.Length < 2) return arr;

        int index = 1;
        int swapIndex = 0;

        T pivot = arr[arr.Length-1];
        while(index < arr.Length)
        {
            Console.WriteLine("Array: " + ArrayToString.Execute(arr));
            if (arr[index].CompareTo( pivot ) == -1)
            {
                Swap.Execute(ref arr[swapIndex], ref arr[index]);
                index++;
            }
            else
            {
                swapIndex++;
            }
        }

        return arr;
    }
}
