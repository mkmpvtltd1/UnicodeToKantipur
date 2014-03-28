using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageConvert;

namespace UnicodeToKantipurTestData
{
    public partial class frmUnicodeToKantipur : Form
    {
        public frmUnicodeToKantipur()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string unicode = txtUnicodeData.Text;
            string kantipur = UnicodeToKantipur.ConvertUnicode(unicode);
            txtKatifurFontData.Text = kantipur;
            txtKantipur.Text = kantipur;
            txtKantipur.Font = new Font("Kantipur", 12, FontStyle.Regular);
        }
    }
}
