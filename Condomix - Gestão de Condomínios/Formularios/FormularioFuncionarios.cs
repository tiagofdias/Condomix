using pt.portugal.eid;
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

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioFuncionarios : Form
    {
        int op, nif, idregisto, IDContacto, IDMorada, IDCargo, IDFuncionario, IDCustomizacao;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, Email, Cor;
        OpenFileDialog dlg = new OpenFileDialog() { Filter = "JPG|*.jpg;*.jpeg|PNG|*.png", ValidateNames = true, Multiselect = false };
        byte[] buffer;
        Image FotoFuncionario;

        public FormularioFuncionarios(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;
        }

        public FormularioFuncionarios(int _op, int _nif, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            nif = _nif;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;
        }

        private void bttCC_Click(object sender, EventArgs e)
        {
            try
            {
                bttGuardar.Focus();

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

                        if (op != 1)
                        {
                            if (eid.getTaxNo() != nif.ToString())
                            {
                                if (tabelaFuncionarios.Rows.Count != 0)
                                {
                                    bttGuardar.Focus();
                                    bttFiltrar.Focus();
                                    MessageBox.Show("Este cartão já está associado a outro funcionário", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    CCComplemento();
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

                bttGuardar.Focus();

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

                        //Obter a primeira e ultima palavra do nome
                        string[] palavras = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(eid.getGivenName().ToLower() + " " + eid.getSurname().ToLower()).Split(' ');

                        txtNome.Text = palavras[0] + " " + palavras[palavras.Length - 1];

                        //Numero de identificação fiscal
                        txtNIF.Text = eid.getTaxNo();

                        //Obter Foto
                        PTEID_Photo photoObj = eid.getPhotoObj();
                        PTEID_ByteArray foto = photoObj.getphoto();

                        buffer = foto.GetBytes();

                        Image Foto = Utilitarios.ConverterBinarioParaImagem(buffer);

                        dlg.FileName = System.IO.Directory.GetCurrentDirectory() + @"\CC.jpg";

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

        private void bttAtualizarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //Browse
                string FotoInicial = dlg.FileName;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = File.OpenRead(dlg.FileName))
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);

                        string extn = new FileInfo(dlg.FileName).Extension;
                        double fileSizeMB = stream.Length / (1024 * 1024);

                        if (fileSizeMB == 0)
                        {
                            //Apresentar Imagem Circular
                            Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(dlg.FileName), new PointF(Image.FromFile(dlg.FileName).Width / 2, Image.FromFile(dlg.FileName).Height / 2), Image.FromFile(dlg.FileName).Width / 2);
                            pictureBoxFoto.Image = RoundedImage;
                        }
                        else
                        {
                            MessageBox.Show("Só são permitidos ficheiros com um tamanho máximo de 1 MB", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dlg.FileName = FotoInicial;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttVoltarVisualizar_Click(object sender, EventArgs e)
        {
            try
            {

                panelDesktop.Visible = false;
                panelVisualizar.Visible = false;
                panelVisualiza.Visible = false;

                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Funcionarios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                panelDesktop.Visible = false;
                panelVisualizar.Visible = false;

                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Funcionarios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
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
                dlg.FileName = startupPath;
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                pictureBoxFoto.Image = RoundedImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttReporPass_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Tem a certeza que deseja repor a password deste funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string password = Utilitarios.GerarStringAleatoria(6, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                    string senha = Crypto.sha256encrypt(password);

                    DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE (IDFuncionario = " + idregisto + ")");

                    int IDContacto = int.Parse(tabelaFuncionarios.Rows[0][3].ToString());
                    string NomeFuncionario = tabelaFuncionarios.Rows[0][6].ToString();

                    DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE (IDContacto = " + IDContacto + ")");

                    string email = tabelaContactos.Rows[0][1].ToString();

                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Logins SET Password = @Password, Status = @Status WHERE(IDFuncionario = @IDFuncionario)", con);

                        cmd.Parameters.AddWithValue("@IDFuncionario", idregisto);
                        cmd.Parameters.AddWithValue("@Password", senha);
                        cmd.Parameters.AddWithValue("@Status", 4);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    Utilitarios.EnviarEmail("Moviarcas@gmail.com", "wzcbnwlrjdplxotp", email, NomeFuncionario, password, "RecuperarConta.txt");

                    MessageBox.Show("Reposição concluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void bttFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {
                    query2 = string.Empty;

                    foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    {
                        foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                        {
                            foreach (Control Controlo in ControloGroupBoxs.Controls)
                            {
                                if (Controlo is TextBox || Controlo is ComboBox)
                                {
                                    if (Controlo.Text.Trim() != string.Empty)
                                    {
                                        string query = string.Empty;

                                        switch (Controlo.Name)
                                        {

                                            case "txtNIF":
                                                query = "Funcionarios.NIFFuncionario";
                                                break;

                                            case "txtNome":
                                                query = "Funcionarios.Nome";
                                                break;

                                            case "cbCargos":
                                                query = "Cargos.Cargo";
                                                break;

                                            case "txtEmail":
                                                query = "Contactos.Email";
                                                break;

                                            case "txtContacto":
                                                query = "Contactos.Contacto";
                                                break;

                                            case "txtContactoAlternativo":
                                                query = "Contactos.ContactoAlternativo";
                                                break;

                                            case "txtMorada":
                                                query = "Moradas.Morada";
                                                break;

                                            case "txtLocalidade":
                                                query = "Moradas.Localidade";
                                                break;

                                            case "txtCP":
                                                query = "Moradas.CodigoPostal";
                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }
                            }
                        }
                    }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Funcionarios", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme)
                {
                    foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelContactos.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelMorada.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);

                }

                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                IPBEmail.IconColor = Customizar.HexToColor(Cor);
                IPBMorada.IconColor = Customizar.HexToColor(Cor);
                IPBTelefone.IconColor = Customizar.HexToColor(Cor);
                lbNome.ForeColor = Customizar.HexToColor(Cor);

                // Carrega os cargos para a COMBOBOX
                DataTable dt = Utilitarios.FillBy("SELECT IDCargo, Cargo FROM Cargos");
                foreach (DataRow row in dt.Rows) cbCargos.Items.Add(row["Cargo"].ToString());

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                {
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }
                    }
                }

                cbCargos.SelectedIndex = -1;
                lblFoto.Visible = true;
                panelFoto.Visible = true;
                bttVoltar.Location = new Point(1057, 399);
                lblContactos.Location = new Point(716, 211);
                panelContactos.Location = new Point(720, 240);

                lblDescFoto.Visible = true;
                bttAtualizarFoto.Visible = true;
                bttApagarFoto.Visible = true;
                bttApagarFoto.IconColor = Customizar.HexToColor(Cor);
                bttReporPass.Visible = false;
                bttCC.Visible = true;
                bttCC.IconColor = Customizar.HexToColor(Cor);
                txtCargo.Visible = false;
                cbCargos.Visible = true;
                erros.Clear();

                string startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Anonimo.jpg";
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                pictureBoxFoto.Image = RoundedImage;

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Funcionário";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();
                        bttApagarFoto.PerformClick();
                        panelDesktop.Visible = true;
                        panelVisualizar.Visible = false;

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Funcionários";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        lblFoto.Visible = false;
                        panelFoto.Visible = false;
                        bttFiltrar.Focus();

                        lblContactos.Location = new Point(10, 404);
                        panelContactos.Location = new Point(14, 433);
                        bttVoltar.Location = new Point(354, 592);
                        bttFiltrar.Location = new Point(527, 592);
                        panelDesktop.Visible = true;
                        panelVisualizar.Visible = false;

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Funcionário";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttReporPass.Visible = true;
                        bttGuardar.Focus();
                        dlg.FileName = string.Empty;
                        panelDesktop.Visible = true;
                        panelVisualizar.Visible = false;

                        break;

                    //Visualizar
                    case 3:

                        panelDesktop.Visible = false;
                        panelVisualiza.Visible = true;
                        panelVisualizar.Visible = true;

                        lblTitleChildForm.Text = "Visualizar Funcionário";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                        {
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            {
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                                {
                                    Controlo.ReadOnly = true;
                                }
                            }
                        }

                        Editar_Visualizar(3);

                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        bttCC.Visible = false;
                        bttVoltar.Location = new Point(1233, 399);
                        bttVoltar.Focus();
                        lblDescFoto.Visible = false;
                        bttAtualizarFoto.Visible = false;
                        bttApagarFoto.Visible = false;

                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Editar_Visualizar(int chegueide)
        {
            try
            {
                DataTable tabelaFuncionario = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE (NIFFuncionario = " + nif + ")");

                if (tabelaFuncionario.Rows.Count == 1)
                {

                    idregisto = int.Parse(tabelaFuncionario.Rows[0][0].ToString());
                    txtNIF.Text = tabelaFuncionario.Rows[0][1].ToString();
                    nif = int.Parse(tabelaFuncionario.Rows[0][1].ToString());
                    IDCargo = int.Parse(tabelaFuncionario.Rows[0][2].ToString());
                    IDContacto = int.Parse(tabelaFuncionario.Rows[0][3].ToString());
                    IDMorada = int.Parse(tabelaFuncionario.Rows[0][4].ToString());
                    txtNome.Text = tabelaFuncionario.Rows[0][6].ToString();

                    if (chegueide == 3)
                    {
                        lbNome.Text = tabelaFuncionario.Rows[0][6].ToString();
                        //lbNIF.Text = tabelaFuncionario.Rows[0][1].ToString();

                    }

                        //FOTO
                        pictureBoxFoto.Image = Utilitarios.ObterFoto("SELECT * FROM Funcionarios WHERE (NIFFuncionario = " + nif + ")");
                        PBFoto.Image = pictureBoxFoto.Image;
                    

                    DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                    if (tabelaCargos.Rows.Count == 1)
                    {
                        if (chegueide == 2)
                        {
                            txtCargo.Visible = false;
                            cbCargos.Visible = true;
                            cbCargos.Text = tabelaCargos.Rows[0][1].ToString();

                        }
                        else
                        {
                            txtCargo.Visible = true;
                            cbCargos.Visible = false;
                            txtCargo.Text = tabelaCargos.Rows[0][1].ToString();
                            lbCargo.Text = tabelaCargos.Rows[0][1].ToString(); ;
                        }

                        DataTable tabelaMorada = Utilitarios.FillBy("SELECT * FROM Moradas WHERE(IDMorada = " + IDMorada + ")");

                        if (tabelaMorada.Rows.Count == 1)
                        {
                            if (chegueide == 2)
                            {
                                txtMorada.Text = tabelaMorada.Rows[0][1].ToString();
                                txtLocalidade.Text = tabelaMorada.Rows[0][2].ToString();
                                txtCP.Text = tabelaMorada.Rows[0][3].ToString();
                            }
                            else
                            {
                                lbMorada.Text = tabelaMorada.Rows[0][1].ToString();
                                lbMorada2.Text = tabelaMorada.Rows[0][3].ToString() + " " + tabelaMorada.Rows[0][2].ToString();
                            }

                            DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE(IDContacto = " + IDContacto + ")");

                            if (tabelaContactos.Rows.Count == 1)
                            {
                                if (chegueide == 2)
                                {
                                    txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                                    Email = tabelaContactos.Rows[0][1].ToString();
                                    txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                                    txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();
                                }
                                else
                                {
                                    lbEmail.Text = tabelaContactos.Rows[0][1].ToString();
                                    lbTelemovel.Text = tabelaContactos.Rows[0][2].ToString();
                                    lbTelefone.Text = tabelaContactos.Rows[0][3].ToString();
                                }

                                DataTable tabelaLogins = Utilitarios.FillBy("SELECT * FROM Logins WHERE(IDFuncionario = " + idregisto + ")");

                                if (tabelaLogins.Rows.Count == 1)
                                {
                                    int Status = int.Parse(tabelaLogins.Rows[0][4].ToString());
                                }
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

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public bool Validar()
        {
            erros.Clear();

            bool erro = false;

            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>()) foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox)
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
                                        if (op != 1)
                                        {
                                            //FillByNIFFuncionarios
                                            DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(Controlo.Text.Trim()) + ")");

                                            //Inserir
                                            if (tabelaFuncionarios.Rows.Count != 0 && op == 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este NIF já pertence a outro funcionário");
                                            }

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

                                case "cbCargos":

                                    if (Controlo.Text.Trim() == string.Empty)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza o Cargo do funcionário");
                                    }

                                    break;
                            }
                        }
                        else
                        {
                            if (Controlo.Name != "txtCargo" && op != 1)
                            {
                                erro = true;
                                erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                            }
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
                        if (op != 1)
                        {
                            erro = true;
                            erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                        }
                    }
                }


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
                                else
                                {
                                    if (op != 1)
                                    {
                                        //FillByEmail
                                        DataTable tabelaContactos = Utilitarios.FillBy("SELECT * FROM Contactos WHERE(Email = '" + Controlo.Text.Trim() + "')");

                                        //Inserir
                                        if (tabelaContactos.Rows.Count != 0 && op == 0)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Este Email já pertence a outro funcionário");
                                        }

                                        //Editar
                                        if (op == 2 && Controlo.Text.Trim() != Email.ToString())
                                        {
                                            if (tabelaContactos.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este Email já pertence a outro funcionário");
                                            }
                                        }
                                    }
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
                        if (op != 1)
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

                    if (op == 0)
                    {

                        if (dlg.FileName != System.IO.Directory.GetCurrentDirectory() + @"\CC.jpg")
                        {
                            using (Stream stream = File.OpenRead(dlg.FileName))
                            {
                                buffer = new byte[stream.Length];
                                stream.Read(buffer, 0, buffer.Length);

                                string extn = new FileInfo(dlg.FileName).Extension;
                            }
                        }

                        //Contactos
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Contactos(Email, Contacto, ContactoAlternativo) VALUES(@Email, @Contacto, @ContactoAlternativo)", con);

                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contacto", int.Parse(txtContacto.Text.Trim()));
                            cmd.Parameters.AddWithValue("@ContactoAlternativo", int.Parse(txtContactoAlternativo.Text.Trim()));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        //Obter ID do contacto
                        DataTable tabelaContacto = Utilitarios.FillBy("SELECT * FROM Contactos ORDER BY IDContacto DESC");

                        IDContacto = int.Parse(tabelaContacto.Rows[0][0].ToString());

                        //Morada
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Moradas (Morada, Localidade, CodigoPostal) VALUES(@Morada, @Localidade, @CodigoPostal)", con);

                            cmd.Parameters.AddWithValue("@Morada", txtMorada.Text.Trim());
                            cmd.Parameters.AddWithValue("@Localidade", txtLocalidade.Text.Trim());
                            cmd.Parameters.AddWithValue("@CodigoPostal", txtCP.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        //Obter ID da Morada
                        DataTable tabelaMorada = Utilitarios.FillBy("SELECT * FROM Moradas ORDER BY IDMorada DESC");

                        IDMorada = int.Parse(tabelaMorada.Rows[0][0].ToString());

                        //Cutomizacao
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Customizacao (Cor) VALUES(@Cor)", con);

                            cmd.Parameters.AddWithValue("@Cor", "#5FFAFE");
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        //Obter ID da Customizacao
                        DataTable tabelaCustomizacao = Utilitarios.FillBy("SELECT * FROM Customizacao ORDER BY IDCustomizacao DESC");

                        IDCustomizacao = int.Parse(tabelaCustomizacao.Rows[0][0].ToString());

                        //Obter ID do Cargo
                        DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + cbCargos.Text + "')");

                        IDCargo = int.Parse(tabelaCargos.Rows[0][0].ToString());

                        //Funcionarios
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Funcionarios (NIFFuncionario, IDCargo, IDContacto, IDMorada, IDCustomizacao, Nome, Foto) VALUES(@NIFFuncionario, @IDCargo, @IDContacto, @IDMorada, @IDCustomizacao, @Nome, @Foto)", con);

                            cmd.Parameters.AddWithValue("@NIFFuncionario", int.Parse(txtNIF.Text.Trim()));
                            cmd.Parameters.AddWithValue("@IDCargo", IDCargo);
                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@IDMorada", IDMorada);
                            cmd.Parameters.AddWithValue("@IDCustomizacao", IDCustomizacao);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@Foto", buffer);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        //Obter ID do funcionário
                        DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios ORDER BY IDFuncionario DESC");

                        int IDFuncionario = int.Parse(tabelaFuncionarios.Rows[0][0].ToString());

                        string password = Utilitarios.GerarStringAleatoria(6, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                        string senha = Crypto.sha256encrypt(password);
                        string AccountSecretKey = Utilitarios.GerarStringAleatoria(10, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");

                        //Login
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Logins (IDFuncionario, Password, AccountSecretKey, Status) VALUES(@IDFuncionario, @Password, @AccountSecretKey, @Status)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@Password", senha);
                            cmd.Parameters.AddWithValue("@AccountSecretKey", AccountSecretKey);
                            cmd.Parameters.AddWithValue("@Status", 4);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        Utilitarios.EnviarEmail("Moviarcas@gmail.com", "wzcbnwlrjdplxotp", txtEmail.Text.Trim(), txtNome.Text.Trim(), password, "NovoFuncionario.txt");

                        MessageBox.Show("Cliente adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        if (dlg.FileName != string.Empty)
                        {

                            if (dlg.FileName != System.IO.Directory.GetCurrentDirectory() + @"\CC.jpg")
                            {
                                using (Stream stream = File.OpenRead(dlg.FileName))
                                {
                                    buffer = new byte[stream.Length];
                                    stream.Read(buffer, 0, buffer.Length);

                                    string extn = new FileInfo(dlg.FileName).Extension;
                                }
                            }

                            //Obter ID do Cargo
                            DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + cbCargos.Text + "')");

                            IDCargo = int.Parse(tabelaCargos.Rows[0][0].ToString());

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Funcionarios SET IDCargo = @IDCargo, Nome = @Nome, Foto = @Foto, NIFFuncionario = @NIFFuncionario WHERE(IDFuncionario = @IDFuncionario)", con);

                                cmd.Parameters.AddWithValue("@IDFuncionario", idregisto);
                                cmd.Parameters.AddWithValue("@IDCargo", IDCargo);
                                cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                                cmd.Parameters.AddWithValue("@Foto", buffer);
                                cmd.Parameters.AddWithValue("@NIFFuncionario", int.Parse(txtNIF.Text.Trim()));

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }

                        }
                        else
                        {
                            //Obter ID do Cargo
                            DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + cbCargos.Text + "')");

                            IDCargo = int.Parse(tabelaCargos.Rows[0][0].ToString());

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Funcionarios SET IDCargo = @IDCargo, Nome = @Nome, NIFFuncionario = @NIFFuncionario WHERE(IDFuncionario = @IDFuncionario)", con);

                                cmd.Parameters.AddWithValue("@IDFuncionario", idregisto);
                                cmd.Parameters.AddWithValue("@IDCargo", IDCargo);
                                cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                                cmd.Parameters.AddWithValue("@NIFFuncionario", int.Parse(txtNIF.Text.Trim()));

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
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
                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Funcionarios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
