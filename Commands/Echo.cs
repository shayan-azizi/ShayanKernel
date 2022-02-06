using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace firstKernel.Commands
{
    public class Echo : Command
    {
        public Echo (string name) : base (name) { }

        public override string execute (string [] args)
        {

            string response = "";

            StringBuilder echoReturn = new StringBuilder();
            int counter = 0;

            if (args.Length == 1)
            {
                response = args[0];
            }
            else
            {

                foreach (string s in args)
                {
                    if (counter > -1)
                    {
                        echoReturn.Append(s + ' ');
                    }
                    ++counter;
                }

                response = echoReturn.ToString();
            }

            if (args[0] == "$0")
            {
                response = "-lipshell";
            }


            return response;

        }

    }
}
