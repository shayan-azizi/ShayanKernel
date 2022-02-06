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

            string response = "Commands able in file: \n file create: make file in the adress \n file remove: delete file in the adress \n file write: write string in to the file in the adress \n file read: read the contents of the file ";
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

                case "write":
                    
                    try
                    {

                        FileStream fs = (FileStream) Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if (fs.CanWrite)
                        {
                            int counter = 0;
                            StringBuilder mainArgs = new StringBuilder();

                            foreach (String s in args)
                            {
                                if (counter > 1)
                                {
                                    mainArgs.Append(s + ' ');
                                }
                                ++counter;
                            }

                            byte[] data = Encoding.ASCII.GetBytes(mainArgs.ToString());

                            fs.Write(data, 0, data.Length);
                            fs.Close();

                            response = "Successfully wrote to file";

                        }
                        else
                        {

                            response = "Unable to write to file! Not open for writing.";
                            break;      

                        }

                    }

                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;

                    }

                    break;

                case "read":

                    try
                    {


                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if (fs.CanRead)
                        {
                            byte[] data = new byte[256];
                            fs.Read(data, 0, data.Length);

                            response = Encoding.ASCII.GetString(data);


                        }

                        else
                        {
                            response = "Unable to read from file! Not open for reading";
                            break;
                        }

                    }

                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }

                    break;

                case "":

                    response = "Commands able in file: \n file create: make file in the adress \n file remove: delete file in the adress \n file write: write string in to the file in the adress \n file read: read the contents of the file ";    

                    break;

                default:
                    response = "Unexpected argument: " + args[0];

                    break;

            }

            return response;

        }

    }
}
