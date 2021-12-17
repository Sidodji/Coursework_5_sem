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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //хеширование пароля
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelBase.Properties.Settings.HotelsBaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string sqlLoginUser = "loginUser";
                String loginUser = tbox_user.Text;
                String passUser = tbox_pass.Text;
                String passUserHash = GetHash(passUser);

                connection.Open();

                SqlCommand commandLoginUser = new SqlCommand(sqlLoginUser, connection);
                commandLoginUser.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usernameParam = new SqlParameter
                {
                    ParameterName = "@userLogin", Value = loginUser
                };

                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@userPass", Value = passUserHash
                };

                commandLoginUser.Parameters.Add(usernameParam);
                commandLoginUser.Parameters.Add(passwordParam);

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandLoginUser);
                DataSet dataSet = new DataSet();
               
                //перебираем строки
                
                adapter.SelectCommand = commandLoginUser;
                adapter.Fill(dataTable);

                //если есть строки в таблице
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //проверка ролей
                        var role = row.Field<int>("Role");
                        if(role == 1)
                        {
                            Admin admin = new Admin();
                            admin.Show(this);
                            MessageBox.Show("Admin");
                            tbox_user.Text = null;
                            tbox_pass.Text = null;
                            this.Hide();
                        }
                        else
                        {
                            User user = new User(tbox_user.Text);
                            user.Show();
                            tbox_user.Text = null;
                            tbox_pass.Text = null;
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Try again");
                    tbox_user.Text = null;
                    tbox_pass.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tbox_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(this);
            registration.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
