using bhojarajsahu88.VSQuickShare.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace bhojarajsahu88.VSQuickShare.Forms
{
    public partial class QuickShare : Form
    {
        AllMethodsClass AM = null;
        string userInfo = string.Empty;
        public QuickShare()
        {
            InitializeComponent();
        }
        public string Encrypt(string textToEncrypt)
        {
            string encryptedCode = string.Empty;
            try
            {
                string actualstring = "";
                if (textToEncrypt.Length == 1)
                    actualstring = "000" + textToEncrypt;
                else if (textToEncrypt.Length == 2)
                    actualstring = "00" + textToEncrypt;
                else if (textToEncrypt.Length == 3)
                    actualstring = "0" + textToEncrypt;
                else
                    actualstring = textToEncrypt;

                Random r = new Random();
                string randomNo = Convert.ToString(r.Next(1111111, 9999990));
                char[] noArray = randomNo.ToCharArray();
                noArray[5] = actualstring[0];
                noArray[3] = actualstring[1];
                noArray[1] = actualstring[2];
                noArray[6] = actualstring[3];
                encryptedCode = new string(noArray);
            }
            catch { }
            return encryptedCode;
        }
        public string Decrypt(string textToDecrypt)
        {
            string decryptedCode = string.Empty;
            try
            {
                Random r = new Random();
                string randomNo = Convert.ToString(r.Next(1111111, 9999990));
                char[] noArray = "0000".ToCharArray(); ;
                noArray[0] = textToDecrypt[5];
                noArray[1] = textToDecrypt[3];
                noArray[2] = textToDecrypt[1];
                noArray[3] = textToDecrypt[6];
                decryptedCode = new string(noArray);
            }
            catch { }
            return decryptedCode;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                AM = new AllMethodsClass();
                if (!string.IsNullOrEmpty(textBoxLink.Text))
                {
                    string keyVal = textBoxLink.Text;
                    //string key = EncryptDecrypt.EncryptDecrypt.Decrypt(keyVal, true);
                    string key = Decrypt(keyVal);
                    string result = AM.getShareKey(Convert.ToString(Convert.ToInt32(key)));
                    textBoxCode.Text = result;
                }
                else
                    UtilityOperations.showMessage("Please verify the key.");
            }
            catch { }

            Cursor.Current = Cursors.Default;
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                AM = new AllMethodsClass();
                if (!string.IsNullOrEmpty(textBoxCode.Text))
                {
                    string resultId = AM.addSharedCode(userInfo, textBoxCode.Text, "0");
                    //textBoxLink.Text = EncryptDecrypt.EncryptDecrypt.Encrypt(resultId, true);
                    textBoxLink.Text = Encrypt(resultId);
                }
                else
                    UtilityOperations.showMessage("Please write some code.");
            }
            catch { }

            Cursor.Current = Cursors.Default;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxCode.Text, TextDataFormat.Text);
            }
            catch { }
        }

        private void QuickShare_Load(object sender, EventArgs e)
        {
            try
            {
                userInfo = Environment.UserDomainName + "-" + Environment.UserName;
                labelMaxChar.Text = labelMaxChar.Text + " : " + textBoxCode.MaxLength;
            }
            catch { }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
            textBoxLink.Text = "";
        }

        private void textBoxLink_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                toolTipLink.SetToolTip(textBoxLink, "Click here to copy Link.");
            }
            catch { }
        }

        private void textBoxLink_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxLink.Text, TextDataFormat.Text);
            }
            catch { }
        }

        private void linkLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lazzycoder.com/");
        }

        private void linkLabelFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:support@lazzycoder.com");
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            labelUsed.Text = "Used : " + textBoxCode.Text.Length;
        }
    }
}
