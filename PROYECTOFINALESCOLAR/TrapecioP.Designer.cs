/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 14/12/2025
 * Hora: 09:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class TrapecioP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrapecioP));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLado4 = new System.Windows.Forms.TextBox();
			this.txtLado3 = new System.Windows.Forms.TextBox();
			this.txtLado2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLado1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtP = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(459, 91);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(89, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "Trapecio";
			// 
			// txtLado4
			// 
			this.txtLado4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.txtLado4.Location = new System.Drawing.Point(302, 129);
			this.txtLado4.Name = "txtLado4";
			this.txtLado4.Size = new System.Drawing.Size(56, 32);
			this.txtLado4.TabIndex = 17;
			// 
			// txtLado3
			// 
			this.txtLado3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.txtLado3.Location = new System.Drawing.Point(208, 129);
			this.txtLado3.Name = "txtLado3";
			this.txtLado3.Size = new System.Drawing.Size(56, 32);
			this.txtLado3.TabIndex = 16;
			// 
			// txtLado2
			// 
			this.txtLado2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.txtLado2.Location = new System.Drawing.Point(108, 129);
			this.txtLado2.Name = "txtLado2";
			this.txtLado2.Size = new System.Drawing.Size(56, 32);
			this.txtLado2.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.label5.Location = new System.Drawing.Point(302, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Lado 4:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.label4.Location = new System.Drawing.Point(208, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Lado 3:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.label3.Location = new System.Drawing.Point(108, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Lado 2:";
			// 
			// txtLado1
			// 
			this.txtLado1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.txtLado1.Location = new System.Drawing.Point(12, 129);
			this.txtLado1.Name = "txtLado1";
			this.txtLado1.Size = new System.Drawing.Size(56, 32);
			this.txtLado1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.label2.Location = new System.Drawing.Point(12, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Lado 1:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(23, 177);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(141, 90);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(208, 177);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(129, 43);
			this.btnCalcular.TabIndex = 19;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(208, 226);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(130, 41);
			this.btnLimpiar.TabIndex = 20;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(207, 275);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(130, 41);
			this.btnCerrar.TabIndex = 21;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.label6.Location = new System.Drawing.Point(12, 293);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Perímetro:";
			// 
			// txtP
			// 
			this.txtP.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
			this.txtP.Location = new System.Drawing.Point(108, 290);
			this.txtP.Name = "txtP";
			this.txtP.Size = new System.Drawing.Size(56, 32);
			this.txtP.TabIndex = 23;
			// 
			// TrapecioP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkMagenta;
			this.ClientSize = new System.Drawing.Size(382, 339);
			this.Controls.Add(this.txtP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtLado4);
			this.Controls.Add(this.txtLado3);
			this.Controls.Add(this.txtLado2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLado1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TrapecioP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TrapecioP";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLado1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLado2;
		private System.Windows.Forms.TextBox txtLado3;
		private System.Windows.Forms.TextBox txtLado4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
