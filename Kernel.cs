using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using firstKernel.Commands;

namespace firstKernel
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ShayanOS booted successfully.");
            Console.ForegroundColor = ConsoleColor.Green;
            this.commandManager = new CommandManager();

        }

        protected override void Run()
        {


            string response;
            string input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);


        }
    }
}
