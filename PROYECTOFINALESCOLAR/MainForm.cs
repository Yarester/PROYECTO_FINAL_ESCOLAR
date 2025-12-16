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
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text;
		    string contra = txtPass.Text;
		
		    string usuarioCorrecto = "admina";
		    string contraCorrecta = "1234";
				    
				    if (usuario == usuarioCorrecto && contra == contraCorrecta)
		    {
		        MessageBox.Show("Bienvenido");
		
		        MenuPrincipal menu = new MenuPrincipal();
		        menu.Show();
		
		        this.Hide();
		    }
		    else
		    {
		        MessageBox.Show("Usuario o contraseña incorrectos");
		    }


		}
		
		void TxtPassTextChanged(object sender, EventArgs e)
		{
			txtPass.PasswordChar = '*';
		}
		
		void btnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
}
}
