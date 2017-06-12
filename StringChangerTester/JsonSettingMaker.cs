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
    public partial class JsonSettingMaker : Form
    {
        public JsonSettingMaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] inp = { "pubmatchBox", "multiplayerBox", "pubmatchDescBox", "storeDescBox", "storeBox", "optionsDescBox", "optionsBox", "barracksDescBox", "barracksBox", "codtvDescBox", "codtvBox", "theaterDescBox", "theaterBox", "customGameDescBox", "customGameBox", "leagueDescBox", "leaguePlayBox", "localBox", "lanPartyBox", "playOnlineBox", "playersOnlineBox", "addSplitscreenControllerBox", "backButtonBox", "friendsPlayingBox", "scorestreaksDescBox", "scorestreaksBox", "createclassDescBox", "createaclassBox", "findmatchDescBox", "findMatchBox", "livestreamDescBox", "livestreamBox", "deadScilenceDescBox", "deadscilenceBox", "tacMaskDescBox", "tacMaskBox", "engineerDescBox", "engineerBox", "exCondDesBox", "exCondBox", "dexterityDescBox", "dexterityBox", "scavengerDescBox", "scavengerBox", "hardwiredDescBox", "hardwiredBox", "fasthandsDescBox", "fasthandsBox", "coldbloodedDescBox", "coldbloodBox", "toughnessDescBox", "toughnessBox", "ghostDescBox", "ghostBox", "flakjacketDescBox", "flakjacketBox", "blindeyeDescBox", "blindeyeBox", "hardlineDescBox", "hardlineBox", "lightweightDescBox", "lightweightBox", "awarenessDescBox", "awarenessBox", "c4DescBox", "c4Box", "bouncingbettyDescBox", "bouncingbettyBox", "combataxeDescBox", "combataxeBox", "semtexDescBox", "semtexBox", "claymoreDescBox", "grenadeDescBox", "claymoreBox", "grenadeBox", "tacinsertDescBox", "tacinsertBox", "trophysystemDescBox", "trophysystemBox", "flashbagDescBox", "flashbangBox", "blackhatDescBox", "blackhatBox", "shockchargeDescBox", "shockchargeBox", "empgrenadeDescBox", "empgrenadeBox", "sensorgrenadeDescBox", "sensorgrenadeBox", "stungrenadeDescBox", "stungrenadeBox", "concussionDescBox", "concussionBox", "assaultriflesBox", "an94DescBox", "an94Box", "maDescBox", "m8a1Box", "smrDescBox", "smrBox", "scarDescBox", "scarhBox", "m27DescBox", "m27Box", "faloswDescBox", "faloswBox", "swat556DescBox", "swat556Box", "type25DescBox", "type25Box", "mtarDescBox", "mtarBox", "m1216DescBox", "m1216Box", "ksgDescBox", "ksgBox", "s12DescBox", "s12Box", "r870mcsDescBox", "r870mcsBox", "HAMRDescBox", "HAMRBox", "LSATDescBox", "LSATBox", "QBBLSWDescBox", "QBBLSWBox", "MK48DescBox", "MK48Box", "XPR50DescBox", "XPR50Box", "BallistaDescBox", "BallistaBox", "DSR50DescBox", "DSR50Box", "SVUASDescBox", "SVUASBox", "assaultshieldDescBox", "assaultshieldBox" };
            //for (int i = 0; i < inp.Length; i++)
            //{
            //    // string input = $"{{'name':'{inp[i].ToString()}','value':''}}\r\n";
            //    //string input = $"FuncDank.Bo2LoadSettingsTool('{ inp[i].ToString()}',{ inp[i].ToString()}.Text);"+Environment.NewLine;
            //    //string input = $"if (setting.name == '{ inp[i].ToString()}') {{{ inp[i].ToString()}.Text = setting.value; }};" + Environment.NewLine;
            //    textBox2.Text += input;

            //}


            //string input = textBox1.Text;


            //textBox2.Text = input.Replace(Environment.NewLine,", ");

            //string settings_filepath = "Bo2ToolSettings.json";
            //if (File.Exists(settings_filepath))
            //{
            //    string[] Settings_Settings_content = File.ReadAllLines(settings_filepath);
            //    foreach (string line in Settings_Settings_content)
            //    {
            //        Setting setting = JsonConvert.DeserializeObject<Setting>(line);
            //        settingsList.Add(setting);
            //        if (setting.name == inp[0].ToString())
            //        {
            //            textBox1.Text += setting.value;
            //        }
            //        if (setting.name == inp[1].ToString())
            //        {
            //            string test = "textBox2.Text";
            //            test += setting.value;
            //        }
            //    }
            //}
            //else MessageBox.Show(settings_filepath + " is missing! :(");

            for (int i = 0; i < inp.Length; i++)
            {
                string input = "";

                input = $"if(setting.name == '{inp[i].ToString()}'){{{ inp[i].ToString()}.Text = setting.value; }}" + Environment.NewLine;
                textBox2.Text += input;//System.Diagnostics.Process.Start($"cmd.exe", "echo{input}");
            }

            for (int i = 0; i < 137; i++)
            {

                string input2 = inp[i].ToString();
                //string input =  "{0}.Text,\r\n",input2;
                //textBox2.Text += input;//System.Diagnostics.Process.Start($"cmd.exe", "echo{input}");
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
    }
}
