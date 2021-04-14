
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
            this.btn_salvar = new MetroFramework.Controls.MetroButton();
            this.tbx_endereço = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tbx_cpf = new MetroFramework.Controls.MetroTextBox();
            this.btn_addicionar = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(416, 409);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(71, 49);
            this.btn_excluir.TabIndex = 30;
            this.btn_excluir.Text = "Excluir";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(298, 409);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(71, 49);
            this.btn_editar.TabIndex = 29;
            this.btn_editar.Text = "Editar";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(176, 409);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(80, 49);
            this.btn_salvar.TabIndex = 28;
            this.btn_salvar.Text = "Salvar";
            // 
            // tbx_endereço
            // 
            this.tbx_endereço.Location = new System.Drawing.Point(640, 66);
            this.tbx_endereço.Name = "tbx_endereço";
            this.tbx_endereço.Size = new System.Drawing.Size(187, 23);
            this.tbx_endereço.TabIndex = 27;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(375, 64);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(144, 23);
            this.metroTextBox1.TabIndex = 26;
            // 
            // tbx_cpf
            // 
            this.tbx_cpf.Location = new System.Drawing.Point(375, 121);
            this.tbx_cpf.Name = "tbx_cpf";
            this.tbx_cpf.Size = new System.Drawing.Size(160, 23);
            this.tbx_cpf.TabIndex = 25;
            // 
            // btn_addicionar
            // 
            this.btn_addicionar.Location = new System.Drawing.Point(292, 127);
            this.btn_addicionar.Name = "btn_addicionar";
            this.btn_addicionar.Size = new System.Drawing.Size(17, 17);
            this.btn_addicionar.TabIndex = 24;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(91, 115);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(195, 29);
            this.metroComboBox2.TabIndex = 23;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.metroComboBox1.Location = new System.Drawing.Point(115, 66);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 22;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(563, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Endereço :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Quarto :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(333, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "TEL :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(313, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "CPF :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Nome :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(62, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 49);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Adicionar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.tbx_endereço);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.tbx_cpf);
            this.Controls.Add(this.btn_addicionar);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
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
        private MetroFramework.Controls.MetroButton btn_salvar;
        private MetroFramework.Controls.MetroTextBox tbx_endereço;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox tbx_cpf;
        private MetroFramework.Controls.MetroButton btn_addicionar;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}