/*
 * Created by SharpDevelop.
 * User: Leandro
 * Date: 25/9/2022
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace windowsForm
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
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.Boton = new System.Windows.Forms.Button();
			this.monedas = new System.Windows.Forms.ComboBox();
			this.monto = new System.Windows.Forms.Label();
			this.cambio = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TotalC = new System.Windows.Forms.TextBox();
			this.Total = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxA
			// 
			this.textBoxA.Location = new System.Drawing.Point(151, 38);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(100, 20);
			this.textBoxA.TabIndex = 0;
			this.textBoxA.Click += new System.EventHandler(this.MainFormLoad);
			this.textBoxA.TextChanged += new System.EventHandler(this.MainFormLoad);
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(151, 78);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(100, 20);
			this.textBoxB.TabIndex = 1;
			// 
			// Boton
			// 
			this.Boton.Location = new System.Drawing.Point(92, 203);
			this.Boton.Name = "Boton";
			this.Boton.Size = new System.Drawing.Size(75, 23);
			this.Boton.TabIndex = 2;
			this.Boton.Text = "OK";
			this.Boton.UseVisualStyleBackColor = true;
			this.Boton.Click += new System.EventHandler(this.BotonClick);
			// 
			// monedas
			// 
			this.monedas.FormattingEnabled = true;
			this.monedas.Items.AddRange(new object[] {
									"Dolar.",
									"Euro.",
									"Real.",
									"Libra.",
									"Peso Uruguayo."});
			this.monedas.Location = new System.Drawing.Point(171, 119);
			this.monedas.Name = "monedas";
			this.monedas.Size = new System.Drawing.Size(80, 21);
			this.monedas.TabIndex = 3;
			// 
			// monto
			// 
			this.monto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monto.Location = new System.Drawing.Point(56, 38);
			this.monto.Name = "monto";
			this.monto.Size = new System.Drawing.Size(74, 23);
			this.monto.TabIndex = 5;
			this.monto.Text = "Monto $";
			// 
			// cambio
			// 
			this.cambio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cambio.Location = new System.Drawing.Point(30, 78);
			this.cambio.Name = "cambio";
			this.cambio.Size = new System.Drawing.Size(100, 23);
			this.cambio.TabIndex = 6;
			this.cambio.Text = "Valor Cambio";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Moneda Cant. billetes";
			this.label1.Click += new System.EventHandler(this.MainFormLoad);
			// 
			// TotalC
			// 
			this.TotalC.Location = new System.Drawing.Point(151, 166);
			this.TotalC.Name = "TotalC";
			this.TotalC.Size = new System.Drawing.Size(100, 20);
			this.TotalC.TabIndex = 8;
			this.TotalC.Click += new System.EventHandler(this.MainFormLoad);
			this.TotalC.TextChanged += new System.EventHandler(this.MainFormLoad);
			// 
			// Total
			// 
			this.Total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total.Location = new System.Drawing.Point(81, 166);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(64, 23);
			this.Total.TabIndex = 9;
			this.Total.Text = "Total";
			this.Total.Click += new System.EventHandler(this.MainFormLoad);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(304, 272);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.TotalC);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cambio);
			this.Controls.Add(this.monto);
			this.Controls.Add(this.monedas);
			this.Controls.Add(this.Boton);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxA);
			this.Name = "MainForm";
			this.Text = "windowsForm";
			this.TextChanged += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label Total;
		private System.Windows.Forms.TextBox TotalC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label cambio;
		private System.Windows.Forms.Label monto;
		private System.Windows.Forms.ComboBox monedas;
		private System.Windows.Forms.Button Boton;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxA;
		
	
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
