using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace firstKernel
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShayanOS booted successfully.");
            Console.ForegroundColor = ConsoleColor.Green;

        }

        protected override void Run()
        {
            Console.Write("$ ");
            string input = Console.ReadLine();
            HandlThisCommand(input);
        }

        private void HandlThisCommand(string input)
        {

            char[] inputArray = input.ToCharArray();



            if (input == "help")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This is the ShayanOS that can help you to work with your computer");
                Console.WriteLine("Use help --commands to see the list of commands in this terminal");
                Console.ForegroundColor = ConsoleColor.Green;

            }

            if (input == "help --commands")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Commands list:");
                Console.WriteLine("help: Watch help panel");
                Console.WriteLine("clear: Clear the screen");
                Console.WriteLine("echo: echo some text you want");
                Console.WriteLine("info: Show system information");
                Console.WriteLine("shutdown: Shutdown the computer");
                Console.WriteLine("restart: Reboot the computer");

                Console.ForegroundColor = ConsoleColor.Green;
            }

            if (inputArray[0] == 'e' && inputArray[1] == 'c' && inputArray[2] == 'h' && inputArray[3] == 'o')
            {
                int counter = 0;
                foreach (char i in inputArray)
                {
                    if (counter > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(i);
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    counter++;
                }
                Console.WriteLine(" ");
            }

            if (input == "clear")
            {
                Console.Clear();
            }
            if (input == "cls")
            {
                Console.Clear();
            }

            if (input == "shutdown")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Are you sure? y/n");
                string sure = Console.ReadLine();
                if (sure == "y")
                {
                    Console.WriteLine("This computer will be shutdown in 5 seconds");
                    System.Threading.Thread.Sleep(5000);
                    Sys.Power.Shutdown();
                }
                Console.ForegroundColor = ConsoleColor.Green;

            }

            if (input == "restart")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Are you sure? y/n");
                string sure = Console.ReadLine();
                if (sure == "y")
                {
                    Console.WriteLine("This computer will be shutdown in 5 seconds");
                    System.Threading.Thread.Sleep(5000);
                    Sys.Power.Reboot();
                }
                Console.ForegroundColor = ConsoleColor.Green;
            }

            if (input == "info")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bruh you are too sumb because you don't know your system config!!");
                Console.ForegroundColor = ConsoleColor.Green;

            }



        }

    }
}
