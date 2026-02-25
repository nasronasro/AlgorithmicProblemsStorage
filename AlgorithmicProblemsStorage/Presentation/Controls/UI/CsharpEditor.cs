using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScintillaNET;

namespace AlgorithmicProblemsStorage.Presentation.Controls
{
    public partial class CsharpEditor : UserControl
    {
        private readonly Scintilla editor = new Scintilla();
        public CsharpEditor()
        {
            InitializeComponent();
        }

        private void CsharpEditor_Load(object sender, EventArgs e)
        {
            editor.Dock = DockStyle.Fill;
            Controls.Add(editor);

            ConfigureVisualStudioDark(editor);
        }
        public string GetText()
        {
            return editor.Text;
        }
       
        private static void ConfigureVisualStudioDark(Scintilla s)
        {
            s.LexerName = "cpp";

            s.StyleResetDefault();
            s.Styles[Style.Default].Font = "Consolas";
            s.Styles[Style.Default].Size = 10;
            s.Styles[Style.Default].BackColor = Color.FromArgb(30, 30, 30);
            s.Styles[Style.Default].ForeColor = Color.FromArgb(220, 220, 220);
            s.StyleClearAll();

            // Line numbers
            s.Margins[0].Type = MarginType.Number;
            s.Margins[0].Width = 45;
            s.Styles[Style.LineNumber].BackColor = Color.FromArgb(37, 37, 38);
            s.Styles[Style.LineNumber].ForeColor = Color.FromArgb(43, 145, 175);

            // Selection
            s.SetSelectionBackColor(true, Color.FromArgb(51, 153, 255));

            // Caret
            s.CaretForeColor = Color.White;
            s.CaretLineVisible = true;
            s.CaretLineBackColor = Color.FromArgb(45, 45, 48);

            // C# Keywords
            s.SetKeywords(0,
                "abstract as base bool break byte case catch char checked class const continue " +
                "decimal default delegate do double else enum event explicit extern false finally fixed " +
                "float for foreach goto if implicit in int interface internal is lock long namespace new " +
                "null object operator out override params private protected public readonly ref return sbyte " +
                "sealed short sizeof stackalloc static string struct switch this throw true try typeof uint " +
                "ulong unchecked unsafe ushort using virtual void volatile while");

            // Styles (Visual Studio Dark approximations)
            s.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(86, 156, 214);      // keywords (blue)
            s.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(214, 157, 133);   // strings (orange)
            s.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(214, 157, 133);
            s.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(87, 166, 74);    // comments (green)
            s.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(87, 166, 74);
            s.Styles[Style.Cpp.CommentDoc].ForeColor = Color.FromArgb(87, 166, 74);
            s.Styles[Style.Cpp.Number].ForeColor = Color.FromArgb(181, 206, 168);   // numbers (light green)
            s.Styles[Style.Cpp.Operator].ForeColor = Color.FromArgb(220, 220, 220);

            // Brace matching
            s.Styles[Style.BraceLight].BackColor = Color.FromArgb(62, 62, 66);
            s.Styles[Style.BraceLight].Bold = true;

            // Indentation guides
            s.IndentationGuides = IndentView.LookBoth;
        }
    }
}
