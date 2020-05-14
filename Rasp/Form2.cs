/*
 * Created by SharpDevelop.
 * User: Игорек
 * Date: 07.05.2020
 * Time: 20:42
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Combo();
			Combo2();
			Combo5();
			Combo3();
			Combo4();
			Combo6();
			Combo7();
			Combo8();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		


		
		void Button2Click(object sender, EventArgs e)
		{
			MainForm fr0 = new MainForm();
			fr0.Show();
			Hide();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 fr3 = new Form3();
			fr3.Show();
			Hide();
			
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox2.Text) || String.IsNullOrEmpty(comboBox5.Text)|| String.IsNullOrEmpty(comboBox3.Text)|| String.IsNullOrEmpty(comboBox4.Text)|| String.IsNullOrEmpty(comboBox6.Text)|| String.IsNullOrEmpty(comboBox7.Text)|| String.IsNullOrEmpty(comboBox8.Text))
            {
                MessageBox.Show("Заполните все строки");
            }
            else
            {
                string query = "INSERT INTO tablica (otdel, begin, end, kurs, grup, discip, prepod, audit) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox5.Text + "','" + comboBox3.Text +"','" + comboBox4.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Расписание сохранено");
                    databaseConnection.Close();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox5.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox6.Text = "";
                    comboBox7.Text = "";
                    comboBox8.Text = "";
                    
                  
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		private void Combo() ///Отделение
		{
			string query = "SELECT DISTINCT nameotdel FROM otdelenie";
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
                    string nameotdel = reader.GetString(0);
                    comboBox1.Items.Add(nameotdel);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo2() ///Дата и время
		{
			string query = "SELECT DISTINCT begin FROM time";
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
                	
                    string begin = reader.GetString(0);
                    comboBox2.Items.Add(begin);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo5() ///Дата и время конец
		{
			string query = "SELECT DISTINCT end FROM time";
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
                	
                    string end = reader.GetString(0);
                    comboBox5.Items.Add(end);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
				
		private void Combo3() ///курс
		{
			string query = "SELECT DISTINCT number FROM kurs";
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
                	
                    string number = reader.GetString(0);
                    comboBox3.Items.Add(number);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo4() ///группа
		{
			string query = "SELECT DISTINCT num FROM grup";
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
                	
                    string num = reader.GetString(0);
                    comboBox4.Items.Add(num);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo6() ///дисциплина
		{
			string query = "SELECT DISTINCT name FROM disciplina";
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
                	
                    string name = reader.GetString(0);
                    comboBox6.Items.Add(name);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo7() ///преподаватель
		{
			string query = "SELECT DISTINCT fio FROM prepod";
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
                	
                    string fio = reader.GetString(0);
                    comboBox7.Items.Add(fio);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		private void Combo8() ///аудитория
		{
			string query = "SELECT DISTINCT num FROM audit";
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
                	
                    string num = reader.GetString(0);
                    comboBox8.Items.Add(num);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form3 fr3 = new Form3();
					fr3.Show();
					Hide();
		}
	}
}
