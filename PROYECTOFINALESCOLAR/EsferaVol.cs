/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 05:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of EsferaVol.
	/// </summary>
	public partial class EsferaVol : Form
	{
		public EsferaVol()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtRadio.Clear();
			txtVol.Clear();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			
		    double radio, volumen;
		
		    if(double.TryParse(txtRadio.Text, out radio))
		    {
		        volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
		
		        txtVol.Text = volumen.ToString();
		    }
		    else
		    {
		        MessageBox.Show("Ingresa un número válido para el radio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		    }

		}
	}
}
