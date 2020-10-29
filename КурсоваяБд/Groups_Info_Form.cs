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
    public partial class Groups_Info_Form : Form
    {
        public Groups_Info_Form()
        {
            InitializeComponent();
            string mybdpath = "D:\\Загрузки\\БД Спортивная школа.accdb";
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            String query = "select [Id_ of_Group] as Индекс, Group_name as Название, [kind of sport].Sport_name as Дисциплина, " +
"(select count(*) from Students where Students.[Group] = [Group].[Id_ of_Group]) as Количество_учеников " +
"from([Group] inner join[kind of sport] on[Group].discipline = [kind of sport].Id_of_sport)";

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
