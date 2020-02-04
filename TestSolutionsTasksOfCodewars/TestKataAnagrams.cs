using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolutionsTasksOfCodewars
{
    using NUnit.Framework;
    using SolutionsTasksOfCodewars.Tasks;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class TestKataAnagrams
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "a" }, Kata.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
            Assert.AreEqual(new List<string> { "aabb", "bbaa" }, Kata.Anagrams("abba", new List<string> { "aabb", "abcd", "bbaa", "dada" }));
            Assert.AreEqual(new List<string>(), Kata.Anagrams("laser", new List<string> { "lazing", "lazy", "lacer" }));
        }
    }
}
