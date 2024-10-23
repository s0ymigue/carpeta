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
			//DELCARA UNA VARIABLE EN FORMA STRIN QUE SUSTITUIRA Y SERA EL VALOR DE EL TEXTBOX DEL PRIMER NOMBRE
			string nombre=txtnombre.Text;
			//DELCARA UNA VARIABLE EN FORMA STRIN QUE SUSTITUIRA Y SERA EL VALOR DE EL TEXTBOX DEL APELLIDO PATERNO
			string apellido1=txtap1.Text;
			//DELCARA UNA VARIABLE EN FORMA STRIN QUE SUSTITUIRA Y SERA EL VALOR DE EL TEXTBOX DEL APELLIDO MATERNO
			string apellido2=txtap2.Text;
			//VARIABLE QUE DIVIDIRA LAS LETRAS Y TE DATA SOLO LAS INDICADAS DEL APELLIDO APETERNO(EN ESTE CASO SERAN LAS DOS PRIMERAS LETRAS)
			string letrasapellido1=apellido1.Substring(0,2);
			//VARIABLE QUE DIVIDIRA LAS LETRAS Y TE DATA SOLO LAS INDICADAS DEL APELLIDO APETERNO(EN ESTE CASO SERA LA PRIMERA LETRA DEL APELLIDO PATERNO)
			string letrasapellido2=apellido2.Substring(0,1);
			//CREA UNA VARIABLE DE MODO STRING QUE SUSTUIRA LAS VARIABLE DEL TEXTBOX DEL NOMBRE Y SOLAMENTE AGARRARA LA PRIMERA LETRA 
			string letranombre=nombre.Substring(0,1);
			//ESTO SIRVE PARA SUSTITUIR LAS VARIABLES DEL CALENDARIO PUESTO EN EL DESING
			DateTime fechas=mt_nacimiento.SelectionStart;
			//DELCARA UNA VARIABLE NUMERICA QUE SUSTITUIURA LOS
			int año = fechas.Year;
			//DIVIDE EL AÑO ENTRE 100 Y ESPECIFICA QUE SOLO QUE SOLO QUIERE DOS NUMEROS
			string sifrasaño = (año%100).ToString("00");
			//DELCARAR UNA VARIABLE QUE SOLO SIRVE PARA FECHAS
			DateTime mesito=mt_nacimiento.SelectionStart;
			//DECLARAR LA VARIABLE NUEMRICA QUE SUSTITUIRA LA ANTERIO VARIABLE
			int mes = mesito.Month;
			//DELCARAR UNA VARIABLE QUE SOLO SIRVE PARA FECHAS
			DateTime diaa = mt_nacimiento.SelectionStart;
			//DECLARAR LA VARIABLE NUEMRICA QUE SUSTITUIRA LA ANTERIO VARIABLE MASTRANDO QUE ESTAS HABLANDO DE DIA CON .DIA
			int dia=diaa.Day;
			//DECLARAR LAS VARIABLES CON SOLO DOAS DIGITOS ESCEPTO LA VARIABLE DIA POR QUE ESTA YA ESTA EN DOS DIGITOS
			string messtring=mes.ToString("00");
			string diastring=dia.ToString("00");
			string rfc = letrasapellido1 + letrasapellido2 + letranombre + sifrasaño + messtring + diastring;
			string nombre_completo= txtnombre + txtap1 + txtap2;
			RFC form1 = new RFC();
			form1.Show();
		}
	}
}
