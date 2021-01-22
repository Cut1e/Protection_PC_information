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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
        private void Form3_Load(object sender, EventArgs e)
        {
            this.владельцыTableAdapter.Fill(this.databaseDataSet.Владельцы);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            if (MessageBox.Show("Вы действительно хотите добавить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    try
                    {
                        this.владельцыTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверно заполнены данные", "Ошибка");
                    }

                    this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
                    this.владельцыTableAdapter.Fill(this.databaseDataSet.Владельцы);
                }
                else
                    MessageBox.Show("Введите пожалуйста данные", "Ошибка");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    this.владельцыTableAdapter.DeleteQuery(System.Convert.ToInt32(владельцыDataGridView.SelectedCells[0].Value));
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
                this.владельцыTableAdapter.Fill(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                владельцыDataGridView.ClearSelection();
                for (int _i = 0; _i < владельцыDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (владельцыDataGridView.Rows[_i].Cells[1].Value.ToString().Contains(textBox8.Text)) _n = true;
                    else if (textBox8.Text == "") _n = true;
                    if (textBox8.Text != "")
                    {
                        if (_n) владельцыDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {try
            {
                владельцыDataGridView.ClearSelection();
                for (int _i = 0; _i < владельцыDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (владельцыDataGridView.Rows[_i].Cells[4].Value.ToString().Contains(textBox7.Text)) _n = true;
                    else if (textBox7.Text == "") _n = true;
                    if (textBox7.Text != "")
                    {
                        if (_n) владельцыDataGridView.Rows[_i].Selected = true;
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
                владельцыDataGridView.ClearSelection();
                for (int _i = 0; _i < владельцыDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (владельцыDataGridView.Rows[_i].Cells[3].Value.ToString().Contains(textBox6.Text)) _n = true;
                    else if (textBox6.Text == "") _n = true;
                    if (textBox6.Text != "")
                    {
                        if (_n) владельцыDataGridView.Rows[_i].Selected = true;
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
                владельцыDataGridView.ClearSelection();
                for (int _i = 0; _i < владельцыDataGridView.Rows.Count - 1; _i++)
                {
                    bool _n = false;

                    if (владельцыDataGridView.Rows[_i].Cells[2].Value.ToString().Contains(textBox5.Text)) _n = true;
                    else if (textBox5.Text == "") _n = true;
                    if (textBox5.Text != "")
                    {
                        if (_n) владельцыDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }       
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void фамилияTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void имяTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void отчествоTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void паспортTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    владельцыBindingSource.Filter = "[ФИО] like'" + textBox12.Text + "%'";
                if (checkBox2.Checked == true)
                    владельцыBindingSource.Filter = "[Место жительства] like'" + textBox11.Text + "%'";
                if (checkBox3.Checked == true)
                    владельцыBindingSource.Filter = "[Номер] like'" + textBox10.Text + "%'";
                if (checkBox4.Checked == true)
                    владельцыBindingSource.Filter = "[Серия] like'" + textBox9.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox9.Text = "";
            владельцыBindingSource.Filter = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            textBox12.Visible = false;
            textBox11.Visible = false;
            textBox10.Visible = false;
            textBox9.Visible = false;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Visible = true;
            checkBox1.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox4.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {
            this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
        }

        private void место_жительстваTextBox_TextChanged(object sender, EventArgs e)
        {
            this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
        }

        private void номерTextBox_TextChanged(object sender, EventArgs e)
        {
            this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
        }

        private void серияTextBox_TextChanged(object sender, EventArgs e)
        {
            this.владельцыTableAdapter.Update(this.databaseDataSet.Владельцы);
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
