
namespace WindowsFormsApp8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centros_departamentosDataSet = new WindowsFormsApp8.centros_departamentosDataSet();
            this.empleadosTableAdapter = new WindowsFormsApp8.centros_departamentosDataSetTableAdapters.EmpleadosTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.centrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosTableAdapter = new WindowsFormsApp8.centros_departamentosDataSetTableAdapters.CentrosTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_DepartamentoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_DepartamentoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new WindowsFormsApp8.centros_departamentosDataSetTableAdapters.DepartamentosTableAdapter();
            this.fillByIdCentroToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_CentroToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_CentroToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIdCentroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centros_departamentosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            this.fillByIdCentroToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Id_Empleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "Id_Empleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "Id_Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // centros_departamentosDataSet
            // 
            this.centros_departamentosDataSet.DataSetName = "centros_departamentosDataSet";
            this.centros_departamentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.centrosBindingSource;
            this.comboBox1.DisplayMember = "Centro";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id_Centro";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // centrosBindingSource
            // 
            this.centrosBindingSource.DataMember = "Centros";
            this.centrosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // centrosTableAdapter
            // 
            this.centrosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_DepartamentoToolStripLabel,
            this.id_DepartamentoToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 31);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(820, 31);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // id_DepartamentoToolStripLabel
            // 
            this.id_DepartamentoToolStripLabel.Name = "id_DepartamentoToolStripLabel";
            this.id_DepartamentoToolStripLabel.Size = new System.Drawing.Size(128, 24);
            this.id_DepartamentoToolStripLabel.Text = "Id_Departamento:";
            // 
            // id_DepartamentoToolStripTextBox
            // 
            this.id_DepartamentoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id_DepartamentoToolStripTextBox.Name = "id_DepartamentoToolStripTextBox";
            this.id_DepartamentoToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departamentosBindingSource;
            this.comboBox2.DisplayMember = "Departamento";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(237, 376);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Id_Departamento";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.centros_departamentosDataSet;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByIdCentroToolStrip
            // 
            this.fillByIdCentroToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByIdCentroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_CentroToolStripLabel,
            this.id_CentroToolStripTextBox,
            this.fillByIdCentroToolStripButton});
            this.fillByIdCentroToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIdCentroToolStrip.Name = "fillByIdCentroToolStrip";
            this.fillByIdCentroToolStrip.Size = new System.Drawing.Size(820, 31);
            this.fillByIdCentroToolStrip.TabIndex = 4;
            this.fillByIdCentroToolStrip.Text = "fillByIdCentroToolStrip";
            // 
            // id_CentroToolStripLabel
            // 
            this.id_CentroToolStripLabel.Name = "id_CentroToolStripLabel";
            this.id_CentroToolStripLabel.Size = new System.Drawing.Size(75, 24);
            this.id_CentroToolStripLabel.Text = "Id_Centro:";
            // 
            // id_CentroToolStripTextBox
            // 
            this.id_CentroToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id_CentroToolStripTextBox.Name = "id_CentroToolStripTextBox";
            this.id_CentroToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByIdCentroToolStripButton
            // 
            this.fillByIdCentroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIdCentroToolStripButton.Name = "fillByIdCentroToolStripButton";
            this.fillByIdCentroToolStripButton.Size = new System.Drawing.Size(105, 24);
            this.fillByIdCentroToolStripButton.Text = "FillByIdCentro";
            this.fillByIdCentroToolStripButton.Click += new System.EventHandler(this.fillByIdCentroToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.fillByToolStrip);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.fillByIdCentroToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 450);
            this.panel2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(55, 31);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(271, 35);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centros_departamentosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            this.fillByIdCentroToolStrip.ResumeLayout(false);
            this.fillByIdCentroToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private centros_departamentosDataSet centros_departamentosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private centros_departamentosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource centrosBindingSource;
        private centros_departamentosDataSetTableAdapters.CentrosTableAdapter centrosTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel id_DepartamentoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox id_DepartamentoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private centros_departamentosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.ToolStrip fillByIdCentroToolStrip;
        private System.Windows.Forms.ToolStripLabel id_CentroToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox id_CentroToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIdCentroToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

