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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_singUp_Click(object sender, EventArgs e)
        {

            Usuarios usuario = new Usuarios();

            usuario.username = tb_SINGuser.Text;
            usuario.password = tb_SINGuser.Text;

            Banco.CreateUser(usuario);
        }
    }
}
