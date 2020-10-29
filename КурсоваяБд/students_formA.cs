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
    public partial class students_formA : Form
    {
        public students_formA()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void students_formA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Group". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Students);
    

        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            string s = groupComboBox.Text;
            ScheduleStudent scheduleStudent = new ScheduleStudent(s);
            scheduleStudent.Show();
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
