using System;
using System.Collections.Generic;
using System.Linq;

namespace SolutionsTasksOfCodewars.Tasks
{
    public class Kata
    {

        /*
         * What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

        'abba' & 'baab' == true

        'abba' & 'bbaa' == true

        'abba' & 'abbba' == false

        'abba' & 'abca' == false

        Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

        anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

        anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

        anagrams('laser', ['lazing', 'lazy',  'lacer']) => []


         */

        public static List<string> Anagrams(string word, List<string> words)
        {
            return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
        }

        /*
         * Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.

         */

        public static string FirstNonRepeatingLetter(string s)
        {
            var result = s.GroupBy(c => char.ToLower(c)).Where(g => g.Count() == 1).FirstOrDefault();
            return (result != null) ? result.First().ToString() : string.Empty;
        }
    }
}
