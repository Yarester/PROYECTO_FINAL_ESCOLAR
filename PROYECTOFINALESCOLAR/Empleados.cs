/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 15/12/2025
 * Hora: 03:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Empleados.
	/// </summary>
	public partial class Empleados : Form
	{
		public Empleados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public bool AgregarProducto(int clave, string nombre, decimal precio)
        {
            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=sistema_tienda; user=root; pwd=root;";
            cn.Open();
            /// AGREGAR EL REGISTRO A LA BASE DE DATOS
            string strSQL = "insert into productos (clave, nombre, precio)" +
                "values (@Clave, @Nombre, @precio)";
            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("Clave", clave);
            comando.Parameters.AddWithValue("Nombre", nombre);
            comando.Parameters.AddWithValue("Precio", precio);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto agregado");
            
            comando.Dispose();
            cn.Close();
            cn.Dispose();
            return true;
        }
		
		void EmpleadosLoad(object sender, EventArgs e)
		{
			cmbPuesto.Items.Add("Cajero");
            cmbPuesto.Items.Add("Repostero");
            cmbPuesto.Items.Add("Vendedor");
            cmbPuesto.Items.Add("Administrador");
            cmbSexto.Items.Add("Femenino");
            cmbSexto.Items.Add("Masculino");

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Puesto";
            dataGridView1.Columns[3].Name = "Fecha Nacimiento";
            dataGridView1.Columns[4].Name = "Sexo";
            dataGridView1.Columns[5].Name = "Estado";
            dataGridView1.Columns[6].Name = "Foto";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if (txtCodigo.Text == "" || txtNombre.Text == "" ||
		        cmbPuesto.SelectedIndex == -1 ||
		        txtCumple.Text == "" ||
		        cmbSexto.SelectedIndex == -1 ||
		        (!rdbRegular.Checked && !rdbContrato.Checked))
		    {
		        MessageBox.Show("Completa todos los campos");
		        return;
		    }
		
		    string estado = rdbRegular.Checked ? "Regular" : "Contrato";
		
		    dataGridView1.Rows.Add(
		        txtCodigo.Text,
		        txtNombre.Text,
		        cmbPuesto.Text,
		        txtCumple.Text,
		        cmbSexto.Text,
		        estado,
		        "Foto"
		    );
		
		    LimpiarCampos();
		
				}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			    if (dataGridView1.SelectedRows.Count == 0)
			    {
			        MessageBox.Show("Selecciona un empleado");
			        return;
			    }
			
			    DataGridViewRow fila = dataGridView1.SelectedRows[0];
			    string estado = rdbRegular.Checked ? "Regular" : "Contrato";
			
			    fila.Cells[0].Value = txtCodigo.Text;
			    fila.Cells[1].Value = txtNombre.Text;
			    fila.Cells[2].Value = cmbPuesto.Text;
			    fila.Cells[3].Value = txtCumple.Text;
			    fila.Cells[4].Value = cmbSexto.Text;
			    fila.Cells[5].Value = estado;

		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			    if (dataGridView1.SelectedRows.Count > 0)
		    {
		        dataGridView1.Rows.RemoveAt(
		            dataGridView1.SelectedRows[0].Index
		        );
		        LimpiarCampos();
		    }

		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			LimpiarCampos();

		}
		
		void LimpiarCampos()
		{
		    txtCodigo.Clear();
		    txtNombre.Clear();
		    txtCumple.Clear();
		    cmbPuesto.SelectedIndex = -1;
		    cmbSexto.SelectedIndex = -1;
		    rdbRegular.Checked = false;
		    rdbContrato.Checked = false;
		    txtCodigo.Focus();
		}

		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
		    {
		        DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
		
		        txtCodigo.Text = fila.Cells[0].Value.ToString();
		        txtNombre.Text = fila.Cells[1].Value.ToString();
		        cmbPuesto.Text = fila.Cells[2].Value.ToString();
		        txtCumple.Text = fila.Cells[3].Value.ToString();
		        cmbSexto.Text = fila.Cells[4].Value.ToString();
		
		        if (fila.Cells[5].Value.ToString() == "Regular")
		            rdbRegular.Checked = true;
		        else
		            rdbContrato.Checked = true;
		    }

		}
	}
}
