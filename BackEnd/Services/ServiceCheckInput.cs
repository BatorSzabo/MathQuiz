using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheQuiz.BackEnd.Services.Mathproblems;

namespace MatheQuiz.BackEnd.Services
{
    public class ServiceCheckInput
    {
        public bool Checkinginput(int input, Operations val, int firsNum, int secondNum)
        {
            int solution = val.Calculation(firsNum, secondNum);
            if (solution == input)
            {
                return true;
            }
            return false;
        }
    }
}