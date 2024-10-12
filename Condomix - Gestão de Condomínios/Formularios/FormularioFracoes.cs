using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioFracoes : Form
    {
        int op, idregisto, IDCliente, IDFuncionario, IDCondominio;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, NomeFracao, Cor;
        Image FotoFuncionario;

        public FormularioFracoes(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioFracoes(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor =_Cor;
        }

        public FormularioFracoes(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _NomeFracao, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            NomeFracao = _NomeFracao;
            Cor =_Cor;
        }

        private void txtNIFCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Validacoes.IsValidContrib(txtNIFCliente.Text.Trim()) == true)
                {
                    //QueryNIFCliente
                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        con.Open();
                        string FillByNIFCliente = "SELECT NIFCliente, Nome FROM Clientes WHERE(NIFCliente = " + int.Parse(txtNIFCliente.Text.Trim()) + ")";

                        SqlDataAdapter adp = new SqlDataAdapter(FillByNIFCliente, con);

                        DataTable tabelaClientes = new DataTable();
                        adp.Fill(tabelaClientes);
                        con.Close();

                        if (tabelaClientes.Rows.Count == 1)
                            txtNomeCliente.Text = tabelaClientes.Rows[0][1].ToString();
                    }
                }
                else
                    txtNomeCliente.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPermilagem_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (op != 3)
                {
                    Match Numeros = Regex.Match(txtPermilagem.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                    if (Numeros.Success == true)
                    {
                        if (cbCondominio.Text.Trim() != string.Empty)
                        {
                            //Obter ID do condomínio
                            DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                            decimal OA = decimal.Parse(tabelaCondominios.Rows[0][5].ToString());
                            decimal QM = OA * (decimal.Parse(txtPermilagem.Text.Trim()) / 1000) / 12;
                            txtQuotaMensal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", QM);
                        }
                    }
                    else
                        txtQuotaMensal.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (op != 3)
                {
                    Match Numeros = Regex.Match(txtPermilagem.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                    if (Numeros.Success == true)
                    {
                        if (txtPermilagem.Text.Trim() != string.Empty)
                        {
                            //Obter ID do condomínio
                            DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                            decimal OA = decimal.Parse(tabelaCondominios.Rows[0][5].ToString());
                            decimal QM = OA * (decimal.Parse(txtPermilagem.Text.Trim()) / 1000) / 12;
                            txtQuotaMensal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", QM);
                        }
                    }
                    else
                        txtQuotaMensal.ResetText();

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

                        //Obter ID do condomínio
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());
                        decimal OA = decimal.Parse(tabelaCondominios.Rows[0][5].ToString());

                        //Obter ID do Cliente
                        DataTable tabelaClientes = Utilitarios.FillBy("SELECT * FROM Clientes WHERE (NIFCliente = " + txtNIFCliente.Text.Trim() + ")");
                        IDCliente = int.Parse(tabelaClientes.Rows[0][0].ToString());

                        //Frações
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Fracoes (IDCondominio, IDCliente, NomeFracao, TipoFracao, Permilagem, QuotaMensal, AdministradorInterno, Observacoes) " +
                                "VALUES(@IDCondominio, @IDCliente, @NomeFracao, @TipoFracao, @Permilagem, @QuotaMensal, @AdministradorInterno, @Observacoes)", con);

                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                            cmd.Parameters.AddWithValue("@NomeFracao", txtNome.Text.Trim().ToUpper());
                            cmd.Parameters.AddWithValue("@TipoFracao", cbTipoFracao.Text.Trim());
                            cmd.Parameters.AddWithValue("@Permilagem", decimal.Parse(txtPermilagem.Text.Trim()));

                            //Quota Anual = Orçamento anual x Permilagem da fração/1 000
                            //Quota Mensal = Orçamento anual x (Permilagem da fração/1 000) / 12
                            cmd.Parameters.AddWithValue("@QuotaMensal", OA * (decimal.Parse(txtPermilagem.Text.Trim()) / 1000) / 12);

                            if (cbAdministradorInterno.Text == "Sim")
                            {
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add(true);
                                cbAdministradorInterno.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@AdministradorInterno", cbAdministradorInterno.Text.Trim());
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add("Sim");
                                cbAdministradorInterno.SelectedIndex = 0;
                            }
                            else
                            {
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add(false);
                                cbAdministradorInterno.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@AdministradorInterno", cbAdministradorInterno.Text.Trim());
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add("Não");
                                cbAdministradorInterno.SelectedIndex = 0;
                            }

                            cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("A nova fração foi adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        //Obter ID do condomínio
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());
                        decimal OA = decimal.Parse(tabelaCondominios.Rows[0][5].ToString());

                        //Obter ID do Cliente
                        DataTable tabelaClientes = Utilitarios.FillBy("SELECT * FROM Clientes WHERE (NIFCliente = '" + txtNIFCliente.Text.Trim() + "')");
                        IDCliente = int.Parse(tabelaClientes.Rows[0][0].ToString());

                        //Frações
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Fracoes SET IDCondominio = @IDCondominio, IDCliente = @IDCliente, " +
                                "NomeFracao = @NomeFracao, TipoFracao = @TipoFracao, Permilagem = @Permilagem, QuotaMensal = @QuotaMensal, " +
                                "AdministradorInterno = @AdministradorInterno, Observacoes = @Observacoes WHERE (IDFracao = @IDFracao)", con);

                            cmd.Parameters.AddWithValue("@IDFracao", idregisto);
                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                            cmd.Parameters.AddWithValue("@NomeFracao", txtNome.Text.Trim().ToUpper());
                            cmd.Parameters.AddWithValue("@TipoFracao", cbTipoFracao.Text.Trim());
                            cmd.Parameters.AddWithValue("@Permilagem", decimal.Parse(txtPermilagem.Text.Trim()));

                            //Quota Anual = Orçamento anual x Permilagem da fração/1 000
                            //Quota Mensal = Orçamento anual x (Permilagem da fração/1 000) / 12
                            cmd.Parameters.AddWithValue("@QuotaMensal", OA * (decimal.Parse(txtPermilagem.Text.Trim()) / 1000) / 12);

                            if (cbAdministradorInterno.Text == "Sim")
                            {
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add(true);
                                cbAdministradorInterno.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@AdministradorInterno", cbAdministradorInterno.Text.Trim());
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add("Sim");
                                cbAdministradorInterno.SelectedIndex = 0;
                            }
                            else
                            {
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add(false);
                                cbAdministradorInterno.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@AdministradorInterno", cbAdministradorInterno.Text.Trim());
                                cbAdministradorInterno.Items.Clear();
                                cbAdministradorInterno.Items.Add("Não");
                                cbAdministradorInterno.SelectedIndex = 0;
                            }

                            cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Fracoes", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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

            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelFracao.Controls.OfType<GroupBox>()) foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is NumericUpDown)
                    {

                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {

                                case "txtNome":

                                    Match Nome = Regex.Match(Controlo.Text.ToUpper().Trim(), @"^(?=.*\d)(?=.*[º])(?=.*[A-Za-z])(?!.*[\ ]).{3,5}$");

                                    if (Nome.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "O nome da fração deve conter o Andar e o lado separados pelo simbolo º");
                                    }
                                    else
                                    {
                                        //verificar se já existe a mesma fração no mesmo condominio

                                        if (op != 1)
                                        {
                                            if (cbCondominio.Text.Trim() != string.Empty)
                                            {
                                                //Obter ID do condomínio
                                                DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                                                DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (NomeFracao = '" + Controlo.Text.ToUpper().Trim() + "') AND(IDCondominio = " + int.Parse(tabelaCondominios.Rows[0][0].ToString()) + ")");

                                                //Inserir
                                                if (op == 0 && tabelaFracoes.Rows.Count != 0)
                                                {
                                                    erro = true;
                                                    erros.SetError(Controlo, "Esta fração já se encontra registada neste condomínio");
                                                }

                                                //Editar
                                                if (op == 2 && Controlo.Text.ToUpper().Trim() != NomeFracao.ToUpper().Trim().ToString() || op == 2 && int.Parse(tabelaCondominios.Rows[0][0].ToString()) != IDCondominio)
                                                {
                                                    if (tabelaFracoes.Rows.Count != 0)
                                                    {
                                                        erro = true;
                                                        erros.SetError(Controlo, "Esta fração já se encontra registada neste condomínio");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                erro = true;
                                                erros.SetError(cbCondominio, "Introduza um condomínio");
                                            }
                                        }
                                    }

                                    break;

                                case "txtPermilagem":

                                    Match Numeros = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                                    if (Numeros.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente a permilagem do condomínio");
                                    }

                                    break;

                                case "txtNIFCliente":

                                    if (Validacoes.IsValidContrib(Controlo.Text.Trim()) == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um NIF de cliente válido");
                                    }

                                    break;

                                case "txtNomeCliente":

                                    Match Nome2 = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                    if (Nome2.Success == false && op == 1)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um nome válido");
                                    }

                                    break;

                                case "txtQuotaMensal":

                                    Match Numeros2 = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                                    if (Numeros2.Success == false && op == 1)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente a Quota Mensal do condomínio");
                                    }

                                    break;

                            }
                        }
                        else
                        {
                            if (Controlo.Name != "txtNomeCliente" && Controlo.Name != "txtAdministradorInterno" && Controlo.Name != "txtTipoFracao" && Controlo.Name != "txtCondominio" && Controlo.Name != "txtQuotaMensal" && op != 1)
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

        private void FormularioFracoes_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelFracao.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);


                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                // Carrega os Condomínios para a COMBOBOX
                DataTable dt = Utilitarios.FillBy("SELECT IDCondominio, Nome FROM Condominios");
                foreach (DataRow row in dt.Rows) cbCondominio.Items.Add(row["Nome"].ToString().Substring(row["Nome"].ToString().IndexOf(" ") + 1));

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
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                    }

                cbCondominio.SelectedIndex = -1;
                cbTipoFracao.SelectedIndex = -1;
                cbAdministradorInterno.SelectedIndex = -1;

                txtCondominio.Visible = false;
                txtTipoFracao.Visible = false;
                txtAdministradorInterno.Visible = false;

                cbCondominio.Visible = true;
                cbTipoFracao.Visible = true;
                cbAdministradorInterno.Visible = true;

                txtObservacoes.ReadOnly = false;
                txtObservacoes.ResetText();

                erros.Clear();
                bttVoltar.Location = new Point(352, 463);

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Fração";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        txtQuotaMensal.ReadOnly = true;
                        txtNomeCliente.ReadOnly = true;
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Frações";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Fração";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        txtQuotaMensal.ReadOnly = true;
                        txtNomeCliente.ReadOnly = true;
                        bttGuardar.Focus();

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Fração";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;

                        Editar_Visualizar(3);

                        bttVoltar.Location = new Point(525, 463);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;

                        txtObservacoes.ReadOnly = true;

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
                DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (IDFracao = " + idregisto + ")");

                if (tabelaFracoes.Rows.Count == 1)
                {
                    IDCondominio = int.Parse(tabelaFracoes.Rows[0][1].ToString());
                    IDCliente = int.Parse(tabelaFracoes.Rows[0][2].ToString());
                    txtNome.Text = tabelaFracoes.Rows[0][3].ToString();
                    cbTipoFracao.Text = tabelaFracoes.Rows[0][4].ToString();
                    txtTipoFracao.Text = tabelaFracoes.Rows[0][4].ToString();
                    decimal Permilagem = decimal.Parse(tabelaFracoes.Rows[0][5].ToString());
                    decimal QuotaMensal = decimal.Parse(tabelaFracoes.Rows[0][6].ToString());
                    txtObservacoes.Text = tabelaFracoes.Rows[0][8].ToString();

                    //Editar
                    if (chegueide == 2)
                    {
                        txtPermilagem.Text = Permilagem.ToString();
                        txtQuotaMensal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", QuotaMensal);
                        txtAdministradorInterno.Visible = false;
                        txtCondominio.Visible = false;
                        txtTipoFracao.Visible = false;
                        cbAdministradorInterno.Visible = true;
                        cbCondominio.Visible = true;
                        cbTipoFracao.Visible = true;
                        if (tabelaFracoes.Rows[0][7].ToString() == "True") cbAdministradorInterno.SelectedIndex = 0; else cbAdministradorInterno.SelectedIndex = 1;
                    }
                    //Visualizar
                    else
                    {
                        txtPermilagem.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2} €", Permilagem.ToString());
                        txtQuotaMensal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", QuotaMensal);
                        txtAdministradorInterno.Visible = true;
                        txtCondominio.Visible = true;
                        txtTipoFracao.Visible = true;
                        cbAdministradorInterno.Visible = false;
                        cbCondominio.Visible = false;
                        cbTipoFracao.Visible = false;
                        if (tabelaFracoes.Rows[0][7].ToString() == "True") txtAdministradorInterno.Text = "Sim"; else txtAdministradorInterno.Text = "Não";
                    }

                    DataTable tabelaClientes = Utilitarios.FillBy("SELECT * FROM Clientes WHERE(IDCliente = " + IDCliente + ")");

                    if (tabelaClientes.Rows.Count == 1)
                    {
                        txtNIFCliente.Text = tabelaClientes.Rows[0][1].ToString();
                        txtNomeCliente.Text = tabelaClientes.Rows[0][4].ToString();
                    }

                    DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE(IDCondominio = " + IDCondominio + ")");

                    if (tabelaCondominios.Rows.Count == 1)
                    {
                        txtCondominio.Text = tabelaCondominios.Rows[0][4].ToString().Substring(tabelaCondominios.Rows[0][4].ToString().IndexOf(" ") + 1);
                        cbCondominio.Text = tabelaCondominios.Rows[0][4].ToString().Substring(tabelaCondominios.Rows[0][4].ToString().IndexOf(" ") + 1);
                    }
                }
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
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Fracoes", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);

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
                    panelFracao.Visible = false;
                    query2 = string.Empty;

                    foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                        foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            foreach (Control Controlo in ControloGroupBoxs.Controls)
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox)
                                {
                                    if (Controlo.Text.Trim() != string.Empty)
                                    {
                                        string query = string.Empty;

                                        switch (Controlo.Name)
                                        {

                                            case "txtNome":
                                                query = "Fracoes.NomeFracao";
                                                break;

                                            case "cbTipoFracao":
                                                query = "Fracoes.TipoFracao";
                                                break;

                                            case "cbCondominio":

                                                string nome = Controlo.Text.Trim();
                                                cbCondominio.Items.Clear();
                                                cbCondominio.Items.Add("Condomínio " + nome);
                                                cbCondominio.SelectedIndex = 0;

                                                query = "Condominios.Nome";
                                                break;

                                            case "txtNIFCliente":
                                                query = "Clientes.NIFCliente";
                                                break;

                                            case "txtNomeCliente":
                                                query = "Clientes.Nome";
                                                break;

                                            case "cbAdministradorInterno":

                                                if (cbAdministradorInterno.Text == "Sim")
                                                {
                                                    cbAdministradorInterno.Items.Clear();
                                                    cbAdministradorInterno.Items.Add(true);
                                                    cbAdministradorInterno.SelectedIndex = 0;
                                                }
                                                else
                                                {
                                                    cbAdministradorInterno.Items.Clear();
                                                    cbAdministradorInterno.Items.Add(false);
                                                    cbAdministradorInterno.SelectedIndex = 0;
                                                }

                                                query = "Fracoes.AdministradorInterno";
                                                break;

                                            case "txtObservacoes":
                                                query = "Fracoes.Observacoes";
                                                break;

                                            case "txtPermilagem":
                                                if (Controlo.Text.ToLower().Contains(',')) Controlo.Text = Controlo.Text.Replace(',', '.');
                                                query = "Fracoes.Permilagem";
                                                break;

                                            case "txtQuotaMensal":
                                                if (Controlo.Text.ToLower().Contains(',')) Controlo.Text = Controlo.Text.Replace(',', '.');
                                                query = "Fracoes.QuotaMensal";
                                                break;

                                        }
                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Fracoes", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
