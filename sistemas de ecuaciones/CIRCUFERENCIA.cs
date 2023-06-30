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
    public partial class CIRCUFERENCIA : Form
    {
        public CIRCUFERENCIA()
        {
            InitializeComponent();
        }

        private void CIRCUFERENCIA_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                double circunferencia = 2 * Math.PI * radio;
                lblResultado.Text = $"La circunferencia es aproximadamente {circunferencia:F2} cm";

                string procedimiento = $"Procedimiento:\n" +
                    $"Radio = {radio} cm\n" +
                    $"Circunferencia = 2 * π * Radio\n" +
                    $"Circunferencia = 2 * {Math.PI} * {radio}\n" +
                    $"Circunferencia ≈ {circunferencia:F2} cm";
                lblProcedimiento.Text = procedimiento;

                // Limpiar el gráfico antes de agregar nuevos datos
                chart1.Series.Clear();

                // Crear una nueva serie para el punto de datos
                Series serieCircunferencia = new Series("Circunferencia");
                serieCircunferencia.ChartType = SeriesChartType.Point;

                // Agregar el punto de datos (radio, circunferencia) al gráfico
                serieCircunferencia.Points.AddXY(radio, circunferencia);

                // Agregar la serie al gráfico
                chart1.Series.Add(serieCircunferencia);

                // Crear una serie para el círculo
                Series serieCirculo = new Series("Círculo");
                serieCirculo.ChartType = SeriesChartType.Line;
                serieCirculo.BorderWidth = 2;
                serieCirculo.Color = Color.Red;

                // Calcular el tamaño del círculo para ajustar los límites del gráfico
                double diametro = 2 * radio;
                double minX = radio - diametro;
                double maxX = radio + diametro;
                double minY = circunferencia - diametro;
                double maxY = circunferencia + diametro;

                // Agregar puntos para dibujar el círculo
                for (double theta = 0; theta <= 2 * Math.PI; theta += 0.01)
                {
                    double x = radio * Math.Cos(theta) + radio;
                    double y = radio * Math.Sin(theta) + circunferencia;
                    serieCirculo.Points.AddXY(x, y);
                }

                // Agregar la serie del círculo al gráfico
                chart1.Series.Add(serieCirculo);

                // Crear una serie para la línea desde el punto hasta el círculo
                Series serieLinea = new Series("Línea");
                serieLinea.ChartType = SeriesChartType.Line;
                serieLinea.Color = Color.Blue;

                // Agregar los puntos para dibujar la línea
                serieLinea.Points.AddXY(radio, circunferencia);
                serieLinea.Points.AddXY(radio + radio * Math.Cos(0), circunferencia + radio * Math.Sin(0)); // Punto en el círculo (theta = 0)

                // Agregar la serie de la línea al gráfico
                chart1.Series.Add(serieLinea);

                // Ajustar los límites del gráfico para que el círculo y la línea sean visibles
                chart1.ChartAreas[0].AxisX.Minimum = minX;
                chart1.ChartAreas[0].AxisX.Maximum = maxX;
                chart1.ChartAreas[0].AxisY.Minimum = minY;
                chart1.ChartAreas[0].AxisY.Maximum = maxY;
            }
            else
            {
                lblResultado.Text = "Ingresa un valor válido para el radio.";
                lblProcedimiento.Text = string.Empty;
                chart1.Series.Clear();
            }
        }
    }
}
