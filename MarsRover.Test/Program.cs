using MarsRover.BLL.Commands;
using MarsRover.BLL.Entities;
using MarsRover.Models.Enums;
using System;

namespace MarsRover.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateauGrid1 = new PlateauGrid(5, 5);

            var roverPosition = new RoverPosition(RoverDirection.N, 1, 2);
            var rover = new Rover(roverPosition, plateauGrid1);

            var roverCommandManager = new RoverCommandManager(rover);
            roverCommandManager.AddCommand(new TurnLeftCommand(rover));
            roverCommandManager.AddCommand(new MoveCommand(rover));
            roverCommandManager.AddCommand(new TurnLeftCommand(rover));
            roverCommandManager.AddCommand(new MoveCommand(rover));
            roverCommandManager.AddCommand(new TurnLeftCommand(rover));
            roverCommandManager.AddCommand(new MoveCommand(rover));
            roverCommandManager.AddCommand(new TurnLeftCommand(rover));
            roverCommandManager.AddCommand(new MoveCommand(rover));
            roverCommandManager.AddCommand(new MoveCommand(rover));

            roverCommandManager.ProcessCommands();

            Console.WriteLine($"X: {roverCommandManager.Rover.CurrentPosition.X}, " +
                $"Y: {roverCommandManager.Rover.CurrentPosition.Y}, " +
                $"Direction: {roverCommandManager.Rover.CurrentPosition.Direction.ToString()}");

            var roverPosition2 = new RoverPosition(RoverDirection.E, 3, 3);
            var rover2 = new Rover(roverPosition2, plateauGrid1);
            
            var roverCommandManager2 = new RoverCommandManager(rover2);
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.AddCommand(new TurnRightCommand(rover2));
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.AddCommand(new TurnRightCommand(rover2));
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.AddCommand(new TurnRightCommand(rover2));
            roverCommandManager2.AddCommand(new TurnRightCommand(rover2));
            roverCommandManager2.AddCommand(new MoveCommand(rover2));
            roverCommandManager2.ProcessCommands();

            Console.WriteLine($"X: {roverCommandManager2.Rover.CurrentPosition.X}, " +
                            $"Y: {roverCommandManager2.Rover.CurrentPosition.Y}, " +
                            $"Direction: {roverCommandManager2.Rover.CurrentPosition.Direction.ToString()}");

            Console.ReadKey();
        }
    }
}
