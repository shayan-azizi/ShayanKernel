using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace firstKernel.Commands
{
    public class File : Command
    {

        public File (String name) : base (name) { }

        public override string execute (string[] args)
        {

            // file create bruh.py

            string response = "";
            switch (args[0])
            {

                case "create":

                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                        response = "Your file " + args[1] + " was successfully created.";
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
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                        response = "Your file " + args[1] + " was successfully removed.";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }


                    break;

            }

            return response;

        }

    }
}
