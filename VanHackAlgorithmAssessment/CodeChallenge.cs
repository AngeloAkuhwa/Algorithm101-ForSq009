using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace VanHackAlgorithmAssessment
{
    public class CodeChallenge
    {
        //question one
        /// <summary>
        /// question one from vanhack assessment
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Numerals(int num)
        {

            string hold = string.Empty;
            int result = 0;
            while (num >= 1)
            {
                if (num >= 1000)
                {
                    result = num / 1000;
                    num = num % 1000;
                    string thousands = ThousandRange(result);
                    hold += thousands;
                }
                else if (num >= 100 && num < 1000)
                {
                    result = num / 100;
                    num = num % 100;
                    string hundreds = HundredRange(result);
                    hold += hundreds;
                }
                else if (num >= 10 && num < 100)
                {
                    result = num / 10;
                    num = num % 10;
                    string tens = TensRange(result);
                    hold += tens;
                }
                else
                {
                    string unitary = UnitsRange(num);
                    hold += unitary;
                    break;
                }

            }
            return hold;
        }

        private static string ThousandRange(int result)
        {
            string hold = "";
            if (result > 2) hold += "MMM";
            else if (result == 2) hold += "MM";
            else hold += "M";
            return hold;
        }

        private static string HundredRange(int result)
        {
            string hold = "";
            if (result == 9) hold += "CM";
            else if (result == 8) hold += "DCCC";
            else if (result == 7) hold += "DCC";
            else if (result == 6) hold += "DC";
            else if (result == 5) hold += "D";
            else if (result == 4) hold += "CD";
            else if (result == 3) hold += "CCC";
            else if (result == 2) hold += "CC";
            else hold += "C";
            return hold;
        }

        private static string TensRange(int result)
        {
            string hold = "";
            if (result == 9) hold += "XC";
            else if (result == 8) hold += "LXXX";
            else if (result == 7) hold += "LXX";
            else if (result == 6) hold += "LX";
            else if (result == 5) hold += "L";
            else if (result == 4) hold += "XL";
            else if (result == 3) hold += "XXX";
            else if (result == 2) hold += "XX";
            else hold += "X";
            return hold;
        }

        private static string UnitsRange(int result)
        {
            string hold = "";
            if (result == 9) hold += "IX";

            else if (result == 8) hold += "VIII";

            else if (result == 7) hold += "VII";

            else if (result == 6) hold += "VI";

            else if (result == 5) hold += "V";

            else if (result == 4) hold += "IV";

            else if (result == 3) hold += "III";

            else if (result == 2) hold += "II";

            else hold += "I";

            return hold;
        }


        //question two

        public static string romanNumerals { get; set; }
        /// <summary>
        /// question twomfrom van hack assessment
        /// </summary>
        /// <param name="roman"></param>
        /// <returns></returns>
        public static int Decode(string roman)
        {
            string upperCased = roman.ToUpper();
            string[] result = upperCased.Split(new[] { "IV", "IX", "XL", "XC", "CD", "CM" }, StringSplitOptions.None);
            romanNumerals = string.Join("", result);

            var repeatedCharCount = CharacterCount();

            List<char> romanNumneralCharacters = new List<char> { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

            string[] doubleNumeral = { "IV", "IX", "XL", "XC", "CD", "CM" };
            int[] doubleNumeralNumbers = { 4, 9, 40, 90, 400, 900 };

            int[] arrNumbers = { 1, 5, 10, 50, 100, 500, 1000 };
            List<int> numberHolder = new List<int>();
            int counter = 0;


            while (true)
            {
                var element = romanNumneralCharacters[counter];

                if (romanNumerals.Contains(element))
                {
                    var multiplier = repeatedCharCount[element];
                    numberHolder.Add(arrNumbers[counter] * multiplier);
                }


                if (counter == romanNumneralCharacters.Count - 1) break;

                counter++;

            }

            int newCounter = 0;

            while (true)
            {

                var element = doubleNumeral[newCounter];

                if (upperCased.Contains(element))
                {
                    numberHolder.Add(doubleNumeralNumbers[newCounter]);
                }
                if (newCounter == doubleNumeral.Length - 1) break;

                newCounter++;
            }
            return numberHolder.Sum(x => x);

        }
        private static Dictionary<char, int> CharacterCount()
        {
            Dictionary<char, int> dictionaryChar = new Dictionary<char, int>();

            foreach (var item in romanNumerals)
            {
                if (dictionaryChar.ContainsKey(item))
                {
                    dictionaryChar[item]++;
                }
                else
                {
                    dictionaryChar.Add(item, 1);
                }
            }

            return dictionaryChar;
        }



        ///question three

        private static List<char> LeftBrackets { get; set; } = new List<char> { '(', '<', '{', '[' };
        private static List<char> RightBrackets { get; set; } = new List<char> { ')', '>', '}', ']' };
        /// <summary>
        /// question three from vanhack assessment
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static double Calc(string expression)
        {
            DataTable com = new DataTable();
            string result = null;

            if (string.IsNullOrWhiteSpace(expression))
            {
                return default(double);
            }

            if (IsBalancedExpression(expression))
            {
                result = com.Compute(expression, null).ToString();

            }
            bool Check = double.TryParse(result, out var finalResult);

            return Check ? finalResult : default;

        }
        public static bool IsBalancedExpression(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char character in str)
            {
                if (IsLeftBracket(character))
                {
                    stack.Push(character);
                }

                if (IsRightBracket(character))
                {
                    if (stack.Count == 0) return false;

                    var leftBracket = stack.Pop();

                    if (!BracketsMatched(leftBracket, character))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        private static bool IsLeftBracket(char character)
        {
            return LeftBrackets.Contains(character);
        }

        private static bool IsRightBracket(char character)
        {
            return RightBrackets.Contains(character);
        }

        private static bool BracketsMatched(char leftBracket, char rightBracket)
        {
            return LeftBrackets.IndexOf(leftBracket) == RightBrackets.IndexOf(rightBracket);
        }

    }
}
