using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id237021687");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/vladikshokoladik_/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("popelizaxar@mail.ru", " Почта");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.Виды_нарушений' table. You can move, or remove it, as needed.
            this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet3.Виды_нарушений);
            // TODO: This line of code loads data into the 'databaseDataSet2.Владельцы' table. You can move, or remove it, as needed.
            this.владельцыTableAdapter.Fill(this.databaseDataSet2.Владельцы);
            // TODO: This line of code loads data into the 'databaseDataSet.Автомобили' table. You can move, or remove it, as needed.
            this.автомобилиTableAdapter.Fill(this.databaseDataSet.Автомобили);
            // TODO: This line of code loads data into the 'databaseDataSet1.Виды_нарушений' table. You can move, or remove it, as needed.
            this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet1.Виды_нарушений);
            // TODO: This line of code loads data into the 'databaseDataSet.Факты_нарушения' table. You can move, or remove it, as needed.
            this.факты_нарушенияTableAdapter.Fill(this.databaseDataSet.Факты_нарушения);
            this.владельцыTableAdapter.Fill(this.databaseDataSet.Владельцы);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            дата_нарушенияDateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                факты_нарушенияDataGridView.ClearSelection();
                for (int _i = 0; _i < факты_нарушенияDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (факты_нарушенияDataGridView.Rows[_i].Cells[3].Value.ToString().Contains(textBox4.Text)) _n = true;
                    else if (textBox4.Text == "") _n = true;
                    if (textBox4.Text != "")
                    {
                        if (_n) факты_нарушенияDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                факты_нарушенияDataGridView.ClearSelection();
                for (int _i = 0; _i < факты_нарушенияDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (факты_нарушенияDataGridView.Rows[_i].Cells[4].Value.ToString().Contains(textBox5.Text)) _n = true;
                    else if (textBox5.Text == "") _n = true;
                    if (textBox5.Text != "")
                    {
                        if (_n) факты_нарушенияDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                факты_нарушенияDataGridView.ClearSelection();
                for (int _i = 0; _i < факты_нарушенияDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (факты_нарушенияDataGridView.Rows[_i].Cells[5].Value.ToString().Contains(textBox6.Text)) _n = true;
                    else if (textBox6.Text == "") _n = true;
                    if (textBox6.Text != "")
                    {
                        if (_n) факты_нарушенияDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                факты_нарушенияDataGridView.ClearSelection();
                for (int _i = 0; _i < факты_нарушенияDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (факты_нарушенияDataGridView.Rows[_i].Cells[6].Value.ToString().Contains(textBox7.Text)) _n = true;
                    else if (textBox7.Text == "") _n = true;
                    if (textBox7.Text != "")
                    {
                        if (_n) факты_нарушенияDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("Вы действительно хотите добавить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = (int)comboBox1.SelectedValue;
                int id2 = (int)comboBox2.SelectedValue;
                DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                //if (textBox3.Text != "")
                //{
                    try
                    {
                        this.факты_нарушенияTableAdapter.InsertQuery(id, id2, data,comboBox3.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверно заполнены данные", "Ошибка");
                    }

                    this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
                    this.факты_нарушенияTableAdapter.Fill(this.databaseDataSet.Факты_нарушения);
                }
                else
                    MessageBox.Show("Введите пожалуйста данные", "Ошибка");
            }
                catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    this.факты_нарушенияTableAdapter.DeleteQuery(System.Convert.ToInt32(факты_нарушенияDataGridView.SelectedCells[0].Value));
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
                this.факты_нарушенияTableAdapter.Fill(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void дата_нарушенияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void фИО_водителяTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void модельTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.виды_нарушенийTableAdapter.Update(this.databaseDataSet.Виды_нарушений);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void статьяTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.виды_нарушенийTableAdapter.Update(this.databaseDataSet.Виды_нарушений);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void модельTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.виды_нарушенийTableAdapter.Update(this.databaseDataSet.Виды_нарушений);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Visible = true;
            checkBox1.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox4.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox6.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    факты_нарушенияBindingSource.Filter = "Дата_нарушения=\'" + dateTimePicker2.Text + "\'";
                if (checkBox2.Checked == true)
                    факты_нарушенияBindingSource.Filter = "ФИО_водителя LIKE'" + comboBox4.Text + "%'";
                if (checkBox3.Checked == true)
                    факты_нарушенияBindingSource.Filter = "Модель LIKE \'" + comboBox5.Text + "%'";
                if (checkBox4.Checked == true)
                    факты_нарушенияBindingSource.Filter = "Статья LIKE \'" + comboBox6.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            факты_нарушенияBindingSource.Filter = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            dateTimePicker2.Visible = false;
            comboBox4.Visible = false;
          comboBox6.Visible = false;
            comboBox5.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "NewProject.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void фИО_водителяComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void статьяComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void модельComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.факты_нарушенияTableAdapter.Update(this.databaseDataSet.Факты_нарушения);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
    }
}
