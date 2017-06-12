namespace StringChangerTester
{
    partial class ArrayMaker
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arrayoutput = new System.Windows.Forms.TextBox();
            this.arrayinput = new System.Windows.Forms.TextBox();
            this.btnBuildArray = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.arrayoutput);
            this.groupBox2.Controls.Add(this.arrayinput);
            this.groupBox2.Controls.Add(this.btnBuildArray);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array Maker";
            // 
            // arrayoutput
            // 
            this.arrayoutput.Location = new System.Drawing.Point(75, 57);
            this.arrayoutput.Name = "arrayoutput";
            this.arrayoutput.Size = new System.Drawing.Size(338, 20);
            this.arrayoutput.TabIndex = 9;
            // 
            // arrayinput
            // 
            this.arrayinput.Location = new System.Drawing.Point(75, 26);
            this.arrayinput.Name = "arrayinput";
            this.arrayinput.Size = new System.Drawing.Size(82, 20);
            this.arrayinput.TabIndex = 11;
            // 
            // btnBuildArray
            // 
            this.btnBuildArray.Location = new System.Drawing.Point(419, 39);
            this.btnBuildArray.Name = "btnBuildArray";
            this.btnBuildArray.Size = new System.Drawing.Size(75, 38);
            this.btnBuildArray.TabIndex = 14;
            this.btnBuildArray.Text = "Set";
            this.btnBuildArray.UseVisualStyleBackColor = true;
            this.btnBuildArray.Click += new System.EventHandler(this.btnBuildArray_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "output";
            // 
            // ArrayMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 129);
            this.Controls.Add(this.groupBox2);
            this.Name = "ArrayMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArrayMaker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArrayMaker_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox arrayoutput;
        private System.Windows.Forms.TextBox arrayinput;
        private System.Windows.Forms.Button btnBuildArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}