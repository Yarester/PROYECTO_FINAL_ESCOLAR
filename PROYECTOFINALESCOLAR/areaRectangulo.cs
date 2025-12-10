/*
 * Created by SharpDevelop.
 * User: CC1_PC16
 * Date: 10/12/2025
 * Time: 01:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of areaRectangulo.
	/// </summary>
	public partial class areaRectangulo : Form
	{
		public areaRectangulo()
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
			double b = double.Parse(txtBase.Text);
			double h = double.Parse(txtAltura.Text);
			double area=b*h;
			lblResul.Text= "Área = " + area; 
		}
	}
}
