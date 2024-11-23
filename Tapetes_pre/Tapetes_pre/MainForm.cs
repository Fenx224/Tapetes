/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 21/11/2024
 * Time: 07:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes_pre
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
		
		int personas = 0, horas = 0, flores = 0, frutos = 0, agua = 0, pintura = 0, alto = 0, largo = 0, m2 = 0;
		double personasp = 0, floresp = 0, frutosp = 0, aguap = 0, pinturap = 0, aserrin = 0, total = 0;
		string pers = "0", hora = "0", flor = "0", frut = "0", water = "0", paint = "0", alt = "0", lar = "0";
		
		void FloresSiCheckedChanged(object sender, EventArgs e)
		{
			if(FloresSi.Checked)
			{
				CuantasFlores.Visible = true;
				TXTCuantasFlores.Visible = true;
			}
			else
			{
				CuantasFlores.Visible = false;
				TXTCuantasFlores.Visible = false;
				TXTCuantasFlores.Text="0";
			}
		}
		
		void FrutosSiCheckedChanged(object sender, EventArgs e)
		{
			if(FloresSi.Checked)
			{
				LBLFrutos.Visible = true;
				TXTFrutos.Visible = true;
				flor = TXTCuantasFlores.Text;
			}
			else
			{
				LBLFrutos.Visible = false;
				TXTFrutos.Visible = false;
				TXTFrutos.Text="0";
				frut = TXTFrutos.Text;
			}
		}
		
		void BTNcalcularClick(object sender, EventArgs e)
		{
			Precios pre = new Precios();
			pers = TXTpp.Text;
			hora = TXThrs.Text;
			water = TXTagua.Text;
			paint = TXTpint.Text;
			alt = TXTh.Text;
			lar = TXTL.Text;
			alto = int.Parse(alt);
			largo = int.Parse(lar);
			m2 = alto * largo;
			personas = int.Parse(pers);
			horas = int.Parse(hora);
			flores = int.Parse(flor);
			frutos = int.Parse(frut);
			agua = int.Parse(water);
			pintura = int.Parse(paint);
			aserrin = (m2 * 0.75)*74;
			personasp = personas*horas*43;
			floresp = flores*30;
			frutosp = frutos*178;
			aguap = agua*10.13;
			pinturap = pintura*235.93;
			total=personasp+floresp+frutosp+aguap+pinturap;
			pre.LBLm2.Text=m2.ToString();
			pre.LBLmano.Text=personasp.ToString();
			pre.LBLaguap.Text=aguap.ToString();
			pre.LBLfloresp.Text=floresp.ToString();
			pre.LBLaserrin.Text=aserrin.ToString();
			pre.LBLpinturap.Text=pinturap.ToString();
			pre.LBLfrutosp.Text=frutosp.ToString();
			pre.LBLtotal.Text=total.ToString();
			pre.Show();
			this.Hide();
		}
	}
}
