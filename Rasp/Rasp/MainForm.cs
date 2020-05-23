/*
 * Created by SharpDevelop.
 * User: Игорек
 * Date: 07.05.2020
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rasp
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 fr1 = new Form1();
			fr1.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form2 fr2 = new Form2();
			fr2.Show();
			Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form3 fr3 = new Form3();
			fr3.Show();
			Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			MessageBoxButtons msb = MessageBoxButtons.YesNo;
    String message = "Вы действительно хотите выйти?";
    String caption = "Выход";
    if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
        Application.Exit();

		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			MessageBoxButtons msb = MessageBoxButtons.YesNo;
    String message = "Вы действительно хотите выйти?";
    String caption = "Выход";
    if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
        Application.Exit();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			Form2 fr2 = new Form2();
			fr2.Show();
			Hide();
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			Form1 fr1 = new Form1();
			fr1.Show();
			Hide();
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			Form3 fr3 = new Form3();
			fr3.Show();
			Hide();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
	}
}
