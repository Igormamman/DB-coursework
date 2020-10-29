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
    public partial class StudentsA : Form
    {
        public StudentsA()
        {
            InitializeComponent();
        }


        private void students_form_button_Click(object sender, EventArgs e)
        {
            students_formA students_FormA = new students_formA();
            students_FormA.Show();

        }

        private void group_form_button_Click(object sender, EventArgs e)
        {
            group_formA gf = new group_formA();
            gf.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = search__st_textBox.Text;
            Search_student_Form search_Student_ = new Search_student_Form(s);
            search_Student_.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = search_sc_textBox.Text;
            Search_schedule_Form search_Schedule_ = new Search_schedule_Form(s);
            search_Schedule_.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Groups_Info_Form groups_Info_ = new Groups_Info_Form();
            groups_Info_.Show();
        }
    }
}
