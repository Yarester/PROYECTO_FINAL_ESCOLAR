/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 14/12/2025
 * Hora: 03:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Temperatura
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtF = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(436, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtF
			// 
			this.txtF.Location = new System.Drawing.Point(329, 265);
			this.txtF.Name = "txtF";
			this.txtF.Size = new System.Drawing.Size(100, 22);
			this.txtF.TabIndex = 10;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(329, 111);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(305, 226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 27);
			this.label3.TabIndex = 8;
			this.label3.Text = "FAHRENHEIT ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(111, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "CELCIOUS A FAHRENHEIT ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(305, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 27);
			this.label2.TabIndex = 6;
			this.label2.Text = "CELCIOUS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Plum;
			this.panel2.Controls.Add(this.btnConvertir);
			this.panel2.Location = new System.Drawing.Point(1, 39);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(246, 342);
			this.panel2.TabIndex = 7;
			// 
			// btnConvertir
			// 
			this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertir.Location = new System.Drawing.Point(22, 278);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(185, 40);
			this.btnConvertir.TabIndex = 0;
			this.btnConvertir.Text = "CONVERTIR";
			this.btnConvertir.UseVisualStyleBackColor = true;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Thistle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(585, 39);
			this.panel1.TabIndex = 5;
			// 
			// Temperatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Violet;
			this.ClientSize = new System.Drawing.Size(516, 369);
			this.Controls.Add(this.txtF);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Temperatura";
			this.Text = "Temperatura";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtF;
		private System.Windows.Forms.Button button1;
	}
}
