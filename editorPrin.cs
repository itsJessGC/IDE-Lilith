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
        public override System.Drawing.Color ForeColor { get; set; }

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

        public Regex keyWordsBlue = new Regex("if|then |else |fi |true |while |do |done |set |export |bool |break |case |class |const |for |foreach |goto |in |void ");
        public Regex keyWordsGreenComment = new Regex(@"\#.*?\n");
        //millz12.wordpress.com/2009/11/26/c-richtextbox-syntax-highlighting/
        ///www.codeproject.com/Questions/643494/Syntax-highlighting-a-RichTextBox-in-Csharp
        //www.c-sharpcorner.com/uploadfile/kirtan007/syntax-highlighting-in-richtextbox-using-C-Sharp/
        //www.c-sharpcorner.com/article/syntax-highlighting-in-richtextbox-control-part-2/
        private void codigoTexto_TextChanged(object sender, EventArgs e)
        {
            // Select all and set to black so that it's 'clean'
            codigoTexto.SelectAll();
            codigoTexto.SelectionColor = Color.Black;
            codigoTexto.Select(codigoTexto.Text.Length, 1);


            this.CheckKeyword("#include", Color.Green, 0);


            this.CheckKeyword("class", Color.Blue, 0);
            this.CheckKeyword("const", Color.Blue, 0);
            this.CheckKeyword("enum", Color.Blue, 0);
            this.CheckKeyword("implements", Color.Blue, 0);
            this.CheckKeyword("new", Color.Blue, 0);
            this.CheckKeyword("package", Color.Blue, 0);
            this.CheckKeyword("private", Color.Blue, 0);
            this.CheckKeyword("protected", Color.Blue, 0);
            this.CheckKeyword("public", Color.Blue, 0);
            this.CheckKeyword("return", Color.Blue, 0);
            this.CheckKeyword("void", Color.Blue, 0);


            this.CheckKeyword("abstract", Color.Blue, 0);
            this.CheckKeyword("assert", Color.Blue, 0);
            this.CheckKeyword("break", Color.Blue, 0);
            this.CheckKeyword("case", Color.Blue, 0);
            this.CheckKeyword("catch", Color.Blue, 0);
            this.CheckKeyword("continue", Color.Blue, 0);
            this.CheckKeyword("default", Color.Blue, 0);
            this.CheckKeyword("do", Color.Blue, 0);
            this.CheckKeyword("else", Color.Blue, 0);
            this.CheckKeyword("extendes", Color.Blue, 0);
            this.CheckKeyword("final", Color.Blue, 0);
            this.CheckKeyword("finaly", Color.Blue, 0);
            this.CheckKeyword("for", Color.Blue, 0);
            this.CheckKeyword("go to", Color.Blue, 0);
            this.CheckKeyword("if", Color.Blue, 0);
            this.CheckKeyword("switch", Color.Blue, 0);
            this.CheckKeyword("while", Color.Blue, 0);


            this.CheckKeyword("boolean", Color.Red, 0);
            this.CheckKeyword("byte", Color.Red, 0);
            this.CheckKeyword("char", Color.Red, 0);
            this.CheckKeyword("double", Color.Red, 0);
            this.CheckKeyword("float", Color.Red, 0);
            this.CheckKeyword("int", Color.Red, 0);
            this.CheckKeyword("long", Color.Red, 0);
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