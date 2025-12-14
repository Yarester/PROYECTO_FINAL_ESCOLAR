/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 14/12/2025
 * Hora: 02:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of kiloLibra.
	/// </summary>
	public partial class kiloLibra : Form
	{
		public kiloLibra()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			double Kilogramo;
			double Libra;
			Kilogramo = double.Parse(txtKilogramos.Text);
			Libra = Kilogramo * 2.20462;
			
			txtLibras.Text = Libra.ToString();
		}
	}
}
