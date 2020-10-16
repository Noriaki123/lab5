using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int f = GetFactorial();
            string val = Convert.ToString(f);
            SetColor(val);
        }

        static int GetFactorial()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = x; i > 0; i--)
            {
                f = i * f;
            }
            return f;
        }

        static void WriteLine(string val, char beginSym, char indentSym, char endSym)
        {
            Console.Write(beginSym);
            for (int i = 0; i < val.Length + 2; i++)
            {
                Console.Write(indentSym);
            }
            Console.Write(endSym);
        }

        static void WriteVal(string val, char beginSym, char indentSym, char endSym)
        {
            Console.Write(beginSym);
            Console.Write(indentSym);
            Console.Write(val);
            Console.Write(indentSym);
            Console.Write(endSym);
        }

        static void WriteBox(string val)
        {
            WriteLine(val, '╔', '═', '╗');
            Console.WriteLine();
            WriteVal(val, '║', ' ', '║');
            Console.WriteLine();
            WriteLine(val, '╚', '═', '╝');
        }

        static void SetColor(string val)
        {
            while (true)
            {
                Console.Clear();
                WriteBox(val);
                if (Console.BackgroundColor == ConsoleColor.Black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
        }
    }
}
