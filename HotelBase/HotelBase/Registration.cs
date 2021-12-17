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
using System.ComponentModel.DataAnnotations;

namespace HotelBase
{
    public partial class Registration : Form
    {
        String loginUser;
        String nameUser;
        String surnameUser;
        String passUser;
        String passUserCon;
       
        public Registration()
        {
            InitializeComponent();

        }

        public Registration(Login loginForm)
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


        private void btn_reg_Click(object sender, EventArgs e)
        {
            //навание процедры
            string sqlAddUser = "addUser";

            //данные полей 
            
            loginUser = tbox_user.Text;
            passUser = tbox_pass.Text;
            passUserCon = tbox_conpas.Text;
            nameUser = tbox_name.Text;
            surnameUser = tbox_surname.Text;
            string passUserHash = GetHash(passUser);
            
            
            string connectionString = ConfigurationManager.ConnectionStrings["HotelBase.Properties.Settings.HotelsBaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand commandAddUser = new SqlCommand(sqlAddUser, connection);
                commandAddUser.CommandType = System.Data.CommandType.StoredProcedure;
                //параметры процедуры
                SqlParameter usernameParam = new SqlParameter
                {
                    ParameterName = "@username",
                    Value = loginUser
                };

                SqlParameter passParamHash = new SqlParameter
                {
                    ParameterName = "@password",
                    Value = passUserHash
                };

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@firstName",
                    Value = nameUser
                };

                SqlParameter surnameParam = new SqlParameter
                {
                    ParameterName = "@lastName",
                    Value = surnameUser
                };

                commandAddUser.Parameters.Add(usernameParam);
                commandAddUser.Parameters.Add(passParamHash);
                commandAddUser.Parameters.Add(nameParam);
                commandAddUser.Parameters.Add(surnameParam);


                if (passUserCon == passUser && passUser !="" && loginUser!="")
                {
                    //выполняем процедуру
                    if (commandAddUser.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User was created");
                        User user = new User(tbox_user.Text);
                        user.Show();
                        tbox_user.Text = null;
                        tbox_name.Text = null;
                        tbox_pass.Text = null;
                        tbox_conpas.Text = null;
                        tbox_surname.Text = null;
                        this.Hide();
                    }
                    else
                    {
                        tbox_user.Text = null;
                        tbox_name.Text = null;
                        tbox_pass.Text = null;
                        tbox_conpas.Text = null;
                        tbox_surname.Text = null;
                        MessageBox.Show("User was not created");
                    }
                        
                }
                else
                {
                    tbox_user.Text = null;
                    tbox_name.Text = null;
                    tbox_pass.Text = null;
                    tbox_conpas.Text = null;
                    tbox_surname.Text = null;
                    MessageBox.Show("check fields");
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
