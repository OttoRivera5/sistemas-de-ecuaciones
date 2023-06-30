namespace sistemas_de_ecuaciones
{
    partial class RECTA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1672, 386);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(1705, 45);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(100, 20);
            this.txtEquation.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(1494, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(1480, 84);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(97, 20);
            this.lblProcedure.TabIndex = 3;
            this.lblProcedure.Text = "lblProcedure";
            // 
            // chartLine
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLine.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLine.Legends.Add(legend1);
            this.chartLine.Location = new System.Drawing.Point(24, 45);
            this.chartLine.Name = "chartLine";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLine.Series.Add(series1);
            this.chartLine.Size = new System.Drawing.Size(1412, 971);
            this.chartLine.TabIndex = 4;
            this.chartLine.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1729, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ax+By=0";
            // 
            // RECTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartLine);
            this.Controls.Add(this.lblProcedure);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.btnCalculate);
            this.Name = "RECTA";
            this.Text = "RECTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
        private System.Windows.Forms.Label label1;
    }
}