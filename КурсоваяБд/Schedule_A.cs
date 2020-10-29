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
    public partial class Schedule_A : Form
    {
        public Schedule_A()
        {
            InitializeComponent();
        }

        private void schedule_form_button_Click(object sender, EventArgs e)
        {
            ScheduleFormA scheduleFormA = new ScheduleFormA(); 
            scheduleFormA.Show();
        }

        private void day_schedule_button_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            search_day_s_scheduleForm sc = new search_day_s_scheduleForm(s);
            sc.Show();
        }

  

        private void sorted_schedule_button_Click(object sender, EventArgs e)
        {
            Search_schedule_Form sc = new Search_schedule_Form();
            sc.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_A_Load(object sender, EventArgs e)
        {
                
        }
    }
}
