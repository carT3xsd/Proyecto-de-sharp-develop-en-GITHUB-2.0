/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 27/10/2026
 * Hora: 07:53 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Git_hub
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);
			
			double discriminante = (b * b) - (4 * a * c);
			
			if (discriminante >= 0) 
			{
			    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
			    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
			    lblX1.Text = "X1 = " + x1.ToString();
			    lblX2.Text = "X2 = " + x2.ToString();
			} 
			else
			{
			    lblX1.Text = "Raíces imaginarias";
			    lblX2.Text = "";
			}
		}
	}
}
