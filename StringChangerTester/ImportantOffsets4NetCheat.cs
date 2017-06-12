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
    public partial class ImportantOffsets4NetCheat : Form
    {
        public static string sSelectedFolder = Properties.Settings.Default.NCFilePath;

        public ImportantOffsets4NetCheat()
        {
            InitializeComponent();
        }

        private void ImportantOffsets4NetCheat_Load(object sender, EventArgs e)
        {
            MW3CheckBox.Checked = Properties.Settings.Default.chkBoxMW3;
            BO2CheckBox.Checked = Properties.Settings.Default.chkBoxBO2;

            SetCheckBoxes();
        }

        private void ImportantOffsets4NetCheat_FormClosed(object sender, FormClosedEventArgs e)
        {

            Properties.Settings.Default.Save();

            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void SetCheckBoxes()
        {

            if (MW3CheckBox.Checked == true)
            {
                txtEbootRange1.Text = "00010200";
                txtEbootRange2.Text = "0229D017";

                txtRange1.Text = "30000000";
                txtRange2.Text = "3AA00000";
            }

            if (BO2CheckBox.Checked == true)
            {
                txtEbootRange1.Text = "Memesd";
                txtEbootRange2.Text = "Memesd";

                txtRange1.Text = "Memesd";
                txtRange2.Text = "Memesd";
            }
        }

        //private void BO2CheckBox_CheckedChanged(object sender, EventArgs e)
        //{

        //    MW3CheckBox.Checked = false;

        //    SetCheckBoxes();
        //}

        //private void MW3CheckBox_CheckedChanged(object sender, EventArgs e)
        //{

        //    BO2CheckBox.Checked = false;
        //    SetCheckBoxes();
        //}

        private void BO2CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            MW3CheckBox.Checked = false;

            SetCheckBoxes();
        }

        private void MW3CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            BO2CheckBox.Checked = false;
            SetCheckBoxes();
        }

        private void ImportantOffsets4NetCheat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MW3CheckBox.Checked == true)
            {
                Properties.Settings.Default.chkBoxMW3 = true;
            }

            if (BO2CheckBox.Checked == true)
            {
                Properties.Settings.Default.chkBoxBO2 = true;
            }

        }

        private void btnLaunchNC_Click(object sender, EventArgs e)
        {
            if (sSelectedFolder != string.Empty|| sSelectedFolder != "")
            {
                string path = sSelectedFolder/* + "\\NetCheatPS3.exe"*/;
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("Please Select a File path!","Error No file path selected",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void changeNCFilepathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedFolder = fbd.FileName;
                MessageBox.Show("File Path Set to \r\n" + sSelectedFolder,"File Path Set",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Properties.Settings.Default.NCFilePath = sSelectedFolder;
                Properties.Settings.Default.Save();

            }

            else
                sSelectedFolder = string.Empty;
        }
    }
}
