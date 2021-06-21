using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreeStructure.TreeConstruct;

namespace TreeStructure
{
    interface ITreeConstruct
    {
        TreeNode SearchZeroNode(TreeNode node, int value = 0);

        string PredictZeroBallContainerLabel(uint depth);

        TreeNode ConstructTree(List<int> values, int minValue, int maxValue, bool traverseRightFirst);

        TreeNode ConstructTree(List<int> values, bool traverseRightFirst);
    }
}
