using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace practicaPreExamen
{
    public partial class Form1 : Form
    {
        // ----- BLOQUE DE VARIABLES Y CONSTANTES GLOBALES. -----

        // Cadena de conexión.
        string MI_CADENA_DE_CONEXION = practicaPreExamen.Properties.Settings.Default.centros_departamentosConnectionString;
        
        // Objeto de conexión global.
        OleDbConnection miConexion;

        string sentenciaSQL;

        OleDbCommand miComando;

        OleDbDataAdapter miDataAdapter;

        DataSet miDataset;

        DataTable miTabla;

        // ----- FIN DE BLOQUE DE VARIABLES Y CONSTANTES GLOBALES. -----

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Bloque de using connetion.
                using ( miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION) ) { 

                    // Abrimos la conexión.
                    miConexion.Open();

                    // Recupera identificador y nomrbe de los centros de la tabla Centros.
                    sentenciaSQL = "SELECT Id_centro, Centro FROM Centros";

                    // Crea el comando a partir de la sentencia y conexión.
                    miComando = new OleDbCommand(sentenciaSQL, miConexion);

                    // A partir del comando creamos la conexión.
                    miDataAdapter = new OleDbDataAdapter( miComando );

                    miDataset = new DataSet();

                    miDataAdapter.Fill(miDataset, "Centros" );

                    miTabla = miDataset.Tables["Centros"];

                    listBox1.DataSource = miTabla;
                    listBox1.DisplayMember = "Centro";
                    listBox1.ValueMember = "Id_centro";

                    // jeSUSANtidad
                    // je - SUSAN - tidad



                }

            }
            catch (Exception ex) {

                MessageBox.Show( ex.Message,"Error Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }


        }

        // Funcion del listbox1  que, segun el valor seleccionado, poblará la listbox 2.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // --------- RECUPERAMOS EL VALOR. ---------

            string valorSeleccionado = null;

            // Recuperamos la fila seleccionada.
            DataRowView drvSeleccionado = listBox1.SelectedItem as DataRowView;

            // Recuperamos el valor de la fila seleccionada.
            if ( drvSeleccionado != null ) {
                // Recuperamos el valor en forma de string.
                valorSeleccionado = Convert.ToString(drvSeleccionado["Id_Centro"]);
            }

            // --------- POBLAMOS LISTBOX 2 CON EL VALOR. ---------
            try
            {

                sentenciaSQL = "SELECT Id_Departamento, Id_centro, Departamento FROM Departamentos WHERE Id_centro = ?";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {
                    miConexion.Open();

                    miComando = new OleDbCommand(sentenciaSQL, miConexion);

                    miComando.Parameters.AddWithValue("?", valorSeleccionado);

                    miDataAdapter = new OleDbDataAdapter(miComando);

                    miDataset = new DataSet();

                    miDataAdapter.Fill(miDataset, "tabla");

                    miTabla = miDataset.Tables["tabla"];

                    listBox2.DataSource = miTabla;
                    listBox2.DisplayMember = "Departamento";
                    listBox2.ValueMember = "Id_departamento";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sentenciaSql = "SELECT Id_Empleado, Empleado FROM Empleados WHERE Id_Departamento = ? ";

                string valorSeleccionado = null;
                DataRowView filaDatos = listBox2.SelectedItem as DataRowView;

                if (filaDatos != null) {

                    valorSeleccionado = Convert.ToString(filaDatos["Id_Departamento"] );
                    Debug.WriteLine("Valor seleccionado: " + valorSeleccionado);
                }

                using (miConexion = new OleDbConnection( MI_CADENA_DE_CONEXION ) ) {

                    miConexion.Open();
                    Debug.WriteLine("Conexion abierta.");

                    miComando= new OleDbCommand( sentenciaSql, miConexion);

                    miComando.Parameters.AddWithValue("?", valorSeleccionado);
                    Debug.WriteLine("Comando creado y parametrizado.");

                    miDataAdapter = new OleDbDataAdapter( miComando );
                    Debug.WriteLine("Adapter creado.");

                    miDataset = new DataSet();

                    miDataAdapter.Fill( miDataset, "Empleados");

                    miTabla = miDataset.Tables["Empleados"];
                    Debug.WriteLine("Tabla recuperada.");

                    listBox3.DataSource = miTabla;
                    listBox3.ValueMember = "Id_Empleado";
                    listBox3.DisplayMember = "Empleado";

                    Debug.WriteLine("Listbox3 poblado.");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnInsertar.Enabled = false;
            tbCentro.Enabled = false;
            tbIdCentro.Enabled = false;

            string sentenciaSql = "SELECT * FROM Centros";

            // Carga datos en modo solo letura para el datagridcentros.
            cargaDataGrid( sentenciaSql, true, dataGridCentros );

        }

        private void cargaDataGrid( string sentencia, Boolean modoLectura, DataGridView dataGrid ) {

            using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
            {

                miConexion.Open();

                miComando = new OleDbCommand(sentencia, miConexion);

                miDataAdapter = new OleDbDataAdapter(miComando);

                miDataset = new DataSet();

                miDataAdapter.Fill(miDataset, "tablaTemp");

                miTabla = miDataset.Tables["tablaTemp"];

                dataGrid.DataSource = miTabla;

                dataGrid.ReadOnly = modoLectura;

                dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }

        private void iNSERTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnInsertar.Enabled = true;
            tbCentro.Enabled = true;
            tbIdCentro.Enabled = true;

            string sentenciaSql = "SELECT Id_centro, Centro FROM Centros";

            // Carga datos en modo solo letura para el datagridcentros.
            cargaDataGrid(sentenciaSql, false, dataGridCentros);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Si la cantidad de filas seleccionadas es mayor a 0.
            //dataGridCentros.SelectedRows.Count > 0
            if ( true ) {

                try
                {

                    string sentencia = "INSERT INTO Centros ( Id_Centro, Centro ) VALUES ( ?, ? )";

                    using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION)) {

                        miConexion.Open();

                        //string centroNombre = dataGridCentros.SelectedRows[0].Cells["Centro"].Value.ToString();
                        //Int32 idCentro = Convert.ToInt32(dataGridCentros.SelectedRows[0].Cells["Id_Centro"].Value);

                        string centroNombre = tbCentro.Text.ToString();
                        Int32 idCentro = Convert.ToInt32(tbIdCentro.Text);

                        miComando = new OleDbCommand(sentencia, miConexion);

                        miComando.Parameters.AddWithValue("?", idCentro);
                        
                        miComando.Parameters.AddWithValue("?", centroNombre);

                        miComando.ExecuteNonQuery();

                        miComando.Dispose();
                        miConexion.Close();

                        tbIdCentro.Clear();
                        tbCentro.Clear();

                        cargaDataGrid("SELECT Id_centro, Centro FROM Centros", false, dataGridCentros);

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show( ex.Message, "Errorsito", MessageBoxButtons.OK, MessageBoxIcon.Error );

                }

            }
        }

        /** Para ver los combobox y listbox */
        private void pantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListboxes.Visible = true;
            panelCrudCentros.Visible = false;
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargaDataGrid("SELECT Id_centro, Centro FROM Centros", false, dataGridCentros);
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = false;
            btnModificar.Enabled = true;
            tbCentro.Enabled = false;
            tbIdCentro.Enabled = false;
            dataGridCentros.AllowUserToAddRows = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();

                    string sentenciaSql = "UPDATE Centros SET Centro = ? WHERE Id_Centro = ?";

                    miComando = new OleDbCommand(sentenciaSql, miConexion);

                    Int32 idCentro = Convert.ToInt32(dataGridCentros.SelectedRows[0].Cells["Id_Centro"].Value);
                    string nombreCentro = dataGridCentros.SelectedRows[0].Cells["Centro"].Value.ToString();

                    using (miComando)
                    {
                        miComando.Parameters.AddWithValue("?", nombreCentro);

                        miComando.Parameters.AddWithValue("?", idCentro);

                        miComando.ExecuteNonQuery();
                    }

                    // Muestra mensaje de éxito
                    MessageBox.Show("La fila se actualizó correctamente.");

                    // Recarga el DataGridView
                    cargaDataGrid("SELECT Id_centro, Centro FROM Centros", false, dataGridCentros);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Controla si no hay filas seleccionadas.
            if (dataGridCentros.SelectedRows.Count > 0)
            {
                // Muestra un diálogo que solicita confirmación al usuario.
                if (MessageBox.Show("¿Está seguro que quiere borrar esta fila?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // Crear el objeto OleDbConnection con la cadena de conexión
                        using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                        {
                            // Abre la conexión
                            miConexion.Open();

                            // Recoge un campo identificativo para la operación
                            int filaSeleccionada = Convert.ToInt32(dataGridCentros.SelectedRows[0].Cells["Id_Centro"].Value);

                            // Define la sentencia SQL para eliminar el registro
                            string sentenciaSQL = "DELETE FROM Centros WHERE Id_Centro = ?";

                            // Genera el comando de borrado.
                            miComando = new OleDbCommand(sentenciaSQL, miConexion);
                            
                            // Parametriza el comando.
                            miComando.Parameters.AddWithValue("?", filaSeleccionada);

                            // Ejecuta la instrucción DELETE.
                            miComando.ExecuteNonQuery();
                            
                            miComando.Dispose();

                            // Muestra mensaje de éxito
                            MessageBox.Show("La fila se eliminó correctamente.");

                            // Recarga el DataGridView
                            cargaDataGrid("SELECT Id_centro, Centro FROM Centros", false, dataGridCentros);

                        }
                    }
                    catch (Exception ex)
                    {
                        // Muestra el error en un mensaje
                        MessageBox.Show($"Error al eliminar los datos: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargaDataGrid("SELECT Id_centro, Centro FROM Centros", false, dataGridCentros);
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = false; 
            btnModificar.Enabled = false; 
            tbCentro.Enabled = false;
            tbIdCentro.Enabled = false;
        }
    }
}
