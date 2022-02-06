using System;
using System.Collections.Generic;
using System.Text;

namespace firstKernel.Commands
{
    public class CommandManager
    {

        private List<Command> commands;

        public CommandManager ()
        {
            this.commands = new List<Command>();
            this.commands.Add(new Help("help"));
            this.commands.Add(new File("file"));
            this.commands.Add(new Dir("dir"));
            this.commands.Add(new Clear("clear"));
            this.commands.Add(new Echo("echo"));


        }

        public string processInput(string input)
        {
            string[] split = input.Split(" "); // Before Convert input to list: "dir -a bruh" | After: ["dir", "a", "bruh"]

            string label = split[0]; // label = "dir"

            List<String> args = new List<String>();

            int counter = 0;

            foreach (String s in split) // See if the command is valid
            {
                if (counter != 0)
                    args.Add(s);

                ++counter;

            }

            foreach (Command cmd in this.commands)
            {
                if (cmd.name == label)
                    return cmd.execute(args.ToArray());

            }

            return "Your command \"" + label + "\" does not exist";

        }

    }
}
