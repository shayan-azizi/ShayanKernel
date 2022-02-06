using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace firstKernel.Commands
{
    public class Dir : Command
    {
        public Dir (string name) : base (name) { }

        public override string execute (string [] args)
        {   
            // dir create bruh

            string response = "Commands able in file: \n dir create: make directory in the adress \n dir remove: delete directory in the adress \n ";

            switch (args[0])
            {
                case "create":

                    try
                    {

                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                        response = "Your directory " + args[1] + " was successfully created. \n";


                    }
                    catch (Exception ex)
                    {

                        response = ex.ToString();
                        break;
                    }

                break;


                case "remove":

                    try
                    {   

                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1], true);
                        response = "Your directory " + args[1] + " was successfully remove. \n";


                    }
                    catch (Exception ex)
                    {

                        response = ex.ToString();
                        break;
                    }

                    break;

                case "":

                    response = "Commands able in file: \n dir create: make directory in the adress \n dir remove: delete directory in the adress \n";

                    break;

                default:

                    response = "Unexpected argument: "+ args[0] + "\n";

                    break;

            }

            return response;
        }
    }
}
