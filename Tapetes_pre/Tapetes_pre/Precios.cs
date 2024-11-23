/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 22/11/2024
 * Time: 07:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes_pre
{
	/// <summary>
	/// Description of Precios.
	/// </summary>
	public partial class Precios : Form
	{
		public Precios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BTNBackClick(object sender, EventArgs e)
		{
			MainForm menu = new MainForm();
			menu.Show();
			Close();
		}
		
		void BTNfinishClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
