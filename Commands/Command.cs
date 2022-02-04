using System;
using System.Collections.Generic;
using System.Text;

namespace firstKernel.Commands
{
    public class Command
    {
        public readonly string name;

        public Command (string name)
        {
            this.name = name;
        }

        public virtual string execute (string[] args)
        {
            return "";
        }
    }
}
