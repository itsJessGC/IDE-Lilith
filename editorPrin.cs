using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Lilith
{
    public partial class editorPrin : Form
    {
        public editorPrin()
        {
            InitializeComponent();
        }

        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = editorCodigo.SelectedTab;

            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }
            return rtb;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("New Document");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            editorCodigo.TabPages.Add(tp);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;
                }
            }
            /*Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;
                    tabControl1.SelectedTab.Text = Path.GetFileName(openFileDialog1.FileName);
                }
            }*/
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        /*private void rtb_TextChanged(object sender, EventArgs e)
        {
            this.CambiaColores("while", Color.Purple, 0);
            this.CambiaColores("if", Color.Green, 0);
        }*/


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                    editorCodigo.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage current_tab = editorCodigo.SelectedTab;

            editorCodigo.TabPages.Remove(current_tab);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void openProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directorio = saveFileDialog1.Title;
                ListDirectory(arbolProyecto, directorio);
            }

        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);

            this.arbolProyecto.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void editorCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                    editorCodigo.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
            string[] lineas = System.IO.File.ReadAllLines(saveFileDialog1.FileName);
            //string cadenas ="+-{;}";
            //Console.WriteLine("Coincidencias primer archivo: \t");
            analizadorLexico analizador = new analizadorLexico();
            int lineaP = 1;
            foreach (string linea in lineas)
            {

                analizador.Analizado_Lexico(linea, lineaP);
                lineaP++;
            }
            analizador.obtenerTokens2();
            tokenText.Text = analizador.tokensResultados();
        }

        private void codigoTexto_TextChanged(object sender, EventArgs e)
        {
            this.CheckKeyword("while", Color.Purple, 0);
            this.CheckKeyword("if", Color.Green, 0);
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.codigoTexto.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.codigoTexto.SelectionStart;

                while ((index = this.codigoTexto.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.codigoTexto.Select((index + startIndex), word.Length);
                    this.codigoTexto.SelectionColor = color;
                    this.codigoTexto.Select(selectStart, 0);
                    this.codigoTexto.SelectionColor = Color.Black;
                }
            }
        }
    }
}