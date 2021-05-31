
namespace VRCQR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonOpenInBrowser = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.HorizontalScrollbar = true;
            this.listBoxHistory.ItemHeight = 14;
            this.listBoxHistory.Location = new System.Drawing.Point(12, 24);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.ScrollAlwaysVisible = true;
            this.listBoxHistory.Size = new System.Drawing.Size(332, 116);
            this.listBoxHistory.TabIndex = 0;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxHistory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR codes scanned:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Location = new System.Drawing.Point(106, 146);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(116, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy to clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonOpenInBrowser
            // 
            this.buttonOpenInBrowser.Enabled = false;
            this.buttonOpenInBrowser.Location = new System.Drawing.Point(228, 146);
            this.buttonOpenInBrowser.Name = "buttonOpenInBrowser";
            this.buttonOpenInBrowser.Size = new System.Drawing.Size(116, 23);
            this.buttonOpenInBrowser.TabIndex = 3;
            this.buttonOpenInBrowser.Text = "Open in browser";
            this.buttonOpenInBrowser.UseVisualStyleBackColor = true;
            this.buttonOpenInBrowser.Click += new System.EventHandler(this.buttonOpenInBrowser_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(12, 146);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(57, 23);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 182);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonOpenInBrowser);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VRCQR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonOpenInBrowser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAout;
        private System.Windows.Forms.Button buttonAbout;
    }
}

