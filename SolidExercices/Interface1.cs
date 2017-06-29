using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    interface IOperations
    {
        bool CanSum(String operation);
        decimal MakeSum(String operation);
    }
}
