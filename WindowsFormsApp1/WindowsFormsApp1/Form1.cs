using CodeLibrary.Controls.DataGridViewColumns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GenerateButtonColumn();
        }

        private void GenerateButtonColumn()
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Column1");
            DataColumn dc2 = new DataColumn("DataGridViewNumericColumn");
            DataColumn dc3 = new DataColumn("DataGridViewCalendarColumn");

            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            DataRow dr =  dt.Rows.Add();
            dr["Column1"] = "999";
            dr["DataGridViewNumericColumn"] = "333";
            dr["DataGridViewCalendarColumn"] = DateTime.Now.ToString();


            DataGridViewNumericColumn column = new DataGridViewNumericColumn();
            column.Name = "DataGridViewNumericColumn";
            column.DataPropertyName = "DataGridViewNumericColumn";
            column.HeaderText = "视频";
            dataGridView.Columns.Add(column);

            DataGridViewCalendarColumn columnCalendar = new DataGridViewCalendarColumn();
            columnCalendar.Name = "DataGridViewCalendarColumn";
            columnCalendar.DataPropertyName = "DataGridViewCalendarColumn";
            columnCalendar.HeaderText = "日期";
            dataGridView.Columns.Add(columnCalendar);

            dataGridView.DataSource = dt;
        }
    }
}
