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
    public partial class ScheduleFormA : Form
    {
        bool allow_edits = true;
        public ScheduleFormA()
        {
            InitializeComponent();
        }
        public ScheduleFormA(bool ans)
        {
            InitializeComponent();
            allow_edits = ans;
        }

        private void lessonsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lessonsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void ScheduleA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.kind_of_sport". При необходимости она может быть перемещена или удалена.
            this.kind_of_sportTableAdapter.Fill(this.бД_Спортивная_школаDataSet.kind_of_sport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Trainers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Lessons". При необходимости она может быть перемещена или удалена.
            this.lessonsTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Lessons);

          
            lessonsBindingNavigator.BindingSource.Position = 0; // МЕГА ВАЖНООООООООООООООООООООООООООООООООООО
            id_of_lessonTextBox.ReadOnly = true;
            if (allow_edits == false)
            {
                
            }


        }

        private void group_info_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_of_lessonTextBox.Text);
            DataView r = ((DataRowView)lessonsBindingSource[0]).DataView;
            int index = r.Table.Rows[id - 1].Field<int>("Group");
            group_formA group_FormA = new group_formA(index);
            group_FormA.Show();
        }

        private void sport_info_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_of_lessonTextBox.Text);
            DataView r = ((DataRowView)lessonsBindingSource[0]).DataView;
            int index = r.Table.Rows[id - 1].Field<int>("Sport");
            Kind_of_sport_Form group_FormA = new Kind_of_sport_Form(index);
            group_FormA.Show();
        }

        private void place_info_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_of_lessonTextBox.Text);
            DataView r = ((DataRowView)lessonsBindingSource[0]).DataView;
            int index = r.Table.Rows[id - 1].Field<int>("Place");
            Place_Form group_FormA = new Place_Form(index);
            group_FormA.Show();
        }

   
    }
}
