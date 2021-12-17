using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HotelBase
{
    public partial class Admin : Form
    {
        DataSet dsHotels;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelBase.Properties.Settings.HotelsBaseConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        string sql = "SELECT * FROM Hotels";

        public Admin()
        {
            InitializeComponent();
            DGVHotels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVHotels.AllowUserToAddRows = false;
            string sqlSelectHotels = "selectHotels";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand commandSelectHotels = new SqlCommand(sqlSelectHotels, connection);
                    commandSelectHotels.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(commandSelectHotels);
                    dsHotels = new DataSet();
                    adapter.Fill(dsHotels);
                    DGVHotels.DataSource = dsHotels.Tables[0];
                    // делаем недоступным столбец id для изменения
                    DGVHotels.Columns["HotelId"].ReadOnly = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
           
        }
        //обработка ошибок 
        private void DGVHotels_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Input Error!");
            e.ThrowException = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dsHotels.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dsHotels.Tables[0].Rows.Add(row);
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //удаляем все выделенные строки
            foreach (DataGridViewRow row in DGVHotels.SelectedRows)
            {
                DGVHotels.Rows.Remove(row);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(sql, connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = new SqlCommand("addHotel", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 64, "Name"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@rooms", SqlDbType.Int, 0, "Rooms"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@capacity", SqlDbType.Int, 0, "Capacity"));

            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@hotelId", SqlDbType.Int, 0, "HotelId");
            parameter.Direction = ParameterDirection.Output;

            try
            {
                adapter.Update(dsHotels);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string sqlExpression = "ExportUsersXML";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    if(command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Export");
                    }
                    else
                    {
                        MessageBox.Show("Dont Export");
                    }
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string sqlExpression = "ImportUsersXML";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Import");
                    }
                    else
                    {
                        MessageBox.Show("Dont Import");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
