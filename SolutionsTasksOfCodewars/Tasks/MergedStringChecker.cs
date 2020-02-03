using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SolutionsTasksOfCodewars.Tasks
{
    public class MergedStringChecker
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            bool empty1 = part1.Length == 0,
                 empty2 = part2.Length == 0,
                 works1 = false,
                works2 = false;

            if (s.Length == 0)
            {
                if (part1.Length == 0 && part2.Length == 0) return true;
                return false;
            }
            else
            {
                if (!empty1 && s[0] == part1[0]) works1 = isMerge(s.Substring(1), part1.Substring(1), part2);
                if (!empty2 && s[0] == part2[0]) works2 = isMerge(s.Substring(1), part1, part2.Substring(1));
                return works1 || works2;
            }
        }
    }
}
