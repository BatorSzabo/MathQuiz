using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheQuiz.BackEnd.Services.Mathproblems
{
    internal class Add : Operations
    {
        public Add()
        {
            OperatorSymbol = '+';
        }

        public override int Calculation(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}