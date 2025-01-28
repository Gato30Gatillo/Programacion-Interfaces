namespace Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCentroAdd = new System.Windows.Forms.Panel();
            this.buttonCentrosAdd = new System.Windows.Forms.Button();
            this.textBoxCentrosAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panelListarCentro = new System.Windows.Forms.Panel();
            this.dataGridViewListarCentros = new System.Windows.Forms.DataGridView();
            this.idCentroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centros_departamentosDataSet = new Examen.centros_departamentosDataSet();
            this.panelBorrarCentro = new System.Windows.Forms.Panel();
            this.buttonBorrarCentro = new System.Windows.Forms.Button();
            this.comboBoxBorrarCentro = new System.Windows.Forms.ComboBox();
            this.panelAddEmpleado = new System.Windows.Forms.Panel();
            this.buttonAddEmpleado = new System.Windows.Forms.Button();
            this.textBoxAddEmpleado = new System.Windows.Forms.TextBox();
            this.comboBoxAddEmpleado = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAddEmpleado = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListarEmpleado = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosTableAdapter = new Examen.centros_departamentosDataSetTableAdapters.CentrosTableAdapter();
            this.departamentosTableAdapter = new Examen.centros_departamentosDataSetTableAdapters.DepartamentosTableAdapter();
            this.empleadosTableAdapter = new Examen.centros_departamentosDataSetTableAdapters.EmpleadosTableAdapter();
            this.panelEliminarEmpleado = new System.Windows.Forms.Panel();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.comboBoxEliminarEmpleado = new System.Windows.Forms.ComboBox();
            this.comboBoxEliminarEmpleadoDepartamento = new System.Windows.Forms.ComboBox();
            this.comboBoxEliminarEmpleadoCentro = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panelCentroAdd.SuspendLayout();
            this.panelListarCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarCentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centros_departamentosDataSet)).BeginInit();
            this.panelBorrarCentro.SuspendLayout();
            this.panelAddEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            this.panelListarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.panelEliminarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centrosToolStripMenuItem
            // 
            this.centrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.añadirToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.centrosToolStripMenuItem.Name = "centrosToolStripMenuItem";
            this.centrosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.centrosToolStripMenuItem.Text = "Centros";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem1,
            this.añadirToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // inicioToolStripMenuItem1
            // 
            this.inicioToolStripMenuItem1.Name = "inicioToolStripMenuItem1";
            this.inicioToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.inicioToolStripMenuItem1.Text = "Inicio";
            // 
            // añadirToolStripMenuItem1
            // 
            this.añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            this.añadirToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.añadirToolStripMenuItem1.Text = "Añadir";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem2,
            this.añadirToolStripMenuItem2,
            this.listarToolStripMenuItem2,
            this.borrarToolStripMenuItem2});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // inicioToolStripMenuItem2
            // 
            this.inicioToolStripMenuItem2.Name = "inicioToolStripMenuItem2";
            this.inicioToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.inicioToolStripMenuItem2.Text = "Inicio";
            this.inicioToolStripMenuItem2.Click += new System.EventHandler(this.inicioToolStripMenuItem2_Click);
            // 
            // añadirToolStripMenuItem2
            // 
            this.añadirToolStripMenuItem2.Name = "añadirToolStripMenuItem2";
            this.añadirToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.añadirToolStripMenuItem2.Text = "Añadir";
            this.añadirToolStripMenuItem2.Click += new System.EventHandler(this.añadirToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem2.Text = "Borrar";
            this.borrarToolStripMenuItem2.Click += new System.EventHandler(this.borrarToolStripMenuItem2_Click);
            // 
            // panelCentroAdd
            // 
            this.panelCentroAdd.Controls.Add(this.buttonCentrosAdd);
            this.panelCentroAdd.Controls.Add(this.textBoxCentrosAdd);
            this.panelCentroAdd.Controls.Add(this.label1);
            this.panelCentroAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentroAdd.Location = new System.Drawing.Point(0, 24);
            this.panelCentroAdd.Name = "panelCentroAdd";
            this.panelCentroAdd.Size = new System.Drawing.Size(800, 426);
            this.panelCentroAdd.TabIndex = 1;
            // 
            // buttonCentrosAdd
            // 
            this.buttonCentrosAdd.Location = new System.Drawing.Point(108, 130);
            this.buttonCentrosAdd.Name = "buttonCentrosAdd";
            this.buttonCentrosAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCentrosAdd.TabIndex = 2;
            this.buttonCentrosAdd.Text = "Añadir";
            this.buttonCentrosAdd.UseVisualStyleBackColor = true;
            this.buttonCentrosAdd.Click += new System.EventHandler(this.buttonCentrosAdd_Click);
            // 
            // textBoxCentrosAdd
            // 
            this.textBoxCentrosAdd.Location = new System.Drawing.Point(150, 73);
            this.textBoxCentrosAdd.Name = "textBoxCentrosAdd";
            this.textBoxCentrosAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxCentrosAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centro";
            // 
            // panelInicio
            // 
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 24);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(800, 426);
            this.panelInicio.TabIndex = 3;
            // 
            // panelListarCentro
            // 
            this.panelListarCentro.Controls.Add(this.dataGridViewListarCentros);
            this.panelListarCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListarCentro.Location = new System.Drawing.Point(0, 24);
            this.panelListarCentro.Name = "panelListarCentro";
            this.panelListarCentro.Size = new System.Drawing.Size(800, 426);
            this.panelListarCentro.TabIndex = 0;
            // 
            // dataGridViewListarCentros
            // 
            this.dataGridViewListarCentros.AllowUserToAddRows = false;
            this.dataGridViewListarCentros.AllowUserToDeleteRows = false;
            this.dataGridViewListarCentros.AutoGenerateColumns = false;
            this.dataGridViewListarCentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarCentros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCentroDataGridViewTextBoxColumn,
            this.centroDataGridViewTextBoxColumn});
            this.dataGridViewListarCentros.DataSource = this.centrosBindingSource;
            this.dataGridViewListarCentros.Location = new System.Drawing.Point(150, 53);
            this.dataGridViewListarCentros.Name = "dataGridViewListarCentros";
            this.dataGridViewListarCentros.ReadOnly = true;
            this.dataGridViewListarCentros.Size = new System.Drawing.Size(476, 289);
            this.dataGridViewListarCentros.TabIndex = 0;
            // 
            // idCentroDataGridViewTextBoxColumn
            // 
            this.idCentroDataGridViewTextBoxColumn.DataPropertyName = "Id_Centro";
            this.idCentroDataGridViewTextBoxColumn.HeaderText = "Id_Centro";
            this.idCentroDataGridViewTextBoxColumn.Name = "idCentroDataGridViewTextBoxColumn";
            this.idCentroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centroDataGridViewTextBoxColumn
            // 
            this.centroDataGridViewTextBoxColumn.DataPropertyName = "Centro";
            this.centroDataGridViewTextBoxColumn.HeaderText = "Centro";
            this.centroDataGridViewTextBoxColumn.Name = "centroDataGridViewTextBoxColumn";
            this.centroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centrosBindingSource
            // 
            this.centrosBindingSource.DataMember = "Centros";
            this.centrosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // centros_departamentosDataSet
            // 
            this.centros_departamentosDataSet.DataSetName = "centros_departamentosDataSet";
            this.centros_departamentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBorrarCentro
            // 
            this.panelBorrarCentro.Controls.Add(this.buttonBorrarCentro);
            this.panelBorrarCentro.Controls.Add(this.comboBoxBorrarCentro);
            this.panelBorrarCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorrarCentro.Location = new System.Drawing.Point(0, 24);
            this.panelBorrarCentro.Name = "panelBorrarCentro";
            this.panelBorrarCentro.Size = new System.Drawing.Size(800, 426);
            this.panelBorrarCentro.TabIndex = 0;
            // 
            // buttonBorrarCentro
            // 
            this.buttonBorrarCentro.Location = new System.Drawing.Point(316, 190);
            this.buttonBorrarCentro.Name = "buttonBorrarCentro";
            this.buttonBorrarCentro.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarCentro.TabIndex = 1;
            this.buttonBorrarCentro.Text = "Borrar";
            this.buttonBorrarCentro.UseVisualStyleBackColor = true;
            this.buttonBorrarCentro.Click += new System.EventHandler(this.buttonBorrarCentro_Click);
            // 
            // comboBoxBorrarCentro
            // 
            this.comboBoxBorrarCentro.DataSource = this.centrosBindingSource;
            this.comboBoxBorrarCentro.DisplayMember = "Centro";
            this.comboBoxBorrarCentro.FormattingEnabled = true;
            this.comboBoxBorrarCentro.Location = new System.Drawing.Point(296, 140);
            this.comboBoxBorrarCentro.Name = "comboBoxBorrarCentro";
            this.comboBoxBorrarCentro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBorrarCentro.TabIndex = 0;
            this.comboBoxBorrarCentro.ValueMember = "Id_Centro";
            // 
            // panelAddEmpleado
            // 
            this.panelAddEmpleado.Controls.Add(this.buttonAddEmpleado);
            this.panelAddEmpleado.Controls.Add(this.textBoxAddEmpleado);
            this.panelAddEmpleado.Controls.Add(this.comboBoxAddEmpleado);
            this.panelAddEmpleado.Controls.Add(this.listBoxAddEmpleado);
            this.panelAddEmpleado.Controls.Add(this.label4);
            this.panelAddEmpleado.Controls.Add(this.label3);
            this.panelAddEmpleado.Controls.Add(this.label2);
            this.panelAddEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddEmpleado.Location = new System.Drawing.Point(0, 24);
            this.panelAddEmpleado.Name = "panelAddEmpleado";
            this.panelAddEmpleado.Size = new System.Drawing.Size(800, 426);
            this.panelAddEmpleado.TabIndex = 2;
            // 
            // buttonAddEmpleado
            // 
            this.buttonAddEmpleado.Location = new System.Drawing.Point(372, 303);
            this.buttonAddEmpleado.Name = "buttonAddEmpleado";
            this.buttonAddEmpleado.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmpleado.TabIndex = 6;
            this.buttonAddEmpleado.Text = "Añadir";
            this.buttonAddEmpleado.UseVisualStyleBackColor = true;
            this.buttonAddEmpleado.Click += new System.EventHandler(this.buttonAddEmpleado_Click);
            // 
            // textBoxAddEmpleado
            // 
            this.textBoxAddEmpleado.Location = new System.Drawing.Point(624, 144);
            this.textBoxAddEmpleado.Name = "textBoxAddEmpleado";
            this.textBoxAddEmpleado.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddEmpleado.TabIndex = 5;
            // 
            // comboBoxAddEmpleado
            // 
            this.comboBoxAddEmpleado.DataSource = this.departamentosBindingSource;
            this.comboBoxAddEmpleado.DisplayMember = "Departamento";
            this.comboBoxAddEmpleado.FormattingEnabled = true;
            this.comboBoxAddEmpleado.Location = new System.Drawing.Point(359, 147);
            this.comboBoxAddEmpleado.Name = "comboBoxAddEmpleado";
            this.comboBoxAddEmpleado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddEmpleado.TabIndex = 4;
            this.comboBoxAddEmpleado.ValueMember = "Id_Departamento";
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // listBoxAddEmpleado
            // 
            this.listBoxAddEmpleado.DataSource = this.centrosBindingSource;
            this.listBoxAddEmpleado.DisplayMember = "Centro";
            this.listBoxAddEmpleado.FormattingEnabled = true;
            this.listBoxAddEmpleado.Location = new System.Drawing.Point(64, 140);
            this.listBoxAddEmpleado.Name = "listBoxAddEmpleado";
            this.listBoxAddEmpleado.Size = new System.Drawing.Size(147, 186);
            this.listBoxAddEmpleado.TabIndex = 3;
            this.listBoxAddEmpleado.ValueMember = "Id_Centro";
            this.listBoxAddEmpleado.SelectedIndexChanged += new System.EventHandler(this.listBoxAddEmpleado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Centro";
            // 
            // panelListarEmpleado
            // 
            this.panelListarEmpleado.Controls.Add(this.dataGridView1);
            this.panelListarEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListarEmpleado.Location = new System.Drawing.Point(0, 24);
            this.panelListarEmpleado.Name = "panelListarEmpleado";
            this.panelListarEmpleado.Size = new System.Drawing.Size(800, 426);
            this.panelListarEmpleado.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // centrosTableAdapter
            // 
            this.centrosTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // panelEliminarEmpleado
            // 
            this.panelEliminarEmpleado.Controls.Add(this.buttonEliminarEmpleado);
            this.panelEliminarEmpleado.Controls.Add(this.comboBoxEliminarEmpleado);
            this.panelEliminarEmpleado.Controls.Add(this.comboBoxEliminarEmpleadoDepartamento);
            this.panelEliminarEmpleado.Controls.Add(this.comboBoxEliminarEmpleadoCentro);
            this.panelEliminarEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEliminarEmpleado.Location = new System.Drawing.Point(0, 24);
            this.panelEliminarEmpleado.Name = "panelEliminarEmpleado";
            this.panelEliminarEmpleado.Size = new System.Drawing.Size(800, 426);
            this.panelEliminarEmpleado.TabIndex = 1;
            // 
            // buttonEliminarEmpleado
            // 
            this.buttonEliminarEmpleado.Location = new System.Drawing.Point(303, 253);
            this.buttonEliminarEmpleado.Name = "buttonEliminarEmpleado";
            this.buttonEliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarEmpleado.TabIndex = 3;
            this.buttonEliminarEmpleado.Text = "Eliminar";
            this.buttonEliminarEmpleado.UseVisualStyleBackColor = true;
            this.buttonEliminarEmpleado.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // comboBoxEliminarEmpleado
            // 
            this.comboBoxEliminarEmpleado.FormattingEnabled = true;
            this.comboBoxEliminarEmpleado.Location = new System.Drawing.Point(535, 118);
            this.comboBoxEliminarEmpleado.Name = "comboBoxEliminarEmpleado";
            this.comboBoxEliminarEmpleado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarEmpleado.TabIndex = 2;
            // 
            // comboBoxEliminarEmpleadoDepartamento
            // 
            this.comboBoxEliminarEmpleadoDepartamento.FormattingEnabled = true;
            this.comboBoxEliminarEmpleadoDepartamento.Location = new System.Drawing.Point(283, 118);
            this.comboBoxEliminarEmpleadoDepartamento.Name = "comboBoxEliminarEmpleadoDepartamento";
            this.comboBoxEliminarEmpleadoDepartamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarEmpleadoDepartamento.TabIndex = 1;
            this.comboBoxEliminarEmpleadoDepartamento.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEliminarEmpleadoDepartamento_SelectionChangeCommitted);
            // 
            // comboBoxEliminarEmpleadoCentro
            // 
            this.comboBoxEliminarEmpleadoCentro.DataSource = this.centrosBindingSource;
            this.comboBoxEliminarEmpleadoCentro.DisplayMember = "Centro";
            this.comboBoxEliminarEmpleadoCentro.FormattingEnabled = true;
            this.comboBoxEliminarEmpleadoCentro.Location = new System.Drawing.Point(68, 118);
            this.comboBoxEliminarEmpleadoCentro.Name = "comboBoxEliminarEmpleadoCentro";
            this.comboBoxEliminarEmpleadoCentro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarEmpleadoCentro.TabIndex = 0;
            this.comboBoxEliminarEmpleadoCentro.ValueMember = "Id_Centro";
            this.comboBoxEliminarEmpleadoCentro.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEliminarEmpleadoCentro_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddEmpleado);
            this.Controls.Add(this.panelListarEmpleado);
            this.Controls.Add(this.panelEliminarEmpleado);
            this.Controls.Add(this.panelBorrarCentro);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelListarCentro);
            this.Controls.Add(this.panelCentroAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Z";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCentroAdd.ResumeLayout(false);
            this.panelCentroAdd.PerformLayout();
            this.panelListarCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarCentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centros_departamentosDataSet)).EndInit();
            this.panelBorrarCentro.ResumeLayout(false);
            this.panelAddEmpleado.ResumeLayout(false);
            this.panelAddEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            this.panelListarEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.panelEliminarEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem2;
        private System.Windows.Forms.Panel panelCentroAdd;
        private System.Windows.Forms.Button buttonCentrosAdd;
        private System.Windows.Forms.TextBox textBoxCentrosAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Panel panelListarCentro;
        private System.Windows.Forms.DataGridView dataGridViewListarCentros;
        private centros_departamentosDataSet centros_departamentosDataSet;
        private System.Windows.Forms.BindingSource centrosBindingSource;
        private centros_departamentosDataSetTableAdapters.CentrosTableAdapter centrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCentroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelBorrarCentro;
        private System.Windows.Forms.Button buttonBorrarCentro;
        private System.Windows.Forms.ComboBox comboBoxBorrarCentro;
        private System.Windows.Forms.Panel panelAddEmpleado;
        private System.Windows.Forms.Button buttonAddEmpleado;
        private System.Windows.Forms.TextBox textBoxAddEmpleado;
        private System.Windows.Forms.ComboBox comboBoxAddEmpleado;
        private System.Windows.Forms.ListBox listBoxAddEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private centros_departamentosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.Panel panelListarEmpleado;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private centros_departamentosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelEliminarEmpleado;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.ComboBox comboBoxEliminarEmpleado;
        private System.Windows.Forms.ComboBox comboBoxEliminarEmpleadoDepartamento;
        private System.Windows.Forms.ComboBox comboBoxEliminarEmpleadoCentro;
    }
}

