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

        /*
         * ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
         * Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, 
         * they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
         * https://www.codewars.com/kata/530e15517bc88ac656000716/solutions/csharp
         */

        public static string Rot13(string message) {
            // your code here
            char[] result = message.ToArray();
            int count = 0;

            foreach (char c in result) {
                int number_char = (int)c;
                if (number_char > 96 && number_char < 123) {
                    int offset = 97;
                    result[count++] = (char)((number_char + 13) > 122 ? (number_char - offset + 13) % 26 + offset : (number_char + 13));

                }
                else if (number_char > 64 && number_char < 91) {
                    int offset = 65;
                    result[count++] = (char)((number_char + 13) > 90 ? (number_char - offset + 13) % 26 + offset : (number_char + 13));

                }
                else {
                    result[count++] = c;
                }
            }
            return new string(result);
        }

        /*
         * Мой нынешний костыльный позор
         * We need to sum big numbers and we require your help.
         * Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.
         * Example
         * * add("123", "321"); -> "444"
         * * add("11", "99");   -> "110"
         * 
         * https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp
         */

        public static string Add(string a, string b) {
            // return Convert.ToString(Int64.Parse(a) + Int64.Parse(b)); // Fix this!

            string result = string.Empty; // сюда будем вкладывать результат
            int array_length = (a.Length >= b.Length) ? a.Length : b.Length; // определяем максимальную длину числа
            int num_v_ume = 0; // здесь будем хранить "цифру в уме"
            

            List<int> array_a = new List<int>();
            List<int> array_b = new List<int>(); ;
            // int[] result_array = new int[array_length*2]; ; // массив для хранения результата сложения
            List<int> result_num = new List<int>();
            result_num.Capacity = array_length+1;

            // Раскладываем строки на созданные массивы

            foreach(char num_a in a.ToCharArray()) {
                array_a.Add((int)(num_a - '0'));
            }
            foreach(char num_b in b.ToCharArray()) {
                array_b.Add((int)(num_b - '0'));
            }

            // нормализуем размеры массивов
            while (array_a.Count < array_length) {
                array_a.Insert(0, 0);
            }
            while (array_b.Count < array_length) {
                array_b.Insert(0, 0);
            }

            for (int i = array_length-1; i >= 0; i--) {
                if ((array_a[i] + array_b[i] + num_v_ume) < 10) {
                    result_num.Add(array_a[i] + array_b[i] + num_v_ume);
                    num_v_ume = 0;
                    // result += array_a[i] + array_b[i] + num_v_ume;
                } else {
                    result_num.Add((array_a[i] + array_b[i] + num_v_ume) % 10);
                    // result_num += (array_a[i] + array_b[i] + num_v_ume) % 10;
                    num_v_ume = (array_a[i] + array_b[i] + num_v_ume) / 10;
                    if (i == 0 && num_v_ume != 0) {
                        result_num.Add(num_v_ume);
                    }
                }
            }
            result_num.Reverse();
            foreach (int i in result_num) {
                result += i;
            }
            
            return result;
        }


        /*
         * Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
         * 12 ==> 21
         * 513 ==> 531
         * 2017 ==> 2071
         * If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):
         * 9 ==> -1
         * 111 ==> -1
         * 531 ==> -1
         * https://www.codewars.com/kata/55983863da40caa2c900004e/train/csharp
         * 
         */
        public static long NextBiggerNumber(long n) {
            //code me
            long result = 0;
            char[] temp_array = n.ToString().ToCharArray();
            string temp_string = string.Empty;
            List<int> temp_list = new List<int>();
            foreach(char c in temp_array) {
                temp_list.Add((int)(c - '0'));
            }

            for(int i = temp_list.Count - 2;  i >= 0 ; i--) {
                if (temp_list[i] < temp_list[i + 1]) {
                    (temp_list[i+1], temp_list[i]) = (temp_list[i], temp_list[i+1]);
                    break;
                }
            }


            foreach (int i in temp_list) {
                temp_string += i;
            }

            result = Int32.Parse(temp_string);

            return result > n? result: -1;
        }
    }
}



