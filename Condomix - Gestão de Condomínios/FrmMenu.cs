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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    public partial class FrmMenu : Form
    {
        int IDFuncionario;
        string NomeFuncionario, CargoFuncionario, Cor;
        Image FotoFuncionario;

        public FrmMenu(int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario)
        {
            InitializeComponent();
            panelCentral.Location = new Point(this.ClientSize.Width / 2 - panelCentral.Size.Width / 2, this.ClientSize.Height / 3 - panelCentral.Size.Height / 2);
            panelCentral.Anchor = AnchorStyles.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;

            lblNomeFuncionario.Text = NomeFuncionario;
            lblCargoFuncionario.Text = CargoFuncionario;

            foreach (Button Controlo in panelCentral.Controls.OfType<Button>())
            {
                Controlo.MouseMove += new System.Windows.Forms.MouseEventHandler(btt_MouseMove);
                Controlo.MouseLeave += new EventHandler(btt_MouseLeave);
            }
          
        }

        void btt_MouseMove(object sender, EventArgs e)
        {
            try
            {
                Button Controlo = (Button)sender;
                Controlo.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btt_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Button Controlo = (Button)sender;
                Controlo.FlatAppearance.BorderColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bttCondominios_Click(object sender, EventArgs e)
        {
            FRMLoad("Condominios", Cor);
        }

        private void bttClientes_Click(object sender, EventArgs e)
        {
            FRMLoad("Clientes", Cor);
        }

        private void bttMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttFuncionarios_Click(object sender, EventArgs e)
        {
            FRMLoad("Funcionarios", Cor);
        }
 
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            try
            {

                //FOTO
                FotoFuncionario = Utilitarios.ObterFoto("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")");
                PBFoto.Image = FotoFuncionario;

                DataTable tabelaFuncionario = Utilitarios.FillBy("SELECT * FROM Funcionarios WHERE(IDFuncionario = " + IDFuncionario + ")");

                int IDCargo = int.Parse(tabelaFuncionario.Rows[0][2].ToString());
                int IDCustomizacao = int.Parse(tabelaFuncionario.Rows[0][5].ToString());
                lblNomeFuncionario.Text = tabelaFuncionario.Rows[0][6].ToString();

                //Obter o Cargo do Funcionario
                DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE(IDCargo = " + IDCargo + ")");

                string Modulos = string.Empty;

                if (tabelaCargos.Rows.Count == 1)
                {
                    lblCargoFuncionario.Text = tabelaCargos.Rows[0][1].ToString();
                    Modulos = tabelaCargos.Rows[0][2].ToString();
                }

                //Obter a Cor da Customizacao
                DataTable tabelaCustomizacao = Utilitarios.FillBy("SELECT * FROM Customizacao WHERE(IDCustomizacao = " + IDCustomizacao + ")");

                if (tabelaCustomizacao.Rows.Count == 1) Cor = tabelaCustomizacao.Rows[0][1].ToString();

                bttUP.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
                bttDefinicoesConta.Visible = false;
                bttTerminarSessao.Visible = false;

                panelFunc.Width = 1003;
                panelFunc.Height = 55;

                //Colocar os módulos visiveis tendo em conta o que consta no cargo do funcionário.
                string[] nomes = Modulos.Split(',');
                foreach (var item in nomes)
                    foreach (FontAwesome.Sharp.IconButton btt in panelCentral.Controls.OfType<FontAwesome.Sharp.IconButton>())
                        if (btt.Text.Trim() == item.Trim()) btt.Visible = true;

                //Pintar com a cor
                foreach (FontAwesome.Sharp.IconButton Controlo in panelCentral.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);
                    foreach (FontAwesome.Sharp.IconButton Controlo in panelNomeFunc.Controls.OfType<FontAwesome.Sharp.IconButton>()) Controlo.IconColor = Customizar.HexToColor(Cor);

                //DARK E LIGHT MODE

                Color cor1 = Color.Black;
                Color cor2 = Color.White;
                lblMenu.BackColor = cor1;
                lblMenu.ForeColor = cor2;
                bttMinimize.BackColor = cor1;
                bttMinimize.ForeColor = cor2;
                bttExit.BackColor = cor1;
                bttExit.ForeColor = cor2;
                lblCondomix.BackColor = cor1;
                lblCondomix.ForeColor = cor2;
                panelTop.BackColor = cor1;
                panelCentral.BackColor = cor1;
                panelFunc.BackColor = cor1;
                panelNomeFunc.BackColor = cor1;
                PBFoto.BackColor = cor1;
                lblNomeFuncionario.ForeColor = cor2;
                lblCargoFuncionario.BackColor = cor1;
                lblCargoFuncionario.ForeColor = Color.Gainsboro;
                this.BackColor = cor1;
                foreach (Control controlo in panelCentral.Controls)
                {
                    UpdateColorControls(controlo,cor1,cor2);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateColorControls(Control Controlo, Color cor1, Color cor2)
        {
            if (Controlo is FontAwesome.Sharp.IconButton)
            {
                Controlo.BackColor = cor1;
                Controlo.ForeColor = cor2;
            }
            //if (myControl is DataGridView)
            //{
            //    DataGridView MyDgv = (DataGridView)myControl;
            //    MyDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            //    MyDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //}

            // Any other non-standard controls should be implemented here aswell...

            //foreach (Control subC in Controlo.Controls)
            //{
            //    UpdateColorControls(subC);
            //}
        }

        private void bttUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (bttUP.IconChar == FontAwesome.Sharp.IconChar.CaretUp)
                {
                    bttUP.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
                    bttDefinicoesConta.Visible = true;
                    bttTerminarSessao.Visible = true;
                    panelFunc.Width = 253;
                    panelFunc.Height = 172;

                }
                else
                {
                    bttUP.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
                    bttDefinicoesConta.Visible = false;
                    bttTerminarSessao.Visible = false;

                    panelFunc.Width = 1003;
                    panelFunc.Height = 55;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttTerminarSessao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLogin janela = new FrmLogin();
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttFracoes_Click(object sender, EventArgs e)
        {
            FRMLoad("Fracoes", Cor);
        }

        private void bttPagamentos_Click(object sender, EventArgs e)
        {
            FRMLoad("Pagamentos", Cor);
        }

        private void bttAtas_Click(object sender, EventArgs e)
        {
            FRMLoad("Atas", Cor);
        }

        private void bttFornecedores_Click(object sender, EventArgs e)
        {
            FRMLoad("Fornecedores", Cor);
        }

        private void bttDefinicoesConta_Click(object sender, EventArgs e)
        {
            try
            {
                Definicoes janela = new Definicoes(IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttContratos_Click(object sender, EventArgs e)
        {
            FRMLoad("Contratos", Cor);
        }

        private void bttOcorrencias_Click(object sender, EventArgs e)
        {
            FRMLoad("Ocorrencias", Cor);
        }

        private void bttVistorias_Click(object sender, EventArgs e)
        {
            FRMLoad("Vistorias", Cor);
        }

        private void bttCargos_Click(object sender, EventArgs e)
        {
            FRMLoad("Cargos",Cor);
        }

        private void bttTeste_Click(object sender, EventArgs e)
        {
            Formularios.FormularioCondominios janela3 = new Formularios.FormularioCondominios(0, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, "CriacaoRapida", Cor);
            Utilitarios.ShowForm(janela3);
            Utilitarios.HideForm(this);
        }

        private void FRMLoad(string Modulo, string Cor)
        {
            try
            {
                Clientes.FrmClientes janela = new Clientes.FrmClientes(Modulo, IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
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
