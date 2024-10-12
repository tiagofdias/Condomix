using FontAwesome.Sharp;
using Google.Authenticator;
using pt.portugal.eid;
using QRCoder;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    public partial class Definicoes : Form
    {
        int IDFuncionario, IDCargo, IDMorada, IDContacto, op;
        string NomeFuncionario, CargoFuncionario, nif, Cor;
        Image FotoFuncionario;
        public Definicoes(int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;
        }

        private void Definicoes_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme)
                {
                    foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelMorada.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelContactos.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelPassword.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelPassword2.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelAutenticacao.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                }


                panelSeguranca.Location = new Point(2, 6);

                erros.Clear();

                bttPerfil.PerformClick();

                foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.ReadOnly = true;
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                    }
                foreach (GroupBox Controlo2 in panelMorada.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        Controlo.ReadOnly = true;
                    }

                //Pintar com a cor
                foreach (FontAwesome.Sharp.IconButton Controlo in panelPerfil.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);
                foreach (FontAwesome.Sharp.IconButton Controlo in panelFoto.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);
                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Image ConverterBinarioParaImagem(byte[] foto)
        {
            using (MemoryStream ms = new MemoryStream(foto))
            {
                return Image.FromStream(ms);
            }
        }

        private void bttPass_Click(object sender, EventArgs e)
        {
            try
            {
                switch (bttPass.Text)
                {
                    case "Alterar Password":

                        txtPassAtual.ResetText();
                        txtPassNova.ResetText();
                        txtPassNova.UseSystemPasswordChar = false;
                        txtPassAtual.UseSystemPasswordChar = false;
                        panelPassword.Visible = true;
                        bttPass.Text = "Continuar";
                        lblSeguranca.ResetText();
                        txtPassAtual.Focus();

                        break;

                    case "Concluir":

                        if (lblSeguranca.Text == "Forte")
                        {
                            string SenhaNova = Crypto.sha256encrypt(txtPassNova.Text.Trim());

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Logins SET Password = @Password WHERE(IDFuncionario = @IDFuncionario)", con);

                                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                                cmd.Parameters.AddWithValue("@Password", SenhaNova);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("A sua password foi alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            panelPassword2.Visible = false;
                            panelLeft.Visible = true;
                            panelRight.Visible = true;
                            bttPass.Text = "Alterar Password";
                           
                        }
                        else
                            erros.SetError(txtPassNova, "Introduza uma password forte");

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEditarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (bttGuardar.Visible == false)
                {
                    foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                        {
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                            if (Controlo.Name == "txtCargo") Controlo.ReadOnly = true; else Controlo.ReadOnly = false; 
                        }
                    foreach (GroupBox Controlo2 in panelMorada.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                        {
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                            Controlo.ReadOnly = false; 
                        }
                    foreach (GroupBox Controlo2 in panelContactos.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                        {
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                            Controlo.ReadOnly = false;
                        }
                    bttGuardar.Visible = true;
                    bttGuardar.Focus();

                    cbCargos.Text = txtCargo.Text;
                    DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                    if (tabelaCargos.Rows.Count == 1)
                    {

                        if (tabelaCargos.Rows[0][1].ToString() == "Administrador")
                        {
                            txtCargo.Visible = false;
                            cbCargos.Visible = true;
                        }
                        else
                        {
                            txtCargo.Visible = true;
                            cbCargos.Visible = false;
                        }

                        if (op == 0)
                            MessageBox.Show("O modo de edição está ativo", "Modo de Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    Desativar();
                    txtCargo.Visible = true;
                    cbCargos.Visible = false;
                    MessageBox.Show("O modo de edição está desativado", "Modo de Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desativar()
        {
            try
            {
                erros.Clear();
                foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        Controlo.ReadOnly = true; 
                    }
                foreach (GroupBox Controlo2 in panelMorada.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        Controlo.ReadOnly = true;
                    }
                bttGuardar.Visible = false;
                bttPerfil.PerformClick();
                bttPerfil.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarFoto(String filePath, int chegueide)
        {
            try
            {
                using (Stream stream = File.OpenRead(filePath))
                {

                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);

                    string extn = new FileInfo(filePath).Extension;
                    double fileSizeMB = stream.Length / (1024 * 1024);

                    if (fileSizeMB == 0)
                    {

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Funcionarios SET Foto = @Foto WHERE(IDFuncionario = @IDFuncionario)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@Foto", buffer);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        if (chegueide != 0) bttPerfil.Focus();

                        //Apresentar Imagem Circular
                        Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(filePath), new PointF(Image.FromFile(filePath).Width / 2, Image.FromFile(filePath).Height / 2), Image.FromFile(filePath).Width / 2);
                        pictureBoxFoto.Image = RoundedImage;

                    }
                    else
                        MessageBox.Show("Só são permitidos ficheiros com um tamanho máximo de 1 MB", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bttAtualizarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //Browse
                OpenFileDialog dlg = new OpenFileDialog() { Filter = "JPG|*.jpg;*.jpeg|PNG|*.png", ValidateNames = true, Multiselect = false };

                if (dlg.ShowDialog() == DialogResult.OK)
                    AtualizarFoto(dlg.FileName, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DesativarContactos()
        {
            try
            {
                foreach (GroupBox Controlo2 in panelContactos.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        Controlo.ReadOnly = true;
                    }
                bttSeguranca.PerformClick();
                bttSeguranca.Focus();
                erros.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassNova.UseSystemPasswordChar == false)
                {
                    txtPassNova.UseSystemPasswordChar = true;
                    iconPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }
                else
                {
                    txtPassNova.UseSystemPasswordChar = false;
                    iconPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassNova_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String password = txtPassNova.Text;

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

        private void txtCP_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtCP.TextLength == 4)
                {
                    txtCP.Text += "-";
                    txtCP.SelectionStart = txtCP.Text.Length;
                    txtCP.SelectionLength = 0;
                }
                else if (txtCP.TextLength == 8)
                {
                    Utilitarios.ObterCodigoPostal(txtCP, txtMorada, txtLocalidade);
                }
                else
                {
                    txtMorada.ResetText();
                    txtLocalidade.ResetText();
                }
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

                        //FillByNIFFuncionarios
                        DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(eid.getTaxNo()) + ")");

                        //Editar
                        if (eid.getTaxNo() != nif.ToString())
                        {
                            if (tabelaFuncionarios.Rows.Count != 0)
                            { 
                                MessageBox.Show("Este cartão já está associado a outro funcionário", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                                bttPerfil.Focus(); 
                            }
                            else
                                CCComplemento();
                        }
                        else
                            CCComplemento();    
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

        private void bttHome_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                iconCurrentChildForm.IconChar = IconChar.UserAlt;
                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                lblTitleChildForm.Text = "Perfil";

                ActivateButton(sender, Customizar.HexToColor(Cor));

                DataTable tabelaFuncionario = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")");

                if (tabelaFuncionario.Rows.Count == 1)
                {
                    txtNIF.Text = tabelaFuncionario.Rows[0][1].ToString();
                    nif = tabelaFuncionario.Rows[0][1].ToString();
                    IDCargo = int.Parse(tabelaFuncionario.Rows[0][2].ToString());
                    IDContacto = int.Parse(tabelaFuncionario.Rows[0][3].ToString());
                    IDMorada = int.Parse(tabelaFuncionario.Rows[0][4].ToString());
                    txtNome.Text = tabelaFuncionario.Rows[0][6].ToString();

                    //FOTO
                    pictureBoxFoto.Image = Utilitarios.ObterFoto("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")");

                    DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                    if (tabelaCargos.Rows.Count == 1)
                    {
                        // Carrega os cargos para a COMBOBOX
                        DataTable dt = Utilitarios.FillBy("SELECT IDCargo, Cargo FROM Cargos");
                        foreach (DataRow row in dt.Rows) cbCargos.Items.Add(row["Cargo"].ToString());

                        txtCargo.Text = tabelaCargos.Rows[0][1].ToString();
                        cbCargos.Text = txtCargo.Text;

                        txtCargo.Visible = true;
                        cbCargos.Visible = false;

                        DataTable tabelaMorada = Utilitarios.FillBy("SELECT * FROM Moradas WHERE(IDMorada = " + IDMorada + ")");

                        if (tabelaMorada.Rows.Count == 1)
                        {
                            txtMorada.Text = tabelaMorada.Rows[0][1].ToString();
                            txtLocalidade.Text = tabelaMorada.Rows[0][2].ToString();
                            txtCP.Text = tabelaMorada.Rows[0][3].ToString();
                        }

                        DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE(IDContacto = " + IDContacto + ")");

                        if (tabelaContactos.Rows.Count == 1)
                        {
                            txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                            txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                            txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();
                        }
                    }
                }

                panelSeguranca.Visible = false;
                panelPerfil.Visible = true;
                panelCustomizar.Visible = false;
                bttGuardar.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private IconButton currentBtn;
        private void ActivateButton(object senderBtn, Color color)
        {
            try
            {
                if (senderBtn != null)
                {
                    DisableButton();
                    //Button
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(31, 31, 35);
                    currentBtn.ForeColor = color;
                    currentBtn.IconColor = color;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisableButton()
        {
            try
            {
                if (currentBtn != null)
                {
                    currentBtn.BackColor = Color.FromArgb(31, 31, 35);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bttSeguranca_Click(object sender, EventArgs e)
        {
            try
            {
                panelPerfil.Visible = false;
                panelPassword.Visible = false;
                panelPassword2.Visible = false;
                panelAutenticacao.Visible = false;
                panelSeguranca.Visible = true;
                panelCustomizar.Visible = false;

                foreach (GroupBox Controlo2 in panelContactos.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {
                        Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        Controlo.ReadOnly = true;
                    }
                bttPass.Text = "Alterar Password";

                erros.Clear();
                DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE(IDContacto = " + IDContacto + ")");

                if (tabelaContactos.Rows.Count == 1)
                {
                    txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                    txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                    txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();

                    DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

                    if (tabelaLogins.Rows.Count == 1)
                    {

                        int Status = int.Parse(tabelaLogins.Rows[0][4].ToString());

                        if (Status == 2)
                        {
                            bttAutenticacao.Text = "Ativar";
                            lblStatus.Text = "Desativada";
                            lblStatus.ForeColor = Color.Red;

                        }
                        else
                        {
                            bttAutenticacao.Text = "Desativar";
                            lblStatus.Text = "Ativada";
                            lblStatus.ForeColor = Color.FromArgb(95, 250, 254);
                        }
                    }
                }

                ActivateButton(sender, Customizar.HexToColor(Cor));
                iconCurrentChildForm.IconChar = IconChar.Lock;
                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                lblTitleChildForm.Text = "Segurança";

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

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {

            DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

            if (tabelaLogins.Rows.Count == 1 && txtCodigo.TextLength == 6)
            {
                int IDLogin = int.Parse(tabelaLogins.Rows[0][0].ToString());
                string AccountSecretKey = tabelaLogins.Rows[0][3].ToString();

                // Validar o Pin
                TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
                bool isCorrectPIN = tfa.ValidateTwoFactorPIN(AccountSecretKey, txtCodigo.Text.Trim(), new TimeSpan(0, -4, -30));

                if (isCorrectPIN == true)
                {

                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Logins SET Status = @Status WHERE(IDLogin = @IDLogin)", con);

                        cmd.Parameters.AddWithValue("@IDLogin", IDLogin);
                        cmd.Parameters.AddWithValue("@Status", 3);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    lblStatus.Text = "Ativada";
                    lblStatus.ForeColor = Color.FromArgb(95, 250, 254);

                    panelAutenticacao.Visible = false;
                    bttAutenticacao.Text = "Desativar";
                }
                else
                    erros.SetError(txtCodigo, "Introduza o código de autenticação do seu autenticador Google corretamente");
            }
        }

        private void txtPassAtual_KeyUp(object sender, KeyEventArgs e)
        {
            string senha = Crypto.sha256encrypt(txtPassAtual.Text.Trim());

            //FillByIDFuncionario - Logins
            DataTable tabela = Utilitarios.FillBy("SELECT * FROM Logins WHERE (IDFuncionario = " + IDFuncionario + ")");

            string Password = tabela.Rows[0][2].ToString();

            if (Password == senha)
            {
                panelPassword.Visible = false;
                panelPassword2.Visible = true;
                bttPass.Text = "Concluir";
                txtPassNova.Focus();
            }
           
        }

        private void bttCustomizar_Click(object sender, EventArgs e)
        {

            panelPerfil.Visible = false;
            panelSeguranca.Visible = false;
            panelCustomizar.Visible = true;
            iconCurrentChildForm.IconChar = IconChar.Palette;
            iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
            lblTitleChildForm.Text = "Customização";

            ActivateButton(sender, Customizar.HexToColor(Cor));

            AtualizarCores(Cor,true);
            //Colocar cores XD

            try
            {
                panelCores.Visible = true;

                string startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\cyan.jpg";
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor1.Image = RoundedImage;

                startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\red.jpg";
                RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor2.Image = RoundedImage;

                startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\purple.jpg";
                RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor3.Image = RoundedImage;

                startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\yellow.jpg";
                RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor4.Image = RoundedImage;

                startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\green.jpg";
                RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor5.Image = RoundedImage;

                startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Colors\pink.jpg";
                RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                PBCor6.Image = RoundedImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AtualizarCores(string Cor, bool bttC)
        {
            try
            {
                switch (Cor)
                {

                    case "#00ffff":

                        PBIcon1.Visible = true;
                        PBIcon2.Visible = false;
                        PBIcon3.Visible = false;
                        PBIcon4.Visible = false;
                        PBIcon5.Visible = false;
                        PBIcon6.Visible = false;

                        break;

                    case "#ff0009":

                        PBIcon1.Visible = false;
                        PBIcon2.Visible = true;
                        PBIcon3.Visible = false;
                        PBIcon4.Visible = false;
                        PBIcon5.Visible = false;
                        PBIcon6.Visible = false;

                        break;

                    case "#836FFF":

                        PBIcon1.Visible = false;
                        PBIcon2.Visible = false;
                        PBIcon3.Visible = true;
                        PBIcon4.Visible = false;
                        PBIcon5.Visible = false;
                        PBIcon6.Visible = false;

                        break;

                    case "#e8ff00":

                        PBIcon1.Visible = false;
                        PBIcon2.Visible = false;
                        PBIcon3.Visible = false;
                        PBIcon4.Visible = true;
                        PBIcon5.Visible = false;
                        PBIcon6.Visible = false;

                        break;

                    case "#00fd95":

                        PBIcon1.Visible = false;
                        PBIcon2.Visible = false;
                        PBIcon3.Visible = false;
                        PBIcon4.Visible = false;
                        PBIcon5.Visible = true;
                        PBIcon6.Visible = false;

                        break;

                    case "#fe81ff":

                        PBIcon1.Visible = false;
                        PBIcon2.Visible = false;
                        PBIcon3.Visible = false;
                        PBIcon4.Visible = false;
                        PBIcon5.Visible = false;
                        PBIcon6.Visible = true;

                        break;
                }

                if (bttC == false)
                {


                    DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE (IDFuncionario = " + IDFuncionario + ")");

                    int IDCustomizacao = int.Parse(tabelaFuncionarios.Rows[0][5].ToString());

                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Customizacao SET Cor = @Cor WHERE(IDCustomizacao = @IDCustomizacao)", con);

                        cmd.Parameters.AddWithValue("@IDCustomizacao", IDCustomizacao);
                        cmd.Parameters.AddWithValue("@Cor", Cor);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }


                    ActivateButton(bttCustomizar, Customizar.HexToColor(Cor));

                    foreach (FontAwesome.Sharp.IconButton Controlo in panelPerfil.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);
                    foreach (FontAwesome.Sharp.IconButton Controlo in panelFoto.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);
                    iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void PBCor1_Click(object sender, EventArgs e)
        {
            Cor = "#00ffff";
            AtualizarCores(Cor,false);

        }

        private void PBCor2_Click(object sender, EventArgs e)
        {
            Cor = "#ff0009";
            AtualizarCores(Cor, false);
        }

        private void PBCor3_Click(object sender, EventArgs e)
        {
            Cor = "#836FFF";
            AtualizarCores(Cor, false);
        }

        private void PBCor4_Click(object sender, EventArgs e)
        {
            Cor = "#e8ff00";
            AtualizarCores(Cor, false);
        }

        private void PBCor5_Click(object sender, EventArgs e)
        {
            Cor = "#00fd95";
            AtualizarCores(Cor, false);
        }

        private void PBCor6_Click(object sender, EventArgs e)
        {
            Cor = "#fe81ff";
            AtualizarCores(Cor, false);
        }

        private void PBIcon1_Click(object sender, EventArgs e)
        {
            Cor = "#00ffff";
            AtualizarCores(Cor, false);
        }

        private void PBIcon2_Click(object sender, EventArgs e)
        {
            Cor = "#ff0009";
            AtualizarCores(Cor, false);
        }

        private void PBIcon3_Click(object sender, EventArgs e)
        {
            Cor = "#836FFF";
            AtualizarCores(Cor, false);
        }

        private void PBIcon4_Click(object sender, EventArgs e)
        {
            Cor = "#e8ff00";
            AtualizarCores(Cor, false);
        }

        private void PBIcon5_Click(object sender, EventArgs e)
        {
            Cor = "#00fd95";
            AtualizarCores(Cor, false);
        }

        private void PBIcon6_Click(object sender, EventArgs e)
        {
            Cor = "#fe81ff";
            AtualizarCores(Cor, false);
        }

        private void txtPassNova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) bttPass.PerformClick();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CCComplemento()
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

                        if (bttGuardar.Visible == false)
                        {
                            op = 1;
                            bttEditarPerfil.PerformClick();
                            op = 0;
                        }

                        //Obter a primeira e ultima palavra do nome
                        string[] palavras = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(eid.getGivenName().ToLower() + " " + eid.getSurname().ToLower()).Split(' ');

                        txtNome.Text = palavras[0] + " " + palavras[palavras.Length - 1];

                        //Numero de identificação fiscal
                        txtNIF.Text = eid.getTaxNo();

                        //Obter Foto
                        PTEID_Photo photoObj = eid.getPhotoObj();
                        PTEID_ByteArray foto = photoObj.getphoto();

                        byte[] byteImg = foto.GetBytes();

                        Image Foto = ConverterBinarioParaImagem(byteImg);

                        pictureBoxFoto.Image = Utilitarios.ClipToCircle(Foto, new PointF(Foto.Width / 2, Foto.Height / 2), Foto.Width / 2);

                        //Morada
                        uint triesLeft = 0;
                        PTEID_Address addr;

                        PTEID_Pins pins = card.getPins();
                        PTEID_Pin pin = pins.getPinByPinRef(PTEID_Pin.ADDR_PIN);

                        if (pin.verifyPin("0000", ref triesLeft, true))
                        {

                            addr = card.getAddr();

                            //Tipo de Rua
                            string tiporua = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(addr.getStreetType().ToLower());

                            //Nome da Rua
                            string rua = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(addr.getStreetName().ToLower());

                            //Porta
                            string Porta = addr.getDoorNo();

                            //Andar
                            string Andar = addr.getFloor();

                            //Lado
                            string lado = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(addr.getSide().ToLower());

                            ////Para os funcionarios
                            txtMorada.Text = tiporua + " " + rua + " " + Porta + " " + Andar + " " + lado;

                            //Localidade
                            txtLocalidade.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(addr.getLocality().ToLower());

                            //Codigo Postal
                            txtCP.Text = addr.getZip4() + "-" + addr.getZip3();

                        }
                        else
                            MessageBox.Show("A sua morada não sofreu alterações porque o pin da morada do seu cartão de cidadão foi alterado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Salvar tudo
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Funcionarios SET Foto = @Foto WHERE(IDFuncionario = @IDFuncionario)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@Foto", byteImg);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        bttGuardar.PerformClick();
                        Desativar();

                    }
                    else
                        MessageBox.Show("Introduza o cartão de cidadão no leitor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttApagarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                string startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Anonimo.jpg";
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                pictureBoxFoto.Image = RoundedImage;
                AtualizarFoto(startupPath, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Validar()
        {
            erros.Clear();

            bool erro = false;

            if (bttPerfil.ForeColor == Color.FromArgb(95, 250, 254))
            {

                //panelDadosGerais
                foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {

                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {
                                case "txtNIF":

                                    if (Validacoes.IsValidContrib(Controlo.Text.Trim()) == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um NIF válido");
                                    }
                                    else
                                    {

                                        //FillByNIFFuncionarios
                                        DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(Controlo.Text.Trim()) + ")");

                                        //Editar
                                        if (Controlo.Text.Trim() != nif.ToString())
                                        {
                                            if (tabelaFuncionarios.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este NIF já pertence a outro funcionário");
                                            }
                                        }        
                                    }

                                    break;

                                case "txtNome":

                                    Match Nome = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                    if (Nome.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o Nome");
                                    }

                                    break;
                            }
                        }
                        else
                        {
                            erro = true;
                            erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                        }
                    }

                //panelMorada
                foreach (GroupBox Controlo2 in panelMorada.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {

                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {

                                case "txtLocalidade":

                                    Match Localidade = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                    if (Localidade.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente a Localidade");
                                    }

                                    break;

                                case "txtCP":

                                    Match CodigoPostal = Regex.Match(Controlo.Text.Trim(), @"^\d{4}-\d{3}?$");

                                    if (CodigoPostal.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o Código Postal");
                                    }

                                    if (Controlo.Text.Length != 8)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o Código Postal");
                                    }

                                    break;
                            }
                        }
                        else
                        {
                            erro = true;
                            erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                        }
                    }


            }
            else
            {
                //panelContactos
                foreach (GroupBox Controlo2 in panelContactos.Controls.OfType<GroupBox>()) foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                    {

                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {
                                case "txtEmail":

                                    if (Validacoes.IsValidEmail(Controlo.Text.Trim(), Controlo) == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um Email valido");
                                    }

                                    break;

                                case "txtContacto":
                                case "txtContactoAlternativo":

                                    Match Telemovel = Regex.Match(Controlo.Text.Trim(), "^[0-9]+$");

                                    if (Controlo.Text.Length != 9)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "O contacto tem de possuir 9 digitos");
                                    }

                                    if (Telemovel.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o contacto");
                                    }

                                    break;
                            }
                        }
                        else
                        {
                            erro = true;
                            erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                        }
                    }
            }

            return erro;

        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {
                    DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                    if (tabelaCargos.Rows.Count == 1)
                    {

                        if (tabelaCargos.Rows[0][1].ToString() == "Administrador" || tabelaCargos.Rows[0][1].ToString() == "Gestor")
                        {
                            //Obter ID do Cargo
                            DataTable tabelaCargos3 = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + cbCargos.Text + "')");
                            IDCargo = int.Parse(tabelaCargos3.Rows[0][0].ToString());
                        }
                        else
                        {
                            //Obter ID do Cargo
                            DataTable tabelaCargos4 = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + txtCargo.Text + "')");
                            IDCargo = int.Parse(tabelaCargos4.Rows[0][0].ToString());
                        }


                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Funcionarios SET Nome = @Nome, NIFFuncionario = @NIFFuncionario WHERE(IDFuncionario = @IDFuncionario)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@NIFFuncionario", int.Parse(txtNIF.Text.Trim()));
                            cmd.Parameters.AddWithValue("@IDCargo", IDCargo);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Moradas SET Morada = @Morada, Localidade = @Localidade, CodigoPostal = @CodigoPostal WHERE(IDMorada = @IDMorada)", con);

                            cmd.Parameters.AddWithValue("@IDMorada", IDMorada);
                            cmd.Parameters.AddWithValue("@Morada", txtMorada.Text.Trim());
                            cmd.Parameters.AddWithValue("@Localidade", txtLocalidade.Text.Trim());
                            cmd.Parameters.AddWithValue("@CodigoPostal", txtCP.Text.Trim());

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Contactos SET Email = @Email, Contacto = @Contacto, ContactoAlternativo = @ContactoAlternativo WHERE(IDContacto = @IDContacto)", con);

                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contacto", int.Parse(txtContacto.Text.Trim()));
                            cmd.Parameters.AddWithValue("@ContactoAlternativo", int.Parse(txtContactoAlternativo.Text.Trim()));

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            DesativarContactos();
                        }

                        Desativar();
                        MessageBox.Show("As informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttAutenticacao_Click(object sender, EventArgs e)
        {
            try
            {

                if (bttAutenticacao.Text == "Cancelar")
                {
                    panelAutenticacao.Visible = false;
                    bttAutenticacao.Text = "Ativar";
                }
                else
                {

                    DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + IDFuncionario + ")");

                    if (tabelaLogins.Rows.Count == 1)
                    {
                        int IDLogin = int.Parse(tabelaLogins.Rows[0][0].ToString());
                        string AccountSecretKey = tabelaLogins.Rows[0][3].ToString();

                        if (bttAutenticacao.Text == "Desativar")
                        {
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Logins SET Status = @Status WHERE(IDLogin = @IDLogin)", con);

                                cmd.Parameters.AddWithValue("@IDLogin", IDLogin);
                                cmd.Parameters.AddWithValue("@Status", 2);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            lblStatus.Text = "Desativada";
                            lblStatus.ForeColor = Color.Red;

                            panelAutenticacao.Visible = false;
                            bttAutenticacao.Text = "Ativar";

                        }
                        else
                        {

                            if (panelAutenticacao.Visible == false)
                            {

                                //METER CODIGO QR
                                DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")");

                                if (tabelaFuncionarios.Rows.Count == 1)
                                {
                                    int IDContacto = int.Parse(tabelaFuncionarios.Rows[0][3].ToString());

                                    DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE(IDContacto = " + IDContacto + ")");

                                    if (tabelaContactos.Rows.Count == 1)
                                    {
                                        string email = tabelaContactos.Rows[0][1].ToString();

                                        TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
                                        var setupInfo = tfa.GenerateSetupCode("Condomix", email, AccountSecretKey, false, 3);

                                        //DAR AO UTILIZADOR

                                        string manualEntrySetupCode = setupInfo.ManualEntryKey;

                                        email = email.Replace("@", "%40");

                                        QRCodeGenerator qrGenerator = new QRCodeGenerator();
                                        QRCodeData qrCodeData = qrGenerator.CreateQrCode("otpauth://totp/" + email + "?secret=" + manualEntrySetupCode + "&issuer=Condomix&algorithm=SHA512&digits=6&period=30", QRCodeGenerator.ECCLevel.H);
                                        QRCode qrCode = new QRCode(qrCodeData);
                                        Bitmap qrCodeImage = qrCode.GetGraphic(50);
                                        pictureBoxAutenticacao.Image = qrCodeImage;
                                        txtCodigo.ResetText();

                                    }
                                }

                                panelAutenticacao.Visible = true;

                                bttAutenticacao.Text = "Cancelar";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
