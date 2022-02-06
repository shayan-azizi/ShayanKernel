using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using firstKernel.Commands;
using Cosmos.System.FileSystem;

namespace firstKernel
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        private CosmosVFS vfs;
        
        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();
            this.commandManager = new CommandManager();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);

            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ShayanOS booted successfully.");
            Console.ForegroundColor = ConsoleColor.Green;

        }

        protected override void Run()
        {

            Console.Write("$ ");
            string response;
            string input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);


        }
    }
}
