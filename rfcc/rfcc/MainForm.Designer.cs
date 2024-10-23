/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 23/10/2024
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rfcc
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
			this.mt_nacimiento = new System.Windows.Forms.MonthCalendar();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtap2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtap1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.btncrear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mt_nacimiento
			// 
			this.mt_nacimiento.Location = new System.Drawing.Point(121, 195);
			this.mt_nacimiento.Name = "mt_nacimiento";
			this.mt_nacimiento.TabIndex = 26;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(4, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Fecha de Nacimiento";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Direccion";
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(179, 163);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(108, 20);
			this.txtdireccion.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "Telefono";
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(179, 131);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(108, 20);
			this.txttelefono.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 23);
			this.label3.TabIndex = 20;
			this.label3.Text = "Apellido Materno";
			// 
			// txtap2
			// 
			this.txtap2.Location = new System.Drawing.Point(179, 99);
			this.txtap2.Name = "txtap2";
			this.txtap2.Size = new System.Drawing.Size(108, 20);
			this.txtap2.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Apellido Paterno";
			// 
			// txtap1
			// 
			this.txtap1.Location = new System.Drawing.Point(179, 67);
			this.txtap1.Name = "txtap1";
			this.txtap1.Size = new System.Drawing.Size(108, 20);
			this.txtap1.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Nombre";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(179, 34);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(108, 20);
			this.txtnombre.TabIndex = 15;
			// 
			// btncrear
			// 
			this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncrear.Location = new System.Drawing.Point(121, 389);
			this.btncrear.Name = "btncrear";
			this.btncrear.Size = new System.Drawing.Size(138, 34);
			this.btncrear.TabIndex = 14;
			this.btncrear.Text = "Crear";
			this.btncrear.UseVisualStyleBackColor = true;
			this.btncrear.Click += new System.EventHandler(this.BtncrearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 435);
			this.Controls.Add(this.mt_nacimiento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtap2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtap1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.btncrear);
			this.Name = "MainForm";
			this.Text = "rfcc";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btncrear;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtap1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtap2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MonthCalendar mt_nacimiento;
	}
}
