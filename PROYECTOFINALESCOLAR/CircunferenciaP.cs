/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 14/12/2025
 * Hora: 09:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of CircunferenciaP.
	/// </summary>
	public partial class CircunferenciaP : Form
	{
		public CircunferenciaP()
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
			double radio = Convert.ToDouble(txtRadio.Text);
			double perimetro = 2 * Math.PI * radio;
			txtP.Text = perimetro.ToString();

		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtP.Clear();
			txtRadio.Clear();
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
