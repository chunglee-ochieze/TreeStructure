using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TreeStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Specify depth in numbers only:");
                var depth = Convert.ToUInt32(Console.ReadLine());

                var children = (int)Math.Pow(2, Convert.ToDouble(depth));
                var parents = children - 1;
                var family = children + parents;
                var familyList = Enumerable.Range(0, family).ToList();

                var newTree = new TreeConstruct().ConstructTree(familyList);

                Console.WriteLine("Predicted container with zero ball value is labeled A0, which is the left-most child node of the balanced tree.");

                var searchedNode = new TreeConstruct().SearchZeroNode(newTree);

                Console.WriteLine($"Verified container with zero ball value is labeled {searchedNode.Label}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
