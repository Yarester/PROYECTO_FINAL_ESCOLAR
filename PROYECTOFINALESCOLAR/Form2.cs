/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//PASTELERIA
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(rdbDulce.Checked)
			{
			 rdbDulce.ForeColor=Color.MediumBlue;
			}
			else 
			{
			 rdbDulce.ForeColor=Color.White;
			}
		}
		
		void RdbSaladoCheckedChanged(object sender, EventArgs e)
		{
			if(rdbSalado.Checked)
			{
			 rdbSalado.ForeColor=Color.MediumBlue;
			}
			else 
			{
			 rdbSalado.ForeColor=Color.White;
			}
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			
		}
	}
}
