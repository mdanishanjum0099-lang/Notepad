using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog danish = new OpenFileDialog();
            danish.Title = "Open";
            danish.Filter = "Text Document(*.txt)|*.txt|All Files (*.*)|*.*"; 
            if(danish.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(danish.FileName,RichTextBoxStreamType.PlainText);
            this.Text = danish.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog danish = new SaveFileDialog();
            danish.Title = "Save";
            danish.Filter = "Text Document(*.txt)|*.txt|All Files (*.*)|*.*";
            if (danish.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(danish.FileName, RichTextBoxStreamType.PlainText);
            this.Text = danish.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap)
            {
                richTextBox1.WordWrap= false;
                wordWrapToolStripMenuItem.Checked= false;
            }
            else
            {
                richTextBox1.WordWrap=true;
                wordWrapToolStripMenuItem.Checked = true; 
            }
        }
    }
}
// This is the project by me 
// mera namee danish hai 
//me teesre semester me parhta hooo