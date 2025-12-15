/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 13/12/2025
 * Hora: 04:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of CuboVol.
	/// </summary>
	public partial class CuboVol : Form
	{
		public CuboVol()
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
					double lado, volumen;
		
		    lado = Convert.ToDouble(txtLado.Text);
		
		    volumen = Math.Pow(lado, 3);
		
		    txtResultado.Text = volumen.ToString("0.00");

		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtLado.Clear();
			txtResultado.Clear();

			txtResultado.Clear();
			txtLado.Clear();
		}
	}
}
