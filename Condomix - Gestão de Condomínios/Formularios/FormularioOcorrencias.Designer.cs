
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioOcorrencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioOcorrencias));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.panelDadosGerais = new System.Windows.Forms.Panel();
            this.GBTitulo = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.RichTextBox();
            this.GBDataLimiteResolucao = new System.Windows.Forms.GroupBox();
            this.dtpData = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.GBDescritivo = new System.Windows.Forms.GroupBox();
            this.txtDescritivo = new System.Windows.Forms.RichTextBox();
            this.GBEstado = new System.Windows.Forms.GroupBox();
            this.cbEstado = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.GBFracao = new System.Windows.Forms.GroupBox();
            this.txtFracao = new System.Windows.Forms.TextBox();
            this.cbFracao = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.GBCondominio = new System.Windows.Forms.GroupBox();
            this.cbCondominio = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
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
            this.GBTitulo.SuspendLayout();
            this.GBDataLimiteResolucao.SuspendLayout();
            this.GBDescritivo.SuspendLayout();
            this.GBEstado.SuspendLayout();
            this.GBFracao.SuspendLayout();
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
            this.panelDesktop.Controls.Add(this.bttFiltrar);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(25, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1080, 623);
            this.panelDesktop.TabIndex = 0;
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(354, 374);
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
            this.panelDadosGerais.Controls.Add(this.GBTitulo);
            this.panelDadosGerais.Controls.Add(this.GBDataLimiteResolucao);
            this.panelDadosGerais.Controls.Add(this.GBDescritivo);
            this.panelDadosGerais.Controls.Add(this.GBEstado);
            this.panelDadosGerais.Controls.Add(this.GBFracao);
            this.panelDadosGerais.Controls.Add(this.GBCondominio);
            this.panelDadosGerais.ForeColor = System.Drawing.Color.Red;
            this.panelDadosGerais.Location = new System.Drawing.Point(13, 45);
            this.panelDadosGerais.Name = "panelDadosGerais";
            this.panelDadosGerais.Size = new System.Drawing.Size(681, 312);
            this.panelDadosGerais.TabIndex = 0;
            // 
            // GBTitulo
            // 
            this.GBTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBTitulo.Controls.Add(this.txtTitulo);
            this.GBTitulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTitulo.ForeColor = System.Drawing.Color.White;
            this.GBTitulo.Location = new System.Drawing.Point(14, 71);
            this.GBTitulo.Name = "GBTitulo";
            this.GBTitulo.Size = new System.Drawing.Size(634, 49);
            this.GBTitulo.TabIndex = 2;
            this.GBTitulo.TabStop = false;
            this.GBTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(6, 21);
            this.txtTitulo.MaxLength = 99;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(602, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "";
            // 
            // GBDataLimiteResolucao
            // 
            this.GBDataLimiteResolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDataLimiteResolucao.Controls.Add(this.dtpData);
            this.GBDataLimiteResolucao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDataLimiteResolucao.ForeColor = System.Drawing.Color.White;
            this.GBDataLimiteResolucao.Location = new System.Drawing.Point(14, 229);
            this.GBDataLimiteResolucao.Name = "GBDataLimiteResolucao";
            this.GBDataLimiteResolucao.Size = new System.Drawing.Size(307, 49);
            this.GBDataLimiteResolucao.TabIndex = 4;
            this.GBDataLimiteResolucao.TabStop = false;
            this.GBDataLimiteResolucao.Text = "Data Limite de Resolução";
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
            // GBDescritivo
            // 
            this.GBDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDescritivo.Controls.Add(this.txtDescritivo);
            this.GBDescritivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDescritivo.ForeColor = System.Drawing.Color.White;
            this.GBDescritivo.Location = new System.Drawing.Point(14, 126);
            this.GBDescritivo.Name = "GBDescritivo";
            this.GBDescritivo.Size = new System.Drawing.Size(634, 97);
            this.GBDescritivo.TabIndex = 3;
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
            this.txtDescritivo.MaxLength = 300;
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.Size = new System.Drawing.Size(607, 68);
            this.txtDescritivo.TabIndex = 0;
            this.txtDescritivo.Text = "";
            // 
            // GBEstado
            // 
            this.GBEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBEstado.Controls.Add(this.cbEstado);
            this.GBEstado.Controls.Add(this.txtEstado);
            this.GBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBEstado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEstado.ForeColor = System.Drawing.Color.White;
            this.GBEstado.Location = new System.Drawing.Point(340, 229);
            this.GBEstado.Name = "GBEstado";
            this.GBEstado.Size = new System.Drawing.Size(307, 49);
            this.GBEstado.TabIndex = 5;
            this.GBEstado.TabStop = false;
            this.GBEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbEstado.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.White;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbEstado.Items.AddRange(new object[] {
            "Aberto",
            "Pendente",
            "Em Resolução",
            "Fechado"});
            this.cbEstado.Location = new System.Drawing.Point(2, 15);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(279, 28);
            this.cbEstado.TabIndex = 0;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(3, 20);
            this.txtEstado.MaxLength = 30;
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(278, 20);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.Visible = false;
            // 
            // GBFracao
            // 
            this.GBFracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBFracao.Controls.Add(this.txtFracao);
            this.GBFracao.Controls.Add(this.cbFracao);
            this.GBFracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBFracao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFracao.ForeColor = System.Drawing.Color.White;
            this.GBFracao.Location = new System.Drawing.Point(341, 16);
            this.GBFracao.Name = "GBFracao";
            this.GBFracao.Size = new System.Drawing.Size(307, 49);
            this.GBFracao.TabIndex = 1;
            this.GBFracao.TabStop = false;
            this.GBFracao.Text = "Fracao";
            // 
            // txtFracao
            // 
            this.txtFracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtFracao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFracao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFracao.ForeColor = System.Drawing.Color.White;
            this.txtFracao.Location = new System.Drawing.Point(3, 19);
            this.txtFracao.MaxLength = 30;
            this.txtFracao.Multiline = true;
            this.txtFracao.Name = "txtFracao";
            this.txtFracao.Size = new System.Drawing.Size(278, 20);
            this.txtFracao.TabIndex = 0;
            this.txtFracao.Visible = false;
            this.txtFracao.Click += new System.EventHandler(this.txtFracao_Click);
            // 
            // cbFracao
            // 
            this.cbFracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFracao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFracao.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFracao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFracao.ForeColor = System.Drawing.Color.White;
            this.cbFracao.FormattingEnabled = true;
            this.cbFracao.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbFracao.Location = new System.Drawing.Point(2, 16);
            this.cbFracao.Name = "cbFracao";
            this.cbFracao.Size = new System.Drawing.Size(279, 28);
            this.cbFracao.TabIndex = 1;
            this.cbFracao.SelectedIndexChanged += new System.EventHandler(this.cbFracao_SelectedIndexChanged);
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
            this.cbCondominio.SelectedIndexChanged += new System.EventHandler(this.cbCondominio_SelectedIndexChanged);
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
            this.txtCondominio.TabIndex = 1;
            this.txtCondominio.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dados da Ocorrência";
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttFiltrar.FlatAppearance.BorderSize = 0;
            this.bttFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFiltrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFiltrar.ForeColor = System.Drawing.Color.White;
            this.bttFiltrar.Location = new System.Drawing.Point(527, 374);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(167, 29);
            this.bttFiltrar.TabIndex = 2;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(527, 374);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(167, 29);
            this.bttGuardar.TabIndex = 3;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = false;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // paneldivisao
            // 
            this.paneldivisao.BackColor = System.Drawing.Color.Black;
            this.paneldivisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldivisao.Location = new System.Drawing.Point(0, 67);
            this.paneldivisao.Name = "paneldivisao";
            this.paneldivisao.Size = new System.Drawing.Size(25, 623);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1105, 34);
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
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Book;
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
            this.panelTop3.Size = new System.Drawing.Size(1105, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(1039, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1072, 0);
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
            // FormularioOcorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1105, 690);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioOcorrencias";
            this.Text = "Ocorrencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ocorrencias_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelDadosGerais.ResumeLayout(false);
            this.GBTitulo.ResumeLayout(false);
            this.GBDataLimiteResolucao.ResumeLayout(false);
            this.GBDescritivo.ResumeLayout(false);
            this.GBEstado.ResumeLayout(false);
            this.GBEstado.PerformLayout();
            this.GBFracao.ResumeLayout(false);
            this.GBFracao.PerformLayout();
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
        private System.Windows.Forms.GroupBox GBDataLimiteResolucao;
        private NormalDateTimePicker dtpData;
        private System.Windows.Forms.GroupBox GBDescritivo;
        private System.Windows.Forms.RichTextBox txtDescritivo;
        private System.Windows.Forms.GroupBox GBFracao;
        private System.Windows.Forms.TextBox txtFracao;
        private CustomCombobox cbFracao;
        private System.Windows.Forms.GroupBox GBCondominio;
        private CustomCombobox cbCondominio;
        private System.Windows.Forms.TextBox txtCondominio;
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
        private System.Windows.Forms.GroupBox GBEstado;
        private CustomCombobox cbEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox GBTitulo;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.RichTextBox txtTitulo;
    }
}