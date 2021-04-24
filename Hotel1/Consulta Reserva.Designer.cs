
namespace Hotel1
{
    partial class Consulta_Reserva
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.DataSaida = new System.Windows.Forms.MaskedTextBox();
            this.DataEntrada = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data Reserva:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 173);
            this.dataGridView1.TabIndex = 22;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(141, 67);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 23;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(142, 100);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(151, 20);
            this.Nome.TabIndex = 24;
            // 
            // DataSaida
            // 
            this.DataSaida.Location = new System.Drawing.Point(467, 63);
            this.DataSaida.Mask = "00/00/0000";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.Size = new System.Drawing.Size(100, 20);
            this.DataSaida.TabIndex = 25;
            this.DataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // DataEntrada
            // 
            this.DataEntrada.Location = new System.Drawing.Point(467, 100);
            this.DataEntrada.Mask = "00/00/0000";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.Size = new System.Drawing.Size(100, 20);
            this.DataEntrada.TabIndex = 26;
            this.DataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // Consulta_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataEntrada);
            this.Controls.Add(this.DataSaida);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Reserva";
            this.Text = "Consulta_Reserva";
            this.Load += new System.EventHandler(this.Consulta_Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.MaskedTextBox DataSaida;
        private System.Windows.Forms.MaskedTextBox DataEntrada;
    }
}