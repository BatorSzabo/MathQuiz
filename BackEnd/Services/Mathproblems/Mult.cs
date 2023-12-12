using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheQuiz.BackEnd.Services.Mathproblems
{
    internal class Mult : Operations
    {
        public Mult()
        {
            OperatorSymbol = '*';
        }

        public override int Calculation(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}