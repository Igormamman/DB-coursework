using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяБд
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void administration_button_Click(object sender, EventArgs e)
        {
            Administration adm_form = new Administration();
            adm_form.Show();
        }

        private void students_button_Click(object sender, EventArgs e)
        {
            Students std_form = new Students();
            std_form.Show();
        }

        private void trainers_button_Click(object sender, EventArgs e)
        {
            Trainers tr_form = new Trainers();
            tr_form.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
    }
}
