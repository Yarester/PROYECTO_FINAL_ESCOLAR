/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:05 p. m.
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
	/// Description of Form2.
	/// </summary>
	public partial class frmPasteleria : Form
	{
		
		double Precio=0;
		
		public frmPasteleria()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//PASTELERIA
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
		
		void RdbDulceCheckedChanged(object sender, EventArgs e)
		{
			if(rdbDulce.Checked)
			{
			 rdbDulce.ForeColor=Color.MediumBlue;
			}
			else 
			{
			 rdbDulce.ForeColor=Color.White;
			}
		}
		
		void RdbSaladoCheckedChanged(object sender, EventArgs e)
		{
			if(rdbSalado.Checked)
			{
			 rdbSalado.ForeColor=Color.MediumBlue;
			}
			else 
			{
			 rdbSalado.ForeColor=Color.White;
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (cbProducto.SelectedIndex == -1)
		    {
		        MessageBox.Show("Debe seleccionar un producto");
		        return;
		    }
		
		    if (txtCantidad.Text == "")
		    {
		        MessageBox.Show("Debe ingresar una cantidad");
		        return;
		    }
		
		    string producto = cbProducto.Text;
		    int cantidad = Convert.ToInt32(txtCantidad.Text);
		    double subtotal = cantidad * Precio;
		
		    ListViewItem item = new ListViewItem(producto);
		    item.SubItems.Add(Precio.ToString("C"));
		    item.SubItems.Add(cantidad.ToString());
		    item.SubItems.Add(subtotal.ToString("C"));
		
		    listView1.Items.Add(item);
		
		    CalcularTotales();
	
		    cbProducto.SelectedIndex = -1;
		    txtPrecio.Clear();
		    txtCantidad.Clear();

		}
		
		void CalcularTotales()
		{
		    double subtotalGeneral = 0;
		
		    foreach (ListViewItem item in listView1.Items)
		    {
		        subtotalGeneral += double.Parse(
		            item.SubItems[3].Text.Replace("$", "")
		        );
		    }
		
		    txtSubtotal.Text = subtotalGeneral.ToString("C");
		
		    double descuento = 0;
		    if (txtDescuento.Text != "")
		        descuento = Convert.ToDouble(txtDescuento.Text);
		
		    double neto = subtotalGeneral - descuento;
		    txtNeto.Text = neto.ToString("C");
		
		    if (txtPagado.Text != "")
		    {
		        double pagado = Convert.ToDouble(txtPagado.Text);
		        double cambio = pagado - neto;
		        txtCambio.Text = cambio.ToString("C");
		    }
		}

		
		void CbProductoSelectedIndexChanged(object sender, EventArgs e)
		{
			string producto = cbProducto.Text;
		
		    if (producto == "PRODUCTO1") Precio = 78;
		    if (producto == "PRODUCTO2") Precio = 126;
		    if (producto == "PRODUCTO3") Precio = 180;
		    if (producto == "PRODUCTO4") Precio = 220;
		
		    txtPrecio.Text = Precio.ToString("C");

		}
		
		void FrmPasteleriaLoad(object sender, EventArgs e)
		{
			listView1.View = View.Details;
		    listView1.FullRowSelect = true;
		    listView1.GridLines = true;
		
		    listView1.Columns.Add("Producto", 120);
		    listView1.Columns.Add("Precio", 80);
		    listView1.Columns.Add("Cantidad", 80);
		    listView1.Columns.Add("Subtotal", 100);

		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();

		    txtSubtotal.Clear();
		    txtDescuento.Clear();
		    txtNeto.Clear();
		    txtPagado.Clear();
		    txtCambio.Clear();

		}
	}
}
