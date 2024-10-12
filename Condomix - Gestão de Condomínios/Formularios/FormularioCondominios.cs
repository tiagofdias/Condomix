using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioCondominios : Form
    {

        int op, idregisto, IDMorada, IDFuncionario;
        string NomeFuncionario, CargoFuncionario, query2 = string.Empty, NomeCondominio, DeOndeVem, Cor;
        Image FotoFuncionario;
        OpenFileDialog dlg = new OpenFileDialog() { Filter = "JPG|*.jpg;*.jpeg|PNG|*.png", ValidateNames = true, Multiselect = false };
        byte[] buffer;

        public FormularioCondominios(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _DeOndeVem, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            DeOndeVem = _DeOndeVem;
            Cor = _Cor;

            foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    foreach (NumericUpDown Controlo in ControloGroupBoxs.Controls.OfType<NumericUpDown>()) Controlo.Controls[0].Visible = false;

        }

        public FormularioCondominios(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _NomeCondominio, string _DeOndeVem, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            NomeCondominio = _NomeCondominio;
            DeOndeVem = _DeOndeVem;
            Cor = _Cor;

            foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    foreach (NumericUpDown Controlo in ControloGroupBoxs.Controls.OfType<NumericUpDown>()) Controlo.Controls[0].Visible = false;

        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validar() == false)
                {

                    if (op == 0)
                    {
                        using (Stream stream = File.OpenRead(dlg.FileName))
                        {
                            buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);

                            string extn = new FileInfo(dlg.FileName).Extension;
                        }

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

                        //Obter ID do Banco
                        int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                        //Condomínios
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Condominios (IDFuncionario, IDMorada, IDBanco, Nome, OrcamentoAnual, IBAN, NumeroFracoes, NumeroAndares, " +
                                "NumeroLojas, NumeroGaragens, NumeroArrecadacoes, NumeroElevadores, SalaCondominio, Foto) VALUES(@IDFuncionario, @IDMorada, @IDBanco, @Nome, @OrcamentoAnual, @IBAN," +
                                " @NumeroFracoes, @NumeroAndares, @NumeroLojas, @NumeroGaragens, @NumeroArrecadacoes, @NumeroElevadores, @SalaCondominio, @Foto)", con);

                            cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                            cmd.Parameters.AddWithValue("@IDMorada", IDMorada);
                            cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                            cmd.Parameters.AddWithValue("@Nome", "Condomínio " + txtMorada.Text.Trim());
                            cmd.Parameters.AddWithValue("@OrcamentoAnual", decimal.Parse(txtOrcamentoAnual.Text.Trim()));
                            cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                            cmd.Parameters.AddWithValue("@NumeroFracoes", NUDFracoes.Text);
                            cmd.Parameters.AddWithValue("@NumeroAndares", NUDAndares.Text);
                            cmd.Parameters.AddWithValue("@NumeroLojas", NUDLojas.Text);
                            cmd.Parameters.AddWithValue("@NumeroGaragens", NUDGaragens.Text);
                            cmd.Parameters.AddWithValue("@NumeroArrecadacoes", NUDArrecadacoes.Text);
                            cmd.Parameters.AddWithValue("@NumeroElevadores", NUDElevadores.Text);
                            cmd.Parameters.AddWithValue("@Foto", buffer);

                            if (CBSalaCondominio.Text == "Sim")
                            {
                                CBSalaCondominio.Items.Clear();
                                CBSalaCondominio.Items.Add(true);
                                CBSalaCondominio.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                CBSalaCondominio.Items.Clear();
                                CBSalaCondominio.Items.Add("Sim");
                                CBSalaCondominio.SelectedIndex = 0;
                            }
                            else
                            {
                                CBSalaCondominio.Items.Clear();
                                CBSalaCondominio.Items.Add(false);
                                CBSalaCondominio.SelectedIndex = 0;
                                cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                CBSalaCondominio.Items.Clear();
                                CBSalaCondominio.Items.Add("Não");
                                CBSalaCondominio.SelectedIndex = 0;
                            }

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        if (DeOndeVem == "Load")
                            MessageBox.Show("Condomínio criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else //EDITAR
                    {
                        if (dlg.FileName != string.Empty)
                        {

                            using (Stream stream = File.OpenRead(dlg.FileName))
                            {
                                buffer = new byte[stream.Length];
                                stream.Read(buffer, 0, buffer.Length);

                                string extn = new FileInfo(dlg.FileName).Extension;
                            }

                            //Obter ID do Banco
                            int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Condominios SET IDFuncionario = @IDFuncionario, IDMorada = @IDMorada, IDBanco = @IDBanco, Nome = @Nome" +
                                    ", OrcamentoAnual = @OrcamentoAnual, IBAN = @IBAN, NumeroFracoes = @NumeroFracoes, NumeroAndares = @NumeroAndares, NumeroLojas = @NumeroLojas," +
                                    " NumeroGaragens = @NumeroGaragens, NumeroArrecadacoes = @NumeroArrecadacoes, NumeroElevadores = @NumeroElevadores, SalaCondominio = @SalaCondominio, Foto = @Foto WHERE(IDCondominio = @IDCondominio)", con);

                                cmd.Parameters.AddWithValue("@IDCondominio", idregisto);
                                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                                cmd.Parameters.AddWithValue("@IDMorada", IDMorada);
                                cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                                cmd.Parameters.AddWithValue("@Nome", "Condomínio " + txtMorada.Text.Trim());
                                cmd.Parameters.AddWithValue("@OrcamentoAnual", decimal.Parse(txtOrcamentoAnual.Text.Trim()));
                                cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                                cmd.Parameters.AddWithValue("@NumeroFracoes", NUDFracoes.Text);
                                cmd.Parameters.AddWithValue("@NumeroAndares", NUDAndares.Text);
                                cmd.Parameters.AddWithValue("@NumeroLojas", NUDLojas.Text);
                                cmd.Parameters.AddWithValue("@NumeroGaragens", NUDGaragens.Text);
                                cmd.Parameters.AddWithValue("@NumeroArrecadacoes", NUDArrecadacoes.Text);
                                cmd.Parameters.AddWithValue("@NumeroElevadores", NUDElevadores.Text);
                                cmd.Parameters.AddWithValue("@Foto", buffer);

                                if (CBSalaCondominio.Text == "Sim")
                                {
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add(true);
                                    CBSalaCondominio.SelectedIndex = 0;
                                    cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add("Sim");
                                    CBSalaCondominio.SelectedIndex = 0;
                                }
                                else
                                {
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add(false);
                                    CBSalaCondominio.SelectedIndex = 0;
                                    cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add("Não");
                                    CBSalaCondominio.SelectedIndex = 0;
                                }

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }

                        }
                        else
                        {
                            //Obter ID do Banco
                            int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Condominios SET IDFuncionario = @IDFuncionario, IDMorada = @IDMorada, IDBanco = @IDBanco, Nome = @Nome" +
                                    ", OrcamentoAnual = @OrcamentoAnual, IBAN = @IBAN, NumeroFracoes = @NumeroFracoes, NumeroAndares = @NumeroAndares, NumeroLojas = @NumeroLojas," +
                                    " NumeroGaragens = @NumeroGaragens, NumeroArrecadacoes = @NumeroArrecadacoes, NumeroElevadores = @NumeroElevadores, SalaCondominio = @SalaCondominio WHERE(IDCondominio = @IDCondominio)", con);

                                cmd.Parameters.AddWithValue("@IDCondominio", idregisto);
                                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                                cmd.Parameters.AddWithValue("@IDMorada", IDMorada);
                                cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                                cmd.Parameters.AddWithValue("@Nome", "Condomínio " + txtMorada.Text.Trim());
                                cmd.Parameters.AddWithValue("@OrcamentoAnual", decimal.Parse(txtOrcamentoAnual.Text.Trim()));
                                cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                                cmd.Parameters.AddWithValue("@NumeroFracoes", NUDFracoes.Text);
                                cmd.Parameters.AddWithValue("@NumeroAndares", NUDAndares.Text);
                                cmd.Parameters.AddWithValue("@NumeroLojas", NUDLojas.Text);
                                cmd.Parameters.AddWithValue("@NumeroGaragens", NUDGaragens.Text);
                                cmd.Parameters.AddWithValue("@NumeroArrecadacoes", NUDArrecadacoes.Text);
                                cmd.Parameters.AddWithValue("@NumeroElevadores", NUDElevadores.Text);

                                if (CBSalaCondominio.Text == "Sim")
                                {
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add(true);
                                    CBSalaCondominio.SelectedIndex = 0;
                                    cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add("Sim");
                                    CBSalaCondominio.SelectedIndex = 0;
                                }
                                else
                                {
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add(false);
                                    CBSalaCondominio.SelectedIndex = 0;
                                    cmd.Parameters.AddWithValue("@SalaCondominio", CBSalaCondominio.Text.Trim());
                                    CBSalaCondominio.Items.Clear();
                                    CBSalaCondominio.Items.Add("Não");
                                    CBSalaCondominio.SelectedIndex = 0;
                                }

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

                        DataTable tabelaFracoes = Utilitarios.FillBy("SELECT * FROM Fracoes WHERE (IDCondominio = '" + idregisto + "')");

                        for (int i = 0; i < tabelaFracoes.Rows.Count; i++)
                        {
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Fracoes SET QuotaMensal = @QuotaMensal WHERE(IDFracao = @IDFracao)", con);

                                cmd.Parameters.AddWithValue("@IDFracao", int.Parse(tabelaFracoes.Rows[i][0].ToString()));
                                cmd.Parameters.AddWithValue("@QuotaMensal", decimal.Parse(txtOrcamentoAnual.Text.Trim()) * (decimal.Parse(tabelaFracoes.Rows[i][5].ToString()) / 1000) / 12);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }

                        bttGuardar.Focus();

                        if (DeOndeVem == "Load")
                            MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
                    }
                    erros.Clear();

                    if (DeOndeVem == "Load")
                    {
                        Clientes.FrmClientes janela = new Clientes.FrmClientes("Condominios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);
                    }
                    else
                    {
                        //depois das alterações é realizado um update. se toda a criação for cancelada é realizado um delete.

                        //Obter ID do Condomínio que foi agora Inserido
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios ORDER BY IDCondominio DESC");
                        int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        erros.Clear();
                        Clientes.FormularioClientes janela = new Clientes.FormularioClientes(0, IDCondominio, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "CriacaoRapida", int.Parse(NUDFracoes.Text.ToString()),Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);
                    }           
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

        private void bttApagarFoto_Click(object sender, EventArgs e)
        {
            try
            {

                string startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Condominio.jpg";
                dlg.FileName = startupPath;
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                pictureBoxFoto.Image = RoundedImage;

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

                if(DeOndeVem != "Load")
                {
                    //APAGA TUDO - DELETES E DPS SIM FAZES ISSO

                    FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
                }
                else
                {
                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Condominios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);
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
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Condominios", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
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
                if (op != 3)
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
                                if (Controlo is TextBox || Controlo is ComboBox || Controlo is NumericUpDown)
                                {
                                    if (Controlo.Text.Trim() != string.Empty)
                                    {
                                        string query = string.Empty;

                                        switch (Controlo.Name)
                                        {

                                            case "txtOrcamentoAnual":
                                                if (Controlo.Text.ToLower().Contains(',')) Controlo.Text = Controlo.Text.Replace(',', '.');
                                                query = "Condominios.OrcamentoAnual";
                                                break;

                                            case "txtIBAN":
                                                query = "Condominios.IBAN";
                                                break;

                                            case "NUDFracoes":
                                                query = "Condominios.NumeroFracoes";
                                                break;

                                            case "NUDAndares":
                                                query = "Condominios.NumeroAndares";
                                                break;

                                            case "NUDLojas":
                                                query = "Condominios.NumeroLojas";
                                                break;

                                            case "NUDGaragens":
                                                query = "Condominios.NumeroGaragens";
                                                break;

                                            case "NUDArrecadacoes":
                                                query = "Condominios.NumeroArrecadacoes";
                                                break;

                                            case "NUDElevadores":
                                                query = "Condominios.NumeroElevadores";
                                                break;

                                            case "CBSalaCondominio":

                                                if (CBSalaCondominio.Text == "Sim")
                                                {
                                                    CBSalaCondominio.Items.Clear();
                                                    CBSalaCondominio.Items.Add(true);
                                                    CBSalaCondominio.SelectedIndex = 0;
                                                }
                                                else
                                                {
                                                    CBSalaCondominio.Items.Clear();
                                                    CBSalaCondominio.Items.Add(false);
                                                    CBSalaCondominio.SelectedIndex = 0;
                                                }

                                                query = "Condominios.SalaCondominio";
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

                    Clientes.FrmClientes janela = new Clientes.FrmClientes("Condominios", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioCondominios_Load(object sender, EventArgs e)
        {
            try
            {

                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme)
                {
                    foreach (GroupBox Controlo in panelCondominio.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelMorada.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);

                }

                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                IPBCondominio.IconColor = Customizar.HexToColor(Cor);
                IPBMorada.IconColor = Customizar.HexToColor(Cor);
                IPBBanco.IconColor = Customizar.HexToColor(Cor);
                lblNome.ForeColor = Customizar.HexToColor(Cor);

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }

                        foreach (NumericUpDown Controlo in ControloGroupBoxs.Controls.OfType<NumericUpDown>()) Controlo.ReadOnly = false;
                    }

                CBSalaCondominio.SelectedIndex = -1;
                txtSalaCondominio.Visible = false;
                CBSalaCondominio.Visible = true;
                erros.Clear();
                labelCondominio.Text = "Condomínio";


                string startupPath = System.IO.Directory.GetCurrentDirectory() + @"\Anonimo.jpg";
                Image RoundedImage = Utilitarios.ClipToCircle(Image.FromFile(startupPath), new PointF(Image.FromFile(startupPath).Width / 2, Image.FromFile(startupPath).Height / 2), Image.FromFile(startupPath).Width / 2);
                pictureBoxFoto.Image = RoundedImage;

                panelFoto.Location = new Point(697, 222);
                panelFoto.Visible = true;
                lblFoto.Visible = true;

                panelMorada.Width = 671;
                panelMorada.Height = 143;
                GBLocalidade.Location = new Point(14, 73);
                bttVoltar.Location = new Point(660, 376);
                bttGuardar.Location = new Point(833, 376);
                bttFiltrar.Location = new Point(833, 376);

                switch (op)
                {
                    //Adicionar
                    case 0:
             
                        lblTitleChildForm.Text = "Adicionar Condomínio";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttApagarFoto.PerformClick();
                        bttGuardar.Focus();
                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                foreach (NumericUpDown Controlo in ControloGroupBoxs.Controls.OfType<NumericUpDown>()) Controlo.ResetText();

                        panelVisualizar.Visible = false;
                        panelDesktop.Visible = true;

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Condomínios";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttFiltrar.Focus();
                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                foreach (NumericUpDown Controlo in ControloGroupBoxs.Controls.OfType<NumericUpDown>()) Controlo.ResetText();

                        panelDesktop.Visible = true;
                        panelVisualizar.Visible = false;
                        panelFoto.Visible = false;
                        lblFoto.Visible = false;

                        panelMorada.Width = 989;
                        panelMorada.Height = 79;
                        GBLocalidade.Location = new Point(666, 18);

                        bttVoltar.Location = new Point(660, 309);
                        bttGuardar.Location = new Point(833, 309);
                        bttFiltrar.Location = new Point(833, 309);

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Condomínio";
                        Editar_Visualizar(2);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        panelDesktop.Visible = true;
                        panelVisualizar.Visible = false;

                        break;

                    //Visualizar
                    case 3:

                        panelVisualizar.Visible = true; 
                        panelVisualiza.Visible = true;
                        //panelDesktop.Visible = false;
                        panelVisualizar.BringToFront();

                        lblTitleChildForm.Text = "Visualizar Condomínio";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>()) Controlo.ReadOnly = true;

                        Editar_Visualizar(3);

                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        bttVoltar.Focus();

                        break;

                }

                if(DeOndeVem == "CriacaoRapida") lblTitleChildForm.Text = "Adicionar Condomínio - Criação Rápida";
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
                DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (IDCondominio = " + idregisto + ")");

                if (tabelaCondominios.Rows.Count == 1)
                {
                    //int IDFuncionario2 = int.Parse(tabelaCondominios.Rows[0][1].ToString());
                    IDMorada = int.Parse(tabelaCondominios.Rows[0][2].ToString());
                    decimal OA = decimal.Parse(tabelaCondominios.Rows[0][5].ToString());
                    txtIBAN.Text = tabelaCondominios.Rows[0][6].ToString();
                    NUDFracoes.Text = tabelaCondominios.Rows[0][7].ToString();
                    NUDAndares.Text = tabelaCondominios.Rows[0][8].ToString();
                    NUDLojas.Text = tabelaCondominios.Rows[0][9].ToString();
                    NUDGaragens.Text = tabelaCondominios.Rows[0][10].ToString();
                    NUDArrecadacoes.Text = tabelaCondominios.Rows[0][11].ToString();
                    NUDElevadores.Text = tabelaCondominios.Rows[0][12].ToString();


                    if (chegueide == 3)
                    {
                        lblNome.Text = tabelaCondominios.Rows[0][4].ToString();
                        lblIBAN.Text = tabelaCondominios.Rows[0][6].ToString();
                        lblfracoes.Text = tabelaCondominios.Rows[0][7].ToString() + " Frações";
                        lblAndares.Text = tabelaCondominios.Rows[0][8].ToString() + " Andares";
                        lblLojas.Text = tabelaCondominios.Rows[0][9].ToString() + " Lojas";
                        lblGaragens.Text = tabelaCondominios.Rows[0][10].ToString() + " Garagens";
                        lblArrecadacoes.Text = tabelaCondominios.Rows[0][11].ToString() + " Arrecadações";
                        lblElevadores.Text = tabelaCondominios.Rows[0][12].ToString() + " Elevadores";
                        txtIBAN.Text = lblIBAN.Text;

                        //Obter o ID do banco                 
                        int IDBanco = Utilitarios.NomeBanco(txtIBAN);
                        DataTable tabelaBanco = Utilitarios.FillBy("SELECT * FROM Bancos WHERE (IDBanco = " + IDBanco + ")");

                        if (tabelaBanco.Rows.Count == 1)
                        {
                            lblBanco.Text = tabelaCondominios.Rows[0][6].ToString();
                        }
                    }

                    //FOTO
                    pictureBoxFoto.Image = Utilitarios.ObterFoto("SELECT * FROM Condominios WHERE (IDCondominio = " + idregisto + ")");
                    PBFoto.Image = pictureBoxFoto.Image;

                    //Editar
                    if (chegueide == 2)
                    {
                        txtOrcamentoAnual.Text = OA.ToString();
                        txtSalaCondominio.Visible = false;
                        CBSalaCondominio.Visible = true;
                        if (tabelaCondominios.Rows[0][13].ToString() == "True") CBSalaCondominio.SelectedIndex = 0; else CBSalaCondominio.SelectedIndex = 1;
                    }
                    //Visualizar
                    else
                    {
                        labelCondominio.Text = tabelaCondominios.Rows[0][4].ToString();
                        txtOrcamentoAnual.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2} €", OA.ToString());
                        lblOrcamentoAnual.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2} €", OA.ToString());
                        txtSalaCondominio.Visible = true;
                        CBSalaCondominio.Visible = false;
                        if (tabelaCondominios.Rows[0][13].ToString() == "True")
                        {
                            txtSalaCondominio.Text = "Sim";
                            lblSalaCondominio.Text = "Sala de Condomínio: Sim";
                        }
                        else
                        {
                            txtSalaCondominio.Text = "Não";
                            lblSalaCondominio.Text = "Sala de Condomínio: Não";
                        }
                    }

                    DataTable tabelaMorada = Utilitarios.FillBy("SELECT * FROM Moradas WHERE(IDMorada = " + IDMorada + ")");

                    if (tabelaMorada.Rows.Count == 1)
                    {
                        txtMorada.Text = tabelaMorada.Rows[0][1].ToString();
                        txtLocalidade.Text = tabelaMorada.Rows[0][2].ToString();
                        txtCP.Text = tabelaMorada.Rows[0][3].ToString();

                        lblMorada.Text = tabelaMorada.Rows[0][1].ToString();
                        lblMorada2.Text = tabelaMorada.Rows[0][3].ToString() + " " + tabelaMorada.Rows[0][2].ToString();
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
            WindowState = FormWindowState.Minimized;
        }

        public bool Validar()
        {
            erros.Clear();

            bool erro = false;
           
            //panelDadosGerais
            foreach (GroupBox Controlo2 in panelCondominio.Controls.OfType<GroupBox>()) foreach (Control Controlo in Controlo2.Controls) if (Controlo is TextBox || Controlo is ComboBox)
                    {

                        if (Controlo.Text.Trim() != string.Empty)
                        {
                            Match Numerosinteiros = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9])?$");

                            if (Controlo.Name.Contains("NUD"))
                            {
                                if (Numerosinteiros.Success == false)
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Introduza somente valores inteiros");
                                }
                            }

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

                                case "txtOrcamentoAnual":

                                    Match Numeros = Regex.Match(Controlo.Text.Trim(), @"^[0-9]+(\,[0-9]{1,2})?$");

                                    if (Numeros.Success == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza corretamente o orçamento anual do condomínio");
                                    }

                                    break;

                                case "txtIBAN":

                                    if (Validacoes.ValidarIBAN(Controlo.Text.Trim()) == false)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Introduza um IBAN válido");
                                    }

                                    break;

                                case "CBSalaCondominio":

                                    if (Controlo.Text.Trim() == string.Empty)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Este campo precisa de ser preenchido");
                                    }

                                    break;

                            }
                        }
                        else
                        {
                            if (Controlo.Name != "txtSalaCondominio" && op != 1)
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

                            case "txtMorada":

                                //Não repetir o nome do condominio
                                if (op != 1)
                                {

                                    DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + Controlo.Text.Trim() + "')");

                                    //Inserir
                                    if (op == 0 && tabelaCondominios.Rows.Count != 0)
                                    {
                                        erro = true;
                                        erros.SetError(Controlo, "Já existe um condomínio registado com este nome");
                                    }

                                    //Editar
                                    if (op == 2 && "Condomínio " + Controlo.Text.Trim() != NomeCondominio.Trim().ToString())
                                    {
                                        if (tabelaCondominios.Rows.Count != 0)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Já existe um condomínio registado com este nome");
                                        }
                                    }
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
    }
}
