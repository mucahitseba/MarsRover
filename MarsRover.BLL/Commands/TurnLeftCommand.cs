﻿using MarsRover.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Commands
{
    public class TurnLeftCommand : ICommand
    {
        IRover rover;

        public TurnLeftCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnLeft();
        }
    }
}
