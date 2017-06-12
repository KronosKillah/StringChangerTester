using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringChangerTester
{
    public partial class ArrayMaker : Form
    {
        public ArrayMaker()
        {
            InitializeComponent();
        }

        private void btnBuildArray_Click(object sender, EventArgs e)
        {
            string input = arrayinput.Text;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    sb.Append(',');
                sb.Append(input[i]);
            }
            string formatted = sb.ToString();

            string write = $"0x{input[0]}{input[1]}, 0x{input[2]}{input[3]}, 0x{input[4]}{input[5]}, 0x{input[6]}{input[7]} ";
            arrayoutput.Text = "new byte[] { " + write + "}";

            Clipboard.SetText(arrayoutput.Text);
            arrayinput.Text = string.Empty;
        }

        private void ArrayMaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
