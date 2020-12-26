using MarsRover.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Commands
{
    public class MoveCommand : ICommand
    {
        IRover rover;

        public MoveCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.Move();
        }
    }
}
