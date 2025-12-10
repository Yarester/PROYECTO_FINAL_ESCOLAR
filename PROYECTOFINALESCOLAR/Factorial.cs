/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 10/12/2025
 * Hora: 01:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Factorial.
	/// </summary>
	public partial class Factorial : Form
	{
		public Factorial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void BtnCalcularClick(object sender, EventArgs e)
		{
				try
			    {
			        int num = int.Parse(txtNum.Text);
			
			        if (num < 0)
			        {
			            lblResult.Text = "El factorial no existe para números negativos.";
			            return;
			        }
			
			        long factorial = 1;
			
			        for (int i = 1; i <= num; i++)
			        {
			            factorial *= i;
			        }
			
			        lblResult.Text = "Factorial: " + factorial.ToString();
			    }
			    catch
			    {
			        lblResult.Text = "Ingresa un número válido.";
			    }
			
				     }
     }
}