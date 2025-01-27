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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            cargarCentrosCombobox3();
            cargarDepartamentosCombobox4();
            cargarCentros();
            cargarDepartamentos();
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Centros' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'centros_departamentosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            cargarEmpleados();

        }

        private void cargarDepartamentosCombobox4()
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\centros_departamentos.accdb";
            sql = "select Id_Departamento, Departamento from Departamentos WHERE Id_Centro = " + Int32.Parse(comboBox3.SelectedValue.ToString());
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBox4.DataSource = ds.Tables[0];
                comboBox4.ValueMember = "Id_Departamento";
                comboBox4.DisplayMember = "Departamento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void cargarCentrosCombobox3()
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\centros_departamentos.accdb";
            sql = "select Id_Centro, Centro from Centros";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBox3.DataSource = ds.Tables[0];
                comboBox3.ValueMember = "Id_Centro";
                comboBox3.DisplayMember = "Centro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
    }

        private void cargarDepartamentos()
        {
            //this.departamentosTableAdapter.Fill(this.centros_departamentosDataSet.Departamentos);
            //if (comboBox1.SelectedValue.ToString() != null)
            this.departamentosTableAdapter.FillByIdCentro(this.centros_departamentosDataSet.Departamentos,Int32.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void cargarCentros()
        {
            this.centrosTableAdapter.Fill(this.centros_departamentosDataSet.Centros);
        }

        private void cargarEmpleados()
        {
            //this.empleadosTableAdapter.Fill(this.centros_departamentosDataSet.Empleados);
            //if (comboBox2.SelectedValue.ToString() != null)
            this.empleadosTableAdapter.FillBy(this.centros_departamentosDataSet.Empleados,comboBox2.SelectedValue.ToString());
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.FillBy(this.centros_departamentosDataSet.Empleados, id_DepartamentoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarEmpleados();
        }

        private void fillByIdCentroToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departamentosTableAdapter.FillByIdCentro(this.centros_departamentosDataSet.Departamentos, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_CentroToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarDepartamentos();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDepartamentosCombobox4();
        }
    }
}
