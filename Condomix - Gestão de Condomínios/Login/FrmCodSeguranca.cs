using System;
using System.Drawing;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Login
{
    public partial class FrmCodSeguranca : Form
    {

        string codigo, email, NomeFuncionario;
        int IDLogin;

        public FrmCodSeguranca(string _codigo, string _email, int _IDLogin, string _NomeFuncionario)
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            codigo = _codigo;
            email = _email;
            NomeFuncionario = _NomeFuncionario;
            IDLogin = _IDLogin;
        }

        private void bttCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo.Text == codigo)
                {
                    Login.FrmRedefinirPassword janela = new Login.FrmRedefinirPassword(IDLogin);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }
                else
                    erros.SetError(txtcodigo, "Introduza o código correto e tente novamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Login.FrmRecuperarConta janela = new Login.FrmRecuperarConta();
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void bttCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLogin janela = new FrmLogin();
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            txtcodigo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
        }

        private void lblReenviar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Utilitarios.Internet() == true)
                {
                    codigo = Utilitarios.GerarStringAleatoria(6, "0123456789");
                    Utilitarios.EnviarEmail("Moviarcas@gmail.com", "wzcbnwlrjdplxotp", email, NomeFuncionario, codigo, "RecuperarConta.txt");

                    MessageBox.Show("E-mail reenviado com sucesso");
                }
                else
                    MessageBox.Show("É necessário estar conectado à internet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
