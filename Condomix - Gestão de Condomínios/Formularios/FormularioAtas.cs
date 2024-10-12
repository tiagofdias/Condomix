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
    public partial class FormularioAtas : Form
    {
        int op, idregisto, IDFuncionario, IDCondominio, IDDocumento;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, Cor;
        Image FotoFuncionario;
        OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true, Multiselect = false };

        public FormularioAtas(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioAtas(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        private void FormularioAtas_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);

                iconCurrentChildForm.IconColor=Customizar.HexToColor(Cor);

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
                        }

                        foreach (NormalDateTimePicker Controlo in ControloGroupBoxs.Controls.OfType<NormalDateTimePicker>()) Controlo.Enabled = true;
                    }

                erros.Clear();
                bttVoltar.Location = new Point(354, 272);
                panelDadosGerais.Height = 212;
                bttAbrirDocumento.Visible = false;
                bttAdicionarDocumento.Visible = true;
                bttAdicionarDocumento.Text = "Adicionar";

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Ata";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        dtpData.CustomFormat = " ";
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Atas";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttAdicionarDocumento.Visible = false;
                        bttAbrirDocumento.Visible = false;
                        lblDocumento.Visible = false;
                        panelDadosGerais.Height = 133;
                        bttVoltar.Location = new Point(354, 193);
                        bttFiltrar.Location = new Point(527, 193);
                        dtpData.CustomFormat = " ";
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Ata";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();
                        bttAdicionarDocumento.Text = "Alterar";

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Ata";

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
                        bttVoltar.Location = new Point(527, 272);
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
                DataTable tabelaPagamentos = Utilitarios.FillBy("SELECT * FROM Atas WHERE (IDAta = " + idregisto + ")");

                if (tabelaPagamentos.Rows.Count == 1)
                {

                    IDCondominio = int.Parse(tabelaPagamentos.Rows[0][1].ToString());
                    IDDocumento = int.Parse(tabelaPagamentos.Rows[0][2].ToString());
                    txtNome.Text = tabelaPagamentos.Rows[0][3].ToString();
                    dtpData.Text = tabelaPagamentos.Rows[0][4].ToString();

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

                    //Documentos
                    DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos WHERE(IDDocumento = " + IDDocumento + ")");

                    if (tabelaDocumentos.Rows.Count == 1)
                        lblDocumento.Text = "Documento - " + tabelaDocumentos.Rows[0][3].ToString();

                    //Condomínio
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

                        //Documentos
                        Utilitarios.SaveFile(dlg.FileName, op);

                        //Condomínios e Frações
                        DataTable tabelaDocumentos = Utilitarios.FillBy("SELECT * FROM Documentos ORDER BY IDDocumento DESC");
                        IDDocumento = int.Parse(tabelaDocumentos.Rows[0][0].ToString());

                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Atas
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Atas (IDCondominio, IDDocumento, Nome, Data) VALUES(@IDCondominio, @IDDocumento, @Nome, @Data)", con);

                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@Data", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Ata adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //Condomínios e Frações
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Text + "')");
                        IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Documentos
                        if (dlg.FileName != string.Empty)
                            Utilitarios.SaveFile(dlg.FileName, op, IDDocumento);

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Atas SET IDCondominio = @IDCondominio, IDDocumento = @IDDocumento, Nome = @Nome, Data = @Data WHERE(IDAta = @IDAta)", con);

                            cmd.Parameters.AddWithValue("@IDAta", idregisto);
                            cmd.Parameters.AddWithValue("@IDCondominio", IDCondominio);
                            cmd.Parameters.AddWithValue("@IDDocumento", IDDocumento);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@Data", DateTime.ParseExact(dtpData.Text.Trim(), "dd/MM/yyyy", null));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                        bttGuardar.Focus();
                        MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    erros.Clear();

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Atas", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is NormalDateTimePicker)
                                {
                                    if (Controlo.Text.Trim() != string.Empty)
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

                                            case "txtNome":
                                                query = "Atas.Nome";
                                                break;

                                            case "dtpData":
                                                dtpData.CustomFormat = "MM/dd/yyyy";
                                                query = "Atas.Data";

                                                break;

                                        }

                                        query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                    }
                                }

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Atas", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
                erros.SetError(txtDocumento, "Adicione o comprovativo do pagamento");
            }

            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>())
                foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox || Controlo is NormalDateTimePicker || Controlo is Button)
                    {
                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            switch (Controlo.Name)
                            {

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
                            if (Controlo.Name != "txtCondominio" && Controlo.Name != "txtDocumento" && op != 1)
                            { 
                                    erro = true;
                                    erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                            }
                        }
                    }

            return erro;
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttAbrirDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitarios.OpenFile(IDDocumento);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
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

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            try
            {

                erros.Clear();
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Atas", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
