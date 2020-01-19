namespace bhojarajsahu88.VSQuickShare.Forms
{
    partial class QuickShare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickShare));
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShare = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.labelLink = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.linkLabelFeedback = new System.Windows.Forms.LinkLabel();
            this.linkLabelLink = new System.Windows.Forms.LinkLabel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.panelCode = new System.Windows.Forms.Panel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.toolTipLink = new System.Windows.Forms.ToolTip(this.components);
            this.labelMaxChar = new System.Windows.Forms.Label();
            this.labelUsed = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelUsed);
            this.panelHead.Controls.Add(this.labelMaxChar);
            this.panelHead.Controls.Add(this.buttonClear);
            this.panelHead.Controls.Add(this.buttonShare);
            this.panelHead.Controls.Add(this.textBoxLink);
            this.panelHead.Controls.Add(this.buttonGet);
            this.panelHead.Controls.Add(this.labelLink);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(894, 70);
            this.panelHead.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(708, 10);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShare
            // 
            this.buttonShare.Location = new System.Drawing.Point(555, 10);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(110, 23);
            this.buttonShare.TabIndex = 3;
            this.buttonShare.Text = "Share";
            this.buttonShare.UseVisualStyleBackColor = true;
            this.buttonShare.Click += new System.EventHandler(this.buttonShare_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxLink.Location = new System.Drawing.Point(107, 12);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(275, 20);
            this.textBoxLink.TabIndex = 1;
            this.textBoxLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLink_MouseClick);
            this.textBoxLink.MouseEnter += new System.EventHandler(this.textBoxLink_MouseEnter);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(422, 10);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(110, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(71, 15);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(30, 13);
            this.labelLink.TabIndex = 0;
            this.labelLink.Text = "Link:";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.linkLabelFeedback);
            this.panelFooter.Controls.Add(this.linkLabelLink);
            this.panelFooter.Controls.Add(this.buttonCopy);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 425);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(894, 41);
            this.panelFooter.TabIndex = 1;
            // 
            // linkLabelFeedback
            // 
            this.linkLabelFeedback.AutoSize = true;
            this.linkLabelFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelFeedback.Location = new System.Drawing.Point(212, 16);
            this.linkLabelFeedback.Name = "linkLabelFeedback";
            this.linkLabelFeedback.Size = new System.Drawing.Size(55, 13);
            this.linkLabelFeedback.TabIndex = 4;
            this.linkLabelFeedback.TabStop = true;
            this.linkLabelFeedback.Text = "Feedback";
            this.linkLabelFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFeedback_LinkClicked);
            // 
            // linkLabelLink
            // 
            this.linkLabelLink.AutoSize = true;
            this.linkLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLink.Location = new System.Drawing.Point(36, 16);
            this.linkLabelLink.Name = "linkLabelLink";
            this.linkLabelLink.Size = new System.Drawing.Size(143, 13);
            this.linkLabelLink.TabIndex = 4;
            this.linkLabelLink.TabStop = true;
            this.linkLabelLink.Text = "http://www.lazzycoder.com/";
            this.linkLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLink_LinkClicked);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(565, 6);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(110, 23);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Copy Code";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.textBoxCode);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCode.Location = new System.Drawing.Point(0, 70);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(894, 355);
            this.panelCode.TabIndex = 2;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCode.Location = new System.Drawing.Point(0, 0);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCode.Size = new System.Drawing.Size(894, 355);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // labelMaxChar
            // 
            this.labelMaxChar.AutoSize = true;
            this.labelMaxChar.Location = new System.Drawing.Point(597, 50);
            this.labelMaxChar.Name = "labelMaxChar";
            this.labelMaxChar.Size = new System.Drawing.Size(100, 13);
            this.labelMaxChar.TabIndex = 5;
            this.labelMaxChar.Text = "Max Character Limit";
            // 
            // labelUsed
            // 
            this.labelUsed.AutoSize = true;
            this.labelUsed.Location = new System.Drawing.Point(760, 50);
            this.labelUsed.Name = "labelUsed";
            this.labelUsed.Size = new System.Drawing.Size(32, 13);
            this.labelUsed.TabIndex = 6;
            this.labelUsed.Text = "Used";
            // 
            // QuickShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 466);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 500);
            this.MinimumSize = new System.Drawing.Size(910, 500);
            this.Name = "QuickShare";
            this.Text = "Quick Share";
            this.Load += new System.EventHandler(this.QuickShare_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Button buttonShare;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolTip toolTipLink;
        private System.Windows.Forms.LinkLabel linkLabelFeedback;
        private System.Windows.Forms.LinkLabel linkLabelLink;
        private System.Windows.Forms.Label labelMaxChar;
        private System.Windows.Forms.Label labelUsed;
    }
}