/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 13/12/2025
 * Hora: 07:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOFINALESCOLAR
{
	/// <summary>
	/// Description of BoletaCalificacion.
	/// </summary>
	public partial class BoletaCalificacion : Form
	{
		public BoletaCalificacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
		MessageBox.Show("Ponga su nombre!!...");
		else if(cbClase.SelectedIndex == -1)
		MessageBox.Show("Debe Seleccionar la asignatura ....! !");
		else if(cbEspecialidad.SelectedIndex == -1)
		MessageBox.Show("Selecciona Especialidad....! !");
		else if(cbGrado.SelectedIndex == -1)
		MessageBox.Show("Selecciona Grado....! !");
		else if (txtPar1.Text == "0")
		MessageBox.Show("Coloque la calificación del parcial 1");
		else if (txtPar2.Text == "0")
		MessageBox.Show("Coloque la calificación del parcial 2");
		else if (txtPar3.Text == "0")
		MessageBox.Show("Coloque la calificación del parcial 3");
		else{
		string Asignatura = cbClase.Text;
		double ParcialUno = Convert.ToDouble(txtPar1.Text);
		double ParcialDos = Convert.ToDouble(txtPar2.Text);
		double ParcialTres = Convert.ToDouble(txtPar3.Text);
		double Promedio = (ParcialUno + ParcialDos + ParcialTres) / 3;
		string Aprovacion;

		if(Promedio < 6)
		Aprovacion = "Reprobado";
		else
		Aprovacion = "Aprovado";
		ListViewItem fila= new ListViewItem(Asignatura);
		fila.SubItems.Add(ParcialUno.ToString());
		fila.SubItems.Add(ParcialDos.ToString());
		fila.SubItems.Add(ParcialTres.ToString());
		fila.SubItems.Add(Promedio.ToString());
		fila.SubItems.Add(Aprovacion);
		lvLista.Items.Add(fila);
		BtnCancelarClick(sender, e);
	}
}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			cbEspecialidad.Text = " ";
			txtPar1.Text = "0";
			txtPar2.Text = "0";
			txtPar3.Text = "0";
		}
}
}