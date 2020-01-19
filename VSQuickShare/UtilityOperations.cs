using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.VSQuickShare
{
    public class UtilityOperations
    {
        public static void showMessage(string text)
        {
            MessageBox.Show(text, "LazzyCoder Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
    }
}
