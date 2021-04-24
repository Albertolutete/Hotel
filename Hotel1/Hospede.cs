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
    public partial class Hospede : MetroForm
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7E8C27T\SQLEXPRESS;Initial Catalog=Hotel1;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlCommand comando;
        SqlDataAdapter da ;
        DataSet ds;
        
        public Hospede()
        {
            InitializeComponent();
            txtId.Visible = false;
        }
        void grid()
        {

            conexao.Open(); //abrir conexao//

            // Comando para inserir na base de dados//
            string query = "Select * from Hospede";
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, conexao);
         
            da.Fill(ds,"Hospede");

            dataGridView1.DataSource = ds.Tables[0];

            conexao.Close();

        }

        private void Hospede_Load(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//

             // Comando para inserir na base de dados//
             string query = "Select * from Hospede";
              ds = new DataSet();
             da = new SqlDataAdapter(query, conexao);

             da.Fill(ds, "Hospede");

             dataGridView1.DataSource = ds.Tables[0];

             conexao.Close();
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "INSERT INTO Hospede (Nome,Telefone,Cpf,Estado,Cidadade) values (@Nome,@Telefone,@Cpf,@Estado,@Cidadade)";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Telefone",tbxTel.Text );
            comando.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
            comando.Parameters.AddWithValue("@Estado", txtEstado.Text);
            comando.Parameters.AddWithValue("@Cidadade", txtcidade.Text);

            // para executar o comando//
            comando.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Cadastro efecuado com sucesso");
                txtNome.Text = "";
                 tbxTel.Text = "";
                TxtCpf.Text = "";
                txtEstado.Text = "";
                txtcidade.Text = "";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // comando para selecionar dados apartir do datagrid e mostar nas txtboxs//
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtCpf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcidade.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "UPDATE Hospede SET Nome = @Nome,Telefone = @Telefone,Cpf= @Cpf, Estado =@Estado, Cidadade=@Cidadade WHERE id=@id";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@id",txtId.Text);
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Telefone", tbxTel.Text);
            comando.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
            comando.Parameters.AddWithValue("@Estado", txtEstado.Text);
            comando.Parameters.AddWithValue("@Cidadade", txtcidade.Text);
            // para executar o comando//
            comando.ExecuteNonQuery();
      
            try
            {
                MessageBox.Show("Dados Actualizado com sucesso");
                txtNome.Text = "";
                tbxTel.Text = "";
                TxtCpf.Text = "";
                txtEstado.Text = "";
                txtcidade.Text = "";

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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//
            // Comando para inserir na base de dados//
            string query = "Delete Hospede where id= @id";

            comando = new SqlCommand(query, conexao);
            //paramentro para entrada na base de dados em questao//
            comando.Parameters.AddWithValue("@id", txtId.Text);
          

            // para executar o comando//
            comando.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Eliminado com sucesso");
                txtNome.Text = "";
                tbxTel.Text = "";
                TxtCpf.Text = "";
                txtEstado.Text = "";
                txtcidade.Text = "";

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
