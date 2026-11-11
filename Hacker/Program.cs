using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hacker
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            
            {
                Console.Title = "HACKER TERMINAL";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;
                Console.Clear();

                Random rnd = new Random();

                string chars = "0123456789ABCDEFabcdef!@#$%^&*";

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            break;
                    }

                    int width = Console.WindowWidth;
                    int height = Console.WindowHeight;

                    for (int i = 0; i < width; i++)
                    {
                        int y = rnd.Next(height);

                        Console.SetCursorPosition(i, y);

                        Console.ForegroundColor =
                            rnd.Next(10) == 0
                            ? ConsoleColor.White
                            : ConsoleColor.Green;

                        Console.Write(chars[rnd.Next(chars.Length)]);
                    }

                    Thread.Sleep(30);
                }

                Console.ResetColor();
                Console.Clear();
                Console.CursorVisible = true;
                Console.WriteLine("Terminal kapatildi.");
            }
        }
    }

    
}
