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
    public partial class StartMenu : Form
    {
        private MainMenu mainMenu = new MainMenu();

        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Aufgabe aufgabe = new Aufgabe();
            aufgabe.Show();
        }
    }
}