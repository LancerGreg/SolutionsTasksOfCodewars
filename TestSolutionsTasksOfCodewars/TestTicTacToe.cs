using System;
using NUnit.Framework;
using SolutionsTasksOfCodewars.Tasks;

namespace TestSolutionsTasksOfCodewars
{
	[TestFixture]
	public class TestTicTacToe
	{
		private TicTacToe tictactoe = new TicTacToe();

		[Test]
		public void test1()
		{
			int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
			Assert.AreEqual(1, tictactoe.IsSolved(board));
		}
		[Test]
		public void test2()
		{
			int[,] board = new int[,] { { 2, 2, 2 }, { 0, 1, 1 }, { 1, 0, 0 } };
			Assert.AreEqual(2, tictactoe.IsSolved(board));
		}
		[Test]
		public void test3()
		{
			int[,] board = new int[,] { { 0, 1, 1 }, { 2, 0, 2 }, { 2, 1, 0 } };
			Assert.AreEqual(-1, tictactoe.IsSolved(board));
		}
	}
}
