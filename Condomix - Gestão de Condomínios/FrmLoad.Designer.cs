
using System;

namespace Condomix___Gestão_de_Condomínios.Clientes
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.paneldivisao = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bttCargos = new FontAwesome.Sharp.IconButton();
            this.bttAtas = new FontAwesome.Sharp.IconButton();
            this.bttRemover = new FontAwesome.Sharp.IconButton();
            this.bttConsultar = new FontAwesome.Sharp.IconButton();
            this.bttVisualizar = new FontAwesome.Sharp.IconButton();
            this.bttEditar = new FontAwesome.Sharp.IconButton();
            this.bttAdicionar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bttHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCondomix = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.bttPrevious = new System.Windows.Forms.Button();
            this.bttNext = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTop3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CMS
            // 
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(61, 4);
            // 
            // CMSAdicionar
            // 
            this.CMSAdicionar.Name = "CMSAdicionar";
            this.CMSAdicionar.Size = new System.Drawing.Size(32, 19);
            // 
            // CMSEditar
            // 
            this.CMSEditar.Name = "CMSEditar";
            this.CMSEditar.Size = new System.Drawing.Size(32, 19);
            // 
            // CMSVisualizar
            // 
            this.CMSVisualizar.Name = "CMSVisualizar";
            this.CMSVisualizar.Size = new System.Drawing.Size(32, 19);
            // 
            // CMSConsultar
            // 
            this.CMSConsultar.Name = "CMSConsultar";
            this.CMSConsultar.Size = new System.Drawing.Size(32, 19);
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSize = true;
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(244, 33);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1379, 34);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(40, 4);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 19);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(2, -1);
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
            this.panelTop3.Location = new System.Drawing.Point(244, 0);
            this.panelTop3.Name = "panelTop3";
            this.panelTop3.Size = new System.Drawing.Size(1379, 33);
            this.panelTop3.TabIndex = 2;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.Location = new System.Drawing.Point(1313, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1346, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // paneldivisao
            // 
            this.paneldivisao.BackColor = System.Drawing.Color.Black;
            this.paneldivisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldivisao.Location = new System.Drawing.Point(219, 0);
            this.paneldivisao.Name = "paneldivisao";
            this.paneldivisao.Size = new System.Drawing.Size(25, 720);
            this.paneldivisao.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.panelMenu.Controls.Add(this.bttCargos);
            this.panelMenu.Controls.Add(this.bttAtas);
            this.panelMenu.Controls.Add(this.bttRemover);
            this.panelMenu.Controls.Add(this.bttConsultar);
            this.panelMenu.Controls.Add(this.bttVisualizar);
            this.panelMenu.Controls.Add(this.bttEditar);
            this.panelMenu.Controls.Add(this.bttAdicionar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(219, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // bttCargos
            // 
            this.bttCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttCargos.FlatAppearance.BorderSize = 0;
            this.bttCargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCargos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCargos.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttCargos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.bttCargos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bttCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttCargos.IconSize = 25;
            this.bttCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttCargos.Location = new System.Drawing.Point(0, 432);
            this.bttCargos.Name = "bttCargos";
            this.bttCargos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttCargos.Size = new System.Drawing.Size(219, 50);
            this.bttCargos.TabIndex = 7;
            this.bttCargos.Text = "  Cargos";
            this.bttCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttCargos.UseVisualStyleBackColor = false;
            this.bttCargos.Visible = false;
            this.bttCargos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // bttAtas
            // 
            this.bttAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttAtas.FlatAppearance.BorderSize = 0;
            this.bttAtas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttAtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAtas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAtas.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttAtas.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.bttAtas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bttAtas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttAtas.IconSize = 25;
            this.bttAtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAtas.Location = new System.Drawing.Point(0, 382);
            this.bttAtas.Name = "bttAtas";
            this.bttAtas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttAtas.Size = new System.Drawing.Size(219, 50);
            this.bttAtas.TabIndex = 6;
            this.bttAtas.Text = "  Atas";
            this.bttAtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAtas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttAtas.UseVisualStyleBackColor = false;
            this.bttAtas.Visible = false;
            this.bttAtas.Click += new System.EventHandler(this.bttAtas_Click);
            // 
            // bttRemover
            // 
            this.bttRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttRemover.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttRemover.FlatAppearance.BorderSize = 0;
            this.bttRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRemover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRemover.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttRemover.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.bttRemover.IconColor = System.Drawing.Color.Gainsboro;
            this.bttRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttRemover.IconSize = 25;
            this.bttRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttRemover.Location = new System.Drawing.Point(0, 332);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttRemover.Size = new System.Drawing.Size(219, 50);
            this.bttRemover.TabIndex = 5;
            this.bttRemover.Text = "  Remover";
            this.bttRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttRemover.UseVisualStyleBackColor = false;
            this.bttRemover.Visible = false;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // bttConsultar
            // 
            this.bttConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttConsultar.FlatAppearance.BorderSize = 0;
            this.bttConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttConsultar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConsultar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bttConsultar.IconColor = System.Drawing.Color.Gainsboro;
            this.bttConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttConsultar.IconSize = 25;
            this.bttConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttConsultar.Location = new System.Drawing.Point(0, 282);
            this.bttConsultar.Name = "bttConsultar";
            this.bttConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttConsultar.Size = new System.Drawing.Size(219, 50);
            this.bttConsultar.TabIndex = 4;
            this.bttConsultar.Text = "  Consultar";
            this.bttConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttConsultar.UseVisualStyleBackColor = false;
            this.bttConsultar.Click += new System.EventHandler(this.bttConsultar_Click);
            // 
            // bttVisualizar
            // 
            this.bttVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttVisualizar.FlatAppearance.BorderSize = 0;
            this.bttVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVisualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVisualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttVisualizar.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.bttVisualizar.IconColor = System.Drawing.Color.Gainsboro;
            this.bttVisualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttVisualizar.IconSize = 25;
            this.bttVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttVisualizar.Location = new System.Drawing.Point(0, 232);
            this.bttVisualizar.Name = "bttVisualizar";
            this.bttVisualizar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttVisualizar.Size = new System.Drawing.Size(219, 50);
            this.bttVisualizar.TabIndex = 3;
            this.bttVisualizar.Text = "  Visualizar";
            this.bttVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttVisualizar.UseVisualStyleBackColor = false;
            this.bttVisualizar.Click += new System.EventHandler(this.bttVisualizar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttEditar.FlatAppearance.BorderSize = 0;
            this.bttEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEditar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.bttEditar.IconColor = System.Drawing.Color.Gainsboro;
            this.bttEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttEditar.IconSize = 25;
            this.bttEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttEditar.Location = new System.Drawing.Point(0, 182);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttEditar.Size = new System.Drawing.Size(219, 50);
            this.bttEditar.TabIndex = 2;
            this.bttEditar.Text = "  Editar";
            this.bttEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttEditar.UseVisualStyleBackColor = false;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttAdicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttAdicionar.FlatAppearance.BorderSize = 0;
            this.bttAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdicionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bttAdicionar.IconColor = System.Drawing.Color.Gainsboro;
            this.bttAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttAdicionar.IconSize = 25;
            this.bttAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdicionar.Location = new System.Drawing.Point(0, 132);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttAdicionar.Size = new System.Drawing.Size(219, 50);
            this.bttAdicionar.TabIndex = 1;
            this.bttAdicionar.Text = "  Adicionar";
            this.bttAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttAdicionar.UseVisualStyleBackColor = false;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.bttHome);
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(219, 132);
            this.panelLogo.TabIndex = 0;
            // 
            // bttHome
            // 
            this.bttHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.bttHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttHome.FlatAppearance.BorderSize = 0;
            this.bttHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.bttHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.bttHome.IconColor = System.Drawing.Color.Gainsboro;
            this.bttHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttHome.IconSize = 25;
            this.bttHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttHome.Location = new System.Drawing.Point(0, 17);
            this.bttHome.Name = "bttHome";
            this.bttHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttHome.Size = new System.Drawing.Size(219, 50);
            this.bttHome.TabIndex = 0;
            this.bttHome.Text = "  Home";
            this.bttHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttHome.UseVisualStyleBackColor = false;
            this.bttHome.Click += new System.EventHandler(this.bttHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCondomix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblCondomix
            // 
            this.lblCondomix.AutoSize = true;
            this.lblCondomix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.lblCondomix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondomix.ForeColor = System.Drawing.Color.White;
            this.lblCondomix.Location = new System.Drawing.Point(12, 28);
            this.lblCondomix.Name = "lblCondomix";
            this.lblCondomix.Size = new System.Drawing.Size(81, 19);
            this.lblCondomix.TabIndex = 0;
            this.lblCondomix.Text = "Operações";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Black;
            this.panelNavigation.Controls.Add(this.lblCount);
            this.panelNavigation.Controls.Add(this.label1);
            this.panelNavigation.Controls.Add(this.lblPagina);
            this.panelNavigation.Controls.Add(this.bttPrevious);
            this.panelNavigation.Controls.Add(this.bttNext);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(244, 668);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1379, 52);
            this.panelNavigation.TabIndex = 1;
            this.panelNavigation.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(0, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(157, 52);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Nº de Registos";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1109, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 52);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPagina
            // 
            this.lblPagina.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPagina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.White;
            this.lblPagina.Location = new System.Drawing.Point(1132, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(157, 52);
            this.lblPagina.TabIndex = 0;
            this.lblPagina.Text = "Página";
            this.lblPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttPrevious
            // 
            this.bttPrevious.BackColor = System.Drawing.Color.Black;
            this.bttPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttPrevious.FlatAppearance.BorderSize = 0;
            this.bttPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrevious.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPrevious.ForeColor = System.Drawing.Color.White;
            this.bttPrevious.Location = new System.Drawing.Point(1289, 0);
            this.bttPrevious.Name = "bttPrevious";
            this.bttPrevious.Size = new System.Drawing.Size(45, 52);
            this.bttPrevious.TabIndex = 1;
            this.bttPrevious.Text = "<";
            this.bttPrevious.UseVisualStyleBackColor = false;
            this.bttPrevious.Click += new System.EventHandler(this.bttPrevious_Click);
            // 
            // bttNext
            // 
            this.bttNext.BackColor = System.Drawing.Color.Black;
            this.bttNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttNext.FlatAppearance.BorderSize = 0;
            this.bttNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNext.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNext.ForeColor = System.Drawing.Color.White;
            this.bttNext.Location = new System.Drawing.Point(1334, 0);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(45, 52);
            this.bttNext.TabIndex = 2;
            this.bttNext.Text = ">";
            this.bttNext.UseVisualStyleBackColor = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Black;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.CMS;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(244, 67);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 50;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1379, 601);
            this.dgv.TabIndex = 0;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1623, 720);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTop3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem CMSEditar;
        private System.Windows.Forms.ToolStripMenuItem CMSVisualizar;
        private System.Windows.Forms.ToolStripMenuItem CMSConsultar;
        private System.Windows.Forms.ToolStripMenuItem CMSAdicionar;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button bttPrevious;
        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton bttConsultar;
        private FontAwesome.Sharp.IconButton bttVisualizar;
        private FontAwesome.Sharp.IconButton bttEditar;
        private FontAwesome.Sharp.IconButton bttAdicionar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton bttHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCondomix;
        private FontAwesome.Sharp.IconButton bttRemover;
        private FontAwesome.Sharp.IconButton bttCargos;
        private FontAwesome.Sharp.IconButton bttAtas;
    }
}