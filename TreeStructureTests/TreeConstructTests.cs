using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeStructure;
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
            var newTree = new TreeConstruct().ConstructTree(Enumerable.Range(0, 5).ToList());
            Assert.AreEqual(2, newTree.Value);
        }

        [TestMethod("SearchZeroNode")]
        public void SearchZeroNodeTest()
        {
            var newTree = new TreeConstruct().ConstructTree(Enumerable.Range(0, 7).ToList());

            var searchedNode = new TreeConstruct().SearchZeroNode(newTree);

            Assert.AreEqual(0, searchedNode.Value);
        }

        [TestMethod("SearchNonZeroNode")]
        public void SearchNonZeroNodeTest()
        {
            var newTree = new TreeConstruct().ConstructTree(Enumerable.Range(0, 5).ToList());

            var searchedNode = new TreeConstruct().SearchZeroNode(newTree, 2);

            Assert.AreEqual(2, searchedNode.Value);
        }
    }
}