/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 23/10/2024
 * Time: 08:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace rfcc
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public string rfc, nombre;
		
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
		
		
		void Form1Load(object sender, EventArgs e)
		{
			LBLNAME.Text=nombre;
			LBLRFC.Text=rfc;
		}
	}
}
