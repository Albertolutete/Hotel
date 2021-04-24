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
using MetroFramework.Forms;


namespace Hotel1
{
    public partial class Login : MetroForm
    {

   
        
        //refercia da conexao//
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7E8C27T\SQLEXPRESS;Initial Catalog=Hotel1;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            

            tbxUsuario.Select();
        }
        void verificar()
        {
            if (tbxUsuario.Text == "" && tbxSenha.Text  == "")
            {
                MessageBox.Show("Prencha os campos vazios ", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUsuario.Select();
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//
            verificar();
            string query = "SELECT *FROM Usuario WHERE Usuario ='" +tbxUsuario.Text+"'AND Senha =  '"+tbxSenha.Text+ "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);



            try
            {
                if (dt.Rows.Count == 1)
                {
                     FormPrincipal principal = new FormPrincipal();
                      principal.Show();
                     this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Usuario nao cadastrado");
                    tbxUsuario.Text = "";//limpar txtbox//
                    tbxSenha.Text = "";
                 
                }
            }
              catch(Exception )
            {

                throw;


               
            }
           
            conexao.Close();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
