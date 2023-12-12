using MatheQuiz.BackEnd.Services;
using MatheQuiz.BackEnd.Services.Mathproblems;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheQuiz.FrontEnd;
using System.Globalization;
using System.Threading;

namespace MatheQuiz
{
    public partial class Aufgabe : Form
    {
        private MainService mainService = new MainService();
        private ServiceCheckInput serviceCheckInput = new ServiceCheckInput();
        private DispalyEntities DisplayEntity = new DispalyEntities();

        private int inputInt = 0;
        private int score = 0;
        private int counter = 0;

        private CancellationTokenSource currentCancellationTokenSource;

        public Aufgabe()
        {
            KeyPreview = true;
            InitializeComponent();
            GetNewExercise();
        }

        private void UpdateUI()
        {
            label_score.Text = $"Score : {score}";
        }

        private async void GetNewExercise()
        {
            counter++;
            if (counter > 10)
            {
                OpenEndScreen();
                this.Hide();
                return;
            }
            prg_bar.Value = 0;
            DisplayEntity = mainService.CreateNewProblem();
            label_first_value.Text = DisplayEntity.FirstNum;
            label_mathsymbol.Text = DisplayEntity.Symbol;
            label_second_value.Text = DisplayEntity.SecondNum;
            prg_bar.Maximum = 5010;
            prg_bar.Minimum = 0;
            currentCancellationTokenSource = new CancellationTokenSource();
            CancellationToken ct = currentCancellationTokenSource.Token;
            for (int i = 0; i < 500; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                int v = prg_bar.Value;
                prg_bar.Value += 10;
                await Task.Delay(10);
            }

            GetNewExercise();
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    inputInt = Convert.ToInt32(txt_input.Text);
                    bool verdict = false;

                    verdict = mainService.passInput(inputInt);

                    if (verdict)
                    {
                        CancelTask();

                        score++;
                        txt_input.Text = null;
                        UpdateUI();
                        GetNewExercise();
                    }
                    else
                    {
                        CancelTask();
                        txt_input.Text = null;

                        GetNewExercise();
                    }
                }
                catch (FormatException)
                {
                    return;
                }
            }
        }

        private void CancelTask()
        {
            if (currentCancellationTokenSource != null)
            {
                currentCancellationTokenSource.Cancel();
            }
        }

        private void OpenEndScreen()
        {
            Endscreen endscreen = new Endscreen(score);
            endscreen.Show();
        }
    }
}