/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 10/12/2025
 * Hora: 01:03 p. m.
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
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNum.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum.Location = new System.Drawing.Point(111, 147);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(235, 32);
			this.txtNum.TabIndex = 0;
			this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Orchid;
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(142, 199);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(169, 50);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(142, 280);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(169, 43);
			this.lblResult.TabIndex = 2;
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orchid;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-2, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 118);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(113, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Factorial";
			// 
			// Factorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(454, 359);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNum);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Factorial";
			this.Text = "Factorial";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtNum;
	}
}
