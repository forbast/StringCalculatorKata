﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    interface IOperations
    {
        bool CanMakeOperation(String operation);
        decimal MakeOperation(String operation);


    }
}
