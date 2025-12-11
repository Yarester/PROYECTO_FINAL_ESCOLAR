/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Application.Run(new frmPasteleria());
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
		string usuario = txtUsuario.Text;
		string contraseña = txtContra.Text;
		
		string Usau = "admin";
		string Ucon = "123";
		
		if(usuario == Usau && contraseña == Ucon)
		{
		
		//	Menu ventanaMenu = new Menu();
		//	ventanaMenu.Show();
			this.Hide();
		}
		else
		{
			MessageBox.Show("Datos incorrectos. Intenta de nuevo.");
		}
		
	}
}
}
