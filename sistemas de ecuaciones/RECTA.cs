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
    public partial class RECTA : Form
    {
        public RECTA()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Obtener la ecuación del TextBox
            string equation = txtEquation.Text;

            // Separar los coeficientes de la ecuación
            string[] coefficients = equation.Split(new char[] { 'x', 'y', '=', '+' }, StringSplitOptions.RemoveEmptyEntries);

            // Convertir los coeficientes en números
            double a = double.Parse(coefficients[0]);
            double b = double.Parse(coefficients[1]);

            // Calcular los puntos
            double x1 = 1;
            double y1 = -(a / b) * x1;
            double x2 = -2;
            double y2 = -(a / b) * x2;

            // Configurar los ejes x e y
            chartLine.ChartAreas[0].AxisX.Minimum = -10;
            chartLine.ChartAreas[0].AxisX.Maximum = 10;
            chartLine.ChartAreas[0].AxisX.Interval = 1;
            chartLine.ChartAreas[0].AxisY.Minimum = -10;
            chartLine.ChartAreas[0].AxisY.Maximum = 10;
            chartLine.ChartAreas[0].AxisY.Interval = 1;
            chartLine.ChartAreas[0].AxisY.Interval = .5;

            // Limpiar el Chart
            chartLine.Series.Clear();

            // Crear una nueva serie para la línea
            Series series = new Series("Línea");
            series.ChartType = SeriesChartType.Line;

            // Agregar los puntos a la serie
            series.Points.AddXY(x1, y1);
            series.Points.AddXY(x2, y2);

            // Agregar la serie al Chart
            chartLine.Series.Add(series);

            // Actualizar la visualización del Chart
            chartLine.Update();



            // Crear una variable para almacenar el procedimiento paso a paso
            string procedure = $"Paso 1: Asignar x = {x1}\n";
            procedure += $"Paso 2: Sustituir x en la ecuación original: {a}({x1}) + {b}y = 0\n";
            procedure += $"Paso 3: Resolver la ecuación para y: {a * x1} + {b}y = 0\n";
            procedure += $"           {b}y = {-a * x1}\n";
            procedure += $"           y = {-a * x1 / b}\n";
            procedure += $"Paso 4: El primer punto es ({x1}, {y1})\n\n";
            procedure += $"Paso 5: Asignar x = {x2}\n";
            procedure += $"Paso 6: Sustituir x en la ecuación original: {a}({x2}) + {b}y = 0\n";
            procedure += $"Paso 7: Resolver la ecuación para y: {a * x2} + {b}y = 0\n";
            procedure += $"           {b}y = {-a * x2}\n";
            procedure += $"           y = {-a * x2 / b}\n";
            procedure += $"Paso 8: El segundo punto es ({x2}, {y2})";

            // Mostrar los resultados en los Labels correspondientes
            lblResult.Text = $"Punto 1: ({x1}, {y1})\nPunto 2: ({x2}, {y2})";
            lblProcedure.Text = procedure;
        }
    }
}
