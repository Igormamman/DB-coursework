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
    public partial class Kind_of_sport_Form : Form
    {
        int index_;
        public Kind_of_sport_Form()
        {
            InitializeComponent();
        }
        public Kind_of_sport_Form(int index)
        {
            InitializeComponent();
            index_ = index - 1;
        }

        private void kind_of_sportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kind_of_sportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void Kind_of_sport_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.kind_of_sport". При необходимости она может быть перемещена или удалена.
            this.kind_of_sportTableAdapter.Fill(this.бД_Спортивная_школаDataSet.kind_of_sport);
            kind_of_sportBindingNavigator.BindingSource.Position = index_;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kind_of_sport_report k = new Kind_of_sport_report();
            k.Show();
        }
    }
}
