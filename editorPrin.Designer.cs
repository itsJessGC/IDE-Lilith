
namespace Lilith
{
    partial class editorPrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editorPrin));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.arbolProyecto = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProyectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProyectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorCodigo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.codigoTexto = new System.Windows.Forms.RichTextBox();
            this.textoTerminal = new System.Windows.Forms.TextBox();
            this.tabLexico = new System.Windows.Forms.TabControl();
            this.Tokens = new System.Windows.Forms.TabPage();
            this.tablaTokens = new System.Windows.Forms.DataGridView();
            this.campoToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenText = new System.Windows.Forms.RichTextBox();
            this.arbolLex = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tablaSimbolos = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodInter = new System.Windows.Forms.TabPage();
            this.txtCodInter = new System.Windows.Forms.RichTextBox();
            this.tabsTerminal = new System.Windows.Forms.TabControl();
            this.Terminal = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.editorCodigo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLexico.SuspendLayout();
            this.Tokens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).BeginInit();
            this.arbolLex.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).BeginInit();
            this.CodInter.SuspendLayout();
            this.tabsTerminal.SuspendLayout();
            this.Terminal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 30);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(158, 399);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.arbolProyecto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(150, 373);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Proyects";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // arbolProyecto
            // 
            this.arbolProyecto.Location = new System.Drawing.Point(0, 0);
            this.arbolProyecto.Name = "arbolProyecto";
            this.arbolProyecto.Size = new System.Drawing.Size(154, 377);
            this.arbolProyecto.TabIndex = 0;
            this.arbolProyecto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(150, 373);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Files";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.terminalToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(986, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.openProyectToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.closeProyectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openProyectToolStripMenuItem
            // 
            this.openProyectToolStripMenuItem.Name = "openProyectToolStripMenuItem";
            this.openProyectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openProyectToolStripMenuItem.Text = "Open Proyect";
            this.openProyectToolStripMenuItem.Click += new System.EventHandler(this.openProyectToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // closeProyectToolStripMenuItem
            // 
            this.closeProyectToolStripMenuItem.Name = "closeProyectToolStripMenuItem";
            this.closeProyectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeProyectToolStripMenuItem.Text = "Close Proyect";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.findInFilesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // findInFilesToolStripMenuItem
            // 
            this.findInFilesToolStripMenuItem.Name = "findInFilesToolStripMenuItem";
            this.findInFilesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.findInFilesToolStripMenuItem.Text = "Find in Files";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem});
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.terminalToolStripMenuItem.Text = "Terminal";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.nToolStripMenuItem.Text = "Open Terminal";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem1});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildToolStripMenuItem1
            // 
            this.buildToolStripMenuItem1.Name = "buildToolStripMenuItem1";
            this.buildToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.buildToolStripMenuItem1.Text = "Build";
            this.buildToolStripMenuItem1.Click += new System.EventHandler(this.buildToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // editorCodigo
            // 
            this.editorCodigo.Controls.Add(this.tabPage1);
            this.editorCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.editorCodigo.Location = new System.Drawing.Point(176, 30);
            this.editorCodigo.Name = "editorCodigo";
            this.editorCodigo.SelectedIndex = 0;
            this.editorCodigo.Size = new System.Drawing.Size(553, 399);
            this.editorCodigo.TabIndex = 0;
            this.editorCodigo.SelectedIndexChanged += new System.EventHandler(this.editorCodigo_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.codigoTexto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // codigoTexto
            // 
            this.codigoTexto.AcceptsTab = true;
            this.codigoTexto.BackColor = System.Drawing.Color.White;
            this.codigoTexto.EnableAutoDragDrop = true;
            this.codigoTexto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTexto.Location = new System.Drawing.Point(0, 1);
            this.codigoTexto.Name = "codigoTexto";
            this.codigoTexto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.codigoTexto.Size = new System.Drawing.Size(543, 371);
            this.codigoTexto.TabIndex = 3;
            this.codigoTexto.TabStop = false;
            this.codigoTexto.Text = "";
            this.codigoTexto.TextChanged += new System.EventHandler(this.codigoTexto_TextChanged);
            // 
            // textoTerminal
            // 
            this.textoTerminal.Location = new System.Drawing.Point(0, 0);
            this.textoTerminal.Multiline = true;
            this.textoTerminal.Name = "textoTerminal";
            this.textoTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoTerminal.Size = new System.Drawing.Size(958, 94);
            this.textoTerminal.TabIndex = 3;
            this.textoTerminal.TextChanged += new System.EventHandler(this.terminal_TextChanged);
            // 
            // tabLexico
            // 
            this.tabLexico.Controls.Add(this.Tokens);
            this.tabLexico.Controls.Add(this.arbolLex);
            this.tabLexico.Controls.Add(this.tabPage2);
            this.tabLexico.Controls.Add(this.CodInter);
            this.tabLexico.ItemSize = new System.Drawing.Size(48, 18);
            this.tabLexico.Location = new System.Drawing.Point(735, 30);
            this.tabLexico.Name = "tabLexico";
            this.tabLexico.SelectedIndex = 0;
            this.tabLexico.Size = new System.Drawing.Size(243, 395);
            this.tabLexico.TabIndex = 4;
            this.tabLexico.Tag = "gdgh";
            // 
            // Tokens
            // 
            this.Tokens.Controls.Add(this.tablaTokens);
            this.Tokens.Controls.Add(this.tokenText);
            this.Tokens.Location = new System.Drawing.Point(4, 22);
            this.Tokens.Name = "Tokens";
            this.Tokens.Padding = new System.Windows.Forms.Padding(3);
            this.Tokens.Size = new System.Drawing.Size(235, 369);
            this.Tokens.TabIndex = 0;
            this.Tokens.Text = "Tokens";
            this.Tokens.UseVisualStyleBackColor = true;
            this.Tokens.Click += new System.EventHandler(this.tabPage1_Click_2);
            // 
            // tablaTokens
            // 
            this.tablaTokens.AllowUserToAddRows = false;
            this.tablaTokens.AllowUserToDeleteRows = false;
            this.tablaTokens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campoToken,
            this.campoTipo,
            this.campoLinea});
            this.tablaTokens.Location = new System.Drawing.Point(0, 0);
            this.tablaTokens.Name = "tablaTokens";
            this.tablaTokens.RowHeadersVisible = false;
            this.tablaTokens.RowHeadersWidth = 51;
            this.tablaTokens.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tablaTokens.Size = new System.Drawing.Size(235, 24);
            this.tablaTokens.TabIndex = 2;
            this.tablaTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // campoToken
            // 
            this.campoToken.HeaderText = "Token";
            this.campoToken.MinimumWidth = 6;
            this.campoToken.Name = "campoToken";
            this.campoToken.Width = 70;
            // 
            // campoTipo
            // 
            this.campoTipo.HeaderText = "Tipo de Token";
            this.campoTipo.MinimumWidth = 6;
            this.campoTipo.Name = "campoTipo";
            this.campoTipo.Width = 110;
            // 
            // campoLinea
            // 
            this.campoLinea.HeaderText = "Línea";
            this.campoLinea.MinimumWidth = 6;
            this.campoLinea.Name = "campoLinea";
            this.campoLinea.Width = 50;
            // 
            // tokenText
            // 
            this.tokenText.Location = new System.Drawing.Point(3, 30);
            this.tokenText.Name = "tokenText";
            this.tokenText.Size = new System.Drawing.Size(227, 338);
            this.tokenText.TabIndex = 0;
            this.tokenText.Text = "";
            // 
            // arbolLex
            // 
            this.arbolLex.Controls.Add(this.treeView1);
            this.arbolLex.Location = new System.Drawing.Point(4, 22);
            this.arbolLex.Name = "arbolLex";
            this.arbolLex.Padding = new System.Windows.Forms.Padding(3);
            this.arbolLex.Size = new System.Drawing.Size(235, 369);
            this.arbolLex.TabIndex = 1;
            this.arbolLex.Text = "Árbol";
            this.arbolLex.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(232, 370);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tablaSimbolos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 369);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Símbolos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tablaSimbolos
            // 
            this.tablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Nombre,
            this.Valor});
            this.tablaSimbolos.Location = new System.Drawing.Point(0, 0);
            this.tablaSimbolos.Name = "tablaSimbolos";
            this.tablaSimbolos.RowHeadersVisible = false;
            this.tablaSimbolos.RowHeadersWidth = 4;
            this.tablaSimbolos.Size = new System.Drawing.Size(235, 369);
            this.tablaSimbolos.TabIndex = 0;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 47;
            // 
            // CodInter
            // 
            this.CodInter.Controls.Add(this.txtCodInter);
            this.CodInter.Location = new System.Drawing.Point(4, 22);
            this.CodInter.Name = "CodInter";
            this.CodInter.Padding = new System.Windows.Forms.Padding(3);
            this.CodInter.Size = new System.Drawing.Size(235, 369);
            this.CodInter.TabIndex = 3;
            this.CodInter.Text = "CodInter";
            this.CodInter.UseVisualStyleBackColor = true;
            // 
            // txtCodInter
            // 
            this.txtCodInter.Location = new System.Drawing.Point(0, 0);
            this.txtCodInter.Name = "txtCodInter";
            this.txtCodInter.Size = new System.Drawing.Size(235, 369);
            this.txtCodInter.TabIndex = 0;
            this.txtCodInter.Text = "";
            // 
            // tabsTerminal
            // 
            this.tabsTerminal.Controls.Add(this.Terminal);
            this.tabsTerminal.Location = new System.Drawing.Point(12, 435);
            this.tabsTerminal.Name = "tabsTerminal";
            this.tabsTerminal.SelectedIndex = 0;
            this.tabsTerminal.Size = new System.Drawing.Size(966, 120);
            this.tabsTerminal.TabIndex = 5;
            // 
            // Terminal
            // 
            this.Terminal.Controls.Add(this.textoTerminal);
            this.Terminal.Location = new System.Drawing.Point(4, 22);
            this.Terminal.Name = "Terminal";
            this.Terminal.Padding = new System.Windows.Forms.Padding(3);
            this.Terminal.Size = new System.Drawing.Size(958, 94);
            this.Terminal.TabIndex = 0;
            this.Terminal.Text = "Terminal";
            this.Terminal.UseVisualStyleBackColor = true;
            // 
            // editorPrin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 567);
            this.Controls.Add(this.tabsTerminal);
            this.Controls.Add(this.tabLexico);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.editorCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "editorPrin";
            this.Text = "Lilith";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.editorCodigo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabLexico.ResumeLayout(false);
            this.Tokens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).EndInit();
            this.arbolLex.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).EndInit();
            this.CodInter.ResumeLayout(false);
            this.tabsTerminal.ResumeLayout(false);
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProyectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProyectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findInFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.TabControl editorCodigo;
        private System.Windows.Forms.TextBox textoTerminal;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.TreeView arbolProyecto;
        private System.Windows.Forms.TabControl tabLexico;
        private System.Windows.Forms.TabPage arbolLex;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem1;
        private System.Windows.Forms.TabPage Tokens;
        private System.Windows.Forms.RichTextBox tokenText;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox codigoTexto;
        private System.Windows.Forms.DataGridView tablaTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoLinea;
        private System.Windows.Forms.TabControl tabsTerminal;
        private System.Windows.Forms.TabPage Terminal;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tablaSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.TabPage CodInter;
        private System.Windows.Forms.RichTextBox txtCodInter;
    }
}

