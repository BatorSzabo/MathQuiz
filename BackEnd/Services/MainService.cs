using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheQuiz.BackEnd.Services.Mathproblems;
using MatheQuiz.Forms;
using MatheQuiz.FrontEnd;

namespace MatheQuiz.BackEnd.Services
{
    public class MainService
    {// global variable
        private CancellationTokenSource currentCancellationTokenSource;
        private int inputInt = 0, score = 0, progressBarValue = 0, counter = 0;
        private Endscreen endscreenForm;
        private Aufgabe aufgabeForm;
        private StartMenu startForm;
        private Random Random = new Random();
        private ServiceCheckInput checkInput = new ServiceCheckInput();

        public Entities entities = null;
        public Operations val;
        public int ProgressBarMinValue = 0, ProgresbarMaxValue = 5010;

        public List<Type> TypeList = new List<Type>()
        {
             typeof(Add),

              typeof(Sub),

              typeof(Mult),
        };

        /// <summary>
        /// calls the StartmenuForm
        /// </summary>
        public void Ini()
        {
            startForm = new StartMenu(this);
            startForm.Show();
            score = 0;
            counter = 0;
        }

        /// <summary>
        /// Calls the aufgabeForm
        /// </summary>
        public void ShowTaskForm()
        {
            startForm.Hide();
            aufgabeForm = new Aufgabe(this);
            aufgabeForm.Show();
            GetNewExerciseAsync();
        }

        /// <summary>
        /// calls endscreenForm
        /// </summary>
        public void ShowEndscreen()
        {
            counter = 0;
            progressBarValue = 0;
            aufgabeForm.Hide();
            endscreenForm = new Endscreen(this);
            endscreenForm.Show();
        }

        /// <summary>
        /// async method for creatiing new excercise later used for the UI and for the background.
        /// </summary>
        private async void GetNewExerciseAsync()
        {
            counter++;
            if (counter > 10)
            {
                ShowEndscreen();
                return;
            }
            progressBarValue = 0;
            CreateNewProblem();
            aufgabeForm.UpdateUI(AllocateValuesForDisplay(entities));
            currentCancellationTokenSource = new CancellationTokenSource();
            CancellationToken ct = currentCancellationTokenSource.Token;
            for (int i = 0; i < 500; i++)
            {
                aufgabeForm.UpdateUI(AllocateValuesForDisplay(entities));

                if (ct.IsCancellationRequested)
                {
                    return;
                }
                await Task.Delay(10);
                progressBarValue += 10;
            }
            GetNewExerciseAsync();
        }

        /// <summary>
        /// declares the values for the excercise
        /// </summary>
        public void CreateNewProblem()
        {
            entities = new Entities();
            entities.FirstNumber = Random.Next(1, 10);
            entities.SecondNumber = Random.Next(1, 10);
            int index = Random.Next(1, TypeList.Count);
            Type OperatorType = TypeList.ToArray()[index];
            val = (Operations)Activator.CreateInstance(OperatorType);
            entities.op = val;
        }

        /// <summary>
        /// returns the values for the UI
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>DisplayEntity Object</returns>
        public DispalyEntities AllocateValuesForDisplay(Entities entities)
        {
            DispalyEntities dispalyEntities = new DispalyEntities();
            dispalyEntities.FirstNum = entities.FirstNumber.ToString();
            dispalyEntities.SecondNum = entities.SecondNumber.ToString();
            dispalyEntities.Symbol = entities.op.OperatorSymbol.ToString();
            dispalyEntities.ProgresBarValue = progressBarValue;

            return dispalyEntities;
        }

        /// <summary>
        /// passes textbox input for check input class and returns true if input == solution for the excercise
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Boolean</returns>
        public bool PassInput(int input)
        {
            return checkInput.Checkinginput(input, val, entities.FirstNumber, entities.SecondNumber);
        }

        /// <summary>
        /// Updates score UI
        /// </summary>
        public void UpdateScore()
        {
            string currentScore = $"Score: {score}";
            aufgabeForm.UpdateScore(currentScore);
        }

        /// <summary>
        /// checks if textbox input is a number
        /// </summary>
        /// <param name="str"></param>
        public void testInputText(string str)
        {
            try
            {
                inputInt = Convert.ToInt32(str);
                bool verdict = false;

                verdict = PassInput(inputInt);

                if (verdict)
                {
                    CancelTask();

                    score++;

                    UpdateScore();
                    GetNewExerciseAsync();
                }
                else
                {
                    CancelTask();

                    GetNewExerciseAsync();
                }
            }
            catch (FormatException)
            {
                return;
            }
        }

        /// <summary>
        /// requests a cancelTokenrequest
        /// </summary>
        public void CancelTask()
        {
            if (currentCancellationTokenSource != null)

            {
                currentCancellationTokenSource.Cancel();
            }
        }

        /// <summary>
        /// returns end state for score in a string
        /// </summary>
        /// <returns>String</returns>
        public string DisplayEndScore()
        {
            return $"Dein Score ist {score}/10";
        }

        /// <summary>
        /// closes Application
        /// </summary>

        public void CloseProgram()
        {
            Application.ExitThread();
        }
    }
}