using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Hotel1
{
    public partial class Usuario : MetroForm
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7E8C27T\SQLEXPRESS;Initial Catalog=Hotel1;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlCommand comando;
        SqlDataAdapter da;
        DataSet ds;

        public Usuario()
        {
            InitializeComponent();

            conexao.Open(); //abrir conexao//

            // Comando para inserir na base de dados//
            string query = "Select * from Usuario";
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, conexao);

            da.Fill(ds, "Usuario");

            dataGridView1.DataSource = ds.Tables[0];

            conexao.Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
        void grid()
        {

            conexao.Open(); //abrir conexao//

            // Comando para inserir na base de dados//
            string query = "Select * from Usuario";
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, conexao);

            da.Fill(ds, "Usuario");

            dataGridView1.DataSource = ds.Tables[0];

            conexao.Close();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "INSERT INTO Usuario (Nome,Usuario,Senha,perfil) values (@Nome,@Usuario,@Senha,@perfil)";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
            comando.Parameters.AddWithValue("@perfil", CmbPerfil.Text);
            
            // para executar o comando//
            comando.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Cadastro efecuado com sucesso");
                txtNome.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                CmbPerfil.Text = "";
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            grid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "UPDATE Usuario SET Nome = @Nome, Usuario = @Usuario, Senha= @Senha, perfil =@perfil WHERE id=@id";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@id", txtid.Text);
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
            comando.Parameters.AddWithValue("@perfil", CmbPerfil.Text);
            // para executar o comando//
            comando.ExecuteNonQuery();

            try
            {
                MessageBox.Show("Dados Actualizado com sucesso");
                txtNome.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                CmbPerfil.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CmbPerfil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "Delete Usuario where id= @id";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@id", txtid.Text);


            // para executar o comando//
            comando.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Eliminado com sucesso");
                txtNome.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                CmbPerfil.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            grid();
        }
    }
}

