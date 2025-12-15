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
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			CircunferenciaP Circun = new CircunferenciaP();
			Circun.MdiParent = this;
			Circun.Show();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			TrapecioP Trap = new TrapecioP();
			Trap.MdiParent = this;
			Trap.Show();
		}
	}
}
