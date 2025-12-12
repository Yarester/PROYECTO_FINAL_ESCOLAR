/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 11:01 a. m.
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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
					try
		    {
		        int numero = int.Parse(txtNum.Text);
		
		        if (numero < 0)
		        {
		           txtResultado.Text = "El factorial no existe para números negativos.";
		            return;
		        }
		
		        long factorial = 1;
		
		        for (int i = 1; i <= numero; i++)
		        {
		            factorial *= i;
		        }
		
		        txtResultado.Text = factorial.ToString();
		    }
		    catch
		    {
		        txtResultado.Text = "Ingresa un número válido.";
		    }
				}
	}
}
