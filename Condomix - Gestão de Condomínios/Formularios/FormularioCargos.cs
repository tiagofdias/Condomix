using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios.Formularios
{
    public partial class FormularioCargos : Form
    {
        int op, idregisto, IDFuncionario, SelectedIndex;
        string NomeFuncionario, CargoFuncionario, selectedItemText, modulos = string.Empty, NomeCargo, Cor;
        Image FotoFuncionario;
        List<string> l1;

        public FormularioCargos(int _op, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _Cor)
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

        public FormularioCargos(int _op, int _idregisto, int _IDFuncionario, string _NomeFuncionario, string _CargoFuncionario, Image _FotoFuncionario, string _NomeCargo, string _Cor)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            op = _op;
            idregisto = _idregisto;
            IDFuncionario = _IDFuncionario;
            NomeFuncionario = _NomeFuncionario;
            CargoFuncionario = _CargoFuncionario;
            FotoFuncionario = _FotoFuncionario;
            NomeCargo = _NomeCargo;
            Cor = _Cor;
        }

        private void FormularioCargos_Load(object sender, EventArgs e)
        {

            try
            {
                //Tema (Dark e light mode) 
                bool Theme = true;

                if (Theme) foreach (GroupBox Controlo in panelCargos.Controls.OfType<GroupBox>()) Controlo.Paint += new PaintEventHandler(Customizar.PintarGB);

                iconCurrentChildForm.IconColor = Customizar.HexToColor(Cor);

                foreach (Panel ControloPaineis in panelDesktop.Controls.OfType<Panel>())
                    foreach (GroupBox ControloGroupBoxs in ControloPaineis.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox Controlo in ControloGroupBoxs.Controls.OfType<TextBox>())
                        {
                            Controlo.ReadOnly = false;
                            Controlo.ResetText();
                            Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        }
                        foreach (ListBox Controlo in ControloGroupBoxs.Controls.OfType<ListBox>()) Controlo.KeyDown += new KeyEventHandler(Utilitarios.textBox_KeyDown);
                        foreach (ListBox Controlo in ControloGroupBoxs.Controls.OfType<ListBox>()) Controlo.Enabled = true;
                    }


                erros.Clear();

                switch (op)
                {
                    //Adicionar
                    case 0:

                        lblTitleChildForm.Text = "Adicionar Cargo";
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        l1 = new List<string>();
                        AddItemsToListFromString(l1, "Clientes,Condomínios,Contratos,Fornecedores,Frações,Funcionários,Ocorrências,Pagamentos,Vistorias", new char[] { ',' });
                        listBox1.DataSource = l1;
                       
                        break;

                    //Editar
                    case 2:

                        lblTitleChildForm.Text = "Editar Cargo";
                        Editar_Visualizar(2);
                        bttGuardar.Visible = true;
                        bttGuardar.Focus();

                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public List<string> AddItemsToListFromString(List<string> lb, String strItems, char[] separators)
        {
            String[] items = strItems.Split(separators);

            foreach (String item in items)
                lb.Add(item.Trim());

            return lb;
        }

        private void Editar_Visualizar(int chegueide)
        {
            try
            {
                DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (IDCargo = " + idregisto + ")");

                if (tabelaCargos.Rows.Count == 1)
                {
                    txtCargo.Text = tabelaCargos.Rows[0][1].ToString();

                    var listbox2 = tabelaCargos.Rows[0][2].ToString().Split(',');
                    var ModulosInicial = " Clientes, Condomínios, Contratos, Fornecedores, Frações, Funcionários, Ocorrências, Pagamentos, Vistorias".ToString().Split(',');

                    string listbox1 = String.Join(",", ModulosInicial.Except(listbox2));

                    l1 = new List<string>();
                    AddItemsToListFromString(l1, listbox1, new char[] { ',' });
                    listBox1.DataSource = l1;

                    Array.Sort(listbox2);
                    foreach (string element in listbox2)
                        listBox2.Items.Add(element.Trim());

                    //Validação
                    if(listBox1.Items.Count == 1 & listBox2.Items.Count == 9)
                    {
                        l1.Clear();
                        listBox1.ClearSelected();
                        listBox1.Enabled = false;
                        bttAdicionar.Enabled = false;
                    }
                    else
                    {
                        listBox1.Enabled = true;
                        bttAdicionar.Enabled = true;
                    }
                              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count != 0)
                {
                    selectedItemText = listBox1.SelectedItem.ToString();
                    SelectedIndex = listBox1.SelectedIndex;
                    listBox2.Items.Add(selectedItemText);

                    if (l1 != null) l1.RemoveAt(SelectedIndex);

                    DataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItems.Count != 0)
                {
                    selectedItemText = listBox2.SelectedItem.ToString();
                    SelectedIndex = listBox2.SelectedIndex;
                    l1.Add(selectedItemText);
                    listBox2.Items.RemoveAt(listBox2.Items.IndexOf(listBox2.SelectedItem));

                    DataBinding();
                }

                //Validação
                if (listBox1.Items.Count == 1 & listBox2.Items.Count == 9)
                {
                    l1.Clear();
                    listBox1.ClearSelected();
                    listBox1.Enabled = false;
                    bttAdicionar.Enabled = false;
                }
                else
                {
                    listBox1.Enabled = true;
                    bttAdicionar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataBinding()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = l1;
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == false)
                {
                    if (op == 0)
                    {
                        if (listBox2.Items.Count != 0)
                        {
                            ArrayList array = new ArrayList();
                            foreach (object item in listBox2.Items)
                                array.Add(item);

                            array.Sort();
                            listBox2.Items.Clear();

                            foreach (object item in array)
                                modulos += item + ", ";
                                
                            modulos = modulos.Remove(modulos.Length - 2);
                            modulos = " " + modulos;

                            //Cargos
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO Cargos (Cargo, Modulos) VALUES(@Cargo, @Modulos)", con);

                                cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text.Trim());
                                cmd.Parameters.AddWithValue("@Modulos", modulos);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            MessageBox.Show("O novo cargo foi criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            erros.Clear();

                            Clientes.FrmClientes janela = new Clientes.FrmClientes("Cargos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);
                        }
                        else
                            erros.SetError(listBox2, "Selecione os módulos que deseja atribuir ao seu cargo");
                    }
                    else
                    {
               
                        if (listBox2.Items.Count != 0)
                        {
                            ArrayList array = new ArrayList();
                            foreach (object item in listBox2.Items)
                                array.Add(item);

                            array.Sort();
                            listBox2.Items.Clear();

                            foreach (object item in array)
                                modulos += item + ", ";

                            modulos = modulos.Remove(modulos.Length - 2);
                            modulos = " " + modulos;

                            //Cargos
                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Cargos SET Cargo = @Cargo, Modulos = @Modulos WHERE (IDCargo = @IDCargo)", con);

                                cmd.Parameters.AddWithValue("@IDCargo", idregisto);
                                cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text.Trim());
                                cmd.Parameters.AddWithValue("@Modulos", modulos);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            bttGuardar.Focus();
                            MessageBox.Show("Todas as informações foram atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            erros.Clear();

                            Clientes.FrmClientes janela = new Clientes.FrmClientes("Cargos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                            Utilitarios.ShowForm(janela);
                            Utilitarios.HideForm(this);

                        }
                        else
                            erros.SetError(listBox2, "Selecione os módulos que deseja atribuir ao seu cargo");
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
                Clientes.FrmClientes janela = new Clientes.FrmClientes("Cargos", IDFuncionario, NomeFuncionario, CargoFuncionario, FotoFuncionario, Cor);
                Utilitarios.ShowForm(janela);
                Utilitarios.HideForm(this);
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

            //Painel
            foreach (GroupBox Controlo2 in panelCargos.Controls.OfType<GroupBox>())
                foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                {
                    if (Controlo.Text.Trim() != string.Empty)
                    {
                        switch (Controlo.Name)
                        {

                            case "txtCargo":

                                Match Nome = Regex.Match(Controlo.Text.Trim(), "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");

                                if (Nome.Success == false)
                                {
                                    erro = true;
                                    erros.SetError(Controlo, "Introduza corretamente o nome do cargo");
                                }
                                else
                                {
                                    //Não repetir o nome do Cargo
                                    if (op != 1)
                                    {
                                        DataTable tabelaCargos = Utilitarios.FillBy("SELECT * FROM Cargos WHERE (Cargo = '" + Controlo.Text.Trim() + "')");

                                        //Inserir
                                        if (op == 0 && tabelaCargos.Rows.Count != 0)
                                        {
                                            erro = true;
                                            erros.SetError(Controlo, "Já existe um cargo registado com este nome");
                                        }

                                        //Editar
                                        if (op == 2 && Controlo.Text.Trim() != NomeCargo.Trim().ToString())
                                        {
                                            if (tabelaCargos.Rows.Count != 0)
                                            {
                                                erro = true;
                                                erros.SetError(Controlo, "Já existe um cargo registado com este nome");
                                            }
                                        }
                                    }
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
    }
}
