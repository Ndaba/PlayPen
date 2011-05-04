using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    internal class Palindrome
    {
        public static bool IsPalindrome(string toTest)
        {
            // lets ignore the case of the string when testing if it is a palindrome (convert into lower case)
            // and any punctuation and spacing in the string.
            
            StringBuilder toTestWithoutSpacesAndPunctuationBuilder = new StringBuilder();
            foreach (char letter in toTest.ToLower())
            {
                if (char.IsLetter(letter))
                    toTestWithoutSpacesAndPunctuationBuilder.Append(letter);
            }

            string toTestAltered = toTestWithoutSpacesAndPunctuationBuilder.ToString();

            //#region Quick Way
            
            // /* 
            //  *   The Reverse extension method reverses the order of characters in the string and returns an IEnumerable<char>
            //  *   The static Concat method of the string class joins each character in a IEnumerable<char> to make a string
            // /*
            //  return (toTest == string.Concat(toTest.Reverse()));
            
            //#endregion

            #region Using a loop

            /* 
             * The for loop below creates a variable called idx, and while idx is less than half the length of toTestAltered.Length/2
             * we check to see if the character in the first half of the toTestAltered is equal to the character the corrosponding distance 
             * from the end of toTestAltered.
             * 
             * If they are not equal then the string is not a palindrome, we can return false.
             * If the for loop completes then there are no characters not equal inside the toTestAltered so
             * the word we are testing must be a palindrome.
             * 
             * If we were testing the word "anna", this is how the loop would execute
             * idx would start at 0; (idx = 0)
             * 
             * the if statement would be:
             *      (toTestAltered[0] != toTestAltered[4 - (0 + 1)]) //4 is the Length of "anna", remember the last index of a character is 1 less than the length of the string as the index starts at 0 not 1
             *  so after working out [4 - (0 + 1)]
             *  we have:
             *      (toTestAltered[0] != toTestAltered[3]) 
             *  
             *  0 1 2 3
             *  a n n a
             *  ^     ^
             *  
             *  we can see that the characters at index 0 and 3 are equal so now idx++ (idx is now 1)
             *  next the test idx < toTestAltered.Length / 2 (so is 1 < 4/2 => 1 < 2) this is true so do the loop again
             *  
             * the if statement would be:
             *      (toTestAltered[1] != toTestAltered[4 - (1 + 1)]) //4 is the Length of "anna", remember the last index of a character is 1 less than the length of the string as the index starts at 0 not 1
             *  so after working out [4 - (1 + 1)]
             *  we have:
             *      (toTestAltered[1] != toTestAltered[2])
             *      
             *  0 1 2 3
             *  a n n a
             *    ^ ^
             *   
             *  we can see that the characters at index 1 and 2 are equal so now idx++ (idx is now 2)
             *  
             *  next the test idx < toTestAltered.Length / 2 (so is 2 < 4/2 => 2 < 2) 2 is not smaller than 2
             *  so the loop now stops executing and moves the next set instructions.
             *  
             *  This means that true is now returned.
             */
            for (int idx = 0; idx < toTestAltered.Length / 2; idx++)
            {
                if (toTestAltered[idx] != toTestAltered[toTestAltered.Length - (idx + 1)])
                {
                    return false;
                }
            }

            return true;

            #endregion
        }
    }
}
