
namespace Condomix___Gestão_de_Condomínios.Formularios
{
    partial class FormularioCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCargos));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelCargos = new System.Windows.Forms.Panel();
            this.GBNome = new System.Windows.Forms.GroupBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.GBModulos = new System.Windows.Forms.GroupBox();
            this.bttRemover = new FontAwesome.Sharp.IconButton();
            this.bttAdicionar = new FontAwesome.Sharp.IconButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttVoltar = new System.Windows.Forms.Button();
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
            this.panelCargos.SuspendLayout();
            this.GBNome.SuspendLayout();
            this.GBModulos.SuspendLayout();
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
            this.panelDesktop.Controls.Add(this.panelCargos);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.bttVoltar);
            this.panelDesktop.Controls.Add(this.bttGuardar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(25, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1090, 574);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelCargos
            // 
            this.panelCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCargos.Controls.Add(this.GBNome);
            this.panelCargos.Controls.Add(this.GBModulos);
            this.panelCargos.ForeColor = System.Drawing.Color.Red;
            this.panelCargos.Location = new System.Drawing.Point(11, 43);
            this.panelCargos.Name = "panelCargos";
            this.panelCargos.Size = new System.Drawing.Size(437, 356);
            this.panelCargos.TabIndex = 0;
            // 
            // GBNome
            // 
            this.GBNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBNome.Controls.Add(this.txtCargo);
            this.GBNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNome.ForeColor = System.Drawing.Color.White;
            this.GBNome.Location = new System.Drawing.Point(14, 13);
            this.GBNome.Name = "GBNome";
            this.GBNome.Size = new System.Drawing.Size(390, 49);
            this.GBNome.TabIndex = 6;
            this.GBNome.TabStop = false;
            this.GBNome.Text = "Nome";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.Location = new System.Drawing.Point(3, 22);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(362, 20);
            this.txtCargo.TabIndex = 0;
            // 
            // GBModulos
            // 
            this.GBModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.GBModulos.Controls.Add(this.bttRemover);
            this.GBModulos.Controls.Add(this.bttAdicionar);
            this.GBModulos.Controls.Add(this.listBox2);
            this.GBModulos.Controls.Add(this.listBox1);
            this.GBModulos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBModulos.ForeColor = System.Drawing.Color.White;
            this.GBModulos.Location = new System.Drawing.Point(14, 80);
            this.GBModulos.Name = "GBModulos";
            this.GBModulos.Size = new System.Drawing.Size(390, 245);
            this.GBModulos.TabIndex = 5;
            this.GBModulos.TabStop = false;
            this.GBModulos.Text = "Módulos";
            // 
            // bttRemover
            // 
            this.bttRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttRemover.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bttRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRemover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRemover.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttRemover.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.bttRemover.IconColor = System.Drawing.Color.White;
            this.bttRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttRemover.IconSize = 25;
            this.bttRemover.Location = new System.Drawing.Point(160, 73);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttRemover.Size = new System.Drawing.Size(51, 32);
            this.bttRemover.TabIndex = 3;
            this.bttRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttRemover.UseVisualStyleBackColor = false;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttAdicionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bttAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdicionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttAdicionar.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.bttAdicionar.IconColor = System.Drawing.Color.White;
            this.bttAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttAdicionar.IconSize = 25;
            this.bttAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdicionar.Location = new System.Drawing.Point(160, 34);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttAdicionar.Size = new System.Drawing.Size(51, 33);
            this.bttAdicionar.TabIndex = 2;
            this.bttAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttAdicionar.UseVisualStyleBackColor = false;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(217, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(148, 209);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 209);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cargos dos Funcionários";
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttVoltar.FlatAppearance.BorderSize = 0;
            this.bttVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.ForeColor = System.Drawing.Color.White;
            this.bttVoltar.Location = new System.Drawing.Point(108, 414);
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
            this.bttGuardar.Location = new System.Drawing.Point(281, 414);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(167, 29);
            this.bttGuardar.TabIndex = 2;
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
            this.paneldivisao.Size = new System.Drawing.Size(25, 574);
            this.paneldivisao.TabIndex = 2;
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
            this.panelTitleBar.Size = new System.Drawing.Size(1115, 34);
            this.panelTitleBar.TabIndex = 3;
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
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
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
            this.panelTop3.Size = new System.Drawing.Size(1115, 33);
            this.panelTop3.TabIndex = 4;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.Location = new System.Drawing.Point(1049, 0);
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
            this.bttExit.Location = new System.Drawing.Point(1082, 0);
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
            // FormularioCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1115, 641);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneldivisao);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTop3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioCargos";
            this.Text = "FormularioCargos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioCargos_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelCargos.ResumeLayout(false);
            this.GBNome.ResumeLayout(false);
            this.GBNome.PerformLayout();
            this.GBModulos.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelCargos;
        private System.Windows.Forms.GroupBox GBModulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Panel paneldivisao;
        private System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.GroupBox GBNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton bttRemover;
        private FontAwesome.Sharp.IconButton bttAdicionar;
        private System.Windows.Forms.ErrorProvider erros;
    }
}