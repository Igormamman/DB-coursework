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
    public partial class group_formA : Form
    {
        int index_;
        public group_formA()
        {
            InitializeComponent();
        }
        public group_formA(int index)
        {
            InitializeComponent();
            index_ = index-1;
        }


        private void groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void group_formA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.kind_of_sport". При необходимости она может быть перемещена или удалена.
            this.kind_of_sportTableAdapter.Fill(this.бД_Спортивная_школаDataSet.kind_of_sport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Group);
            groupBindingNavigator.BindingSource.Position = index_;

        }

        private void students_in_group_button_Click(object sender, EventArgs e)
        {
            int group_index = int.Parse(id__of_GroupTextBox.Text);
            Amount_of_students_Form amount_Of_Students_ = new Amount_of_students_Form(group_index);
            amount_Of_Students_.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
