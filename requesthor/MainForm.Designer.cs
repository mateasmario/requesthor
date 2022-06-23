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
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuItem4 = new System.Windows.Forms.Panel();
            this.MenuItemLabel4 = new System.Windows.Forms.Label();
            this.MenuItem3 = new System.Windows.Forms.Panel();
            this.MenuItemLabel3 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.MenuItem2 = new System.Windows.Forms.Panel();
            this.MenuItemLabel2 = new System.Windows.Forms.Label();
            this.MenuItem1 = new System.Windows.Forms.Panel();
            this.MenuItemLabel1 = new System.Windows.Forms.Label();
            this.PagesTabControl = new System.Windows.Forms.TabControl();
            this.RequestsTabPage = new System.Windows.Forms.TabPage();
            this.RequestMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ResponseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StatusCodePanel = new System.Windows.Forms.Panel();
            this.StatusCodeLabel = new System.Windows.Forms.Label();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.HeadersTabPage = new System.Windows.Forms.TabPage();
            this.HeadersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BodyTabPage = new System.Windows.Forms.TabPage();
            this.BodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AuthorizationTabPage = new System.Windows.Forms.TabPage();
            this.AuthorizationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBarCloseButton = new System.Windows.Forms.Button();
            this.TitleBarPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuItem4.SuspendLayout();
            this.MenuItem3.SuspendLayout();
            this.MenuItem2.SuspendLayout();
            this.MenuItem1.SuspendLayout();
            this.PagesTabControl.SuspendLayout();
            this.RequestsTabPage.SuspendLayout();
            this.StatusCodePanel.SuspendLayout();
            this.HeadersTabPage.SuspendLayout();
            this.BodyTabPage.SuspendLayout();
            this.AuthorizationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleBarPanel.Controls.Add(this.MaximizeButton);
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
            this.MenuPanel.Controls.Add(this.CreditsButton);
            this.MenuPanel.Controls.Add(this.MenuItem4);
            this.MenuPanel.Controls.Add(this.MenuItem3);
            this.MenuPanel.Controls.Add(this.VersionLabel);
            this.MenuPanel.Controls.Add(this.MenuItem2);
            this.MenuPanel.Controls.Add(this.MenuItem1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 36);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(189, 568);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuItem4
            // 
            this.MenuItem4.Controls.Add(this.pictureBox4);
            this.MenuItem4.Controls.Add(this.MenuItemLabel4);
            this.MenuItem4.Location = new System.Drawing.Point(0, 114);
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(189, 38);
            this.MenuItem4.TabIndex = 6;
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItem4.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItem4.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MenuItemLabel4
            // 
            this.MenuItemLabel4.AutoSize = true;
            this.MenuItemLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemLabel4.ForeColor = System.Drawing.Color.White;
            this.MenuItemLabel4.Location = new System.Drawing.Point(35, 10);
            this.MenuItemLabel4.Name = "MenuItemLabel4";
            this.MenuItemLabel4.Size = new System.Drawing.Size(104, 21);
            this.MenuItemLabel4.TabIndex = 4;
            this.MenuItemLabel4.Text = "Authorization";
            this.MenuItemLabel4.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItemLabel4.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItemLabel4.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Controls.Add(this.pictureBox3);
            this.MenuItem3.Controls.Add(this.MenuItemLabel3);
            this.MenuItem3.Location = new System.Drawing.Point(0, 76);
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(189, 38);
            this.MenuItem3.TabIndex = 5;
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItem3.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItem3.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MenuItemLabel3
            // 
            this.MenuItemLabel3.AutoSize = true;
            this.MenuItemLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemLabel3.ForeColor = System.Drawing.Color.White;
            this.MenuItemLabel3.Location = new System.Drawing.Point(35, 8);
            this.MenuItemLabel3.Name = "MenuItemLabel3";
            this.MenuItemLabel3.Size = new System.Drawing.Size(45, 21);
            this.MenuItemLabel3.TabIndex = 4;
            this.MenuItemLabel3.Text = "Body";
            this.MenuItemLabel3.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItemLabel3.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItemLabel3.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(29, 498);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(123, 26);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Alpha 1.20 / 23.06.2022\r\nby Mateaș Mario";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuItem2
            // 
            this.MenuItem2.Controls.Add(this.pictureBox2);
            this.MenuItem2.Controls.Add(this.MenuItemLabel2);
            this.MenuItem2.Location = new System.Drawing.Point(0, 38);
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(189, 38);
            this.MenuItem2.TabIndex = 2;
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItem2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MenuItem2.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MenuItemLabel2
            // 
            this.MenuItemLabel2.AutoSize = true;
            this.MenuItemLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemLabel2.ForeColor = System.Drawing.Color.White;
            this.MenuItemLabel2.Location = new System.Drawing.Point(35, 8);
            this.MenuItemLabel2.Name = "MenuItemLabel2";
            this.MenuItemLabel2.Size = new System.Drawing.Size(67, 21);
            this.MenuItemLabel2.TabIndex = 4;
            this.MenuItemLabel2.Text = "Headers";
            this.MenuItemLabel2.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItemLabel2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Controls.Add(this.pictureBox1);
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
            this.MenuItemLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuItemLabel1.Location = new System.Drawing.Point(34, 8);
            this.MenuItemLabel1.Name = "MenuItemLabel1";
            this.MenuItemLabel1.Size = new System.Drawing.Size(89, 21);
            this.MenuItemLabel1.TabIndex = 3;
            this.MenuItemLabel1.Text = "Destination";
            this.MenuItemLabel1.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.MenuItemLabel1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            // 
            // PagesTabControl
            // 
            this.PagesTabControl.Controls.Add(this.RequestsTabPage);
            this.PagesTabControl.Controls.Add(this.HeadersTabPage);
            this.PagesTabControl.Controls.Add(this.BodyTabPage);
            this.PagesTabControl.Controls.Add(this.AuthorizationTabPage);
            this.PagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagesTabControl.Location = new System.Drawing.Point(189, 36);
            this.PagesTabControl.Name = "PagesTabControl";
            this.PagesTabControl.SelectedIndex = 0;
            this.PagesTabControl.Size = new System.Drawing.Size(731, 568);
            this.PagesTabControl.TabIndex = 2;
            // 
            // RequestsTabPage
            // 
            this.RequestsTabPage.Controls.Add(this.RequestMethodComboBox);
            this.RequestsTabPage.Controls.Add(this.ResponseRichTextBox);
            this.RequestsTabPage.Controls.Add(this.StatusCodePanel);
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
            // RequestMethodComboBox
            // 
            this.RequestMethodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RequestMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestMethodComboBox.FormattingEnabled = true;
            this.RequestMethodComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.RequestMethodComboBox.Location = new System.Drawing.Point(545, 6);
            this.RequestMethodComboBox.Name = "RequestMethodComboBox";
            this.RequestMethodComboBox.Size = new System.Drawing.Size(84, 26);
            this.RequestMethodComboBox.TabIndex = 4;
            // 
            // ResponseRichTextBox
            // 
            this.ResponseRichTextBox.AcceptsTab = true;
            this.ResponseRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseRichTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ResponseRichTextBox.DetectUrls = false;
            this.ResponseRichTextBox.Location = new System.Drawing.Point(6, 74);
            this.ResponseRichTextBox.Name = "ResponseRichTextBox";
            this.ResponseRichTextBox.ReadOnly = true;
            this.ResponseRichTextBox.Size = new System.Drawing.Size(711, 462);
            this.ResponseRichTextBox.TabIndex = 2;
            this.ResponseRichTextBox.Text = "";
            // 
            // StatusCodePanel
            // 
            this.StatusCodePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCodePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.StatusCodePanel.Controls.Add(this.StatusCodeLabel);
            this.StatusCodePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusCodePanel.Location = new System.Drawing.Point(6, 39);
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
            this.StatusCodeLabel.Size = new System.Drawing.Size(170, 20);
            this.StatusCodeLabel.TabIndex = 0;
            this.StatusCodeLabel.Text = "Info: No request sent yet";
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendRequestButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SendRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.SendRequestButton.FlatAppearance.BorderSize = 0;
            this.SendRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendRequestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestButton.ForeColor = System.Drawing.Color.White;
            this.SendRequestButton.Location = new System.Drawing.Point(635, 7);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(82, 25);
            this.SendRequestButton.TabIndex = 1;
            this.SendRequestButton.Text = "Send";
            this.SendRequestButton.UseVisualStyleBackColor = false;
            this.SendRequestButton.Click += new System.EventHandler(this.SendRequestButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox.Location = new System.Drawing.Point(6, 7);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(533, 25);
            this.URLTextBox.TabIndex = 0;
            this.URLTextBox.Text = "Type in a URL here";
            this.URLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLTextBox_KeyDown);
            // 
            // HeadersTabPage
            // 
            this.HeadersTabPage.Controls.Add(this.HeadersRichTextBox);
            this.HeadersTabPage.Location = new System.Drawing.Point(4, 22);
            this.HeadersTabPage.Name = "HeadersTabPage";
            this.HeadersTabPage.Size = new System.Drawing.Size(723, 542);
            this.HeadersTabPage.TabIndex = 1;
            this.HeadersTabPage.Text = "HeadersTabPage";
            this.HeadersTabPage.UseVisualStyleBackColor = true;
            // 
            // HeadersRichTextBox
            // 
            this.HeadersRichTextBox.AcceptsTab = true;
            this.HeadersRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeadersRichTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HeadersRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadersRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.HeadersRichTextBox.Name = "HeadersRichTextBox";
            this.HeadersRichTextBox.Size = new System.Drawing.Size(723, 542);
            this.HeadersRichTextBox.TabIndex = 3;
            this.HeadersRichTextBox.Text = "{\n    \"User-Agent\": \"requesthor\",\n    \"Accept\": \"application/json\"\n}";
            // 
            // BodyTabPage
            // 
            this.BodyTabPage.Controls.Add(this.BodyRichTextBox);
            this.BodyTabPage.Location = new System.Drawing.Point(4, 22);
            this.BodyTabPage.Name = "BodyTabPage";
            this.BodyTabPage.Size = new System.Drawing.Size(723, 542);
            this.BodyTabPage.TabIndex = 2;
            this.BodyTabPage.Text = "BodyTabPage";
            this.BodyTabPage.UseVisualStyleBackColor = true;
            // 
            // BodyRichTextBox
            // 
            this.BodyRichTextBox.AcceptsTab = true;
            this.BodyRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyRichTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BodyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.BodyRichTextBox.Name = "BodyRichTextBox";
            this.BodyRichTextBox.Size = new System.Drawing.Size(723, 542);
            this.BodyRichTextBox.TabIndex = 5;
            this.BodyRichTextBox.Text = "{}";
            // 
            // AuthorizationTabPage
            // 
            this.AuthorizationTabPage.Controls.Add(this.AuthorizationRichTextBox);
            this.AuthorizationTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuthorizationTabPage.Name = "AuthorizationTabPage";
            this.AuthorizationTabPage.Size = new System.Drawing.Size(723, 542);
            this.AuthorizationTabPage.TabIndex = 3;
            this.AuthorizationTabPage.Text = "AuthorizationTabPage";
            this.AuthorizationTabPage.UseVisualStyleBackColor = true;
            // 
            // AuthorizationRichTextBox
            // 
            this.AuthorizationRichTextBox.AcceptsTab = true;
            this.AuthorizationRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorizationRichTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AuthorizationRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorizationRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationRichTextBox.Name = "AuthorizationRichTextBox";
            this.AuthorizationRichTextBox.Size = new System.Drawing.Size(723, 542);
            this.AuthorizationRichTextBox.TabIndex = 6;
            this.AuthorizationRichTextBox.Text = "";
            // 
            // CreditsButton
            // 
            this.CreditsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreditsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreditsButton.Image = global::requesthor.Properties.Resources.github__1_;
            this.CreditsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditsButton.Location = new System.Drawing.Point(56, 533);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(68, 23);
            this.CreditsButton.TabIndex = 7;
            this.CreditsButton.Text = "GitHub";
            this.CreditsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreditsButton.UseVisualStyleBackColor = true;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::requesthor.Properties.Resources.padlock;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(5, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::requesthor.Properties.Resources.quill_drawing_a_line;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(5, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(5, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::requesthor.Properties.Resources.send;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MenuItem_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackgroundImage = global::requesthor.Properties.Resources.expand__1_;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.Location = new System.Drawing.Point(861, 9);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(20, 20);
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
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
            this.button1.Location = new System.Drawing.Point(830, 9);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 604);
            this.Controls.Add(this.PagesTabControl);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Requesthor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.MenuItem4.ResumeLayout(false);
            this.MenuItem4.PerformLayout();
            this.MenuItem3.ResumeLayout(false);
            this.MenuItem3.PerformLayout();
            this.MenuItem2.ResumeLayout(false);
            this.MenuItem2.PerformLayout();
            this.MenuItem1.ResumeLayout(false);
            this.MenuItem1.PerformLayout();
            this.PagesTabControl.ResumeLayout(false);
            this.RequestsTabPage.ResumeLayout(false);
            this.RequestsTabPage.PerformLayout();
            this.StatusCodePanel.ResumeLayout(false);
            this.StatusCodePanel.PerformLayout();
            this.HeadersTabPage.ResumeLayout(false);
            this.BodyTabPage.ResumeLayout(false);
            this.AuthorizationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label MenuItemLabel2;
        private System.Windows.Forms.TabControl PagesTabControl;
        private System.Windows.Forms.TabPage RequestsTabPage;
        private System.Windows.Forms.TabPage HeadersTabPage;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button SendRequestButton;
        private System.Windows.Forms.RichTextBox ResponseRichTextBox;
        private System.Windows.Forms.Panel StatusCodePanel;
        private System.Windows.Forms.Label StatusCodeLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ComboBox RequestMethodComboBox;
        private System.Windows.Forms.Panel MenuItem3;
        private System.Windows.Forms.Label MenuItemLabel3;
        private System.Windows.Forms.TabPage BodyTabPage;
        private System.Windows.Forms.RichTextBox BodyRichTextBox;
        private System.Windows.Forms.Panel MenuItem4;
        private System.Windows.Forms.Label MenuItemLabel4;
        private System.Windows.Forms.TabPage AuthorizationTabPage;
        private System.Windows.Forms.RichTextBox AuthorizationRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox HeadersRichTextBox;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.Button MaximizeButton;
    }
}

