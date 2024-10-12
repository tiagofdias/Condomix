using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    public static class Utilitarios
    {

        //Load e Consultas
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\tiago\Desktop\Condomix - Gestão de Condomínios\Condomix - Gestão de Condomínios\CONDOMIX.mdf ;Integrated Security=True");         
        }
                                       //Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Utilizador\Desktop\Condomix - Gestão de Condomínios\Condomix - Gestão de Condomínios\Condomix.mdf";Integrated Security = True; Connect Timeout = 30
        public static Tuple<string, int, int, int> Loads(int num, int Npagina, DataGridView dgv, string query, string querycount, string query2, int op, int NRegistosPorPagina)
        {
            SqlDataAdapter adp;

            if (op == 1 && query2.Trim() != string.Empty)
            {

                string str = query2.Substring(query2.IndexOf(" ") + 5);

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand(querycount + " Where " + str, con);
                    Int32 count = (Int32)comm.ExecuteScalar();

                    decimal Valor = decimal.Parse(count.ToString()) / NRegistosPorPagina;
                    int NPaginas = (int)Math.Ceiling(Valor);

                    if (Npagina == 1 && NPaginas == 0)
                        NPaginas = 1;

                    string labelPaginas = "Página " + Npagina + " de " + NPaginas;

                    adp = new SqlDataAdapter(query + " Where " + str, con);

                    DataTable tabela = new DataTable();
                    adp.Fill(num, NRegistosPorPagina, tabela);
                    dgv.DataSource = tabela;

                    return new Tuple<string, int, int, int>(labelPaginas, Npagina, NPaginas, count);
                }
            }
            else
            {

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand(querycount, con);
                    Int32 count = (Int32)comm.ExecuteScalar();

                    decimal Valor = decimal.Parse(count.ToString()) / NRegistosPorPagina;
                    int NPaginas = (int)Math.Ceiling(Valor);

                    string labelPaginas = "Página " + Npagina + " de " + NPaginas;

                    adp = new SqlDataAdapter(query, con);

                    DataTable tabela = new DataTable();
                    adp.Fill(num, NRegistosPorPagina, tabela);
                    dgv.DataSource = tabela;

                    return new Tuple<string, int, int, int>(labelPaginas, Npagina, NPaginas, count);
                }
            }
        }
 
        //Obter o Nome do banco com base no IBAN
        public static int NomeBanco(System.Windows.Forms.TextBox txtIBAN)
        {
            string query = "SELECT IDBanco, Nome, Prefixo FROM Bancos WHERE(Prefixo = " + txtIBAN.Text.Substring(txtIBAN.Text.IndexOf(" ") + 5).Substring(0, 4) + ")";

            using (SqlConnection con = GetConnection())
            {

                SqlDataAdapter adp = new SqlDataAdapter(query, con);

                DataTable tabela = new DataTable();
                adp.Fill(tabela);

                int IDBanco = int.Parse(tabela.Rows[0]["IDBanco"].ToString());

                return IDBanco;
            }
        }

        public static void ObterCodigoPostal(System.Windows.Forms.TextBox txtcp, System.Windows.Forms.TextBox txtMorada, System.Windows.Forms.TextBox txtLocalidade)
        {
            try
            {

                string cp1 = txtcp.Text.Substring(0, 4);
                string cp2 = txtcp.Text.Substring(txtcp.Text.Length - 3);
                string cp = cp1 + ";" + cp2;

                string fileName = "todos_cp.txt";
                string caminho = Path.Combine(Environment.CurrentDirectory, fileName);

                string line = File.ReadLines(caminho).SkipWhile(lines => !lines.Contains(cp)).First();

                string[] words = line.Split(';');

                List<string> list = new List<string>();

                foreach (var word in words) list.Add(word);

                String[] str = list.ToArray();

                //int codDistrito = int.Parse(str[0]);
                //int codConcelho = int.Parse(str[1]);
                string localidade = str[3];
                string rua = str[5] + " " + str[9];
                txtMorada.Text = rua;
                txtLocalidade.Text = localidade;
                //falta as outras txts

            }
            catch (Exception) { }

        }

        //Abrir forms
        public static void OpenChildForm(Form childForm, Form currentChildForm, System.Windows.Forms.Panel panelDesktop)
        {
            try
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    currentChildForm.Dispose();
                }

                panelDesktop.Controls.Clear();
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                panelDesktop.BringToFront();
                childForm.Show();
            }
            catch (Exception)
            {
                panelDesktop.Controls.Clear();
            }
        }

        public static string GerarStringAleatoria(int length, string characters)
        {
            Random rnd = new Random();
            return new string(Enumerable.Repeat(characters, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static bool Internet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        public static void EnviarEmail(string NossoEmail, string NossaPassword, string Destinatario, string funcionario, string codigo, string ficheiro)
        {

            try
            {

                //EMAIL

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                MailDefinition md = new MailDefinition();
                ListDictionary replacements = new ListDictionary();

                string client = getBetween(Destinatario, "@", ".");

                if (ficheiro == "RecuperarConta.txt")
                {
                    if (client == "outlook" || client == "hotmail") ficheiro = "RecuperarContaOutlook.txt"; else ficheiro = "RecuperarContaGmail.txt";

                    //instancias
                    md = new MailDefinition
                    {
                        From = NossoEmail,
                        IsBodyHtml = true,
                        Subject = "Recuperação de Conta"
                    };

                    replacements = new ListDictionary
                    {
                        { "{nome}", funcionario },
                        { "{codigo}", codigo },
                        { "{Destinatario}", Destinatario },
                    };
                }
                else
                {
                    if (client == "outlook" || client == "hotmail") ficheiro = "NovoFuncionarioOutlook.txt"; else ficheiro = "NovoFuncionarioGmail.txt";

                    //instancias
                    md = new MailDefinition
                    {
                        From = NossoEmail,
                        IsBodyHtml = true,
                        Subject = "Bem-Vindo ao Condomix"
                    };

                    replacements = new ListDictionary
                    {
                        { "{nome}", funcionario },
                        { "{codigo}", codigo },
                        { "{Destinatario}", Destinatario },
                    };
                }

                string caminho = Path.Combine(Environment.CurrentDirectory, ficheiro);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.Load(caminho);

                    string body = doc.DocumentNode.OuterHtml;

                    MailMessage msg = md.CreateMailMessage(Destinatario, replacements, body, new System.Web.UI.Control());

                    msg.From = new MailAddress(NossoEmail, "Condomix");
                    msg.Priority = MailPriority.High;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(NossoEmail, NossaPassword);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(msg);

            }
            catch{}

        }

        private static int height;
        private static int width;

        public static void ShowForm(Form form)
        {
            form.Visible = true;
            form.Height = height;
            form.Width = width;
        }

        public static void HideForm(Form form)
        {
            height = form.Height;
            width = form.Width;

            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Height = 0;
            form.Width = 0;
            form.Visible = false;
        }

        public static DataTable FillBy(string query)
        {
            using (SqlConnection con = Utilitarios.GetConnection())
            {
                con.Open();
                SqlDataAdapter adp;
                adp = new SqlDataAdapter(query, con);

                DataTable tabela = new DataTable();
                tabela.Clear();
                adp.Fill(tabela);
                con.Close();

                return tabela;
            }
        }

        #region Password
        public static int CheckStrength(string password)
        {

            //Verificar a força da password

            int score = 0;

            if (password.Trim().Length > 4)
                score++;

            bool Uppercase = password.Any(char.IsUpper);
            bool Lowercase = password.Any(char.IsLower);
            bool numeros = password.Any(char.IsDigit);
            bool symbolCheck = password.Any(p => !char.IsLetterOrDigit(p));

            if (symbolCheck == true)
                score++;

            if (numeros == true)
                score++;

            if (Uppercase == true)
                score++;

            if (Lowercase == true)
                score++;

            if (password.Length >= 6)
                score++;

            return score;
        }

        #endregion

        public static void OpenFile(int id)
        {

            using (SqlConnection con = Utilitarios.GetConnection())
            {
                string query = "SELECT IDDocumento, Documento, Extensao, Nome FROM Documentos WHERE(IDDocumento = @IDDocumento)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@IDDocumento", SqlDbType.Int).Value = id;
                con.Open();

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    var name = reader["Nome"].ToString();
                    var documento = (byte[])reader["Documento"];

                    var extn = reader["Extensao"].ToString();
                    var newFile = name + extn;
                    File.WriteAllBytes(newFile, documento);
                    System.Diagnostics.Process.Start(name + extn);

                }

                con.Close();
            }
        }

        public static void SaveFile(String filePath, int op, [Optional] int IDDocumento)
        {
            try
            {
                using (Stream stream = File.OpenRead(filePath))
                {

                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);

                    string extn = new FileInfo(filePath).Extension;

                    if (extn == ".pdf")
                    {
                        string name = new FileInfo(filePath).Name.Remove(new FileInfo(filePath).Name.Length - 4);

                        if (op == 0)
                        {
                            string query = "INSERT INTO Documentos (Documento, Extensao, Nome) VALUES(@Documento, @Extensao, @Nome)";

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {

                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.Parameters.Add("@Documento", SqlDbType.VarBinary).Value = buffer;
                                cmd.Parameters.Add("@Extensao", SqlDbType.Char).Value = extn;
                                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = name;

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        else
                        {
                            string query = "UPDATE Documentos SET Documento = @Documento, Extensao = @Extensao, Nome = @Nome WHERE (IDDocumento = @IDDocumento)";

                            using (SqlConnection con = Utilitarios.GetConnection())
                            {
                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.Parameters.Add("@IDDocumento", SqlDbType.Int).Value = IDDocumento;
                                cmd.Parameters.Add("@Documento", SqlDbType.VarBinary).Value = buffer;
                                cmd.Parameters.Add("@Extensao", SqlDbType.Char).Value = extn;
                                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = name;

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Só são permitidos ficheiros do tipo PDF");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        #region Foto
        public static System.Drawing.Image ClipToCircle(System.Drawing.Image srcImage, PointF center, float radius)
        {
            Bitmap b = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            b.MakeTransparent();
            System.Drawing.Image dstImage = b;

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }

        public static System.Drawing.Image ConverterBinarioParaImagem(byte[] foto)
        {
            using (MemoryStream ms = new MemoryStream(foto))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        #endregion

        #region Foto

        public static System.Drawing.Image ObterFoto(string query)
        {

            //FOTO
            using (SqlConnection con = Utilitarios.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] byteImg = (byte[])reader["Foto"];

                    //Apresentar Imagem normal
                    //pictureBox2.Image = ConverterBinarioParaImagem(byteImg);

                    //Apresentar Imagem Circular
                    System.Drawing.Image StartImage = Utilitarios.ConverterBinarioParaImagem(byteImg);
                    System.Drawing.Image RoundedImage = Utilitarios.ClipToCircle(StartImage, new PointF(StartImage.Width / 2, StartImage.Height / 2), StartImage.Width / 2);
                    con.Close();
                    return RoundedImage;

                }
                else 
                {
                    con.Close();
                    return null;    
                }
            }  
        }
        #endregion
    }
}
