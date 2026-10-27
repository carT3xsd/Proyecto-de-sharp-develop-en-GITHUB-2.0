/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 27/10/2026
 * Hora: 07:31 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Git_hub
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double Num1 = Convert.ToDouble(txtNum1.Text);
		    double Num2 = Convert.ToDouble(txtNum2.Text);
		    double resultado = Num1 + Num2;
		    lblResultado.Text = "Resultado: " + resultado.ToString();
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double Num1 = Convert.ToDouble(txtNum1.Text);
		    double Num2 = Convert.ToDouble(txtNum2.Text);
		    double resultado = Num1 - Num2;
		    lblResultado.Text = "Resultado: " + resultado.ToString();
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double Num1 = Convert.ToDouble(txtNum1.Text);
		    double Num2 = Convert.ToDouble(txtNum2.Text);
		    double resultado = Num1 * Num2;
		    lblResultado.Text = "Resultado: " + resultado.ToString();
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double Num1 = Convert.ToDouble(txtNum1.Text);
		    double Num2 = Convert.ToDouble(txtNum2.Text);
		    double resultado = Num1 / Num2;
		    lblResultado.Text = "Resultado: " + resultado.ToString();
		}
		
		void BtnResiduoClick(object sender, EventArgs e)
		{
			double Num1 = Convert.ToDouble(txtNum1.Text);
			double Num2 = Convert.ToDouble(txtNum2.Text);
			double resultado = Num1 % Num2;
			labelResultado.Text = "Módulo: " + resultado.ToString();
		}
	}
}
