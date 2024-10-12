
namespace Condomix___Gestão_de_Condomínios.Login
{
    partial class FrmCodSeguranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCodSeguranca));
            this.label9 = new System.Windows.Forms.Label();
            this.lblMudarEmail = new System.Windows.Forms.LinkLabel();
            this.lblReenviar = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.bttCodigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBEmail = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblCondomix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.GBEmail.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panelTop3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(327, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "ou";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMudarEmail
            // 
            this.lblMudarEmail.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lblMudarEmail.AutoSize = true;
            this.lblMudarEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMudarEmail.LinkColor = System.Drawing.Color.White;
            this.lblMudarEmail.Location = new System.Drawing.Point(360, 409);
            this.lblMudarEmail.Name = "lblMudarEmail";
            this.lblMudarEmail.Size = new System.Drawing.Size(161, 15);
            this.lblMudarEmail.TabIndex = 5;
            this.lblMudarEmail.TabStop = true;
            this.lblMudarEmail.Text = "Mudar o endereço de E-mail";
            this.lblMudarEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblReenviar
            // 
            this.lblReenviar.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lblReenviar.AutoSize = true;
            this.lblReenviar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenviar.LinkColor = System.Drawing.Color.White;
            this.lblReenviar.Location = new System.Drawing.Point(232, 409);
            this.lblReenviar.Name = "lblReenviar";
            this.lblReenviar.Size = new System.Drawing.Size(89, 15);
            this.lblReenviar.TabIndex = 4;
            this.lblReenviar.TabStop = true;
            this.lblReenviar.Text = "Reenviar email";
            this.lblReenviar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReenviar_LinkClicked);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Não recebeu o e-mail?  Verifique a pasta de Spam.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttCodigo
            // 
            this.bttCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttCodigo.FlatAppearance.BorderSize = 0;
            this.bttCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCodigo.ForeColor = System.Drawing.Color.White;
            this.bttCodigo.Location = new System.Drawing.Point(377, 311);
            this.bttCodigo.Name = "bttCodigo";
            this.bttCodigo.Size = new System.Drawing.Size(155, 42);
            this.bttCodigo.TabIndex = 3;
            this.bttCodigo.Text = "Verificar E-mail";
            this.bttCodigo.UseVisualStyleBackColor = false;
            this.bttCodigo.Click += new System.EventHandler(this.bttCodigo_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 42);
            this.label3.TabIndex = 28;
            this.label3.Text = "Para completar a recuperação da sua conta, por favor verifique o seu e-mail. Intr" +
    "oduza o código de segurança que recebeu.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(296, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Verifique o seu e-mail";
            // 
            // bttCancelar
            // 
            this.bttCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttCancelar.FlatAppearance.BorderSize = 0;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.ForeColor = System.Drawing.Color.White;
            this.bttCancelar.Location = new System.Drawing.Point(226, 311);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(145, 42);
            this.bttCancelar.TabIndex = 2;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // GBEmail
            // 
            this.GBEmail.BackColor = System.Drawing.Color.Black;
            this.GBEmail.Controls.Add(this.txtcodigo);
            this.GBEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEmail.ForeColor = System.Drawing.Color.White;
            this.erros.SetIconAlignment(this.GBEmail, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.GBEmail.Location = new System.Drawing.Point(226, 215);
            this.GBEmail.Name = "GBEmail";
            this.GBEmail.Size = new System.Drawing.Size(306, 49);
            this.GBEmail.TabIndex = 1;
            this.GBEmail.TabStop = false;
            this.GBEmail.Text = "Código de Segurança";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Black;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.White;
            this.txtcodigo.Location = new System.Drawing.Point(3, 22);
            this.txtcodigo.MaxLength = 30;
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(278, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.label9);
            this.panelCentral.Controls.Add(this.lblCondomix);
            this.panelCentral.Controls.Add(this.lblMudarEmail);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.lblReenviar);
            this.panelCentral.Controls.Add(this.label8);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.GBEmail);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Controls.Add(this.bttCancelar);
            this.panelCentral.Controls.Add(this.bttCodigo);
            this.panelCentral.Location = new System.Drawing.Point(38, 28);
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
            this.label2.TabIndex = 36;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(649, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "_________________________________________________________________________________" +
    "__________________________";
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
            this.panelTop3.Size = new System.Drawing.Size(851, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(785, 0);
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
            this.bttExit.Location = new System.Drawing.Point(818, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // FrmCodSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(851, 635);
            this.ControlBox = false;
            this.Controls.Add(this.panelTop3);
            this.Controls.Add(this.panelCentral);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCodSeguranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCodSeguranca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.GBEmail.ResumeLayout(false);
            this.GBEmail.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelTop3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblMudarEmail;
        private System.Windows.Forms.LinkLabel lblReenviar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblCondomix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GBEmail;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
    }
}