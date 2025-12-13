/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 01:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Fibonacci
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnClean = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Fuchsia;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(406, 127);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.Location = new System.Drawing.Point(53, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 63);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fibonacci";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNum.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum.Location = new System.Drawing.Point(91, 151);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(216, 36);
			this.txtNum.TabIndex = 1;
			// 
			// txtResult
			// 
			this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtResult.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtResult.Location = new System.Drawing.Point(91, 279);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(216, 36);
			this.txtResult.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Fuchsia;
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnCalcular.Location = new System.Drawing.Point(121, 207);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(155, 57);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Fuchsia;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnSalir.Location = new System.Drawing.Point(40, 335);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(136, 36);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Cerrar";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnClean
			// 
			this.btnClean.BackColor = System.Drawing.Color.Fuchsia;
			this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClean.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnClean.Location = new System.Drawing.Point(205, 335);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(136, 36);
			this.btnClean.TabIndex = 6;
			this.btnClean.Text = "Limpiar";
			this.btnClean.UseVisualStyleBackColor = false;
			this.btnClean.Click += new System.EventHandler(this.BtnCleanClick);
			// 
			// Fibonacci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(407, 383);
			this.Controls.Add(this.btnClean);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Fibonacci";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fibonacci";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClean;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Panel panel1;
	}
}
