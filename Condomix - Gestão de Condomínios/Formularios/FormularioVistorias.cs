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
    public partial class FormularioVistorias : Form
    {
        int op, idregisto, IDFuncionario, IDCondominio;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, Cor;
        Image FotoFuncionario;

        public FormularioVistorias(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioVistorias(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Vistorias", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtNIFFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Validacoes.IsValidContrib(txtNIFFuncionario.Text.Trim()) == true)
                {
                    //QueryNIFCliente
                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        con.Open();
                        string FillByNIFCliente = "SELECT NIFFuncionario, Nome FROM Funcionarios WHERE(NIFFuncionario = " + int.Parse(txtNIFFuncionario.Text.Trim()) + ")";

                        SqlDataAdapter adp = new SqlDataAdapter(FillByNIFCliente, con);

                        DataTable tabelaClientes = new DataTable();
                        adp.Fill(tabelaClientes);
                        con.Close();

                        if (tabelaClientes.Rows.Count == 1)
                            txtNomeFuncionario.Text = tabelaClientes.Rows[0][1].ToString();
                    }
                }
                else
                    txtNomeFuncionario.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioVistorias_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelVistorias.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);


                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                // Carrega os Condomínios para a COMBOBOX
                DataTable dt = Utilitarios.FillBy("SELECT IDCondominio, Nome FROM Condominios");
                foreach (DataRow row in dt.Rows) cbCondominio.Items.Add(row["Nome"].ToString().Substring(row["Nome"].ToString().IndexOf(" ") + 1));

                dtpData.MaxDate = DateTime.Today;

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }
                        foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>()) Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = true;
                    }


                cbCondominio.SelectedIndex = -1;
                txtCondominio.Visible = false;
                cbCondominio.Visible = true;
                txtDescritivo.ReadOnly = false;
                erros.Clear();

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Vistoria";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        txtNomeFuncionario.ReadOnly = true;
                        dtpData.CustomFormat = " ";
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Vistorias";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        dtpData.CustomFormat = " ";
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Vistorias";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        txtNomeFuncionario.ReadOnly = true;
                        bttGuardar.Focus();

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Vistoria";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                            {
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;
                                foreach (RichTextBox Controlo in ControloGroupBoxs.Controls.OfType<RichTextBox>()) Controlo.ReadOnly = true;
                                foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = false;
                            }

                        Editar_Visualizar(3);

                        bttVoltar.Location = new Point(525, 415);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        txtDescritivo.ReadOnly = true;
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
                DataTable tabelaVistorias = Utilitarios.FillBy("SELECT * FROM Vistorias WHERE (IDVistoria = " + idregisto + ")");

                if (tabelaVistorias.Rows.Count == 1)
                {
                    int IDFuncionario2 = int.Parse(tabelaVistorias.Rows[0][1].ToString());
                    IDCondominio = int.Parse(tabelaVistorias.Rows[0][2].ToString());
                    txtTitulo.Text = tabelaVistorias.Rows[0][3].ToString();
                    txtDescritivo.Text = tabelaVistorias.Rows[0][4].ToString();
                    dtpData.Text = tabelaVistorias.Rows[0][5].ToString();

                    //Editar
                    if (chegueide == 2)
                    {
                        txtCondominio.Visible = false;
                        cbCondominio.Visible = true;
                    }
                    //Visualizar
                    else
                    {
                        txtCondominio.Visible = true;
                        cbCondominio.Visible = false;
                    }

                    DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario2 + ")");

                    if (tabelaFuncionarios.Rows.Count == 1)
                    {
                        txtNIFFuncionario.Text = tabelaFuncionarios.Rows[0][1].ToString();
                        txtNomeFuncionario.Text = tabelaFuncionarios.Rows[0][6].ToString();
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

                        //Obter ID do Funcionario
                        DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE (NIFFuncionario = " + txtNIFFuncionario.Text.Trim() + ")");
                        int IDFuncionario = int.Parse(tabelaFuncionarios.Rows[0][0].ToString());

                        //Vistorias
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Vistorias (IDFuncionario, IDCondominio, Titulo, Descritivo, Data) " +
                                "VALUES(@IDFuncionario, @IDCondominio, @Titulo, @Descritivo, @Data)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Data", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Vistoria adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        //Obter ID do condomínio
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text.Trim() + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Obter ID do Funcionario
                        DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE (NIFFuncionario = " + txtNIFFuncionario.Text.Trim() + ")");
                        int IDFuncionario = int.Parse(tabelaFuncionarios.Rows[0][0].ToString());

                        //Vistorias
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Vistorias SET IDFuncionario = @IDFuncionario, IDCondominio = @IDCondominio, " +
                                "Titulo = @Titulo, Descritivo = @Descritivo, Data = @Data WHERE (IDVistoria = @IDVistoria)", con);

                            cmd.Parameters.AddWithValue("@IDVistoria", idregisto);
                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descritivo", txtDescritivo.Text.Trim());
                            cmd.Parameters.AddWithValue("@Data", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Vistorias", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is NormalDateTimePicker || Controlo is RichTextBox)
                                {
                                    if (Controlo.Text.Trim() != string.Empty)
                                    {
                                        string query = string.Empty;

                                        switch (Controlo.Name)
                                        {
                                            case "txtNIFFuncionario":
                                                query = "Funcionarios.NIFFuncionario";
                                                break;

                                            case "txtNomeFuncionario":
                                                query = "Funcionarios.Nome";
                                                break;

                                            case "cbCondominio":

                                                string nome = Controlo.Text.Trim();
                                                cbCondominio.Items.Clear();
                                                cbCondominio.Items.Add("Condomínio " + nome);
                                                cbCondominio.SelectedIndex = 0;

                                                query = "Condominios.Nome";
                                                break;

                                            case "txtTitulo":
                                                query = "Vistorias.Titulo";
                                                break;

                                            case "txtDescritivo":
                                                query = "Vistorias.Descritivo";
                                                break;

                                            case "dtpData":
                                                dtpData.CustomFormat = "MM/dd/yyyy";
                                                query = "Vistorias.Data";

                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Vistorias", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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

            foreach (GroupBox Controlo2 in panelVistorias.Controls.OfType<GroupBox>())
                foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is NormalDateTimePicker || Controlo is RichTextBox)
                    {
                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {
                                case "txtNIFFuncionario":

                                    if (Validacoes.IsValidContrib(Controlo.Text.Trim()) == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um NIF de Funcionario válido");
                                    }

                                    break;

                                case "txtNomeFuncionario":

                                    Match Nome2 = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                    if (Nome2.Success == false && op == 1)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um nome válido");
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
                            if (Controlo.Name != "txtNomeFuncionario" && Controlo.Name != "txtCondominio" && op != 1)
                            {
                                erro = true;
                                erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                            }
                        }
                    }

            return erro;
        }

    }
}
