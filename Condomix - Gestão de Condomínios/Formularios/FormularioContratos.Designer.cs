
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioContratos));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.panelDadosGerais = new System.Windows.Forms.Panel();
            this.GBDataRescisao = new System.Windows.Forms.GroupBox();
            this.dtpDataRescisao = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBDataFim = new System.Windows.Forms.GroupBox();
            this.dtpDataFim = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBContratoRescindido = new System.Windows.Forms.GroupBox();
            this.cbContratoRescindido = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtContratoRescindido = new System.Windows.Forms.TextBox();
            this.GBTitulo = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.GBDataInicio = new System.Windows.Forms.GroupBox();
            this.dtpDataInicio = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBValor = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.RichTextBox();
            this.GBDescritivo = new System.Windows.Forms.GroupBox();
            this.txtDescritivo = new System.Windows.Forms.RichTextBox();
            this.GBContratoSemTermo = new System.Windows.Forms.GroupBox();
            this.cbContratoSemTermo = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtContratoSemTermo = new System.Windows.Forms.TextBox();
            this.GBFornecedor = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
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
            this.GBDataRescisao.SuspendLayout();
            this.GBDataFim.SuspendLayout();
            this.GBContratoRescindido.SuspendLayout();
            this.GBTitulo.SuspendLayout();
            this.GBDataInicio.SuspendLayout();
            this.GBValor.SuspendLayout();
            this.GBDescritivo.SuspendLayout();
            this.GBContratoSemTermo.SuspendLayout();
            this.GBFornecedor.SuspendLayout();
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
            this.panelDesktop.Size = new System.Drawing.Size(1305, 724);
            this.panelDesktop.TabIndex = 0;
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(354, 555);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(167, 29);
            this.bttVoltar.TabIndex = 2;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = false;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // panelDadosGerais
            // 
            this.panelDadosGerais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosGerais.Controls.Add(this.GBDataRescisao);
            this.panelDadosGerais.Controls.Add(this.GBDataFim);
            this.panelDadosGerais.Controls.Add(this.GBContratoRescindido);
            this.panelDadosGerais.Controls.Add(this.GBTitulo);
            this.panelDadosGerais.Controls.Add(this.lblDocumento);
            this.panelDadosGerais.Controls.Add(this.GBDataInicio);
            this.panelDadosGerais.Controls.Add(this.GBValor);
            this.panelDadosGerais.Controls.Add(this.GBDescritivo);
            this.panelDadosGerais.Controls.Add(this.GBContratoSemTermo);
            this.panelDadosGerais.Controls.Add(this.GBFornecedor);
            this.panelDadosGerais.Controls.Add(this.bttAbrirDocumento);
            this.panelDadosGerais.Controls.Add(this.bttAdicionarDocumento);
            this.panelDadosGerais.Controls.Add(this.txtDocumento);
            this.panelDadosGerais.ForeColor = System.Drawing.Color.Red;
            this.panelDadosGerais.Location = new System.Drawing.Point(13, 45);
            this.panelDadosGerais.Name = "panelDadosGerais";
            this.panelDadosGerais.Size = new System.Drawing.Size(681, 495);
            this.panelDadosGerais.TabIndex = 1;
            // 
            // GBDataRescisao
            // 
            this.GBDataRescisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDataRescisao.Controls.Add(this.dtpDataRescisao);
            this.GBDataRescisao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDataRescisao.ForeColor = System.Drawing.Color.White;
            this.GBDataRescisao.Location = new System.Drawing.Point(341, 348);
            this.GBDataRescisao.Name = "GBDataRescisao";
            this.GBDataRescisao.Size = new System.Drawing.Size(307, 49);
            this.GBDataRescisao.TabIndex = 8;
            this.GBDataRescisao.TabStop = false;
            this.GBDataRescisao.Text = "Data da Rescisão";
            this.GBDataRescisao.Visible = false;
            // 
            // dtpDataRescisao
            // 
            this.dtpDataRescisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpDataRescisao.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpDataRescisao.ButtonColor = System.Drawing.Color.White;
            this.dtpDataRescisao.CustomFormat = " dd/MM/yyyy";
            this.dtpDataRescisao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataRescisao.Image = null;
            this.dtpDataRescisao.Location = new System.Drawing.Point(2, 17);
            this.dtpDataRescisao.Name = "dtpDataRescisao";
            this.dtpDataRescisao.Size = new System.Drawing.Size(279, 27);
            this.dtpDataRescisao.TabIndex = 0;
            this.dtpDataRescisao.TextColor = System.Drawing.Color.White;
            this.dtpDataRescisao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDataRescisao_MouseDown);
            // 
            // GBDataFim
            // 
            this.GBDataFim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDataFim.Controls.Add(this.dtpDataFim);
            this.GBDataFim.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDataFim.ForeColor = System.Drawing.Color.White;
            this.GBDataFim.Location = new System.Drawing.Point(341, 293);
            this.GBDataFim.Name = "GBDataFim";
            this.GBDataFim.Size = new System.Drawing.Size(307, 49);
            this.GBDataFim.TabIndex = 6;
            this.GBDataFim.TabStop = false;
            this.GBDataFim.Text = "Data de Fim";
            this.GBDataFim.Visible = false;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpDataFim.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpDataFim.ButtonColor = System.Drawing.Color.White;
            this.dtpDataFim.CustomFormat = " dd/MM/yyyy";
            this.dtpDataFim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Image = null;
            this.dtpDataFim.Location = new System.Drawing.Point(2, 17);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(279, 27);
            this.dtpDataFim.TabIndex = 0;
            this.dtpDataFim.TextColor = System.Drawing.Color.White;
            this.dtpDataFim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDataFim_MouseDown);
            // 
            // GBContratoRescindido
            // 
            this.GBContratoRescindido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBContratoRescindido.Controls.Add(this.cbContratoRescindido);
            this.GBContratoRescindido.Controls.Add(this.txtContratoRescindido);
            this.GBContratoRescindido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBContratoRescindido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBContratoRescindido.ForeColor = System.Drawing.Color.White;
            this.GBContratoRescindido.Location = new System.Drawing.Point(14, 348);
            this.GBContratoRescindido.Name = "GBContratoRescindido";
            this.GBContratoRescindido.Size = new System.Drawing.Size(307, 49);
            this.GBContratoRescindido.TabIndex = 7;
            this.GBContratoRescindido.TabStop = false;
            this.GBContratoRescindido.Text = "Contrato Rescindido";
            // 
            // cbContratoRescindido
            // 
            this.cbContratoRescindido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoRescindido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoRescindido.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoRescindido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContratoRescindido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContratoRescindido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContratoRescindido.ForeColor = System.Drawing.Color.White;
            this.cbContratoRescindido.FormattingEnabled = true;
            this.cbContratoRescindido.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoRescindido.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbContratoRescindido.Location = new System.Drawing.Point(2, 17);
            this.cbContratoRescindido.Name = "cbContratoRescindido";
            this.cbContratoRescindido.Size = new System.Drawing.Size(284, 28);
            this.cbContratoRescindido.TabIndex = 0;
            this.cbContratoRescindido.SelectedIndexChanged += new System.EventHandler(this.cbContratoRescindido_SelectedIndexChanged);
            // 
            // txtContratoRescindido
            // 
            this.txtContratoRescindido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtContratoRescindido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContratoRescindido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoRescindido.ForeColor = System.Drawing.Color.White;
            this.txtContratoRescindido.Location = new System.Drawing.Point(3, 20);
            this.txtContratoRescindido.MaxLength = 30;
            this.txtContratoRescindido.Multiline = true;
            this.txtContratoRescindido.Name = "txtContratoRescindido";
            this.txtContratoRescindido.Size = new System.Drawing.Size(278, 20);
            this.txtContratoRescindido.TabIndex = 1;
            this.txtContratoRescindido.Visible = false;
            // 
            // GBTitulo
            // 
            this.GBTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBTitulo.Controls.Add(this.txtTitulo);
            this.GBTitulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTitulo.ForeColor = System.Drawing.Color.White;
            this.GBTitulo.Location = new System.Drawing.Point(14, 80);
            this.GBTitulo.Name = "GBTitulo";
            this.GBTitulo.Size = new System.Drawing.Size(634, 49);
            this.GBTitulo.TabIndex = 1;
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
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(604, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(11, 411);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(69, 15);
            this.lblDocumento.TabIndex = 87;
            this.lblDocumento.Text = "Documento";
            // 
            // GBDataInicio
            // 
            this.GBDataInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDataInicio.Controls.Add(this.dtpDataInicio);
            this.GBDataInicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDataInicio.ForeColor = System.Drawing.Color.White;
            this.GBDataInicio.Location = new System.Drawing.Point(14, 293);
            this.GBDataInicio.Name = "GBDataInicio";
            this.GBDataInicio.Size = new System.Drawing.Size(307, 49);
            this.GBDataInicio.TabIndex = 5;
            this.GBDataInicio.TabStop = false;
            this.GBDataInicio.Text = "Data de Inicio";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpDataInicio.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpDataInicio.ButtonColor = System.Drawing.Color.White;
            this.dtpDataInicio.CustomFormat = " dd/MM/yyyy";
            this.dtpDataInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicio.Image = null;
            this.dtpDataInicio.Location = new System.Drawing.Point(2, 17);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(284, 27);
            this.dtpDataInicio.TabIndex = 0;
            this.dtpDataInicio.TextColor = System.Drawing.Color.White;
            this.dtpDataInicio.ValueChanged += new System.EventHandler(this.dtpDataInicio_ValueChanged);
            this.dtpDataInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDataInicio_MouseDown);
            // 
            // GBValor
            // 
            this.GBValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBValor.Controls.Add(this.txtValor);
            this.GBValor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBValor.ForeColor = System.Drawing.Color.White;
            this.GBValor.Location = new System.Drawing.Point(14, 238);
            this.GBValor.Name = "GBValor";
            this.GBValor.Size = new System.Drawing.Size(307, 49);
            this.GBValor.TabIndex = 3;
            this.GBValor.TabStop = false;
            this.GBValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(7, 20);
            this.txtValor.MaxLength = 16;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(278, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "";
            // 
            // GBDescritivo
            // 
            this.GBDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDescritivo.Controls.Add(this.txtDescritivo);
            this.GBDescritivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDescritivo.ForeColor = System.Drawing.Color.White;
            this.GBDescritivo.Location = new System.Drawing.Point(14, 135);
            this.GBDescritivo.Name = "GBDescritivo";
            this.GBDescritivo.Size = new System.Drawing.Size(634, 97);
            this.GBDescritivo.TabIndex = 2;
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
            this.txtDescritivo.MaxLength = 400;
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.Size = new System.Drawing.Size(607, 68);
            this.txtDescritivo.TabIndex = 0;
            this.txtDescritivo.Text = "";
            // 
            // GBContratoSemTermo
            // 
            this.GBContratoSemTermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBContratoSemTermo.Controls.Add(this.cbContratoSemTermo);
            this.GBContratoSemTermo.Controls.Add(this.txtContratoSemTermo);
            this.GBContratoSemTermo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBContratoSemTermo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBContratoSemTermo.ForeColor = System.Drawing.Color.White;
            this.GBContratoSemTermo.Location = new System.Drawing.Point(340, 238);
            this.GBContratoSemTermo.Name = "GBContratoSemTermo";
            this.GBContratoSemTermo.Size = new System.Drawing.Size(307, 49);
            this.GBContratoSemTermo.TabIndex = 4;
            this.GBContratoSemTermo.TabStop = false;
            this.GBContratoSemTermo.Text = "Contrato sem Termo";
            // 
            // cbContratoSemTermo
            // 
            this.cbContratoSemTermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoSemTermo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoSemTermo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoSemTermo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContratoSemTermo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContratoSemTermo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContratoSemTermo.ForeColor = System.Drawing.Color.White;
            this.cbContratoSemTermo.FormattingEnabled = true;
            this.cbContratoSemTermo.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbContratoSemTermo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbContratoSemTermo.Location = new System.Drawing.Point(2, 15);
            this.cbContratoSemTermo.Name = "cbContratoSemTermo";
            this.cbContratoSemTermo.Size = new System.Drawing.Size(280, 28);
            this.cbContratoSemTermo.TabIndex = 0;
            this.cbContratoSemTermo.SelectedIndexChanged += new System.EventHandler(this.cbContratoSemTermo_SelectedIndexChanged);
            // 
            // txtContratoSemTermo
            // 
            this.txtContratoSemTermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtContratoSemTermo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContratoSemTermo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoSemTermo.ForeColor = System.Drawing.Color.White;
            this.txtContratoSemTermo.Location = new System.Drawing.Point(3, 20);
            this.txtContratoSemTermo.MaxLength = 30;
            this.txtContratoSemTermo.Multiline = true;
            this.txtContratoSemTermo.Name = "txtContratoSemTermo";
            this.txtContratoSemTermo.Size = new System.Drawing.Size(278, 20);
            this.txtContratoSemTermo.TabIndex = 1;
            this.txtContratoSemTermo.Visible = false;
            // 
            // GBFornecedor
            // 
            this.GBFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBFornecedor.Controls.Add(this.cbFornecedor);
            this.GBFornecedor.Controls.Add(this.txtFornecedor);
            this.GBFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBFornecedor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFornecedor.ForeColor = System.Drawing.Color.White;
            this.GBFornecedor.Location = new System.Drawing.Point(14, 16);
            this.GBFornecedor.Name = "GBFornecedor";
            this.GBFornecedor.Size = new System.Drawing.Size(634, 49);
            this.GBFornecedor.TabIndex = 0;
            this.GBFornecedor.TabStop = false;
            this.GBFornecedor.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFornecedor.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.ForeColor = System.Drawing.Color.White;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFornecedor.Location = new System.Drawing.Point(2, 15);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(605, 28);
            this.cbFornecedor.TabIndex = 0;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.ForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Location = new System.Drawing.Point(3, 20);
            this.txtFornecedor.MaxLength = 30;
            this.txtFornecedor.Multiline = true;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(278, 20);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.Visible = false;
            // 
            // bttAbrirDocumento
            // 
            this.bttAbrirDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttAbrirDocumento.FlatAppearance.BorderSize = 0;
            this.bttAbrirDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAbrirDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAbrirDocumento.ForeColor = System.Drawing.Color.White;
            this.bttAbrirDocumento.Location = new System.Drawing.Point(14, 439);
            this.bttAbrirDocumento.Name = "bttAbrirDocumento";
            this.bttAbrirDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAbrirDocumento.TabIndex = 9;
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
            this.bttAdicionarDocumento.Location = new System.Drawing.Point(14, 439);
            this.bttAdicionarDocumento.Name = "bttAdicionarDocumento";
            this.bttAdicionarDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAdicionarDocumento.TabIndex = 89;
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
            this.txtDocumento.Location = new System.Drawing.Point(171, 439);
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
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dados do Contrato";
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(527, 555);
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
            this.bttFiltrar.Location = new System.Drawing.Point(527, 555);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(167, 29);
            this.bttFiltrar.TabIndex = 4;
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
            this.paneldivisao.Size = new System.Drawing.Size(25, 724);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1330, 34);
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
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
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
            this.panelTop3.Size = new System.Drawing.Size(1330, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(1264, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1297, 0);
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
            // FormularioContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1330, 791);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioContratos";
            this.Text = "FormularioContratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioContratos_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelDadosGerais.ResumeLayout(false);
            this.panelDadosGerais.PerformLayout();
            this.GBDataRescisao.ResumeLayout(false);
            this.GBDataFim.ResumeLayout(false);
            this.GBContratoRescindido.ResumeLayout(false);
            this.GBContratoRescindido.PerformLayout();
            this.GBTitulo.ResumeLayout(false);
            this.GBTitulo.PerformLayout();
            this.GBDataInicio.ResumeLayout(false);
            this.GBValor.ResumeLayout(false);
            this.GBDescritivo.ResumeLayout(false);
            this.GBContratoSemTermo.ResumeLayout(false);
            this.GBContratoSemTermo.PerformLayout();
            this.GBFornecedor.ResumeLayout(false);
            this.GBFornecedor.PerformLayout();
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
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.GroupBox GBDataInicio;
        private NormalDateTimePicker dtpDataInicio;
        private System.Windows.Forms.GroupBox GBValor;
        private System.Windows.Forms.RichTextBox txtValor;
        private System.Windows.Forms.GroupBox GBDescritivo;
        private System.Windows.Forms.RichTextBox txtDescritivo;
        private System.Windows.Forms.GroupBox GBContratoSemTermo;
        private CustomCombobox cbContratoSemTermo;
        private System.Windows.Forms.TextBox txtContratoSemTermo;
        private System.Windows.Forms.GroupBox GBFornecedor;
        private CustomCombobox cbFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button bttAbrirDocumento;
        private System.Windows.Forms.Button bttAdicionarDocumento;
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
        private System.Windows.Forms.GroupBox GBTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox GBContratoRescindido;
        private CustomCombobox cbContratoRescindido;
        private System.Windows.Forms.TextBox txtContratoRescindido;
        private System.Windows.Forms.GroupBox GBDataRescisao;
        private NormalDateTimePicker dtpDataRescisao;
        private System.Windows.Forms.GroupBox GBDataFim;
        private NormalDateTimePicker dtpDataFim;
        private System.Windows.Forms.ErrorProvider erros;
    }
}