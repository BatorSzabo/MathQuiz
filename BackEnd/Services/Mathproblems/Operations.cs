using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheQuiz.BackEnd.Services.Mathproblems
{
    public abstract class Operations
    {
        public char OperatorSymbol { get; set; }

        public virtual int Calculation(int firstNumber, int secondNumber)
        {
            return 0;
        }
    }
}