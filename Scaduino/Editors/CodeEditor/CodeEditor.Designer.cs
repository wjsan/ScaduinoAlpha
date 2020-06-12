namespace Scaduino.Editors
{
    partial class CodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
            Scaduino.Editors.SyntaxRegexStyle syntaxRegexStyle1 = new Scaduino.Editors.SyntaxRegexStyle();
            Scaduino.Editors.SyntaxRegexStyle syntaxRegexStyle2 = new Scaduino.Editors.SyntaxRegexStyle();
            Scaduino.Editors.SyntaxRegexStyle syntaxRegexStyle3 = new Scaduino.Editors.SyntaxRegexStyle();
            Scaduino.Editors.SyntaxRegexStyle syntaxRegexStyle4 = new Scaduino.Editors.SyntaxRegexStyle();
            Scaduino.Editors.SyntaxRegexStyle syntaxRegexStyle5 = new Scaduino.Editors.SyntaxRegexStyle();
            Scaduino.Editors.SyntaxStyle syntaxStyle1 = new Scaduino.Editors.SyntaxStyle();
            Scaduino.Editors.SyntaxStyle syntaxStyle2 = new Scaduino.Editors.SyntaxStyle();
            Scaduino.Editors.SyntaxStyle syntaxStyle3 = new Scaduino.Editors.SyntaxStyle();
            Scaduino.Editors.SyntaxStyle syntaxStyle4 = new Scaduino.Editors.SyntaxStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.filesExplorer = new CommonControls.FilesExplorer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.screenHeaderFileName = new ModernUI.ScreenHeader();
            this.screenHeader1 = new ModernUI.ScreenHeader();
            this.codeStyle = new Scaduino.Editors.CodeStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filesExplorer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fastColoredTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.screenHeaderFileName);
            this.splitContainer1.Size = new System.Drawing.Size(800, 431);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // filesExplorer
            // 
            this.filesExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.filesExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesExplorer.ForeColor = System.Drawing.Color.White;
            this.filesExplorer.HideEmptyFolders = false;
            this.filesExplorer.ImageIndex = 0;
            this.filesExplorer.ImageList = this.imageList1;
            this.filesExplorer.Location = new System.Drawing.Point(0, 0);
            this.filesExplorer.Name = "filesExplorer";
            this.filesExplorer.Paths = new string[0];
            this.filesExplorer.PathsNames = new string[0];
            this.filesExplorer.SelectedImageIndex = 0;
            this.filesExplorer.Size = new System.Drawing.Size(266, 431);
            this.filesExplorer.TabIndex = 0;
            this.filesExplorer.WatchedPath = "";
            this.filesExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.filesExplorer_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, ".ino");
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AutoCompleteBrackets = true;
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(35, 25);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox.CharHeight = 15;
            this.fastColoredTextBox.CharWidth = 7;
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DescriptionFile = "";
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fastColoredTextBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.LeftBracket = '(';
            this.fastColoredTextBox.LeftBracket2 = '{';
            this.fastColoredTextBox.LeftPadding = 10;
            this.fastColoredTextBox.LineNumberColor = System.Drawing.Color.RoyalBlue;
            this.fastColoredTextBox.Location = new System.Drawing.Point(0, 34);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fastColoredTextBox.RightBracket = ')';
            this.fastColoredTextBox.RightBracket2 = '}';
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.ServiceLinesColor = System.Drawing.Color.White;
            this.fastColoredTextBox.ShowFoldingLines = true;
            this.fastColoredTextBox.Size = new System.Drawing.Size(530, 397);
            this.fastColoredTextBox.TabIndex = 4;
            this.fastColoredTextBox.Visible = false;
            this.fastColoredTextBox.Zoom = 100;
            // 
            // screenHeaderFileName
            // 
            this.screenHeaderFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.screenHeaderFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeaderFileName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenHeaderFileName.Location = new System.Drawing.Point(0, 0);
            this.screenHeaderFileName.Name = "screenHeaderFileName";
            this.screenHeaderFileName.Padding = new System.Windows.Forms.Padding(10);
            this.screenHeaderFileName.ScreenContainer = null;
            this.screenHeaderFileName.Size = new System.Drawing.Size(530, 34);
            this.screenHeaderFileName.TabIndex = 5;
            this.screenHeaderFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Padding = new System.Windows.Forms.Padding(10);
            this.screenHeader1.ScreenContainer = null;
            this.screenHeader1.Size = new System.Drawing.Size(800, 41);
            this.screenHeader1.TabIndex = 1;
            this.screenHeader1.Text = "Scaduino - Code Editor";
            this.screenHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codeStyle
            // 
            this.codeStyle.CodeEditor = this.fastColoredTextBox;
            syntaxRegexStyle1.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxRegexStyle1.Font = System.Drawing.FontStyle.Italic;
            syntaxRegexStyle1.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            syntaxRegexStyle1.Name = "CommentBlockEnd";
            syntaxRegexStyle1.Snippets = null;
            syntaxRegexStyle1.UseBackgroundColor = false;
            syntaxRegexStyle2.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxRegexStyle2.Font = System.Drawing.FontStyle.Italic;
            syntaxRegexStyle2.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            syntaxRegexStyle2.Name = "CommentBlockStart";
            syntaxRegexStyle2.Snippets = null;
            syntaxRegexStyle2.UseBackgroundColor = false;
            syntaxRegexStyle3.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxRegexStyle3.Font = System.Drawing.FontStyle.Italic;
            syntaxRegexStyle3.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            syntaxRegexStyle3.Name = "Comments";
            syntaxRegexStyle3.Snippets = null;
            syntaxRegexStyle3.UseBackgroundColor = false;
            syntaxRegexStyle4.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxRegexStyle4.Font = System.Drawing.FontStyle.Regular;
            syntaxRegexStyle4.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            syntaxRegexStyle4.Name = "Strings";
            syntaxRegexStyle4.Snippets = null;
            syntaxRegexStyle4.UseBackgroundColor = false;
            syntaxRegexStyle5.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxRegexStyle5.Font = System.Drawing.FontStyle.Regular;
            syntaxRegexStyle5.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            syntaxRegexStyle5.Name = "Library";
            syntaxRegexStyle5.Snippets = null;
            syntaxRegexStyle5.UseBackgroundColor = false;
            this.codeStyle.SyntaxRegexStyles = new Scaduino.Editors.SyntaxRegexStyle[] {
        syntaxRegexStyle1,
        syntaxRegexStyle2,
        syntaxRegexStyle3,
        syntaxRegexStyle4,
        syntaxRegexStyle5};
            syntaxStyle1.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxStyle1.Font = System.Drawing.FontStyle.Regular;
            syntaxStyle1.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            syntaxStyle1.Name = null;
            syntaxStyle1.Snippets = new string[] {
        "digitalRead",
        "digitalWrite",
        "pinMode",
        "analogRead",
        "analogReference",
        "analogWrite",
        "analogReadResolution",
        "analogWriteResolution",
        "noTone",
        "pulseIn",
        "pulseInLong",
        "shiftIn",
        "shiftOut",
        "tone",
        "delay",
        "delayMicroseconds",
        "micros",
        "millis",
        "abs",
        "constrain",
        "map",
        "max",
        "min",
        "pow",
        "sq",
        "sqrt",
        "cos",
        "sin",
        "tan",
        "isAlpha",
        "isAlphaNumeric",
        "isAscii",
        "isControl",
        "isDigit",
        "isGraph",
        "isHexadecimalDigit",
        "isLowerCase",
        "isPrintable",
        "isPunct",
        "isSpace",
        "isUpperCase",
        "isWhitespace",
        "random",
        "randomSeed",
        "bit",
        "bitClear",
        "bitRead",
        "bitSet",
        "bitWrite",
        "highByte",
        "lowByte",
        "External Interrupts",
        "attachInterrupt",
        "detachInterrupt",
        "Interrupts",
        "interrupts",
        "noInterrupts"};
            syntaxStyle1.UseBackgroundColor = false;
            syntaxStyle2.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxStyle2.Font = System.Drawing.FontStyle.Regular;
            syntaxStyle2.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            syntaxStyle2.Name = null;
            syntaxStyle2.Snippets = new string[] {
        "HIGH",
        "LOW",
        "INPUT",
        "OUTPUT",
        "INPUT_PULLUP",
        "LED_BUILTIN",
        "true",
        "false",
        "unsigned int",
        "unsigned long",
        "byte",
        "char",
        "float",
        "int",
        "long",
        "word",
        "array",
        "bool",
        "boolean",
        "byte",
        "char",
        "double",
        "float",
        "int",
        "long",
        "short",
        "size_t",
        "string",
        "String",
        "unsigned char",
        "unsigned int",
        "unsigned long",
        "void",
        "word",
        "const",
        "scope",
        "static",
        "volatile",
        "Utilities",
        "PROGMEM",
        "sizeof",
        "enum"};
            syntaxStyle2.UseBackgroundColor = false;
            syntaxStyle3.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxStyle3.Font = System.Drawing.FontStyle.Regular;
            syntaxStyle3.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            syntaxStyle3.Name = null;
            syntaxStyle3.Snippets = new string[] {
        "loop",
        "setup",
        "break",
        "continue",
        "do",
        "while",
        "else",
        "for",
        "goto",
        "if",
        "return",
        "switch",
        "case",
        "while"};
            syntaxStyle3.UseBackgroundColor = false;
            syntaxStyle4.BackgroundBrush = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            syntaxStyle4.Font = System.Drawing.FontStyle.Regular;
            syntaxStyle4.ForeBrush = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            syntaxStyle4.Name = null;
            syntaxStyle4.Snippets = new string[] {
        "defined",
        "#ifndef",
        "#endif",
        "#define",
        "#if",
        "#elif",
        "#include",
        "#ifdef",
        "#else",
        "#ifdef"};
            syntaxStyle4.UseBackgroundColor = false;
            this.codeStyle.SyntaxStyles = new Scaduino.Editors.SyntaxStyle[] {
        syntaxStyle1,
        syntaxStyle2,
        syntaxStyle3,
        syntaxStyle4};
            // 
            // CodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.screenHeader1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeEditor";
            this.Load += new System.EventHandler(this.CodeEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CommonControls.FilesExplorer filesExplorer;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
        private ModernUI.ScreenHeader screenHeaderFileName;
        private ModernUI.ScreenHeader screenHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private CodeStyle codeStyle;
    }
}