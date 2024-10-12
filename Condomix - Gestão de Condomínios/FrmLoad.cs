using FontAwesome.Sharp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Clientes
{
    public partial class FrmClientes : Form
    {

        int NPaginas, Npagina = 1, num = 0, NRegistosPorPagina = 10, op, nif, IDFuncionario;
        string query2 = string.Empty;
        string Modulo, NomeFuncionario, CargoFuncionario,Cor;
        Image FotoFuncionario;

        public FrmClientes(string _Modulo, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Modulo = _Modulo;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;

            Inicio();

        }

        public FrmClientes(string _Modulo, int _op, string _query2, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Modulo = _Modulo;
            op = _op;
            query2 = _query2;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            Cor = _Cor;

            Npagina = 1;
            num = 0;

            Inicio();

        }

        //Mapa de Pagamentos - Vem dos Pagamentos
        int Ano;
        string cbCondominio;

        public FrmClientes(string _Modulo, int _Ano, string _cbCondominio, int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Modulo = _Modulo;
            Ano = _Ano;
            cbCondominio = _cbCondominio;
            op = _op;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            Cor = _Cor;

        }

        private void Inicio()
        {
            try
            {
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.AllowUserToResizeColumns = false;
                dgv.AllowUserToResizeRows = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv.BackgroundColor = Color.Black;
                dgv.BorderStyle = BorderStyle.None;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.Dock = DockStyle.Fill;
                dgv.EnableHeadersVisualStyles = false;
                dgv.Location = new Point(0, 0);
                dgv.MultiSelect = false;
                dgv.ReadOnly = true;
                dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.RowHeadersVisible = false;
                dgv.RowHeadersWidth = 50;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.Size = new Size(1623, 720);
                dgv.TabIndex = 0;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = Customizar.HexToColor(Cor);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Customizar.HexToColor(Cor);
                dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);
                dgv.EnableHeadersVisualStyles = false;

                dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                dgv.RowsDefaultCellStyle.SelectionBackColor = Customizar.HexToColor(Cor);
                dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);

                dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

                dgv.RowTemplate.Height = 30;

                dgv.GridColor = Customizar.HexToColor(Cor);
                dgv.RowsDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 13, FontStyle.Bold);

                panelNavigation.Visible = true;

                switch (Modulo)
                {
                    case "Clientes":

                        iconCurrentChildForm.IconChar = IconChar.UserFriends;
                        lblTitleChildForm.Text = "Clientes";

                        Colunas("NIF");
                        Colunas("Nome");
                        Colunas("Email");
                        Colunas("Contacto");
                        Colunas("Contacto Alternativo");
                        Colunas("IBAN");
                        Colunas("Nome do Banco");

                        break;

                    case "Funcionarios":

                        iconCurrentChildForm.IconChar = IconChar.PeopleCarry;
                        lblTitleChildForm.Text = "Funcionários";

                        Colunas("NIF", 145);
                        Colunas("Nome", 146);
                        Colunas("Cargo", 146);
                        Colunas("Email");
                        Colunas("Contacto", 146);
                        Colunas("Contacto Alternativo", 220);
                        Colunas("Morada");
                        Colunas("Localidade", 146);
                        Colunas("Código Postal", 146);

                        break;

                    case "Condominios":

                        iconCurrentChildForm.IconChar = IconChar.Building;
                        lblTitleChildForm.Text = "Condomínios";

                        Colunas("ID", 30);
                        Colunas("Nome");
                        Colunas("Orçamento Anual", 250);
                        Colunas("IBAN", 220);
                        Colunas("Banco", 185);
                        Colunas("Localidade", 146);
                        Colunas("Código Postal", 146);

                        break;

                    case "Fracoes":

                        iconCurrentChildForm.IconChar = IconChar.HouseUser;
                        lblTitleChildForm.Text = "Frações";

                        Colunas("ID", 30);
                        Colunas("Fração", 65);
                        Colunas("Condomínio");
                        Colunas("Tipo de Fração", 180);
                        Colunas("Permilagem", 200);
                        Colunas("Quota Mensal", 200);
                        Colunas("NIF do Cliente", 145);
                        Colunas("Nome do Cliente", 180);

                        break;

                    case "Pagamentos":

                        iconCurrentChildForm.IconChar = IconChar.Coins;
                        lblTitleChildForm.Text = "Pagamentos";

                        Colunas("ID", 30);
                        Colunas("Fração", 70);
                        Colunas("Condomínio");
                        Colunas("Tipo de Pagamento", 180);
                        Colunas("Valor", 100);
                        Colunas("Data", 170);

                        break;

                    case "Atas":

                        iconCurrentChildForm.IconChar = IconChar.BookReader;
                        lblTitleChildForm.Text = "Atas";

                        Colunas("ID", 30);
                        Colunas("Nome", 160);
                        Colunas("Condomínio");
                        Colunas("Documento", 700);
                        Colunas("Data", 170);

                        break;

                    case "Fornecedores":

                        iconCurrentChildForm.IconChar = IconChar.Truck;
                        lblTitleChildForm.Text = "Fornecedores";

                        Colunas("ID", 30);
                        Colunas("Fornecedor");
                        Colunas("Email", 300);
                        Colunas("Contacto", 146);
                        Colunas("Contacto Alternativo", 200);
                        Colunas("IBAN", 220);
                        Colunas("Banco", 185);

                        break;

                    case "Contratos":

                        iconCurrentChildForm.IconChar = IconChar.FileSignature;
                        lblTitleChildForm.Text = "Contratos";

                        Colunas("ID", 30);
                        Colunas("Contrato");
                        Colunas("Data de Início", 170);
                        Colunas("Valor", 170);
                        Colunas("Fornecedor", 200);

                        break;

                    case "Ocorrencias":

                        iconCurrentChildForm.IconChar = IconChar.Book;
                        lblTitleChildForm.Text = "Ocorrências";

                        Colunas("ID", 30);
                        Colunas("Fração", 65);
                        Colunas("Condomínio");
                        Colunas("Título");
                        Colunas("Data Limite de Resolução", 250);
                        Colunas("Estado", 170);

                        break;

                    case "Vistorias":

                        iconCurrentChildForm.IconChar = IconChar.ClipboardList;
                        lblTitleChildForm.Text = "Vistorias";

                        Colunas("ID", 30);
                        Colunas("Condomínio");
                        Colunas("Título");
                        Colunas("NIF do Funcionário", 200);
                        Colunas("Funcionário", 146);
                        Colunas("Data", 170);

                        break;

                    case "Cargos":

                        iconCurrentChildForm.IconChar = IconChar.Briefcase;
                        lblTitleChildForm.Text = "Cargos dos Funcionários";

                        Colunas("ID", 30);
                        Colunas("Cargo");
                        Colunas("Módulos");

                        break;

                    case "MapaPagamentos":

                        iconCurrentChildForm.IconChar = IconChar.Map;
                        lblTitleChildForm.Text = "Mapa de Pagamentos de " + Ano + " - Condomínio " + cbCondominio;

                        Colunas("Frações");
                        for (int i = 1; i <= 12; i++)
                            Colunas(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i)));

                        break;

                }

                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);
                bttHome.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Colunas(string Nome, int Width)
        {
            DataGridViewTextBoxColumn Coluna = new DataGridViewTextBoxColumn();
            if (Nome == "Quota Mensal" || Nome == "Permilagem" || Nome == "Orçamento Anual" || Nome == "Valor") Coluna.DefaultCellStyle.Format = "C2";
            Coluna.DataPropertyName = Nome;
            Coluna.HeaderText = Nome;
            Coluna.Name = Nome;
            Coluna.ReadOnly = true;

            Coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Coluna.Width = Width;

            dgv.Columns.Add(Coluna);

        }

        private void Colunas(string Nome)
        {
            DataGridViewTextBoxColumn Coluna = new DataGridViewTextBoxColumn();
            if (Nome == "Quota Mensal" || Nome == "Permilagem" || Nome == "Orçamento Anual" || Nome == "Valor") Coluna.DefaultCellStyle.Format = "C2";
            Coluna.DataPropertyName = Nome;
            Coluna.HeaderText = Nome;
            Coluna.Name = Nome;
            Coluna.ReadOnly = true;

            Coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns.Add(Coluna);

        }

        private void Loads()
        {
            try
            {
                string query = string.Empty, querycount = string.Empty;

                switch (Modulo)
                {
                    case "Clientes":

                        //Isto é a tableview
                        query = "SELECT Clientes.NIFCliente AS NIF, Clientes.Nome, Contactos.Email, Contactos.Contacto, Contactos.ContactoAlternativo AS [Contacto Alternativo], Clientes.IBAN, Bancos.Nome AS [Nome do Banco] FROM Clientes "
                                      + "INNER JOIN Contactos ON Clientes.IDContacto = Contactos.IDContacto INNER JOIN Bancos ON Clientes.IDBanco = Bancos.IDBanco";

                        querycount = "SELECT COUNT(*) FROM Clientes INNER JOIN Contactos ON Clientes.IDContacto = Contactos.IDContacto INNER JOIN Bancos ON Clientes.IDBanco = Bancos.IDBanco ";

                        break;

                    case "Funcionarios":

                        query = "SELECT Funcionarios.NIFFuncionario AS NIF,Funcionarios.Nome, Cargos.Cargo, Contactos.Email, Contactos.Contacto, Contactos.ContactoAlternativo AS [Contacto Alternativo], Moradas.Morada, Moradas.Localidade, Moradas.CodigoPostal AS [Código Postal]" +
                   " FROM Cargos INNER JOIN Funcionarios ON Cargos.IDCargo = Funcionarios.IDCargo INNER JOIN Contactos ON Funcionarios.IDContacto = Contactos.IDContacto INNER JOIN " +
                   "Moradas ON Funcionarios.IDMorada = Moradas.IDMorada";

                        querycount = "SELECT COUNT(*) FROM Cargos INNER JOIN Funcionarios ON Cargos.IDCargo = Funcionarios.IDCargo INNER JOIN Contactos ON Funcionarios.IDContacto = Contactos.IDContacto INNER JOIN " +
                           "Moradas ON Funcionarios.IDMorada = Moradas.IDMorada";

                        break;

                    case "Condominios":

                        query = "SELECT Condominios.IDCondominio AS ID, Condominios.Nome AS Nome, Condominios.OrcamentoAnual AS [Orçamento Anual], Condominios.IBAN AS IBAN, Bancos.Nome AS Banco, Moradas.Localidade AS Localidade, Moradas.CodigoPostal AS [Código Postal] FROM Bancos " +
                            " INNER JOIN Condominios ON Bancos.IDBanco = Condominios.IDBanco" +
                            " INNER JOIN Funcionarios ON Condominios.IDFuncionario = Funcionarios.IDFuncionario" +
                            " INNER JOIN Moradas ON Condominios.IDMorada = Moradas.IDMorada";

                        querycount = "SELECT COUNT(*) FROM Bancos INNER JOIN Condominios ON Bancos.IDBanco = Condominios.IDBanco INNER JOIN Funcionarios ON Condominios.IDFuncionario = Funcionarios.IDFuncionario INNER JOIN Moradas ON Condominios.IDMorada = Moradas.IDMorada";

                        break;

                    case "Fracoes":

                        query = "SELECT Fracoes.IDFracao AS ID, Fracoes.NomeFracao AS Fração, Condominios.Nome AS Condomínio, Fracoes.TipoFracao AS [Tipo de Fração], Fracoes.Permilagem AS Permilagem, " +
                            "Fracoes.QuotaMensal AS[Quota Mensal], Clientes.NIFCliente AS[NIF do Cliente], Clientes.Nome AS[Nome do Cliente]" +
                            "FROM Clientes INNER JOIN Fracoes ON Clientes.IDCliente = Fracoes.IDCliente INNER JOIN Condominios ON Fracoes.IDCondominio = Condominios.IDCondominio";

                        querycount = "SELECT COUNT(*) FROM Clientes INNER JOIN Fracoes ON Clientes.IDCliente = Fracoes.IDCliente INNER JOIN Condominios ON Fracoes.IDCondominio = Condominios.IDCondominio";

                        break;

                    case "Pagamentos":

                        query = "SELECT Pagamentos.IDPagamento AS ID, Fracoes.NomeFracao AS Fração, Condominios.Nome AS Condomínio, Pagamentos.TipoPagamento AS [Tipo de Pagamento], Pagamentos.Valor AS Valor, Pagamentos.DataPagamento AS Data " +
                            "FROM Condominios INNER JOIN Fracoes ON Condominios.IDCondominio = Fracoes.IDCondominio INNER JOIN Funcionarios ON Condominios.IDFuncionario = Funcionarios.IDFuncionario " +
                            "INNER JOIN Pagamentos ON Fracoes.IDFracao = Pagamentos.IDFracao AND Funcionarios.IDFuncionario = Pagamentos.IDFuncionario";

                        querycount = "SELECT COUNT(*) FROM Condominios INNER JOIN Fracoes ON Condominios.IDCondominio = Fracoes.IDCondominio INNER JOIN Funcionarios ON Condominios.IDFuncionario = Funcionarios.IDFuncionario " +
                            "INNER JOIN Pagamentos ON Fracoes.IDFracao = Pagamentos.IDFracao AND Funcionarios.IDFuncionario = Pagamentos.IDFuncionario";

                        break;

                    case "Atas":

                        query = "SELECT Atas.IDAta AS ID, Atas.Nome AS Nome, Condominios.Nome AS Condomínio, Documentos.Nome AS Documento, Atas.Data AS Data FROM Atas " +
                            "INNER JOIN Condominios ON Atas.IDCondominio = Condominios.IDCondominio " +
                            "INNER JOIN Documentos ON Atas.IDDocumento = Documentos.IDDocumento";

                        querycount = "SELECT COUNT(*) FROM Atas INNER JOIN Condominios ON Atas.IDCondominio = Condominios.IDCondominio INNER JOIN Documentos ON Atas.IDDocumento = Documentos.IDDocumento";

                        break;

                    case "Fornecedores":

                        query = "SELECT Fornecedores.IDFornecedor AS ID, Fornecedores.Nome AS Fornecedor, Contactos.Email AS Email, Contactos.Contacto AS Contacto, Contactos.ContactoAlternativo AS [Contacto Alternativo], Fornecedores.IBAN AS IBAN, Bancos.Nome AS Banco " +
                            "FROM Fornecedores INNER JOIN Bancos ON Fornecedores.IDBanco = Bancos.IDBanco INNER JOIN Contactos ON Fornecedores.IDContacto = Contactos.IDContacto";

                        querycount = "SELECT COUNT(*) FROM Fornecedores INNER JOIN Bancos ON Fornecedores.IDBanco = Bancos.IDBanco INNER JOIN Contactos ON Fornecedores.IDContacto = Contactos.IDContacto";

                        break;

                    case "Contratos":

                        query = "SELECT Contratos.IDContrato AS ID, Contratos.Titulo AS Contrato, Contratos.DataInicio AS [Data de Início], Contratos.Valor AS Valor, Fornecedores.Nome AS Fornecedor " +
                            "FROM Fornecedores INNER JOIN Contratos ON Fornecedores.IDFornecedor = Contratos.IDFornecedor INNER JOIN Funcionarios ON Contratos.IDFuncionario = Funcionarios.IDFuncionario " +
                            "INNER JOIN Documentos ON Contratos.IDDocumento = Documentos.IDDocumento";

                        querycount = "SELECT COUNT(*) FROM Fornecedores INNER JOIN Contratos ON Fornecedores.IDFornecedor = Contratos.IDFornecedor " +
                            "INNER JOIN Funcionarios ON Contratos.IDFuncionario = Funcionarios.IDFuncionario INNER JOIN Documentos ON Contratos.IDDocumento = Documentos.IDDocumento";

                        break;

                    case "Ocorrencias":

                        query = "SELECT Ocorrencias.IDOcorrencia AS ID, Fracoes.NomeFracao AS Fração, Condominios.Nome AS Condomínio, Ocorrencias.Titulo AS Título, Ocorrencias.DataLimiteResolucao AS [Data Limite de Resolução], Ocorrencias.Estado AS Estado " +
                            "FROM Fracoes INNER JOIN Ocorrencias ON Fracoes.IDFracao = Ocorrencias.IDFracao INNER JOIN Condominios ON Fracoes.IDCondominio = Condominios.IDCondominio";

                        querycount = "SELECT COUNT(*) FROM Fracoes INNER JOIN Ocorrencias ON Fracoes.IDFracao = Ocorrencias.IDFracao INNER JOIN Condominios ON Fracoes.IDCondominio = Condominios.IDCondominio";

                        break;

                    case "Vistorias":

                        query = "SELECT Vistorias.IDVistoria AS ID, Condominios.Nome AS Condomínio, Vistorias.Titulo AS Título, Funcionarios.NIFFuncionario AS [NIF do Funcionário], Funcionarios.Nome AS Funcionário, Vistorias.Data AS Data " +
                            "FROM Vistorias INNER JOIN Condominios ON Vistorias.IDCondominio = Condominios.IDCondominio INNER JOIN Funcionarios ON Vistorias.IDFuncionario = Funcionarios.IDFuncionario";

                        querycount = "SELECT COUNT(*) FROM Vistorias INNER JOIN Condominios ON Vistorias.IDCondominio = Condominios.IDCondominio INNER JOIN Funcionarios ON Vistorias.IDFuncionario = Funcionarios.IDFuncionario";

                        break;

                    case "Cargos":

                        query = "SELECT Cargos.IDCargo AS ID, Cargos.Cargo AS Cargo, Cargos.Modulos AS Módulos " +
                            "FROM Cargos";

                        querycount = "SELECT COUNT(*) FROM Cargos";

                        break;

                    case "MapaPagamentos":

                        //Obter ID do condomínio
                        DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Trim() + "')");
                        int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                        query = "SELECT IDFracao FROM Fracoes WHERE(IDCondominio = '" + IDCondominio + "')";

                        querycount = "SELECT COUNT(*) FROM Fracoes WHERE(IDCondominio = '" + IDCondominio + "')";

                        break;

                }

                var tuplo = Utilitarios.Loads(num, Npagina, dgv, query, querycount, query2, op, NRegistosPorPagina);
                lblPagina.Text = tuplo.Item1;
                Npagina = tuplo.Item2;
                NPaginas = tuplo.Item3;
                int Nregistos = tuplo.Item4;

                if (Nregistos == 1) lblCount.Text = tuplo.Item4.ToString() + " Registo"; else lblCount.Text = tuplo.Item4.ToString() + " Registos";

                if (Modulo == "Ocorrencias")
                    for (int i = 0; i < dgv.Rows.Count; i++)
                        switch (dgv[5, i].Value.ToString())
                        {
                            case "Em Resolução":
                                dgv[5, i].Style.ForeColor = Color.FromArgb(251, 255, 0);
                                break;

                            case "Pendente":
                                dgv[5, i].Style.ForeColor = Color.FromArgb(251, 255, 0);
                                break;

                            case "Aberto":
                                dgv[5, i].Style.ForeColor = Color.FromArgb(0, 255, 34);
                                break;
                        }

                if (Modulo == "MapaPagamentos")
                {
                    dgv.DataSource = null;

                    Inicio();

                    //Obter ID do condomínio
                    DataTable tabelaCondominios = Utilitarios.FillBy("SELECT * FROM Condominios WHERE (Nome = 'Condomínio " + cbCondominio.Trim() + "')");
                    int IDCondominio = int.Parse(tabelaCondominios.Rows[0][0].ToString());

                    //Frações
                    DataTable tabelaFracoes = Utilitarios.FillBy("SELECT IDFracao, NomeFracao, QuotaMensal FROM Fracoes WHERE (IDCondominio = '" + IDCondominio + "') ORDER BY NomeFracao");

                    if (tabelaFracoes.Rows.Count != 0)
                    {
                        for (int i = 0; i < tabelaFracoes.Rows.Count; i++)
                        {
                            string[] Estado = { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };

                            int IDFracao = int.Parse(tabelaFracoes.Rows[i][0].ToString());
                            string NomeFracao = tabelaFracoes.Rows[i][1].ToString();

                            for (int i3 = 1; i3 <= 12; i3++)
                            {
                                //Pagamentos
                                DataTable tabelaPagamentos = new DataTable();
                                tabelaPagamentos.Clear();
                                tabelaPagamentos = Utilitarios.FillBy("SELECT IDPagamento, Valor, PeriodoQuota FROM Pagamentos WHERE (IDFracao = " + IDFracao + ") AND (TipoPagamento = 'Pagamento da Quota') AND (PeriodoQuota = '" + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i3) + " " + Ano + "')");

                                if (tabelaPagamentos.Rows.Count != 0)
                                {
                                    decimal QuotaMensal = decimal.Parse(tabelaFracoes.Rows[i][2].ToString());
                                    decimal Valor = 0;

                                    for (int i2 = 0; i2 < tabelaPagamentos.Rows.Count; i2++)
                                    {
                                        Valor += decimal.Parse(tabelaPagamentos.Rows[i2][1].ToString());

                                        if (i2 == tabelaPagamentos.Rows.Count - 1)
                                            if (Valor >= QuotaMensal) Estado[i3 - 1] = "Pago"; else Estado[i3 - 1] = "Pago Parcialmente";
                                    }
                                }
                            }

                            for (int contador = 0; contador < int.Parse(DateTime.Today.Month.ToString()); contador++)
                                if (Estado[contador] == string.Empty) Estado[contador] = "Por Pagar";

                            dgv.Rows.Add(NomeFracao, Estado[0], Estado[1], Estado[2], Estado[3], Estado[4], Estado[5], Estado[6], Estado[7], Estado[8], Estado[9], Estado[10], Estado[11]);

                            dgv.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Loads();

            if (Modulo== "Cargos")
            {
                bttConsultar.Visible = false;
                bttVisualizar.Visible = false;
                bttRemover.Visible = true;
            }
            else
            {
                bttConsultar.Visible = true;
                bttVisualizar.Visible = true;
                bttRemover.Visible = false;
            }

            if (Modulo == "Funcionarios") bttCargos.Visible = true; else bttCargos.Visible = false;
            if (Modulo == "Condominios") bttAtas.Visible = true; else bttAtas.Visible = false;

            //Pintar com a cor  
            bttAtas.IconColor = Customizar.HexToColor(Cor);
            bttCargos.IconColor = Customizar.HexToColor(Cor);
        }


        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Modulo)
                {
                    case "Clientes":

                        FormularioClientes janela = new FormularioClientes(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);
                        break;

                    case "Funcionarios":

                        Formularios.FormularioFuncionarios janela2 = new Formularios.FormularioFuncionarios(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela2);
                        Utilitarios.HideForm(this);

                        break;

                    case "Condominios":

                        Formularios.FormularioCondominios janela3 = new Formularios.FormularioCondominios(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                        Utilitarios.ShowForm(janela3);
                        Utilitarios.HideForm(this);

                        break;

                    case "Fracoes":

                        Formularios.FormularioFracoes janela4 = new Formularios.FormularioFracoes(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela4);
                        Utilitarios.HideForm(this);

                        break;

                    case "Pagamentos":

                        Formularios.FormularioPagamentos janela5 = new Formularios.FormularioPagamentos(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela5);
                        Utilitarios.HideForm(this);
                        break;

                    case "Atas":

                        Formularios.FormularioAtas janela6 = new Formularios.FormularioAtas(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela6);
                        Utilitarios.HideForm(this);
                        break;

                    case "Vistorias":

                        Formularios.FormularioVistorias janela7 = new Formularios.FormularioVistorias(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela7);
                        Utilitarios.HideForm(this);
                        break;

                    case "Ocorrencias":

                        Formularios.FormularioOcorrencias janela8 = new Formularios.FormularioOcorrencias(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela8);
                        Utilitarios.HideForm(this);
                        break;

                    case "Fornecedores":

                        Formularios.FormularioFornecedores janela9 = new Formularios.FormularioFornecedores(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela9);
                        Utilitarios.HideForm(this);
                        break;

                    case "Contratos":

                        Formularios.FormularioContratos janela10 = new Formularios.FormularioContratos(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela10);
                        Utilitarios.HideForm(this);
                        break;

                    case "Cargos":

                        Formularios.FormularioCargos janela11 = new Formularios.FormularioCargos(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela11);
                        Utilitarios.HideForm(this);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
                {
                    int Linha = dgv.CurrentRow.Index;
                    nif = int.Parse(dgv[0, Linha].Value.ToString());
                    int idregisto = int.Parse(dgv[0, Linha].Value.ToString());

                    switch (Modulo)
                    {

                        case "Clientes":

                            FormularioClientes janela = new FormularioClientes(2, nif, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);

                            break;

                        case "Funcionarios":

                            Formularios.FormularioFuncionarios janela2 = new Formularios.FormularioFuncionarios(2, nif, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela2);
                            Utilitarios.HideForm(this);

                            break;

                        case "Condominios":

                            string NomeCondominio = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioCondominios janela3 = new Formularios.FormularioCondominios(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeCondominio, "Load", Cor);
                            Utilitarios.ShowForm(janela3);
                            Utilitarios.HideForm(this);

                            break;

                        case "Fracoes":

                            string NomeFracao = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioFracoes janela4 = new Formularios.FormularioFracoes(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeFracao);
                            Utilitarios.ShowForm(janela4);
                            Utilitarios.HideForm(this);

                            break;


                        case "Pagamentos":

                            Formularios.FormularioPagamentos janela5 = new Formularios.FormularioPagamentos(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela5);
                            Utilitarios.HideForm(this);
                            break;

                        case "Atas":

                            Formularios.FormularioAtas janela6 = new Formularios.FormularioAtas(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela6);
                            Utilitarios.HideForm(this);
                            break;

                        case "Vistorias":

                            Formularios.FormularioVistorias janela7 = new Formularios.FormularioVistorias(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela7);
                            Utilitarios.HideForm(this);
                            break;

                        case "Ocorrencias":

                            Formularios.FormularioOcorrencias janela8 = new Formularios.FormularioOcorrencias(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela8);
                            Utilitarios.HideForm(this);
                            break;

                        case "Fornecedores":

                            string NomeFornecedor = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioFornecedores janela9 = new Formularios.FormularioFornecedores(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeFornecedor, Cor);
                            Utilitarios.ShowForm(janela9);
                            Utilitarios.HideForm(this);
                            break;

                        case "Contratos":

                            Formularios.FormularioContratos janela10 = new Formularios.FormularioContratos(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela10);
                            Utilitarios.HideForm(this);
                            break;

                        case "Cargos":

                            string NomeCargo = dgv[1, Linha].Value.ToString();

                            if(NomeCargo != "Administrador")
                            {
                                Formularios.FormularioCargos janela11 = new Formularios.FormularioCargos(2, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeCargo, Cor);
                                Utilitarios.ShowForm(janela11);
                                Utilitarios.HideForm(this);
                            }
                            else
                                MessageBox.Show("Não é possível efetuar alterações ao cargo de Administrador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
            //Cargos
            try
            {
                if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
                {

                    DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja eliminar este cargo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int Linha = dgv.CurrentRow.Index;
                        int idregisto = int.Parse(dgv[0, Linha].Value.ToString());
                        string Cargo = dgv[1, Linha].Value.ToString();

                        if (Cargo != "Administrador")
                        {
                            DataTable tabelaFuncionarios = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(IDCargo = " + idregisto + ")");

                            if (tabelaFuncionarios.Rows.Count == 0)
                            {
                                //Remover Cargos
                                using (SqlConnection con = Utilitarios.GetConnection())
                                {
                                    SqlCommand cmd = new SqlCommand("DELETE FROM Cargos WHERE (IDCargo = @IDCargo)", con);

                                    cmd.Parameters.AddWithValue("@IDCargo", idregisto);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }

                                MessageBox.Show("O cargo foi removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Loads();
                            }
                            else
                                MessageBox.Show("O cargo não pode ser removido porque ainda existem funcionários associados ao mesmo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Não é possível efetuar alterações ao cargo de Administrador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttAtas_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Atas", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Cargos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttHome_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenu janela = new FrmMenu(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario);
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

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bttVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
                {
                    int Linha = dgv.CurrentRow.Index;
                    nif = int.Parse(dgv[0, Linha].Value.ToString());
                    int idregisto = int.Parse(dgv[0, Linha].Value.ToString());

                    switch (Modulo)
                    {
                        case "Clientes":

                            FormularioClientes janela = new FormularioClientes(3, nif, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);

                            break;

                        case "Funcionarios":

                            Formularios.FormularioFuncionarios janela2 = new Formularios.FormularioFuncionarios(3, nif, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela2);
                            Utilitarios.HideForm(this);

                            break;

                        case "Condominios":

                            string NomeCondominio = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioCondominios janela3 = new Formularios.FormularioCondominios(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeCondominio, "Load", Cor);
                            Utilitarios.ShowForm(janela3);
                            Utilitarios.HideForm(this);

                            break;

                        case "Fracoes":

                            string NomeFracao = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioFracoes janela4 = new Formularios.FormularioFracoes(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeFracao);
                            Utilitarios.ShowForm(janela4);
                            Utilitarios.HideForm(this);

                            break;

                        case "Pagamentos":

                            Formularios.FormularioPagamentos janela5 = new Formularios.FormularioPagamentos(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela5);
                            Utilitarios.HideForm(this);
                            break;

                        case "Atas":

                            Formularios.FormularioAtas janela6 = new Formularios.FormularioAtas(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela6);
                            Utilitarios.HideForm(this);
                            break;

                        case "Vistorias":

                            Formularios.FormularioVistorias janela7 = new Formularios.FormularioVistorias(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela7);
                            Utilitarios.HideForm(this);
                            break;

                        case "Ocorrencias":

                            Formularios.FormularioOcorrencias janela8 = new Formularios.FormularioOcorrencias(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela8);
                            Utilitarios.HideForm(this);
                            break;

                        case "Fornecedores":

                            string NomeFornecedor = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioFornecedores janela9 = new Formularios.FormularioFornecedores(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeFornecedor, Cor);
                            Utilitarios.ShowForm(janela9);
                            Utilitarios.HideForm(this);
                            break;

                        case "Contratos":

                            Formularios.FormularioContratos janela10 = new Formularios.FormularioContratos(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela10);
                            Utilitarios.HideForm(this);
                            break;

                        case "Cargos":

                            string NomeCargo = dgv[1, Linha].Value.ToString();
                            Formularios.FormularioCargos janela11 = new Formularios.FormularioCargos(3, idregisto, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, NomeCargo, Cor);
                            Utilitarios.ShowForm(janela11);
                            Utilitarios.HideForm(this);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Modulo)
                {
                    case "Clientes":

                        FormularioClientes janela = new FormularioClientes(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                        Utilitarios.ShowForm(janela);
                        Utilitarios.HideForm(this);

                        break;

                    case "Funcionarios":

                        Formularios.FormularioFuncionarios janela2 = new Formularios.FormularioFuncionarios(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela2);
                        Utilitarios.HideForm(this);

                        break;

                    case "Condominios":

                        Formularios.FormularioCondominios janela3 = new Formularios.FormularioCondominios(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "Load", Cor);
                        Utilitarios.ShowForm(janela3);
                        Utilitarios.HideForm(this);

                        break;

                    case "Fracoes":

                        Formularios.FormularioFracoes janela4 = new Formularios.FormularioFracoes(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela4);
                        Utilitarios.HideForm(this);

                        break;

                    case "Pagamentos":

                        Formularios.FormularioPagamentos janela5 = new Formularios.FormularioPagamentos(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela5);
                        Utilitarios.HideForm(this);
                        break;

                    case "Atas":

                        Formularios.FormularioAtas janela6 = new Formularios.FormularioAtas(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela6);
                        Utilitarios.HideForm(this);
                        break;

                    case "Vistorias":

                        Formularios.FormularioVistorias janela7 = new Formularios.FormularioVistorias(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela7);
                        Utilitarios.HideForm(this);
                        break;

                    case "Ocorrencias":

                        Formularios.FormularioOcorrencias janela8 = new Formularios.FormularioOcorrencias(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela8);
                        Utilitarios.HideForm(this);
                        break;

                    case "Fornecedores":

                        Formularios.FormularioFornecedores janela9 = new Formularios.FormularioFornecedores(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela9);
                        Utilitarios.HideForm(this);
                        break;

                    case "Contratos":

                        Formularios.FormularioContratos janela10 = new Formularios.FormularioContratos(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela10);
                        Utilitarios.HideForm(this);
                        break;

                    case "Cargos":

                        Formularios.FormularioCargos janela11 = new Formularios.FormularioCargos(1, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                        Utilitarios.ShowForm(janela11);
                        Utilitarios.HideForm(this);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npagina < NPaginas)
                {
                    num += NRegistosPorPagina;
                    Npagina++;

                    Loads();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npagina != 1 && Npagina <= NPaginas)
                {
                    num -= NRegistosPorPagina;
                    Npagina--;

                    Loads();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

