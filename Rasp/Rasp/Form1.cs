/*
 * Created by SharpDevelop.
 * User: Игорек
 * Date: 07.05.2020
 * Time: 19:44
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
	/// Description of Form1.
	/// </summary>
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
//			Combo();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "dd MMMM yyyyy hh:mm";
			
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "dd MMMM yyyyy hh:mm";
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";
		}
		
	 
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm fr0 = new MainForm();
			fr0.Show();
			Hide();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e) ///Преподаватели
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введите ФИО и Должность");
            }
            else
            {
                string query = "INSERT INTO prepod (fio, doljnost) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Преподаватель добавлен в базу данных");
                    databaseConnection.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button6Click(object sender, EventArgs e) ///Дисциплины
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите название Дисциплины");
            }
            else
            {
                string query = "INSERT INTO disciplina (name) VALUES ('" + textBox5.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Дисциплина добавлена в базу данных");
                    databaseConnection.Close();
                    textBox5.Text = "";
                  
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button2Click(object sender, EventArgs e) ///Отделения
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Введите номер Отделения");
            }
            else
            {
                string query = "INSERT INTO otdelenie (nameotdel) VALUES ('" + textBox4.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Отделение добавлено в базу данных");
                    databaseConnection.Close();
                    textBox4.Text = "";
                  
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button12Click(object sender, EventArgs e) ///Группы
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(textBox11.Text) || String.IsNullOrEmpty(textBox10.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Введите код, номер и кол-во студентов");
            }
            else
            {
                string query = "INSERT INTO grup (kod, num, kolvo) VALUES ('" + textBox11.Text + "','" + textBox10.Text + "','" + textBox3.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Группа добавлена в базу данных");
                    databaseConnection.Close();
                    textBox11.Text = "";
                    textBox10.Text = "";
                    textBox3.Text = "";
                  
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button7Click(object sender, EventArgs e) ///Аудитории
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер Аудитории");
            }
            else
            {
                string query = "INSERT INTO audit (num) VALUES ('" + textBox6.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Аудитория добавлена в базу данных");
                    databaseConnection.Close();
                    textBox6.Text = "";
                  
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button8Click(object sender, EventArgs e) ///Время занятий
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
			if (String.IsNullOrEmpty(dateTimePicker1.Text) || String.IsNullOrEmpty(dateTimePicker2.Text))
            {
                MessageBox.Show("Введите Начало и Конец занятий");
            }
            else
            {
                string query = "INSERT INTO time (begin, end) VALUES ('" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Время занятий добавлено в базу данных");
                    databaseConnection.Close();
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения");
                }
                
            
            }
		}
		
		void Button4Click(object sender, EventArgs e) ///Обновить Преподователей
		{
			dataGridView1.Rows.Clear();
			string query = "SELECT idprepod, fio, doljnost FROM prepod;";
            
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
                    string idprepod = reader.GetString(0);
                    string fio = reader.GetString(1);
                    string doljnost = reader.GetString(2);
                    dataGridView1.Rows.Add(idprepod, fio, doljnost);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
				void Button5Click(object sender, EventArgs e) ///Обновление Дисциплин
		{
			dataGridView4.Rows.Clear();
			string query = "SELECT iddisc, name FROM disciplina;";
            
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
                	string iddisc = reader.GetString(0);
                	string name = reader.GetString(1);
                    dataGridView4.Rows.Add(iddisc, name);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Button9Click(object sender, EventArgs e) ///Обновление Отделения
		{
			dataGridView3.Rows.Clear();
			string query = "SELECT idotdel, nameotdel FROM otdelenie;";
            
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
                	string idotdel = reader.GetString(0);
                	string nameotdel = reader.GetString(1);
                    dataGridView3.Rows.Add(idotdel, nameotdel);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Button10Click(object sender, EventArgs e) ///Обновление Группы
		{
			dataGridView2.Rows.Clear();
			string query = "SELECT idgrup, kod, num, kolvo FROM grup;";
            
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
                	string idgrup = reader.GetString(0);
                	string kod = reader.GetString(1);
                	string num = reader.GetString(2);
                	string kolvo = reader.GetString(3);
                    dataGridView2.Rows.Add(idgrup, kod, num, kolvo);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Button11Click(object sender, EventArgs e) ///Обновление Аудитории
		{
			dataGridView5.Rows.Clear();
			string query = "SELECT idaudit, num FROM audit;";
            
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
                	string idaudit = reader.GetString(0);
                	string num = reader.GetString(1);
                    dataGridView5.Rows.Add(idaudit, num);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Button13Click(object sender, EventArgs e) /// Обновление Времени занятий
		{
			dataGridView6.Rows.Clear();
			string query = "SELECT idtime, begin, end FROM time;";
            
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
                	string idtime = reader.GetString(0);
                	string begin = reader.GetString(1);
                	string end = reader.GetString(2);
                    dataGridView6.Rows.Add(idtime, begin, end);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		void Label10Click(object sender, EventArgs e)
		{
			MainForm fr0 = new MainForm();
			fr0.Show();
			Hide();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
//		private void Combo()
//		{
//			string query = "SELECT DISTINCT fio FROM prepod";
//            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Auto IS;";
//            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
//            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
//            
//            MySqlDataReader reader;
//            try
//            {
//                databaseConnection.Open();
//                reader = commandDatabase.ExecuteReader();
//                while (reader.Read())
//                {
//                    string fio = reader.GetString(0);
//                    comboBox1.Items.Add(fio);
//                }
//                databaseConnection.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//		}
		

		
		void Timer1Tick(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		void DataGridView6CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
