using System;
using System.Collections.Generic;
using System.Text;

namespace TerracorTask
{
    public class LocationNumerals
    {
        private Dictionary<char, int> alphabetIndex = new Dictionary<char, int>(); /*Dictionary data structure for storing all the alphabets*/

        private char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        /*
         * Constructor - initializes the dictionary with the alphabets
         */
        public LocationNumerals()
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabetIndex.Add(alphabet[i], i);
            }
        }


        /*
         * This method converts an integer to its equivalent abbrivated location numeral
         * param name="inputInteger" : an integer value
         * returns: equivalent location numeral string
         */
        public string IntegerToLocationNumeral(int inputInteger)
        {
            string locationNumeral = "";
            while (inputInteger > 0)
            {
                int pow = (int)Math.Log2(inputInteger);
                locationNumeral += alphabet[pow];
                inputInteger = inputInteger - (int)Math.Pow(2, pow);
            }
            return ToAbbreviate(locationNumeral);
        }


        /*
         * This method converts a location numeral to its equivalent integer
         * param name="inputLocationNumeral" : a location numeral string
         * returns: equivalent integer of the input location numerals or "-1" if the input is not a valid location numeral
         */
        public int LocationNumeralToInteger(string inputLocationNumeral)
        {
            int resultInteger = 0;
            for (int i = 0; i < inputLocationNumeral.Length; i++)
            {
                if (!alphabetIndex.ContainsKey(inputLocationNumeral[i])) /*checking whether input has any character except a-z.*/
                {
                    /*
                     * breaking the for loop as the input string is not valid
                     */
                    resultInteger = -1;
                    break;
                }
                int index = alphabetIndex[inputLocationNumeral[i]];
                resultInteger += (int)Math.Pow(2, index);
            }
            return resultInteger;
        }


        /*
         * ToAbbreviate function converts a location numeral to its abbreviated form
         * param name="inputLocationNumeral" : a location numeral string
         * returns:  abbreviated location numeral string of inputLocationNumeral or 
         *           "Invalid Input" if the input string is not a valid location numeral
         *           
         * running time O(nlogn) where n is the length of the input string
         */
        public string ToAbbreviate(string inputLocationNumeral)
        {
            /*
             * sort the input stringin alphabetical order
             */
            char[] characters = inputLocationNumeral.ToCharArray();
            Array.Sort(characters);
            inputLocationNumeral = new string(characters);

            string outputLocationNumeral = "";

            for (int i = 0; i < inputLocationNumeral.Length; i++)
            {
                if (!alphabetIndex.ContainsKey(inputLocationNumeral[i])) /*checking whether input has any character except a-z.*/
                {
                    /*
                     * breaking the for loop as input string is not valid
                     */
                    outputLocationNumeral = "Invalid Input";
                    break;
                }
                if (!outputLocationNumeral.EndsWith(inputLocationNumeral[i]) || (inputLocationNumeral[i] == alphabet[25]))/*checking whether the las character of output and current character of input are not same or the current character is 'z'*/
                {
                    /*
                     * if the last character of output and current character of input are not the same 
                     * or the current character is 'z', we add the current character to the output
                     */
                    outputLocationNumeral = outputLocationNumeral + inputLocationNumeral[i];
                }
                else
                {
                    /*
                     * if the current character of input and the last character of output are the same 
                     * or the current character is not 'z', we replace the last character of outputLocationNumeral by its next character in the alphabet.
                     */
                    StringBuilder sb = new StringBuilder(outputLocationNumeral);
                    sb[outputLocationNumeral.Length - 1] = alphabet[alphabetIndex[inputLocationNumeral[i]] + 1];
                    outputLocationNumeral = sb.ToString();
                }
            }
            return outputLocationNumeral;
        }
    }
}
