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
using MatheQuiz.Forms;

namespace MatheQuiz.Forms
{
    public partial class Endscreen : Form
    {
        private int Endscore;

        public Endscreen(int score)
        {
            Endscore = score;
            InitializeComponent();
            label_endscore.Text = $"Dein Score ist {Endscore}/10";
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
        }

        private void Endscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }
    }
}