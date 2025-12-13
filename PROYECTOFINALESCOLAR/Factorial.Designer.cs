/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 11:01 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Factorial
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Fuchsia;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 124);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "Factorial";
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Fuchsia;
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(104, 200);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(179, 67);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNum.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtNum.Location = new System.Drawing.Point(87, 150);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(219, 36);
			this.txtNum.TabIndex = 2;
			// 
			// txtResultado
			// 
			this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtResultado.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtResultado.Location = new System.Drawing.Point(87, 282);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(219, 36);
			this.txtResultado.TabIndex = 3;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Fuchsia;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(12, 333);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(152, 41);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Cerrar";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Fuchsia;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(207, 333);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(152, 41);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Limpiar";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// Factorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(406, 386);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Factorial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Factorial";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
