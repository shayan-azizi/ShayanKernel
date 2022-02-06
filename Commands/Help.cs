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
            string response = "";


            switch (args[0])
            {
                case "--commands":

                    response = "Commands list: \n    help: About this kernel and help you to work with that \n    echo: Print the argument \n    clear: Clear the screen \n    file: Manage files \n    dir: Manage direcotories \n";

                    break;

                case "--about":

                    response = "About ShayanOS: \n Version: v1.2.4 \n Author: Shayan Azizi \n Copyright: MIT License 2022 Shayan Azizi \n";

                    break;
            }

            return response;

        }

    }
}
