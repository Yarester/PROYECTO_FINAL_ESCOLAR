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
	partial class frmPasteleria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasteleria));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(968, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
			this.panel1.Controls.Add(this.rdbSalado);
			this.panel1.Controls.Add(this.rdbDulce);
			this.panel1.Location = new System.Drawing.Point(393, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(206, 55);
			this.panel1.TabIndex = 1;
			// 
			// rdbSalado
			// 
			this.rdbSalado.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbSalado.ForeColor = System.Drawing.Color.White;
			this.rdbSalado.Location = new System.Drawing.Point(106, 14);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(95, 24);
			this.rdbSalado.TabIndex = 2;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "SALADO";
			this.rdbSalado.UseVisualStyleBackColor = true;
			this.rdbSalado.CheckedChanged += new System.EventHandler(this.RdbSaladoCheckedChanged);
			// 
			// rdbDulce
			// 
			this.rdbDulce.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDulce.ForeColor = System.Drawing.Color.White;
			this.rdbDulce.Location = new System.Drawing.Point(3, 14);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(97, 24);
			this.rdbDulce.TabIndex = 3;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "DULCE";
			this.rdbDulce.UseVisualStyleBackColor = true;
			this.rdbDulce.CheckedChanged += new System.EventHandler(this.RdbDulceCheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label1.Location = new System.Drawing.Point(12, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "SELECCIONAR PRODUCTO";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"",
									"PRODUCTO1",
									"PRODUCTO2",
									"PRODUCTO3",
									"PRODUCTO4"});
			this.comboBox1.Location = new System.Drawing.Point(318, 219);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(213, 29);
			this.comboBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(687, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(239, 45);
			this.button1.TabIndex = 4;
			this.button1.Text = "AGREGAR PRODUCTO";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(687, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(239, 45);
			this.button2.TabIndex = 5;
			this.button2.Text = "ELEMINAR PRODUCTO";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label2.Location = new System.Drawing.Point(31, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 34);
			this.label2.TabIndex = 6;
			this.label2.Text = "PRECIO";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(26, 304);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label3.Location = new System.Drawing.Point(175, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 32);
			this.label3.TabIndex = 8;
			this.label3.Text = "CANTIDAD";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(175, 304);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label4.Location = new System.Drawing.Point(336, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 32);
			this.label4.TabIndex = 10;
			this.label4.Text = "TOTAL";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(318, 304);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 11;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.listView1.Location = new System.Drawing.Point(31, 397);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(895, 154);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "PRODUCTO";
			this.columnHeader1.Width = 285;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PRECIO";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 209;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CANTIDAD";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 223;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "TOTAL";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 173;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label5.Location = new System.Drawing.Point(40, 595);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "SUBTOTAL";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(158, 601);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label6.Location = new System.Drawing.Point(284, 595);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 32);
			this.label6.TabIndex = 15;
			this.label6.Text = "DESCUENTO";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(413, 601);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 16;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(96, 662);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(126, 45);
			this.button3.TabIndex = 17;
			this.button3.Text = "GUARDAR";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(292, 662);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(126, 45);
			this.button4.TabIndex = 18;
			this.button4.Text = "BORRAR";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(473, 662);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(126, 45);
			this.button5.TabIndex = 19;
			this.button5.Text = "IMPRIMIR";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
			this.panel2.Location = new System.Drawing.Point(0, 363);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(968, 15);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
			this.panel3.Location = new System.Drawing.Point(0, 566);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(968, 15);
			this.panel3.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label7.Location = new System.Drawing.Point(621, 584);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 25);
			this.label7.TabIndex = 20;
			this.label7.Text = "IMPORTE NETO";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(747, 581);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(163, 28);
			this.textBox6.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label8.Location = new System.Drawing.Point(621, 625);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 25);
			this.label8.TabIndex = 22;
			this.label8.Text = "IMPORTE PAGADO";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label9.Location = new System.Drawing.Point(621, 665);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(152, 25);
			this.label9.TabIndex = 23;
			this.label9.Text = "CAMBIO";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(763, 622);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(163, 28);
			this.textBox7.TabIndex = 24;
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox8.Location = new System.Drawing.Point(704, 662);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(163, 28);
			this.textBox8.TabIndex = 25;
			// 
			// frmPasteleria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(964, 736);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmPasteleria";
			this.Text = "PASTELERIA";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
	}
}
