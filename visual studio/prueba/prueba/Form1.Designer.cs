namespace prueba
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
            this.panelAlumnoAlta = new System.Windows.Forms.Panel();
            this.labelNif = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panelAlumnoListar = new System.Windows.Forms.Panel();
            this.dataGridViewListarAlumno = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSet = new prueba.practicaDataSet();
            this.panelAlumnoModificar = new System.Windows.Forms.Panel();
            this.buttonGuardarModificar = new System.Windows.Forms.Button();
            this.dataGridViewModificarAlumno = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelAlumnosEliminar = new System.Windows.Forms.Panel();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.dataGridViewEliminarAlumno = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelEvaluacionesAlta = new System.Windows.Forms.Panel();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAltaEvaluaciones = new System.Windows.Forms.Button();
            this.panelEvaluacionesListar = new System.Windows.Forms.Panel();
            this.dataGridViewListarEvaluaciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelEvaluacionesModificar = new System.Windows.Forms.Panel();
            this.textBoxModificarEvaluaciones = new System.Windows.Forms.TextBox();
            this.buttonModificarEvaluaciones = new System.Windows.Forms.Button();
            this.comboBoxModificarEvaluaciones = new System.Windows.Forms.ComboBox();
            this.panelEvaluacionesEliminar = new System.Windows.Forms.Panel();
            this.buttonEliminarEvaluaciones = new System.Windows.Forms.Button();
            this.comboBoxEliminarEvaluaciones = new System.Windows.Forms.ComboBox();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEvaluacionesId = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosTableAdapter = new prueba.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.evaluacionesTableAdapter = new prueba.practicaDataSetTableAdapters.EvaluacionesTableAdapter();
            this.notasTableAdapter = new prueba.practicaDataSetTableAdapters.NotasTableAdapter();
            this.panelAlumnoAlta.SuspendLayout();
            this.panelAlumnoListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).BeginInit();
            this.panelAlumnoModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarAlumno)).BeginInit();
            this.panelAlumnosEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarAlumno)).BeginInit();
            this.panelEvaluacionesAlta.SuspendLayout();
            this.panelEvaluacionesListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarEvaluaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            this.panelEvaluacionesModificar.SuspendLayout();
            this.panelEvaluacionesEliminar.SuspendLayout();
            this.panelNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlumnoAlta
            // 
            this.panelAlumnoAlta.Controls.Add(this.labelNif);
            this.panelAlumnoAlta.Controls.Add(this.labelApellidos);
            this.panelAlumnoAlta.Controls.Add(this.labelNombre);
            this.panelAlumnoAlta.Controls.Add(this.buttonGuardar);
            this.panelAlumnoAlta.Controls.Add(this.checkBoxBaja);
            this.panelAlumnoAlta.Controls.Add(this.textBoxNif);
            this.panelAlumnoAlta.Controls.Add(this.textBoxApellido);
            this.panelAlumnoAlta.Controls.Add(this.textBoxNombre);
            this.panelAlumnoAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnoAlta.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnoAlta.Name = "panelAlumnoAlta";
            this.panelAlumnoAlta.Size = new System.Drawing.Size(800, 450);
            this.panelAlumnoAlta.TabIndex = 0;
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Location = new System.Drawing.Point(77, 155);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(20, 13);
            this.labelNif.TabIndex = 7;
            this.labelNif.Text = "Nif";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(77, 118);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 6;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(77, 79);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(127, 228);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(128, 196);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(50, 17);
            this.checkBoxBaja.TabIndex = 3;
            this.checkBoxBaja.Text = "Alta?";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(127, 155);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(100, 20);
            this.textBoxNif.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(127, 115);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(127, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // panelAlumnoListar
            // 
            this.panelAlumnoListar.Controls.Add(this.dataGridViewListarAlumno);
            this.panelAlumnoListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnoListar.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnoListar.Name = "panelAlumnoListar";
            this.panelAlumnoListar.Size = new System.Drawing.Size(800, 450);
            this.panelAlumnoListar.TabIndex = 0;
            // 
            // dataGridViewListarAlumno
            // 
            this.dataGridViewListarAlumno.AllowUserToAddRows = false;
            this.dataGridViewListarAlumno.AllowUserToDeleteRows = false;
            this.dataGridViewListarAlumno.AutoGenerateColumns = false;
            this.dataGridViewListarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.dataGridViewListarAlumno.DataSource = this.alumnosBindingSource;
            this.dataGridViewListarAlumno.Location = new System.Drawing.Point(133, 95);
            this.dataGridViewListarAlumno.Name = "dataGridViewListarAlumno";
            this.dataGridViewListarAlumno.ReadOnly = true;
            this.dataGridViewListarAlumno.Size = new System.Drawing.Size(443, 244);
            this.dataGridViewListarAlumno.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            this.bajaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.practicaDataSet;
            // 
            // practicaDataSet
            // 
            this.practicaDataSet.DataSetName = "practicaDataSet";
            this.practicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelAlumnoModificar
            // 
            this.panelAlumnoModificar.Controls.Add(this.buttonGuardarModificar);
            this.panelAlumnoModificar.Controls.Add(this.dataGridViewModificarAlumno);
            this.panelAlumnoModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnoModificar.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnoModificar.Name = "panelAlumnoModificar";
            this.panelAlumnoModificar.Size = new System.Drawing.Size(800, 450);
            this.panelAlumnoModificar.TabIndex = 0;
            // 
            // buttonGuardarModificar
            // 
            this.buttonGuardarModificar.Location = new System.Drawing.Point(302, 345);
            this.buttonGuardarModificar.Name = "buttonGuardarModificar";
            this.buttonGuardarModificar.Size = new System.Drawing.Size(122, 40);
            this.buttonGuardarModificar.TabIndex = 1;
            this.buttonGuardarModificar.Text = "Guardar";
            this.buttonGuardarModificar.UseVisualStyleBackColor = true;
            this.buttonGuardarModificar.Click += new System.EventHandler(this.buttonGuardarModificar_Click);
            // 
            // dataGridViewModificarAlumno
            // 
            this.dataGridViewModificarAlumno.AllowUserToAddRows = false;
            this.dataGridViewModificarAlumno.AllowUserToDeleteRows = false;
            this.dataGridViewModificarAlumno.AutoGenerateColumns = false;
            this.dataGridViewModificarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn1,
            this.nIFDataGridViewTextBoxColumn1,
            this.bajaDataGridViewCheckBoxColumn1});
            this.dataGridViewModificarAlumno.DataSource = this.alumnosBindingSource;
            this.dataGridViewModificarAlumno.Location = new System.Drawing.Point(101, 64);
            this.dataGridViewModificarAlumno.Name = "dataGridViewModificarAlumno";
            this.dataGridViewModificarAlumno.Size = new System.Drawing.Size(543, 262);
            this.dataGridViewModificarAlumno.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // apellidosDataGridViewTextBoxColumn1
            // 
            this.apellidosDataGridViewTextBoxColumn1.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.Name = "apellidosDataGridViewTextBoxColumn1";
            // 
            // nIFDataGridViewTextBoxColumn1
            // 
            this.nIFDataGridViewTextBoxColumn1.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn1.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn1.Name = "nIFDataGridViewTextBoxColumn1";
            // 
            // bajaDataGridViewCheckBoxColumn1
            // 
            this.bajaDataGridViewCheckBoxColumn1.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn1.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn1.Name = "bajaDataGridViewCheckBoxColumn1";
            // 
            // panelAlumnosEliminar
            // 
            this.panelAlumnosEliminar.Controls.Add(this.buttonEliminarAlumno);
            this.panelAlumnosEliminar.Controls.Add(this.dataGridViewEliminarAlumno);
            this.panelAlumnosEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnosEliminar.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnosEliminar.Name = "panelAlumnosEliminar";
            this.panelAlumnosEliminar.Size = new System.Drawing.Size(800, 450);
            this.panelAlumnosEliminar.TabIndex = 0;
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(339, 335);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(122, 33);
            this.buttonEliminarAlumno.TabIndex = 1;
            this.buttonEliminarAlumno.Text = "Eliminar";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = true;
            this.buttonEliminarAlumno.Click += new System.EventHandler(this.buttonEliminarAlumno_Click);
            // 
            // dataGridViewEliminarAlumno
            // 
            this.dataGridViewEliminarAlumno.AllowUserToAddRows = false;
            this.dataGridViewEliminarAlumno.AllowUserToDeleteRows = false;
            this.dataGridViewEliminarAlumno.AutoGenerateColumns = false;
            this.dataGridViewEliminarAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminarAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn2,
            this.apellidosDataGridViewTextBoxColumn2,
            this.nIFDataGridViewTextBoxColumn2,
            this.bajaDataGridViewCheckBoxColumn2});
            this.dataGridViewEliminarAlumno.DataSource = this.alumnosBindingSource;
            this.dataGridViewEliminarAlumno.Location = new System.Drawing.Point(120, 71);
            this.dataGridViewEliminarAlumno.Name = "dataGridViewEliminarAlumno";
            this.dataGridViewEliminarAlumno.ReadOnly = true;
            this.dataGridViewEliminarAlumno.Size = new System.Drawing.Size(547, 254);
            this.dataGridViewEliminarAlumno.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn2
            // 
            this.apellidosDataGridViewTextBoxColumn2.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn2.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn2.Name = "apellidosDataGridViewTextBoxColumn2";
            this.apellidosDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn2
            // 
            this.nIFDataGridViewTextBoxColumn2.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn2.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn2.Name = "nIFDataGridViewTextBoxColumn2";
            this.nIFDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn2
            // 
            this.bajaDataGridViewCheckBoxColumn2.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn2.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn2.Name = "bajaDataGridViewCheckBoxColumn2";
            this.bajaDataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // panelEvaluacionesAlta
            // 
            this.panelEvaluacionesAlta.Controls.Add(this.textBoxDescripcion);
            this.panelEvaluacionesAlta.Controls.Add(this.buttonAltaEvaluaciones);
            this.panelEvaluacionesAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaluacionesAlta.Location = new System.Drawing.Point(0, 0);
            this.panelEvaluacionesAlta.Name = "panelEvaluacionesAlta";
            this.panelEvaluacionesAlta.Size = new System.Drawing.Size(800, 450);
            this.panelEvaluacionesAlta.TabIndex = 0;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(263, 176);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(227, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // buttonAltaEvaluaciones
            // 
            this.buttonAltaEvaluaciones.Location = new System.Drawing.Point(302, 248);
            this.buttonAltaEvaluaciones.Name = "buttonAltaEvaluaciones";
            this.buttonAltaEvaluaciones.Size = new System.Drawing.Size(159, 54);
            this.buttonAltaEvaluaciones.TabIndex = 0;
            this.buttonAltaEvaluaciones.Text = "Guardar";
            this.buttonAltaEvaluaciones.UseVisualStyleBackColor = true;
            this.buttonAltaEvaluaciones.Click += new System.EventHandler(this.buttonAltaEvaluaciones_Click);
            // 
            // panelEvaluacionesListar
            // 
            this.panelEvaluacionesListar.Controls.Add(this.dataGridViewListarEvaluaciones);
            this.panelEvaluacionesListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaluacionesListar.Location = new System.Drawing.Point(0, 0);
            this.panelEvaluacionesListar.Name = "panelEvaluacionesListar";
            this.panelEvaluacionesListar.Size = new System.Drawing.Size(800, 450);
            this.panelEvaluacionesListar.TabIndex = 0;
            // 
            // dataGridViewListarEvaluaciones
            // 
            this.dataGridViewListarEvaluaciones.AllowUserToAddRows = false;
            this.dataGridViewListarEvaluaciones.AllowUserToDeleteRows = false;
            this.dataGridViewListarEvaluaciones.AutoGenerateColumns = false;
            this.dataGridViewListarEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.evaluacionDataGridViewTextBoxColumn});
            this.dataGridViewListarEvaluaciones.DataSource = this.evaluacionesBindingSource;
            this.dataGridViewListarEvaluaciones.Location = new System.Drawing.Point(130, 89);
            this.dataGridViewListarEvaluaciones.Name = "dataGridViewListarEvaluaciones";
            this.dataGridViewListarEvaluaciones.ReadOnly = true;
            this.dataGridViewListarEvaluaciones.Size = new System.Drawing.Size(558, 279);
            this.dataGridViewListarEvaluaciones.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            this.evaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.practicaDataSet;
            // 
            // panelEvaluacionesModificar
            // 
            this.panelEvaluacionesModificar.Controls.Add(this.textBoxModificarEvaluaciones);
            this.panelEvaluacionesModificar.Controls.Add(this.buttonModificarEvaluaciones);
            this.panelEvaluacionesModificar.Controls.Add(this.comboBoxModificarEvaluaciones);
            this.panelEvaluacionesModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaluacionesModificar.Location = new System.Drawing.Point(0, 0);
            this.panelEvaluacionesModificar.Name = "panelEvaluacionesModificar";
            this.panelEvaluacionesModificar.Size = new System.Drawing.Size(800, 450);
            this.panelEvaluacionesModificar.TabIndex = 0;
            // 
            // textBoxModificarEvaluaciones
            // 
            this.textBoxModificarEvaluaciones.Location = new System.Drawing.Point(132, 162);
            this.textBoxModificarEvaluaciones.Name = "textBoxModificarEvaluaciones";
            this.textBoxModificarEvaluaciones.Size = new System.Drawing.Size(131, 20);
            this.textBoxModificarEvaluaciones.TabIndex = 2;
            // 
            // buttonModificarEvaluaciones
            // 
            this.buttonModificarEvaluaciones.Location = new System.Drawing.Point(136, 226);
            this.buttonModificarEvaluaciones.Name = "buttonModificarEvaluaciones";
            this.buttonModificarEvaluaciones.Size = new System.Drawing.Size(109, 40);
            this.buttonModificarEvaluaciones.TabIndex = 1;
            this.buttonModificarEvaluaciones.Text = "Guardar";
            this.buttonModificarEvaluaciones.UseVisualStyleBackColor = true;
            this.buttonModificarEvaluaciones.Click += new System.EventHandler(this.buttonModificarEvaluaciones_Click);
            // 
            // comboBoxModificarEvaluaciones
            // 
            this.comboBoxModificarEvaluaciones.DataSource = this.evaluacionesBindingSource;
            this.comboBoxModificarEvaluaciones.DisplayMember = "Evaluacion";
            this.comboBoxModificarEvaluaciones.FormattingEnabled = true;
            this.comboBoxModificarEvaluaciones.Location = new System.Drawing.Point(135, 86);
            this.comboBoxModificarEvaluaciones.Name = "comboBoxModificarEvaluaciones";
            this.comboBoxModificarEvaluaciones.Size = new System.Drawing.Size(111, 21);
            this.comboBoxModificarEvaluaciones.TabIndex = 0;
            this.comboBoxModificarEvaluaciones.ValueMember = "Id";
            this.comboBoxModificarEvaluaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxModificarEvaluaciones_SelectedIndexChanged);
            // 
            // panelEvaluacionesEliminar
            // 
            this.panelEvaluacionesEliminar.Controls.Add(this.buttonEliminarEvaluaciones);
            this.panelEvaluacionesEliminar.Controls.Add(this.comboBoxEliminarEvaluaciones);
            this.panelEvaluacionesEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaluacionesEliminar.Location = new System.Drawing.Point(0, 0);
            this.panelEvaluacionesEliminar.Name = "panelEvaluacionesEliminar";
            this.panelEvaluacionesEliminar.Size = new System.Drawing.Size(800, 450);
            this.panelEvaluacionesEliminar.TabIndex = 0;
            // 
            // buttonEliminarEvaluaciones
            // 
            this.buttonEliminarEvaluaciones.Location = new System.Drawing.Point(173, 173);
            this.buttonEliminarEvaluaciones.Name = "buttonEliminarEvaluaciones";
            this.buttonEliminarEvaluaciones.Size = new System.Drawing.Size(187, 75);
            this.buttonEliminarEvaluaciones.TabIndex = 1;
            this.buttonEliminarEvaluaciones.Text = "Guardar";
            this.buttonEliminarEvaluaciones.UseVisualStyleBackColor = true;
            this.buttonEliminarEvaluaciones.Click += new System.EventHandler(this.buttonEliminarEvaluaciones_Click);
            // 
            // comboBoxEliminarEvaluaciones
            // 
            this.comboBoxEliminarEvaluaciones.DataSource = this.evaluacionesBindingSource;
            this.comboBoxEliminarEvaluaciones.DisplayMember = "Evaluacion";
            this.comboBoxEliminarEvaluaciones.FormattingEnabled = true;
            this.comboBoxEliminarEvaluaciones.Location = new System.Drawing.Point(172, 124);
            this.comboBoxEliminarEvaluaciones.Name = "comboBoxEliminarEvaluaciones";
            this.comboBoxEliminarEvaluaciones.Size = new System.Drawing.Size(189, 21);
            this.comboBoxEliminarEvaluaciones.TabIndex = 0;
            this.comboBoxEliminarEvaluaciones.ValueMember = "Id";
            // 
            // panelNotas
            // 
            this.panelNotas.Controls.Add(this.checkBoxTodos);
            this.panelNotas.Controls.Add(this.listBoxAlumnos);
            this.panelNotas.Controls.Add(this.dataGridViewNotas);
            this.panelNotas.Controls.Add(this.comboBoxEvaluacionesId);
            this.panelNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotas.Location = new System.Drawing.Point(0, 0);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(800, 450);
            this.panelNotas.TabIndex = 0;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(93, 111);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTodos.TabIndex = 3;
            this.checkBoxTodos.Text = "Todos?";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.DataSource = this.alumnosBindingSource;
            this.listBoxAlumnos.DisplayMember = "Nombre";
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(85, 53);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(400, 43);
            this.listBoxAlumnos.TabIndex = 2;
            this.listBoxAlumnos.ValueMember = "Id";
            this.listBoxAlumnos.SelectedIndexChanged += new System.EventHandler(this.listBoxAlumnos_SelectedIndexChanged);
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AutoGenerateColumns = false;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.dIDataGridViewTextBoxColumn,
            this.pMDMDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn});
            this.dataGridViewNotas.DataSource = this.notasBindingSource;
            this.dataGridViewNotas.Location = new System.Drawing.Point(85, 139);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.Size = new System.Drawing.Size(640, 245);
            this.dataGridViewNotas.TabIndex = 1;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            // 
            // dIDataGridViewTextBoxColumn
            // 
            this.dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            this.dIDataGridViewTextBoxColumn.HeaderText = "DI";
            this.dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            // 
            // pMDMDataGridViewTextBoxColumn
            // 
            this.pMDMDataGridViewTextBoxColumn.DataPropertyName = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.HeaderText = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.Name = "pMDMDataGridViewTextBoxColumn";
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.practicaDataSet;
            // 
            // comboBoxEvaluacionesId
            // 
            this.comboBoxEvaluacionesId.DataSource = this.evaluacionesBindingSource;
            this.comboBoxEvaluacionesId.DisplayMember = "Evaluacion";
            this.comboBoxEvaluacionesId.FormattingEnabled = true;
            this.comboBoxEvaluacionesId.Location = new System.Drawing.Point(512, 64);
            this.comboBoxEvaluacionesId.Name = "comboBoxEvaluacionesId";
            this.comboBoxEvaluacionesId.Size = new System.Drawing.Size(214, 21);
            this.comboBoxEvaluacionesId.TabIndex = 0;
            this.comboBoxEvaluacionesId.ValueMember = "Id";
            this.comboBoxEvaluacionesId.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvaluacionesId_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelAlumnoAlta);
            this.Controls.Add(this.panelAlumnoListar);
            this.Controls.Add(this.panelAlumnoModificar);
            this.Controls.Add(this.panelAlumnosEliminar);
            this.Controls.Add(this.panelEvaluacionesAlta);
            this.Controls.Add(this.panelEvaluacionesListar);
            this.Controls.Add(this.panelEvaluacionesModificar);
            this.Controls.Add(this.panelEvaluacionesEliminar);
            this.Controls.Add(this.panelNotas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAlumnoAlta.ResumeLayout(false);
            this.panelAlumnoAlta.PerformLayout();
            this.panelAlumnoListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).EndInit();
            this.panelAlumnoModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarAlumno)).EndInit();
            this.panelAlumnosEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarAlumno)).EndInit();
            this.panelEvaluacionesAlta.ResumeLayout(false);
            this.panelEvaluacionesAlta.PerformLayout();
            this.panelEvaluacionesListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarEvaluaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            this.panelEvaluacionesModificar.ResumeLayout(false);
            this.panelEvaluacionesModificar.PerformLayout();
            this.panelEvaluacionesEliminar.ResumeLayout(false);
            this.panelNotas.ResumeLayout(false);
            this.panelNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAlumnoAlta;
        private System.Windows.Forms.Panel panelAlumnoListar;
        private System.Windows.Forms.Panel panelAlumnoModificar;
        private System.Windows.Forms.Panel panelAlumnosEliminar;
        private System.Windows.Forms.Panel panelEvaluacionesAlta;
        private System.Windows.Forms.Panel panelEvaluacionesListar;
        private System.Windows.Forms.Panel panelEvaluacionesModificar;
        private System.Windows.Forms.Panel panelEvaluacionesEliminar;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.DataGridView dataGridViewListarAlumno;
        private System.Windows.Forms.Button buttonGuardarModificar;
        private System.Windows.Forms.DataGridView dataGridViewModificarAlumno;
        private System.Windows.Forms.Button buttonEliminarAlumno;
        private System.Windows.Forms.DataGridView dataGridViewEliminarAlumno;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAltaEvaluaciones;
        private System.Windows.Forms.DataGridView dataGridViewListarEvaluaciones;
        private System.Windows.Forms.TextBox textBoxModificarEvaluaciones;
        private System.Windows.Forms.Button buttonModificarEvaluaciones;
        private System.Windows.Forms.ComboBox comboBoxModificarEvaluaciones;
        private System.Windows.Forms.Button buttonEliminarEvaluaciones;
        private System.Windows.Forms.ComboBox comboBoxEliminarEvaluaciones;
        private practicaDataSet practicaDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private practicaDataSetTableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.ComboBox comboBoxEvaluacionesId;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private practicaDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.ListBox listBoxAlumnos;
    }
}

