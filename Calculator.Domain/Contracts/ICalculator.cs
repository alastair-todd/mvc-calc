using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Contracts
{
    public interface ICalculator
    {
        object Calc(string expression);
    }
}
