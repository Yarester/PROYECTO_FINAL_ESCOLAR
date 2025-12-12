/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(229, 344);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(48, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 52);
			this.label3.TabIndex = 2;
			this.label3.Text = "Inicio";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Location = new System.Drawing.Point(12, 283);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(52, 45);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalirClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Purple;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(32, 24);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(157, 122);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(237, 85);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.Purple;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(358, 91);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(161, 23);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(237, 172);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 28);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.Purple;
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPass.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(358, 175);
			this.txtPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(161, 23);
			this.txtPass.TabIndex = 4;
			this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPass.TextChanged += new System.EventHandler(this.TxtPassTextChanged);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Location = new System.Drawing.Point(372, 266);
			this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(137, 52);
			this.btnEntrar.TabIndex = 5;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkMagenta;
			this.ClientSize = new System.Drawing.Size(552, 342);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "PROYECTOFINALESCOLAR";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
