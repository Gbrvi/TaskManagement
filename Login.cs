using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagmentGUI
{
    public partial class Login : Form
    {
        Form1 form1;
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Username or Password are null");
                tb_username.Focus();
                return;
            }

            string SQL = $"SELECT * FROM Usuarios WHERE USERNAME = '{username}' AND PASSWORD = '{password}'";
            DataTable dt = Banco.Query(SQL);

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("User not found");
                tb_username.Clear();
                tb_password.Clear();
                tb_username.Focus();
                return;
            }

            MessageBox.Show("Login efetuado!");
            this.Close();

          
        }
    }
}
