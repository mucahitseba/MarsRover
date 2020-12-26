using MarsRover.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Commands
{
    public class TurnRightCommand : ICommand
    {
        IRover rover;

        public TurnRightCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnRight();
        }
    }
}
