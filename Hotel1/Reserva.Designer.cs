
namespace Hotel1
{
    partial class Reserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.CombxQuarto = new System.Windows.Forms.ComboBox();
            this.dataGReserva = new System.Windows.Forms.DataGridView();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quarto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 20);
            this.txtNome.TabIndex = 7;
            // 
            // CombxQuarto
            // 
            this.CombxQuarto.FormattingEnabled = true;
            this.CombxQuarto.Location = new System.Drawing.Point(82, 73);
            this.CombxQuarto.Name = "CombxQuarto";
            this.CombxQuarto.Size = new System.Drawing.Size(88, 21);
            this.CombxQuarto.TabIndex = 8;
            // 
            // dataGReserva
            // 
            this.dataGReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGReserva.Location = new System.Drawing.Point(24, 181);
            this.dataGReserva.Name = "dataGReserva";
            this.dataGReserva.Size = new System.Drawing.Size(746, 169);
            this.dataGReserva.TabIndex = 9;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(271, 70);
            this.txtMes.Mask = "0000";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 10;
            this.txtMes.ValidatingType = typeof(System.DateTime);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(571, 76);
            this.txtAno.Mask = "00/00/0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 11;
            this.txtAno.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(326, 112);
            this.txtTelefone.Mask = "(99) 000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(534, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 20);
            this.txtValor.TabIndex = 13;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(457, 73);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(49, 20);
            this.txtDias.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(50, 398);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(178, 398);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(312, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.dataGReserva);
            this.Controls.Add(this.CombxQuarto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox CombxQuarto;
        private System.Windows.Forms.DataGridView dataGReserva;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEliminar;
    }
}