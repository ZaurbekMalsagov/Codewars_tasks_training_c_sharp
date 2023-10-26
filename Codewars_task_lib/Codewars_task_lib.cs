using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_task_lib
{
    public  class CodewarsLib
    {

        /*
         Create a function which answers the question "Are you playing banjo?".
         If your name starts with the letter "R" or lower case "r", you are playing banjo!
         The function takes a name as its only argument, and returns one of the following strings
         */
        public static string AreYouPlayingBanjo(string name) {
            string result = string.Empty;
            char[] name_array = name.ToCharArray();
            //Implement me
            if ((char.ToLower(name_array[0])) == 'r') {
                result = name + " plays banjo";
            }
            else {
                result = name + " does not play banjo";
            }
            return result;
        }


        /*
           This function should test if the factor is a factor of base.
           Return true if it is a factor or false if it is not.
           About factors
           Factors are numbers you can multiply together to get another number.
           2 and 3 are factors of 6 because: 2 * 3 = 6
           You can find a factor by dividing numbers. If the remainder is 0 then the number is a factor.
           You can use the mod operator (%) in most languages to check for a remainder
           For example 2 is not a factor of 7 because: 7 % 2 = 1
           Note: base is a non-negative number, factor is a positive number.
         */
        public static bool CheckForFactor(int num, int factor) {
            bool result;
            if (num % factor == 0) {
                result = true;
            }
            else {
                result = false;
            }
            return result;
        }


    }
}
