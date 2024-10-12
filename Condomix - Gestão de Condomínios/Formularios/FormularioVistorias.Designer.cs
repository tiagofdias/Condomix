
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioVistorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVistorias));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelVistorias = new System.Windows.Forms.Panel();
            this.GBData = new System.Windows.Forms.GroupBox();
            this.dtpData = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBNomeFuncionario = new System.Windows.Forms.GroupBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.GBDescritivo = new System.Windows.Forms.GroupBox();
            this.txtDescritivo = new System.Windows.Forms.RichTextBox();
            this.GBCondominio = new System.Windows.Forms.GroupBox();
            this.cbCondominio = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.GBNIFFuncionario = new System.Windows.Forms.GroupBox();
            this.txtNIFFuncionario = new System.Windows.Forms.TextBox();
            this.GBTitulo = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttVoltar = new System.Windows.Forms.Button();
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
            this.panelVistorias.SuspendLayout();
            this.GBData.SuspendLayout();
            this.GBNomeFuncionario.SuspendLayout();
            this.GBDescritivo.SuspendLayout();
            this.GBCondominio.SuspendLayout();
            this.GBNIFFuncionario.SuspendLayout();
            this.GBTitulo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.Black;
            this.panelDesktop.Controls.Add(this.panelVistorias);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.bttVoltar);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Controls.Add(this.bttFiltrar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(25, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(954, 586);
            this.panelDesktop.TabIndex = 0;
            // 
            // panelVistorias
            // 
            this.panelVistorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelVistorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVistorias.Controls.Add(this.GBData);
            this.panelVistorias.Controls.Add(this.GBNomeFuncionario);
            this.panelVistorias.Controls.Add(this.GBDescritivo);
            this.panelVistorias.Controls.Add(this.GBCondominio);
            this.panelVistorias.Controls.Add(this.GBNIFFuncionario);
            this.panelVistorias.Controls.Add(this.GBTitulo);
            this.panelVistorias.ForeColor = System.Drawing.Color.Red;
            this.panelVistorias.Location = new System.Drawing.Point(11, 43);
            this.panelVistorias.Name = "panelVistorias";
            this.panelVistorias.Size = new System.Drawing.Size(681, 356);
            this.panelVistorias.TabIndex = 0;
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
            // GBNomeFuncionario
            // 
            this.GBNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBNomeFuncionario.Controls.Add(this.txtNomeFuncionario);
            this.GBNomeFuncionario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.GBNomeFuncionario.Location = new System.Drawing.Point(340, 71);
            this.GBNomeFuncionario.Name = "GBNomeFuncionario";
            this.GBNomeFuncionario.Size = new System.Drawing.Size(307, 49);
            this.GBNomeFuncionario.TabIndex = 3;
            this.GBNomeFuncionario.TabStop = false;
            this.GBNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNomeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(3, 22);
            this.txtNomeFuncionario.MaxLength = 50;
            this.txtNomeFuncionario.Multiline = true;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.ReadOnly = true;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(278, 20);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // GBDescritivo
            // 
            this.GBDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDescritivo.Controls.Add(this.txtDescritivo);
            this.GBDescritivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDescritivo.ForeColor = System.Drawing.Color.White;
            this.GBDescritivo.Location = new System.Drawing.Point(14, 181);
            this.GBDescritivo.Name = "GBDescritivo";
            this.GBDescritivo.Size = new System.Drawing.Size(633, 144);
            this.GBDescritivo.TabIndex = 5;
            this.GBDescritivo.TabStop = false;
            this.GBDescritivo.Text = "Descritivo";
            // 
            // txtDescritivo
            // 
            this.txtDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtDescritivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescritivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescritivo.ForeColor = System.Drawing.Color.White;
            this.txtDescritivo.Location = new System.Drawing.Point(7, 23);
            this.txtDescritivo.MaxLength = 299;
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.Size = new System.Drawing.Size(620, 115);
            this.txtDescritivo.TabIndex = 0;
            this.txtDescritivo.Text = "";
            // 
            // GBCondominio
            // 
            this.GBCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBCondominio.Controls.Add(this.cbCondominio);
            this.GBCondominio.Controls.Add(this.txtCondominio);
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
            // cbCondominio
            // 
            this.cbCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.DisplayMember = "IDCargo";
            this.cbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondominio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.ForeColor = System.Drawing.Color.White;
            this.cbCondominio.FormattingEnabled = true;
            this.cbCondominio.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbCondominio.Location = new System.Drawing.Point(2, 15);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(279, 28);
            this.cbCondominio.TabIndex = 0;
            this.cbCondominio.ValueMember = "IDCargo";
            // 
            // txtCondominio
            // 
            this.txtCondominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtCondominio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCondominio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondominio.ForeColor = System.Drawing.Color.White;
            this.txtCondominio.Location = new System.Drawing.Point(3, 22);
            this.txtCondominio.MaxLength = 30;
            this.txtCondominio.Multiline = true;
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(278, 20);
            this.txtCondominio.TabIndex = 1;
            this.txtCondominio.Visible = false;
            // 
            // GBNIFFuncionario
            // 
            this.GBNIFFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBNIFFuncionario.Controls.Add(this.txtNIFFuncionario);
            this.GBNIFFuncionario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNIFFuncionario.ForeColor = System.Drawing.Color.White;
            this.GBNIFFuncionario.Location = new System.Drawing.Point(340, 16);
            this.GBNIFFuncionario.Name = "GBNIFFuncionario";
            this.GBNIFFuncionario.Size = new System.Drawing.Size(307, 49);
            this.GBNIFFuncionario.TabIndex = 1;
            this.GBNIFFuncionario.TabStop = false;
            this.GBNIFFuncionario.Text = "NIF do Funcionário";
            // 
            // txtNIFFuncionario
            // 
            this.txtNIFFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtNIFFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIFFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIFFuncionario.ForeColor = System.Drawing.Color.White;
            this.txtNIFFuncionario.Location = new System.Drawing.Point(3, 22);
            this.txtNIFFuncionario.MaxLength = 9;
            this.txtNIFFuncionario.Multiline = true;
            this.txtNIFFuncionario.Name = "txtNIFFuncionario";
            this.txtNIFFuncionario.Size = new System.Drawing.Size(278, 20);
            this.txtNIFFuncionario.TabIndex = 0;
            this.txtNIFFuncionario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNIFFuncionario_KeyUp);
            // 
            // GBTitulo
            // 
            this.GBTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBTitulo.Controls.Add(this.txtTitulo);
            this.GBTitulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTitulo.ForeColor = System.Drawing.Color.White;
            this.GBTitulo.Location = new System.Drawing.Point(14, 126);
            this.GBTitulo.Name = "GBTitulo";
            this.GBTitulo.Size = new System.Drawing.Size(633, 49);
            this.GBTitulo.TabIndex = 4;
            this.GBTitulo.TabStop = false;
            this.GBTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(3, 22);
            this.txtTitulo.MaxLength = 90;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(604, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dados da Vistoria";
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(352, 415);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(167, 29);
            this.bttVoltar.TabIndex = 1;
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
            this.bttGuardar.Location = new System.Drawing.Point(525, 415);
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
            this.bttFiltrar.Location = new System.Drawing.Point(525, 415);
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
            this.paneldivisao.Size = new System.Drawing.Size(25, 586);
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
            this.panelTitleBar.Size = new System.Drawing.Size(979, 34);
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
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
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
            this.panelTop3.Size = new System.Drawing.Size(979, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(913, 0);
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
            this.bttExit.Location = new System.Drawing.Point(946, 0);
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
            // FormularioVistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(979, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioVistorias";
            this.Text = "FormularioVistorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioVistorias_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelVistorias.ResumeLayout(false);
            this.GBData.ResumeLayout(false);
            this.GBNomeFuncionario.ResumeLayout(false);
            this.GBNomeFuncionario.PerformLayout();
            this.GBDescritivo.ResumeLayout(false);
            this.GBCondominio.ResumeLayout(false);
            this.GBCondominio.PerformLayout();
            this.GBNIFFuncionario.ResumeLayout(false);
            this.GBNIFFuncionario.PerformLayout();
            this.GBTitulo.ResumeLayout(false);
            this.GBTitulo.PerformLayout();
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
        private System.Windows.Forms.Panel panelVistorias;
        private System.Windows.Forms.GroupBox GBNomeFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.GroupBox GBDescritivo;
        private System.Windows.Forms.RichTextBox txtDescritivo;
        private System.Windows.Forms.GroupBox GBCondominio;
        private CustomCombobox cbCondominio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.GroupBox GBNIFFuncionario;
        private System.Windows.Forms.TextBox txtNIFFuncionario;
        private System.Windows.Forms.GroupBox GBTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.GroupBox GBData;
        private NormalDateTimePicker dtpData;
        private System.Windows.Forms.ErrorProvider erros;
    }
}