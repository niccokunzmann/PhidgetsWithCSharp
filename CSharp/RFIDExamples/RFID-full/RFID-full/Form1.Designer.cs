namespace RFID_full
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyboardCheckBox = new System.Windows.Forms.CheckBox();
            this.output1chk = new System.Windows.Forms.CheckBox();
            this.ledChk = new System.Windows.Forms.CheckBox();
            this.output0Chk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputsTxt = new System.Windows.Forms.TextBox();
            this.versionTxt = new System.Windows.Forms.TextBox();
            this.serialTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.attachedTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.antennaChk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.protoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.writeBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.writeTagTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.writeProtoCmb = new System.Windows.Forms.ComboBox();
            this.writeBtn = new System.Windows.Forms.Button();
            this.writeLockChk = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.writeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.protoTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tagTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag Read";
            // 
            // tagTxt
            // 
            this.tagTxt.Location = new System.Drawing.Point(90, 19);
            this.tagTxt.Name = "tagTxt";
            this.tagTxt.ReadOnly = true;
            this.tagTxt.Size = new System.Drawing.Size(172, 20);
            this.tagTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tag String:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyboardCheckBox);
            this.groupBox1.Controls.Add(this.output1chk);
            this.groupBox1.Controls.Add(this.ledChk);
            this.groupBox1.Controls.Add(this.output0Chk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.outputsTxt);
            this.groupBox1.Controls.Add(this.versionTxt);
            this.groupBox1.Controls.Add(this.serialTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.attachedTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.antennaChk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 297);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Reader Info";
            // 
            // keyboardCheckBox
            // 
            this.keyboardCheckBox.AutoSize = true;
            this.keyboardCheckBox.Location = new System.Drawing.Point(19, 270);
            this.keyboardCheckBox.Name = "keyboardCheckBox";
            this.keyboardCheckBox.Size = new System.Drawing.Size(148, 17);
            this.keyboardCheckBox.TabIndex = 14;
            this.keyboardCheckBox.Text = "Keyboard Output Enabled";
            this.keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // output1chk
            // 
            this.output1chk.AutoSize = true;
            this.output1chk.Location = new System.Drawing.Point(133, 247);
            this.output1chk.Name = "output1chk";
            this.output1chk.Size = new System.Drawing.Size(67, 17);
            this.output1chk.TabIndex = 13;
            this.output1chk.Text = "Output 1";
            this.output1chk.UseVisualStyleBackColor = true;
            this.output1chk.CheckedChanged += new System.EventHandler(this.output1chk_CheckedChanged);
            // 
            // ledChk
            // 
            this.ledChk.AutoSize = true;
            this.ledChk.Location = new System.Drawing.Point(19, 247);
            this.ledChk.Name = "ledChk";
            this.ledChk.Size = new System.Drawing.Size(86, 17);
            this.ledChk.TabIndex = 12;
            this.ledChk.Text = "Led Enabled";
            this.ledChk.UseVisualStyleBackColor = true;
            this.ledChk.CheckedChanged += new System.EventHandler(this.ledChk_CheckedChanged);
            // 
            // output0Chk
            // 
            this.output0Chk.AutoSize = true;
            this.output0Chk.Location = new System.Drawing.Point(133, 224);
            this.output0Chk.Name = "output0Chk";
            this.output0Chk.Size = new System.Drawing.Size(67, 17);
            this.output0Chk.TabIndex = 11;
            this.output0Chk.Text = "Output 0";
            this.output0Chk.UseVisualStyleBackColor = true;
            this.output0Chk.CheckedChanged += new System.EventHandler(this.output0Chk_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Outputs:";
            // 
            // outputsTxt
            // 
            this.outputsTxt.Location = new System.Drawing.Point(85, 183);
            this.outputsTxt.Name = "outputsTxt";
            this.outputsTxt.ReadOnly = true;
            this.outputsTxt.Size = new System.Drawing.Size(177, 20);
            this.outputsTxt.TabIndex = 9;
            // 
            // versionTxt
            // 
            this.versionTxt.Location = new System.Drawing.Point(85, 147);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.ReadOnly = true;
            this.versionTxt.Size = new System.Drawing.Size(177, 20);
            this.versionTxt.TabIndex = 8;
            // 
            // serialTxt
            // 
            this.serialTxt.Location = new System.Drawing.Point(85, 113);
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.ReadOnly = true;
            this.serialTxt.Size = new System.Drawing.Size(177, 20);
            this.serialTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(85, 56);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(177, 48);
            this.nameTxt.TabIndex = 6;
            // 
            // attachedTxt
            // 
            this.attachedTxt.Location = new System.Drawing.Point(85, 27);
            this.attachedTxt.Name = "attachedTxt";
            this.attachedTxt.ReadOnly = true;
            this.attachedTxt.Size = new System.Drawing.Size(177, 20);
            this.attachedTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Version:";
            // 
            // antennaChk
            // 
            this.antennaChk.AutoSize = true;
            this.antennaChk.Location = new System.Drawing.Point(19, 224);
            this.antennaChk.Name = "antennaChk";
            this.antennaChk.Size = new System.Drawing.Size(108, 17);
            this.antennaChk.TabIndex = 3;
            this.antennaChk.Text = "Antenna Enabled";
            this.antennaChk.UseVisualStyleBackColor = true;
            this.antennaChk.CheckedChanged += new System.EventHandler(this.antennaChk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attached:";
            // 
            // protoTxt
            // 
            this.protoTxt.Location = new System.Drawing.Point(90, 45);
            this.protoTxt.Name = "protoTxt";
            this.protoTxt.ReadOnly = true;
            this.protoTxt.Size = new System.Drawing.Size(172, 20);
            this.protoTxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Protocol:";
            // 
            // writeBox
            // 
            this.writeBox.Controls.Add(this.writeLockChk);
            this.writeBox.Controls.Add(this.writeBtn);
            this.writeBox.Controls.Add(this.writeProtoCmb);
            this.writeBox.Controls.Add(this.label8);
            this.writeBox.Controls.Add(this.writeTagTxt);
            this.writeBox.Controls.Add(this.label9);
            this.writeBox.Location = new System.Drawing.Point(12, 395);
            this.writeBox.Name = "writeBox";
            this.writeBox.Size = new System.Drawing.Size(268, 104);
            this.writeBox.TabIndex = 4;
            this.writeBox.TabStop = false;
            this.writeBox.Text = "Tag Write";
            this.writeBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Protocol:";
            // 
            // writeTagTxt
            // 
            this.writeTagTxt.Location = new System.Drawing.Point(90, 19);
            this.writeTagTxt.Name = "writeTagTxt";
            this.writeTagTxt.Size = new System.Drawing.Size(172, 20);
            this.writeTagTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tag String:";
            // 
            // writeProtoCmb
            // 
            this.writeProtoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.writeProtoCmb.FormattingEnabled = true;
            this.writeProtoCmb.Location = new System.Drawing.Point(90, 45);
            this.writeProtoCmb.Name = "writeProtoCmb";
            this.writeProtoCmb.Size = new System.Drawing.Size(172, 21);
            this.writeProtoCmb.TabIndex = 3;
            // 
            // writeBtn
            // 
            this.writeBtn.Location = new System.Drawing.Point(187, 72);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(75, 23);
            this.writeBtn.TabIndex = 4;
            this.writeBtn.Text = "Write";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // writeLockChk
            // 
            this.writeLockChk.AutoSize = true;
            this.writeLockChk.Location = new System.Drawing.Point(90, 76);
            this.writeLockChk.Name = "writeLockChk";
            this.writeLockChk.Size = new System.Drawing.Size(50, 17);
            this.writeLockChk.TabIndex = 5;
            this.writeLockChk.Text = "Lock";
            this.writeLockChk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 511);
            this.Controls.Add(this.writeBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(298, 545);
            this.MinimumSize = new System.Drawing.Size(298, 433);
            this.Name = "Form1";
            this.Text = "RFID-full";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.writeBox.ResumeLayout(false);
            this.writeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tagTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox output1chk;
        private System.Windows.Forms.CheckBox ledChk;
        private System.Windows.Forms.CheckBox output0Chk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputsTxt;
        private System.Windows.Forms.TextBox versionTxt;
        private System.Windows.Forms.TextBox serialTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox attachedTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox antennaChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox keyboardCheckBox;
        private System.Windows.Forms.TextBox protoTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox writeBox;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.ComboBox writeProtoCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox writeTagTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox writeLockChk;
    }
}

