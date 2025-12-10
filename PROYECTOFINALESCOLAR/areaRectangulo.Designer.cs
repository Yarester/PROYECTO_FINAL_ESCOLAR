/*
 * Created by SharpDevelop.
 * User: CC1_PC16
 * Date: 10/12/2025
 * Time: 01:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROYECTOFINALESCOLAR
{
	partial class areaRectangulo
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResul = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Base:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Altura:";
			// 
			// txtBase
			// 
			this.txtBase.Location = new System.Drawing.Point(113, 29);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(100, 20);
			this.txtBase.TabIndex = 2;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(113, 66);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 20);
			this.txtAltura.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(101, 127);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblResul
			// 
			this.lblResul.Location = new System.Drawing.Point(113, 100);
			this.lblResul.Name = "lblResul";
			this.lblResul.Size = new System.Drawing.Size(100, 23);
			this.lblResul.TabIndex = 5;
			// 
			// areaRectangulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(251, 187);
			this.Controls.Add(this.lblResul);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "areaRectangulo";
			this.Text = "areaRectangulo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResul;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
