
namespace VRQR
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
            this.listBoxScans = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpenURL = new System.Windows.Forms.Button();
            this.buttonCopyURL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxStartMinimized = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenURL = new System.Windows.Forms.CheckBox();
            this.checkBoxPlaySound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxScans
            // 
            this.listBoxScans.FormattingEnabled = true;
            this.listBoxScans.Location = new System.Drawing.Point(6, 19);
            this.listBoxScans.Name = "listBoxScans";
            this.listBoxScans.Size = new System.Drawing.Size(278, 82);
            this.listBoxScans.TabIndex = 0;
            this.listBoxScans.SelectedIndexChanged += new System.EventHandler(this.listBoxScans_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpenURL);
            this.groupBox1.Controls.Add(this.listBoxScans);
            this.groupBox1.Controls.Add(this.buttonCopyURL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scanned QR codes";
            // 
            // buttonOpenURL
            // 
            this.buttonOpenURL.Enabled = false;
            this.buttonOpenURL.Location = new System.Drawing.Point(209, 107);
            this.buttonOpenURL.Name = "buttonOpenURL";
            this.buttonOpenURL.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenURL.TabIndex = 3;
            this.buttonOpenURL.Text = "Open";
            this.buttonOpenURL.UseVisualStyleBackColor = true;
            this.buttonOpenURL.Click += new System.EventHandler(this.buttonOpenURL_Click);
            // 
            // buttonCopyURL
            // 
            this.buttonCopyURL.Enabled = false;
            this.buttonCopyURL.Location = new System.Drawing.Point(128, 107);
            this.buttonCopyURL.Name = "buttonCopyURL";
            this.buttonCopyURL.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyURL.TabIndex = 2;
            this.buttonCopyURL.Text = "Copy";
            this.buttonCopyURL.UseVisualStyleBackColor = true;
            this.buttonCopyURL.Click += new System.EventHandler(this.buttonCopyURL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxStartMinimized);
            this.groupBox2.Controls.Add(this.checkBoxOpenURL);
            this.groupBox2.Controls.Add(this.checkBoxPlaySound);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBoxStartMinimized
            // 
            this.checkBoxStartMinimized.AutoSize = true;
            this.checkBoxStartMinimized.Location = new System.Drawing.Point(9, 38);
            this.checkBoxStartMinimized.Name = "checkBoxStartMinimized";
            this.checkBoxStartMinimized.Size = new System.Drawing.Size(96, 17);
            this.checkBoxStartMinimized.TabIndex = 6;
            this.checkBoxStartMinimized.Text = "Start minimized";
            this.checkBoxStartMinimized.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenURL
            // 
            this.checkBoxOpenURL.AutoSize = true;
            this.checkBoxOpenURL.Location = new System.Drawing.Point(199, 15);
            this.checkBoxOpenURL.Name = "checkBoxOpenURL";
            this.checkBoxOpenURL.Size = new System.Drawing.Size(77, 17);
            this.checkBoxOpenURL.TabIndex = 4;
            this.checkBoxOpenURL.Text = "Open URL";
            this.checkBoxOpenURL.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlaySound
            // 
            this.checkBoxPlaySound.AutoSize = true;
            this.checkBoxPlaySound.Location = new System.Drawing.Point(115, 15);
            this.checkBoxPlaySound.Name = "checkBoxPlaySound";
            this.checkBoxPlaySound.Size = new System.Drawing.Size(78, 17);
            this.checkBoxPlaySound.TabIndex = 3;
            this.checkBoxPlaySound.Text = "Play sound";
            this.checkBoxPlaySound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "On successful scan:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 231);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VRQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxScans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCopyURL;
        private System.Windows.Forms.Button buttonOpenURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPlaySound;
        private System.Windows.Forms.CheckBox checkBoxOpenURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxStartMinimized;
    }
}

