/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Form2
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
			this.txtLado = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtLado
			// 
			this.txtLado.Location = new System.Drawing.Point(127, 47);
			this.txtLado.Name = "txtLado";
			this.txtLado.Size = new System.Drawing.Size(100, 20);
			this.txtLado.TabIndex = 0;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(127, 116);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(62, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lado:";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(129, 79);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 3;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(286, 208);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLado);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtLado;
	}
}
