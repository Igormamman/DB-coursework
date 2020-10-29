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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void studentsA_button_Click(object sender, EventArgs e)
        {
            StudentsA studentsA = new StudentsA();
            studentsA.Show();
        }

        private void trainersA_button_Click(object sender, EventArgs e)
        {
            TrainersA trainersA = new TrainersA();
            trainersA.Show();
        }

        private void scheduleA_button_Click(object sender, EventArgs e)
        {
            Schedule_A scheduleA = new Schedule_A();
            scheduleA.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }
    }
}
