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

namespace Hotel1
{
    public partial class TesteCadastro : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7E8C27T\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlCommand comando;
        SqlDataAdapter dp = new SqlDataAdapter();

        public TesteCadastro()
        {

           

            InitializeComponent();
            tbxNome.Select();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conexao.Open(); //abrir conexao//

            string query = "INSERT INTO CadTexte (Nome,Cidade,Tel) values (@Nome,@Cidade,@Tel)";

            comando = new SqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@Nome", tbxNome.Text);
            comando.Parameters.AddWithValue("@Cidade", CombCidade.Text);
            comando.Parameters.AddWithValue("@Tel", MaskTel.Text);
            comando.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Cadastro efecuado com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
