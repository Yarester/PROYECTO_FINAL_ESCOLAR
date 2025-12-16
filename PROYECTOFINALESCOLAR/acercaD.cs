/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 15/12/2025
 * Hora: 03:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of acercaD.
	/// </summary>
	public partial class acercaD : Form
	{
		public acercaD()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AcercaDLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MenuPrincipal menu = new MenuPrincipal();
			menu.Show();
			this.Hide();
		}
	}
}
