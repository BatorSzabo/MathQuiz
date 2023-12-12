using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
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
    }
}