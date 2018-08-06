using ClienteWcfData.ServiceReference1;
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
	public partial class Form2 : Form
	{
		public event EventHandler AlumnoAdded;
		public Form2()
		{
			InitializeComponent();
		}

		public void button1_Click(object sender, EventArgs e)
		{
			Alumno alumno = new Alumno();
			alumno.Nombre = textBox1.Text;
			alumno.Apellidos = textBox2.Text;
			Service1Client svc = new Service1Client("TCP");
			svc.Add(alumno);
			AlumnoAdded(this, e);
			Close();
		}
	}
}
