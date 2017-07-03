using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StringChangerTester
{
    public partial class JsonSettingMaker : Form
    {
        public JsonSettingMaker()
        {
            InitializeComponent();
        }
        public string[] inpute;
        public bool fileopened = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileopened == true)
            {
                if (checkBox1.Checked)
                {
                    textBox2.Clear();
                    MessageBox.Show(inpute.Length.ToString());
                    for (int i = 0; i < inpute.Length; i++)
                    {
                        
                        string input = "";
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Please Enter a Saving Function Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            
                            input = $"{textBox1.Text}(\"{ inpute[i].ToString()}\", {inpute[i].ToString()}.Text);" + Environment.NewLine;
                            textBox2.Text += input;//System.Diagnostics.Process.Start($"cmd.exe", "echo{input}");
                        }
                    }
                }
                else
                {
                    textBox2.Clear();
                    for (int i = 0; i < inpute.Length; i++)
                    {
                        string input = "";

                        input = $"if(setting.name == \"{inpute[i].ToString()}\"){{{ inpute[i].ToString()}.Text = setting.value; }}" + Environment.NewLine;
                        textBox2.Text += input;//System.Diagnostics.Process.Start($"cmd.exe", "echo{input}");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please load txt file","Errpr!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void JsonSettingMaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void JsonSettingMaker_Load(object sender, EventArgs e)
        {

        }

        private void loadTxtFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*txt)| *.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inpute = File.ReadAllLines(ofd.FileName);
                    MessageBox.Show("Loaded txt file");
                    fileopened = true;
                    label1.Text = "File Loaded : " + ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
