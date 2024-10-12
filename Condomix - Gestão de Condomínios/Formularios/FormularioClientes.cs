using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Clientes
{
    public partial class FormularioClientes : Form
    {
        int op, nif, IDContacto, idregisto, IDFuncionario, IDCondominio;
        string Email, query2 = string.Empty, NomeFuncionario, CargoFuncionario, DeOndeVem,Cor;
        Image FotoFuncionario;
        int NClientes, NCliente = 1;
        public FormularioClientes(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _DeOndeVem, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            DeOndeVem = _DeOndeVem;
            Cor =_Cor;

        }

        public FormularioClientes(int _op, int _nif, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _DeOndeVem, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            nif = _nif;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            DeOndeVem = _DeOndeVem;
            Cor = _Cor;
        }

        public FormularioClientes(int _op,int _IDCondominio, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _DeOndeVem, int _NClientes, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            IDCondominio = _IDCondominio;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            DeOndeVem = _DeOndeVem;
            NClientes = _NClientes;
            Cor = _Cor;
  
        }

      

        int x = - 1;
        int y = 0;

        private void bttPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (NCliente != 1 && NCliente <= NClientes)
                {
                    NCliente--;
                    lblTitleChildForm.Text = "Adicionar Cliente (" + NCliente + " de " + NClientes + ") - Criação Rápida";

                    // trazer os campos e editar

                   
                    //Obter ID do cliente anterior

                    using (SqlConnection con = Utilitarios.GetConnection())
                    {
                        con.Open();
                        string FillByNIFCliente = "SELECT * FROM Clientes WHERE IDCliente = (SELECT MAX(IDCliente)-" + y + " FROM Clientes)";

                        SqlDataAdapter adp = new SqlDataAdapter(FillByNIFCliente, con);

                        DataTable tabelaClientes = new DataTable();
                        adp.Fill(tabelaClientes);
                        con.Close();

                        int idregisto = int.Parse(tabelaClientes.Rows[0][0].ToString());
                        txtNIF.Text = tabelaClientes.Rows[0][1].ToString();
                        IDContacto = int.Parse(tabelaClientes.Rows[0][2].ToString());
                        txtNome.Text = tabelaClientes.Rows[0][4].ToString();
                        txtIBAN.Text = tabelaClientes.Rows[0][5].ToString();

                        con.Open();
                        string FillByIDContacto = "SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos WHERE(IDContacto = " + IDContacto + ")";

                        adp = new SqlDataAdapter(FillByIDContacto, con);

                        DataTable tabelaContactos = new DataTable();
                        adp.Fill(tabelaContactos);
                        con.Close();

                        txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                        Email = tabelaContactos.Rows[0][1].ToString();
                        txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                        txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();

                    }
                    x++;
                    y++;
                    MessageBox.Show(x.ToString());

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {

            if (NCliente <= NClientes)
            {
                //Verificar se o NIF já está inserido na BD. Se não estiver é um INSERT e limpar os campos, else trazer os campos e UPDATE

                //Verificar se é pa Inserir na BD ou pa Editar
                //QueryNIFCliente

                if (Validacoes.IsValidContrib(txtNIF.Text.Trim()) == true)
                {

                    using (SqlConnection conn = Utilitarios.GetConnection())
                    {
                        conn.Open();
                        string FillByNIFCliente = "SELECT IDCliente, NIFCliente, IDContacto, IDBanco, Nome, IBAN FROM Clientes WHERE(NIFCliente = " + int.Parse(txtNIF.Text.Trim()) + ")";

                        SqlDataAdapter adps = new SqlDataAdapter(FillByNIFCliente, conn);

                        DataTable tabelaClientes = new DataTable();
                        adps.Fill(tabelaClientes);
                        conn.Close();

                        if (tabelaClientes.Rows.Count != 0)
                        {
                            //Editar
                            op = 2;
                            if (Validar() == false)
                            {
                                //Contactos
                                using (SqlConnection con = Utilitarios.GetConnection())
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE Contactos SET Email = @Email, Contacto = @Contacto, ContactoAlternativo = @ContactoAlternativo WHERE(IDContacto = @Original_IDContacto)", con);

                                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Contacto", int.Parse(txtContacto.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@ContactoAlternativo", int.Parse(txtContactoAlternativo.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@Original_IDContacto", IDContacto);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }

                                //Obter o ID do banco                 
                                int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                                //Clientes
                                using (SqlConnection con = Utilitarios.GetConnection())
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE Clientes SET NIFCliente = @NIFCliente, IDContacto = @IDContacto, IDBanco = @IDBanco, Nome = @Nome, IBAN = @IBAN WHERE(IDCliente = @Original_IDCliente)", con);

                                    cmd.Parameters.AddWithValue("@NIFCliente", int.Parse(txtNIF.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                                    cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                                    cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Original_IDCliente", idregisto);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                MessageBox.Show("Editou");

                                //Limpar campos
                                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                                        {
                                            Controlo.ReadOnly = false;
                                            Controlo.ResetText();
                                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                                        }

                                x--;
                                y--;
                                MessageBox.Show(y.ToString());

                                using (SqlConnection com = Utilitarios.GetConnection())
                                {
                                    com.Open();
                                    string FillByNIFClientesss = "SELECT * FROM Clientes WHERE IDCliente = (SELECT MAX(IDCliente) - " + x + " FROM Clientes )";

                                    SqlDataAdapter adp = new SqlDataAdapter(FillByNIFClientesss, com);

                                    DataTable tabelaClientess = new DataTable();
                                    adp.Fill(tabelaClientess);
                                    com.Close();

                                    if (tabelaClientess.Rows.Count > 0)
                                    {
                                        int idregisto = int.Parse(tabelaClientess.Rows[0][0].ToString());
                                        txtNIF.Text = tabelaClientess.Rows[0][1].ToString();
                                        IDContacto = int.Parse(tabelaClientess.Rows[0][2].ToString());
                                        txtNome.Text = tabelaClientess.Rows[0][4].ToString();
                                        txtIBAN.Text = tabelaClientess.Rows[0][5].ToString();

                                        com.Open();
                                        string FillByIDContacto = "SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos WHERE(IDContacto = " + IDContacto + ")";

                                        adp = new SqlDataAdapter(FillByIDContacto, com);

                                        DataTable tabelaContactos = new DataTable();
                                        adp.Fill(tabelaContactos);
                                        com.Close();

                                        txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                                        Email = tabelaContactos.Rows[0][1].ToString();
                                        txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                                        txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();

                                    }
                                }

                                NCliente++;
                                lblTitleChildForm.Text = "Adicionar Cliente (" + NCliente + " de " + NClientes + ") - Criação Rápida";

                            }
                            else
                            {
                                //Inserir e limpar campos

                                op = 0;
                                if (Validar() == false)
                                {
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
                                    string queryIDContacto = "SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos ORDER BY IDContacto DESC";

                                    using (SqlConnection con = Utilitarios.GetConnection())
                                    {

                                        SqlDataAdapter adp = new SqlDataAdapter(queryIDContacto, con);

                                        DataTable tabela = new DataTable();
                                        adp.Fill(tabela);

                                        IDContacto = int.Parse(tabela.Rows[0][0].ToString());

                                    }

                                    //Obter ID do Banco
                                    int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                                    //Clientes
                                    using (SqlConnection con = Utilitarios.GetConnection())
                                    {
                                        SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (NIFCliente, IDContacto, IDBanco, Nome, IBAN) VALUES(@NIFCliente, @IDContacto, @IDBanco, @Nome, @IBAN)", con);

                                        cmd.Parameters.AddWithValue("@NIFCliente", int.Parse(txtNIF.Text.Trim()));
                                        cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                                        cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                                        cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }

                                    //Limpar campos
                                    foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                                        foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                            foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                                            {
                                                Controlo.ReadOnly = false;
                                                Controlo.ResetText();
                                                Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                                            }

                                    NCliente++;
                                    lblTitleChildForm.Text = "Adicionar Cliente (" + NCliente + " de " + NClientes + ") - Criação Rápida";
                                }
                            }
                        }
                    }

                    //erros.Clear();


                    if (DeOndeVem == "Load")
                    {
                        FrmClientes janela = new FrmClientes("Clientes", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);
                    }
                    else
                    {
                        //ALTERAR PRAS FRAÇOES
                        //depois das alterações é realizado um update. se toda a criação for cancelada é realizado um delete.

                        //Obter ID do Condomínio que foi agora Inserido
                        //DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios ORDER BY IDCondominio DESC");
                        //int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        //Formularios.FormularioFracoes janela = new Formularios.FormularioFracoes(0, IDCondominio, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "CriacaoRapida", int.Parse(NUDFracoes.Value.ToString()));
                        //Utilitarios.ShowForm(janela);
                        //Utilitarios.HideForm(this);
                    }
                }
                else
                {
                    erros.SetError(txtNIF, "Introduza o número de contribuinte");
                }
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

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme)
                {
                    foreach (GroupBox Controlo in panelDadosGerais.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);
                    foreach (GroupBox Controlo in panelContactos.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);

                }

                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }           

                bttVoltar.Location = new Point(376, 463);

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Cliente";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Clientes";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Cliente";
                        Editar_Visualizar();
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Cliente";

                        foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                            foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                                foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                                    Controlo.ReadOnly = true;            

                        Editar_Visualizar();

                        bttVoltar.Location = new Point(549, 463);
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = false;
                        bttVoltar.Focus();

                        break;

                }

                if (DeOndeVem == "CriacaoRapida")
                    lblTitleChildForm.Text = "Adicionar Cliente (" + NCliente + " de " + NClientes + ") - Criação Rápida";
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Editar_Visualizar()
        {
            try
            {
                using (SqlConnection con = Utilitarios.GetConnection())
                {
                    con.Open();
                    string FillByNIFCliente = "SELECT IDCliente, NIFCliente, IDContacto, IDBanco, Nome, IBAN FROM Clientes WHERE(NIFCliente = " + nif + ")";

                    SqlDataAdapter adp = new SqlDataAdapter(FillByNIFCliente, con);

                    DataTable tabelaClientes = new DataTable();
                    adp.Fill(tabelaClientes);
                    con.Close();

                    if (tabelaClientes.Rows.Count == 1)
                    {
                        idregisto = int.Parse(tabelaClientes.Rows[0][0].ToString());
                        txtNIF.Text = tabelaClientes.Rows[0][1].ToString();
                        IDContacto = int.Parse(tabelaClientes.Rows[0][2].ToString());
                        txtNome.Text = tabelaClientes.Rows[0][4].ToString();
                        txtIBAN.Text = tabelaClientes.Rows[0][5].ToString();

                        con.Open();
                        string FillByIDContacto = "SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos WHERE(IDContacto = " + IDContacto + ")";

                        adp = new SqlDataAdapter(FillByIDContacto, con);

                        DataTable tabelaContactos = new DataTable();
                        adp.Fill(tabelaContactos);
                        con.Close();

                        txtEmail.Text = tabelaContactos.Rows[0][1].ToString();
                        Email = tabelaContactos.Rows[0][1].ToString();
                        txtContacto.Text = tabelaContactos.Rows[0][2].ToString();
                        txtContactoAlternativo.Text = tabelaContactos.Rows[0][3].ToString();

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

                    if (op == 0) //Inserir
                    {

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
                        string queryIDContacto = "SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos ORDER BY IDContacto DESC";

                        using (SqlConnection con = Utilitarios.GetConnection())
                        {

                            SqlDataAdapter adp = new SqlDataAdapter(queryIDContacto, con);

                            DataTable tabela = new DataTable();
                            adp.Fill(tabela);

                            IDContacto = int.Parse(tabela.Rows[0][0].ToString());

                        }

                        //Obter ID do Banco
                        int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                        //Clientes
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (NIFCliente, IDContacto, IDBanco, Nome, IBAN) VALUES(@NIFCliente, @IDContacto, @IDBanco, @Nome, @IBAN)", con);

                            cmd.Parameters.AddWithValue("@NIFCliente", int.Parse(txtNIF.Text.Trim()));
                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Cliente adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else  //Editar
                    {

                        //Contactos
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Contactos SET Email = @Email, Contacto = @Contacto, ContactoAlternativo = @ContactoAlternativo WHERE(IDContacto = @Original_IDContacto)", con);

                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contacto", int.Parse(txtContacto.Text.Trim()));
                            cmd.Parameters.AddWithValue("@ContactoAlternativo", int.Parse(txtContactoAlternativo.Text.Trim()));
                            cmd.Parameters.AddWithValue("@Original_IDContacto", IDContacto);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        //Obter o ID do banco                 
                        int IDBanco = Utilitarios.NomeBanco(txtIBAN);

                        //Clientes
                        using (SqlConnection con = Utilitarios.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Clientes SET NIFCliente = @NIFCliente, IDContacto = @IDContacto, IDBanco = @IDBanco, Nome = @Nome, IBAN = @IBAN WHERE(IDCliente = @Original_IDCliente)", con);

                            cmd.Parameters.AddWithValue("@NIFCliente", int.Parse(txtNIF.Text.Trim()));
                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                            cmd.Parameters.AddWithValue("@Original_IDCliente", idregisto);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Cliente editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    erros.Clear();

                    FrmClientes janela = new FrmClientes("Clientes", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                    Utilitarios.ShowForm(janela);
                    Utilitarios.HideForm(this);

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
                FrmClientes janela = new FrmClientes("Clientes", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
                    query2 = string.Empty;

                    foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    {
                        foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                        {
                            foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                            {
                                if (Controlo.Text.Trim() != string.Empty)
                                {
                                    string query = string.Empty;

                                    switch (Controlo.Name)
                                    {

                                        case "txtNIF":
                                            query = "Clientes.NIFCliente";
                                            break;

                                        case "txtNome":
                                            query = "Clientes.Nome";
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

                                        case "txtIBAN":
                                            query = "Clientes.IBAN";
                                            break;

                                    }

                                    query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                }
                            }
                        }
                    }

                    FrmClientes janela = new FrmClientes("Clientes", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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

            //Painel Dados Gerais
            foreach (GroupBox Controlo2 in panelDadosGerais.Controls.OfType<GroupBox>())
            {
                foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
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
                                        //QueryNIFCliente
                                        using (SqlConnection con = Utilitarios.GetConnection())
                                        {
                                            con.Open();
                                            string FillByNIFCliente = "SELECT IDCliente, NIFCliente, IDContacto, IDBanco, Nome, IBAN FROM Clientes WHERE(NIFCliente = " + int.Parse(Controlo.Text.Trim()) + ")";

                                            SqlDataAdapter adp = new SqlDataAdapter(FillByNIFCliente, con);

                                            DataTable tabelaClientes = new DataTable();
                                            adp.Fill(tabelaClientes);
                                            con.Close();

                                            //Inserir
                                            if (op == 0 && tabelaClientes.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este NIF já pertence a outro cliente");
                                            }

                                            //Editar
                                            if (op==2 && Controlo.Text.Trim() != nif.ToString())
                                            {
                                                if (tabelaClientes.Rows.Count != 0)
                                                {
                                                    erro = true;
                                                    erros.SetError(Controlo, "Este NIF já pertence a outro cliente");
                                                }
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

                            case "txtIBAN":

                                if (Validacoes.ValidarIBAN(Controlo.Text.Trim()) == false)
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Introduza um IBAN válido");
                                }

                                break;
                        }
                    }
                    else
                    {
                        //Validar Campos vazios
                        if (op != 1)
                        {
                            erro = true;
                            string str = Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Substring(Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Length - 1);
                            if (str.Trim() == "a") str = "Introduza uma "; else str = "Introduza um ";

                            erros.SetError(Controlo, str + Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2"));
                        }
                    }
                }
            }

            //painel Contactos
            foreach (GroupBox Controlo2 in panelContactos.Controls.OfType<GroupBox>())
            {
                foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
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
                                            erros.SetError(Controlo, "Este Email pertence a outro cliente");
                                        }

                                        //Editar
                                        if (op == 2 && Controlo.Text.Trim() != Email.ToString())
                                        {
                                            if (tabelaContactos.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este Email pertence a outro cliente");
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
                        //Validar campos vazios
                        if (op != 1)
                        {
                            erro = true;
                            string str = Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Substring(Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Length - 1);
                            if (str.Trim() == "a") str = "Introduza uma "; else str = "Introduza um ";

                            erros.SetError(Controlo, str + Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2"));
                        }
                    }
                }
            }

            return erro;
        }
    }

}

