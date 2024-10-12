using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Login
{
    public partial class FrmRecuperarConta : Form
    {

        public FrmRecuperarConta()
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public bool Validar()
        {
            erros.Clear();

            bool erro = false;
      
            if (Validacoes.IsValidEmail(txtEmail.Text,txtEmail) == false)
            {
                erro = true;
                erros.SetError(txtEmail, "Introduza um Email valido");
            }

            erro = Validacoes.ValidarCampoVazio(panelCentral, erro, erros);

            return erro;

        }

        private void bttRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {

                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        //FillByEmail - Contactos
                        con.Open();
                        string FillByEmail = "SELECT * FROM Contactos WHERE(Email = '" + txtEmail.Text.Trim() + "')";

                        SqlDataAdapter adp;
                        adp = new SqlDataAdapter(FillByEmail, con);

                        DataTable tabelaContactos = new DataTable();
                        adp.Fill(tabelaContactos);
                        con.Close();

                        if (tabelaContactos.Rows.Count == 1)
                        {

                            int IDContacto = int.Parse(tabelaContactos.Rows[0][0].ToString());

                            //FillByIDContacto - Funcionarios
                            con.Open();
                            string FillByIDContacto = "SELECT * FROM Funcionarios WHERE(IDContacto = " + IDContacto + ")";

                            adp = new SqlDataAdapter(FillByIDContacto, con);

                            DataTable tabelaFuncionarios = new DataTable();
                            adp.Fill(tabelaFuncionarios);
                            con.Close();

                            if (tabelaFuncionarios.Rows.Count == 1)
                            {

                                int IDFuncionario = int.Parse(tabelaFuncionarios.Rows[0][0].ToString());
                                string NomeFuncionario = tabelaFuncionarios.Rows[0][5].ToString();

                                //FillByIDFuncionario - Logins
                                con.Open();
                                string FillByIDFuncionario = "SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")";

                                adp = new SqlDataAdapter(FillByIDFuncionario, con);

                                DataTable tabelaLogins = new DataTable();
                                adp.Fill(tabelaLogins);
                                con.Close();

                                if (tabelaLogins.Rows.Count == 1)
                                {
                                    int IDLogin = int.Parse(tabelaLogins.Rows[0][0].ToString());
                                    int status = int.Parse(tabelaLogins.Rows[0][4].ToString());

                                    //0 - DESATIVADO SEM 2ND STEP
                                    //1 - DESATIVADO COM 2ND STEP
                                    //2 - ATIVADO SEM 2ND STEP
                                    //3 - ATIVADO COM 2ND STEP
                                    //4 - ATIVADO MAS PRIMEIRA VEZ QUE FAZ LOGIN

                                    switch (status)
                                    {

                                        case 0:
                                        case 1:
                                            MessageBox.Show("Este funcionário não está autorizado a fazer login");
                                            break;

                                        case 2:
                                        case 3:
                                        case 4:

                                            string codigo = Utilitarios.GerarStringAleatoria(6, "0123456789");

                                            if (Utilitarios.Internet() == true)
                                            {

                                                Utilitarios.EnviarEmail("Moviarcas@gmail.com", "wzcbnwlrjdplxotp", txtEmail.Text.Trim(), NomeFuncionario, codigo, "RecuperarConta.txt");

                                                Login.FrmCodSeguranca janela = new Login.FrmCodSeguranca(codigo, txtEmail.Text.Trim(), IDLogin, NomeFuncionario);
                                                Utilitarios.ShowForm(janela);
                                                Utilitarios.HideForm(this);

                                            }
                                            else
                                                MessageBox.Show("O computador precisa de estar conectado à internet", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            break;
                                    }
                                }
                                else
                                    MessageBox.Show("Erro 2");
                            }
                            else
                                MessageBox.Show("Erro 1");
                        }
                        else
                            erros.SetError(txtEmail, "Não existe nenhum funcionário registado com esse endereço de e-mail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRecuperarConta_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            txtEmail.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
        }
    }
}
