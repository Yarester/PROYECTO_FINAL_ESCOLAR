/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.IsMdiContainer = true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//MDI FORMULARIO
		}
		
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			    Factorial fac = new Factorial();
   			 	fac.MdiParent = this;
  				fac.Show();

		}
		
		void FibbonacciToolStripMenuItemClick(object sender, EventArgs e)
		{
			    Fibonacci fib = new Fibonacci();
    			fib.MdiParent = this;
    			fib.Show();

		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			EsferaVol Esfera = new EsferaVol();
			Esfera.MdiParent = this;
			Esfera.Show();
		}
		
		
		void PirámideToolStripMenuItemClick(object sender, EventArgs e)
		{
			PiramideVol Piramide = new PiramideVol();
			Piramide.MdiParent = this;
			Piramide.Show();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			CuboVol Cubo = new CuboVol();
			Cubo.MdiParent = this;
			Cubo.Show();
		}
		
		void BoletaDeCalificacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
		    BoletaCalificacion Cali = new BoletaCalificacion();
			Cali.MdiParent = this;
			Cali.Show();
		}
		
		void KilometrosAMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			KiloMillas kms = new KiloMillas();
			kms.MdiParent = this;
			kms.Show();
		}
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			CuadradoA Cuadrado = new CuadradoA();
			Cuadrado.MdiParent = this;
			Cuadrado.Show();
		}
		
		void RectánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			RectanguloA Rect = new RectanguloA();
			Rect.MdiParent = this;
			Rect.Show();
		}
		
		void TriánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			TrianguloA Tria = new TrianguloA();
			Tria.MdiParent = this;
			Tria.Show();
		}
		
		void KilogramosAMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			kiloLibra kl = new kiloLibra();
			kl.MdiParent = this;
			kl.Show();
		}
		
		void CelsiusAFarenheitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Temperatura temp = new Temperatura();
			temp.MdiParent = this;
			temp.Show();
		}
		
		void SegundosAHorasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Segundahora sh = new Segundahora();
			sh.MdiParent = this;
			sh.Show();
     }
      
		void PasteleríaToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmPasteleria Past = new frmPasteleria();
			Past.MdiParent = this;
			Past.Show();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			acercaD Crc = new acercaD();
			Crc.MdiParent = this;
			Crc.Show();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Empleados yo = new Empleados();
			yo.MdiParent = this;
			yo.Show();	
		}
		
		void SalirToolStripMenuItem1Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Estas seguro de que deseas salir del sistema?", "Confirmr salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (respuesta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
