using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Theta {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static double parseInput(TextBox box) {
            return Double.Parse(box.Text.Replace('.', ','));
        }

        private void Form1_Load(object sender, EventArgs e) {
            //WindowState = FormWindowState.Maximized;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Index";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Name = "x";
            dataGridView1.Columns[1].Width = 138;
            dataGridView1.Columns[2].Name = "Value";
            dataGridView1.Columns[2].Width = 138;

            chart1.Series.Add("Dual");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Color = System.Drawing.Color.Blue;

            fromValueBox.Text = "-10";
            toValueBox.Text = "10";

        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            var L = parseInput(lValueBox);
            var k_cnt = (int)parseInput(kCntBox);
            var m_cnt = (int)parseInput(mCntBox);
            var nx_porc = parseInput(nxCntBox);
            var x_max = parseInput(xMaxBox);

            var alpha1 = Math.Sqrt(Math.PI / L);
            var alpha2 = alpha1 * L;
            var omega1 = (2 * Math.PI) / alpha2;
            var omega2 = (2 * Math.PI) / alpha1;

            var buf = 4 / Math.Pow(omega1, 2);
            double[] c_k = Utilities.CalcCoeffs(buf, k_cnt);
            buf = 4 / Math.Pow(omega2, 2);
            double[] c_m = Utilities.CalcCoeffs(buf, m_cnt);

            var hx = alpha1 / nx_porc;
            var nx_cnt = (int)Math.Round(x_max / hx);
            double[] yValues = new double[nx_cnt];
            double[] xValues = new double[nx_cnt];

            for (int i = 0; i < nx_cnt; i++) {
                double x = i * hx;
                buf = Utilities.dual(x, omega1, omega2);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = x;
                dataGridView1.Rows[i].Cells[2].Value = buf;

                yValues[i] = buf;
                xValues[i] = x;
            }

            double from = parseInput(fromValueBox);
            double to = parseInput(toValueBox);

            for (int i = nx_cnt - 1; i > 1; i--) {
                if (-xValues[i] > from) {
                    chart1.Series[0].Points.AddXY(
                        -xValues[i],
                        yValues[i]
                    );
                }
            }

            for (int i = 1; i < nx_cnt; i++) {
                if (xValues[i] < to)
                    chart1.Series[0].Points.AddXY(
                       xValues[i],
                       yValues[i]
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            TestingUtilities.testThetha(15);
        }
    }
}
