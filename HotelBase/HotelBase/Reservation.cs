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
    public partial class Reservation : Form
    {
        DataSet dsReserv;
        SqlDataAdapter adapter;
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelBase.Properties.Settings.HotelsBaseConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        string sqlSelectReserv = "getApartment";
        string sqlUser = "selectUser";
        string deResApartment = "resetApartment";
        int ApartmentId;

        public Reservation(string username)
        {
            
            InitializeComponent();
            DGReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGReservation.AllowUserToAddRows = false;
            DGReservation.MultiSelect = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //получение юзера
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

                    int UserId = dataTableUser.Rows[0].Field<int>("UserId");
                    //получение брони
                    SqlCommand commandSelectReserv = new SqlCommand(sqlSelectReserv, connection);
                    commandSelectReserv.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter userIdParam = new SqlParameter
                    {
                        ParameterName = "@userId",
                        Value = UserId
                    };

                    commandSelectReserv.Parameters.Add(userIdParam);

                    SqlDataAdapter adapter = new SqlDataAdapter(commandSelectReserv);
                    
                    dsReserv = new DataSet();
                    adapter.Fill(dsReserv);

                    DGReservation.DataSource = dsReserv.Tables[0];

                    DGReservation.Columns["ApartmentId"].ReadOnly = true;
                    DGReservation.Columns["Room"].ReadOnly = true;
                    DGReservation.Columns["HotelName"].ReadOnly = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User user = new User(GBReserve.Text);
            user.Show();
            this.Hide();
        }

        public void btnDeRes_Click(object sender, EventArgs e)
        {
            //процедура разбронирования
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand commandDeRes = new SqlCommand(deResApartment, connection);
                    commandDeRes.CommandType = System.Data.CommandType.StoredProcedure;


                    //id номера
                    string ApartmentId = DGReservation[0, DGReservation.CurrentRow.Index].Value.ToString();

                    SqlParameter apartmentParam = new SqlParameter
                    {
                        ParameterName = "@apartmentId",
                        Value = ApartmentId
                    };

                    commandDeRes.Parameters.Add(apartmentParam);
                    SqlDataAdapter adapter = new SqlDataAdapter(commandDeRes);
                    adapter.UpdateCommand = commandDeRes;
                    adapter.Fill(dsReserv);
                    adapter.Update(dsReserv);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
