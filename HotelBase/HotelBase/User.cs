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
using System.Security.Cryptography;

namespace HotelBase
{
    public partial class User : Form
    { 
        DataSet dsRooms;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelBase.Properties.Settings.HotelsBaseConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        string sqlSelectRooms = "AllUserApartments";
        string resApartment = "resApartment";
        string resetApartment = "resetApartment";
        int UserId;

        public User(string username)
        {
            InitializeComponent();
            DGVRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVRooms.AllowUserToAddRows = false;
            DGVRooms.MultiSelect = false;
            groupBoxUser.Text = username;
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand commandSelectRooms = new SqlCommand(sqlSelectRooms, connection);
                    commandSelectRooms.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(commandSelectRooms);
                    dsRooms = new DataSet();
                    adapter.Fill(dsRooms);
                    DGVRooms.DataSource = dsRooms.Tables[0];
                    //делаем недоступным для изменений
                    DGVRooms.Columns["ApartmentId"].ReadOnly = true;
                    DGVRooms.Columns["Room"].ReadOnly = true;
                    DGVRooms.Columns["Booked"].ReadOnly = true;
                    DGVRooms.Columns["HotelName"].ReadOnly = true;
                    //DGVRooms.Columns["UserId"].ReadOnly = true;

                    //получение инфы юзера
                    string sqlUser = "selectUser";

                    SqlCommand commandUser = new SqlCommand(sqlUser, connection);
                    commandUser.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    SqlParameter usernameParam = new SqlParameter
                    {
                        ParameterName = "@username",
                        Value = username
                    };

                    commandUser.Parameters.Add(usernameParam);

                    DataTable dataTableUser = new DataTable();
                    SqlDataAdapter adapterUser = new SqlDataAdapter(commandUser);
                    DataSet dataSetUser = new DataSet();

                    adapterUser.SelectCommand = commandUser;
                    adapterUser.Fill(dataTableUser);

                    lblName.Text = dataTableUser.Rows[0].Field<string>("FirstName");
                    lblSurname.Text = dataTableUser.Rows[0].Field<string>("LastName");
                    UserId = dataTableUser.Rows[0].Field<int>("UserId");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlPassUser= "updateUserPass";
                string pass = tboxNewPass.Text;
                string pass2 = tboxNewPass2.Text;
                if(pass == pass2)
                {
                    string passUser = GetHash(pass);
                    connection.Open();
                    SqlCommand commandPassUser = new SqlCommand(sqlPassUser, connection);
                    commandPassUser.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter userIdParam = new SqlParameter
                    {
                        ParameterName = "@userId",
                        Value = UserId
                    };

                    SqlParameter userPassParam = new SqlParameter
                    {
                        ParameterName = "@userPass",
                        Value = passUser
                    };

                    commandPassUser.Parameters.Add(userIdParam);
                    commandPassUser.Parameters.Add(userPassParam);
                    if (commandPassUser.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Password changed");
                    }
                    else
                    {
                        MessageBox.Show("Password not changed");
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("The password does not match");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnReserve_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandSelectRooms = new SqlCommand(sqlSelectRooms, connection);
            commandSelectRooms.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commandSelectRooms);
            
            string brook = DGVRooms[3, DGVRooms.CurrentRow.Index].Value.ToString();
            string ApartmentId = DGVRooms[0, DGVRooms.CurrentRow.Index].Value.ToString();
            string sqlUser = "selectUser";

            //получаем юзера
            SqlCommand commandUser = new SqlCommand(sqlUser, connection);
            commandUser.CommandType = System.Data.CommandType.StoredProcedure;
            String Username = groupBoxUser.Text;

            SqlParameter usernameParam = new SqlParameter
            {
                ParameterName = "@username",
                Value = Username
            };

            commandUser.Parameters.Add(usernameParam);

            DataTable dataTableUser = new DataTable();
            SqlDataAdapter adapterUser = new SqlDataAdapter(commandUser);
            DataSet dataSetUser = new DataSet();

            adapterUser.SelectCommand = commandUser;
            adapterUser.Fill(dataTableUser);

            int UserID = dataTableUser.Rows[0].Field<int>("UserId");

            if (brook == "2")
            {
                MessageBox.Show("Bron");

                //выполняем процедуру бронирования
                SqlCommand commandBron = new SqlCommand(resApartment, connection);
                commandBron.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter apartmentParam = new SqlParameter
                {
                    ParameterName = "@apartmentId",
                    Value = ApartmentId
                };

                SqlParameter userIdParam = new SqlParameter
                {
                    ParameterName = "@userId",
                    Value = UserID
                };

                commandBron.Parameters.Add(apartmentParam);
                commandBron.Parameters.Add(userIdParam);

                SqlDataAdapter adapterBron = new SqlDataAdapter(commandBron);
                adapterBron.UpdateCommand = commandBron;
                adapterBron.Fill(dsRooms);
                adapterBron.Update(dsRooms);
            }
            else
            {
                MessageBox.Show("This room is already booked");
            }
            connection.Close();

        }

        private void btnBron_Click(object sender, EventArgs e)
        {
            String Username = groupBoxUser.Text;
            Reservation reservation = new Reservation(Username);
            reservation.Show();
            reservation.GBReserve.Text = Username;
            this.Hide();
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void groupBoxUser_Enter(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void tboxNewPass2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
