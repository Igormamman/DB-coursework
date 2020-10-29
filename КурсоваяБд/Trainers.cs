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
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
        }

        private void trainers_button_Click(object sender, EventArgs e)
        {
            TrainersA trainersA = new TrainersA();
            trainersA.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleStudent schedule = new ScheduleStudent();
            schedule.Show();
        }

        private void search_st_button_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Search_student_Form students_Info_Form = new Search_student_Form(s);
            students_Info_Form.Show();
        }
    }
}
