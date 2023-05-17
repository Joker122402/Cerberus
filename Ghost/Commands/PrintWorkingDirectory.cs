﻿using Ghost.Models.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost.Commands
{
    public class PrintWorkingDirectory : GhostCommand
    {
        public override string Name => "pwd";

        public override string Execute(GhostTask task)
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
