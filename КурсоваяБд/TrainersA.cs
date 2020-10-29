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
    public partial class TrainersA : Form
    {
        public TrainersA()
        {
            InitializeComponent();
        }

        private void trainersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void TrainersA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Trainers);
        }

        private void trainer_sc_button_Click(object sender, EventArgs e)
        {
            string fullname = full_nameTextBox.Text;
            Trainer_Sc_Form trainer_Sc_ = new Trainer_Sc_Form(fullname);
            trainer_Sc_.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trainers_report t = new Trainers_report();
            t.Show();
        }
    }
}
