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
		Form2 Form2Add;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2Add = new Form2();
			//Form2Add.button1.Click += new EventHandler(this.button3_Click);
			Form2Add.AlumnoAdded += new EventHandler(this.button3_Click);
			Form2Add.Show();
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
