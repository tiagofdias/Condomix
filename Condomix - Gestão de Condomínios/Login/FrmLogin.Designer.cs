
namespace Condomix___Gestão_de_Condomínios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.GBNIF = new System.Windows.Forms.GroupBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblCondomix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bttLogin = new System.Windows.Forms.Button();
            this.GBPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbRecuperarPass = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.GBNIF.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelTop3.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.GBPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // txtNIF
            // 
            this.txtNIF.BackColor = System.Drawing.Color.Black;
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.ForeColor = System.Drawing.Color.White;
            this.erros.SetIconAlignment(this.txtNIF, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.txtNIF.Location = new System.Drawing.Point(3, 22);
            this.txtNIF.MaxLength = 30;
            this.txtNIF.Multiline = true;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(278, 20);
            this.txtNIF.TabIndex = 0;
            this.txtNIF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNIF_KeyDown);
            // 
            // GBNIF
            // 
            this.GBNIF.BackColor = System.Drawing.Color.Black;
            this.GBNIF.Controls.Add(this.txtNIF);
            this.GBNIF.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNIF.ForeColor = System.Drawing.Color.White;
            this.erros.SetIconAlignment(this.GBNIF, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.GBNIF.Location = new System.Drawing.Point(225, 172);
            this.GBNIF.Name = "GBNIF";
            this.GBNIF.Size = new System.Drawing.Size(307, 49);
            this.GBNIF.TabIndex = 1;
            this.GBNIF.TabStop = false;
            this.GBNIF.Text = "Nº de Contribuinte";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelTop3);
            this.panelDesktop.Controls.Add(this.panelCentral);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(955, 620);
            this.panelDesktop.TabIndex = 0;
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
            this.panelTop3.Size = new System.Drawing.Size(955, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(889, 0);
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
            this.bttExit.Location = new System.Drawing.Point(922, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.lblCondomix);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.bttCC);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.label12);
            this.panelCentral.Controls.Add(this.bttLogin);
            this.panelCentral.Controls.Add(this.GBPassword);
            this.panelCentral.Controls.Add(this.lbRecuperarPass);
            this.panelCentral.Controls.Add(this.GBNIF);
            this.panelCentral.Controls.Add(this.label11);
            this.panelCentral.Location = new System.Drawing.Point(36, 47);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(769, 570);
            this.panelCentral.TabIndex = 0;
            // 
            // lblCondomix
            // 
            this.lblCondomix.AutoSize = true;
            this.lblCondomix.BackColor = System.Drawing.Color.Black;
            this.lblCondomix.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondomix.ForeColor = System.Drawing.Color.White;
            this.lblCondomix.Location = new System.Drawing.Point(289, 17);
            this.lblCondomix.Name = "lblCondomix";
            this.lblCondomix.Size = new System.Drawing.Size(174, 39);
            this.lblCondomix.TabIndex = 0;
            this.lblCondomix.Text = "CONDOMIX";
            this.lblCondomix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // bttCC
            // 
            this.bttCC.BackColor = System.Drawing.Color.White;
            this.bttCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCC.ForeColor = System.Drawing.Color.Black;
            this.bttCC.Image = global::Condomix___Gestão_de_Condomínios.Properties.Resources.Capture12;
            this.bttCC.Location = new System.Drawing.Point(225, 422);
            this.bttCC.Name = "bttCC";
            this.bttCC.Size = new System.Drawing.Size(307, 45);
            this.bttCC.TabIndex = 5;
            this.bttCC.UseVisualStyleBackColor = false;
            this.bttCC.Click += new System.EventHandler(this.bttCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(221, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Login com:";
            // 
            // bttLogin
            // 
            this.bttLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttLogin.FlatAppearance.BorderSize = 0;
            this.bttLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogin.ForeColor = System.Drawing.Color.White;
            this.bttLogin.Location = new System.Drawing.Point(225, 311);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(307, 42);
            this.bttLogin.TabIndex = 3;
            this.bttLogin.Text = "Iniciar Sessão";
            this.bttLogin.UseVisualStyleBackColor = false;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // GBPassword
            // 
            this.GBPassword.Controls.Add(this.txtPassword);
            this.GBPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPassword.ForeColor = System.Drawing.Color.White;
            this.GBPassword.Location = new System.Drawing.Point(225, 227);
            this.GBPassword.Name = "GBPassword";
            this.GBPassword.Size = new System.Drawing.Size(307, 49);
            this.GBPassword.TabIndex = 2;
            this.GBPassword.TabStop = false;
            this.GBPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(3, 22);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '.';
            this.txtPassword.Size = new System.Drawing.Size(278, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lbRecuperarPass
            // 
            this.lbRecuperarPass.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lbRecuperarPass.AutoSize = true;
            this.lbRecuperarPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecuperarPass.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbRecuperarPass.LinkColor = System.Drawing.Color.White;
            this.lbRecuperarPass.Location = new System.Drawing.Point(222, 356);
            this.lbRecuperarPass.Name = "lbRecuperarPass";
            this.lbRecuperarPass.Size = new System.Drawing.Size(118, 15);
            this.lbRecuperarPass.TabIndex = 4;
            this.lbRecuperarPass.TabStop = true;
            this.lbRecuperarPass.Text = "Recuperar Password";
            this.lbRecuperarPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRecuperarPass_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(329, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Autenticação";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(955, 620);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONDOMIX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.GBNIF.ResumeLayout(false);
            this.GBNIF.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelTop3.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.GBPassword.ResumeLayout(false);
            this.GBPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMoradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCargoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lbRecuperarPass;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bttCC;
        private System.Windows.Forms.GroupBox GBNIF;
        private System.Windows.Forms.GroupBox GBPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCondomix;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
    }
}