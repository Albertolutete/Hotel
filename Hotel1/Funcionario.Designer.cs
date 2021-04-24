
namespace Hotel1
{
    partial class Funcionario
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
            this.cbx_perfil = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbx_cpf = new MetroFramework.Controls.MetroTextBox();
            this.mlb_tel = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.tbx_bairro = new MetroFramework.Controls.MetroTextBox();
            this.tbx_email = new MetroFramework.Controls.MetroTextBox();
            this.mtbx_nome = new MetroFramework.Controls.MetroTextBox();
            this.lb_cep = new MetroFramework.Controls.MetroLabel();
            this.mlb_bairro = new MetroFramework.Controls.MetroLabel();
            this.lb_CIdade = new MetroFramework.Controls.MetroLabel();
            this.lb_email = new MetroFramework.Controls.MetroLabel();
            this.lb_cpf = new MetroFramework.Controls.MetroLabel();
            this.lb_Estado = new MetroFramework.Controls.MetroLabel();
            this.lb_nome = new MetroFramework.Controls.MetroLabel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_perfil
            // 
            this.cbx_perfil.FormattingEnabled = true;
            this.cbx_perfil.ItemHeight = 23;
            this.cbx_perfil.Items.AddRange(new object[] {
            "Limpeza",
            "Atendente",
            "Gerente",
            "Supervisor",
            "Jardineiro"});
            this.cbx_perfil.Location = new System.Drawing.Point(456, 199);
            this.cbx_perfil.Name = "cbx_perfil";
            this.cbx_perfil.Size = new System.Drawing.Size(160, 29);
            this.cbx_perfil.TabIndex = 51;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(414, 206);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Perfil :";
            // 
            // tbx_cpf
            // 
            this.tbx_cpf.Location = new System.Drawing.Point(456, 77);
            this.tbx_cpf.Name = "tbx_cpf";
            this.tbx_cpf.Size = new System.Drawing.Size(219, 23);
            this.tbx_cpf.TabIndex = 49;
            // 
            // mlb_tel
            // 
            this.mlb_tel.AutoSize = true;
            this.mlb_tel.Location = new System.Drawing.Point(414, 181);
            this.mlb_tel.Name = "mlb_tel";
            this.mlb_tel.Size = new System.Drawing.Size(36, 19);
            this.mlb_tel.TabIndex = 48;
            this.mlb_tel.Text = "TEL :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "BL",
            "PA",
            "BR",
            "MT"});
            this.metroComboBox1.Location = new System.Drawing.Point(100, 110);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(143, 29);
            this.metroComboBox1.TabIndex = 47;
            // 
            // metroTextBox10
            // 
            this.metroTextBox10.Location = new System.Drawing.Point(456, 141);
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.Size = new System.Drawing.Size(219, 23);
            this.metroTextBox10.TabIndex = 45;
            // 
            // metroTextBox9
            // 
            this.metroTextBox9.Location = new System.Drawing.Point(456, 170);
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.Size = new System.Drawing.Size(219, 23);
            this.metroTextBox9.TabIndex = 44;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.Location = new System.Drawing.Point(456, 110);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(219, 23);
            this.metroTextBox7.TabIndex = 42;
            // 
            // tbx_bairro
            // 
            this.tbx_bairro.Location = new System.Drawing.Point(99, 145);
            this.tbx_bairro.Name = "tbx_bairro";
            this.tbx_bairro.Size = new System.Drawing.Size(219, 23);
            this.tbx_bairro.TabIndex = 40;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(88, 181);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(219, 23);
            this.tbx_email.TabIndex = 39;
            // 
            // mtbx_nome
            // 
            this.mtbx_nome.Location = new System.Drawing.Point(100, 81);
            this.mtbx_nome.Name = "mtbx_nome";
            this.mtbx_nome.Size = new System.Drawing.Size(219, 23);
            this.mtbx_nome.TabIndex = 37;
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(410, 145);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(40, 19);
            this.lb_cep.TabIndex = 35;
            this.lb_cep.Text = "CEP :";
            // 
            // mlb_bairro
            // 
            this.mlb_bairro.AutoSize = true;
            this.mlb_bairro.Location = new System.Drawing.Point(41, 150);
            this.mlb_bairro.Name = "mlb_bairro";
            this.mlb_bairro.Size = new System.Drawing.Size(52, 19);
            this.mlb_bairro.TabIndex = 34;
            this.mlb_bairro.Text = "Bairro :";
            // 
            // lb_CIdade
            // 
            this.lb_CIdade.AutoSize = true;
            this.lb_CIdade.Location = new System.Drawing.Point(408, 110);
            this.lb_CIdade.Name = "lb_CIdade";
            this.lb_CIdade.Size = new System.Drawing.Size(51, 19);
            this.lb_CIdade.TabIndex = 32;
            this.lb_CIdade.Text = "Cidade";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(41, 185);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(41, 19);
            this.lb_email.TabIndex = 31;
            this.lb_email.Text = "Email";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(410, 81);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(40, 19);
            this.lb_cpf.TabIndex = 30;
            this.lb_cpf.Text = "CPF :";
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Location = new System.Drawing.Point(39, 120);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(55, 19);
            this.lb_Estado.TabIndex = 29;
            this.lb_Estado.Text = "Estado :";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(41, 81);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(53, 19);
            this.lb_nome.TabIndex = 28;
            this.lb_nome.Text = "Nome :";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(66, 458);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 53;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 150);
            this.dataGridView1.TabIndex = 54;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(303, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(185, 458);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 504);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbx_perfil);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbx_cpf);
            this.Controls.Add(this.mlb_tel);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox10);
            this.Controls.Add(this.metroTextBox9);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.tbx_bairro);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.mtbx_nome);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.mlb_bairro);
            this.Controls.Add(this.lb_CIdade);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_Estado);
            this.Controls.Add(this.lb_nome);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbx_perfil;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbx_cpf;
        private MetroFramework.Controls.MetroLabel mlb_tel;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox10;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox tbx_bairro;
        private MetroFramework.Controls.MetroTextBox tbx_email;
        private MetroFramework.Controls.MetroTextBox mtbx_nome;
        private MetroFramework.Controls.MetroLabel lb_cep;
        private MetroFramework.Controls.MetroLabel mlb_bairro;
        private MetroFramework.Controls.MetroLabel lb_CIdade;
        private MetroFramework.Controls.MetroLabel lb_email;
        private MetroFramework.Controls.MetroLabel lb_cpf;
        private MetroFramework.Controls.MetroLabel lb_Estado;
        private MetroFramework.Controls.MetroLabel lb_nome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlterar;
    }
}