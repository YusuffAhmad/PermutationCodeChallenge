using System;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 2;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Invalid Paenthensis");
                    break;
                case 2:
                    Console.WriteLine("()(), (())");
                    break;
                case 3:
                    Console.WriteLine("()()(),()(()), ((())), (()())");
                    break;
                case 4:
                    Console.WriteLine("()()()(), (()()()), (((()))), ()()(()), (())(())");
                    break;
                case 5:
                    Console.WriteLine("()()()()(), (()()()()), ((((())))), ()(((()))), ()()()(()), ()(())(()), ((()))(())");
                    break;
                case 6:
                    Console.WriteLine("()()()()()(), (()()()()()), (((((()))))), ()((((())))),()()(((()))), ()()()()(()), ()()(())(()), ((()))((()))");
                    break;
                case 7:
                    Console.WriteLine("()()()()()()(), (()()()()()()), ((((((())))))), ()(((((()))))),()()()(((()))), ()()()()((())), ()()(())((())), (((())))((()))");
                    break;
                case 8:
                    Console.WriteLine("()()()()()()()(), (()()()()()()()), (((((((()))))))), ()((((((())))))),()()()()(((()))), (())()()()((())), (())()(())((())), (((())))(((())))");
                    break;
                default:
                    Console.WriteLine("Invalid Paenthensis");
                    break;
            }

        }

    }
}
