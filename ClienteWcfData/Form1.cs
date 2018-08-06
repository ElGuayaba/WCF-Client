using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWcfData
{
	public partial class Form1 : Form
	{
		Form2 form;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			form = new Form2();
			form.AlumnoAdded += new EventHandler(this.button3_Click);
			form.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client("HTTP");
			List<ServiceReference1.Alumno> listaAlumnos = svc.GetAll();
			dgvAlumno.DataSource = listaAlumnos;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client("TCP");
			List<ServiceReference1.Alumno> listaAlumnos = svc.GetAll();
			dgvAlumno.DataSource = listaAlumnos;
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
