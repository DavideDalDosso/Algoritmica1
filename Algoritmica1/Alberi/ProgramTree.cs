using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramTree
{
    public static void Main(string[] args)
    {
        BinaryTree<int> tree = new BinaryTree<int>();

        tree.Add(6);
        tree.Add(9);
        tree.Add(4);
        tree.Add(2);
        tree.Add(0);
        tree.Add(-1);
        tree.Add(7);

        Console.Out.WriteLine(tree.ToString());
    }
}
