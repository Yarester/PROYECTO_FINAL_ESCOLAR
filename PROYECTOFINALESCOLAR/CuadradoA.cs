/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 14/12/2025
 * Hora: 12:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of CuadradoA.
	/// </summary>
	public partial class CuadradoA : Form
	{
		public CuadradoA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double lado = Convert.ToDouble(txtLado.Text);
			double area = lado * lado;
			txtArea.Text = area.ToString();

		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtArea.Clear();
			txtLado.Clear();
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
