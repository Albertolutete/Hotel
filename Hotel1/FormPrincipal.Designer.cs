
namespace Hotel1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnCentral = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btbInfo = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Lb_Acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foto3 = new System.Windows.Forms.PictureBox();
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(153, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 122);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tela Inicial";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.reservarToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(6, 82);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartosToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.hospedesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarToolStripMenuItem.Image = global::Hotel1.Properties.Resources._1486564412_plus_815111;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Image = global::Hotel1.Properties.Resources.Quarto;
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.quartosToolStripMenuItem.Text = "Quartos";
            this.quartosToolStripMenuItem.Click += new System.EventHandler(this.quartosToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Image = global::Hotel1.Properties.Resources.funcionario;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // hospedesToolStripMenuItem
            // 
            this.hospedesToolStripMenuItem.Image = global::Hotel1.Properties.Resources.hospede;
            this.hospedesToolStripMenuItem.Name = "hospedesToolStripMenuItem";
            this.hospedesToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.hospedesToolStripMenuItem.Text = "Hospedes";
            this.hospedesToolStripMenuItem.Click += new System.EventHandler(this.hospedesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vagaToolStripMenuItem,
            this.visualizarVagasToolStripMenuItem});
            this.reservarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reservarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservarToolStripMenuItem.Image")));
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.reservarToolStripMenuItem.Text = "Reservar";
            // 
            // vagaToolStripMenuItem
            // 
            this.vagaToolStripMenuItem.Name = "vagaToolStripMenuItem";
            this.vagaToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.vagaToolStripMenuItem.Text = "Nova Reserva";
            this.vagaToolStripMenuItem.Click += new System.EventHandler(this.vagaToolStripMenuItem_Click);
            // 
            // visualizarVagasToolStripMenuItem
            // 
            this.visualizarVagasToolStripMenuItem.Name = "visualizarVagasToolStripMenuItem";
            this.visualizarVagasToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.visualizarVagasToolStripMenuItem.Text = "Visualizar Vagas";
            this.visualizarVagasToolStripMenuItem.Click += new System.EventHandler(this.visualizarVagasToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Image = global::Hotel1.Properties.Resources.get_info_13806;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoToolStripMenuItem.Image = global::Hotel1.Properties.Resources.eyevision_1228541;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.infoToolStripMenuItem.Text = "Visualizar";
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.Location = new System.Drawing.Point(0, 493);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(155, 97);
            this.btnFerramentas.TabIndex = 4;
            this.btnFerramentas.Text = "Ferramentas";
            this.btnFerramentas.UseVisualStyleBackColor = true;
            this.btnFerramentas.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCentral
            // 
            this.btnCentral.Location = new System.Drawing.Point(0, 120);
            this.btnCentral.Name = "btnCentral";
            this.btnCentral.Size = new System.Drawing.Size(155, 108);
            this.btnCentral.TabIndex = 3;
            this.btnCentral.Text = "Central";
            this.btnCentral.UseVisualStyleBackColor = true;
            this.btnCentral.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(0, 410);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(155, 94);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check IN/OUT";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btbInfo
            // 
            this.btbInfo.Location = new System.Drawing.Point(0, 210);
            this.btbInfo.Name = "btbInfo";
            this.btbInfo.Size = new System.Drawing.Size(155, 107);
            this.btbInfo.TabIndex = 0;
            this.btbInfo.Text = "Info";
            this.btbInfo.UseVisualStyleBackColor = true;
            this.btbInfo.Click += new System.EventHandler(this.btbVisualizar_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(0, 309);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(155, 112);
            this.btnRelatorios.TabIndex = 1;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.Lb_Acesso);
            this.panel3.Location = new System.Drawing.Point(981, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 590);
            this.panel3.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(101, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 24);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sair";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Lb_Acesso
            // 
            this.Lb_Acesso.AutoSize = true;
            this.Lb_Acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Acesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Acesso.Location = new System.Drawing.Point(3, 176);
            this.Lb_Acesso.Name = "Lb_Acesso";
            this.Lb_Acesso.Size = new System.Drawing.Size(78, 24);
            this.Lb_Acesso.TabIndex = 0;
            this.Lb_Acesso.Text = "Acesso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hotel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFerramentas);
            this.panel2.Controls.Add(this.btnCentral);
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.btbInfo);
            this.panel2.Controls.Add(this.btnRelatorios);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 590);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel1.Properties.Resources.get_info_138061;
            this.pictureBox3.Location = new System.Drawing.Point(11, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hotel1.Properties.Resources._1486395874_settings_80622;
            this.pictureBox5.Location = new System.Drawing.Point(3, 520);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 46);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Hotel1.Properties.Resources._3615751_banknote_cash_cheque_money_order_payment_voucher_107903;
            this.pictureBox4.Location = new System.Drawing.Point(3, 427);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel1.Properties.Resources.report_file_icon_148347;
            this.pictureBox2.Location = new System.Drawing.Point(25, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 31);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel1.Properties.Resources.pequenho_home;
            this.pictureBox1.Location = new System.Drawing.Point(21, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // foto3
            // 
            this.foto3.Image = global::Hotel1.Properties.Resources.unnamed;
            this.foto3.Location = new System.Drawing.Point(671, 121);
            this.foto3.Name = "foto3";
            this.foto3.Size = new System.Drawing.Size(310, 183);
            this.foto3.TabIndex = 6;
            this.foto3.TabStop = false;
            // 
            // foto2
            // 
            this.foto2.Image = global::Hotel1.Properties.Resources.imagem_de_hote_1;
            this.foto2.Location = new System.Drawing.Point(394, 121);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(281, 183);
            this.foto2.TabIndex = 5;
            this.foto2.TabStop = false;
            // 
            // foto1
            // 
            this.foto1.Image = global::Hotel1.Properties.Resources.images;
            this.foto1.Location = new System.Drawing.Point(156, 121);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(256, 183);
            this.foto1.TabIndex = 4;
            this.foto1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1145, 594);
            this.ControlBox = false;
            this.Controls.Add(this.foto3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.foto2);
            this.Controls.Add(this.foto1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnCentral;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btbInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.PictureBox foto3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarVagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label Lb_Acesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}