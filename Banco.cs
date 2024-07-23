using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;


namespace TaskManagmentGUI
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\gvalm\\source\\repos\\TaskManagmentGUI\\TaskManagmentGUI\\BD\\tarefas.bd");
            conexao.Open();
            return conexao;
        }

        private static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM USUARIOS";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Query(string SQL)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = SQL;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }



        // METODOS DE SING UP
        // METODOS DE SING UP


        public static void CreateUser(Usuarios u)
        {
            MessageBox.Show("DSS");


            if (ExistsUsername(u))
            {
                MessageBox.Show("Username already exists");
                return;
            }

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())

                {
                    MessageBox.Show("To aqui");
                    cmd.CommandText = "INSERT INTO Usuarios (USERNAME, PASSWORD) VALUES (@username, @password)";
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New user created");

                }

            }

            catch (Exception e)
            {
                MessageBox.Show("ERRO ao cadastrar");
                throw e;

            }
        }


        private static bool ExistsUsername(Usuarios u)

        {

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            MessageBox.Show("Após DSS");

            var cmd = ConexaoBanco().CreateCommand();

            cmd.CommandText = "SELECT * from USUARIOS where USERNAME = '" +u.username+ "'";

            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);

            MessageBox.Show("Dentro do TRY de exists");


            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

    }
 
}

