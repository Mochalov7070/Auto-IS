/*
 * Created by SharpDevelop.
 * User: Игорек
 * Date: 07.05.2020
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Rasp
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm fr0 = new MainForm();
			fr0.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			string query = "SELECT id, otdel, begin, end, kurs, grup, discip, prepod, audit FROM tablica;";
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
           
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                	string id = reader.GetString(0);
                	string otdel = reader.GetString(1);
                	string begin = reader.GetString(2);
                	string end = reader.GetString(3);
                	string kurs = reader.GetString(4);
                	string grup = reader.GetString(5);
                	string discip = reader.GetString(6);
                	string prepod = reader.GetString(7);
                	string audit = reader.GetString(8);
                	
                    dataGridView1.Rows.Add(id, otdel, begin, end, kurs, grup, discip, prepod, audit);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			MainForm fr0 = new MainForm();
			fr0.Show();
			Hide();
		}
	}
}
