using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SolutionsTasksOfCodewars.Tasks;

namespace TestSolutionsTasksOfCodewars
{
    [TestFixture]
    public class TestRankingSystem
    {
        [Test]
        public void MyTest1()
        {
            User user = new User();
            user.incProgress(-7);
            Assert.AreEqual(10, user.Progress);
            Assert.AreEqual(-8, user.Rank);
        }

        [Test]
        public void MyTest2()
        {
            User user = new User();
            user.incProgress(-5);
            Assert.AreEqual(90, user.Progress);
            Assert.AreEqual(-8, user.Rank);
        }

        [Test]
        public void MyTest3()
        {
            User user = new User();
            user.incProgress(-7);
            user.incProgress(-5);
            Assert.AreEqual(0, user.Progress);
            Assert.AreEqual(-7, user.Rank);
        }


    }
}
