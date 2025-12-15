/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 15/12/2025
 * Hora: 02:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Segundahora.
	/// </summary>
	public partial class Segundahora : Form
	{
		public Segundahora()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			double Seg;
			double Hora;
			Seg = double.Parse(txtSeg.Text);
			Hora = Seg / 3600;
			
			txtHoras.Text = Hora.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
