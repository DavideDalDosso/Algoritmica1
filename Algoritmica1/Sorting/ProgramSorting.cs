using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramSorting
{
    public static void Main(String[] args)
    {
        var array = new int[]{5,6,9,1,2,8,7,3,420,1337,21};

        int[] result;

        Console.WriteLine();
        Console.WriteLine("Clock Started!");

        var bubbleArray = DuplicateArray.Execute(array);

        var start = DateTime.Now;
        ///START STUFF

        BubbleSort.Sort( bubbleArray );

        ///END STUFF
        var end = DateTime.Now;
        Console.WriteLine("Clock Ended!");
        Console.WriteLine();

        //Console.WriteLine("Result: " + ArrayToString.Execute(bubbleArray) );
        Console.WriteLine("Result: " + bubbleArray[0]);
    }
}
