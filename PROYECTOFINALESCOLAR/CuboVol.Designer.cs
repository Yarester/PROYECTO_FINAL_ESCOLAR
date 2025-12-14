/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 13/12/2025
 * Hora: 04:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class CuboVol
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuboVol));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Cubo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLado = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Plum;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.txtResultado);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.Cubo);
			this.panel1.Location = new System.Drawing.Point(0, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 343);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(23, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(148, 135);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// txtResultado
			// 
			this.txtResultado.BackColor = System.Drawing.Color.Violet;
			this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtResultado.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtResultado.Location = new System.Drawing.Point(35, 245);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(116, 43);
			this.txtResultado.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label3.Location = new System.Drawing.Point(12, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 54);
			this.label3.TabIndex = 6;
			this.label3.Text = "Volumen del cubo:";
			// 
			// Cubo
			// 
			this.Cubo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Cubo.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.Cubo.Location = new System.Drawing.Point(35, 12);
			this.Cubo.Name = "Cubo";
			this.Cubo.Size = new System.Drawing.Size(99, 35);
			this.Cubo.TabIndex = 0;
			this.Cubo.Text = "Cubo";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(222, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 54);
			this.label1.TabIndex = 1;
			this.label1.Text = "Introduce la medida del lado:";
			// 
			// txtLado
			// 
			this.txtLado.BackColor = System.Drawing.Color.Violet;
			this.txtLado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLado.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtLado.Location = new System.Drawing.Point(265, 81);
			this.txtLado.Name = "txtLado";
			this.txtLado.Size = new System.Drawing.Size(116, 43);
			this.txtLado.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnCalcular.Location = new System.Drawing.Point(248, 146);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(170, 58);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Plum;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnLimpiar.Location = new System.Drawing.Point(331, 240);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(118, 41);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Plum;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnCerrar.Location = new System.Drawing.Point(206, 240);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(100, 41);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// CuboVol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(461, 314);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CuboVol";
			this.Text = "CuboVol";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtLado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Cubo;
		private System.Windows.Forms.Panel panel1;
	}
}
