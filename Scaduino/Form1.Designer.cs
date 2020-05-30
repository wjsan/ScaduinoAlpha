namespace Scaduino
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
            this.components = new System.ComponentModel.Container();
            this.screens = new ModernUI.ScreenContainer();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.button1 = new Scaduino.Controls.Button();
            this.serialArduino1 = new Scaduino.Components.SerialArduino(this.components);
            this.menu1 = new ModernUI.Menu();
            this.menuItem3 = new ModernUI.MenuItem();
            this.menuItem2 = new ModernUI.MenuItem();
            this.menuItem1 = new ModernUI.MenuItem();
            this.hideMenu1 = new ModernUI.HideMenu();
            this.screenHeader1 = new ModernUI.ScreenHeader();
            this.control1 = new System.Windows.Forms.Control();
            this.control2 = new System.Windows.Forms.Control();
            this.control3 = new System.Windows.Forms.Control();
            this.control4 = new System.Windows.Forms.Control();
            this.pin1 = new Scaduino.Components.Pin();
            this.screens.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screens
            // 
            this.screens.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.screens.Controls.Add(this.tabHome);
            this.screens.Controls.Add(this.tabControl);
            this.screens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screens.ItemSize = new System.Drawing.Size(0, 1);
            this.screens.Location = new System.Drawing.Point(158, 74);
            this.screens.Name = "screens";
            this.screens.SelectedIndex = 0;
            this.screens.SelectedScreen = this.tabControl;
            this.screens.Size = new System.Drawing.Size(669, 474);
            this.screens.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.screens.TabIndex = 2;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 5);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(661, 465);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(227, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem Vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.button1);
            this.tabControl.Location = new System.Drawing.Point(4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(661, 465);
            this.tabControl.TabIndex = 1;
            this.tabControl.Text = "Control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.ColorMouseEnter = System.Drawing.Color.Gray;
            this.button1.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.button1.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button1.Device = this.serialArduino1;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ForeColorMouseEnter = System.Drawing.Color.White;
            this.button1.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.button1.ForeColorOnClick = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(57, 50);
            this.button1.Name = "button1";
            this.button1.Pin = null;
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialArduino1
            // 
            this.serialArduino1.BaudRate = 9600;
            this.serialArduino1.PortName = "COM1";
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu1.ButtonHideOnOnverColor = System.Drawing.Color.Empty;
            this.menu1.Controls.Add(this.menuItem3);
            this.menu1.Controls.Add(this.menuItem2);
            this.menu1.Controls.Add(this.menuItem1);
            this.menu1.Controls.Add(this.hideMenu1);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Hidden = false;
            this.menu1.Location = new System.Drawing.Point(0, 74);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(158, 474);
            this.menu1.TabIndex = 1;
            // 
            // menuItem3
            // 
            this.menuItem3.AutoColors = true;
            this.menuItem3.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem3.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuItem3.ColorMouseLeave = System.Drawing.SystemColors.Highlight;
            this.menuItem3.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.menuItem3.ColorSelected = System.Drawing.SystemColors.Highlight;
            this.menuItem3.ColorSelectedIndicator = System.Drawing.SystemColors.HighlightText;
            this.menuItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItem3.ExitApplication = true;
            this.menuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem3.Image = null;
            this.menuItem3.LabelText = "Sair";
            this.menuItem3.Location = new System.Drawing.Point(0, 78);
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItem3.ScreenController = null;
            this.menuItem3.ScreenControllerIdx = 0;
            this.menuItem3.Selected = false;
            this.menuItem3.Size = new System.Drawing.Size(148, 39);
            this.menuItem3.TabIndex = 2;
            this.menuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuItem2
            // 
            this.menuItem2.AutoColors = true;
            this.menuItem2.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem2.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuItem2.ColorMouseLeave = System.Drawing.SystemColors.Highlight;
            this.menuItem2.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.menuItem2.ColorSelected = System.Drawing.SystemColors.Highlight;
            this.menuItem2.ColorSelectedIndicator = System.Drawing.SystemColors.HighlightText;
            this.menuItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItem2.ExitApplication = false;
            this.menuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem2.Image = null;
            this.menuItem2.LabelText = "Control";
            this.menuItem2.Location = new System.Drawing.Point(0, 39);
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItem2.ScreenController = this.screens;
            this.menuItem2.ScreenControllerIdx = 1;
            this.menuItem2.Selected = false;
            this.menuItem2.Size = new System.Drawing.Size(148, 39);
            this.menuItem2.TabIndex = 1;
            this.menuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuItem1
            // 
            this.menuItem1.AutoColors = true;
            this.menuItem1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem1.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuItem1.ColorMouseLeave = System.Drawing.SystemColors.Highlight;
            this.menuItem1.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.menuItem1.ColorSelected = System.Drawing.SystemColors.Highlight;
            this.menuItem1.ColorSelectedIndicator = System.Drawing.SystemColors.HighlightText;
            this.menuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItem1.ExitApplication = false;
            this.menuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem1.Image = null;
            this.menuItem1.LabelText = "Home";
            this.menuItem1.Location = new System.Drawing.Point(0, 0);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItem1.ScreenController = this.screens;
            this.menuItem1.ScreenControllerIdx = 0;
            this.menuItem1.Selected = true;
            this.menuItem1.Size = new System.Drawing.Size(148, 39);
            this.menuItem1.TabIndex = 0;
            this.menuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hideMenu1
            // 
            this.hideMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hideMenu1.BackColorOnOver = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.hideMenu1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideMenu1.Location = new System.Drawing.Point(148, 0);
            this.hideMenu1.Menu = this.menu1;
            this.hideMenu1.Name = "hideMenu1";
            this.hideMenu1.Size = new System.Drawing.Size(10, 474);
            this.hideMenu1.TabIndex = 3;
            this.hideMenu1.Text = "<";
            this.hideMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // screenHeader1
            // 
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Padding = new System.Windows.Forms.Padding(10);
            this.screenHeader1.ScreenController = this.screens;
            this.screenHeader1.Size = new System.Drawing.Size(827, 74);
            this.screenHeader1.TabIndex = 0;
            this.screenHeader1.Text = "Control";
            this.screenHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(0, 0);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // control2
            // 
            this.control2.Location = new System.Drawing.Point(0, 0);
            this.control2.Name = "control2";
            this.control2.Size = new System.Drawing.Size(0, 0);
            this.control2.TabIndex = 0;
            this.control2.Text = "control2";
            // 
            // control3
            // 
            this.control3.Location = new System.Drawing.Point(0, 0);
            this.control3.Name = "control3";
            this.control3.Size = new System.Drawing.Size(0, 0);
            this.control3.TabIndex = 0;
            this.control3.Text = "control3";
            // 
            // control4
            // 
            this.control4.Location = new System.Drawing.Point(0, 0);
            this.control4.Name = "control4";
            this.control4.Size = new System.Drawing.Size(0, 0);
            this.control4.TabIndex = 0;
            this.control4.Text = "control4";
            // 
            // pin1
            // 
            this.pin1.Arduino = this.serialArduino1;
            this.pin1.PinMode = Scaduino.Components.Pin.PinType.Input;
            this.pin1.PinName = "Pin";
            this.pin1.PinNumber = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(827, 548);
            this.Controls.Add(this.screens);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.screenHeader1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.screens.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.menu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ModernUI.ScreenHeader screenHeader1;
        private ModernUI.Menu menu1;
        private ModernUI.MenuItem menuItem3;
        private ModernUI.MenuItem menuItem2;
        private ModernUI.MenuItem menuItem1;
        private ModernUI.HideMenu hideMenu1;
        private ModernUI.ScreenContainer screens;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.Control control2;
        private System.Windows.Forms.Control control3;
        private System.Windows.Forms.Control control4;
        private Components.SerialArduino serialArduino1;
        private Controls.Button button1;
        private Components.Pin pin1;
    }
}