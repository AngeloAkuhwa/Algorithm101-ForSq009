using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStructure
{
    public class MyStack
    {
        private static List<char> LeftBrackets { get; set; } = new List<char> { '(', '<', '{', '[' };
        private static List<char> RightBrackets { get; set; } = new List<char> { ')', '>', '}', ']' };


        public static string ReverseString(string str)
        {
            if (str == null) throw new ArgumentNullException("wrong values");

            Stack<char> sta = new Stack<char>();
            foreach (var item in str)
            {
                sta.Push(item);
            }

            StringBuilder builder = new StringBuilder();
            foreach (var item in sta)
            {
                builder.Append(item);
            }
            return builder.ToString();
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
                    if (stack.Count == 0) return false ;

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
