
namespace Condomix___Gestão_de_Condomínios.Login
{
    partial class FrmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutenticacao));
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCondomix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttCodigo = new System.Windows.Forms.Button();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop3.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.GBCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.SuspendLayout();
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
            this.panelTop3.Size = new System.Drawing.Size(1255, 33);
            this.panelTop3.TabIndex = 39;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttMinimize.Location = new System.Drawing.Point(1189, 0);
            this.bttMinimize.Name = "bttMinimize";
            this.bttMinimize.Size = new System.Drawing.Size(33, 33);
            this.bttMinimize.TabIndex = 3;
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
            this.bttExit.Location = new System.Drawing.Point(1222, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 4;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.lblCondomix);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.GBCodigo);
            this.panelCentral.Controls.Add(this.label11);
            this.panelCentral.Controls.Add(this.bttCancelar);
            this.panelCentral.Controls.Add(this.bttCodigo);
            this.panelCentral.Location = new System.Drawing.Point(214, 58);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(769, 570);
            this.panelCentral.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 42);
            this.label3.TabIndex = 40;
            this.label3.Text = "A autenticação de dois fatores está ativa. Verifique o seu autenticador da Google" +
    " para obter o código de autenticação. Introduza esse código aqui.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblCondomix.TabIndex = 34;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // GBCodigo
            // 
            this.GBCodigo.Controls.Add(this.txtCodigo);
            this.GBCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCodigo.ForeColor = System.Drawing.Color.White;
            this.GBCodigo.Location = new System.Drawing.Point(225, 227);
            this.GBCodigo.Name = "GBCodigo";
            this.GBCodigo.Size = new System.Drawing.Size(307, 49);
            this.GBCodigo.TabIndex = 33;
            this.GBCodigo.TabStop = false;
            this.GBCodigo.Text = "Código de Autenticação";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Black;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(3, 19);
            this.txtCodigo.MaxLength = 255;
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '.';
            this.txtCodigo.Size = new System.Drawing.Size(278, 20);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.UseSystemPasswordChar = true;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(272, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Autenticação de Dois Fatores";
            // 
            // bttCancelar
            // 
            this.bttCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttCancelar.FlatAppearance.BorderSize = 0;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.ForeColor = System.Drawing.Color.White;
            this.bttCancelar.Location = new System.Drawing.Point(225, 311);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(145, 42);
            this.bttCancelar.TabIndex = 39;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttCodigo
            // 
            this.bttCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttCodigo.FlatAppearance.BorderSize = 0;
            this.bttCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCodigo.ForeColor = System.Drawing.Color.White;
            this.bttCodigo.Location = new System.Drawing.Point(376, 311);
            this.bttCodigo.Name = "bttCodigo";
            this.bttCodigo.Size = new System.Drawing.Size(155, 42);
            this.bttCodigo.TabIndex = 38;
            this.bttCodigo.Text = "Verificar";
            this.bttCodigo.UseVisualStyleBackColor = false;
            this.bttCodigo.Click += new System.EventHandler(this.bttCodigo_Click);
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // FrmAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1255, 683);
            this.ControlBox = false;
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutenticacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop3.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.GBCodigo.ResumeLayout(false);
            this.GBCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblCondomix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttCodigo;
        private System.Windows.Forms.Label label3;
    }
}