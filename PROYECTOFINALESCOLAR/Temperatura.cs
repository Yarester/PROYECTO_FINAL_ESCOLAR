/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 14/12/2025
 * Hora: 03:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Temperatura.
	/// </summary>
	public partial class Temperatura : Form
	{
		public Temperatura()
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
			double Celcious;
			double Fahren;
			Celcious = double.Parse(txtC.Text);
			Fahren = (Celcious * 1.8) + 32;
			
			txtF.Text = Fahren.ToString();
		}
	}
}
