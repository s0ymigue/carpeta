/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 23/10/2024
 * Time: 08:12 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rfcc
{
	partial class RFC
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
			this.LBLNAME = new System.Windows.Forms.Label();
			this.LBLRFC = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "TU NOMBRE ES:";
			// 
			// LBLNAME
			// 
			this.LBLNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLNAME.Location = new System.Drawing.Point(124, 70);
			this.LBLNAME.Name = "LBLNAME";
			this.LBLNAME.Size = new System.Drawing.Size(108, 25);
			this.LBLNAME.TabIndex = 1;
			this.LBLNAME.Text = "****";
			// 
			// LBLRFC
			// 
			this.LBLRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLRFC.Location = new System.Drawing.Point(124, 182);
			this.LBLRFC.Name = "LBLRFC";
			this.LBLRFC.Size = new System.Drawing.Size(86, 36);
			this.LBLRFC.TabIndex = 3;
			this.LBLRFC.Text = "label3";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(239, 28);
			this.label4.TabIndex = 2;
			this.label4.Text = "TU RFC ES:";
			// 
			// RFC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 323);
			this.Controls.Add(this.LBLRFC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LBLNAME);
			this.Controls.Add(this.label1);
			this.Name = "RFC";
			this.Text = "RFC";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LBLRFC;
		private System.Windows.Forms.Label LBLNAME;
		private System.Windows.Forms.Label label1;
	}
}
