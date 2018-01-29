using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChartExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (ChartEntities db = new ChartEntities()) {
                chartRevenue.DataSource = db.Revenues.ToList();
                chartRevenue.Series["Revenue"].XValueMember = "Year";
                chartRevenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartRevenue.Series["Revenue"].YValueMembers = "Total";
                chartRevenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ChartSalary.Series["Salary"].Points.AddXY("Peter", 1000);
            ChartSalary.Series["Salary"].Points.AddXY("John", 5000);
            ChartSalary.Series["Salary"].Points.AddXY("Tan", 1500);
            ChartSalary.Series["Salary"].Points.AddXY("Lucy", 1000);*/

            ChartSalary.Series["Salary"].Points.Add(1000);
            ChartSalary.Series["Salary"].Points[0].Color = Color.Red;
            ChartSalary.Series["Salary"].Points[0].AxisLabel = "Peter";
            ChartSalary.Series["Salary"].Points[0].LegendText = "Peter";
            ChartSalary.Series["Salary"].Points[0].Label = "5000";

            ChartSalary.Series["Salary"].Points.Add(5000);
            ChartSalary.Series["Salary"].Points[1].Color = Color.Green;
            ChartSalary.Series["Salary"].Points[1].AxisLabel = "John";
            ChartSalary.Series["Salary"].Points[1].LegendText = "John";
            ChartSalary.Series["Salary"].Points[1].Label = "5000";

            ChartSalary.Series["Salary"].Points.Add(1500);
            ChartSalary.Series["Salary"].Points[2].Color = Color.Red;
            ChartSalary.Series["Salary"].Points[2].AxisLabel = "Tan";
            ChartSalary.Series["Salary"].Points[2].LegendText = "Tan";
            ChartSalary.Series["Salary"].Points[2].Label = "1500";

            ChartSalary.Series["Salary"].Points.Add(7000);
            ChartSalary.Series["Salary"].Points[3].Color = Color.Blue;
            ChartSalary.Series["Salary"].Points[3].AxisLabel = "Lucy";
            ChartSalary.Series["Salary"].Points[3].LegendText = "Lucy";
            ChartSalary.Series["Salary"].Points[3].Label = "7000";
        }
    }
}
