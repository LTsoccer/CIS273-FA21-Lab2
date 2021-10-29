using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //IsBalanced("{ int a = new int[ ] ( ( ) ) }");

            Evaluate("5 3 11 + -");

        }



        public static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s.Length == 0)
            {
                return true;
            }

            foreach ( char c in s)
            {
                // If opening symbol, then push onto stack
                if ( c == '{' || c=='<' || c=='[' || c=='(' )
                {
                    stack.Push(c);
                }

                // If closing symbol, then see if it matches the top
                else if (c == '}' || c == '>' || c == ']' || c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if ( Matches(stack.Peek(), c) )
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                // If any other character, then continue/ignore it.
                else
                {
                    //continue;
                }
            }

            // If stack is empty, return true
            // else return false

            if( stack.Count == 0)
            {
                return true;
            }

            return false;
        }

        private static bool Matches(char open, char close)
        {
            switch(close)
            {
                case ')':
                    if (open == '(')
                    {
                        return true;
                    }
                    return false;
                case '}':
                    if (open == '{')
                    {
                        return true;
                    }
                    return false;
                case ']':
                    if (open == '[')
                    {
                        return true;
                    }
                    return false;
                case '>':
                    if (open == '<')
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;

            }
        }

        // Evaluate("5 3 11 + -")	// returns -9
        // 2.4 3.8 / 2.321 +
        
        public static double? Evaluate(string s)
        {
            // parse into tokens (strings)
            if (s.Length == 0)
            {
                return null;
            }

            string[] tokens = s.Split();

            Stack<double> stack = new Stack<double>();
            foreach (string token in tokens)
            {
                if (Double.TryParse(token, out double token1))
                {
                    stack.Push(token1);
                }

                if (token == "+" || token == "-" || token == "*" || token == "/")
                    {
                        if (stack.Count < 2)
                        {
                            return null;
                        }
                        else
                        {
                            double num2 = stack.Pop();
                            double num1 = stack.Pop();
                            if (token == "+")
                            {
                                stack.Push(num1 + num2);
                            }
                            else if (token == "-")
                            {
                                stack.Push(num1 - num2);
                            }
                            else if (token == "/")
                            {
                                stack.Push(num1 / num2);
                            }
                            else
                            {
                                stack.Push(num1 * num2);
                            }

                      
                        }
                    Console.WriteLine(stack.Peek());
                }
            }

            Console.WriteLine(stack.Peek());
            if ( stack.Count != 1)
            {
                return null;
            }
            Console.WriteLine(stack.Peek());
            return stack.Pop();
        }



    }
}
