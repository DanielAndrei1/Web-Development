using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Elevator
{



    public partial class Database : Form1
    {

        public void Insert_req_lv0()
        {
            string connetionString = null;
            OleDbConnection connection;
            DateTime currentDate = DateTime.Now;
            currentDate.ToString("d/m/yyyy");

            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\Elevator\Elevator\Database.mdb";
           
            try
            {
                connection = new OleDbConnection(connetionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Elevator( Request, Floor, [Date and time]) values( 'Request at floor 0', '0', @data)";
                command.Parameters.AddWithValue("@data", currentDate);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public void Insert_reg_lv1()
        {


            DateTime currentDate = DateTime.Now;
            currentDate.ToString("d/m/yyyy");
            string connetionString = null;
            OleDbConnection connection;
            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\Elevator\Elevator\Database.mdb";

            try
            {
                connection = new OleDbConnection(connetionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "insert into Elevator( Request, Floor, [Date and time]) values( 'Request at floor 1', '1', @data)";
                command.Parameters.AddWithValue("@data", currentDate);
                command.Connection = connection;

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }




    }

}


