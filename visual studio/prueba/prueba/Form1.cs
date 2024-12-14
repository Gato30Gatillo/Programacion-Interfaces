using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.practicaDataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Evaluaciones' Puede moverla o quitarla según sea necesario.
            this.evaluacionesTableAdapter.Fill(this.practicaDataSet.Evaluaciones);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.practicaDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.practicaDataSet.Alumnos);

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = true;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = true;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = true;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = true;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = true;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = true;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = true;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = false;
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = true;
            panelNotas.Visible = false;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAlumnoAlta.Visible = false;
            panelAlumnoModificar.Visible = false;
            panelAlumnoListar.Visible = false;
            panelAlumnosEliminar.Visible = false;
            panelEvaluacionesAlta.Visible = false;
            panelEvaluacionesListar.Visible = false;
            panelEvaluacionesModificar.Visible = false;
            panelEvaluacionesEliminar.Visible = false;
            panelNotas.Visible = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            alumnosTableAdapter.InsertAlumno(textBoxNombre.Text,textBoxApellido.Text,textBoxNif.Text,checkBoxBaja.Checked);
            practicaDataSet.AcceptChanges();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxNif.Clear();
            checkBoxBaja.Checked = false;
            dataGridViewListarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewModificarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewEliminarAlumno.DataSource = alumnosTableAdapter.GetData();
            listBoxAlumnos.DataSource = alumnosTableAdapter.GetData();
        }

        private void buttonGuardarModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewModificarAlumno.Rows)
            {
                int originalId = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value); 
                string nombre = row.Cells["nombreDataGridViewTextBoxColumn1"].Value.ToString();
                string apellidos = row.Cells["apellidosDataGridViewTextBoxColumn1"].Value.ToString();
                string nif = row.Cells["nIFDataGridViewTextBoxColumn1"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["bajaDataGridViewCheckBoxColumn1"].Value);
                alumnosTableAdapter.UpdateAlumno(nombre, apellidos, nif, baja, originalId);
                listBoxAlumnos.DataSource = alumnosTableAdapter.GetData();
            }
            practicaDataSet.AcceptChanges();
            dataGridViewListarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewModificarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewEliminarAlumno.DataSource = alumnosTableAdapter.GetData();
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEliminarAlumno.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                string nombre = row.Cells["nombreDataGridViewTextBoxColumn1"].Value.ToString();
                string apellidos = row.Cells["apellidosDataGridViewTextBoxColumn1"].Value.ToString();
                string nif = row.Cells["nIFDataGridViewTextBoxColumn1"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["bajaDataGridViewCheckBoxColumn1"].Value);
                alumnosTableAdapter.DeleteAlumnos(id,nombre, apellidos, nif, baja);
            }
            practicaDataSet.AcceptChanges();
            dataGridViewListarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewModificarAlumno.DataSource = alumnosTableAdapter.GetData();
            dataGridViewEliminarAlumno.DataSource = alumnosTableAdapter.GetData();
            listBoxAlumnos.DataSource = alumnosTableAdapter.GetData();
        }

        private void buttonAltaEvaluaciones_Click(object sender, EventArgs e)
        {
            evaluacionesTableAdapter.InsertEvaluacion(textBoxDescripcion.Text);
            textBoxDescripcion.Clear();
            practicaDataSet.AcceptChanges();
            dataGridViewListarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEliminarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxModificarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEvaluacionesId.DataSource = evaluacionesTableAdapter.GetData();
        }

        private void buttonModificarEvaluaciones_Click(object sender, EventArgs e)
        {
            evaluacionesTableAdapter.UpdateEvaluaciones(textBoxModificarEvaluaciones.Text, Convert.ToInt32(comboBoxModificarEvaluaciones.SelectedValue));
            textBoxModificarEvaluaciones.Clear();
            practicaDataSet.AcceptChanges();
            dataGridViewListarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEliminarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxModificarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEvaluacionesId.DataSource = evaluacionesTableAdapter.GetData();
        }

        private void buttonEliminarEvaluaciones_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxEliminarEvaluaciones.SelectedValue);
            evaluacionesTableAdapter.DeleteEvaluaciones(id);
            practicaDataSet.AcceptChanges();
            dataGridViewListarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEliminarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxModificarEvaluaciones.DataSource = evaluacionesTableAdapter.GetData();
            comboBoxEvaluacionesId.DataSource = evaluacionesTableAdapter.GetData();
        }

        private void comboBoxModificarEvaluaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxModificarEvaluaciones.Text = comboBoxModificarEvaluaciones.Text.ToString();
        }
    }
}
