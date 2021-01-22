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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.Автомобили' table. You can move, or remove it, as needed.
            this.автомобилиTableAdapter.Fill(this.databaseDataSet2.Автомобили);
            // TODO: This line of code loads data into the 'databaseDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.databaseDataSet.DataTable2);
            // TODO: This line of code loads data into the 'databaseDataSet.Виды_нарушений' table. You can move, or remove it, as needed.
            this.виды_нарушенийTableAdapter.Fill(this.databaseDataSet.Виды_нарушений);
            // TODO: This line of code loads data into the 'databaseDataSet.Владельцы' table. You can move, or remove it, as needed.
            this.владельцыTableAdapter.Fill(this.databaseDataSet.Владельцы);
            // TODO: This line of code loads data into the 'databaseDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.databaseDataSet.DataTable1);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            // TODO: This line of code loads data into the 'databaseDataSet.Факты_нарушения' table. You can move, or remove it, as needed.

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

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
        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.databaseDataSet.DataTable1);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
  
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication11.Report2.rdlc";
                this.dataTable1TableAdapter.Fill(this.databaseDataSet.DataTable1);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication11.Report4.rdlc";
            this.dataTable1TableAdapter.FillBy(this.databaseDataSet.DataTable1, фИО_водителяComboBox.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {

                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication11.Report5.rdlc";
                DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                DateTime data1 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker1.Value.ToShortDateString())));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker2.Value.ToShortDateString())));
                this.dataTable1TableAdapter.FillBy1(this.databaseDataSet.DataTable1, data, data1);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.Fill(this.databaseDataSet.DataTable2);
                this.reportViewer2.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication11.Report6.rdlc";
                DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                DateTime data1 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker4.Value.ToShortDateString())));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker3.Value.ToShortDateString())));
                this.dataTable1TableAdapter.FillBy2(this.databaseDataSet.DataTable1, data, data1, фИО_водителяComboBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.FillBy(this.databaseDataSet.DataTable2,фИОComboBox.Text);
            this.reportViewer2.RefreshReport();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.FillBy1(this.databaseDataSet.DataTable2,модельComboBox.Text);
            this.reportViewer2.RefreshReport();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.FillBy2(this.databaseDataSet.DataTable2, место_жительстваComboBox.Text);
            this.reportViewer2.RefreshReport();
        }
    }

    }

