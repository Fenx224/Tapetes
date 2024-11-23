/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 21/11/2024
 * Time: 07:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tapetes_pre
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
			this.label1 = new System.Windows.Forms.Label();
			this.TXTh = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TXTL = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.FloresSi = new System.Windows.Forms.CheckBox();
			this.FloresNo = new System.Windows.Forms.CheckBox();
			this.CuantasFlores = new System.Windows.Forms.Label();
			this.TXTCuantasFlores = new System.Windows.Forms.TextBox();
			this.TXTFrutos = new System.Windows.Forms.TextBox();
			this.LBLFrutos = new System.Windows.Forms.Label();
			this.FrutosNo = new System.Windows.Forms.CheckBox();
			this.FrutosSi = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TXTagua = new System.Windows.Forms.TextBox();
			this.TXTpint = new System.Windows.Forms.TextBox();
			this.TXThrs = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TXTpp = new System.Windows.Forms.TextBox();
			this.BTNcalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(136, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tamaño";
			// 
			// TXTh
			// 
			this.TXTh.BackColor = System.Drawing.Color.White;
			this.TXTh.Location = new System.Drawing.Point(223, 78);
			this.TXTh.Name = "TXTh";
			this.TXTh.Size = new System.Drawing.Size(134, 22);
			this.TXTh.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(377, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "x";
			// 
			// TXTL
			// 
			this.TXTL.Location = new System.Drawing.Point(409, 78);
			this.TXTL.Name = "TXTL";
			this.TXTL.Size = new System.Drawing.Size(134, 22);
			this.TXTL.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(298, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Datos del tapete";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(41, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cuantas personas participaran";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(41, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(197, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "¿Usaras flores en tu tapete?";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(41, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "¿Usaras frutos secos?";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(41, 324);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(253, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "¿Cuantos litros de agua piensas usar?";
			// 
			// FloresSi
			// 
			this.FloresSi.Location = new System.Drawing.Point(244, 220);
			this.FloresSi.Name = "FloresSi";
			this.FloresSi.Size = new System.Drawing.Size(50, 24);
			this.FloresSi.TabIndex = 11;
			this.FloresSi.Text = "Si";
			this.FloresSi.UseVisualStyleBackColor = true;
			this.FloresSi.CheckedChanged += new System.EventHandler(this.FloresSiCheckedChanged);
			// 
			// FloresNo
			// 
			this.FloresNo.Location = new System.Drawing.Point(300, 220);
			this.FloresNo.Name = "FloresNo";
			this.FloresNo.Size = new System.Drawing.Size(56, 24);
			this.FloresNo.TabIndex = 12;
			this.FloresNo.Text = "No";
			this.FloresNo.UseVisualStyleBackColor = true;
			// 
			// CuantasFlores
			// 
			this.CuantasFlores.Location = new System.Drawing.Point(383, 223);
			this.CuantasFlores.Name = "CuantasFlores";
			this.CuantasFlores.Size = new System.Drawing.Size(133, 23);
			this.CuantasFlores.TabIndex = 13;
			this.CuantasFlores.Text = "¿Cuantas usaras?";
			this.CuantasFlores.Visible = false;
			// 
			// TXTCuantasFlores
			// 
			this.TXTCuantasFlores.Location = new System.Drawing.Point(522, 220);
			this.TXTCuantasFlores.Name = "TXTCuantasFlores";
			this.TXTCuantasFlores.Size = new System.Drawing.Size(100, 22);
			this.TXTCuantasFlores.TabIndex = 14;
			this.TXTCuantasFlores.Visible = false;
			// 
			// TXTFrutos
			// 
			this.TXTFrutos.Location = new System.Drawing.Point(522, 271);
			this.TXTFrutos.Name = "TXTFrutos";
			this.TXTFrutos.Size = new System.Drawing.Size(100, 22);
			this.TXTFrutos.TabIndex = 18;
			this.TXTFrutos.Visible = false;
			// 
			// LBLFrutos
			// 
			this.LBLFrutos.Location = new System.Drawing.Point(383, 274);
			this.LBLFrutos.Name = "LBLFrutos";
			this.LBLFrutos.Size = new System.Drawing.Size(133, 23);
			this.LBLFrutos.TabIndex = 17;
			this.LBLFrutos.Text = "¿Cuantos kilos?";
			this.LBLFrutos.Visible = false;
			// 
			// FrutosNo
			// 
			this.FrutosNo.Location = new System.Drawing.Point(300, 271);
			this.FrutosNo.Name = "FrutosNo";
			this.FrutosNo.Size = new System.Drawing.Size(56, 24);
			this.FrutosNo.TabIndex = 16;
			this.FrutosNo.Text = "No";
			this.FrutosNo.UseVisualStyleBackColor = true;
			// 
			// FrutosSi
			// 
			this.FrutosSi.Location = new System.Drawing.Point(244, 271);
			this.FrutosSi.Name = "FrutosSi";
			this.FrutosSi.Size = new System.Drawing.Size(50, 24);
			this.FrutosSi.TabIndex = 15;
			this.FrutosSi.Text = "Si";
			this.FrutosSi.UseVisualStyleBackColor = true;
			this.FrutosSi.CheckedChanged += new System.EventHandler(this.FrutosSiCheckedChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(41, 369);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(275, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "¿Cuantos litros de pintura piensas usar?";
			// 
			// TXTagua
			// 
			this.TXTagua.Location = new System.Drawing.Point(333, 324);
			this.TXTagua.Name = "TXTagua";
			this.TXTagua.Size = new System.Drawing.Size(100, 22);
			this.TXTagua.TabIndex = 20;
			// 
			// TXTpint
			// 
			this.TXTpint.Location = new System.Drawing.Point(333, 366);
			this.TXTpint.Name = "TXTpint";
			this.TXTpint.Size = new System.Drawing.Size(100, 22);
			this.TXTpint.TabIndex = 21;
			// 
			// TXThrs
			// 
			this.TXThrs.Location = new System.Drawing.Point(333, 177);
			this.TXThrs.Name = "TXThrs";
			this.TXThrs.Size = new System.Drawing.Size(100, 22);
			this.TXThrs.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(41, 177);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(253, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "¿Cuantas horas de trabajo seran?";
			// 
			// TXTpp
			// 
			this.TXTpp.Location = new System.Drawing.Point(333, 135);
			this.TXTpp.Name = "TXTpp";
			this.TXTpp.Size = new System.Drawing.Size(100, 22);
			this.TXTpp.TabIndex = 24;
			// 
			// BTNcalcular
			// 
			this.BTNcalcular.Location = new System.Drawing.Point(319, 489);
			this.BTNcalcular.Name = "BTNcalcular";
			this.BTNcalcular.Size = new System.Drawing.Size(84, 23);
			this.BTNcalcular.TabIndex = 25;
			this.BTNcalcular.Text = "Calcular";
			this.BTNcalcular.UseVisualStyleBackColor = true;
			this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(720, 524);
			this.Controls.Add(this.BTNcalcular);
			this.Controls.Add(this.TXTpp);
			this.Controls.Add(this.TXThrs);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.TXTpint);
			this.Controls.Add(this.TXTagua);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.TXTFrutos);
			this.Controls.Add(this.LBLFrutos);
			this.Controls.Add(this.FrutosNo);
			this.Controls.Add(this.FrutosSi);
			this.Controls.Add(this.TXTCuantasFlores);
			this.Controls.Add(this.CuantasFlores);
			this.Controls.Add(this.FloresNo);
			this.Controls.Add(this.FloresSi);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TXTL);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TXTh);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tapetes_pre";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BTNcalcular;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TXThrs;
		private System.Windows.Forms.TextBox TXTpint;
		private System.Windows.Forms.TextBox TXTagua;
		private System.Windows.Forms.CheckBox FrutosSi;
		private System.Windows.Forms.CheckBox FrutosNo;
		private System.Windows.Forms.Label LBLFrutos;
		private System.Windows.Forms.TextBox TXTFrutos;
		private System.Windows.Forms.TextBox TXTCuantasFlores;
		private System.Windows.Forms.Label CuantasFlores;
		private System.Windows.Forms.CheckBox FloresNo;
		private System.Windows.Forms.CheckBox FloresSi;
		private System.Windows.Forms.TextBox TXTpp;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXTL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXTh;
		private System.Windows.Forms.Label label1;
	}
}
