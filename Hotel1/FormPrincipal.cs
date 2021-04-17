using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
         
         
            
           
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_termniar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quarto n = new Quarto();
            n.ShowDialog();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            foto1.Visible = false;
            foto2.Visible = false;
            foto3.Visible = false;
        }

        private void btbVisualizar_Click(object sender, EventArgs e)
        {
            foto1.Visible = false;
            foto2.Visible = false;
            foto3.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foto1.Visible = false;
            foto2.Visible = false;
            foto3.Visible = false;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            foto1.Visible = false;
            foto2.Visible = false;
            foto3.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            foto1.Visible = true;
            foto2.Visible = true;
            foto3.Visible = true;
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario n = new Funcionario();
            n.ShowDialog();
        }

        private void hospedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hospede n = new Hospede();
            n.ShowDialog();

        }
    }
}
