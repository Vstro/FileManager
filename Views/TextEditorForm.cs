using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FileManager.Services.Services;

namespace FileManager
{
    public partial class TextEditorForm : Form
    {
        String Buffer { get; set; }

        String FileName { get; set; }

        public TextEditorForm(String fileName)
        {
            InitializeComponent();
            FileName = fileName;
            MainTextBox.Multiline = true;
            MainTextBox.Text = LoadFileContent(fileName);
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Копировать");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Вставить");
            CopyPasteContextMenuStrip.Items.AddRange(new[] { copyMenuItem, pasteMenuItem });
            MainTextBox.ContextMenuStrip = CopyPasteContextMenuStrip;
            copyMenuItem.Click += CopyMenuItem_Click;
            pasteMenuItem.Click += PasteMenuItem_Click;
        }

        void PasteMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Paste(Buffer);
        }

        void CopyMenuItem_Click(object sender, EventArgs e)
        {
            Buffer = MainTextBox.SelectedText;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileContent(FileName, MainTextBox.Text);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileContent(FileName, MainTextBox.Text);
        }
    }
}
