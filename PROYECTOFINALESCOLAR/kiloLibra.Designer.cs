/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 14/12/2025
 * Hora: 02:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class kiloLibra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kiloLibra));
			this.txtLibras = new System.Windows.Forms.TextBox();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.txtKilogramos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLibras
			// 
			this.txtLibras.Location = new System.Drawing.Point(332, 265);
			this.txtLibras.Name = "txtLibras";
			this.txtLibras.ReadOnly = true;
			this.txtLibras.Size = new System.Drawing.Size(100, 22);
			this.txtLibras.TabIndex = 10;
			// 
			// btnConvertir
			// 
			this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertir.Location = new System.Drawing.Point(38, 273);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(185, 40);
			this.btnConvertir.TabIndex = 0;
			this.btnConvertir.Text = "CONVERTIR";
			this.btnConvertir.UseVisualStyleBackColor = true;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// txtKilogramos
			// 
			this.txtKilogramos.Location = new System.Drawing.Point(332, 111);
			this.txtKilogramos.Name = "txtKilogramos";
			this.txtKilogramos.Size = new System.Drawing.Size(100, 22);
			this.txtKilogramos.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(308, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 27);
			this.label2.TabIndex = 7;
			this.label2.Text = "KILOGRAMOS";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(443, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(332, 226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 27);
			this.label3.TabIndex = 8;
			this.label3.Text = "LIBRAS";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(122, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "KILOGRAMOS A LIBRAS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Plum;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.btnConvertir);
			this.panel2.Location = new System.Drawing.Point(-3, 39);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(253, 342);
			this.panel2.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Thistle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-8, -4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(597, 46);
			this.panel1.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(238, 204);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// kiloLibra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Violet;
			this.ClientSize = new System.Drawing.Size(513, 371);
			this.Controls.Add(this.txtLibras);
			this.Controls.Add(this.txtKilogramos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "kiloLibra";
			this.Text = "kiloLibra";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKilogramos;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.TextBox txtLibras;
	}
}
