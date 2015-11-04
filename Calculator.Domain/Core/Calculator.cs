using Calculator.Domain.Contracts;
using NCalc;

namespace Calculator.Domain.Core
{
    public class Calculator: ICalculator
    {
        public object Calc(string expression)
        {
            // facade ncalc for mocking
            Expression e = new Expression(expression);
            return e.Evaluate();
        }
    }
}
