
namespace Condomix___Gestão_de_Condomínios.Login
{
    partial class FrmRedefinirPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedefinirPassword));
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBPass = new System.Windows.Forms.GroupBox();
            this.iconPass = new FontAwesome.Sharp.IconPictureBox();
            this.txtNovaPass = new System.Windows.Forms.TextBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblSeguranca = new System.Windows.Forms.Label();
            this.lblCondomix = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttContinuar = new System.Windows.Forms.Button();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.GBPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.panelTop3.SuspendLayout();
            this.SuspendLayout();
            // 
            // erros
            // 
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            this.erros.Icon = ((System.Drawing.Icon)(resources.GetObject("erros.Icon")));
            // 
            // GBPass
            // 
            this.GBPass.BackColor = System.Drawing.Color.Black;
            this.GBPass.Controls.Add(this.iconPass);
            this.GBPass.Controls.Add(this.txtNovaPass);
            this.GBPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPass.ForeColor = System.Drawing.Color.White;
            this.erros.SetIconAlignment(this.GBPass, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.GBPass.Location = new System.Drawing.Point(225, 215);
            this.GBPass.Name = "GBPass";
            this.GBPass.Size = new System.Drawing.Size(307, 49);
            this.GBPass.TabIndex = 0;
            this.GBPass.TabStop = false;
            this.GBPass.Text = "Password";
            // 
            // iconPass
            // 
            this.iconPass.ErrorImage = ((System.Drawing.Image)(resources.GetObject("iconPass.ErrorImage")));
            this.iconPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPass.IconColor = System.Drawing.Color.White;
            this.iconPass.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPass.IconSize = 25;
            this.iconPass.InitialImage = global::Condomix___Gestão_de_Condomínios.Properties.Resources.img_246059;
            this.iconPass.Location = new System.Drawing.Point(247, 21);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(34, 25);
            this.iconPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPass.TabIndex = 34;
            this.iconPass.TabStop = false;
            this.iconPass.Click += new System.EventHandler(this.iconPass_Click);
            // 
            // txtNovaPass
            // 
            this.txtNovaPass.BackColor = System.Drawing.Color.Black;
            this.txtNovaPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovaPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaPass.ForeColor = System.Drawing.Color.White;
            this.txtNovaPass.Location = new System.Drawing.Point(3, 22);
            this.txtNovaPass.MaxLength = 25;
            this.txtNovaPass.Multiline = true;
            this.txtNovaPass.Name = "txtNovaPass";
            this.txtNovaPass.PasswordChar = '.';
            this.txtNovaPass.Size = new System.Drawing.Size(278, 20);
            this.txtNovaPass.TabIndex = 0;
            this.txtNovaPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaPass_KeyDown);
            this.txtNovaPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNovaPass_KeyUp);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.lblSeguranca);
            this.panelCentral.Controls.Add(this.lblCondomix);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.GBPass);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.bttCancelar);
            this.panelCentral.Controls.Add(this.bttContinuar);
            this.panelCentral.Location = new System.Drawing.Point(25, 39);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(769, 570);
            this.panelCentral.TabIndex = 0;
            // 
            // lblSeguranca
            // 
            this.lblSeguranca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguranca.ForeColor = System.Drawing.Color.White;
            this.lblSeguranca.Location = new System.Drawing.Point(364, 267);
            this.lblSeguranca.Name = "lblSeguranca";
            this.lblSeguranca.Size = new System.Drawing.Size(158, 21);
            this.lblSeguranca.TabIndex = 37;
            this.lblSeguranca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(649, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Segurança da Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(62, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(649, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Escolher uma palavra-passe nova";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(150, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 43);
            this.label3.TabIndex = 28;
            this.label3.Text = "Crie uma nova palavra-passe que tenha, pelo menos, 6 carateres. Para ter uma pala" +
    "vra-passe forte, use uma combinação de letras, números e sinais de pontuação.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bttCancelar.Size = new System.Drawing.Size(146, 42);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttContinuar
            // 
            this.bttContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.bttContinuar.FlatAppearance.BorderSize = 0;
            this.bttContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttContinuar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttContinuar.ForeColor = System.Drawing.Color.White;
            this.bttContinuar.Location = new System.Drawing.Point(377, 311);
            this.bttContinuar.Name = "bttContinuar";
            this.bttContinuar.Size = new System.Drawing.Size(155, 42);
            this.bttContinuar.TabIndex = 2;
            this.bttContinuar.Text = "Continuar";
            this.bttContinuar.UseVisualStyleBackColor = false;
            this.bttContinuar.Click += new System.EventHandler(this.bttContinuar_Click);
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
            this.panelTop3.Size = new System.Drawing.Size(909, 33);
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
            this.bttMinimize.Location = new System.Drawing.Point(843, 0);
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
            this.bttExit.Location = new System.Drawing.Point(876, 0);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(33, 33);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "X";
            this.bttExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // FrmRedefinirPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(909, 635);
            this.ControlBox = false;
            this.Controls.Add(this.panelTop3);
            this.Controls.Add(this.panelCentral);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRedefinirPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRedefinirPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRedefinirPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.GBPass.ResumeLayout(false);
            this.GBPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelTop3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblCondomix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBPass;
        private FontAwesome.Sharp.IconPictureBox iconPass;
        private System.Windows.Forms.TextBox txtNovaPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttContinuar;
        private System.Windows.Forms.Label lblSeguranca;
    }
}