using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class TreeConstruct
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;
            public string Label;
        }

        public TreeNode SearchZeroNode(TreeNode node, int value = 0)
        {
            if (node is null)
                return null;

            return value == node.Value ? node : SearchZeroNode(node.Left, value);
        }

        public TreeNode ConstructTree(List<int> values, int minValue, int maxValue)
        {
            if (minValue == maxValue)
                return null;

            var midPoint = minValue + (maxValue - minValue) / 2;

            return new TreeNode
            {
                Value = values[midPoint],
                Left = ConstructTree(values, minValue, midPoint),
                Right = ConstructTree(values, midPoint + 1, maxValue),
                Label = LetterMapper.ConvertNumberToLetters(values[midPoint])
            };
        }

        public TreeNode ConstructTree(List<int> values)
        {
            //values is ordered in ascending order to enable tree constructor create a perfectly balanced tree as the implementation requires.
            return ConstructTree(values.OrderBy(x => x).ToList(), 0, values.Count);
        }
    }
}
