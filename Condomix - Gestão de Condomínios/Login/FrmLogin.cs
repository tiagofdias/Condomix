using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pt.portugal.eid;

namespace Condomix___Gestão_de_Condomínios
{
    public partial class FrmLogin : Form
    {
        DataTable tabela = new DataTable();
        Image RoundedImage;

        public FrmLogin()
        {
            InitializeComponent();

            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 2 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
                    
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login(int NIFFuncionario)
        {
            try
            {
                if (tabela.Rows.Count == 1)
                {

                    int status = int.Parse(tabela.Rows[0][4].ToString());

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

                            DataTable tabelaFuncionario = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + NIFFuncionario + ")");

                            if (tabelaFuncionario.Rows.Count == 1)
                            {
                                int IDFuncionario = int.Parse(tabelaFuncionario.Rows[0][0].ToString());
                                int IDCargo = int.Parse(tabelaFuncionario.Rows[0][2].ToString());
                                string NomeFuncionario = tabelaFuncionario.Rows[0][6].ToString();

                                //Obter o Cargo do Funcionario
                                DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                                if (tabelaCargos.Rows.Count == 1)
                                {
                                    string CargoFuncionario = tabelaCargos.Rows[0][1].ToString();

                                    FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, RoundedImage);
                                    Utilitarios.ShowForm(janela);
                                    Utilitarios.HideForm(this);
                                }
                            }
                            else
                                MessageBox.Show("ERRO: NIF de Funcionário repetido nos funcionários");


                            break;

                        case 3:

                            //FillByNIFFuncionario - Funcionarios
                            DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + NIFFuncionario + ")");

                            if (tabelaFuncionarios.Rows.Count == 1)
                            {
                                int IDFuncionario = int.Parse(tabelaFuncionarios.Rows[0][0].ToString());
                                int IDCargo = int.Parse(tabelaFuncionarios.Rows[0][2].ToString());
                                string NomeFuncionario = tabelaFuncionarios.Rows[0][6].ToString();

                                //FillByIDCargo - Cargos
                                DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                                if (tabelaCargos.Rows.Count == 1)
                                {
                                    string CargoFuncionario = tabelaCargos.Rows[0][1].ToString();

                                    //FillByIDLogin - Logins
                                    DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

                                    if (tabelaLogins.Rows.Count == 1)
                                    {
                                        string AccountSecretKey = tabelaLogins.Rows[0][3].ToString();

                                        Login.FrmAutenticacao janela = new Login.FrmAutenticacao(IDFuncionario, NomeFuncionario, CargoFuncionario, RoundedImage, AccountSecretKey);
                                        Utilitarios.ShowForm(janela);
                                        Utilitarios.HideForm(this);
                                    }
                                }
                                else
                                    MessageBox.Show("ERRO: NIF de Funcionário repetido nos funcionários");
                            }

                            break;

                        case 4:

                            //FillByNIFFuncionario - Funcionarios
                            DataTable tabelaFuncionarios3 = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + NIFFuncionario + ")");

                            if (tabelaFuncionarios3.Rows.Count == 1)
                            {
                                int IDFuncionario = int.Parse(tabelaFuncionarios3.Rows[0][0].ToString());
                                int IDCargo = int.Parse(tabelaFuncionarios3.Rows[0][2].ToString());
                                string NomeFuncionario = tabelaFuncionarios3.Rows[0][6].ToString();

                                //FillByIDCargo - Cargos
                                DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                                if (tabelaCargos.Rows.Count == 1)
                                {
                                    string CargoFuncionario = tabelaCargos.Rows[0][1].ToString();

                                    //FillByIDFuncionario - Logins
                                    DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

                                    if (tabelaLogins.Rows.Count == 1)
                                    {
                                        int IDlogin = int.Parse(tabelaLogins.Rows[0][0].ToString());

                                        Login.FrmRedefinirPassword janela = new Login.FrmRedefinirPassword(IDlogin, IDFuncionario, CargoFuncionario, NomeFuncionario, RoundedImage);
                                        Utilitarios.ShowForm(janela);
                                        Utilitarios.HideForm(this);
                                    }
                                }
                                else
                                    MessageBox.Show("ERRO: NIF de Funcionário repetido nos funcionários");
                            }

