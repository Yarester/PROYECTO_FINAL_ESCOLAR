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

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class frmPasteleria : Form
	{
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
		double Precio=0;
		
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
			if(cbProducto.SelectedIndex == -1)
			MessageBox.Show("Debe Seleccionar un producto....! !");
			else if(txtCantidad.Text == "")
			MessageBox.Show("Debe Ingresar una cantidad....! !");
			else
			{

			// ESTO ESTA PENDIENTE NO LO SUPE SOLUCIONAR :,(...
			string producto = cbProducto.Text;
			int cantidad = Convert.ToInt32(txtCantidad.Text);
			
			double subtotal = cantidad * Precio;
			double descuento = 0;
			if(txtDescuento.Text == "")
			descuento = 1 * subtotal;
			else
			descuento = 0.05 * subtotal;
			
			double PrecioNeto = subtotal - descuento;
			double Pagado;
			Pagado = double.Parse(txtPagado.Text);
			double Cambio = PrecioNeto - Pagado;
			
			txtNeto.Text =PrecioNeto.ToString();
			txtPagado.Text =Pagado.ToString();
			txtCambio.Text =Cambio.ToString();
			
			}
		}
		
		void CbProductoSelectedIndexChanged(object sender, EventArgs e)
		{
			string producto = cbProducto.Text;
				if (producto.Equals("PRODUCTO1"))Precio=78;
				if (producto.Equals("PRODUCTO2"))Precio=126;
				if (producto.Equals("PRODUCTO3"))Precio=180;
				if (producto.Equals("PRODUCTO4"))Precio=220;
				
				txtPrecio.Text=Precio.ToString("C");
		}
	}
}
