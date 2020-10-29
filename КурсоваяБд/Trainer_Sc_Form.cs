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
    public partial class Trainer_Sc_Form : Form
    {
        public Trainer_Sc_Form(string fullname)
        {
            InitializeComponent();
            string mybdpath = "D:\\Загрузки\\БД Спортивная школа.accdb";
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();

            String query = String.Format("select Group_name as Группа, " +
                "Trainers.Full_name as Тренер, Place as Номер_зала, start_time as время_начала, " +
                "end_time as время_конца, [kind of sport].Sport_name as Вид_спорта, " +
                "Day as День, Rating as Рейтинг " +
                "from ((Lessons " +
                "inner join Trainers on (Lessons.Trainer = Trainers.Id_of_trainer)) " +
                "inner join [Group] on ([Lessons].[Group] = [Group].[Id_ of_Group])) " +
                "inner join [kind of sport] on ([Lessons].Sport = [kind of sport].Id_of_sport) " +
                "where Full_name = '{0}'", fullname);

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
