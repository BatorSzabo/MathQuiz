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
using MatheQuiz;
using MatheQuiz.Forms;

namespace MatheQuiz.Forms
{
    public partial class Aufgabe : Form
    {
        private MainService mainServiceInst;

        public Aufgabe(MainService mainService)
        {
            mainServiceInst = mainService;
            KeyPreview = true;
            InitializeComponent();
            prg_bar.Maximum = mainService.ProgresbarMaxValue;
            prg_bar.Minimum = mainService.ProgressBarMinValue;
        }

        public void UpdateUI(DispalyEntities entities)
        {
            label_first_value.Text = entities.FirstNum.ToString();
            label_mathsymbol.Text = entities.Symbol.ToString();
            label_second_value.Text = entities.SecondNum.ToString();
            prg_bar.Value = entities.ProgresBarValue;
        }

        public void UpdateScore(string score)
        {
            label_score.Text = score.ToString();
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                mainServiceInst.testInputText(txt_input.Text);
                txt_input.Text = null;
            }
        }

        private void Aufgabe_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainServiceInst.CloseProgram();
        }
    }
}