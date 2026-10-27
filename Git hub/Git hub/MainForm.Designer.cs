/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 27/10/2026
 * Hora: 07:31 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Git_hub
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnResiduo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Num 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Num 2:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(134, 35);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 22);
			this.txtNum1.TabIndex = 3;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(134, 67);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 22);
			this.txtNum2.TabIndex = 4;
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(241, 33);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(94, 37);
			this.btnSumar.TabIndex = 5;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(354, 35);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(94, 37);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(241, 76);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(94, 37);
			this.btnMultiplicar.TabIndex = 7;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(354, 76);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(94, 37);
			this.btnDividir.TabIndex = 8;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblResultado.Location = new System.Drawing.Point(46, 135);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(164, 53);
			this.lblResultado.TabIndex = 9;
			// 
			// btnResiduo
			// 
			this.btnResiduo.Location = new System.Drawing.Point(241, 119);
			this.btnResiduo.Name = "btnResiduo";
			this.btnResiduo.Size = new System.Drawing.Size(94, 37);
			this.btnResiduo.TabIndex = 10;
			this.btnResiduo.Text = "Residuo";
			this.btnResiduo.UseVisualStyleBackColor = true;
			this.btnResiduo.Click += new System.EventHandler(this.BtnResiduoClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(354, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 56);
			this.button1.TabIndex = 11;
			this.button1.Text = "Ir a Formula general";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(485, 256);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnResiduo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Git hub";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnResiduo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
