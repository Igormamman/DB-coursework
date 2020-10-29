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
    public partial class Place_Form : Form
    {
        int index_;
        public Place_Form()
        {
            InitializeComponent();
        }
        public Place_Form(int index)
        {
            InitializeComponent();
            index_ = index - 1;
        }

        private void placeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.placeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_Спортивная_школаDataSet);

        }

        private void Place_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Спортивная_школаDataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.бД_Спортивная_школаDataSet.Place);
            placeBindingNavigator.BindingSource.Position = index_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_report p = new Place_report();
            p.Show();

        }
    }
}
