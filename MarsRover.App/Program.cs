﻿using MarsRover.BLL.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = DependencyRegistrar.Configure();

            Console.WriteLine("Test Input :");

            var plateauGrid = serviceProvider.GetService<IPlateauGrid>();

            while (!plateauGrid.CheckInit)
            {
                Console.WriteLine("Plateau grid size :");
                var plateauGridSizeInput = Console.ReadLine();
                Console.WriteLine(plateauGrid.Initialize(plateauGridSizeInput));
            }

            var addAnotherRover = true;

            while (addAnotherRover)
            {
                Console.WriteLine("Rover position :");
                var roverPositionInput = Console.ReadLine();
                Console.WriteLine("Rover command :");
                var roverCommandInput = Console.ReadLine();

                var rover = serviceProvider.GetService<IRover>();
                if (rover.Initialize(roverPositionInput))
                {
                    rover.PlateauGrid = plateauGrid;
                    rover.CommandParse(roverCommandInput);
                    plateauGrid.Rovers.Add(rover);
                }

                Console.WriteLine("Do you want to deploy another rover ? (Y)");
                var addAnotherRoverInput = Console.ReadLine();
                if (addAnotherRoverInput.ToUpper() != "Y")
                {
                    addAnotherRover = false;
                }
            }

            Console.WriteLine("Expected Output :");
            foreach (var rover in plateauGrid.Rovers)
            {
                var roverCommandManager = serviceProvider.GetService<IRoverCommandManager>();
                roverCommandManager.Rover = rover;

                foreach (var roverCommand in rover.Commands)
                {
                    roverCommandManager.AddCommand(roverCommand);
                }

                roverCommandManager.ProcessCommands();

                Console.WriteLine($"{roverCommandManager.Rover.CurrentPosition.X} " +
                  $"{roverCommandManager.Rover.CurrentPosition.Y} " +
                  $"{roverCommandManager.Rover.CurrentPosition.Direction.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
