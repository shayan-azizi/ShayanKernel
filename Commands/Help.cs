using System;
using System.Collections.Generic;
using System.Text;

namespace firstKernel.Commands
{
    public class Help : Command
    {
        
        public Help (string name) : base (name) { }

        public override string execute(string[] args)
        {
            return "Welcome to ShayanOS Help command.The ShayanOS current version is alfa-1.2.0. For more information on a specific command, type help --commands";

        }

    }
}
