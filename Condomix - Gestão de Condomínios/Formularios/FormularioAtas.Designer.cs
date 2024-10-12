
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioAtas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAtas));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.panelDadosGerais = new System.Windows.Forms.Panel();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.GBData = new System.Windows.Forms.GroupBox();
            this.dtpData = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.GBCondominio = new System.Windows.Forms.GroupBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.cbCondominio = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.bttAbrirDocumento = new System.Windows.Forms.Button();
            this.bttAdicionarDocumento = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.paneldivisao = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDesktop.SuspendLayout();
            this.panelDadosGerais.SuspendLayout();
            this.GBData.SuspendLayout();
            this.GBNome.SuspendLayout();
            this.GBCondominio.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.bttVoltar);
            this.panelDesktop.Controls.Add(this.panelDadosGerais);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Controls.Add(this.bttFiltrar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(25, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1106, 628);
            this.panelDesktop.TabIndex = 0;
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(354, 272);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(167, 29);
            this.bttVoltar.TabIndex = 1;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = false;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // panelDadosGerais
            // 
            this.panelDadosGerais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosGerais.Controls.Add(this.lblDocumento);
            this.panelDadosGerais.Controls.Add(this.GBData);
            this.panelDadosGerais.Controls.Add(this.GBNome);
            this.panelDadosGerais.Controls.Add(this.GBCondominio);
            this.panelDadosGerais.Controls.Add(this.bttAbrirDocumento);
            this.panelDadosGerais.Controls.Add(this.bttAdicionarDocumento);
            this.panelDadosGerais.Controls.Add(this.txtDocumento);
            this.panelDadosGerais.ForeColor = System.Drawing.Color.Red;
            this.panelDadosGerais.Location = new System.Drawing.Point(13, 45);
            this.panelDadosGerais.Name = "panelDadosGerais";
            this.panelDadosGerais.Size = new System.Drawing.Size(681, 212);
            this.panelDadosGerais.TabIndex = 0;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(14, 133);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(69, 15);
            this.lblDocumento.TabIndex = 87;
            this.lblDocumento.Text = "Documento";
            // 
            // GBData
            // 
            this.GBData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBData.Controls.Add(this.dtpData);
            this.GBData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBData.ForeColor = System.Drawing.Color.White;
            this.GBData.Location = new System.Drawing.Point(14, 71);
            this.GBData.Name = "GBData";
            this.GBData.Size = new System.Drawing.Size(307, 49);
            this.GBData.TabIndex = 2;
            this.GBData.TabStop = false;
            this.GBData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpData.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpData.ButtonColor = System.Drawing.Color.White;
            this.dtpData.CustomFormat = " dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Image = null;
            this.dtpData.Location = new System.Drawing.Point(2, 17);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(279, 27);
            this.dtpData.TabIndex = 0;
            this.dtpData.TextColor = System.Drawing.Color.White;
            this.dtpData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpData_MouseDown);
            // 
            // GBNome
            // 
            this.GBNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBNome.Controls.Add(this.txtNome);
            this.GBNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNome.ForeColor = System.Drawing.Color.White;
            this.GBNome.Location = new System.Drawing.Point(340, 16);
            this.GBNome.Name = "GBNome";
            this.GBNome.Size = new System.Drawing.Size(307, 49);
            this.GBNome.TabIndex = 1;
            this.GBNome.TabStop = false;
            this.GBNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(3, 19);
            this.txtNome.MaxLength = 50;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(278, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // GBCondominio
            // 
            this.GBCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBCondominio.Controls.Add(this.txtCondominio);
            this.GBCondominio.Controls.Add(this.cbCondominio);
            this.GBCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBCondominio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCondominio.ForeColor = System.Drawing.Color.White;
            this.GBCondominio.Location = new System.Drawing.Point(14, 16);
            this.GBCondominio.Name = "GBCondominio";
            this.GBCondominio.Size = new System.Drawing.Size(307, 49);
            this.GBCondominio.TabIndex = 0;
            this.GBCondominio.TabStop = false;
            this.GBCondominio.Text = "Condomínio";
            // 
            // txtCondominio
            // 
            this.txtCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtCondominio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCondominio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondominio.ForeColor = System.Drawing.Color.White;
            this.txtCondominio.Location = new System.Drawing.Point(3, 20);
            this.txtCondominio.MaxLength = 30;
            this.txtCondominio.Multiline = true;
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(278, 20);
            this.txtCondominio.TabIndex = 0;
            this.txtCondominio.Visible = false;
            // 
            // cbCondominio
            // 
            this.cbCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondominio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.ForeColor = System.Drawing.Color.White;
            this.cbCondominio.FormattingEnabled = true;
            this.cbCondominio.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.Location = new System.Drawing.Point(2, 15);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(279, 28);
            this.cbCondominio.TabIndex = 82;
            // 
            // bttAbrirDocumento
            // 
            this.bttAbrirDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttAbrirDocumento.FlatAppearance.BorderSize = 0;
            this.bttAbrirDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAbrirDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAbrirDocumento.ForeColor = System.Drawing.Color.White;
            this.bttAbrirDocumento.Location = new System.Drawing.Point(17, 160);
            this.bttAbrirDocumento.Name = "bttAbrirDocumento";
            this.bttAbrirDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAbrirDocumento.TabIndex = 3;
            this.bttAbrirDocumento.Text = "Visualizar";
            this.bttAbrirDocumento.UseVisualStyleBackColor = false;
            this.bttAbrirDocumento.Click += new System.EventHandler(this.bttAbrirDocumento_Click);
            // 
            // bttAdicionarDocumento
            // 
            this.bttAdicionarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttAdicionarDocumento.FlatAppearance.BorderSize = 0;
            this.bttAdicionarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionarDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdicionarDocumento.ForeColor = System.Drawing.Color.White;
            this.bttAdicionarDocumento.Location = new System.Drawing.Point(17, 160);
            this.bttAdicionarDocumento.Name = "bttAdicionarDocumento";
            this.bttAdicionarDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAdicionarDocumento.TabIndex = 4;
            this.bttAdicionarDocumento.Text = "Adicionar";
            this.bttAdicionarDocumento.UseVisualStyleBackColor = false;
            this.bttAdicionarDocumento.Click += new System.EventHandler(this.bttAdicionarDocumento_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.White;
            this.txtDocumento.Location = new System.Drawing.Point(174, 160);
            this.txtDocumento.MaxLength = 400;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(10, 29);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ata";
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(527, 272);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(167, 29);
            this.bttGuardar.TabIndex = 2;
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
            this.bttFiltrar.Location = new System.Drawing.Point(527, 272);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(167, 29);
            this.bttFiltrar.TabIndex = 3;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            // 
            // paneldivisao
            // 
            this.paneldivisao.BackColor = System.Drawing.Color.Black;
            this.paneldivisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldivisao.Location = new System.Drawing.Point(0, 67);
            this.paneldivisao.Name = "paneldivisao";
            this.paneldivisao.Size = new System.Drawing.Size(25, 628);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1131, 34);
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
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.BookReader;
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
            this.panelTop3.Size = new System.Drawing.Size(1131, 33);
            this.panelTop3.TabIndex = 1;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.Location = new System.Drawing.Point(1065, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1098, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // FormularioAtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 695);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioAtas";
            this.Text = "FormularioAtas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioAtas_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelDadosGerais.ResumeLayout(false);
            this.panelDadosGerais.PerformLayout();
            this.GBData.ResumeLayout(false);
            this.GBNome.ResumeLayout(false);
            this.GBNome.PerformLayout();
            this.GBCondominio.ResumeLayout(false);
            this.GBCondominio.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTop3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Panel panelDadosGerais;
        private System.Windows.Forms.Button bttAbrirDocumento;
        private System.Windows.Forms.Button bttAdicionarDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.GroupBox GBData;
        private NormalDateTimePicker dtpData;
        private System.Windows.Forms.GroupBox GBNome;
        private System.Windows.Forms.GroupBox GBCondominio;
        private CustomCombobox cbCondominio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.RichTextBox txtDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.TextBox txtNome;
    }
}