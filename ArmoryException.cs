﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class ArmoryException : Exception
    {
        public ArmoryException(string message) : base(message)
        {
        }
    }
}
