/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 27/10/2026
 * Hora: 07:53 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Git_hub
{
	partial class Form1
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(33, 35);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(100, 23);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Valor a:";
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(33, 68);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(100, 23);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Valor b:";
			// 
			// lblC
			// 
			this.lblC.Location = new System.Drawing.Point(33, 106);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(100, 23);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "Valor c:";
			// 
			// txtA
			// 
			this.txtA.AcceptsReturn = true;
			this.txtA.Location = new System.Drawing.Point(148, 35);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 22);
			this.txtA.TabIndex = 3;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(148, 68);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 22);
			this.txtB.TabIndex = 4;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(148, 103);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(317, 34);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(106, 56);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblX1
			// 
			this.lblX1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblX1.Location = new System.Drawing.Point(65, 165);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(140, 78);
			this.lblX1.TabIndex = 7;
			// 
			// lblX2
			// 
			this.lblX2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblX2.Location = new System.Drawing.Point(256, 165);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(140, 78);
			this.lblX2.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 272);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblA;
	}
}
