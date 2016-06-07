using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[13] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            TreeNode root = TreeNode.CreateMinimalBST(array);
            Console.WriteLine(root.getValue());
        }

        
    }
}
