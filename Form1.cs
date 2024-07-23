namespace TaskManagmentGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro F_newUser = new Cadastro();

            F_newUser.ShowDialog();
        }
    }
}
