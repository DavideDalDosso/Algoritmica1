﻿using System;
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
        tree.Add(4);
        tree.Add(5);
        tree.Add(9);
        tree.Add(8);
        tree.Add(10);
        tree.Add(11);

        Console.Out.WriteLine(tree.ToString());
    }
}
