/*
 * Created by SharpDevelop.
 * User: Игорек
 * Date: 07.05.2020
 * Time: 19:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rasp
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button10 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button12 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button11 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.dataGridView5 = new System.Windows.Forms.DataGridView();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button13 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.dataGridView6 = new System.Windows.Forms.DataGridView();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 352);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 53);
			this.button1.TabIndex = 11;
			this.button1.Text = "Глав.Стр";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(113, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(527, 55);
			this.label1.TabIndex = 10;
			this.label1.Text = "Страница \"Значения\"";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Location = new System.Drawing.Point(113, 79);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(552, 257);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(544, 228);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Преподаватели";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(340, 196);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(94, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "Обновить";
			this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(112, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "Добавить";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column4,
									this.Column1,
									this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(7, 87);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(530, 102);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// Column4
			// 
			this.Column4.HeaderText = "ID";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Ф.И.О";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Должность";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 47);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(411, 22);
			this.textBox2.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(411, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Должность";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ф.И.О";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.dataGridView4);
			this.tabPage2.Controls.Add(this.textBox5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(544, 228);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Дисциплины";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(340, 196);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(94, 23);
			this.button5.TabIndex = 18;
			this.button5.Text = "Обновить";
			this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(112, 196);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(94, 23);
			this.button6.TabIndex = 17;
			this.button6.Text = "Добавить";
			this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// dataGridView4
			// 
			this.dataGridView4.AllowUserToDeleteRows = false;
			this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column5,
									this.dataGridViewTextBoxColumn3});
			this.dataGridView4.Location = new System.Drawing.Point(8, 66);
			this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.ReadOnly = true;
			this.dataGridView4.RowTemplate.Height = 24;
			this.dataGridView4.Size = new System.Drawing.Size(530, 102);
			this.dataGridView4.TabIndex = 16;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "ID";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Названия";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(113, 37);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(410, 22);
			this.textBox5.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(7, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Название";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button9);
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(544, 228);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Отделения";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.Location = new System.Drawing.Point(340, 196);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(94, 23);
			this.button9.TabIndex = 22;
			this.button9.Text = "Обновить";
			this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(112, 196);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 21;
			this.button2.Text = "Добавить";
			this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column6,
									this.dataGridViewTextBoxColumn2});
			this.dataGridView3.Location = new System.Drawing.Point(8, 66);
			this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.RowTemplate.Height = 24;
			this.dataGridView3.Size = new System.Drawing.Size(530, 102);
			this.dataGridView3.TabIndex = 20;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "ID";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(113, 36);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(410, 22);
			this.textBox4.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(7, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Номер";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button10);
			this.tabPage4.Controls.Add(this.textBox3);
			this.tabPage4.Controls.Add(this.label4);
			this.tabPage4.Controls.Add(this.textBox10);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.button12);
			this.tabPage4.Controls.Add(this.dataGridView2);
			this.tabPage4.Controls.Add(this.textBox11);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(544, 228);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Группы";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button10.Location = new System.Drawing.Point(340, 199);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(94, 23);
			this.button10.TabIndex = 29;
			this.button10.Text = "Обновить";
			this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(116, 66);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(407, 22);
			this.textBox3.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(4, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 23);
			this.label4.TabIndex = 27;
			this.label4.Text = "Кол-во студ.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(116, 36);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(407, 22);
			this.textBox10.TabIndex = 25;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(0, 39);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(117, 30);
			this.label11.TabIndex = 24;
			this.label11.Text = "Номер группы";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button12.Location = new System.Drawing.Point(116, 199);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(94, 23);
			this.button12.TabIndex = 23;
			this.button12.Text = "Добавить";
			this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column7,
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn6,
									this.dataGridViewTextBoxColumn7});
			this.dataGridView2.Location = new System.Drawing.Point(7, 95);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(530, 102);
			this.dataGridView2.TabIndex = 22;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "ID";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Код группы";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Номер группы";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Кол-во студентов";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(116, 8);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(407, 22);
			this.textBox11.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(10, 11);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 20;
			this.label12.Text = "Код группы";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.button11);
			this.tabPage5.Controls.Add(this.button7);
			this.tabPage5.Controls.Add(this.dataGridView5);
			this.tabPage5.Controls.Add(this.textBox6);
			this.tabPage5.Controls.Add(this.label7);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(544, 228);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Аудитории";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button11.Location = new System.Drawing.Point(340, 196);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(94, 23);
			this.button11.TabIndex = 18;
			this.button11.Text = "Обновить";
			this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.Location = new System.Drawing.Point(112, 196);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(94, 23);
			this.button7.TabIndex = 17;
			this.button7.Text = "Добавить";
			this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// dataGridView5
			// 
			this.dataGridView5.AllowUserToDeleteRows = false;
			this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column8,
									this.dataGridViewTextBoxColumn4});
			this.dataGridView5.Location = new System.Drawing.Point(8, 66);
			this.dataGridView5.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView5.Name = "dataGridView5";
			this.dataGridView5.ReadOnly = true;
			this.dataGridView5.RowTemplate.Height = 24;
			this.dataGridView5.Size = new System.Drawing.Size(530, 102);
			this.dataGridView5.TabIndex = 16;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "ID";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(113, 36);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(410, 22);
			this.textBox6.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(7, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Номер";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.dateTimePicker2);
			this.tabPage6.Controls.Add(this.dateTimePicker1);
			this.tabPage6.Controls.Add(this.button13);
			this.tabPage6.Controls.Add(this.label9);
			this.tabPage6.Controls.Add(this.button8);
			this.tabPage6.Controls.Add(this.dataGridView6);
			this.tabPage6.Controls.Add(this.label8);
			this.tabPage6.Location = new System.Drawing.Point(4, 25);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(544, 228);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Время занятий";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(151, 41);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(372, 22);
			this.dateTimePicker2.TabIndex = 22;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(151, 10);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(372, 22);
			this.dateTimePicker1.TabIndex = 21;
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button13.Location = new System.Drawing.Point(340, 196);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(94, 23);
			this.button13.TabIndex = 20;
			this.button13.Text = "Обновить";
			this.button13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(7, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Конец (чч:мм)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.Location = new System.Drawing.Point(112, 196);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(94, 23);
			this.button8.TabIndex = 17;
			this.button8.Text = "Добавить";
			this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// dataGridView6
			// 
			this.dataGridView6.AllowUserToDeleteRows = false;
			this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column9,
									this.dataGridViewTextBoxColumn5,
									this.Column3});
			this.dataGridView6.Location = new System.Drawing.Point(7, 78);
			this.dataGridView6.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView6.Name = "dataGridView6";
			this.dataGridView6.ReadOnly = true;
			this.dataGridView6.RowTemplate.Height = 24;
			this.dataGridView6.Size = new System.Drawing.Size(530, 102);
			this.dataGridView6.TabIndex = 16;
			this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView6CellContentClick);
			// 
			// Column9
			// 
			this.Column9.HeaderText = "ID";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Начало";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Конец";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(7, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Начало (чч:мм)";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label10
			// 
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(145, 352);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 53);
			this.label10.TabIndex = 12;
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(734, 407);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Значения";
			this.Load += new System.EventHandler(this.Form1Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridView dataGridView6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridView dataGridView5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
