/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 14/12/2025
 * Hora: 12:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class TrianguloA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrianguloA));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 78);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(111, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 49);
			this.label3.TabIndex = 1;
			this.label3.Text = "Triángulo";
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(315, 221);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(91, 40);
			this.btnCerrar.TabIndex = 7;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(172, 221);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(91, 40);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalcular.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(32, 221);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(91, 40);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtArea
			// 
			this.txtArea.Font = new System.Drawing.Font("Gill Sans MT", 10.8F);
			this.txtArea.Location = new System.Drawing.Point(313, 131);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(100, 28);
			this.txtArea.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(322, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Area:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(155, 94);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 107);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// txtAltura
			// 
			this.txtAltura.Font = new System.Drawing.Font("Gill Sans MT", 10.8F);
			this.txtAltura.Location = new System.Drawing.Point(24, 172);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 28);
			this.txtAltura.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Inserte altura:";
			// 
			// txtBase
			// 
			this.txtBase.Font = new System.Drawing.Font("Gill Sans MT", 10.8F);
			this.txtBase.Location = new System.Drawing.Point(23, 114);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(100, 28);
			this.txtBase.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Inserte la base:";
			// 
			// TrianguloA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orchid;
			this.ClientSize = new System.Drawing.Size(437, 284);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TrianguloA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TrianguloA";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Panel panel1;
	}
}
