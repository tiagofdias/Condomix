using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    class Validacoes
    {

        //Validações

        public static bool IsValidContrib(string Contrib)
        {
            bool functionReturnValue = false;
            string[] s = new string[9];
            string Ss = null;
            string C = null;
            int i = 0;
            long checkDigit = 0;

            try
            {

                s[0] = Convert.ToString(Contrib[0]);
                s[1] = Convert.ToString(Contrib[1]);
                s[2] = Convert.ToString(Contrib[2]);
                s[3] = Convert.ToString(Contrib[3]);
                s[4] = Convert.ToString(Contrib[4]);
                s[5] = Convert.ToString(Contrib[5]);
                s[6] = Convert.ToString(Contrib[6]);
                s[7] = Convert.ToString(Contrib[7]);
                s[8] = Convert.ToString(Contrib[8]);

                if (Contrib.Length == 9)
                {
                    C = s[0];
                    if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                    {
                        checkDigit = Convert.ToInt32(C) * 9;
                        for (i = 2; i <= 8; i++)
                        {
                            checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                        }
                        checkDigit = 11 - (checkDigit % 11);
                        if ((checkDigit >= 10))
                            checkDigit = 0;
                        Ss = s[0] + s[1] + s[2] + s[3] + s[4] + s[5] + s[6] + s[7] + s[8];
                        if ((checkDigit == Convert.ToInt32(s[8])))
                            functionReturnValue = true;
                    }
                }
                return functionReturnValue;
            }
            catch
            {
                functionReturnValue = false;
                return functionReturnValue;

            }

        }

        public static bool IsValidEmail(string emailaddress, TextBox txtEmail)
        {
            try
            {
                if (txtEmail.Text.Trim() != "")
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool ValidarIBAN(string bankAccount)
        {
            try
            {
                bankAccount = bankAccount.ToUpper();
                if (String.IsNullOrEmpty(bankAccount))
                    return false;
                else if (System.Text.RegularExpressions.Regex.IsMatch(bankAccount, "^[A-Z0-9]"))
                {
                    bankAccount = bankAccount.Replace(" ", String.Empty);
                    string bank =
                    bankAccount.Substring(4, bankAccount.Length - 4) + bankAccount.Substring(0, 4);
                    int asciiShift = 55;
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in bank)
                    {
                        int v;
                        if (Char.IsLetter(c)) v = c - asciiShift;
                        else v = int.Parse(c.ToString());
                        sb.Append(v);
                    }
                    string checkSumString = sb.ToString();
                    int checksum = int.Parse(checkSumString.Substring(0, 1));
                    for (int i = 1; i < checkSumString.Length; i++)
                    {
                        int v = int.Parse(checkSumString.Substring(i, 1));
                        checksum *= 10;
                        checksum += v;
                        checksum %= 97;
                    }
                    return checksum == 1;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;

            }

        }

        public static bool ValidarCampoVazio(Panel panelDesktop, bool erro, ErrorProvider erros)
        {
            
            foreach (GroupBox Controlo2 in panelDesktop.Controls.OfType<GroupBox>())
            {
                foreach (TextBox Controlo in Controlo2.Controls.OfType<TextBox>())
                {

                    string str = Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Substring(Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2").Length - 1);
                    if (str.Trim() == "a") str = "Introduza uma "; else str = "Introduza um ";

                    if (Controlo.Text.Trim() == string.Empty)
                    {
                        erro = true;
                        erros.SetError(Controlo, str + Regex.Replace(Controlo.Name.ToString().Substring(Controlo.Name.ToString().IndexOf(" ") + 4), "([a-z])([A-Z])", "$1 $2"));
                    }
                }
               
            }

            return erro;
        }
    }
}
