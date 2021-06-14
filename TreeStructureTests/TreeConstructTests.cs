using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Tests
{
    [TestClass]
    public class TreeConstructTests
    {
        [TestMethod("TreeConstruct")]
        public void ConstructTreeTest()
        {
            var depth = 2;

            var leafNodes = (int)Math.Pow(2, Convert.ToDouble(depth));
            var totalNodes = leafNodes + (leafNodes - 1);
            var nodeValues = Enumerable.Range(0, totalNodes).ToList();

            var traverseRightFirst = depth % 2 == 0;

            var newTree = new TreeConstruct().ConstructTree(nodeValues, traverseRightFirst);
            Assert.AreEqual(3, newTree.Value);
            Assert.AreEqual("A", newTree.Container);
            Assert.AreEqual(0, newTree.Left.Right.Value);
            Assert.AreEqual("D", newTree.Left.Right.Container);
        }

        [TestMethod("SearchZeroNode")]
        public void SearchZeroNodeTest()
        {
            var depth = 2;

            var children = (int)Math.Pow(2, Convert.ToDouble(depth));
            var family = children + (children - 1);
            var familyList = Enumerable.Range(0, family).ToList();

            var normalTraverse = depth % 2 == 0;

            var newTree = new TreeConstruct().ConstructTree(familyList, normalTraverse);

            var searchedNode = new TreeConstruct().SearchZeroNode(newTree);

            Assert.AreEqual(0, searchedNode.Value);
        }

        [TestMethod("SearchNonZeroNode")]
        public void SearchNonZeroNodeTest()
        {
            var depth = 2;

            var children = (int)Math.Pow(2, Convert.ToDouble(depth));
            var family = children + (children - 1);
            var familyList = Enumerable.Range(0, family).ToList();

            var normalTraverse = depth % 2 == 0;

            var newTree = new TreeConstruct().ConstructTree(familyList, normalTraverse);

            var searchedNode = new TreeConstruct().SearchZeroNode(newTree, 2);

            Assert.AreEqual(2, searchedNode.Value);
        }

        [TestMethod("PredictZeroBallContainer2")]
        public void PredictZeroBallContainer2()
        {
            var depth = 2U;

            var containerLabel = TreeConstruct.PredictZeroBallContainerLabel(depth);

            Assert.AreEqual("D", containerLabel);
        }

        [TestMethod("PredictZeroBallContainer0")]
        public void PredictZeroBallContainer0()
        {
            var depth = 0U;

            var containerLabel = TreeConstruct.PredictZeroBallContainerLabel(depth);

            Assert.AreEqual("A", containerLabel);
        }

        [TestMethod("PredictZeroBallContainer3")]
        public void PredictZeroBallContainer3()
        {
            var depth = 3U;

            var containerLabel = TreeConstruct.PredictZeroBallContainerLabel(depth);

            Assert.AreEqual("L", containerLabel);
        }

        [TestMethod("PredictZeroBallContainer7")]
        public void PredictZeroBallContainer7()
        {
            var depth = 7U;

            var containerLabel = TreeConstruct.PredictZeroBallContainerLabel(depth);

            Assert.AreEqual("FR", containerLabel);
        }

        [TestMethod("PredictZeroBallContainer60")]
        public void PredictZeroBallContainer60()
        {
            var depth = 60U;

            var containerLabel = TreeConstruct.PredictZeroBallContainerLabel(depth);

            Assert.AreEqual("HAJRNAPCZZVHI", containerLabel);
        }

        [TestMethod("ZeroContainerIndex")]
        public void ZeroContainerIndex()
        {
            var depth = 8U;

            var containerIndex = TreeConstruct.ZeroContainerIndex(depth);

            Assert.AreEqual(175, containerIndex);
        }
    }
}