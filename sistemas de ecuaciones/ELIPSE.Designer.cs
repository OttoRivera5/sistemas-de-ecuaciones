namespace sistemas_de_ecuaciones
{
    partial class ELIPSE
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(597, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(714, 34);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(724, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(594, 213);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // txtCentroX
            // 
            this.txtCentroX.Location = new System.Drawing.Point(836, 33);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(100, 20);
            this.txtCentroX.TabIndex = 4;
            // 
            // txtCentroY
            // 
            this.txtCentroY.Location = new System.Drawing.Point(958, 33);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(100, 20);
            this.txtCentroY.TabIndex = 5;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(1328, 35);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 6;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(1444, 34);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.AutoSize = true;
            this.lblProcedimiento.Location = new System.Drawing.Point(1074, 213);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(84, 13);
            this.lblProcedimiento.TabIndex = 8;
            this.lblProcedimiento.Text = "lblProcedimiento";
            // 
            // ELIPSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblProcedimiento);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.txtCentroX);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "ELIPSE";
            this.Text = "ELIPSE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblProcedimiento;
    }
}