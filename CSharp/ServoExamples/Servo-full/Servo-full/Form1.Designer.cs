namespace Servo_full
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
            this.servoTypeCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.engagedCheckBox = new System.Windows.Forms.CheckBox();
            this.positionTrk = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.positionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.servoNumCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servosTxt = new System.Windows.Forms.TextBox();
            this.versionTxt = new System.Windows.Forms.TextBox();
            this.serialTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.attachedTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrk)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servoTypeCmb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.engagedCheckBox);
            this.groupBox2.Controls.Add(this.positionTrk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.positionTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.servoNumCombo);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 195);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servo Position";
            // 
            // servoTypeCmb
            // 
            this.servoTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servoTypeCmb.Enabled = false;
            this.servoTypeCmb.FormattingEnabled = true;
            this.servoTypeCmb.Location = new System.Drawing.Point(68, 46);
            this.servoTypeCmb.Name = "servoTypeCmb";
            this.servoTypeCmb.Size = new System.Drawing.Size(193, 21);
            this.servoTypeCmb.TabIndex = 44;
            this.servoTypeCmb.SelectedIndexChanged += new System.EventHandler(this.servoTypeCmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Type:";
            // 
            // engagedCheckBox
            // 
            this.engagedCheckBox.AutoSize = true;
            this.engagedCheckBox.Enabled = false;
            this.engagedCheckBox.Location = new System.Drawing.Point(68, 167);
            this.engagedCheckBox.Name = "engagedCheckBox";
            this.engagedCheckBox.Size = new System.Drawing.Size(69, 17);
            this.engagedCheckBox.TabIndex = 5;
            this.engagedCheckBox.Text = "Engaged";
            this.engagedCheckBox.UseVisualStyleBackColor = true;
            this.engagedCheckBox.CheckedChanged += new System.EventHandler(this.engagedCheckBox_CheckedChanged);
            // 
            // positionTrk
            // 
            this.positionTrk.Enabled = false;
            this.positionTrk.Location = new System.Drawing.Point(68, 119);
            this.positionTrk.Name = "positionTrk";
            this.positionTrk.Size = new System.Drawing.Size(193, 45);
            this.positionTrk.TabIndex = 4;
            this.positionTrk.Scroll += new System.EventHandler(this.positionTrk_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Position:";
            // 
            // positionTxt
            // 
            this.positionTxt.Location = new System.Drawing.Point(68, 84);
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.ReadOnly = true;
            this.positionTxt.Size = new System.Drawing.Size(193, 20);
            this.positionTxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Servo No.:";
            // 
            // servoNumCombo
            // 
            this.servoNumCombo.Enabled = false;
            this.servoNumCombo.FormattingEnabled = true;
            this.servoNumCombo.Location = new System.Drawing.Point(130, 19);
            this.servoNumCombo.Name = "servoNumCombo";
            this.servoNumCombo.Size = new System.Drawing.Size(69, 21);
            this.servoNumCombo.TabIndex = 0;
            this.servoNumCombo.SelectedIndexChanged += new System.EventHandler(this.servoNumCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.servosTxt);
            this.groupBox1.Controls.Add(this.versionTxt);
            this.groupBox1.Controls.Add(this.serialTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.attachedTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servo Info";
            // 
            // servosTxt
            // 
            this.servosTxt.Location = new System.Drawing.Point(68, 196);
            this.servosTxt.Name = "servosTxt";
            this.servosTxt.ReadOnly = true;
            this.servosTxt.Size = new System.Drawing.Size(193, 20);
            this.servosTxt.TabIndex = 9;
            // 
            // versionTxt
            // 
            this.versionTxt.Location = new System.Drawing.Point(68, 158);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.ReadOnly = true;
            this.versionTxt.Size = new System.Drawing.Size(193, 20);
            this.versionTxt.TabIndex = 8;
            // 
            // serialTxt
            // 
            this.serialTxt.Location = new System.Drawing.Point(68, 121);
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.ReadOnly = true;
            this.serialTxt.Size = new System.Drawing.Size(193, 20);
            this.serialTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(68, 57);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(193, 51);
            this.nameTxt.TabIndex = 6;
            // 
            // attachedTxt
            // 
            this.attachedTxt.Location = new System.Drawing.Point(68, 24);
            this.attachedTxt.Name = "attachedTxt";
            this.attachedTxt.ReadOnly = true;
            this.attachedTxt.Size = new System.Drawing.Size(193, 20);
            this.attachedTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Servos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attached:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Servo-full";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar positionTrk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox positionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox servoNumCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox servosTxt;
        private System.Windows.Forms.TextBox versionTxt;
        private System.Windows.Forms.TextBox serialTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox attachedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox engagedCheckBox;
        private System.Windows.Forms.ComboBox servoTypeCmb;
        private System.Windows.Forms.Label label8;
    }
}

