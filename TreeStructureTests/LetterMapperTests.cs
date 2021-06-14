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
    public class LetterMapperTests
    {
        [TestMethod("MapZero")]
        public void ConvertNumberToLettersTestZero()
        {
            var number = 0;
            var letter = LetterMapper.ConvertNumberToLetters(number);
            Assert.AreEqual("", letter);
        }

        [TestMethod("MapOne")]
        public void ConvertNumberToLettersTestOne()
        {
            var number = 1;
            var letter = LetterMapper.ConvertNumberToLetters(number);
            Assert.AreEqual("A", letter);
        }

        [TestMethod("MapTwentySix")]
        public void ConvertNumberToLettersTestTwentySix()
        {
            var number = 26;
            var letter = LetterMapper.ConvertNumberToLetters(number);
            Assert.AreEqual("Z", letter);
        }

        [TestMethod("MapEightySeven")]
        public void ConvertNumberToLettersTestEightySeven()
        {
            var number = 87;
            var letter = LetterMapper.ConvertNumberToLetters(number);
            Assert.AreEqual("CI", letter);
        }
    }
}