using requesthor.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace requesthor
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Important Overrides
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion Important Overrides

        #region Helper Methods

        #region Design Helper Methods

        public void DesignFix()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            Application.EnableVisualStyles();
        }

        public void HideTabControlHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.ItemSize = new System.Drawing.Size(0, 1);
            tabControl.Multiline = true;
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        public void InitializeTitleBar()
        {
            TitleBarLabel.Font = new Font(Globals.privateFontCollection.Families[0], TitleBarLabel.Font.Size);
            TitleBarPanel.BackColor = Color.FromArgb(33, 33, 33);
        }

        public void InitializeMenuPanel()
        {
            MenuPanel.BackColor = Color.FromArgb(33, 33, 33);
        }

        public void InitializeTextBoxes()
        {
            URLTextBox.Font = new Font(Globals.privateFontCollection.Families[1], URLTextBox.Font.Size);
            URLTextBox.Select();
            ResponseRichTextBox.Font = new Font(Globals.privateFontCollection.Families[1], ResponseRichTextBox.Font.Size);
            HeadersRichTextBox.Font = new Font(Globals.privateFontCollection.Families[1], HeadersRichTextBox.Font.Size);
            BodyRichTextBox.Font = new Font(Globals.privateFontCollection.Families[1], BodyRichTextBox.Font.Size);
            AuthorizationRichTextBox.Font = new Font(Globals.privateFontCollection.Families[1], AuthorizationRichTextBox.Font.Size);

            ResponseRichTextBox.Text = "You will see the request response here.";
        }

        public void SelectMenuItem(Panel senderPanel)
        {
            MenuItem1.BackColor = Color.FromArgb(33, 33, 33);
            MenuItem2.BackColor = Color.FromArgb(33, 33, 33);
            MenuItem3.BackColor = Color.FromArgb(33, 33, 33);
            MenuItem4.BackColor = Color.FromArgb(33, 33, 33);

            senderPanel.BackColor = Color.FromArgb(49, 126, 168);
        }

        #endregion Design Helper Methods

        #endregion Helper Methods

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            DesignFix();
            HideTabControlHeader(PagesTabControl);

            ResourceManagerService.InitializeFontCollection();
            InitializeTitleBar();
            InitializeMenuPanel();
            InitializeTextBoxes();

            RequestMethodComboBox.SelectedIndex = 0;

            SelectMenuItem(MenuItem1);
        }

        private void TitleBarCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TitleBarMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Globals.mouseDown = true;
            Globals.lastLocation = e.Location;
        }

        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Globals.mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - Globals.lastLocation.X) + e.X, (this.Location.Y - Globals.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TitleBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Globals.mouseDown = false;
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            Panel senderPanel = null;

            if (sender is Label)
                senderPanel = (Panel)((Label)sender).Parent;
            else if (sender is PictureBox)
                senderPanel = (Panel)((PictureBox)sender).Parent;
            else if (sender is Panel)
                senderPanel = (Panel)sender;

            if (senderPanel.BackColor != Color.FromArgb(49, 126, 168))
                senderPanel.BackColor = Color.FromArgb(98, 162, 196);
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            Panel senderPanel = null;

            if (sender is Label)
                senderPanel = (Panel)((Label)sender).Parent;
            else if (sender is PictureBox)
                senderPanel = (Panel)((PictureBox)sender).Parent;
            else if (sender is Panel)
                senderPanel = (Panel)sender;

            if (senderPanel.BackColor != Color.FromArgb(49, 126, 168))
                senderPanel.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void MenuItem_MouseClick(object sender, EventArgs e)
        {
            Panel senderPanel = null;

            if (sender is Label)
                senderPanel = (Panel)((Label)sender).Parent;
            else if (sender is PictureBox)
                senderPanel = (Panel)((PictureBox)sender).Parent;
            else if (sender is Panel)
                senderPanel = (Panel)sender;

            SelectMenuItem(senderPanel);

            // open tab page
            if (senderPanel == MenuItem1)
                PagesTabControl.SelectTab(0);
            else if (senderPanel == MenuItem2)
                PagesTabControl.SelectTab(1);
            else if (senderPanel == MenuItem3)
                PagesTabControl.SelectTab(2);
            else if (senderPanel == MenuItem4)
                PagesTabControl.SelectTab(3);
        }

        private void SendRequestButton_Click(object sender, EventArgs e)
        {
            RequestService.SendRequest(RequestMethodComboBox.Text, URLTextBox.Text, HeadersRichTextBox.Text, BodyRichTextBox.Text, AuthorizationRichTextBox.Text, ResponseRichTextBox, StatusCodeLabel);
        }

        private void URLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestService.SendRequest(RequestMethodComboBox.Text, URLTextBox.Text, HeadersRichTextBox.Text, BodyRichTextBox.Text, AuthorizationRichTextBox.Text, ResponseRichTextBox, StatusCodeLabel);
            }
        }
        private void CreditsButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mateasmario/requesthor");
        }

        #endregion Events
    }
}
