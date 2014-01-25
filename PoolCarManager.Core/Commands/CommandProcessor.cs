using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PoolCarManager.Core.Commands
{
    public class CommandProcessor
    {
        private static readonly IList<Assembly> __assemblies;

        public static void AddCommandHandlerAssembly(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");

            __assemblies.Add(assembly);
        }

        public static void Process<TCommand>(TCommand command)
        {
            var query = from a in __assemblies
                        from t in a.GetTypes()
                        where typeof(ICommandHandler<TCommand>).IsAssignableFrom(t)
                        select t;

            List<Type> commandHandlerTypes = query.ToList();

            foreach (var commandHandlerType in commandHandlerTypes)
            {
                var handler = (ICommandHandler<TCommand>)Activator.CreateInstance((Type)commandHandlerType);
                handler.Handle(command);
            }
        }
    }
}