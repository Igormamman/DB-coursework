using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяБд
{
    public partial class Search_student_Form : Form
    {
        public Search_student_Form(string full_name)
        {
            InitializeComponent();
            string mybdpath = "D:\\Загрузки\\БД Спортивная школа.accdb";
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            String query = String.Format("select Id_of_St as Индекс, Full_name as ФИО, Group_name as Группа, [Address] as Адрес, " +
"Tel_number as Тел_номер, Отчисление " +
"from(Students inner join[Group] on([Group].[Id_ of_Group] = Students.[Group])) where Full_name = '{0}'",full_name);

            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }
    }
}
