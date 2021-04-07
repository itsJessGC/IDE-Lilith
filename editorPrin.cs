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

            if(tp != null)
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
            String linea;

            StreamReader fp = new StreamReader(editorCodigo.SelectedTab.Text); //Leemos el archovo abierto
                                                                                                                                                                                         //un string para manipularlo mucho mas facil 
            linea = makeString(fp);
            
            encontrarTokens(linea, linea.Length);
            
        }

        public struct token
        {
            public token_types type;
            public string lexema;
        }

        public const int MAXLENID = 32;
        public const int MAXLENBUF = 1024;
        public const int MAXRESWORDS = 4;

        public enum token_types
        {
            TKN_BEGIN, TKN_END, TKN_READ, TKN_WRITE, TKN_ID,
            TKN_NUM, TKN_LPAREN, TKN_RPAREN, TKN_SEMICOLON, TKN_COMMA,
            TKN_ASSIGN, TKN_ADD, TKN_MINUS, TKN_EOF, TKN_ERROR
        }

        enum States
        {
            IN_START, IN_ID, IN_NUM, IN_LPAREN, IN_RPAREN, IN_SEMICOLON,
            IN_COMMA, IN_ASSIGN, IN_ADD, IN_MINUS, IN_EOF, IN_ERROR, IN_DONE
        }

        //esta funcion lo que va ser es que elimine los comentarios y dejar todo en un string
        //falta que elimine los comentarios 
        static String makeString(StreamReader fp)
        {
            String line = null;
            String recipiente = null;
            try
            {
                //Read the first line of text
                line = fp.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //junta el texto en un string 
                    recipiente += line;
                    //Read the next line
                    line = fp.ReadLine();
                }
                //close the file


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Terminó");
            }

            return recipiente;
        }

        //esta funcion checa las palabras que le son enviadas para identificar 
        //si estas son palabras reservadas 
        //aqui la meta es que cheque los identificadores , los numeros , digitos y caracteres 

        private void queTokenes(String palabra)
        {
            if (palabra.Equals("program") ||
                palabra.Equals("if") ||
                palabra.Equals("else") ||
                palabra.Equals("fi") ||
                palabra.Equals("do") ||
                palabra.Equals("until") ||
                palabra.Equals("while") ||
                palabra.Equals("read") ||
                palabra.Equals("case") ||
                palabra.Equals("write") ||
                palabra.Equals("float") ||
                palabra.Equals("int") ||
                palabra.Equals("bool") ||
                palabra.Equals("not") ||
                palabra.Equals("and") ||
                palabra.Equals("or")
                )
            {
                Console.WriteLine(palabra + "   = Reservada");
                Tokens.Text = palabra + " = Reservada";
            }
        }

        //esta funcion checa y va haciendo palabras asta que encuentre un digito especial 
        //en caso de que asi sea checa la palabra y la manda a la funcion de arriba 
        //y ademas que identifica los signos especiales 
        public void encontrarTokens(String linea, int largo)
        {
            token tok;

            tok.lexema = null;
            int pos = 0;
            char caracter;
            int index = 0;
            while (index < largo)
            {
                caracter = linea[index];
                switch (caracter)
                {
                    case ' ':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        index++;
                        break;
                    case '(':

                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("(   = simbolo");
                        Tokens.Text = "(   = simbolo";
                        index++;
                        break;
                    case ')':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(")   = simbolo");
                        Tokens.Text = ")   = simbolo";
                        index++;
                        break;
                    case ';':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(";   = simbolo");
                        Tokens.Text = ";   = simbolo";
                        index++;
                        break;
                    case ',':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(",   = simbolo");
                        Tokens.Text = ",   = simbolo";
                        index++;
                        break;
                    case ':':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(":   = simbolo");
                        Tokens.Text = ":   = simbolo";
                        index++;
                        break;
                    case '+':
                        queTokenes(tok.lexema);
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("+=   = simbolo");
                            Tokens.Text = "+=   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("+   = simbolo");
                            Tokens.Text = "+   = simbolo";
                        }
                        tok.lexema = "";
                        index++;
                        break;
                    case '-':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("-=   = simbolo");
                            Tokens.Text = "-=   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("-   = simbolo");
                            Tokens.Text = "-   = simbolo";
                        }
                        index++;
                        break;
                    case '*':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("*   = simbolo");
                        Tokens.Text = "*   = simbolo";
                        index++;
                        break;
                    case '/':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("/   = simbolo");
                        Tokens.Text = "/   = simbolo";
                        index++;
                        break;
                    case '^':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("^   = simbolo");
                        Tokens.Text = "^   = simbolo";
                        index++;
                        break;
                    case '<':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("<=   = simbolo");
                            Tokens.Text = "<=   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("<   = simbolo");
                            Tokens.Text = "<   = simbolo";
                        }
                        index++;
                        break;
                    case '>':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine(">=   = simbolo");
                            Tokens.Text = ">=   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine(">   = simbolo");
                            Tokens.Text = ">   = simbolo";
                        }
                        index++;
                        break;
                    case '=':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("==   = simbolo");
                            Tokens.Text = "==   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("=   = simbolo");
                            Tokens.Text = "=   = simbolo";
                        }
                        index++;
                        break;
                    case '!':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("!=   = simbolo");
                            Tokens.Text = "!=   = simbolo";
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("!   = simbolo");
                            Tokens.Text = "!   = simbolo";
                        }
                        index++;
                        break;
                    case '{':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("{    = simbolo");
                        Tokens.Text = "{   = simbolo";
                        index++;
                        break;
                    case '}':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("}    = simbolo");
                        Tokens.Text = "}   = simbolo";
                        index++;
                        break;
                    default:
                        tok.lexema += caracter;
                        index++;
                        break;
                }
            }

        }
    }
}