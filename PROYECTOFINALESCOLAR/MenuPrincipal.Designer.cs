/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class MenuPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibbonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.áreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.períToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilométrosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilometrosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilogramosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.celsiusAFarenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segundosAHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteleríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aplicacionesToolStripMenuItem,
									this.áreasToolStripMenuItem,
									this.períToolStripMenuItem,
									this.volumenToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaDeCalificacionesToolStripMenuItem,
									this.pasteleríaToolStripMenuItem,
									this.empleadosToolStripMenuItem,
									this.salirToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aplicacionesToolStripMenuItem
			// 
			this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.fibbonacciToolStripMenuItem});
			this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
			this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.factorialToolStripMenuItem.Text = "Factorial";
			this.factorialToolStripMenuItem.Click += new System.EventHandler(this.FactorialToolStripMenuItemClick);
			// 
			// fibbonacciToolStripMenuItem
			// 
			this.fibbonacciToolStripMenuItem.Name = "fibbonacciToolStripMenuItem";
			this.fibbonacciToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.fibbonacciToolStripMenuItem.Text = "Fibonnaci";
			this.fibbonacciToolStripMenuItem.Click += new System.EventHandler(this.FibbonacciToolStripMenuItemClick);
			// 
			// áreasToolStripMenuItem
			// 
			this.áreasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.rectánguloToolStripMenuItem,
									this.triánguloToolStripMenuItem});
			this.áreasToolStripMenuItem.Name = "áreasToolStripMenuItem";
			this.áreasToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.áreasToolStripMenuItem.Text = "Áreas";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// rectánguloToolStripMenuItem
			// 
			this.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem";
			this.rectánguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.rectánguloToolStripMenuItem.Text = "Rectángulo";
			this.rectánguloToolStripMenuItem.Click += new System.EventHandler(this.RectánguloToolStripMenuItemClick);
			// 
			// triánguloToolStripMenuItem
			// 
			this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
			this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.triánguloToolStripMenuItem.Text = "Triángulo";
			this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.TriánguloToolStripMenuItemClick);
			// 
			// períToolStripMenuItem
			// 
			this.períToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.períToolStripMenuItem.Name = "períToolStripMenuItem";
			this.períToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
			this.períToolStripMenuItem.Text = " Perímetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem,
									this.pirámideToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.volumenToolStripMenuItem.Text = "Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// pirámideToolStripMenuItem
			// 
			this.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem";
			this.pirámideToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.pirámideToolStripMenuItem.Text = "Pirámide";
			this.pirámideToolStripMenuItem.Click += new System.EventHandler(this.PirámideToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilométrosAMillasToolStripMenuItem,
									this.masaToolStripMenuItem,
									this.temperaturaToolStripMenuItem,
									this.tiempoToolStripMenuItem});
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.conversionesToolStripMenuItem.Text = "Conversiones";
			// 
			// kilométrosAMillasToolStripMenuItem
			// 
			this.kilométrosAMillasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilometrosAMillasToolStripMenuItem});
			this.kilométrosAMillasToolStripMenuItem.Name = "kilométrosAMillasToolStripMenuItem";
			this.kilométrosAMillasToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.kilométrosAMillasToolStripMenuItem.Text = "Longitud";
			// 
			// kilometrosAMillasToolStripMenuItem
			// 
			this.kilometrosAMillasToolStripMenuItem.Name = "kilometrosAMillasToolStripMenuItem";
			this.kilometrosAMillasToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
			this.kilometrosAMillasToolStripMenuItem.Text = "Kilometros a Millas";
			this.kilometrosAMillasToolStripMenuItem.Click += new System.EventHandler(this.KilometrosAMillasToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilogramosAMillasToolStripMenuItem});
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.masaToolStripMenuItem.Text = "Masa";
			// 
			// kilogramosAMillasToolStripMenuItem
			// 
			this.kilogramosAMillasToolStripMenuItem.Name = "kilogramosAMillasToolStripMenuItem";
			this.kilogramosAMillasToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.kilogramosAMillasToolStripMenuItem.Text = "Kilogramos a Libras";
			this.kilogramosAMillasToolStripMenuItem.Click += new System.EventHandler(this.KilogramosAMillasToolStripMenuItemClick);
			// 
			// temperaturaToolStripMenuItem
			// 
			this.temperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.celsiusAFarenheitToolStripMenuItem});
			this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
			this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.temperaturaToolStripMenuItem.Text = "Temperatura";
			// 
			// celsiusAFarenheitToolStripMenuItem
			// 
			this.celsiusAFarenheitToolStripMenuItem.Name = "celsiusAFarenheitToolStripMenuItem";
			this.celsiusAFarenheitToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
			this.celsiusAFarenheitToolStripMenuItem.Text = "Celsius a Farenheit";
			this.celsiusAFarenheitToolStripMenuItem.Click += new System.EventHandler(this.CelsiusAFarenheitToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.segundosAHorasToolStripMenuItem});
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.tiempoToolStripMenuItem.Text = "Tiempo";
			// 
			// segundosAHorasToolStripMenuItem
			// 
			this.segundosAHorasToolStripMenuItem.Name = "segundosAHorasToolStripMenuItem";
			this.segundosAHorasToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
			this.segundosAHorasToolStripMenuItem.Text = "Segundos a Horas";
			this.segundosAHorasToolStripMenuItem.Click += new System.EventHandler(this.SegundosAHorasToolStripMenuItemClick);
			// 
			// boletaDeCalificacionesToolStripMenuItem
			// 
			this.boletaDeCalificacionesToolStripMenuItem.Name = "boletaDeCalificacionesToolStripMenuItem";
			this.boletaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
			this.boletaDeCalificacionesToolStripMenuItem.Text = "Boleta de calificaciones";
			this.boletaDeCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.BoletaDeCalificacionesToolStripMenuItemClick);
			// 
			// pasteleríaToolStripMenuItem
			// 
			this.pasteleríaToolStripMenuItem.Name = "pasteleríaToolStripMenuItem";
			this.pasteleríaToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.pasteleríaToolStripMenuItem.Text = "Pastelería";
			this.pasteleríaToolStripMenuItem.Click += new System.EventHandler(this.PasteleríaToolStripMenuItemClick);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem1});
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.salirToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem1
			// 
			this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
			this.salirToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
			this.salirToolStripMenuItem1.Text = "Salir";
			this.salirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1Click);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1054, 705);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MenuPrincipal";
			this.Text = "Menú principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem segundosAHorasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem celsiusAFarenheitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilogramosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilometrosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilométrosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteleríaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boletaDeCalificacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem períToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem áreasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fibbonacciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
