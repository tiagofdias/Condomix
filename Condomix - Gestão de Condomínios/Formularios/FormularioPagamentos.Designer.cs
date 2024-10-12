
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPagamentos));
            this.paneldivisao = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.panelDadosGerais = new System.Windows.Forms.Panel();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.GBDataPagamento = new System.Windows.Forms.GroupBox();
            this.GBValor = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.RichTextBox();
            this.GBDescritivo = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.GBTipoPagamento = new System.Windows.Forms.GroupBox();
            this.txtTipoPagamento = new System.Windows.Forms.TextBox();
            this.GBFracao = new System.Windows.Forms.GroupBox();
            this.txtFracao = new System.Windows.Forms.TextBox();
            this.GBPeriodoQuota = new System.Windows.Forms.GroupBox();
            this.GBCondominio = new System.Windows.Forms.GroupBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.bttAbrirDocumento = new System.Windows.Forms.Button();
            this.bttAdicionarDocumento = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttMapaPagamentos = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.dtpDataPagamento = new Condomix___Gestão_de_Condomínios.NormalDateTimePicker();
            this.cbTipoPagamento = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.cbFracao = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.dtpPeriodoQuota = new Condomix___Gestão_de_Condomínios.MyDateTimePicker();
            this.cbCondominio = new Condomix___Gestão_de_Condomínios.CustomCombobox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelDadosGerais.SuspendLayout();
            this.GBDataPagamento.SuspendLayout();
            this.GBValor.SuspendLayout();
            this.GBDescritivo.SuspendLayout();
            this.GBTipoPagamento.SuspendLayout();
            this.GBFracao.SuspendLayout();
            this.GBPeriodoQuota.SuspendLayout();
            this.GBCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldivisao
            // 
            this.paneldivisao.BackColor = System.Drawing.Color.Black;
            this.paneldivisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldivisao.Location = new System.Drawing.Point(0, 67);
            this.paneldivisao.Name = "paneldivisao";
            this.paneldivisao.Size = new System.Drawing.Size(25, 660);
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
            this.panelTitleBar.Size = new System.Drawing.Size(1164, 34);
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
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Coins;
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
            this.panelTop3.Size = new System.Drawing.Size(1164, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(1098, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1131, 0);
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
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.bttVoltar);
            this.panelDesktop.Controls.Add(this.panelDadosGerais);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.bttMapaPagamentos);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Controls.Add(this.bttFiltrar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(25, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1139, 660);
            this.panelDesktop.TabIndex = 0;
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(354, 440);
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
            this.panelDadosGerais.Controls.Add(this.lblDocumento);
            this.panelDadosGerais.Controls.Add(this.GBDataPagamento);
            this.panelDadosGerais.Controls.Add(this.GBValor);
            this.panelDadosGerais.Controls.Add(this.GBDescritivo);
            this.panelDadosGerais.Controls.Add(this.GBTipoPagamento);
            this.panelDadosGerais.Controls.Add(this.GBFracao);
            this.panelDadosGerais.Controls.Add(this.GBPeriodoQuota);
            this.panelDadosGerais.Controls.Add(this.GBCondominio);
            this.panelDadosGerais.Controls.Add(this.bttAbrirDocumento);
            this.panelDadosGerais.Controls.Add(this.bttAdicionarDocumento);
            this.panelDadosGerais.Controls.Add(this.txtDocumento);
            this.panelDadosGerais.ForeColor = System.Drawing.Color.Red;
            this.panelDadosGerais.Location = new System.Drawing.Point(13, 45);
            this.panelDadosGerais.Name = "panelDadosGerais";
            this.panelDadosGerais.Size = new System.Drawing.Size(681, 380);
            this.panelDadosGerais.TabIndex = 0;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(11, 292);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(69, 15);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento";
            // 
            // GBDataPagamento
            // 
            this.GBDataPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDataPagamento.Controls.Add(this.dtpDataPagamento);
            this.GBDataPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDataPagamento.ForeColor = System.Drawing.Color.White;
            this.GBDataPagamento.Location = new System.Drawing.Point(341, 229);
            this.GBDataPagamento.Name = "GBDataPagamento";
            this.GBDataPagamento.Size = new System.Drawing.Size(307, 49);
            this.GBDataPagamento.TabIndex = 6;
            this.GBDataPagamento.TabStop = false;
            this.GBDataPagamento.Text = "Data do Pagamento";
            // 
            // GBValor
            // 
            this.GBValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBValor.Controls.Add(this.txtValor);
            this.GBValor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBValor.ForeColor = System.Drawing.Color.White;
            this.GBValor.Location = new System.Drawing.Point(14, 229);
            this.GBValor.Name = "GBValor";
            this.GBValor.Size = new System.Drawing.Size(307, 49);
            this.GBValor.TabIndex = 5;
            this.GBValor.TabStop = false;
            this.GBValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(8, 21);
            this.txtValor.MaxLength = 16;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(278, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "";
            // 
            // GBDescritivo
            // 
            this.GBDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBDescritivo.Controls.Add(this.txtDescricao);
            this.GBDescritivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDescritivo.ForeColor = System.Drawing.Color.White;
            this.GBDescritivo.Location = new System.Drawing.Point(14, 126);
            this.GBDescritivo.Name = "GBDescritivo";
            this.GBDescritivo.Size = new System.Drawing.Size(634, 97);
            this.GBDescritivo.TabIndex = 4;
            this.GBDescritivo.TabStop = false;
            this.GBDescritivo.Text = "Descritivo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(7, 23);
            this.txtDescricao.MaxLength = 400;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(607, 68);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // GBTipoPagamento
            // 
            this.GBTipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBTipoPagamento.Controls.Add(this.cbTipoPagamento);
            this.GBTipoPagamento.Controls.Add(this.txtTipoPagamento);
            this.GBTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBTipoPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTipoPagamento.ForeColor = System.Drawing.Color.White;
            this.GBTipoPagamento.Location = new System.Drawing.Point(14, 71);
            this.GBTipoPagamento.Name = "GBTipoPagamento";
            this.GBTipoPagamento.Size = new System.Drawing.Size(307, 49);
            this.GBTipoPagamento.TabIndex = 2;
            this.GBTipoPagamento.TabStop = false;
            this.GBTipoPagamento.Text = "Tipo de Pagamento";
            // 
            // txtTipoPagamento
            // 
            this.txtTipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtTipoPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoPagamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPagamento.ForeColor = System.Drawing.Color.White;
            this.txtTipoPagamento.Location = new System.Drawing.Point(3, 20);
            this.txtTipoPagamento.MaxLength = 30;
            this.txtTipoPagamento.Multiline = true;
            this.txtTipoPagamento.Name = "txtTipoPagamento";
            this.txtTipoPagamento.Size = new System.Drawing.Size(278, 20);
            this.txtTipoPagamento.TabIndex = 1;
            this.txtTipoPagamento.Visible = false;
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
            // GBPeriodoQuota
            // 
            this.GBPeriodoQuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBPeriodoQuota.Controls.Add(this.dtpPeriodoQuota);
            this.GBPeriodoQuota.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPeriodoQuota.ForeColor = System.Drawing.Color.White;
            this.GBPeriodoQuota.Location = new System.Drawing.Point(341, 71);
            this.GBPeriodoQuota.Name = "GBPeriodoQuota";
            this.GBPeriodoQuota.Size = new System.Drawing.Size(307, 49);
            this.GBPeriodoQuota.TabIndex = 3;
            this.GBPeriodoQuota.TabStop = false;
            this.GBPeriodoQuota.Text = "Período da Quota";
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
            // bttAbrirDocumento
            // 
            this.bttAbrirDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttAbrirDocumento.FlatAppearance.BorderSize = 0;
            this.bttAbrirDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAbrirDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAbrirDocumento.ForeColor = System.Drawing.Color.White;
            this.bttAbrirDocumento.Location = new System.Drawing.Point(14, 320);
            this.bttAbrirDocumento.Name = "bttAbrirDocumento";
            this.bttAbrirDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAbrirDocumento.TabIndex = 0;
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
            this.bttAdicionarDocumento.Location = new System.Drawing.Point(14, 320);
            this.bttAdicionarDocumento.Name = "bttAdicionarDocumento";
            this.bttAdicionarDocumento.Size = new System.Drawing.Size(167, 29);
            this.bttAdicionarDocumento.TabIndex = 2;
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
            this.txtDocumento.Location = new System.Drawing.Point(171, 320);
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
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dados do Pagamento";
            // 
            // bttMapaPagamentos
            // 
            this.bttMapaPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttMapaPagamentos.FlatAppearance.BorderSize = 0;
            this.bttMapaPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMapaPagamentos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMapaPagamentos.ForeColor = System.Drawing.Color.White;
            this.bttMapaPagamentos.Location = new System.Drawing.Point(274, 440);
            this.bttMapaPagamentos.Name = "bttMapaPagamentos";
            this.bttMapaPagamentos.Size = new System.Drawing.Size(247, 29);
            this.bttMapaPagamentos.TabIndex = 1;
            this.bttMapaPagamentos.Text = "Consultar Mapa de Pagamentos";
            this.bttMapaPagamentos.UseVisualStyleBackColor = false;
            this.bttMapaPagamentos.Click += new System.EventHandler(this.bttMapaPagamentos_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(527, 440);
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
            this.bttFiltrar.Location = new System.Drawing.Point(527, 440);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(167, 29);
            this.bttFiltrar.TabIndex = 4;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpDataPagamento.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpDataPagamento.ButtonColor = System.Drawing.Color.White;
            this.dtpDataPagamento.CustomFormat = " dd/MM/yyyy";
            this.dtpDataPagamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPagamento.Image = null;
            this.dtpDataPagamento.Location = new System.Drawing.Point(2, 17);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(279, 27);
            this.dtpDataPagamento.TabIndex = 0;
            this.dtpDataPagamento.TextColor = System.Drawing.Color.White;
            this.dtpDataPagamento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDataPagamento_MouseDown);
            // 
            // cbTipoPagamento
            // 
            this.cbTipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbTipoPagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbTipoPagamento.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoPagamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPagamento.ForeColor = System.Drawing.Color.White;
            this.cbTipoPagamento.FormattingEnabled = true;
            this.cbTipoPagamento.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.cbTipoPagamento.Items.AddRange(new object[] {
            "Pagamento da Quota"});
            this.cbTipoPagamento.Location = new System.Drawing.Point(2, 15);
            this.cbTipoPagamento.Name = "cbTipoPagamento";
            this.cbTipoPagamento.Size = new System.Drawing.Size(279, 28);
            this.cbTipoPagamento.TabIndex = 0;
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
            // dtpPeriodoQuota
            // 
            this.dtpPeriodoQuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dtpPeriodoQuota.BackDisabledColor = System.Drawing.SystemColors.Control;
            this.dtpPeriodoQuota.ButtonColor = System.Drawing.Color.White;
            this.dtpPeriodoQuota.CustomFormat = "MMMM yyyy";
            this.dtpPeriodoQuota.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodoQuota.Image = null;
            this.dtpPeriodoQuota.Location = new System.Drawing.Point(1, 16);
            this.dtpPeriodoQuota.Name = "dtpPeriodoQuota";
            this.dtpPeriodoQuota.Size = new System.Drawing.Size(280, 27);
            this.dtpPeriodoQuota.TabIndex = 0;
            this.dtpPeriodoQuota.TextColor = System.Drawing.Color.White;
            this.dtpPeriodoQuota.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpPeriodoQuota_MouseDown);
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
            // FormularioPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 727);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPagamentos";
            this.Text = "FormularioPagamentos2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioPagamentos2_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTop3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelDadosGerais.ResumeLayout(false);
            this.panelDadosGerais.PerformLayout();
            this.GBDataPagamento.ResumeLayout(false);
            this.GBValor.ResumeLayout(false);
            this.GBDescritivo.ResumeLayout(false);
            this.GBTipoPagamento.ResumeLayout(false);
            this.GBTipoPagamento.PerformLayout();
            this.GBFracao.ResumeLayout(false);
            this.GBFracao.PerformLayout();
            this.GBPeriodoQuota.ResumeLayout(false);
            this.GBCondominio.ResumeLayout(false);
            this.GBCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.Panel panelDadosGerais;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Button bttAbrirDocumento;
        private System.Windows.Forms.Button bttAdicionarDocumento;
        private System.Windows.Forms.GroupBox GBDataPagamento;
        private NormalDateTimePicker dtpDataPagamento;
        private System.Windows.Forms.GroupBox GBValor;
        private System.Windows.Forms.GroupBox GBDescritivo;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.GroupBox GBTipoPagamento;
        private CustomCombobox cbTipoPagamento;
        private System.Windows.Forms.TextBox txtTipoPagamento;
        private System.Windows.Forms.GroupBox GBFracao;
        private System.Windows.Forms.GroupBox GBPeriodoQuota;
        private MyDateTimePicker dtpPeriodoQuota;
        private System.Windows.Forms.GroupBox GBCondominio;
        private CustomCombobox cbCondominio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttMapaPagamentos;
        private CustomCombobox cbFracao;
        private System.Windows.Forms.RichTextBox txtValor;
        private System.Windows.Forms.TextBox txtFracao;
        private System.Windows.Forms.RichTextBox txtDocumento;
    }
}