using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, wouldn't we? Our goal is to create a function that will check that for us!

Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:

[[0, 0, 1],
 [0, 1, 2],
 [2, 1, 0]]

We want our function to return:

    -1 if the board is not yet finished (there are empty spots),
    1 if "X" won,
    2 if "O" won,
    0 if it's a cat's game (i.e. a draw).

You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe.

 */

namespace SolutionsTasksOfCodewars.Tasks
{
    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            var comb = new int[] { 0, 1, 2 };
            var res = string.Join(",", comb.Select(x => string.Join("", comb.Select(y => board[x, y])))) + ","
                 + string.Join(",", comb.Select(x => string.Join("", comb.Select(y => board[y, x])))) + ","
                 + string.Join("", comb.Select(x => board[x, x])) + ","
                 + string.Join("", comb.Select(x => board[2 - x, x]));

            return res.Contains("111") ? 1 : res.Contains("222") ? 2 : !res.Contains("0") ? 0 : -1;
        }
    }
}
