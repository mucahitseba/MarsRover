using MarsRover.BLL.Interfaces;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Entities
{
    public class RoverPosition : IRoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public RoverDirection Direction { get; set; }

        public RoverPosition(RoverDirection direction = RoverDirection.N, int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
    }
}
