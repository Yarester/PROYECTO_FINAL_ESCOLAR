/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 05:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class PiramideVol
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiramideVol));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtVol = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLado = new System.Windows.Forms.TextBox();
			this.txtH = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClean = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Plum;
			this.panel1.Controls.Add(this.txtVol);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(-2, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(184, 369);
			this.panel1.TabIndex = 0;
			// 
			// txtVol
			// 
			this.txtVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtVol.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtVol.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtVol.Location = new System.Drawing.Point(15, 266);
			this.txtVol.Name = "txtVol";
			this.txtVol.Size = new System.Drawing.Size(142, 36);
			this.txtVol.TabIndex = 8;
			this.txtVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label3.Location = new System.Drawing.Point(14, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 63);
			this.label3.TabIndex = 8;
			this.label3.Text = "Volúmen de la pirámide:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 171);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(199, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lado:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label2.Location = new System.Drawing.Point(199, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Altura:";
			// 
			// txtLado
			// 
			this.txtLado.BackColor = System.Drawing.Color.Violet;
			this.txtLado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLado.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtLado.Location = new System.Drawing.Point(305, 89);
			this.txtLado.Name = "txtLado";
			this.txtLado.Size = new System.Drawing.Size(100, 36);
			this.txtLado.TabIndex = 3;
			this.txtLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtH
			// 
			this.txtH.BackColor = System.Drawing.Color.Violet;
			this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtH.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtH.Location = new System.Drawing.Point(305, 161);
			this.txtH.Name = "txtH";
			this.txtH.Size = new System.Drawing.Size(100, 36);
			this.txtH.TabIndex = 4;
			this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnCalcular.Location = new System.Drawing.Point(260, 219);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(114, 43);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Plum;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnClose.Location = new System.Drawing.Point(189, 279);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(114, 43);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Cerrar";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnClean
			// 
			this.btnClean.BackColor = System.Drawing.Color.Plum;
			this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClean.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnClean.Location = new System.Drawing.Point(333, 279);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(114, 43);
			this.btnClean.TabIndex = 7;
			this.btnClean.Text = "Limpiar";
			this.btnClean.UseVisualStyleBackColor = false;
			this.btnClean.Click += new System.EventHandler(this.Button3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.Location = new System.Drawing.Point(226, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 44);
			this.label4.TabIndex = 8;
			this.label4.Text = "Pirámide";
			// 
			// PiramideVol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(455, 345);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClean);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtH);
			this.Controls.Add(this.txtLado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PiramideVol";
			this.Text = "PiramideVol";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVol;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClean;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtH;
		private System.Windows.Forms.TextBox txtLado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
