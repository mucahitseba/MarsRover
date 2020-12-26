using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Interfaces
{
    public interface IRoverCommandManager
    {
        IRover Rover { get; set; }
        void AddCommand(ICommand command);
        void ProcessCommands();
    }
}
