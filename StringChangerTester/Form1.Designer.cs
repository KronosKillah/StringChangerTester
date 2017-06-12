namespace StringChangerTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeToolGameSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mW3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gHOSTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bO1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameFilename = new System.Windows.Forms.ToolStripTextBox();
            this.openOtherToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONSettingMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importantOffsetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLastMemUsed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkWriteToFile = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.origonaloffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stringtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buildFunc = new System.Windows.Forms.Button();
            this.outputfuncBox = new System.Windows.Forms.TextBox();
            this.Pointer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FreeMem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FuncName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect\r\nAttach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0x01546F2C";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "CCAPI";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pointer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text Change";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolGameSettingToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.setGameToolStripMenuItem,
            this.GameFilename,
            this.openOtherToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeToolGameSettingToolStripMenuItem
            // 
            this.changeToolGameSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bO2ToolStripMenuItem,
            this.mW3ToolStripMenuItem,
            this.gHOSTSToolStripMenuItem,
            this.aWToolStripMenuItem,
            this.bO1ToolStripMenuItem});
            this.changeToolGameSettingToolStripMenuItem.Name = "changeToolGameSettingToolStripMenuItem";
            this.changeToolGameSettingToolStripMenuItem.Size = new System.Drawing.Size(160, 23);
            this.changeToolGameSettingToolStripMenuItem.Text = "Change Tool Game Setting";
            // 
            // bO2ToolStripMenuItem
            // 
            this.bO2ToolStripMenuItem.Name = "bO2ToolStripMenuItem";
            this.bO2ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bO2ToolStripMenuItem.Text = "BO2";
            this.bO2ToolStripMenuItem.Click += new System.EventHandler(this.bO2ToolStripMenuItem_Click);
            // 
            // mW3ToolStripMenuItem
            // 
            this.mW3ToolStripMenuItem.Name = "mW3ToolStripMenuItem";
            this.mW3ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mW3ToolStripMenuItem.Text = "MW3";
            this.mW3ToolStripMenuItem.Click += new System.EventHandler(this.mW3ToolStripMenuItem_Click);
            // 
            // gHOSTSToolStripMenuItem
            // 
            this.gHOSTSToolStripMenuItem.Enabled = false;
            this.gHOSTSToolStripMenuItem.Name = "gHOSTSToolStripMenuItem";
            this.gHOSTSToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.gHOSTSToolStripMenuItem.Text = "GHOSTS";
            // 
            // aWToolStripMenuItem
            // 
            this.aWToolStripMenuItem.Name = "aWToolStripMenuItem";
            this.aWToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aWToolStripMenuItem.Text = "AW";
            this.aWToolStripMenuItem.Click += new System.EventHandler(this.aWToolStripMenuItem_Click);
            // 
            // bO1ToolStripMenuItem
            // 
            this.bO1ToolStripMenuItem.Enabled = false;
            this.bO1ToolStripMenuItem.Name = "bO1ToolStripMenuItem";
            this.bO1ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bO1ToolStripMenuItem.Text = "BO1";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // setGameToolStripMenuItem
            // 
            this.setGameToolStripMenuItem.Name = "setGameToolStripMenuItem";
            this.setGameToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.setGameToolStripMenuItem.Text = "Set Game";
            this.setGameToolStripMenuItem.Click += new System.EventHandler(this.setGameToolStripMenuItem_Click);
            // 
            // GameFilename
            // 
            this.GameFilename.Name = "GameFilename";
            this.GameFilename.Size = new System.Drawing.Size(100, 23);
            // 
            // openOtherToolStrip
            // 
            this.openOtherToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayMakerToolStripMenuItem,
            this.jSONSettingMakerToolStripMenuItem,
            this.importantOffsetsToolStripMenuItem});
            this.openOtherToolStrip.Name = "openOtherToolStrip";
            this.openOtherToolStrip.Size = new System.Drawing.Size(120, 23);
            this.openOtherToolStrip.Text = "Open Another Tool";
            // 
            // arrayMakerToolStripMenuItem
            // 
            this.arrayMakerToolStripMenuItem.Name = "arrayMakerToolStripMenuItem";
            this.arrayMakerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.arrayMakerToolStripMenuItem.Text = "Array Maker";
            this.arrayMakerToolStripMenuItem.Click += new System.EventHandler(this.arrayMakerToolStripMenuItem_Click);
            // 
            // jSONSettingMakerToolStripMenuItem
            // 
            this.jSONSettingMakerToolStripMenuItem.Name = "jSONSettingMakerToolStripMenuItem";
            this.jSONSettingMakerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.jSONSettingMakerToolStripMenuItem.Text = "JSON Setting Maker";
            this.jSONSettingMakerToolStripMenuItem.Click += new System.EventHandler(this.jSONSettingMakerToolStripMenuItem_Click);
            // 
            // importantOffsetsToolStripMenuItem
            // 
            this.importantOffsetsToolStripMenuItem.Name = "importantOffsetsToolStripMenuItem";
            this.importantOffsetsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.importantOffsetsToolStripMenuItem.Text = "Important Offsets";
            this.importantOffsetsToolStripMenuItem.Click += new System.EventHandler(this.importantOffsetsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pointer Tester";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLastMemUsed);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.checkWriteToFile);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.origonaloffset);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.stringtext);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buildFunc);
            this.groupBox3.Controls.Add(this.outputfuncBox);
            this.groupBox3.Controls.Add(this.Pointer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.FreeMem);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.FuncName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 304);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function Maker";
            // 
            // txtLastMemUsed
            // 
            this.txtLastMemUsed.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastMemUsed.Location = new System.Drawing.Point(89, 261);
            this.txtLastMemUsed.Name = "txtLastMemUsed";
            this.txtLastMemUsed.Size = new System.Drawing.Size(100, 20);
            this.txtLastMemUsed.TabIndex = 29;
            this.txtLastMemUsed.Text = "50082680";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Last Mem used: ";
            // 
            // checkWriteToFile
            // 
            this.checkWriteToFile.AutoSize = true;
            this.checkWriteToFile.Checked = true;
            this.checkWriteToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWriteToFile.Location = new System.Drawing.Point(477, 83);
            this.checkWriteToFile.Name = "checkWriteToFile";
            this.checkWriteToFile.Size = new System.Drawing.Size(82, 17);
            this.checkWriteToFile.TabIndex = 27;
            this.checkWriteToFile.Text = "Write to File";
            this.checkWriteToFile.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(477, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(137, 17);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "Comment Creator Mode";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(477, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Comments on top?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // origonaloffset
            // 
            this.origonaloffset.Location = new System.Drawing.Point(527, 18);
            this.origonaloffset.Name = "origonaloffset";
            this.origonaloffset.Size = new System.Drawing.Size(82, 20);
            this.origonaloffset.TabIndex = 23;
            this.origonaloffset.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Origional Offset";
            // 
            // stringtext
            // 
            this.stringtext.Location = new System.Drawing.Point(72, 48);
            this.stringtext.Name = "stringtext";
            this.stringtext.Size = new System.Drawing.Size(364, 20);
            this.stringtext.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "String";
            // 
            // buildFunc
            // 
            this.buildFunc.Location = new System.Drawing.Point(539, 260);
            this.buildFunc.Name = "buildFunc";
            this.buildFunc.Size = new System.Drawing.Size(75, 38);
            this.buildFunc.TabIndex = 20;
            this.buildFunc.Text = "Build";
            this.buildFunc.UseVisualStyleBackColor = true;
            this.buildFunc.Click += new System.EventHandler(this.buildFunc_Click);
            // 
            // outputfuncBox
            // 
            this.outputfuncBox.Location = new System.Drawing.Point(9, 106);
            this.outputfuncBox.Multiline = true;
            this.outputfuncBox.Name = "outputfuncBox";
            this.outputfuncBox.Size = new System.Drawing.Size(605, 148);
            this.outputfuncBox.TabIndex = 19;
            // 
            // Pointer
            // 
            this.Pointer.Location = new System.Drawing.Point(354, 18);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(82, 20);
            this.Pointer.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pointer";
            // 
            // FreeMem
            // 
            this.FreeMem.Location = new System.Drawing.Point(220, 18);
            this.FreeMem.Name = "FreeMem";
            this.FreeMem.Size = new System.Drawing.Size(82, 20);
            this.FreeMem.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Free Mem";
            // 
            // FuncName
            // 
            this.FuncName.Location = new System.Drawing.Point(72, 18);
            this.FuncName.Name = "FuncName";
            this.FuncName.Size = new System.Drawing.Size(82, 20);
            this.FuncName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Func Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronos\'s String Changer Pointer Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeToolGameSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mW3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gHOSTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bO1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buildFunc;
        private System.Windows.Forms.TextBox outputfuncBox;
        private System.Windows.Forms.TextBox Pointer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FreeMem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FuncName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox origonaloffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stringtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkWriteToFile;
        private System.Windows.Forms.ToolStripTextBox GameFilename;
        private System.Windows.Forms.ToolStripMenuItem setGameToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLastMemUsed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem openOtherToolStrip;
        private System.Windows.Forms.ToolStripMenuItem arrayMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONSettingMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importantOffsetsToolStripMenuItem;
    }
}

