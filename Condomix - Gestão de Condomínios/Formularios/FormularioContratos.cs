using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioContratos : Form
    {

        int op, idregisto, IDDocumento, IDFornecedor, IDFuncionario;
        string query2 = string.Empty, NomeFuncionario, CargoFuncionario, Cor;
        Image FotoFuncionario;
        OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true, Multiselect = false };

        public FormularioContratos(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioContratos(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor=_Cor;
        }

        private void dtpDataInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDataFim.MinDate = dtpDataInicio.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDataRescisao_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                dtpDataRescisao.MinDate = dtpDataInicio.Value;
                this.Select();

                SendKeys.Send("%{DOWN}");
                dtpDataRescisao.CustomFormat = "dd/MM/yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDataFim_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                dtpDataFim.MinDate = dtpDataInicio.Value;
                this.Select();

                SendKeys.Send("%{DOWN}");
                dtpDataFim.CustomFormat = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDataInicio_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.Select();

                dtpDataInicio.MinDate = DateTime.Today;
                dtpDataRescisao.MinDate = DateTime.Today;
                dtpDataFim.MinDate = dtpDataInicio.Value;

                SendKeys.Send("%{DOWN}");
                dtpDataInicio.CustomFormat = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbContratoSemTermo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbContratoSemTermo.SelectedIndex == 0)
                {
                    GBDataFim.Visible = true;
                    dtpDataFim.Visible = true;
                }
                else
                {
                    GBDataFim.Visible = false;
                    dtpDataFim.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbContratoRescindido_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbContratoRescindido.SelectedIndex == 0)
                {
                    GBDataRescisao.Visible = true;
                    dtpDataRescisao.Visible = true;
                }
                else
                {
                    GBDataRescisao.Visible = false;
                    dtpDataRescisao.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {
                    if (op == 0)
                    {

                        //Documentos
                        Utilitarios.SaveFile(dlg.FileName, op);

                        DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos ORDER BY IDDocumento DESC");
                        IDDocumento = int.Parse(tabelaDocumentos.Rows[0][0].ToString());

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Fornecedores WHERE (Nome = '" + cbFornecedor.Text + "')");
                        IDFornecedor = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Pagamentos
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Contratos (IDFornecedor, IDFuncionario, IDDocumento, Titulo, Descritivo, DataInicio, DataFim, Valor, ContratoSemTermo, ContratoRescindido, DataRescisao) " +
                                " VALUES(@IDFornecedor, @IDFuncionario, @IDDocumento, @Titulo, @Descritivo, @DataInicio, @DataFim, @Valor, @ContratoSemTermo, @ContratoRescindido, @DataRescisao)", con);

                            cmd.Parameters.AddWithValue("@IDFornecedor", IDFornecedor);
                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataInicio", DateTime.ParseExact(dtpDataInicio.Text.Trim(), "dd/MM/yyyy", null));

                            if (dtpDataFim.Text.Trim() != string.Empty)
                                cmd.Parameters.AddWithValue("@DataFim", DateTime.ParseExact(dtpDataFim.Text.Trim(), "dd/MM/yyyy", null));
                            else
                                cmd.Parameters.AddWithValue("@DataFim", "");

                            cmd.Parameters.AddWithValue("@Valor", decimal.Parse(txtValor.Text.Trim()));

                            if (cbContratoSemTermo.Text == "Sim")
                                cmd.Parameters.AddWithValue("@ContratoSemTermo", true);
                            else
                                cmd.Parameters.AddWithValue("@ContratoSemTermo", false);

                            if (cbContratoRescindido.Text == "Sim")
                                cmd.Parameters.AddWithValue("@ContratoRescindido", true);
                            else
                                cmd.Parameters.AddWithValue("@ContratoRescindido", false);

                            if (dtpDataRescisao.Text.Trim() != string.Empty)
                                cmd.Parameters.AddWithValue("@DataRescisao", DateTime.ParseExact(dtpDataRescisao.Text.Trim(), "dd/MM/yyyy", null));
                            else
                                cmd.Parameters.AddWithValue("@DataRescisao", "");

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Contrato adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos ORDER BY IDDocumento DESC");
                        IDDocumento = int.Parse(tabelaDocumentos.Rows[0][0].ToString());

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Fornecedores WHERE (Nome = '" + cbFornecedor.Text + "')");
                        IDFornecedor = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Documentos
                        if (dlg.FileName != string.Empty)
                            Utilitarios.SaveFile(dlg.FileName, op, IDDocumento);

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Contratos SET IDFornecedor = @IDFornecedor, IDFuncionario = @IDFuncionario, IDDocumento = @IDDocumento, Titulo = @Titulo," +
                                "Descritivo = @Descritivo, DataInicio = @DataInicio, DataFim = @DataFim, Valor = @Valor, ContratoSemTermo = @ContratoSemTermo, ContratoRescindido = @ContratoRescindido, DataRescisao = @DataRescisao WHERE(IDContrato = @IDContrato)", con);

                            cmd.Parameters.AddWithValue("@IDContrato", idregisto);
                            cmd.Parameters.AddWithValue("@IDFornecedor", IDFornecedor);
                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataInicio", DateTime.ParseExact(dtpDataInicio.Text.Trim(), "dd/MM/yyyy", null));

                            if (dtpDataFim.Text.Trim() != string.Empty)
                                cmd.Parameters.AddWithValue("@DataFim", DateTime.ParseExact(dtpDataFim.Text.Trim(), "dd/MM/yyyy", null));
                            else
                                cmd.Parameters.AddWithValue("@DataFim", "");

                            cmd.Parameters.AddWithValue("@Valor", decimal.Parse(txtValor.Text.Trim()));

                            if (cbContratoSemTermo.Text == "Sim")
                                cmd.Parameters.AddWithValue("@ContratoSemTermo", true);
                            else
                                cmd.Parameters.AddWithValue("@ContratoSemTermo", false);

                            if (cbContratoRescindido.Text == "Sim")
                                cmd.Parameters.AddWithValue("@ContratoRescindido", true);
                            else
                                cmd.Parameters.AddWithValue("@ContratoRescindido", false);

                            if (dtpDataRescisao.Text.Trim() != string.Empty)
                                cmd.Parameters.AddWithValue("@DataRescisao", DateTime.ParseExact(dtpDataRescisao.Text.Trim(), "dd/MM/yyyy", null));
                            else
                                cmd.Parameters.AddWithValue("@DataRescisao", "");

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                        bttGuardar.Focus();
                        MessageBox.Show("O contrato foi atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Contratos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);

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
                        foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            foreach (Control Controlo in ControloGroupBoxs.Controls)
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox || Controlo is MyDateTimePicker || Controlo is NormalDateTimePicker)
                                {
                                    if (Controlo.Text.Trim() != string.Empty && Controlo.Name != "txtFracao")
                                    {
                                        string query = string.Empty;

                                        switch (Controlo.Name)
                                        {

                                            case "cbFornecedor":

                                                query = "Fornecedores.Nome";
                                                break;

                                            case "txtTitulo":
                                                query = "Contratos.Titulo";
                                                break;

                                            case "txtDescritivo":
                                                query = "Contratos.Descritivo";
                                                break;

                                            case "dtpDataInicio":
                                                dtpDataInicio.CustomFormat = "MM/dd/yyyy";
                                                query = "Contratos.DataInicio";
                                                break;

                                            case "dtpDataFim":
                                                dtpDataFim.CustomFormat = "MM/dd/yyyy";
                                                query = "Contratos.DataFim";
                                                break;

                                            case "txtValor":
                                                if (Controlo.Text.ToLower().Contains(',')) Controlo.Text = Controlo.Text.Replace(',', '.');
                                                query = "Contratos.Valor";
                                                break;

                                            case "dtpDataRescisao":
                                                dtpDataRescisao.CustomFormat = "MM/dd/yyyy";
                                                query = "Contratos.DataRescisao";
                                                break;

                                            case "cbContratoSemTermo":

                                                if (cbContratoSemTermo.Text == "Sim")
                                                {
                                                    cbContratoSemTermo.Items.Clear();
                                                    cbContratoSemTermo.Items.Add(true);
                                                    cbContratoSemTermo.SelectedIndex = 0;
                                                }
                                                else
                                                {
                                                    cbContratoSemTermo.Items.Clear();
                                                    cbContratoSemTermo.Items.Add(false);
                                                    cbContratoSemTermo.SelectedIndex = 0;
                                                }

                                                query = "Contratos.ContratoSemTermo";
                                                break;


                                            case "cbContratoRescindido":

                                                if (cbContratoRescindido.Text == "Sim")
                                                {
                                                    cbContratoRescindido.Items.Clear();
                                                    cbContratoRescindido.Items.Add(true);
                                                    cbContratoRescindido.SelectedIndex = 0;
                                                }
                                                else
                                                {
                                                    cbContratoRescindido.Items.Clear();
                                                    cbContratoRescindido.Items.Add(false);
                                                    cbContratoRescindido.SelectedIndex = 0;
                                                }

                                                query = "Contratos.ContratoRescindido";
                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Contratos", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }
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

            if (bttAdicionarDocumento.Text.Trim() == "Adicionar" && op == 0)
            {
                erro = true;
                erros.SetError(txtDocumento, "Adicione o contrato");
            }

            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>())
                foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox || Controlo is NormalDateTimePicker || Controlo is Button)
                    {
                        if (Controlo.Visible == true)
                            if (Controlo.Text.Trim() != string.Empty)
                            {
                                switch (Controlo.Name)
                                {

                                    case "txtValor":

                                        Match Numeros = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");
                                       
                                        if (Numeros.Success == false)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Introduza corretamente o valor");
                                        }

                                        break;

                                    case "txtTitulo":

                                        Match Nome = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                        if (Nome.Success == false && op == 1)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Introduza um título válido");
                                        }

                                        break;

                                    case "txtDescritivo":

                                        Match Nome3 = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ., ]+$");

                                        if (Nome3.Success == false && op == 1)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Introduza um Descritivo válido");
                                        }

                                        break;
                                }
                            }
                            else
                            {
                                if (Controlo.Name != "txtFornecedor" && Controlo.Name != "txtContratoRescindido" && Controlo.Name != "txtContratoSemTermo" && Controlo.Name != "txtDocumento" && op != 1)
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                                }
                            }
                    }

            return erro;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttAdicionarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                //Browse

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = File.OpenRead(dlg.FileName))
                    {

                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);

                        string extn = new FileInfo(dlg.FileName).Extension;

                        if (extn == ".pdf")
                        {
                            string name = new FileInfo(dlg.FileName).Name.Remove(new FileInfo(dlg.FileName).Name.Length - 4);

                            lblDocumento.Text = "Documento - " + name;
                            bttAdicionarDocumento.Text = "Alterar";
                        }
                        else
                            MessageBox.Show("Só são permitidos ficheiros do tipo PDF");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttAbrirDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitarios.OpenFile(IDDocumento);
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
                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Contratos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioContratos_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);


                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                //Carrega os Fornecedores para a COMBOBOX
                DataTable dt = Utilitarios.FillBy("SELECT IDFornecedor, Nome FROM Fornecedores");
                foreach (DataRow row in dt.Rows) cbFornecedor.Items.Add(row["Nome"].ToString());

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }

                        foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }

                        foreach (MyDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<MyDateTimePicker>()) Controlo.Enabled = true;
                        foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = true;
                    }

                dtpDataRescisao.Visible = false;
                dtpDataFim.Visible = false;
                cbContratoSemTermo.SelectedIndex = -1;
                cbContratoRescindido.SelectedIndex = -1;

                txtContratoRescindido.Visible = false;
                cbContratoRescindido.Visible = true;

                txtContratoSemTermo.Visible = false;
                cbContratoSemTermo.Visible = true;

                erros.Clear();
                bttVoltar.Location = new Point(354, 555);
                bttAbrirDocumento.Visible = false;
                bttAdicionarDocumento.Visible = true;
                bttAdicionarDocumento.Text = "Adicionar";
                panelDadosGerais.Height = 495;

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Contrato";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        dtpDataInicio.CustomFormat = " ";
                        dtpDataFim.CustomFormat = " ";
                        dtpDataRescisao.CustomFormat = " ";
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Contratos";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttAdicionarDocumento.Visible = false;
                        bttAbrirDocumento.Visible = false;
                        lblDocumento.Visible = false;
                        panelDadosGerais.Height = 415;
                        bttVoltar.Location = new Point(354, 474);
                        bttFiltrar.Location = new Point(527, 474);
                        dtpDataInicio.CustomFormat = " ";
                        dtpDataFim.CustomFormat = " ";
                        dtpDataRescisao.CustomFormat = " ";
                        GBDataRescisao.Visible = true;
                        dtpDataRescisao.Visible = true;
                        GBDataFim.Visible = true;
                        dtpDataFim.Visible = true;
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Contrato";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();
                        bttAdicionarDocumento.Text = "Alterar";

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Contrato";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            {
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;
                                foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>()) Controlo.ReadOnly = true;
                                foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = false;
                            }

                        Editar_Visualizar(3);

                        bttAbrirDocumento.Visible = true;
                        bttAdicionarDocumento.Visible = false;
                        bttVoltar.Location = new Point(527, 555);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        bttVoltar.Focus();

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
                DataTable tabelaContratos = Utilitarios.FillBy("SELECT * FROM Contratos WHERE (IDContrato = " + idregisto + ")");

                if (tabelaContratos.Rows.Count == 1)
                {

                    IDFornecedor = int.Parse(tabelaContratos.Rows[0][1].ToString());
                    IDDocumento = int.Parse(tabelaContratos.Rows[0][3].ToString());
                    txtTitulo.Text = tabelaContratos.Rows[0][4].ToString();
                    txtDescritivo.Text = tabelaContratos.Rows[0][5].ToString();
                    dtpDataInicio.Text = tabelaContratos.Rows[0][6].ToString();
                    decimal Valor = decimal.Parse(tabelaContratos.Rows[0][8].ToString());

                    if (tabelaContratos.Rows[0][7].ToString() == "01/01/1900 00:00:00")
                        dtpDataFim.CustomFormat = " ";
                    else
                        dtpDataFim.Text = tabelaContratos.Rows[0][7].ToString();

                    if (tabelaContratos.Rows[0][11].ToString() == "01/01/1900 00:00:00")
                        dtpDataRescisao.CustomFormat = " ";
                    else
                        dtpDataRescisao.Text = tabelaContratos.Rows[0][11].ToString();

                    //Editar
                    if (chegueide == 2)
                    {
                        txtValor.Text = Valor.ToString();

                        txtFornecedor.Visible = false;
                        cbFornecedor.Visible = true;

                        txtContratoSemTermo.Visible = false;
                        cbContratoSemTermo.Visible = true;

                        txtContratoRescindido.Visible = false;
                        cbContratoRescindido.Visible = true;

                        if (tabelaContratos.Rows[0][9].ToString() == "True")
                        {
                            cbContratoSemTermo.SelectedIndex = 0;
                            GBDataFim.Visible = true;
                            dtpDataFim.Visible = true;
                        }
                        else
                        {
                            dtpDataFim.Visible = false;
                            GBDataFim.Visible = false;
                            cbContratoSemTermo.SelectedIndex = 1;
                        }

                        if (tabelaContratos.Rows[0][10].ToString() == "True")
                        {
                            dtpDataRescisao.Visible = true;
                            GBDataRescisao.Visible = true;
                            cbContratoRescindido.SelectedIndex = 0;
                        }
                        else
                        {
                            dtpDataRescisao.Visible = false;
                            GBDataRescisao.Visible = false;
                            cbContratoRescindido.SelectedIndex = 1;
                        }

                    }
                    //Visualizar
                    else
                    {
                        txtValor.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2} €", Valor.ToString());

                        txtFornecedor.Visible = true;
                        cbFornecedor.Visible = false;

                        txtContratoSemTermo.Visible = true;
                        cbContratoSemTermo.Visible = false;

                        txtContratoRescindido.Visible = true;
                        cbContratoRescindido.Visible = false;

                        if (tabelaContratos.Rows[0][9].ToString() == "True")
                        {
                            txtContratoSemTermo.Text = "Sim";
                            GBDataFim.Visible = true;
                            dtpDataFim.Visible = true;
                        }
                        else
                        {
                            GBDataFim.Visible = false;
                            dtpDataFim.Visible = false;
                            txtContratoSemTermo.Text = "Não";
                        }

                        if (tabelaContratos.Rows[0][10].ToString() == "True")
                        {
                            GBDataRescisao.Visible = true;
                            dtpDataRescisao.Visible = true;
                            txtContratoRescindido.Text = "Sim";
                        }
                        else
                        {
                            GBDataRescisao.Visible = false;
                            dtpDataRescisao.Visible = false;
                            txtContratoRescindido.Text = "Não";
                        }

                    }

                    //Documentos
                    DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos WHERE(IDDocumento = " + IDDocumento + ")");

                    if (tabelaDocumentos.Rows.Count == 1)
                        lblDocumento.Text = "Documento - " + tabelaDocumentos.Rows[0][3].ToString();

                    DataTable tabelaFornecedores = Utilitarios.FillBy("SELECT * FROM Fornecedores WHERE(IDFornecedor = " + IDFornecedor + ")");

                    if (tabelaFornecedores.Rows.Count == 1)
                    {
                        txtFornecedor.Text = tabelaFornecedores.Rows[0][3].ToString();
                        cbFornecedor.Text = tabelaFornecedores.Rows[0][3].ToString();
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
