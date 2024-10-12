using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    class Customizar
    {

        //Cores
        public class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        public class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(38, 38, 44); }
            }
            public override Color MenuBorder
            {
                get { return Color.White; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.White; }

            }
        }

        public static string ColorToHex(Color color)
        {
            return ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb()));
        }

        public static Color HexToColor(string hexColor)
        {
            //Remove # if present
            if (hexColor.IndexOf('#') != -1)
                hexColor = hexColor.Replace("#", "");

            int red = 0;
            int green = 0;
            int blue = 0;

            if (hexColor.Length == 6)
            {
                //#RRGGBB
                red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hexColor.Length == 3)
            {
                //#RGB
                red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
            }

            return Color.FromArgb(red, green, blue);
        }

        //Datagridview
        public static void dgv(DataGridView dgv, string Modulo)
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

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(95, 250, 254);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(95, 250, 254);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);
            dgv.EnableHeadersVisualStyles = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(0,0,0);
            dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255,255,255);
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(95, 250, 254);
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);

            dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            dgv.RowTemplate.Height = 30;

            dgv.GridColor = Color.FromArgb(95, 250, 254);
            dgv.RowsDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 13, FontStyle.Bold);

            switch (Modulo)
            {

                case "Clientes":

                    DataGridViewTextBoxColumn NIF = new DataGridViewTextBoxColumn();

                    NIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    NIF.DataPropertyName = "NIFCliente";
                    NIF.HeaderText = "NIF";
                    NIF.Name = "NIF";
                    NIF.ReadOnly = true;

                    dgv.Columns.Add(NIF);

                    DataGridViewTextBoxColumn Nome = new DataGridViewTextBoxColumn();

                    Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    Nome.DataPropertyName = "Nome";
                    Nome.HeaderText = "Nome";
                    Nome.Name = "Nome";
                    Nome.ReadOnly = true;

                    dgv.Columns.Add(Nome);

                    DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();

                    Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    Email.DataPropertyName = "Email";
                    Email.HeaderText = "Email";
                    Email.Name = "Email";
                    Email.ReadOnly = true;

                    dgv.Columns.Add(Email);

                    DataGridViewTextBoxColumn Contacto = new DataGridViewTextBoxColumn();

                    Contacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    Contacto.DataPropertyName = "Contacto";
                    Contacto.HeaderText = "Contacto";
                    Contacto.Name = "Contacto";
                    Contacto.ReadOnly = true;

                    dgv.Columns.Add(Contacto);

                    DataGridViewTextBoxColumn ContactoAlternativo = new DataGridViewTextBoxColumn();

                    ContactoAlternativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    ContactoAlternativo.DataPropertyName = "ContactoAlternativo";
                    ContactoAlternativo.HeaderText = "Contacto Alternativo";
                    ContactoAlternativo.Name = "ContactoAlternativo";
                    ContactoAlternativo.ReadOnly = true;

                    dgv.Columns.Add(ContactoAlternativo);

                    DataGridViewTextBoxColumn IBAN = new DataGridViewTextBoxColumn();

                    IBAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    IBAN.DataPropertyName = "IBAN";
                    IBAN.HeaderText = "IBAN";
                    IBAN.Name = "IBAN";
                    IBAN.ReadOnly = true;

                    dgv.Columns.Add(IBAN);

                    DataGridViewTextBoxColumn NomeBanco = new DataGridViewTextBoxColumn();

                    NomeBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    NomeBanco.DataPropertyName = "NomeBanco";
                    NomeBanco.HeaderText = "Nome do Banco";
                    NomeBanco.Name = "NomeBanco";
                    NomeBanco.ReadOnly = true;

                    dgv.Columns.Add(NomeBanco);

                    break;

            }

        }

        public static bool ContainsTransparent(Bitmap image)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    if (image.GetPixel(x, y).A != 255)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Groupbox Borders
        public static void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        public static void PintarGB(object sender, PaintEventArgs e)
        {

            Pen p;

            Graphics gfx = e.Graphics;

           /* if (ColorMode)*/ p = new Pen(Color.Red, 1); /*else p = new Pen(Color.White, 2);*/

            //linha da esquerda
            gfx.DrawLine(p, 0, 8, 0, e.ClipRectangle.Height - 2);

            //linha da esquerda curva
            gfx.DrawLine(p, 0, 8, 8, 8);

            //Linha da direita
            gfx.DrawLine(p, e.ClipRectangle.Width - 1, 8, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 2);

            //linha de baixo
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);

            //linha de cima dps do nome (2 opção, 1º dps do P - mais = pa direita, menos = pa esquerda)
            GroupBox GB = sender as GroupBox;
            string NomeGB = GB.Name;
       
            switch(NomeGB)
            {

                case "GBNome": gfx.DrawLine(p, 42, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBNIF": gfx.DrawLine(p, 29, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBIBAN": gfx.DrawLine(p, 37, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBContacto": gfx.DrawLine(p, 60, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBContactoAlternativo": gfx.DrawLine(p, 123, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBEmail": gfx.DrawLine(p, 41, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBCondominio": gfx.DrawLine(p, 77, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBData": gfx.DrawLine(p, 37, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBOrcamento": gfx.DrawLine(p, 107, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBSalaCondominio": gfx.DrawLine(p, 121, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBLojas": gfx.DrawLine(p, 72, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBGaragens": gfx.DrawLine(p, 95, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBFracoes": gfx.DrawLine(p, 86, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBAndares": gfx.DrawLine(p, 86, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBArrecadacoes": gfx.DrawLine(p, 118, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBElevadores": gfx.DrawLine(p, 103, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBCP": gfx.DrawLine(p, 87, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBMorada": gfx.DrawLine(p, 55, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBLocalidade": gfx.DrawLine(p, 71, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBCargo": gfx.DrawLine(p, 43, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBModulos": gfx.DrawLine(p, 60, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBNIFCliente": gfx.DrawLine(p, 87, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBNomeCliente": gfx.DrawLine(p, 100, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBTipoFracao": gfx.DrawLine(p, 92, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBAdministradorInterno": gfx.DrawLine(p, 134, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBPermilagem": gfx.DrawLine(p, 76, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBQuotaMensal": gfx.DrawLine(p, 89, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBObservacoes": gfx.DrawLine(p, 82, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBFracao": gfx.DrawLine(p, 49, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBTitulo": gfx.DrawLine(p, 42, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDescritivo": gfx.DrawLine(p, 66, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDataLimiteResolucao": gfx.DrawLine(p, 149, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBEstado": gfx.DrawLine(p, 48, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBNIFFuncionario": gfx.DrawLine(p, 116, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBNomeFuncionario": gfx.DrawLine(p, 129, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBFornecedor": gfx.DrawLine(p, 73, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBValor": gfx.DrawLine(p, 40, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBContratoSemTermo": gfx.DrawLine(p, 120, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDataInicio": gfx.DrawLine(p, 88, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBContratoRescindido": gfx.DrawLine(p, 123, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBTipoPagamento": gfx.DrawLine(p, 115, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBPeriodoQuota": gfx.DrawLine(p, 107, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDataPagamento": gfx.DrawLine(p, 118, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDataFim": gfx.DrawLine(p, 76, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBDataRescisao": gfx.DrawLine(p, 106, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBPassAtual": gfx.DrawLine(p, 186, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBPassNova": gfx.DrawLine(p, 160, 8, e.ClipRectangle.Width - 1, 8); break;
                case "GBCodigo": gfx.DrawLine(p, 139, 8, e.ClipRectangle.Width - 1, 8); break;
            }

        }
    }
}
