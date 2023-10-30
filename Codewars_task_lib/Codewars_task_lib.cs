using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_task_lib {
    public class CodewarsLib {

        /*
         * Create a function which answers the question "Are you playing banjo?".
         * If your name starts with the letter "R" or lower case "r", you are playing banjo!
         * The function takes a name as its only argument, and returns one of the following strings
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
         * This function should test if the factor is a factor of base.
         * Return true if it is a factor or false if it is not.
         * About factors
         * Factors are numbers you can multiply together to get another number.
         * 2 and 3 are factors of 6 because: 2 * 3 = 6
         * You can find a factor by dividing numbers. If the remainder is 0 then the number is a factor.
         * You can use the mod operator (%) in most languages to check for a remainder
         * For example 2 is not a factor of 7 because: 7 % 2 = 1
         * Note: base is a non-negative number, factor is a positive number.
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


        /*
         * Your task is to create a function that does four basic mathematical operations.
         * The function should take three arguments - operation(string/char), value1(number), value2(number).
         * The function should return result of numbers after applying the chosen operation.
        */
        public static double basicOp(char operation, double value1, double value2) {
            double result;
            switch (operation) {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }

        /*Write a function that removes the spaces from the string, then return the resultant string.*/
        public static string NoSpace(string input) {
            char[] input_array = input.ToCharArray();
            char[] output_array = new char[input_array.Length];
            int i = 0;
            foreach(char c in input_array) {
                if (c!= ' ') {
                    output_array[i] = c;
                    i++;
                }
            }
            string result = new string(output_array, 0, i);
            return result;
        }

        public static bool Solution(string str, string ending) {  
            return str.EndsWith(ending);
        }
        /*
         * Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. 
         * You can guarantee that input is non-negative.
         * Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
         */

        public static int CountBits(int n) {
            string bits = Convert.ToString(n, 2);
            char [] bits_array = bits.ToCharArray();
            int counter = 0;
            foreach(char c in bits_array) {
                if (c == '1') {
                    counter++;
                }
            }
            return counter;
        }

        /*The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:
         * maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
         * -- should be 6: [4, -1, 2, 1]
         * Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. If the list is made up of only negative numbers, 
         * return 0 instead.
         * Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
         * https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/train/csharp
         */

        public static int MaxSequence(int[] arr) {
            //TODO : create code
            return 0;
        }


    }
}

