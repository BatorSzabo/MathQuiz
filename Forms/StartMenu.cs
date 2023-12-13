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
using MatheQuiz.BackEnd.Services;

namespace MatheQuiz.Forms
{
    public partial class StartMenu : Form
    {
        private MainService mainService;

        public StartMenu(MainService mainService)
        {
            this.mainService = mainService;
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            mainService.ShowTaskForm();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainService.CloseProgram();
        }
    }
}