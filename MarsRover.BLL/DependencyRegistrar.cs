using MarsRover.BLL.Commands;
using MarsRover.BLL.Entities;
using MarsRover.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Interfaces
{
    public class DependencyRegistrar
    {
        public static ServiceProvider Configure()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ICommand, TurnLeftCommand>();
            services.AddTransient<ICommand, TurnRightCommand>();
            services.AddTransient<ICommand, MoveCommand>();
            services.AddTransient<IRoverCommandManager, RoverCommandManager>();
            services.AddTransient<IRoverPosition, RoverPosition>();
            services.AddTransient<IRover, Rover>();
            services.AddTransient<IPlateauGrid, PlateauGrid>();

            return services.BuildServiceProvider();
        }
    }
}
