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
	/// Description of RectanguloA.
	/// </summary>
	public partial class RectanguloA : Form
	{
		public RectanguloA()
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
			double baseR = Convert.ToDouble(txtBase.Text);
			double altura = Convert.ToDouble(txtAltura.Text);
			double area = baseR * altura;
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
