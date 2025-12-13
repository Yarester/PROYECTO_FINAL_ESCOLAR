/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 05:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of PiramideVol.
	/// </summary>
	public partial class PiramideVol : Form
	{
		public PiramideVol()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			txtH.Clear();
			txtLado.Clear();
			txtVol.Clear();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
					double lado, altura, volumen;
		
		    lado = Convert.ToDouble(txtLado.Text);
		    altura = Convert.ToDouble(txtH.Text);
		
		    volumen = (lado * lado * altura) / 3;
		
		    txtVol.Text = "Volumen = " + volumen.ToString("0.00");
		}
	}
}
