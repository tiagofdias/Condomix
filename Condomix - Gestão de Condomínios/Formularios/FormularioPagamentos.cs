using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioPagamentos : Form
    {
        int op, idregisto, IDCondominio, IDFracao, IDFuncionario, IDDocumento;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, Cor;
        Image FotoFuncionario;
        OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true, Multiselect = false };

        public FormularioPagamentos(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioPagamentos(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;
        }

        private void dtpPeriodoQuota_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.Select();

                SendKeys.Send("%{DOWN}");

                dtpPeriodoQuota.CustomFormat = "MMMM yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i = 0;
        private void cbCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbFracao.Visible = false;
                cbFracao.Items.Clear();

                if (i != 0 && op == 2)
                {
                    txtFracao.Visible = false;
                    txtFracao.ResetText();
                }

                if (op == 0)
                    txtFracao.ResetText();

                if (cbCondominio.Text != string.Empty)
                {
                    DataTable tabelaCondominio = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = '" + "Condomínio " + cbCondominio.Text + "')");

                    if (tabelaCondominio.Rows.Count == 1)
                    {
                        int IDCondominio = int.Parse(tabelaCondominio.Rows[0][0].ToString());
                        int Ano = Convert.ToDateTime(tabelaCondominio.Rows[0][14].ToString()).Year;
                        int Mes = Convert.ToDateTime(tabelaCondominio.Rows[0][14].ToString()).Month;
                        DateTime Data = DateTime.Parse("01/" + Mes + "/" + Ano);
                        dtpPeriodoQuota.MinDate = Data;

                        // Carrega os Condomínios para a COMBOBOX
                        DataTable dt = Utilitarios.FillBy("SELECT IDFracao, IDCondominio, NomeFracao FROM Fracoes WHERE IDCondominio = " + IDCondominio + " ORDER BY NomeFracao ");

                        foreach (DataRow row in dt.Rows) cbFracao.Items.Add(row["NomeFracao"].ToString().Substring(row["NomeFracao"].ToString().IndexOf(" ") + 1));

                        if (cbFracao.Items.Count != 0)
                        {
                            cbFracao.Visible = true;
                            dtpPeriodoQuota.Visible = true;
                        }
                           
                    }
                }

                if (op == 2) i++;

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

        private void txtFracao_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == 2)
                {
                    cbFracao.Select();
                    SendKeys.Send("%{DOWN}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtFracao.Text = cbFracao.Text;
                txtFracao.Visible = false;
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

                                            case "cbCondominio":

                                                string nome = Controlo.Text.Trim();
                                                cbCondominio.Items.Clear();
                                                cbCondominio.Items.Add("Condomínio " + nome);
                                                cbCondominio.SelectedIndex = 0;

                                                query = "Condominios.Nome";
                                                break;

                                            case "cbFracao":

                                                query = "Fracoes.NomeFracao";
                                                break;

                                            case "cbTipoPagamento":
                                                query = "Pagamentos.TipoPagamento";
                                                break;


                                            case "dtpPeriodoQuota":
                                                query = "Pagamentos.PeriodoQuota";
                                                break;

                                            case "txtDescricao":
                                                query = "Pagamentos.Descricao";
                                                break;

                                            case "txtValor":
                                                if (Controlo.Text.ToLower().Contains(',')) Controlo.Text = Controlo.Text.Replace(',', '.');
                                                query = "Pagamentos.Valor";
                                                break;

                                            case "dtpDataPagamento":
                                                dtpDataPagamento.CustomFormat = "MM/dd/yyyy";
                                                query = "Pagamentos.DataPagamento";

                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Pagamentos", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }
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

            if (bttAdicionarDocumento.Text.Trim() == "Adicionar" && op ==0)
            {
                erro = true;
                erros.SetError(txtDocumento, "Adicione o comprovativo do pagamento");
            }

            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>())
                foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox || Controlo is MyDateTimePicker || Controlo is NormalDateTimePicker || Controlo is Button)
                    {
                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {

                                case "txtValor":

                                    Match Numeros = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                                    if (Numeros.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o valor do pagamento");
                                    }

                                    break;
                            }
                        }
                        else
                        {
                            if (Controlo.Name != "txtCondominio" && Controlo.Name != "txtFracao" && Controlo.Name != "txtTipoPagamento" && Controlo.Name != "txtDescricao" && Controlo.Name != "txtDocumento" && op != 1)
                            {
                                if (Controlo.Name == "cbFracao" && Controlo.Visible == false)
                                {
                                    erro = true;
                                    erros.SetError(cbCondominio, "Este condomínio não possui frações");
                                }
                                else if (Controlo.Name == "cbFracao" && Controlo.Visible == true && Controlo.Text == string.Empty && txtFracao.Text != string.Empty)
                                {

                                }
                                else
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                                }
                            }
                        }
                    }

            return erro;
        }

        private void dtpDataPagamento_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.Select();

                SendKeys.Send("%{DOWN}");
                dtpDataPagamento.CustomFormat = "dd/MM/yyyy";
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
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Pagamentos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioPagamentos2_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);


                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                //Carrega os Condomínios para a COMBOBOX
                DataTable dt = Utilitarios.FillBy("SELECT IDCondominio, Nome FROM Condominios");
                foreach (DataRow row in dt.Rows) cbCondominio.Items.Add(row["Nome"].ToString().Substring(row["Nome"].ToString().IndexOf(" ") + 1));

                dtpDataPagamento.MaxDate = DateTime.Today;

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

                cbFracao.Visible = false;
                bttMapaPagamentos.Visible = false;
                cbTipoPagamento.SelectedIndex = -1;
                txtTipoPagamento.Visible = false;
                cbTipoPagamento.Visible = true;
                erros.Clear();
                bttVoltar.Location = new Point(354, 440);
                bttAbrirDocumento.Visible = false;
                bttAdicionarDocumento.Visible = true;
                bttAdicionarDocumento.Text = "Adicionar";
                panelDadosGerais.Height = 380;

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Pagamento";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        dtpDataPagamento.CustomFormat = " ";
                        dtpPeriodoQuota.CustomFormat = " ";
                        dtpPeriodoQuota.Visible = false;
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Pagamentos";
                        bttFiltrar.Visible = true;
                        bttMapaPagamentos.Visible = true;
                        bttGuardar.Visible = false;
                        bttAdicionarDocumento.Visible = false;
                        bttAbrirDocumento.Visible = false;
                        lblDocumento.Visible = false;
                        panelDadosGerais.Height = 295;
                        bttVoltar.Location = new Point(100, 355);
                        bttFiltrar.Location = new Point(527, 355);
                        bttMapaPagamentos.Location = new Point(274, 355);
                        dtpDataPagamento.CustomFormat = " ";
                        dtpPeriodoQuota.CustomFormat = " ";
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Pagamento";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();
                        bttAdicionarDocumento.Text = "Alterar";

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Pagamento";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            {
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;
                                foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>()) Controlo.ReadOnly = true;
                                foreach (MyDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<MyDateTimePicker>()) Controlo.Enabled = false;
                                foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = false;
                            }

                        Editar_Visualizar(3);

                        bttAbrirDocumento.Visible = true;
                        bttAdicionarDocumento.Visible = false;
                        bttVoltar.Location = new Point(527, 440);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        bttVoltar.Focus();
                        cbFracao.Visible = false;

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
                DataTable tabelaPagamentos = Utilitarios.FillBy("SELECT * FROM Pagamentos WHERE (IDPagamento = " + idregisto + ")");

                if (tabelaPagamentos.Rows.Count == 1)
                {
                    //int IDFuncionario2 = int.Parse(tabelaCondominios.Rows[0][1].ToString());
                    int IDFracao = int.Parse(tabelaPagamentos.Rows[0][1].ToString());
                    IDFuncionario = int.Parse(tabelaPagamentos.Rows[0][2].ToString());
                    IDDocumento = int.Parse(tabelaPagamentos.Rows[0][3].ToString());
                    txtDescricao.Text = tabelaPagamentos.Rows[0][5].ToString();
                    decimal Valor = decimal.Parse(tabelaPagamentos.Rows[0][6].ToString());
                    dtpPeriodoQuota.Text = tabelaPagamentos.Rows[0][7].ToString();
                    dtpDataPagamento.Text = tabelaPagamentos.Rows[0][8].ToString();

                    //Editar
                    if (chegueide == 2)
                    {
                        txtValor.Text = Valor.ToString();
                        txtTipoPagamento.Visible = false;
                        cbTipoPagamento.Visible = true;
                        cbTipoPagamento.Text = tabelaPagamentos.Rows[0][4].ToString();

                        txtCondominio.Visible = false;
                        cbCondominio.Visible = true;

                        txtFracao.Visible = true;
                        cbFracao.Visible = true;
                    }
                    //Visualizar
                    else
                    {
                        txtValor.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2} €", Valor.ToString());
                        txtTipoPagamento.Visible = true;
                        cbTipoPagamento.Visible = false;
                        txtTipoPagamento.Text = tabelaPagamentos.Rows[0][4].ToString();

                        txtCondominio.Visible = true;
                        cbCondominio.Visible = false;

                        txtFracao.Visible = true;
                        cbFracao.Visible = false;
                    }

                    //Documentos
                    DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos WHERE(IDDocumento = " + IDDocumento + ")");

                    if (tabelaDocumentos.Rows.Count == 1)
                        lblDocumento.Text = "Documento - " + tabelaDocumentos.Rows[0][3].ToString();

                    //Fração e Condomínio
                    DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE(IDFracao = " + IDFracao + ")");

                    if (tabelaFracoes.Rows.Count == 1)
                    {
                        int IDCondominio = int.Parse(tabelaFracoes.Rows[0][1].ToString());
                        txtFracao.Text = tabelaFracoes.Rows[0][3].ToString();
                        cbFracao.Text = tabelaFracoes.Rows[0][3].ToString();

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE(IDCondominio = " + IDCondominio + ")");

                        if (tabelaCondominios.Rows.Count == 1)
                        {
                            txtCondominio.Text = tabelaCondominios.Rows[0][4].ToString().Substring(tabelaCondominios.Rows[0][4].ToString().IndexOf(" ") + 1);
                            cbCondominio.Text = tabelaCondominios.Rows[0][4].ToString().Substring(tabelaCondominios.Rows[0][4].ToString().IndexOf(" ") + 1);
                        }
                    }

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

                        //Condomínios e Frações
                        DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos ORDER BY IDDocumento DESC");
                        IDDocumento = int.Parse(tabelaDocumentos.Rows[0][0].ToString());

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (NomeFracao = '" + cbFracao.Text + "' and IDCondominio = '" + IDCondominio + "')");
                        IDFracao = int.Parse(tabelaFracoes.Rows[0][0].ToString());

                        //Pagamentos
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Pagamentos (IDFracao, IDFuncionario, IDDocumento, TipoPagamento, Descricao, Valor, PeriodoQuota, DataPagamento) VALUES(@IDFracao, @IDFuncionario, @IDDocumento, @TipoPagamento, @Descricao, @Valor, @PeriodoQuota, @DataPagamento)", con);

                            cmd.Parameters.AddWithValue("@IDFracao", IDFracao);
                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@TipoPagamento", cbTipoPagamento.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim());
                            cmd.Parameters.AddWithValue("@Valor", decimal.Parse(txtValor.Text.Trim()));
                            cmd.Parameters.AddWithValue("@PeriodoQuota", dtpPeriodoQuota.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataPagamento", DateTime.ParseExact(dtpDataPagamento.Text.Trim(), "dd/MM/yyyy", null));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Pagamento registado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //Condomínios e Frações
                        DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos ORDER BY IDDocumento DESC");
                        IDDocumento = int.Parse(tabelaDocumentos.Rows[0][0].ToString());

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (NomeFracao = '" + txtFracao.Text + "' and IDCondominio = " + IDCondominio + ")");
                        IDFracao = int.Parse(tabelaFracoes.Rows[0][0].ToString());

                        //Documentos
                        if (dlg.FileName != string.Empty)
                            Utilitarios.SaveFile(dlg.FileName, op, IDDocumento);

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Pagamentos SET IDFracao = @IDFracao, IDFuncionario = @IDFuncionario, IDDocumento = @IDDocumento, TipoPagamento = @TipoPagamento," +
                                "Descricao = @Descricao, Valor = @Valor, PeriodoQuota = @PeriodoQuota, DataPagamento = @DataPagamento WHERE(IDPagamento = @IDPagamento)", con);

                            cmd.Parameters.AddWithValue("@IDPagamento", idregisto);
                            cmd.Parameters.AddWithValue("@IDFracao", IDFracao);
                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@TipoPagamento", cbTipoPagamento.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim());
                            cmd.Parameters.AddWithValue("@Valor", decimal.Parse(txtValor.Text.Trim()));
                            cmd.Parameters.AddWithValue("@PeriodoQuota", dtpPeriodoQuota.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataPagamento", DateTime.ParseExact(dtpDataPagamento.Text.Trim(), "dd/MM/yyyy", null));

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Pagamentos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttMapaPagamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCondominio.Text.Trim() != string.Empty)
                {
                    //Obter ID do condomínio
                    DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                    int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                    //Frações
                    DataTable tabelaFracoes = Utilitarios.FillBy("SELECT IDFracao, NomeFracao, QuotaMensal FROM Fracoes WHERE (IDCondominio = '" + IDCondominio + "') ORDER BY NomeFracao");

                    if (tabelaFracoes.Rows.Count != 0)
                    {
                        erros.Clear();

                        Clientes.FrmClientes janela = new Clientes.FrmClientes("MapaPagamentos",DateTime.Today.Year, cbCondominio.Text.Trim(), op, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);
                    }
                    else
                        erros.SetError(cbCondominio, "Este condomínio não possui frações");
                }
                else
                    erros.SetError(cbCondominio, "Selecione um condomínio");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
