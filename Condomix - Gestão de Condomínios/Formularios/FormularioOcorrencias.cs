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
    public partial class FormularioOcorrencias : Form
    {
        int op, idregisto, IDFuncionario, IDFracao;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, Cor;
        Image FotoFuncionario;

        public FormularioOcorrencias(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioOcorrencias(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor= _Cor;
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

                        // Carrega os Condomínios para a COMBOBOX
                        DataTable dt = Utilitarios.FillBy("SELECT IDFracao, IDCondominio, NomeFracao FROM Fracoes WHERE IDCondominio = " + IDCondominio + " ORDER BY NomeFracao ");

                        foreach (DataRow row in dt.Rows) cbFracao.Items.Add(row["NomeFracao"].ToString().Substring(row["NomeFracao"].ToString().IndexOf(" ") + 1));

                        if (cbFracao.Items.Count != 0)
                            cbFracao.Visible = true;
                    }
                }

                if (op == 2) i++;

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

        private void dtpData_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.Select();

                SendKeys.Send("%{DOWN}");
                dtpData.CustomFormat = "dd/MM/yyyy";

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

                        //Condomínios e Frações
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (NomeFracao = '" + cbFracao.Text + "' and IDCondominio = '" + IDCondominio + "')");
                        IDFracao = int.Parse(tabelaFracoes.Rows[0][0].ToString());

                        //Pagamentos
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Ocorrencias (IDFracao, Titulo, Descritivo, DataLimiteResolucao, Estado) VALUES(@IDFracao, @Titulo, @Descritivo, @DataLimiteResolucao, @Estado)", con);

                            cmd.Parameters.AddWithValue("@IDFracao", IDFracao);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataLimiteResolucao", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));
                            cmd.Parameters.AddWithValue("@Estado", cbEstado.Text.Trim());

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Ocorrência registada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //Condomínios e Frações
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (NomeFracao = '" + txtFracao.Text + "' and IDCondominio = '" + IDCondominio + "')");
                        IDFracao = int.Parse(tabelaFracoes.Rows[0][0].ToString());

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Ocorrencias SET IDFracao = @IDFracao, Titulo = @Titulo, Descritivo = @Descritivo, DataLimiteResolucao = @DataLimiteResolucao," +
                                "Estado = @Estado WHERE(IDOcorrencia = @IDOcorrencia)", con);

                            cmd.Parameters.AddWithValue("@IDOcorrencia", idregisto);
                            cmd.Parameters.AddWithValue("@IDFracao", IDFracao);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@DataLimiteResolucao", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));
                            cmd.Parameters.AddWithValue("@Estado", cbEstado.Text.Trim());

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Ocorrencias", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox || Controlo is NormalDateTimePicker)
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

                                            case "cbEstado":
                                                query = "Ocorrencias.Estado";
                                                break;

                                            case "txtTitulo":
                                                query = "Ocorrencias.Titulo";
                                                break;

                                            case "txtDescricao":
                                                query = "Ocorrencias.Descritivo";
                                                break;

                                            case "dtpData":
                                                dtpData.CustomFormat = "MM/dd/yyyy";
                                                query = "Ocorrencias.DataLimiteResolucao";

                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Ocorrencias", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>())
                foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is RichTextBox || Controlo is MyDateTimePicker || Controlo is NormalDateTimePicker || Controlo is Button)
                    {
                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {

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
                            if (Controlo.Name != "txtCondominio" && Controlo.Name != "txtFracao" && Controlo.Name != "txtEstado" && op != 1)
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

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Ocorrencias", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ocorrencias_Load(object sender, EventArgs e)
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

                        foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = true;
                    }

                cbFracao.Visible = false;
                cbEstado.SelectedIndex = -1;
                txtEstado.Visible = false;
                cbEstado.Visible = true;
                erros.Clear();
                bttVoltar.Location = new Point(354, 374);

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Ocorrência";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        dtpData.CustomFormat = " ";
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Ocorrências";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        dtpData.CustomFormat = " ";
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Ocorrência";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Ocorrência";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            {
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;
                                foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>()) Controlo.ReadOnly = true;
                                foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = false;
                            }

                        Editar_Visualizar(3);

                        bttVoltar.Location = new Point(527, 374);
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
                DataTable tabelaOcorrencias = Utilitarios.FillBy("SELECT * FROM Ocorrencias WHERE (IDOcorrencia = " + idregisto + ")");

                if (tabelaOcorrencias.Rows.Count == 1)
                {

                    int IDFracao = int.Parse(tabelaOcorrencias.Rows[0][1].ToString());
                    txtTitulo.Text = tabelaOcorrencias.Rows[0][2].ToString();
                    txtDescritivo.Text = tabelaOcorrencias.Rows[0][3].ToString();
                    dtpData.Text = tabelaOcorrencias.Rows[0][4].ToString();

                    //Editar
                    if (chegueide == 2)
                    {
                        txtEstado.Visible = false;
                        cbEstado.Visible = true;
                        cbEstado.Text = tabelaOcorrencias.Rows[0][5].ToString();

                        txtCondominio.Visible = false;
                        cbCondominio.Visible = true;

                        txtFracao.Visible = true;
                        cbFracao.Visible = true;

                    }
                    //Visualizar
                    else
                    {
                        txtEstado.Visible = true;
                        cbEstado.Visible = false;
                        txtEstado.Text = tabelaOcorrencias.Rows[0][5].ToString();

                        txtCondominio.Visible = true;
                        cbCondominio.Visible = false;

                        txtFracao.Visible = true;
                        cbFracao.Visible = false;
                    }

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
    }
}
