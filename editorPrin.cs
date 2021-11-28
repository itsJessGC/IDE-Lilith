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
using System.Diagnostics;

namespace Lilith
{
    public partial class editorPrin : Form
    {
        public override System.Drawing.Color ForeColor { get; set; }

        //Inicializamos nuestro componente, que es nuestra pantalla inicial
        public editorPrin()
        {
            InitializeComponent();
        }

        int tokenllevado = 0;

        //con este se selecciona el cuadro de texto de la pestaña elegida
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

        //Funciones vacías por error
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

        //Creamos un archivo nuevo
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("New Document");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            editorCodigo.TabPages.Add(tp);
        }

        //Abrimos un archivo
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //Se abre el diálogo de archivos

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    editorCodigo.SelectedTab.Text = strfilename;
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

        //Funciones vacías
        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Guardar archivo
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

        //Funcion para cortar texto
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        //Función para copear texto
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        //Función para pegar texto
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        //Función para deshacer modificación
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        //Una especie de ctrl + Y
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        //Cierra el archivo
        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage current_tab = editorCodigo.SelectedTab;

            editorCodigo.TabPages.Remove(current_tab); //elimina la pestaña
        }

        //función vacía
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        //Abrir proyecto solo abre una carpeta y lo muestra en forma de árbol del lado izq
        //Aun no cuenta con la funcionalidad de abrir el archivo seleccionado de ese árbol
        private void openProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directorio = saveFileDialog1.Title;
                ListDirectory(arbolProyecto, directorio);//Aqui se llama a la función para crear el árbol
            }

        }

        //Creación del arbol
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear(); //Limpiamos los nodos existentes
            var rootDirectoryInfo = new DirectoryInfo(path);

            this.arbolProyecto.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo)); //Llammos a la funcion para crear los nuevos nodos
        }

        //Creacion de nodos para el árbol de directorios
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }

        //Funciones vacías
        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void editorCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Compilamos el código
        private void buildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);
                    editorCodigo.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }*/
            string[] lineas = System.IO.File.ReadAllLines(editorCodigo.SelectedTab.Text);

            //string cadenas ="+-{;}";
            //Console.WriteLine("Coincidencias primer archivo: \t");

            //creamos nuestra variable del archivo analizadorLexico
            analizadorLexico analizador = new analizadorLexico();
            int lineaP = 1;
            foreach (string linea in lineas)
            {
                //comanzamos a mandar cada linea para que pueda ser analizado
                analizador.Analizado_Lexico(linea, lineaP);
                lineaP++;
            }
            //obtenemos los tokens
            analizador.obtenerTokens2();
            tokenText.Text = analizador.tokensResultados();
            analizador.obtenerTokensError();

            //se muestran los tokens de error en nuestra terminal
            textoTerminal.Text = "Tokens \t Tipo \t Linea" + Environment.NewLine + analizador.tokensResultadosError();
            //tokenllevado = tablaTokens.Rows.Add();


            /*tablaTokens.Rows[tokenllevado].Cells["campoToken"].Value = analizador.simboloResultados();
            tablaTokens.Rows[tokenllevado].Cells["campoTipo"].Value = analizador.tokensResultados();
            tablaTokens.Rows[tokenllevado].Cells["campoLinea"].Value = analizador.lineaResultados();*/

            //obtenemos los tokens que no tienen error
            if (analizador.tokensResultadosError() == null)
            {
                Sintactico analizadorSintactico = new Sintactico(analizador.obtenerTokens());
                Nodo arbol = new Nodo();
                arbol = analizadorSintactico.arbolSintactico();

                //Arbol es el que utilizamos para enviarlo al TreeView
                treeView1.Nodes.Clear();
                tablaSimbolos.Rows.Clear();

                TreeNode aux = treeView1.Nodes.Add(arbol.valor);
                arbolSint(null, aux, arbol);
                textoTerminal.Text = analizadorSintactico.erroresSintacticos();
                CallRecursive(treeView1);
            }
        }

        private void arbolSint(object p, TreeNode aux, Nodo arbol)
        {
            throw new NotImplementedException();
        }

        public Regex keyWordsBlue = new Regex("if|then |else |fi |true |while |do |done |set |export |bool |break |case |class |const |for |foreach |goto |in |void ");
        public Regex keyWordsGreenComment = new Regex(@"\#.*?\n");
        //millz12.wordpress.com/2009/11/26/c-richtextbox-syntax-highlighting/
        ///www.codeproject.com/Questions/643494/Syntax-highlighting-a-RichTextBox-in-Csharp
        //www.c-sharpcorner.com/uploadfile/kirtan007/syntax-highlighting-in-richtextbox-using-C-Sharp/
        //www.c-sharpcorner.com/article/syntax-highlighting-in-richtextbox-control-part-2/

        //al hacer un cambio en el cuadro de texto, se actualizan los colores respecto a la palabra
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

        //si es palabra normal entonces es de color negro
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


        //funciones vacías
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void terminal_TextChanged(object sender, EventArgs e)
        {

        }

        int ren;//cant de renglones de la tabla sintáctico

        //Impresion del árbol sintáctico
        void arbolSint(TreeNode padre, TreeNode treeNode, Nodo nodo)
        {
            for (int i = 0; i < 3; i++)
            {
                if (nodo.hijos[i] != null)
                {
                    TreeNode aux = treeNode.Nodes.Add(nodo.hijos[i].valor);
                    arbolSint(treeNode, aux, nodo.hijos[i]);
                }
                else
                {
                    break;
                }
            }

            if (nodo.hermano != null)
            {
                TreeNode aux = padre.Nodes.Add(nodo.hermano.valor);
                arbolSint(padre, aux, nodo.hermano);
            }
            Nodo actual = nodo;
            //tabSint(nodo, actual);
        }

        //Tabla Sint

        private Operaciones raiz;
        private Operaciones ultimo;
        double res = 0;

        bool operacion = false;
        bool ultimoNodoOp = false;
        int cantOp = 0;
        private void PrintRecursive(TreeNode treeNode)
        {
            Operaciones aux = raiz;

            if (treeNode.Text == "int" || treeNode.Text == "float" || treeNode.Text == "bool") //Checa si el nodo actual es un int, float o bool, si lo es entonces agrega la variable
            {
                ren = tablaSimbolos.Rows.Add();
                tablaSimbolos.Rows[ren].Cells[0].Value = treeNode.Text;
                tablaSimbolos.Rows[ren].Cells[1].Value = treeNode.Nodes[0].Text;
            }

            if (treeNode.Text == "asignacion" || operacion == true) // si es una asignacion entra
            {
                foreach (TreeNode hoja in treeNode.Nodes) //verá cada nodo de la rama (hojas del nodo)
                {
                    if ((hoja.Text == "/") || (hoja.Text == "*") || (hoja.Text == "+") || (hoja.Text == "-") || ultimoNodoOp == true) //si es algun operador entra - si es el ultimo nodo, y ya había entrado aqui, entra
                    {
                        cantOp++;
                        operacion = true;
                        Operaciones nuevo1 = new Operaciones();
                        if (raiz == null)
                        {
                            nuevo1.dato = treeNode.Nodes[0].Text;
                            raiz = nuevo1; // x <---------

                            Operaciones nuevo2 = new Operaciones();
                            nuevo2.dato = treeNode.Nodes[1].Text;
                            raiz.sig = nuevo2;
                            nuevo2.ant = raiz;
                            ultimo = nuevo2;
                        }
                        else
                        {
                            nuevo1.dato = treeNode.Nodes[0].Text;
                            nuevo1.ant = ultimo;
                            ultimo.sig = nuevo1;
                            ultimo = nuevo1;

                            Operaciones nuevo2 = new Operaciones();
                            nuevo2.dato = treeNode.Nodes[1].Text;
                            ultimo.sig = nuevo2;
                            nuevo2.ant = ultimo;
                            ultimo = nuevo2;
                        }



                        if (ultimoNodoOp)
                        {
                            Operaciones nuevo3 = new Operaciones();
                            nuevo3.dato = treeNode.Nodes[1].Nodes[0].Text;
                            nuevo3.ant = ultimo;
                            ultimo.sig = nuevo3;
                            ultimo = nuevo3;

                            Operaciones nuevo4 = new Operaciones();
                            nuevo4.dato = treeNode.Nodes[1].Nodes[1].Text;
                            ultimo.sig = nuevo4;
                            nuevo4.ant = ultimo;
                            ultimo = nuevo4;

                            ultimoNodoOp = false;
                            operacion = false;
                            cantOp = 0;
                            resultadoParcial(); //una vez que tengamos todos los elementos en la lista hacemos las operaciones
                        }

                    }
                    else
                    {
                        if (operacion)
                        {
                            ultimoNodoOp = true;
                        }
                        //operacion = false;
                    }

                }

                if (!operacion) //Si no se hará una operación 
                {
                    for (int j = 0; j <= ren; j++)//recorremos la tabla
                    {
                        if (tablaSimbolos.Rows[j].Cells[1].Value.ToString() == treeNode.Nodes[0].Text) //compara si el nodo actual ya está en la tabla
                        {
                            //Cambiamos la variable a la tabla
                            tablaSimbolos.Rows[j].Cells[2].Value = treeNode.Nodes[1].Text;
                        }
                    }
                }
            }

            // Visit each node recursively.  
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        // Call the procedure using the TreeView.  
        private void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.  
            foreach (TreeNode n in treeView.Nodes)
            {
                PrintRecursive(n);
            }
        }

        public void resultadoParcial()
        {
            string div = "/";
            string mul = "*";
            string sum = "+";
            string resta = "-";

            double var1;
            double var2;


            Operaciones reco = raiz;
            Operaciones prioridad = raiz;

            while (prioridad != null)
            {
                if (prioridad.dato == div)
                {
                    Console.WriteLine(prioridad.sig.dato);
                    Console.WriteLine(prioridad.sig.sig.dato);
                    if (prioridad.sig.sig.sig == null && prioridad.ant.ant == null) //si es la unica operación
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 / var2;

                        prioridad.dato = res.ToString();
                        prioridad.sig.ant = null;
                        prioridad.sig = null;

                        break;
                    }
                    else if (prioridad.sig.sig.sig == null) // si es la ultima operación
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 / var2;

                        prioridad.dato = res.ToString();
                        ultimo = prioridad;
                        ultimo.sig.ant = null;
                        ultimo.sig = null;

                    }
                    else if (prioridad.ant.ant == null) // si es la primera operacion
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 / var2;

                        prioridad.dato = res.ToString();

                        prioridad.sig = prioridad.sig.sig.sig;
                        prioridad.sig.sig.sig.ant = prioridad;
                    }
                    else
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 / var2;

                        prioridad.dato = res.ToString();

                        prioridad.sig = prioridad.sig.sig.sig;
                        prioridad.sig.sig.sig.ant = prioridad;
                    }
                    prioridad = raiz;
                }
                else if (prioridad.dato == mul)
                {
                    if (prioridad.sig.sig.sig == null && prioridad.ant.ant == null) //si es la unica operación
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 * var2;

                        prioridad.dato = res.ToString();
                        prioridad.sig.ant = null;
                        prioridad.sig = null;

                        break;
                    }
                    else if (prioridad.sig.sig.sig == null) // si es la ultima operación
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 * var2;

                        prioridad.dato = res.ToString();

                        ultimo = prioridad;
                        ultimo.sig.ant = null;
                        ultimo.sig = null;
                    }
                    else if (prioridad.ant.ant == null) // si es la primera operacion
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 * var2;

                        prioridad.dato = res.ToString();

                        prioridad.sig = prioridad.sig.sig.sig;
                        prioridad.sig.sig.sig.ant = reco;
                    }
                    else
                    {
                        var1 = double.Parse(prioridad.sig.dato);
                        var2 = double.Parse(prioridad.sig.sig.dato);

                        res = var1 * var2;

                        prioridad.dato = res.ToString();

                        prioridad.sig = prioridad.sig.sig.sig;
                        prioridad.sig.sig.sig.ant = prioridad;
                    }
                    prioridad = raiz;
                }
                prioridad = prioridad.sig;
            }

            while (reco != null)
            {
                if (reco.dato == sum)
                {
                    if (reco.sig.sig.sig == null && reco.ant.ant == null) //si es la unica operación
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 + var2;
                        reco.dato = res.ToString();
                        reco.sig.ant = null;
                        reco.sig = null;

                        break;
                    }
                    else if (reco.sig.sig.sig == null) // si es la ultima operación
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 + var2;

                        reco.dato = res.ToString();

                        ultimo = reco;
                        ultimo.sig.ant = null;
                        ultimo.sig = null;
                    }
                    else if (reco.ant.ant == null) // si es la primera operacion
                    {
                        Console.WriteLine(reco.sig.dato);
                        Console.WriteLine(reco.sig.sig.dato);
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 + var2;

                        reco.dato = res.ToString();

                        reco.sig = reco.sig.sig.sig;
                        reco.sig.sig.sig.ant = reco;
                    }
                    else
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 + var2;

                        reco.dato = res.ToString();

                        reco.sig = reco.sig.sig.sig;
                        reco.sig.sig.sig.ant = reco;
                    }
                    reco = raiz;
                }
                else if (reco.dato == resta)
                {
                    if (reco.sig.sig.sig == null && reco.ant.ant == null) //si es la unica operación
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 - var2;

                        reco.dato = res.ToString();
                        reco.sig.ant = null;
                        reco.sig = null;

                        break;
                    }
                    else if (reco.sig.sig.sig == null) // si es la ultima operación
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 - var2;

                        reco.dato = res.ToString();

                        ultimo = reco;
                        ultimo.sig.ant = null;
                        ultimo.sig = null;
                    }
                    else if (reco.ant.ant == null) // si es la primera operacion
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 - var2;

                        reco.dato = res.ToString();

                        reco.sig = reco.sig.sig.sig;
                        reco.sig.sig.sig.ant = reco;
                    }
                    else
                    {
                        var1 = double.Parse(reco.sig.dato);
                        var2 = double.Parse(reco.sig.sig.dato);

                        res = var1 - var2;

                        reco.dato = res.ToString();

                        reco.sig = reco.sig.sig.sig;
                        reco.sig.sig.sig.ant = reco;
                    }
                    reco = raiz;
                    //Console.WriteLine(res);
                }
                reco = reco.sig;
            }
            Console.WriteLine(res); //4.5 <---------------


            for (int i = 0; i < ren; i++)
            {
                if (tablaSimbolos.Rows[i].Cells[1].Value.ToString() == raiz.dato)
                {
                    //acumulador = double.Parse(tablaSimbolos.Rows[i].Cells[2].Value.ToString()); //Prueba para obtener valor ya existente
                    tablaSimbolos.Rows[i].Cells[2].Value = res; // cambiamos el valor a la tabla con el nuevo valor

                }
            }
        }
    }
    class Operaciones
    {
        public string dato;
        public Operaciones sig, ant;
    }
}