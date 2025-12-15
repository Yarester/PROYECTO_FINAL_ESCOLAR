/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 15/12/2025
 * Hora: 02:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Segundahora
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
			this.txtHoras = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtSeg = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtHoras
			// 
			this.txtHoras.Location = new System.Drawing.Point(319, 266);
			this.txtHoras.Name = "txtHoras";
			this.txtHoras.ReadOnly = true;
			this.txtHoras.Size = new System.Drawing.Size(100, 22);
			this.txtHoras.TabIndex = 16;
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
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtSeg
			// 
			this.txtSeg.Location = new System.Drawing.Point(319, 112);
			this.txtSeg.Name = "txtSeg";
			this.txtSeg.Size = new System.Drawing.Size(100, 22);
			this.txtSeg.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(319, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 27);
			this.label3.TabIndex = 14;
			this.label3.Text = "HORAS";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(123, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "SEGUNDOS A HORAS";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(301, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 27);
			this.label2.TabIndex = 13;
			this.label2.Text = "SEGUNDOS";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Thistle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-9, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(585, 39);
			this.panel1.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Plum;
			this.panel3.Controls.Add(this.button2);
			this.panel3.Location = new System.Drawing.Point(1, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(246, 342);
			this.panel3.TabIndex = 17;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(22, 278);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(185, 40);
			this.button2.TabIndex = 0;
			this.button2.Text = "CONVERTIR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Segundahora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Violet;
			this.ClientSize = new System.Drawing.Size(524, 378);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.txtHoras);
			this.Controls.Add(this.txtSeg);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Segundahora";
			this.Text = "Segundahora";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSeg;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtHoras;
	}
}
