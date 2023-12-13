using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheQuiz;
using MatheQuiz.BackEnd.Services;
using MatheQuiz.Forms;

namespace MatheQuiz.Forms
{
    public partial class Endscreen : Form
    {
        private MainService mainServiceInst;

        public Endscreen(MainService mainService)
        {
            mainServiceInst = mainService;

            InitializeComponent();
        }

        public void UpdateScoreText(int score)
        {
            label_endscore.Text = $"Du hast {score} aus 10 richtig";
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
        }

        private void Endscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainServiceInst.Ini();
        }
    }
}