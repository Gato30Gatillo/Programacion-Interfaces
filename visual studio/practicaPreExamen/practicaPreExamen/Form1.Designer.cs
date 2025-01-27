namespace practicaPreExamen
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.panelListboxes = new System.Windows.Forms.Panel();
            this.panelCrudCentros = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCentros = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbIdCentro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCentro = new System.Windows.Forms.TextBox();
            this.panelListboxes.SuspendLayout();
            this.panelCrudCentros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCentros)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(259, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 199);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(519, 200);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(247, 199);
            this.listBox3.TabIndex = 3;
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.Location = new System.Drawing.Point(259, 172);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(247, 23);
            this.btnCargaDatos.TabIndex = 4;
            this.btnCargaDatos.Text = "CARGAR DATOS";
            this.btnCargaDatos.UseVisualStyleBackColor = true;
            this.btnCargaDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelListboxes
            // 
            this.panelListboxes.Controls.Add(this.btnCargaDatos);
            this.panelListboxes.Controls.Add(this.listBox1);
            this.panelListboxes.Controls.Add(this.listBox2);
            this.panelListboxes.Controls.Add(this.listBox3);
            this.panelListboxes.Location = new System.Drawing.Point(12, 39);
            this.panelListboxes.Name = "panelListboxes";
            this.panelListboxes.Size = new System.Drawing.Size(769, 400);
            this.panelListboxes.TabIndex = 5;
            // 
            // panelCrudCentros
            // 
            this.panelCrudCentros.Controls.Add(this.label3);
            this.panelCrudCentros.Controls.Add(this.tbCentro);
            this.panelCrudCentros.Controls.Add(this.label2);
            this.panelCrudCentros.Controls.Add(this.tbIdCentro);
            this.panelCrudCentros.Controls.Add(this.btnEliminar);
            this.panelCrudCentros.Controls.Add(this.btnModificar);
            this.panelCrudCentros.Controls.Add(this.btnInsertar);
            this.panelCrudCentros.Controls.Add(this.label1);
            this.panelCrudCentros.Controls.Add(this.dataGridCentros);
            this.panelCrudCentros.Location = new System.Drawing.Point(12, 39);
            this.panelCrudCentros.Name = "panelCrudCentros";
            this.panelCrudCentros.Size = new System.Drawing.Size(769, 400);
            this.panelCrudCentros.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(610, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "ACTUALIZAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(3, 358);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(156, 35);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "CENTROS";
            // 
            // dataGridCentros
            // 
            this.dataGridCentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCentros.Location = new System.Drawing.Point(0, 46);
            this.dataGridCentros.Name = "dataGridCentros";
            this.dataGridCentros.Size = new System.Drawing.Size(769, 264);
            this.dataGridCentros.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrosToolStripMenuItem,
            this.listboxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centrosToolStripMenuItem
            // 
            this.centrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERTARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem,
            this.mODIFICARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem});
            this.centrosToolStripMenuItem.Name = "centrosToolStripMenuItem";
            this.centrosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.centrosToolStripMenuItem.Text = "Centros";
            // 
            // iNSERTARToolStripMenuItem
            // 
            this.iNSERTARToolStripMenuItem.Name = "iNSERTARToolStripMenuItem";
            this.iNSERTARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNSERTARToolStripMenuItem.Text = "INSERTAR";
            this.iNSERTARToolStripMenuItem.Click += new System.EventHandler(this.iNSERTARToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // mODIFICARToolStripMenuItem
            // 
            this.mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            this.mODIFICARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            this.mODIFICARToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARToolStripMenuItem_Click);
            // 
            // listboxToolStripMenuItem
            // 
            this.listboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem});
            this.listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            this.listboxToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listboxToolStripMenuItem.Text = "Listbox";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pantallaToolStripMenuItem.Text = "Pantalla";
            this.pantallaToolStripMenuItem.Click += new System.EventHandler(this.pantallaToolStripMenuItem_Click);
            // 
            // tbIdCentro
            // 
            this.tbIdCentro.Location = new System.Drawing.Point(62, 321);
            this.tbIdCentro.Name = "tbIdCentro";
            this.tbIdCentro.Size = new System.Drawing.Size(277, 20);
            this.tbIdCentro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Centro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre centro";
            // 
            // tbCentro
            // 
            this.tbCentro.Location = new System.Drawing.Point(438, 321);
            this.tbCentro.Name = "tbCentro";
            this.tbCentro.Size = new System.Drawing.Size(324, 20);
            this.tbCentro.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCrudCentros);
            this.Controls.Add(this.panelListboxes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelListboxes.ResumeLayout(false);
            this.panelCrudCentros.ResumeLayout(false);
            this.panelCrudCentros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCentros)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnCargaDatos;
        private System.Windows.Forms.Panel panelListboxes;
        private System.Windows.Forms.Panel panelCrudCentros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCentros;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem pantallaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdCentro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCentro;
    }
}

