using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyboardTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtAzerty.Text = Api.KeyboardTranslator.ToQwerty(txtQwerty.Text);
        }
    }
}
