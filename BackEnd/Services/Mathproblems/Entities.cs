using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheQuiz.BackEnd.Services.Mathproblems
{
    public class Entities
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public char Symbol { get; set; }
        public Type Type { get; set; }
    }
}