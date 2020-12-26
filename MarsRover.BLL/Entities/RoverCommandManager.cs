using MarsRover.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Entities
{
    public class RoverCommandManager : IRoverCommandManager
    {
        public IRover Rover { get; set; }
        private Queue<ICommand> commands = new Queue<ICommand>();

        public RoverCommandManager(IRover rover)
        {
            this.Rover = rover;
        }

        public void AddCommand(ICommand command)
        {
            commands.Enqueue(command);
        }

        public void ProcessCommands()
        {
            while (commands.Count > 0)
            {
                ICommand command = commands.Dequeue();
                command.Process();
            }
        }
    }
}
