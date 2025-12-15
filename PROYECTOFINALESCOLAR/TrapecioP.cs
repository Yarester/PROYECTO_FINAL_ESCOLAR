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
	/// Description of TrapecioP.
	/// </summary>
	public partial class TrapecioP : Form
	{
		public TrapecioP()
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
			double l1 = Convert.ToDouble(txtLado1.Text);
			double l2 = Convert.ToDouble(txtLado2.Text);
			double l3 = Convert.ToDouble(txtLado3.Text);
			double l4 = Convert.ToDouble(txtLado4.Text);
			
			double perimetro = l1 + l2 + l3 + l4;
			txtP.Text = perimetro.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtLado1.Clear();
			txtLado2.Clear();
			txtLado3.Clear();
			txtLado4.Clear();
			txtP.Clear();
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
