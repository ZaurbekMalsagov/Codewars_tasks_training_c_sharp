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





        /*A Narcissistic Number (or Armstrong Number) is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. 
         * In this Kata, we will restrict ourselves to decimal (base 10).
         * For example, take 153 (3 digits), which is narcissistic:
         * 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
         * and 1652 (4 digits), which isn't:
         *  1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
         * Your code must return true or false (not 'true' and 'false') depending upon whether the given number is a Narcissistic number in base 10.
         * https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/csharp
         */


        public static bool Narcissistic(int value) {
            // Code me
            int original_number = value;
            bool result = false;
            double result_number = 0;
            List<int> values = new List<int>();
            while (value > 0) {
                if (value != 0) {
                    values.Add(value % 10);
                    value = value / 10;

                }
            }

            foreach (var item in values) {
                result_number += Math.Pow(item, values.Count);
            }
            if ((double)original_number == result_number) {
                result = true;
            }
            return result;

        }

        /*The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
         * What if the string is empty? Then the result should be empty object literal, {}.
         * https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp
         */
        public static Dictionary<char, int> Count(string str) {
            Dictionary<char, int> result = new Dictionary<char, int>();
            char[] chars = str.ToCharArray();
            foreach (char c in chars) {
                if (result.ContainsKey(c)) {
                    result[c]++;
                } else {
                    result.Add(c, 1);
                }
            }
            return result;
        }

        /*
         * Write a simple parser that will parse and run Deadfish.
         * Deadfish has 4 commands, each 1 character long:
         * i increments the value (initially 0)
         * d decrements the value
         * s squares the value
         * o outputs the value into the return array
         * Invalid characters should be ignored.
         *       Deadfish.Parse("iiisdoso") => new int[] {8, 64};
         *       https://www.codewars.com/kata/51e0007c1f9378fa810002a9/solutions/csharp
         */
        public static int[] ParseDeadFish(string data) {
            // Return the output array, and ignore all non-op characters


            List<int> result = new List<int>();

            int result_number = 0;
            char[] temp = data.ToCharArray();

            foreach(char c in temp) {
                switch (c) {
                    case 'i':
                        result_number++;
                        break;
                    case 'd':
                        result_number--;
                        break;
                    case 's':
                        result_number*=result_number; 
                        break;
                    case 'o':
                        result.Add( result_number); 
                        break;
                }

            }
            int[] result_array = new int[result.Count];
            for(int i = 0; i < result.Count; i++) {
                result_array[i] = result[i];
            }
            return result_array;
        }
    }
}

