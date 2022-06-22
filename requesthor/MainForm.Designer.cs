namespace requesthor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBarCloseButton = new System.Windows.Forms.Button();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuItem2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuItem1 = new System.Windows.Forms.Panel();
            this.MenuItemLabel1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RequestsTabPage = new System.Windows.Forms.TabPage();
            this.StatusCodePanel = new System.Windows.Forms.Panel();
            this.StatusCodeLabel = new System.Windows.Forms.Label();
            this.ResponseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.HeadersTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleBarPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuItem2.SuspendLayout();
            this.MenuItem1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RequestsTabPage.SuspendLayout();
            this.StatusCodePanel.SuspendLayout();
            this.HeadersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleBarPanel.Controls.Add(this.button1);
            this.TitleBarPanel.Controls.Add(this.TitleBarCloseButton);
            this.TitleBarPanel.Controls.Add(this.TitleBarLabel);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(920, 36);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.TitleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.TitleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::requesthor.Properties.Resources.Minimize;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(863, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TitleBarMinimizeButton_Click);
            // 
            // TitleBarCloseButton
            // 
            this.TitleBarCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBarCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBarCloseButton.BackgroundImage")));
            this.TitleBarCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBarCloseButton.FlatAppearance.BorderSize = 0;
            this.TitleBarCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.TitleBarCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.TitleBarCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarCloseButton.ForeColor = System.Drawing.Color.White;
            this.TitleBarCloseButton.Location = new System.Drawing.Point(893, 9);
            this.TitleBarCloseButton.Name = "TitleBarCloseButton";
            this.TitleBarCloseButton.Size = new System.Drawing.Size(20, 20);
            this.TitleBarCloseButton.TabIndex = 2;
            this.TitleBarCloseButton.UseVisualStyleBackColor = true;
            this.TitleBarCloseButton.Click += new System.EventHandler(this.TitleBarCloseButton_Click);
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarLabel.ForeColor = System.Drawing.Color.White;
            this.TitleBarLabel.Location = new System.Drawing.Point(5, 8);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(85, 24);
            this.TitleBarLabel.TabIndex = 1;
            this.TitleBarLabel.Text = "requesthor";
            this.TitleBarLabel.UseCompatibleTextRendering = true;
            this.TitleBarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.TitleBarLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.TitleBarLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.MenuItem2);
            this.MenuPanel.Controls.Add(this.MenuItem1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 36);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(189, 568);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuItem2
            // 
            this.MenuItem2.Controls.Add(this.label1);
            this.MenuItem2.Location = new System.Drawing.Point(0, 38);
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(189, 38);
            this.MenuItem2.TabIndex = 2;
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItem2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItem2.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Headers";
            this.label1.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.label1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Controls.Add(this.MenuItemLabel1);
            this.MenuItem1.Location = new System.Drawing.Point(0, 0);
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(189, 38);
            this.MenuItem1.TabIndex = 1;
            this.MenuItem1.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItem1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItem1.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MenuItemLabel1
            // 
            this.MenuItemLabel1.AutoSize = true;
            this.MenuItemLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemLabel1.ForeColor = System.Drawing.Color.White;
            this.MenuItemLabel1.Location = new System.Drawing.Point(8, 8);
            this.MenuItemLabel1.Name = "MenuItemLabel1";
            this.MenuItemLabel1.Size = new System.Drawing.Size(66, 21);
            this.MenuItemLabel1.TabIndex = 3;
            this.MenuItemLabel1.Text = "Request";
            this.MenuItemLabel1.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItemLabel1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RequestsTabPage);
            this.tabControl1.Controls.Add(this.HeadersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(189, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 568);
            this.tabControl1.TabIndex = 2;
            // 
            // RequestsTabPage
            // 
            this.RequestsTabPage.Controls.Add(this.StatusCodePanel);
            this.RequestsTabPage.Controls.Add(this.ResponseRichTextBox);
            this.RequestsTabPage.Controls.Add(this.SendRequestButton);
            this.RequestsTabPage.Controls.Add(this.URLTextBox);
            this.RequestsTabPage.Location = new System.Drawing.Point(4, 22);
            this.RequestsTabPage.Name = "RequestsTabPage";
            this.RequestsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RequestsTabPage.Size = new System.Drawing.Size(723, 542);
            this.RequestsTabPage.TabIndex = 0;
            this.RequestsTabPage.Text = "RequestsTabPage";
            this.RequestsTabPage.UseVisualStyleBackColor = true;
            // 
            // StatusCodePanel
            // 
            this.StatusCodePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCodePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StatusCodePanel.Controls.Add(this.StatusCodeLabel);
            this.StatusCodePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusCodePanel.Location = new System.Drawing.Point(6, 46);
            this.StatusCodePanel.Name = "StatusCodePanel";
            this.StatusCodePanel.Size = new System.Drawing.Size(711, 29);
            this.StatusCodePanel.TabIndex = 3;
            // 
            // StatusCodeLabel
            // 
            this.StatusCodeLabel.AutoSize = true;
            this.StatusCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCodeLabel.ForeColor = System.Drawing.Color.White;
            this.StatusCodeLabel.Location = new System.Drawing.Point(3, 4);
            this.StatusCodeLabel.Name = "StatusCodeLabel";
            this.StatusCodeLabel.Size = new System.Drawing.Size(57, 20);
            this.StatusCodeLabel.TabIndex = 0;
            this.StatusCodeLabel.Text = "200 OK";
            // 
            // ResponseRichTextBox
            // 
            this.ResponseRichTextBox.AcceptsTab = true;
            this.ResponseRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseRichTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ResponseRichTextBox.DetectUrls = false;
            this.ResponseRichTextBox.Location = new System.Drawing.Point(6, 87);
            this.ResponseRichTextBox.Name = "ResponseRichTextBox";
            this.ResponseRichTextBox.ReadOnly = true;
            this.ResponseRichTextBox.Size = new System.Drawing.Size(711, 447);
            this.ResponseRichTextBox.TabIndex = 2;
            this.ResponseRichTextBox.Text = "";
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendRequestButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SendRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.SendRequestButton.FlatAppearance.BorderSize = 0;
            this.SendRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendRequestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestButton.ForeColor = System.Drawing.Color.White;
            this.SendRequestButton.Location = new System.Drawing.Point(635, 15);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(82, 25);
            this.SendRequestButton.TabIndex = 1;
            this.SendRequestButton.Text = "GET";
            this.SendRequestButton.UseVisualStyleBackColor = false;
            this.SendRequestButton.Click += new System.EventHandler(this.SendRequestButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox.Location = new System.Drawing.Point(6, 15);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(623, 25);
            this.URLTextBox.TabIndex = 0;
            this.URLTextBox.Text = "Type in a URL here";
            this.URLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLTextBox_KeyDown);
            // 
            // HeadersTabPage
            // 
            this.HeadersTabPage.Controls.Add(this.label2);
            this.HeadersTabPage.Controls.Add(this.HeadersRichTextBox);
            this.HeadersTabPage.Location = new System.Drawing.Point(4, 22);
            this.HeadersTabPage.Name = "HeadersTabPage";
            this.HeadersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HeadersTabPage.Size = new System.Drawing.Size(723, 542);
            this.HeadersTabPage.TabIndex = 1;
            this.HeadersTabPage.Text = "HeadersTabPage";
            this.HeadersTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please specify the headers in JSON format.";
            // 
            // HeadersRichTextBox
            // 
            this.HeadersRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadersRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeadersRichTextBox.Location = new System.Drawing.Point(6, 24);
            this.HeadersRichTextBox.Name = "HeadersRichTextBox";
            this.HeadersRichTextBox.Size = new System.Drawing.Size(711, 512);
            this.HeadersRichTextBox.TabIndex = 3;
            this.HeadersRichTextBox.Text = "{\n    \"User-Agent\": \"requesthor\"\n}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.00 / 22.06.2022";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 604);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Requesthor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.MenuItem2.ResumeLayout(false);
            this.MenuItem2.PerformLayout();
            this.MenuItem1.ResumeLayout(false);
            this.MenuItem1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RequestsTabPage.ResumeLayout(false);
            this.RequestsTabPage.PerformLayout();
            this.StatusCodePanel.ResumeLayout(false);
            this.StatusCodePanel.PerformLayout();
            this.HeadersTabPage.ResumeLayout(false);
            this.HeadersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label TitleBarLabel;
        private System.Windows.Forms.Button TitleBarCloseButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MenuItem2;
        private System.Windows.Forms.Panel MenuItem1;
        private System.Windows.Forms.Label MenuItemLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RequestsTabPage;
        private System.Windows.Forms.TabPage HeadersTabPage;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button SendRequestButton;
        private System.Windows.Forms.RichTextBox ResponseRichTextBox;
        private System.Windows.Forms.Panel StatusCodePanel;
        private System.Windows.Forms.Label StatusCodeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox HeadersRichTextBox;
        private System.Windows.Forms.Label label3;
    }
}

