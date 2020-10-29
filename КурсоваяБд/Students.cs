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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            ScheduleFormA sc = new ScheduleFormA();
            sc.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
