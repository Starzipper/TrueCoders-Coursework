using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null || word == string.Empty || word.Trim().Length == 0)
            {
                return false;
            }
            string spacelessWord = "";
            foreach(char chars in word)
            {
                if (chars != ' ')
                {
                    spacelessWord += chars;
                }
            }
            string reversedWord = "";
            for (int i = spacelessWord.Length-1; i >= 0; i--)
            {
                reversedWord += spacelessWord[i];
            }
            if (spacelessWord.ToLower() == reversedWord.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}
