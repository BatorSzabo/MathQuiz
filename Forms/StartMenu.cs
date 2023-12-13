using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheQuiz.Forms;
using MatheQuiz;

namespace MatheQuiz.Forms
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aufgabe aufgabe = new Aufgabe();
            aufgabe.Show();
        }
    }
}