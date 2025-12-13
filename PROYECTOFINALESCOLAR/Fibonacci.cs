/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 01:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Fibonacci.
	/// </summary>
	public partial class Fibonacci : Form
	{
		public Fibonacci()
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
		        int num = int.Parse(txtNum.Text);
		
		        if (num <= 0)
		        {
		            txtResult.Text = "Ingresa un número mayor a 0.";
		            return;
		        }
		
		        int a = 0, b = 1;
		        string serie = "";
		
		        for (int i = 1; i <= num; i++)
		        {
		            serie += a + "  ";
		            int temp = a + b;
		            a = b;
		            b = temp;
		        }
		
		        txtResult.Text = serie;
		    }
		    catch
		    {
		        txtResult.Text = "Número inválido.";
		    }

		}
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnCleanClick(object sender, EventArgs e)
		{
			txtResult.Clear();
		   txtNum.Clear();
		}
	}
}
