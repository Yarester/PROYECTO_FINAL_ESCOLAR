/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 08/12/2025
 * Hora: 03:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTOFINALESCOLAR
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lvTabla = new System.Windows.Forms.ListView();
			this.CHproducto = new System.Windows.Forms.ColumnHeader();
			this.CHprecio = new System.Windows.Forms.ColumnHeader();
			this.CHcantidad = new System.Windows.Forms.ColumnHeader();
			this.CHTotal = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.BORRAR = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(979, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rdbDulce
			// 
			this.rdbDulce.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdbDulce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDulce.ForeColor = System.Drawing.Color.White;
			this.rdbDulce.Location = new System.Drawing.Point(12, 20);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(116, 24);
			this.rdbDulce.TabIndex = 1;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "DULCE";
			this.rdbDulce.UseVisualStyleBackColor = true;
			this.rdbDulce.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// rdbSalado
			// 
			this.rdbSalado.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdbSalado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbSalado.ForeColor = System.Drawing.Color.White;
			this.rdbSalado.Location = new System.Drawing.Point(134, 20);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(126, 24);
			this.rdbSalado.TabIndex = 2;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "SALADO";
			this.rdbSalado.UseVisualStyleBackColor = true;
			this.rdbSalado.CheckedChanged += new System.EventHandler(this.RdbSaladoCheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
			this.panel1.Controls.Add(this.rdbDulce);
			this.panel1.Controls.Add(this.rdbSalado);
			this.panel1.Location = new System.Drawing.Point(376, 107);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 63);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Indigo;
			this.label1.Location = new System.Drawing.Point(12, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 40);
			this.label1.TabIndex = 4;
			this.label1.Text = "SELECCIONAR PRODUCTO";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.ForeColor = System.Drawing.Color.Indigo;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"PRODUCTO 1",
									"PRODUCTO 2",
									"PRODUCTO 3"});
			this.comboBox1.Location = new System.Drawing.Point(351, 206);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(276, 33);
			this.comboBox1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Indigo;
			this.label2.Location = new System.Drawing.Point(46, 272);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 40);
			this.label2.TabIndex = 6;
			this.label2.Text = "Precio";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(31, 298);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 27);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Indigo;
			this.label3.Location = new System.Drawing.Point(205, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 26);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cantidad";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.Indigo;
			this.textBox2.Location = new System.Drawing.Point(196, 301);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 27);
			this.textBox2.TabIndex = 9;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Indigo;
			this.label4.Location = new System.Drawing.Point(367, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 26);
			this.label4.TabIndex = 10;
			this.label4.Text = "Total";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.ForeColor = System.Drawing.Color.Indigo;
			this.textBox3.Location = new System.Drawing.Point(351, 301);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 27);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "0";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lvTabla
			// 
			this.lvTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.CHproducto,
									this.CHprecio,
									this.CHcantidad,
									this.CHTotal});
			this.lvTabla.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.lvTabla.ForeColor = System.Drawing.Color.White;
			this.lvTabla.Location = new System.Drawing.Point(31, 366);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(895, 203);
			this.lvTabla.TabIndex = 12;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
			// 
			// CHproducto
			// 
			this.CHproducto.Text = "Producto";
			this.CHproducto.Width = 314;
			// 
			// CHprecio
			// 
			this.CHprecio.Text = "Precio";
			this.CHprecio.Width = 134;
			// 
			// CHcantidad
			// 
			this.CHcantidad.Text = "Cantidad";
			this.CHcantidad.Width = 151;
			// 
			// CHTotal
			// 
			this.CHTotal.Text = "Total";
			this.CHTotal.Width = 292;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Indigo;
			this.label5.Location = new System.Drawing.Point(31, 593);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 36);
			this.label5.TabIndex = 13;
			this.label5.Text = "Subtotal";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.ForeColor = System.Drawing.Color.Indigo;
			this.textBox4.Location = new System.Drawing.Point(132, 596);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 27);
			this.textBox4.TabIndex = 14;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Indigo;
			this.label6.Location = new System.Drawing.Point(299, 596);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 36);
			this.label6.TabIndex = 15;
			this.label6.Text = "Subtotal";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.ForeColor = System.Drawing.Color.Indigo;
			this.textBox5.Location = new System.Drawing.Point(388, 599);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 27);
			this.textBox5.TabIndex = 16;
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.btnGuardar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
			this.btnGuardar.Location = new System.Drawing.Point(132, 679);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(114, 53);
			this.btnGuardar.TabIndex = 17;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// BORRAR
			// 
			this.BORRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.BORRAR.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.BORRAR.ForeColor = System.Drawing.Color.Indigo;
			this.BORRAR.Location = new System.Drawing.Point(322, 679);
			this.BORRAR.Name = "BORRAR";
			this.BORRAR.Size = new System.Drawing.Size(114, 53);
			this.BORRAR.TabIndex = 18;
			this.BORRAR.Text = "BORRAR";
			this.BORRAR.UseVisualStyleBackColor = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.btnImprimir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.btnImprimir.ForeColor = System.Drawing.Color.Indigo;
			this.btnImprimir.Location = new System.Drawing.Point(484, 679);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(121, 53);
			this.btnImprimir.TabIndex = 19;
			this.btnImprimir.Text = "IMPRIMIR";
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Indigo;
			this.label7.Location = new System.Drawing.Point(659, 590);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 36);
			this.label7.TabIndex = 20;
			this.label7.Text = "Importe Neto";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Indigo;
			this.label8.Location = new System.Drawing.Point(641, 623);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(159, 36);
			this.label8.TabIndex = 21;
			this.label8.Text = "Importe Pagado";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Indigo;
			this.label9.Location = new System.Drawing.Point(714, 659);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 36);
			this.label9.TabIndex = 22;
			this.label9.Text = "Cambio";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.Indigo;
			this.textBox6.Location = new System.Drawing.Point(806, 590);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 27);
			this.textBox6.TabIndex = 23;
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.ForeColor = System.Drawing.Color.Indigo;
			this.textBox7.Location = new System.Drawing.Point(806, 626);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 27);
			this.textBox7.TabIndex = 24;
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.textBox8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox8.ForeColor = System.Drawing.Color.Indigo;
			this.textBox8.Location = new System.Drawing.Point(806, 662);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 27);
			this.textBox8.TabIndex = 25;
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.button1.ForeColor = System.Drawing.Color.Indigo;
			this.button1.Location = new System.Drawing.Point(675, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(251, 37);
			this.button1.TabIndex = 26;
			this.button1.Text = "AGREGAR PRODUCTO";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
			this.button2.ForeColor = System.Drawing.Color.Indigo;
			this.button2.Location = new System.Drawing.Point(675, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(251, 37);
			this.button2.TabIndex = 27;
			this.button2.Text = "ELIMINAR PRODUCTO";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(976, 744);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.BORRAR);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form2";
			this.Text = "PASTELERIA";
			this.Load += new System.EventHandler(this.Form2Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button BORRAR;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader CHTotal;
		private System.Windows.Forms.ColumnHeader CHcantidad;
		private System.Windows.Forms.ColumnHeader CHprecio;
		private System.Windows.Forms.ColumnHeader CHproducto;
		private System.Windows.Forms.ListView lvTabla;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
