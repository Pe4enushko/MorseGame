using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseGame
{
    public partial class MainForm : Form
    {

        public string Decrypt(string text)
        {
            string Temp = "",DecChr = "",DecTxt = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    Temp += text[i];
                }
                else
                {
                    Temp += " ";
                    DecChr += Temp;
                    Temp = "";
                    DecChr = DecChr.Replace(".--.-. " ,"ъ");
                    DecChr = DecChr.Replace("...-... ","э");
                    DecChr = DecChr.Replace("-... "   ,"б");
                    DecChr = DecChr.Replace("...- "   ,"ж");
                    DecChr = DecChr.Replace(".-.- "   ,"я");
                    DecChr = DecChr.Replace("--.. "   ,"з");
                    DecChr = DecChr.Replace(".--- "   ,"й");
                    DecChr = DecChr.Replace(".-.. "   ,"л");
                    DecChr = DecChr.Replace(".--. "   ,"п");
                    DecChr = DecChr.Replace("..-. "   ,"ф");
                    DecChr = DecChr.Replace(".... "   ,"х");
                    DecChr = DecChr.Replace("-.-. "   ,"ц");
                    DecChr = DecChr.Replace("---- "   ,"ш");
                    DecChr = DecChr.Replace("--.- "   ,"щ");
                    DecChr = DecChr.Replace("-.-- "   ,"ы");
                    DecChr = DecChr.Replace("-..- "   ,"ь");
                    DecChr = DecChr.Replace("..-- "   ,"ю");
                    DecChr = DecChr.Replace("---. "   ,"ч");
                    DecChr = DecChr.Replace("..- "    ,"у");
                    DecChr = DecChr.Replace(".-. "    ,"р");
                    DecChr = DecChr.Replace("-.. "    ,"д");
                    DecChr = DecChr.Replace("... "    ,"с");
                    DecChr = DecChr.Replace("--. "    ,"г");
                    DecChr = DecChr.Replace("--- "    ,"о");
                    DecChr = DecChr.Replace("-.- "    ,"к");
                    DecChr = DecChr.Replace(".-- "    ,"в");
                    DecChr = DecChr.Replace("-- "     ,"м");
                    DecChr = DecChr.Replace(".. "     ,"и");
                    DecChr = DecChr.Replace(".- "     ,"а");
                    DecChr = DecChr.Replace("-. "     ,"н");
                    DecChr = DecChr.Replace(". "      ,"е");
                    DecChr = DecChr.Replace("- "      ,"т");
                    DecTxt += DecChr;
                    DecChr = "";
                }
            }

            return DecTxt;
        }
        public string Encrypt(string text)
        {
            text = text.ToLower();
            
                text = text.Replace("а", ".- ");
                text = text.Replace("б", "-... ");
                text = text.Replace("в", ".-- ");
                text = text.Replace("г", "--. ");
                text = text.Replace("д", "-.. ");
                text = text.Replace("е", ". ");
                text = text.Replace("ж", "...- ");
                text = text.Replace("з", "--.. ");
                text = text.Replace("и", ".. ");
                text = text.Replace("й", ".--- ");
                text = text.Replace("к", "-.- ");
                text = text.Replace("л", ".-.. ");
                text = text.Replace("м", "-- ");
                text = text.Replace("н", "-. ");
                text = text.Replace("о", "--- ");
                text = text.Replace("п", ".--. ");
                text = text.Replace("р", ".-. ");
                text = text.Replace("с", "... ");
                text = text.Replace("т", "- ");
                text = text.Replace("у", "..- ");
                text = text.Replace("ф", "..-. ");
                text = text.Replace("х", ".... ");
                text = text.Replace("ц", "-.-. ");
                text = text.Replace("ч", "---. ");
                text = text.Replace("ш", "---- ");
                text = text.Replace("щ", "--.- ");
                text = text.Replace("ъ", ".--.-. ");
                text = text.Replace("ы", "-.-- ");
                text = text.Replace("ь", "-..- ");
                text = text.Replace("э", "...-... ");
                text = text.Replace("ю", "..-- ");
                text = text.Replace("я", ".-.- ");
            
                return text;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_NextCipher_Click(object sender, EventArgs e)
        {
            Txt_Decryption.Text = "";
            Random rnd = new Random();
            string text = "none";
            byte[] EncodArray = new byte[(int)UpDn_Difficulty.Value];
            
                for (int b = 0; b < UpDn_Difficulty.Value; b++)
                {
                    EncodArray[b] = (byte)rnd.Next(224,255);
                }
                for (int i = 0; i < UpDn_Difficulty.Value; i++)
                {
                text = Encoding.GetEncoding(1251).GetString(EncodArray);
                }
            text = Encrypt(text);
            Txt_Cipher.Text = text;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Decryption_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Decrypted : " + Decrypt(Txt_Cipher.Text));
            if ((Txt_Decryption.Text == Decrypt(Txt_Cipher.Text)) || (Encrypt(Txt_Decryption.Text) == Txt_Cipher.Text))
            {
                Pb_Check.Image = Image.FromFile(@"Resources/0.png");
            }
            else
            {
                Pb_Check.Image = Image.FromFile(@"Resources/1.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Decryption.Text = Decrypt(Txt_Cipher.Text);
        }
    }
}
