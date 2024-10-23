/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 23/10/2024
 * Time: 08:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rfcc
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
			this.LBLRFC = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LBLNAME = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LBLRFC
			// 
			this.LBLRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLRFC.Location = new System.Drawing.Point(86, 189);
			this.LBLRFC.Name = "LBLRFC";
			this.LBLRFC.Size = new System.Drawing.Size(86, 36);
			this.LBLRFC.TabIndex = 7;
			this.LBLRFC.Text = "####";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(239, 28);
			this.label4.TabIndex = 6;
			this.label4.Text = "TU RFC ES:";
			// 
			// LBLNAME
			// 
			this.LBLNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLNAME.Location = new System.Drawing.Point(86, 77);
			this.LBLNAME.Name = "LBLNAME";
			this.LBLNAME.Size = new System.Drawing.Size(108, 25);
			this.LBLNAME.TabIndex = 5;
			this.LBLNAME.Text = "****";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "TU NOMBRE ES:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.LBLRFC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LBLNAME);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LBLNAME;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LBLRFC;
	}
}
