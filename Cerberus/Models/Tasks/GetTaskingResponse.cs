﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerberus.Models.Tasks
{
    public class GetTaskingResponse
    {
        public string action { get; set; }
        public MythicTaskResult[] responses { get; set; }
    }
}
