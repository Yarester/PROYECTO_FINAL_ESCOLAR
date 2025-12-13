/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 12/12/2025
 * Hora: 05:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class EsferaVol
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsferaVol));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtVol = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Plum;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtVol);
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 343);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label4.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 37);
			this.label4.TabIndex = 6;
			this.label4.Text = "Esfera";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 150);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
			this.label2.Location = new System.Drawing.Point(12, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 52);
			this.label2.TabIndex = 3;
			this.label2.Text = "Volúmen de la esfera:";
			// 
			// txtVol
			// 
			this.txtVol.BackColor = System.Drawing.Color.Violet;
			this.txtVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtVol.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtVol.Location = new System.Drawing.Point(12, 287);
			this.txtVol.Name = "txtVol";
			this.txtVol.Size = new System.Drawing.Size(169, 43);
			this.txtVol.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(216, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Introduce el radio:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtRadio
			// 
			this.txtRadio.BackColor = System.Drawing.Color.Violet;
			this.txtRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRadio.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold);
			this.txtRadio.Location = new System.Drawing.Point(216, 86);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(194, 43);
			this.txtRadio.TabIndex = 2;
			this.txtRadio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnCalcular.Location = new System.Drawing.Point(240, 163);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(170, 58);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Plum;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnClear.Location = new System.Drawing.Point(330, 247);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(119, 35);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Limpiar";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Plum;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic);
			this.btnSalir.Location = new System.Drawing.Point(207, 247);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(101, 41);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Cerrar";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// EsferaVol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(461, 341);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EsferaVol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EsferaVol";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtVol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
