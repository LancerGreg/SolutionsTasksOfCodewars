﻿using System;
using System.Collections.Generic;
using System.Text;

/*
 * A perfect power is a classification of positive integers:

    In mathematics, a perfect power is a positive integer that can be expressed as an integer power of another positive integer. More formally, n is a perfect power if there exist natural numbers m > 1, and k > 1 such that mk = n.

Your task is to check wheter a given integer is a perfect power. If it is a perfect power, return a pair m and k with mk = n as a proof. Otherwise return Nothing, Nil, null, NULL, None or your language's equivalent.

Note: For a perfect power, there might be several pairs. For example 81 = 3^4 = 9^2, so (3,4) and (9,2) are valid solutions. However, the tests take care of this, so if a number is a perfect power, return any pair that proves it.
Examples

IsPerfectPower(4) => (2,2)
IsPerfectPower(5) => null
IsPerfectPower(8) => (2,3)
IsPerfectPower(9) => (3,2)

*/

namespace SolutionsTasksOfCodewars.Tasks
{
    public class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            for (int i = (int)Math.Sqrt(n); i >= 2; i--)
            {
                if (Math.Pow(i, Convert.ToInt32(Math.Log(n, i))) == n)
                {
                    return (i, Convert.ToInt32(Math.Log(n, i)));
                }
            }
            return null;
        }
    }
}
