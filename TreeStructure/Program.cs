using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace TreeStructure
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Specify depth in numbers only:");
                var depth = Convert.ToUInt32(Console.ReadLine());

                if (depth > 0)
                {
                    var leafNodes = (int) Math.Pow(2, Convert.ToDouble(depth));
                    var totalNodes = leafNodes + (leafNodes - 1);

                    var balls = leafNodes - 1;
                    Console.WriteLine($"Implying that {balls} balls will run thru a Tree Structure, and settle in {leafNodes} leaf nodes or containers.\r\n");

                    Console.WriteLine($"One of those {leafNodes} will contain a ball with zero value. Let's find out who...\r\n");

                    var nodeValues = Enumerable.Range(0, totalNodes).ToList();

                    var traverseRightFirst = depth % 2 == 0;

                    var newTree = new TreeConstruct().ConstructTree(nodeValues, traverseRightFirst);

                    Console.WriteLine(
                        $"Constructed Tree Structure in JSON format:\r\n{JsonConvert.SerializeObject(newTree, Formatting.Indented)}\r\n");

                    var predictedZeroContainer = TreeConstruct.PredictZeroBallContainerLabel(depth);

                    Console.WriteLine($"Predicted container with zero ball value is {predictedZeroContainer}.\r\n");

                    var searchedNode = new TreeConstruct().SearchZeroNode(newTree);

                    Console.WriteLine($"Verified container with zero ball value is labeled {searchedNode.Container}.");
                }
                else
                {
                    Console.WriteLine($"Depth of {depth} is not a valid depth.");
                }

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
