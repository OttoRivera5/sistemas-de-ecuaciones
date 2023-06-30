using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sistemas_de_ecuaciones
{
    public partial class PARABOLA : Form
    {
        public PARABOLA()
        {
            InitializeComponent();
        }

        private void PARABOLA_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = -10;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = -10;
            chart1.ChartAreas[0].AxisY.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = .25 ;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            string kString = txtK.Text;
            string hString = txtH.Text;
            string aString = txtA.Text;

            string equation = $"(y + {kString})² = {aString}(x - {hString})";
            string procedure = "";

            try
            {
                double k = double.Parse(kString);
                double h = double.Parse(hString);
                double a = double.Parse(aString);

                // Calcular el vértice
                double vertexX = h;
                double vertexY = -k;

                // Calcular el foco
                double focusX = h;
                double focusY = -k + 1 / (4 * a);

                // Calcular la directriz
                double directrixY = -k - 1 / (4 * a);

                // Generar la ecuación en forma canónica
                string canonicalEquation = $"(y + {k})² = {4 * a}(x - {h})";

                // Construir el procedimiento
               
                procedure += $"Ecuación: {equation}\n\n";
                procedure += "Procedimiento Paso a Paso:\n";
                procedure += $"Paso 1: Calcular el vértice\n";
                procedure += $"Vértice: ({vertexX}, {vertexY})\n\n";
                procedure += $"Paso 2: Calcular el foco\n";
                procedure += $"Foco: ({focusX}, {focusY})\n\n";
                procedure += $"Paso 3: Calcular la directriz\n";
                procedure += $"Directriz: y = {directrixY}\n\n";
                procedure += $"Paso 4: Mostrar el procedimiento completo\n";
                procedure += $"Ecuación: {equation}\n";
                procedure += $"Forma canónica: {canonicalEquation}\n";
                procedure += $"Vértice: ({vertexX}, {vertexY})\n";
                procedure += $"Foco: ({focusX}, {focusY})\n";
                procedure += $"Directriz: y = {directrixY}\n";

                // Graficar la parábola
                Series series = new Series();
                series.ChartType = SeriesChartType.Spline;

                for (double x = -10; x <= 10; x += 0.01)
                {
                    double y = Math.Pow(4 * a * (x - h), 0.5) - k;
                    series.Points.AddXY(x, y);
                }


                chart1.Series.Clear();
                chart1.Series.Add(series);
                chart1.Series.Add(new Series

                {
                    ChartType = SeriesChartType.Point,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    Points = { new DataPoint(focusX, focusY) }
                });

                Series directrixSeries = new Series
                {
                    ChartType = SeriesChartType.Line
                };

                for (double x = -10; x <= 10; x += 0.1)
                {
                    double y = directrixY;
                    directrixSeries.Points.AddXY(x, y);
                }


                //recta de directriz
                chart1.Series.Add(directrixSeries);

                lblProcedimiento.Text = procedure;
            }
            catch (Exception ex)
            {
                lblProcedimiento.Text = "Error: " + ex.Message;
            }
        }
    }

}

 
