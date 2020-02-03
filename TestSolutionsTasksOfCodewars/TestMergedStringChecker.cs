using System;
using NUnit.Framework;
using SolutionsTasksOfCodewars.Tasks;

namespace TestSolutionsTasksOfCodewars
{
    [TestFixture]
    public class TestMergedStringChecker
    {
		[Test]
		public void HappyPath1()
		{
			Assert.IsTrue(MergedStringChecker.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
		}

		[Test]
		public void HappyPath2()
		{
			Assert.IsTrue(MergedStringChecker.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
		}

		[Test]
		public void SadPath1()
		{
			Assert.IsFalse(MergedStringChecker.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
		}
	}
}
