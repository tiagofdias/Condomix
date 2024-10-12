using System;
using System.Drawing;
using System.Windows.Forms;
using Google.Authenticator;

namespace Condomix___Gestão_de_Condomínios.Login
{
    public partial class FrmAutenticacao : Form
    {
        string AccountSecretKey, NomeFuncionario, CargoFuncionario;
        int IDFuncionario;
        Image FotoFuncionario;

        public FrmAutenticacao(int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _AccountSecretKey)
        {
            InitializeComponent();

            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            AccountSecretKey = _AccountSecretKey;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            AccountSecretKey = _AccountSecretKey;
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

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
          txtCodigo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar o Pin
                TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
                bool isCorrectPIN = tfa.ValidateTwoFactorPIN(AccountSecretKey, txtCodigo.Text.Trim(), new TimeSpan(0, -4, -30));

                if (isCorrectPIN == true)
                {
                    FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }

                else
                    erros.SetError(txtCodigo, "Introduza o código de autenticação do seu autenticador Google corretamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
