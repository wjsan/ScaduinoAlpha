using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace Scaduino.Editors
{
    public partial class CodeStyle : Component
    {
        private FastColoredTextBox codeEditor;

        public SyntaxStyle[] SyntaxStyles { get; set; }

        public SyntaxRegexStyle[] SyntaxRegexStyles { get; set; }

        public FastColoredTextBox CodeEditor
        {
            get => codeEditor;
            set
            {
                codeEditor = value;
                codeEditor.TextChanged += CodeEditor_TextChanged;
            }
        }

        private void CodeEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                SetStyles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        public void SetStyles()
        {
            foreach (var style in SyntaxStyles)
            {
                codeEditor.Range.ClearStyle(style.TextStyle);
            }
            foreach (var style in SyntaxRegexStyles)
            {
                codeEditor.Range.ClearStyle(style.TextStyle);
            }
            foreach (var style in SyntaxRegexStyles)
            {
                foreach (var pattern in style.RegexPatterns)
                {
                    codeEditor.Range.SetStyle(style.TextStyle, pattern.Regex, pattern.RegexOption1 | pattern.RegexOption2);
                }
            }
            foreach (var style in SyntaxStyles)
            {
                codeEditor.Range.SetStyle(style.TextStyle, style.GetRegexSnippets());
            }
        }

        public CodeStyle()
        {
            InitializeComponent();
        }

        public CodeStyle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    public class SyntaxStyle
    {
        private Brush foreBrush;
        private Brush backgroundBrush;
        private TextStyle textStyle;

        public string Name { get; set; }

        [Browsable(false)]
        public TextStyle TextStyle
        {
            get
            {
                if (!UseBackgroundColor) backgroundBrush = null;
                if(textStyle == null) textStyle = new TextStyle(foreBrush, backgroundBrush, Font);
                return textStyle;
            }
        }

        public Color ForeBrush
        {
            get
            {
                if (foreBrush != null)
                    return new Pen(foreBrush).Color;
                else
                    return Color.Black;
            }

            set
            {
                if (value != null)
                    foreBrush = new SolidBrush(Color.FromArgb(value.ToArgb()));
            }
        }

        public bool UseBackgroundColor { get; set; }

        public Color BackgroundBrush
        {
            get
            {
                if (backgroundBrush != null)
                    return new Pen(backgroundBrush).Color;
                else
                    return Color.Transparent;
            }

            set
            {
                if (value != null)
                    backgroundBrush = new SolidBrush(Color.FromArgb(value.ToArgb()));
            }
        }

        public System.Drawing.FontStyle Font { get; set; }

        public string[] Snippets { get; set; }

        public string GetRegexSnippets()
        {
            var regex = @"\b";
            foreach (var snippet in Snippets)
            {
                regex += snippet;
                if (snippet != Snippets.Last())
                    regex += @"\b|";
            }
            regex += @"\b";
            return regex;
        }

    }
    public class SyntaxRegexStyle : SyntaxStyle
    {

        [Browsable(false)]
        new public string Snippets { get; set; }

        public RegexPattern[] RegexPatterns { get; set; }
    }

    public class RegexPattern
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption1 { get; set; }
        public RegexOptions RegexOption2 { get; set; }
    }
}
