using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando
{
    public partial class KeyValidate : Form
    {
        public string TextBox1 { get; set;}

        public KeyValidate()
        {
            InitializeComponent();
        }

        private void KeyValidate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1 = textBox1.Text;
        }
    }
}
