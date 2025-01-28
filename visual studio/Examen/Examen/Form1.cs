using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {

        string MI_CADENA_DE_CONEXION = Examen.Properties.Settings.Default.centros_departamentosConnectionString;

        // Objeto de conexión global.
        OleDbConnection miConexion;

        OleDbCommand miComando;

        OleDbDataAdapter miDataAdapter;

        DataSet miDataset;

        DataTable miTabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = true;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;

        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = true;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = true;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;
            string sentenciaSql = "SELECT * FROM Centros";

            cargaDataGridView(sentenciaSql, true, dataGridViewListarCentros);

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = true;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;
            string sentenciaSql = "SELECT * FROM Centros";

            cargaComboBox(sentenciaSql, comboBoxBorrarCentro);

        }

        private void inicioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = true;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;
        }

        private void añadirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = true;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = false;
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = true;
            panelEliminarEmpleado.Visible = false;
            string sentenciaSql = "SELECT Empleado FROM Empleados JOIN Departamentos";

            cargaDataGridView(sentenciaSql, true, dataGridView1);
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelCentroAdd.Visible = false;
            panelListarCentro.Visible = false;
            panelBorrarCentro.Visible = false;
            panelAddEmpleado.Visible = false;
            panelListarEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = true;
        }

        private void cargaDataGridView(string sentencia, Boolean modoLectura, DataGridView dataGrid)
        {

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

            }

        }

        private void cargaComboBox(string sentencia, ComboBox combobox)
        {

            using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
            {

                miConexion.Open();

                miComando = new OleDbCommand(sentencia, miConexion);

                miDataAdapter = new OleDbDataAdapter(miComando);

                miDataset = new DataSet();

                miDataAdapter.Fill(miDataset, "tablaTemp");

                miTabla = miDataset.Tables["tablaTemp"];

                combobox.DataSource = miTabla;

            }
        }

        private void cargaListBox(string sentencia, ListBox listbox)
        {

            using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
            {

                miConexion.Open();

                miComando = new OleDbCommand(sentencia, miConexion);

                miDataAdapter = new OleDbDataAdapter(miComando);

                miDataset = new DataSet();

                miDataAdapter.Fill(miDataset, "tablaTemp");

                miTabla = miDataset.Tables["tablaTemp"];

                listbox.DataSource = miTabla;

            }
        }

        private void buttonCentrosAdd_Click(object sender, EventArgs e)
        {

            try
            {

                string sentencia = "INSERT INTO Centros ( Centro ) VALUES ( ? ) WHERE Centro !=(SELECT Centro FROM Centros)";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();

                    string centroNombre = textBoxCentrosAdd.Text.ToString();

                    miComando = new OleDbCommand(sentencia, miConexion);

                    miComando.Parameters.AddWithValue("?", centroNombre);

                    miComando.ExecuteNonQuery();

                    MessageBox.Show("el centro se ha introducido correctamente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miComando.Dispose();
                    miConexion.Close();

                    textBoxCentrosAdd.Clear();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.centros_departamentosDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            this.departamentosTableAdapter.Fill(this.centros_departamentosDataSet.Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Centros' Puede moverla o quitarla según sea necesario.
            this.centrosTableAdapter.Fill(this.centros_departamentosDataSet.Centros);

        }

        private void buttonBorrarCentro_Click(object sender, EventArgs e)
        {
            try
            {

                string sentencia = "DELETE FROM Centros WHERE Id_Centro = ?";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();

                    miComando = new OleDbCommand(sentencia, miConexion);

                    miComando.Parameters.AddWithValue("?", Convert.ToInt32(comboBoxBorrarCentro.SelectedValue));

                    miComando.ExecuteNonQuery();

                    MessageBox.Show("el centro se ha borrado correctamente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miComando.Dispose();
                    miConexion.Close();

                    cargaComboBox("SELECT * FROM Centros",comboBoxBorrarCentro);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void listBoxAddEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            string valorSeleccionado = null;

            DataRowView drvSeleccionado = listBoxAddEmpleado.SelectedItem as DataRowView;

            if (drvSeleccionado != null)
            {
                valorSeleccionado = Convert.ToString(drvSeleccionado["Id_Centro"]);
            }

            try
            {

                String sentenciaSQL = "SELECT Id_Departamento, Id_centro, Departamento FROM Departamentos WHERE Id_centro = ?";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {
                    miConexion.Open();

                    miComando = new OleDbCommand(sentenciaSQL, miConexion);

                    miComando.Parameters.AddWithValue("?", valorSeleccionado);

                    miDataAdapter = new OleDbDataAdapter(miComando);

                    miDataset = new DataSet();

                    miDataAdapter.Fill(miDataset, "tabla");

                    miTabla = miDataset.Tables["tabla"];

                    comboBoxAddEmpleado.DataSource = miTabla;
                    comboBoxAddEmpleado.DisplayMember = "Departamento";
                    comboBoxAddEmpleado.ValueMember = "Id_departamento";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddEmpleado_Click(object sender, EventArgs e)
        {
            try
            {

                string sentencia = "INSERT INTO Empleados ( Id_Departamento, Empleado ) VALUES ( ?, ? )";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();

                    string Empleado = textBoxAddEmpleado.Text.ToString();

                    miComando = new OleDbCommand(sentencia, miConexion);

                    miComando.Parameters.AddWithValue("?", comboBoxAddEmpleado.SelectedValue);

                    miComando.Parameters.AddWithValue("?", Empleado);

                    miComando.ExecuteNonQuery();

                    MessageBox.Show("el centro se ha introducido correctamente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miComando.Dispose();
                    miConexion.Close();

                    textBoxCentrosAdd.Clear();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {

                string sentencia = "DELETE FROM Empleados WHERE Id_Empleado = ?";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();

                    miComando = new OleDbCommand(sentencia, miConexion);

                    miComando.Parameters.AddWithValue("?", Convert.ToInt32(comboBoxEliminarEmpleado.SelectedValue));

                    miComando.ExecuteNonQuery();

                    MessageBox.Show("el empleado se ha borrado correctamente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miComando.Dispose();
                    miConexion.Close();

                    comboBoxEliminarEmpleadoCentro.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxEliminarEmpleadoCentro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string valorSeleccionado = null;

            DataRowView drvSeleccionado = comboBoxEliminarEmpleadoCentro.SelectedItem as DataRowView;

            if (drvSeleccionado != null)
            {
                valorSeleccionado = Convert.ToString(drvSeleccionado["Id_Centro"]);
            }

            try
            {

                String sentenciaSQL = "SELECT Id_Departamento, Id_centro, Departamento FROM Departamentos WHERE Id_centro = ?";

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {
                    miConexion.Open();

                    miComando = new OleDbCommand(sentenciaSQL, miConexion);

                    miComando.Parameters.AddWithValue("?", valorSeleccionado);

                    miDataAdapter = new OleDbDataAdapter(miComando);

                    miDataset = new DataSet();

                    miDataAdapter.Fill(miDataset, "tabla");

                    miTabla = miDataset.Tables["tabla"];

                    comboBoxEliminarEmpleadoDepartamento.DataSource = miTabla;
                    comboBoxEliminarEmpleadoDepartamento.DisplayMember = "Departamento";
                    comboBoxEliminarEmpleadoDepartamento.ValueMember = "Id_departamento";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEliminarEmpleadoDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                string sentenciaSql = "SELECT Id_Empleado, Empleado FROM Empleados WHERE Id_Departamento = ? ";

                string valorSeleccionado = null;
                DataRowView filaDatos = comboBoxEliminarEmpleadoDepartamento.SelectedItem as DataRowView;

                if (filaDatos != null)
                {

                    valorSeleccionado = Convert.ToString(filaDatos["Id_Departamento"]);
                    Debug.WriteLine("Valor seleccionado: " + valorSeleccionado);
                }

                using (miConexion = new OleDbConnection(MI_CADENA_DE_CONEXION))
                {

                    miConexion.Open();
                    Debug.WriteLine("Conexion abierta.");

                    miComando = new OleDbCommand(sentenciaSql, miConexion);

                    miComando.Parameters.AddWithValue("?", valorSeleccionado);
                    Debug.WriteLine("Comando creado y parametrizado.");

                    miDataAdapter = new OleDbDataAdapter(miComando);
                    Debug.WriteLine("Adapter creado.");

                    miDataset = new DataSet();

                    miDataAdapter.Fill(miDataset, "Empleados");

                    miTabla = miDataset.Tables["Empleados"];
                    Debug.WriteLine("Tabla recuperada.");

                    comboBoxEliminarEmpleado.DataSource = miTabla;
                    comboBoxEliminarEmpleado.ValueMember = "Id_Empleado";
                    comboBoxEliminarEmpleado.DisplayMember = "Empleado";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN CARGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
