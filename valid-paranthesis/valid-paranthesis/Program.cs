using System;
using System.Collections.Generic;

namespace valid_paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Parentheses");
            string strng= Console.ReadLine();
            IsValid(strng);
            Console.WriteLine(IsValid(strng));
        }
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i];
                if (curr == '(' || curr == '{' || curr == '[')
                {
                    stack.Push(curr);
                }
                else if (curr == ')' || curr == ']' || curr == '}') 



                         if (stack.Count == 0)
                {
                    return false;
                }


                var prev = (char)stack.Pop();
                if ((prev == '('&& prev==')') || (prev == '{'&& prev=='}') || (prev == '['&& prev== ']'))
                {
                    continue;
                }
                return true;
            }
            return stack.Count == 0;
        }
      

    }

}

