using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using System.IO;

namespace StringChangerTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtLastMemUsed.Text = Properties.Settings.Default.lastMem;
        }
        public static uint ProcessID;
        public static uint[] processIDs;
        public static string snresult;

        public static string Info;
        public static string Status;
        public static string MemStatus;
        public static PS3API PS3 = new PS3API();
        public static Random rand = new Random();
        public static CCAPI PS31 = new CCAPI();
        public static CCAPI CCAPI = new CCAPI();

        public static uint freememtochange = 0x00000000;
        public static byte[] gamevalue = null;
        public static byte[] restore;
        public static uint restoreGame;

        public static string GameNameFile;
        
        public static class Dank
        {
            public static void SetMeme(uint Offset, byte[] value)
            {
                PS3.SetMemory(Offset, value);
            }
            public static void WriteFlo(uint Offset, float Input)
            {
                PS3.Extension.WriteFloat(Offset, Input);
            }
            public static void WriteString(uint Offset, string Input)
            {
                PS3.Extension.WriteString(Offset, Input);
            }
            public static void WriteByte(uint Offset, byte Input)
            {
                PS3.Extension.WriteByte(Offset, Input);
            }
            public static void SetName(uint Offset, string Text)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(Text);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                Dank.SetMeme(Offset, bytes);
            }
            public static void ChangeString(uint freemem, byte[] value, string inputBox, uint pointer)
            {
                Dank.SetMeme(freemem, clearmem);
                Dank.WriteString(freemem, inputBox);
                Dank.SetMeme(pointer, value);
            }
        }
        static byte[] clearmem = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.ConnectTarget(0))
                {
                    PS3.AttachProcess();
                    MessageBox.Show($"Connected and Attached with {PS3.GetCurrentAPIName()} ");
                }
                else { MessageBox.Show("Could not Connect/attach"); }
            }
            catch { MessageBox.Show(e.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e) //0x51, 0x05, 0x00, 0x00
        {
            if (GameFilename.Text != "" || GameFilename.Text != string.Empty)
            {
                if (freememtochange != 0x00000000 && gamevalue != null)
                {
                    if (!textBox1.Text.StartsWith("0x"))
                        restore = PS3.GetBytes(Convert.ToUInt32(textBox1.Text, 16), (int)16);


                    restoreGame = Convert.ToUInt32(textBox1.Text, 16);
                    Dank.ChangeString(freememtochange, gamevalue, textBox2.Text, Convert.ToUInt32(textBox1.Text, 16));
                }

                else
                {
                    MessageBox.Show("Please Select a Game setting From the drop down menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please Enter a File name to save as", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
            else
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
            }
        }

        private void bO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freememtochange = 0x51050000;
            gamevalue = new byte[] { 0x51, 0x05, 0x00, 0x00 };

        }

        private void aWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freememtochange = 0x60000100;
            gamevalue = new byte[] { 0x60, 0x00, 0x01, 0x00 };
        }

        private void mW3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freememtochange = 0x50080000;
            gamevalue = new byte[] { 0x50, 0x08, 0x00, 0x00 };
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dank.SetMeme(restoreGame, restore);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buildFunc_Click(object sender, EventArgs e)
        {
            try
            {
                string lastmemused = FreeMem.Text;
                if (lastmemused != "")
                {
                    Properties.Settings.Default.lastMem = lastmemused;
                    txtLastMemUsed.Text = Properties.Settings.Default.lastMem;
                    Properties.Settings.Default.Save();
                }
                string backupmem = FreeMem.Text;
                //int freemempt1 = int.Parse(backupmem);
                //int freememnew = freemempt1 + 70;

                string input = FreeMem.Text;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                        sb.Append(',');
                    sb.Append(input[i]);
                }
                string formatted = sb.ToString();

                string comment = $"//String: {stringtext.Text}\r\n//Free Mem: 0x{FreeMem.Text}  | Pointer: 0x{Pointer.Text}  | Origional Offset: 0x{origonaloffset.Text}\r\n";

                string write = $"0x{input[0]}{input[1]}, 0x{input[2]}{input[3]}, 0x{input[4]}{input[5]}, 0x{input[6]}{input[7]} ";
                string bytesaddress = "new byte[] { " + write + "}";
                string line = $"public static void {FuncName.Text}(string textbox)\r\n{{\tFuncDank.ChangeString(0x{FreeMem.Text}, {bytesaddress} , textbox, 0x{Pointer.Text});" + Environment.NewLine + "}";
                if (checkWriteToFile.Checked)
                {
                    using (StreamWriter sw = new StreamWriter(GameNameFile + ".txt", true))
                    {
                        sw.WriteLine(comment);

                    }
                }

                if (checkBox2.Checked)
                {
                    outputfuncBox.Text = comment + line;
                    Clipboard.SetText(outputfuncBox.Text);

                }
                else if (checkBox3.Checked == true)
                {
                    FuncName.Enabled = false;
                    outputfuncBox.Text = comment;
                    Clipboard.SetText(outputfuncBox.Text);


                }
                else
                {
                    outputfuncBox.Text = line;
                    Clipboard.SetText(outputfuncBox.Text);

                }

                //FreeMem.Text = freememnew.ToString();
            }
            catch
            {
                MessageBox.Show("Make sure all the boxes are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteToFile()
        {

            
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                FuncName.Enabled = false;
                checkBox2.Checked = false;
            }
            else
                FuncName.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
                FuncName.Enabled = true;

            }
        }
        public void ClearBoxes()
        {
            FuncName.Text = string.Empty;
            stringtext.Text = string.Empty;
            FreeMem.Text = string.Empty;
            Pointer.Text = string.Empty;
            origonaloffset.Text = "3";



        }

        private void setGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameNameFile = GameFilename.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arrayMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayMaker ar = new ArrayMaker();
            ar.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void jSONSettingMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonSettingMaker jsm = new JsonSettingMaker();
            jsm.Show();
            this.Hide();

        }

        private void importantOffsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportantOffsets4NetCheat frm = new ImportantOffsets4NetCheat();
            frm.Show();
            this.Hide();
        }
    } 
}
