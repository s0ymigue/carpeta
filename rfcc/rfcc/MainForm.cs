/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 23/10/2024
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rfcc
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
		
		void BtncrearClick(object sender, EventArgs e)
		{
			string nombre=txtnombre.Text;
			string apellido1=txtap1.Text;
			string apellido2=txtap2.Text;
			string letrasapellido1=apellido1.Substring(0,2);
			string letrasapellido2=apellido2.Substring(0,1);
			string letranombre=nombre.Substring(0,1);
			DateTime fechas=mt_nacimiento.SelectionStart;
			int año = fechas.Year;
			string sifrasaño = (año%100).ToString("00");
			DateTime mesito=mt_nacimiento.SelectionStart;
			int mes = mesito.Month;
			DateTime diaa = mt_nacimiento.SelectionStart;
			int dia=diaa.Day;
			string messtring=mes.ToString("00");
			string diastring=dia.ToString("00");
			string rfc = letrasapellido1 + letrasapellido2 + letranombre + sifrasaño + messtring + diastring;
			MessageBox.Show(rfc);
		}
	}
}
