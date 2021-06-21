using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeStructure
{
    public class TreeConstruct : ITreeConstruct
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;
            public string Container;
        }

        private int _nodeCount;

        public TreeNode SearchZeroNode(TreeNode node, int value = 0)
        {
            if (node is null)
                return null;

            if (value == node.Value)
                return node;

            var foundOnLeft = SearchZeroNode(node.Left, value);

            return foundOnLeft ?? SearchZeroNode(node.Right, value);
        }

        public string PredictZeroBallContainerLabel(uint depth)
        {
            var containerIndex = ZeroContainerIndex(depth);

            return LetterMapper.ConvertNumberToLetters(containerIndex);
        }

        public static long ZeroContainerIndex(uint depth)
        {
            long index;

            if (depth < 1)
                index = 1;
            else
            {
                if (depth % 2 != 0)
                {
                    index = (long)(Math.Pow(2, depth) + ZeroContainerIndex(depth - 1));
                }
                else
                {
                    depth -= 1;
                    index = (long)(Math.Pow(2, depth) + ZeroContainerIndex(depth - 1)) + 1;
                }
            }

            return index;
        }

        public TreeNode ConstructTree(List<int> values, int minValue, int maxValue, bool traverseRightFirst)
        {
            if (minValue == maxValue)
                return null;

            _nodeCount += 1;

            var midPoint = minValue + (maxValue - minValue) / 2;

            return new TreeNode
            {
                Container = LetterMapper.ConvertNumberToLetters(_nodeCount),
                Value = values[midPoint],
                Left = traverseRightFirst
                    ? ConstructTree(values, minValue, midPoint, !traverseRightFirst)
                    : ConstructTree(values, midPoint + 1, maxValue, !traverseRightFirst),
                Right = traverseRightFirst
                    ? ConstructTree(values, midPoint + 1, maxValue, !traverseRightFirst)
                    : ConstructTree(values, minValue, midPoint, !traverseRightFirst)
            };
        }

        public TreeNode ConstructTree(List<int> values, bool traverseRightFirst)
        {
            //values is ordered in ascending order to enable tree constructor create a perfectly balanced tree as the implementation requires.
            return ConstructTree(values.OrderBy(x => x).ToList(), 0, values.Count, traverseRightFirst);
        }
    }
}