                            break;
                    }
                }
                else if (tabela.Rows.Count > 1)
                    MessageBox.Show("ERRO: NIF de Funcionário repetido nos Logins");

                else
                    MessageBox.Show("O NIF do funcionário ou a Password foram introduzidos incorretamente. Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttCC_Click(object sender, EventArgs e)
        {
            try
            {

                PTEID_ReaderSet.initSDK();

                PTEID_EIDCard card;
                PTEID_ReaderContext context;
                PTEID_ReaderSet readerSet;
                readerSet = PTEID_ReaderSet.instance();

                for (int i = 0; i < readerSet.readerCount(); i++)
                {
                    context = readerSet.getReaderByNum(Convert.ToUInt32(i));

                    if (context.isCardPresent())
                    {
                        card = context.getEIDCard();
                        PTEID_EId eid = card.getID();

                        //Numero de identificação fiscal
                        string nIDFiscal = eid.getTaxNo();

                        //FillByNIFFuncionario - Funcionarios
                        DataTable tabelaFuncionario1 = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(nIDFiscal.Trim()) + ")");

                        if (tabelaFuncionario1.Rows.Count == 1)
                        {
                            int IDFuncionario = int.Parse(tabelaFuncionario1.Rows[0][0].ToString());

                            //Obter Foto da BD
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")", con);

                                var reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    byte[] byteImg = (byte[])reader["Foto"];

                                    //Apresentar Imagem normal
                                    //pictureBox2.Image = ConverterBinarioParaImagem(byteImg);

                                    //Apresentar Imagem Circular
                                    Image StartImage = Utilitarios.ConverterBinarioParaImagem(byteImg);
                                    RoundedImage = Utilitarios.ClipToCircle(StartImage, new PointF(StartImage.Width / 2, StartImage.Height / 2), StartImage.Width / 2);

                                }
                                con.Close();
                            }

                            //FillByIDFuncionario - Logins
                            tabela = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

                            Login(int.Parse(nIDFiscal));

                        }
                        else
                            MessageBox.Show("Este funcionário ainda não está registado no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Introduza o cartão de cidadão no leitor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PTEID_ReaderContext readerContext = PTEID_ReaderSet.instance().getReader();
                PTEID_ReaderSet.releaseSDK();

            }
            catch (PTEID_ExNoReader)
            {
                MessageBox.Show("Não foram detetados leitores de cartões!");
                return;
            }
            catch (PTEID_ExNoCardPresent)
            {
                MessageBox.Show("Introduza o cartão de cidadão no leitor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (PTEID_ExCardTypeUnknown)
            {
                MessageBox.Show("Cartão desconhecido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (PTEID_ExBadTransaction)
            {
                MessageBox.Show("Ocorreu um Erro. Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {

                    string senha = Crypto.sha256encrypt(txtPassword.Text);

                    //FillByNIFFuncionario - Funcionarios
                    DataTable tabelaFuncionario2 = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(txtNIF.Text.Trim()) + ")");

                    if (tabelaFuncionario2.Rows.Count == 1)
                    {
                        int IDFuncionario = int.Parse(tabelaFuncionario2.Rows[0][0].ToString());

                        //Obter Foto da BD
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")", con);
                        
                            var reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                byte[] byteImg = (byte[])reader["Foto"];

                            //Apresentar Imagem normal
                            //pictureBox2.Image = ConverterBinarioParaImagem(byteImg);

                            //Apresentar Imagem Circular
                            Image StartImage = Utilitarios.ConverterBinarioParaImagem(byteImg);
                            RoundedImage = Utilitarios.ClipToCircle(StartImage, new PointF(StartImage.Width / 2, StartImage.Height / 2), StartImage.Width / 2);

                        }
                            con.Close();
                        }

                        //FillByIDFuncionario - Logins
                        tabela = Utilitarios.FillBy("SELECT * FROM Logins WHERE (IDFuncionario = " + IDFuncionario + ")");

                        string Password = tabela.Rows[0][2].ToString();

                        if (Password == senha) Login(int.Parse(txtNIF.Text)); else MessageBox.Show("O NIF do funcionário ou a Password foram introduzidos incorretamente. Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //senha
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbRecuperarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        public bool Validar()
        {
            erros.Clear();

            bool erro = false;

            if (Validacoes.IsValidContrib(txtNIF.Text) == false)
            {
                erro = true;
                erros.SetError(txtNIF, "Introduza um NIF valido");
            }

            erro = Validacoes.ValidarCampoVazio(panelCentral, erro, erros);

            return erro;
        }

        private void txtNIF_KeyDown(object sender, KeyEventArgs e)
        {
            txtNIF.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            txtPassword.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
        }
    }
}
