using System;
using System.Collections.Generic;
using System.Text;

namespace firstKernel.Commands
{
    public class Clear : Command
    {
        public Clear (string name) : base (name) { }

        public override string execute (string [] args)
        {
            Console.Clear();
            return "";
        }
    }
}
