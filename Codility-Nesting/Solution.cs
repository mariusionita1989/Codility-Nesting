using System.Runtime.CompilerServices;

namespace Codility_Nesting
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 1000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(string S)
        {
            int N = S.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                Stack<char> stack = new Stack<char>();
                foreach (char c in S)
                {
                    if (c == '(')
                    {
                        // If it's an opening bracket, push it onto the stack
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        // If it's a closing bracket, check if the stack is empty
                        if (stack.Count == 0)
                            return 0; // Not properly nested

                        // Check if the top of the stack contains a matching opening bracket
                        if (stack.Peek() == '(')
                            stack.Pop(); // Pop the matching opening bracket
                        else
                            return 0; // Not properly nested
                    }
                }
                // After processing the entire string, the stack should be empty for it to be properly nested
                return stack.Count == 0 ? 1 : 0;
            }

            return -1;
        }
    }
}
