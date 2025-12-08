/*
 * Created by SharpDevelop.
 * User: CC1_PC16
 * Date: 08/12/2025
 * Time: 02:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejemplo
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
		
		void TxtUsuarioEnter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="Usuario")
            {
            txtUsuario.Text="";
            txtUsuario.ForeColor=Color.LightGray;
            }
        }
		void TxtUsuarioLeave(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="")
            {
            txtUsuario.Text="Usuario";
            txtUsuario.ForeColor=Color.DimGray;
            }
        }
		void TxtPassLeave(object sender, EventArgs e)
        {
            if(txtPass.Text==&quot;&quot;)
            {
            txtPass.Text=&quot;Contraseña&quot;;
            txtPass.ForeColor=Color.DimGray;
            txtPass.UseSystemPasswordChar=false;
            }
        }
	}
	
	
}
