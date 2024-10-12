using Condomix___Gestão_de_Condomínios.Clientes;
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
    public partial class FormularioFornecedores : Form
    {
        int op, idregisto, IDContacto, IDFuncionario;
        string Email, query2 = string.Empty, NomeFuncionario, CargoFuncionario, NomeFornecedor, Cor;
        Image FotoFuncionario;

        public FormularioFornecedores(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioFornecedores(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _NomeFornecedor, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            NomeFornecedor = _NomeFornecedor;
            Cor = _Cor;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                                        case "txtNome":
                                            query = "Fornecedores.Nome";
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
                                            query = "Fornecedores.IBAN";
                                            break;

                                    }

                                    query2 += " and (" + query + " = '" + Controlo.Text + "')";
                                }
                            }
                        }
                    }

                    FrmClientes janela = new FrmClientes("Fornecedores", 1, query2, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                erros.Clear();
                FrmClientes janela = new FrmClientes("Fornecedores", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioFornecedores_Load(object sender, EventArgs e)
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

                bttVoltar.Location = new Point(376, 406);

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Fornecedor";
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                    //Consultar
                    case 1:

                        lblTitleChildForm.Text = "Consultar Fornecedores";
                        bttFiltrar.Visible = true;
                        bttGuardar.Visible = false;
                        bttFiltrar.Focus();

                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Fornecedor";
                        Editar_Visualizar();
                        bttFiltrar.Visible = false;
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                    //Visualizar
                    case 3:

                        lblTitleChildForm.Text = "Visualizar Fornecedor";

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

                        Editar_Visualizar();

                        bttVoltar.Location = new Point(549, 406);
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

        private void Editar_Visualizar()
        {
            try
            {
                using (SqlConnection con = Utilitarios.GetConnection())
                {

                    DataTable tabelaFornecedores = Utilitarios.FillBy("SELECT * FROM Fornecedores WHERE(IDFornecedor = " + idregisto + ")");

                    if (tabelaFornecedores.Rows.Count == 1)
                    {
                        idregisto = int.Parse(tabelaFornecedores.Rows[0][0].ToString());
                        IDContacto = int.Parse(tabelaFornecedores.Rows[0][1].ToString());
                        txtNome.Text = tabelaFornecedores.Rows[0][3].ToString();
                        txtIBAN.Text = tabelaFornecedores.Rows[0][4].ToString();

                        DataTable tabelaContactos = Utilitarios.FillBy("SELECT IDContacto, Email, Contacto, ContactoAlternativo FROM Contactos WHERE(IDContacto = " + IDContacto + ")");

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
                            SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedores (IDContacto, IDBanco, Nome, IBAN) VALUES(@IDContacto, @IDBanco, @Nome, @IBAN)", con);

                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Fornecedor adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            SqlCommand cmd = new SqlCommand("UPDATE Fornecedores SET IDContacto = @IDContacto, IDBanco = @IDBanco, Nome = @Nome, IBAN = @IBAN WHERE(IDFornecedor = @IDFornecedor)", con);

                            cmd.Parameters.AddWithValue("@IDContacto", IDContacto);
                            cmd.Parameters.AddWithValue("@IDBanco", IDBanco);
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                            cmd.Parameters.AddWithValue("@IBAN", txtIBAN.Text.Trim());
                            cmd.Parameters.AddWithValue("@IDFornecedor", idregisto);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Fornecedor editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    erros.Clear();

                    FrmClientes janela = new FrmClientes("Fornecedores", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
   
                            case "txtNome":

                                Match Nome = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                if (Nome.Success == false)
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Introduza corretamente o Nome");
                                }
                                else
                                {
                                    //Não repetir o nome do fornecedor
                                    if (op != 1)
                                    {
                                        DataTable tabelaFornecedores = Utilitarios.FillBy("SELECT * FROM Fornecedores WHERE (Nome = '" + Controlo.Text.Trim() + "')");

                                        //Inserir
                                        if (op == 0 && tabelaFornecedores.Rows.Count != 0)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Já existe um fornecedor registado com este nome");
                                        }

                                        //Editar
                                        if (op == 2 && Controlo.Text.Trim() != NomeFornecedor.Trim().ToString())
                                        {
                                            if (tabelaFornecedores.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Já existe um fornecedor registado com este nome");
                                            }
                                        }
                                    }
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
                                            erros.SetError(Controlo, "Este Email pertence a outro fornecedor");
                                        }

                                        //Editar
                                        if (op == 2 && Controlo.Text.Trim() != Email.ToString())
                                        {
                                            if (tabelaContactos.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Este Email pertence a outro fornecedor");
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
