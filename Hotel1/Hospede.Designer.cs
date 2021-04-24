
namespace Hotel1
{
    partial class Hospede
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_excluir = new MetroFramework.Controls.MetroButton();
            this.btn_editar = new MetroFramework.Controls.MetroButton();
            this.txtcidade = new MetroFramework.Controls.MetroTextBox();
            this.TxtCpf = new MetroFramework.Controls.MetroTextBox();
            this.tbxTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(333, 409);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(71, 34);
            this.btn_excluir.TabIndex = 30;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(201, 409);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(71, 34);
            this.btn_editar.TabIndex = 29;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(344, 96);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(187, 23);
            this.txtcidade.TabIndex = 27;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(321, 63);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(144, 23);
            this.TxtCpf.TabIndex = 26;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(91, 92);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(160, 23);
            this.tbxTel.TabIndex = 25;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(284, 96);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Cidade:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "TEL :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(284, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "CPF :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Nome :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(62, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 34);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Adicionar";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 150);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 23);
            this.txtNome.TabIndex = 32;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(556, 63);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(187, 23);
            this.txtEstado.TabIndex = 34;
            this.txtEstado.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(496, 63);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Estado";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(694, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 35;
            // 
            // Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 489);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_add);
            this.Name = "Hospede";
            this.Text = "Hospede";
            this.Load += new System.EventHandler(this.Hospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_excluir;
        private MetroFramework.Controls.MetroButton btn_editar;
        private MetroFramework.Controls.MetroTextBox txtcidade;
        private MetroFramework.Controls.MetroTextBox TxtCpf;
        private MetroFramework.Controls.MetroTextBox tbxTel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtEstado;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtId;
    }
}