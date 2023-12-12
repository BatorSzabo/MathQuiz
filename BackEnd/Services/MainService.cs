using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheQuiz.BackEnd.Services.Mathproblems;
using MatheQuiz.FrontEnd;

namespace MatheQuiz.BackEnd.Services
{
    public class MainService
    {
        private Random Random = new Random();
        public Entities entities = new Entities();
        public Operations val;
        private ServiceCheckInput checkInput = new ServiceCheckInput();

        public List<Entities> TypeList = new List<Entities>()
        {
          new Entities()
          {
            Type = typeof(Add),
          },
          new Entities()
          {
              Type = typeof(Sub),
          },
          new Entities()
          {
              Type= typeof(Mult),
          }
        };

        public DispalyEntities CreateNewProblem()
        {
            entities.FirstNumber = Random.Next(1, 10);
            entities.SecondNumber = Random.Next(1, 10);
            int index = Random.Next(1, TypeList.Count);
            List<Type> Type = TypeList.Select(x => x.Type).ToList();
            Type OperatorType = Type.ToArray()[index];
            val = (Operations)Activator.CreateInstance(OperatorType);
            entities.Symbol = val.OperatorSymbol;
            var DisplayValues = AllocateValuesForDisplay(entities.FirstNumber, entities.SecondNumber, entities.Symbol);
            return DisplayValues;
        }

        public DispalyEntities AllocateValuesForDisplay(int FirstNumber, int SecondNumber, char Symbol)
        {
            DispalyEntities dispalyEntities = new DispalyEntities();
            dispalyEntities.FirstNum = FirstNumber.ToString();
            dispalyEntities.SecondNum = SecondNumber.ToString();
            dispalyEntities.Symbol = Symbol.ToString();

            return dispalyEntities;
        }

        public bool passInput(int input)
        {
            return checkInput.Checkinginput(input, val, entities.FirstNumber, entities.SecondNumber);
        }
    }
}