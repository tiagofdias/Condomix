using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Condomix___Gestão_de_Condomínios.Login
{

    public partial class FrmRedefinirPassword : Form
    {
        int IDLogin, IDFuncionario;
        string NomeFuncionario, CargoFuncionario;
        Image FotoFuncionario;

        public FrmRedefinirPassword(int _IDLogin)
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            IDLogin = _IDLogin;
        }

        public FrmRedefinirPassword(int _IDLogin, int _IDFuncionario, string _CargoFuncionario, string _NomeFuncionario, Image _FotoFuncionario)
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            IDLogin = _IDLogin;
            IDFuncionario = _IDFuncionario;
            CargoFuncionario = _CargoFuncionario;
            NomeFuncionario = _NomeFuncionario;
            FotoFuncionario = _FotoFuncionario;
        }

        public FrmRedefinirPassword()
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void bttContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblSeguranca.Text == "Forte")
                {

                    string senha = Crypto.sha256encrypt(txtNovaPass.Text);

                    //FillByIDLogin - Logins
                    DataTable tabela = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDLogin = " + IDLogin + ")");

                    if (tabela.Rows.Count == 1)
                    {
                        int Status = int.Parse(tabela.Rows[0][4].ToString());

                        //Primeira Vez
                        if (Status == 4)
                        {
                            //Update
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {

                                SqlCommand cmd = new SqlCommand("UPDATE Logins SET Password = @Password, Status = @Status WHERE(IDLogin = @IDLogin)", con);

                                cmd.Parameters.AddWithValue("@IDLogin", IDLogin);
                                cmd.Parameters.AddWithValue("@Password", senha);
                                cmd.Parameters.AddWithValue("@Status", 2);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            MessageBox.Show("A sua password foi criada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario);
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);

                        }
                        else
                        {
                            //Update
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {

                                SqlCommand cmd = new SqlCommand("UPDATE Logins SET Password = @Password WHERE(IDLogin = @IDLogin)", con);

                                cmd.Parameters.AddWithValue("@IDLogin", IDLogin);
                                cmd.Parameters.AddWithValue("@Password", senha);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            MessageBox.Show("A sua password foi alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmLogin janela = new FrmLogin();
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);

                        }
                    }

                }
                else
                    erros.SetError(txtNovaPass, "Introduza uma password forte");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRedefinirPassword_Load(object sender, EventArgs e)
        {
            txtNovaPass.UseSystemPasswordChar = false;
        }

        private void iconPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNovaPass.UseSystemPasswordChar == false)
                {
                    txtNovaPass.UseSystemPasswordChar = true;
                    iconPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }
                else
                {
                    txtNovaPass.UseSystemPasswordChar = false;
                    iconPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNovaPass_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String password = txtNovaPass.Text;

                int valor = Utilitarios.CheckStrength(password);

                if (valor >= 6)
                {
                    lblSeguranca.Text = "Forte";
                    lblSeguranca.ForeColor = Color.Green;

                }
                else if (valor >= 4)
                {

                    lblSeguranca.Text = "Média";
                    lblSeguranca.ForeColor = Color.Yellow;
                }
                else if (valor >= 0)
                {
                    lblSeguranca.Text = "Fraca";
                    lblSeguranca.ForeColor = Color.Red;

                }
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

        private void txtNovaPass_KeyDown(object sender, KeyEventArgs e)
        {
            txtNovaPass.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
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
    }
}

