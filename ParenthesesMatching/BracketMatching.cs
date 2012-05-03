// <copyright file="BracketMatching.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace ParenthesesMatching
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A static class to test strings to determine their parenthetical validity
    /// </summary>
    public static class BracketMatching
    {
        /// <summary>
        /// Determines whether or not a string contains a valid, well-formed parenthetical expression
        /// </summary>
        /// <param name="input">The string to test</param>
        /// <returns>Whether or not the string contains a valid parenthetical expressions</returns>
        public static bool IsValidParentheticalExpression(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if ("{([<".Contains(c))
                {
                    stack.Push(c);
                }

                if ("})]>".Contains(c))
                {
                    if (stack.Count == 0)
                    {
                        // if the stack is empty and we have more closings
                        // then the input is not a well-formed parenthetical expression
                        return false;
                    }

                    char lastOpenBracket = stack.Pop();

                    // the last popped element must match the last in type to the current closing bracket
                    // this prevents things like {[}] from being valid
                    if ((lastOpenBracket == '{' && c != '}') || (lastOpenBracket == '(' && c != ')')
                     || (lastOpenBracket == '[' && c != ']') || (lastOpenBracket == '<' && c != '>'))
                    {
                        return false;
                    }
                }
            }

            // if there are still elements on the stack then, there are more
            // opening brackets than closing
            return stack.Count == 0 ? true : false;
        }
    }
}
