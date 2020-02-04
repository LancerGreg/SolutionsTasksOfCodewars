using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using System;
using SolutionsTasksOfCodewars.Tasks;

namespace TestSolutionsTasksOfCodewars
{
    [TestFixture]
    public class TestKataFirstNonRepeatingLetter
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("a", Kata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Kata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Kata.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("T", Kata.FirstNonRepeatingLetter("sTreSS"));
        }
    }
}

