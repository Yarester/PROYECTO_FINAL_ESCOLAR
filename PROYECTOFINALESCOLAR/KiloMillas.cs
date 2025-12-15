/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 14/12/2025
 * Hora: 01:52 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of KiloMillas.
	/// </summary>
	public partial class KiloMillas : Form
	{
		public KiloMillas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			double Kilometro;
			double Millas;
			Kilometro = double.Parse(txtKilometro.Text);
			Millas = Kilometro * 0.621371;
			
			txtMilla.Text = Millas.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
