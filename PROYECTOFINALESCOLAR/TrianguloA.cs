/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 14/12/2025
 * Hora: 12:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of TrianguloA.
	/// </summary>
	public partial class TrianguloA : Form
	{
		public TrianguloA()
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
			double baseT = Convert.ToDouble(txtBase.Text);
			double altura = Convert.ToDouble(txtAltura.Text);
			double area = (baseT * altura) / 2;
			txtArea.Text = area.ToString();

		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtArea.Clear();
			txtAltura.Clear();
			txtBase.Clear();
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
