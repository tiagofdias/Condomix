
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioFornecedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioFornecedores));
            this.paneldivisao = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelContactos = new System.Windows.Forms.Panel();
            this.GBContactoAlternativo = new System.Windows.Forms.GroupBox();
            this.txtContactoAlternativo = new System.Windows.Forms.TextBox();
            this.GBEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.GBContacto = new System.Windows.Forms.GroupBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.panelDadosGerais = new System.Windows.Forms.Panel();
            this.GBIBAN = new System.Windows.Forms.GroupBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.GBNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTop3.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelContactos.SuspendLayout();
            this.GBContactoAlternativo.SuspendLayout();
            this.GBEmail.SuspendLayout();
            this.GBContacto.SuspendLayout();
            this.panelDadosGerais.SuspendLayout();
            this.GBIBAN.SuspendLayout();
            this.GBNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldivisao
            // 
            this.paneldivisao.BackColor = System.Drawing.Color.Black;
            this.paneldivisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldivisao.Location = new System.Drawing.Point(0, 67);
            this.paneldivisao.Name = "paneldivisao";
            this.paneldivisao.Size = new System.Drawing.Size(25, 593);
            this.paneldivisao.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSize = true;
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 33);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1104, 34);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(51, 4);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 19);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(13, -1);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelTop3
            // 
            this.panelTop3.AutoScroll = true;
            this.panelTop3.BackColor = System.Drawing.Color.Black;
            this.panelTop3.Controls.Add(this.bttMinimize);
            this.panelTop3.Controls.Add(this.bttExit);
            this.panelTop3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop3.Location = new System.Drawing.Point(0, 0);
            this.panelTop3.Name = "panelTop3";
            this.panelTop3.Size = new System.Drawing.Size(1104, 33);
            this.panelTop3.TabIndex = 0;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.Location = new System.Drawing.Point(1038, 0);
            this.bttMinimize.Name = "bttMinimize";
            this.bttMinimize.Size = new System.Drawing.Size(33, 33);
            this.bttMinimize.TabIndex = 1;
            this.bttMinimize.Text = "‒";
            this.bttMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.UseVisualStyleBackColor = true;
            this.bttMinimize.Click += new System.EventHandler(this.bttMinimize_Click);
            // 
            // bttExit
            // 
            this.bttExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttExit.FlatAppearance.BorderSize = 0;
            this.bttExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.Color.White;
            this.bttExit.Location = new System.Drawing.Point(1071, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.Black;
            this.panelDesktop.Controls.Add(this.paneldivisao);
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Controls.Add(this.panelTop3);
            this.panelDesktop.Controls.Add(this.label10);
            this.panelDesktop.Controls.Add(this.panelContactos);
            this.panelDesktop.Controls.Add(this.panelDadosGerais);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.bttVoltar);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Controls.Add(this.bttFiltrar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1104, 660);
            this.panelDesktop.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Contactos";
            // 
            // panelContactos
            // 
            this.panelContactos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelContactos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContactos.Controls.Add(this.GBContactoAlternativo);
            this.panelContactos.Controls.Add(this.GBEmail);
            this.panelContactos.Controls.Add(this.GBContacto);
            this.panelContactos.ForeColor = System.Drawing.Color.Red;
            this.panelContactos.Location = new System.Drawing.Point(35, 250);
            this.panelContactos.Name = "panelContactos";
            this.panelContactos.Size = new System.Drawing.Size(681, 139);
            this.panelContactos.TabIndex = 1;
            // 
            // GBContactoAlternativo
            // 
            this.GBContactoAlternativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBContactoAlternativo.Controls.Add(this.txtContactoAlternativo);
            this.GBContactoAlternativo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBContactoAlternativo.ForeColor = System.Drawing.Color.White;
            this.GBContactoAlternativo.Location = new System.Drawing.Point(13, 72);
            this.GBContactoAlternativo.Name = "GBContactoAlternativo";
            this.GBContactoAlternativo.Size = new System.Drawing.Size(307, 49);
            this.GBContactoAlternativo.TabIndex = 2;
            this.GBContactoAlternativo.TabStop = false;
            this.GBContactoAlternativo.Text = "Contacto Alternativo";
            // 
            // txtContactoAlternativo
            // 
            this.txtContactoAlternativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtContactoAlternativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactoAlternativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoAlternativo.ForeColor = System.Drawing.Color.White;
            this.txtContactoAlternativo.Location = new System.Drawing.Point(4, 22);
            this.txtContactoAlternativo.MaxLength = 9;
            this.txtContactoAlternativo.Multiline = true;
            this.txtContactoAlternativo.Name = "txtContactoAlternativo";
            this.txtContactoAlternativo.Size = new System.Drawing.Size(278, 20);
            this.txtContactoAlternativo.TabIndex = 0;
            // 
            // GBEmail
            // 
            this.GBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBEmail.Controls.Add(this.txtEmail);
            this.GBEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEmail.ForeColor = System.Drawing.Color.White;
            this.GBEmail.Location = new System.Drawing.Point(342, 17);
            this.GBEmail.Name = "GBEmail";
            this.GBEmail.Size = new System.Drawing.Size(307, 49);
            this.GBEmail.TabIndex = 1;
            this.GBEmail.TabStop = false;
            this.GBEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(3, 22);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // GBContacto
            // 
            this.GBContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBContacto.Controls.Add(this.txtContacto);
            this.GBContacto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBContacto.ForeColor = System.Drawing.Color.White;
            this.GBContacto.Location = new System.Drawing.Point(13, 17);
            this.GBContacto.Name = "GBContacto";
            this.GBContacto.Size = new System.Drawing.Size(307, 49);
            this.GBContacto.TabIndex = 0;
            this.GBContacto.TabStop = false;
            this.GBContacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.ForeColor = System.Drawing.Color.White;
            this.txtContacto.Location = new System.Drawing.Point(4, 23);
            this.txtContacto.MaxLength = 9;
            this.txtContacto.Multiline = true;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(278, 20);
            this.txtContacto.TabIndex = 0;
            // 
            // panelDadosGerais
            // 
            this.panelDadosGerais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosGerais.Controls.Add(this.GBIBAN);
            this.panelDadosGerais.Controls.Add(this.GBNome);
            this.panelDadosGerais.ForeColor = System.Drawing.Color.Red;
            this.panelDadosGerais.Location = new System.Drawing.Point(35, 111);
            this.panelDadosGerais.Name = "panelDadosGerais";
            this.panelDadosGerais.Size = new System.Drawing.Size(681, 93);
            this.panelDadosGerais.TabIndex = 0;
            // 
            // GBIBAN
            // 
            this.GBIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBIBAN.Controls.Add(this.txtIBAN);
            this.GBIBAN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBIBAN.ForeColor = System.Drawing.Color.White;
            this.GBIBAN.Location = new System.Drawing.Point(340, 16);
            this.GBIBAN.Name = "GBIBAN";
            this.GBIBAN.Size = new System.Drawing.Size(307, 49);
            this.GBIBAN.TabIndex = 1;
            this.GBIBAN.TabStop = false;
            this.GBIBAN.Text = "IBAN";
            // 
            // txtIBAN
            // 
            this.txtIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtIBAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIBAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBAN.ForeColor = System.Drawing.Color.White;
            this.txtIBAN.Location = new System.Drawing.Point(2, 22);
            this.txtIBAN.MaxLength = 30;
            this.txtIBAN.Multiline = true;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(279, 20);
            this.txtIBAN.TabIndex = 0;
            // 
            // GBNome
            // 
            this.GBNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBNome.Controls.Add(this.txtNome);
            this.GBNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNome.ForeColor = System.Drawing.Color.White;
            this.GBNome.Location = new System.Drawing.Point(14, 16);
            this.GBNome.Name = "GBNome";
            this.GBNome.Size = new System.Drawing.Size(307, 49);
            this.GBNome.TabIndex = 0;
            this.GBNome.TabStop = false;
            this.GBNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(3, 22);
            this.txtNome.MaxLength = 30;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dados Gerais ";
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(376, 406);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(167, 29);
            this.bttVoltar.TabIndex = 2;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = false;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(549, 406);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(167, 29);
            this.bttGuardar.TabIndex = 3;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = false;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttFiltrar.FlatAppearance.BorderSize = 0;
            this.bttFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFiltrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFiltrar.ForeColor = System.Drawing.Color.White;
            this.bttFiltrar.Location = new System.Drawing.Point(549, 406);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(167, 29);
            this.bttFiltrar.TabIndex = 4;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // FormularioFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1104, 660);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioFornecedores";
            this.Text = "FormularioFornecedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioFornecedores_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTop3.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelContactos.ResumeLayout(false);
            this.GBContactoAlternativo.ResumeLayout(false);
            this.GBContactoAlternativo.PerformLayout();
            this.GBEmail.ResumeLayout(false);
            this.GBEmail.PerformLayout();
            this.GBContacto.ResumeLayout(false);
            this.GBContacto.PerformLayout();
            this.panelDadosGerais.ResumeLayout(false);
            this.GBIBAN.ResumeLayout(false);
            this.GBIBAN.PerformLayout();
            this.GBNome.ResumeLayout(false);
            this.GBNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelContactos;
        private System.Windows.Forms.GroupBox GBContactoAlternativo;
        private System.Windows.Forms.TextBox txtContactoAlternativo;
        private System.Windows.Forms.GroupBox GBEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox GBContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Panel panelDadosGerais;
        private System.Windows.Forms.GroupBox GBIBAN;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.GroupBox GBNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.ErrorProvider erros;
    }
}