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
			this.cbProducto = new System.Windows.Forms.ComboBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lvTabla = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
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
			// cbProducto
			// 
			this.cbProducto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProducto.FormattingEnabled = true;
			this.cbProducto.Items.AddRange(new object[] {
									"",
									"PRODUCTO1",
									"PRODUCTO2",
									"PRODUCTO3",
									"PRODUCTO4"});
			this.cbProducto.Location = new System.Drawing.Point(318, 219);
			this.cbProducto.Name = "cbProducto";
			this.cbProducto.Size = new System.Drawing.Size(213, 29);
			this.cbProducto.TabIndex = 3;
			this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.CbProductoSelectedIndexChanged);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(687, 194);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(239, 45);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "AGREGAR PRODUCTO";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(687, 281);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(239, 45);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "ELEMINAR PRODUCTO";
			this.btnEliminar.UseVisualStyleBackColor = true;
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
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(26, 304);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 22);
			this.txtPrecio.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label3.Location = new System.Drawing.Point(175, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 32);
			this.label3.TabIndex = 8;
			this.label3.Text = "CANTIDAD";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(175, 304);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 9;
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
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(318, 304);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 11;
			// 
			// lvTabla
			// 
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.lvTabla.Location = new System.Drawing.Point(31, 397);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(895, 154);
			this.lvTabla.TabIndex = 12;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
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
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(158, 601);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
			this.txtSubtotal.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label6.Location = new System.Drawing.Point(284, 595);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 32);
			this.label6.TabIndex = 15;
			this.label6.Text = "DESCUENTO";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(417, 601);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(136, 22);
			this.txtDescuento.TabIndex = 16;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(96, 662);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(126, 45);
			this.btnGuardar.TabIndex = 17;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(292, 662);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(126, 45);
			this.btnBorrar.TabIndex = 18;
			this.btnBorrar.Text = "BORRAR";
			this.btnBorrar.UseVisualStyleBackColor = true;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(473, 662);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(126, 45);
			this.btnImprimir.TabIndex = 19;
			this.btnImprimir.Text = "IMPRIMIR";
			this.btnImprimir.UseVisualStyleBackColor = true;
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
			// txtNeto
			// 
			this.txtNeto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNeto.Location = new System.Drawing.Point(747, 581);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.Size = new System.Drawing.Size(163, 28);
			this.txtNeto.TabIndex = 21;
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
			// txtPagado
			// 
			this.txtPagado.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPagado.Location = new System.Drawing.Point(763, 622);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(163, 28);
			this.txtPagado.TabIndex = 24;
			// 
			// txtCambio
			// 
			this.txtCambio.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCambio.Location = new System.Drawing.Point(704, 662);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(163, 28);
			this.txtCambio.TabIndex = 25;
			// 
			// frmPasteleria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(964, 736);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.txtPagado);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.cbProducto);
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
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvTabla;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.ComboBox cbProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
	}
}
