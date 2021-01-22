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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {          
            this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet.Виды_нарушений);
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
        private void виды_нарушенийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.виды_нарушенийBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите добавить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        try
                        {
                            this.виды_нарушенийTableAdapter.InsertQuery(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Неверно заполнены данные", "Ошибка");
                        }

                        this.виды_нарушенийTableAdapter.Update(this.databaseDataSet.Виды_нарушений);
                        this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet.Виды_нарушений);
                    }
                    else
                        MessageBox.Show("Введите пожалуйста данные", "Ошибка");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    this.виды_нарушенийTableAdapter.DeleteQuery(System.Convert.ToInt32(виды_нарушенийDataGridView.SelectedCells[0].Value));
                this.виды_нарушенийTableAdapter.Update(this.databaseDataSet.Виды_нарушений);
                this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet.Виды_нарушений);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                виды_нарушенийDataGridView.ClearSelection();
                for (int _i = 0; _i < виды_нарушенийDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (виды_нарушенийDataGridView.Rows[_i].Cells[3].Value.ToString().Contains(textBox6.Text)) _n = true;
                    else if (textBox6.Text == "") _n = true;
                    if (textBox6.Text != "")
                    {
                        if (_n) виды_нарушенийDataGridView.Rows[_i].Selected = true;
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
                виды_нарушенийDataGridView.ClearSelection();
                for (int _i = 0; _i < виды_нарушенийDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (виды_нарушенийDataGridView.Rows[_i].Cells[2].Value.ToString().Contains(textBox5.Text)) _n = true;
                    else if (textBox5.Text == "") _n = true;
                    if (textBox5.Text != "")
                    {
                        if (_n) виды_нарушенийDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                виды_нарушенийDataGridView.ClearSelection();
                for (int _i = 0; _i < виды_нарушенийDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (виды_нарушенийDataGridView.Rows[_i].Cells[1].Value.ToString().Contains(textBox4.Text)) _n = true;
                    else if (textBox4.Text == "") _n = true;
                    if (textBox4.Text != "")
                    {
                        if (_n) виды_нарушенийDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void наименование_нарушенияTextBox_TextChanged(object sender, EventArgs e)
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
        private void размер_штрафаTextBox_TextChanged(object sender, EventArgs e)
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
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    виды_нарушенийBindingSource.Filter = "Наименование_нарушения like'" + textBox7.Text + "%'";
                if (checkBox2.Checked == true)
                    виды_нарушенийBindingSource.Filter = "Размер_штрафа =\'" + textBox8.Text + "\'";
                if (checkBox3.Checked == true)
                    виды_нарушенийBindingSource.Filter = "Статья like'" + textBox9.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            виды_нарушенийBindingSource.Filter = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;                   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
        }
     private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            checkBox1.Visible = false;
            checkBox3.Visible = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Visible = true;
            checkBox2.Visible = false;
            checkBox1.Visible = false;
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
    }
}