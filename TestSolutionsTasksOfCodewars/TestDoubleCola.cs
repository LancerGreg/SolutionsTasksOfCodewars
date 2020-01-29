using NUnit.Framework;
using SolutionsTasksOfCodewars.Tasks;
using System;

namespace TestSolutionsTasksOfCodewars
{
    [TestFixture]
    public class TestDoubleCola
    {
        [Test]
        public void Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }
        
        [Test]
        public void Test3()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Penny", DoubleCola.WhoIsNext(names, 52));
        }
        
        [Test]
        public void Test4()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Leonard", DoubleCola.WhoIsNext(names, 7230702951));
        }
    }
}
