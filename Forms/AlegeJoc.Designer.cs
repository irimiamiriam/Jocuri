namespace Jocuri.Forms
{
    partial class AlegeJoc
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelUtilizator = new System.Windows.Forms.Label();
            this.primQRButton = new System.Windows.Forms.Button();
            this.jocLitereButton = new System.Windows.Forms.Button();
            this.jocMemorieButton = new System.Windows.Forms.Button();
            this.chartRezultate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUtilizator
            // 
            this.labelUtilizator.AutoSize = true;
            this.labelUtilizator.Font = new System.Drawing.Font("Rockwell Condensed", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilizator.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelUtilizator.Location = new System.Drawing.Point(33, 29);
            this.labelUtilizator.Name = "labelUtilizator";
            this.labelUtilizator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUtilizator.Size = new System.Drawing.Size(80, 31);
            this.labelUtilizator.TabIndex = 0;
            this.labelUtilizator.Text = "label1";
            // 
            // primQRButton
            // 
            this.primQRButton.BackColor = System.Drawing.Color.SteelBlue;
            this.primQRButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primQRButton.Location = new System.Drawing.Point(839, 599);
            this.primQRButton.Name = "primQRButton";
            this.primQRButton.Size = new System.Drawing.Size(173, 90);
            this.primQRButton.TabIndex = 10;
            this.primQRButton.Text = "Gaseste Prim QR";
            this.primQRButton.UseVisualStyleBackColor = false;
            this.primQRButton.Click += new System.EventHandler(this.primQRButton_Click);
            // 
            // jocLitereButton
            // 
            this.jocLitereButton.BackColor = System.Drawing.Color.SteelBlue;
            this.jocLitereButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jocLitereButton.Location = new System.Drawing.Point(501, 599);
            this.jocLitereButton.Name = "jocLitereButton";
            this.jocLitereButton.Size = new System.Drawing.Size(173, 90);
            this.jocLitereButton.TabIndex = 9;
            this.jocLitereButton.Text = "Popice cu litere";
            this.jocLitereButton.UseVisualStyleBackColor = false;
            this.jocLitereButton.Click += new System.EventHandler(this.jocLitereButton_Click);
            // 
            // jocMemorieButton
            // 
            this.jocMemorieButton.BackColor = System.Drawing.Color.SteelBlue;
            this.jocMemorieButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jocMemorieButton.Location = new System.Drawing.Point(137, 599);
            this.jocMemorieButton.Name = "jocMemorieButton";
            this.jocMemorieButton.Size = new System.Drawing.Size(174, 86);
            this.jocMemorieButton.TabIndex = 8;
            this.jocMemorieButton.Text = "Testeaza memoria";
            this.jocMemorieButton.UseVisualStyleBackColor = false;
            this.jocMemorieButton.Click += new System.EventHandler(this.jocMemorieButton_Click);
            // 
            // chartRezultate
            // 
            this.chartRezultate.Location = new System.Drawing.Point(12, 88);
            this.chartRezultate.Name = "chartRezultate";
            series1.Name = "Series1";
            this.chartRezultate.Series.Add(series1);
            this.chartRezultate.Size = new System.Drawing.Size(1141, 490);
            this.chartRezultate.TabIndex = 11;
            this.chartRezultate.Text = "chartRezultate";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonExit.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(963, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(173, 71);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AlegeJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1160, 697);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.chartRezultate);
            this.Controls.Add(this.primQRButton);
            this.Controls.Add(this.jocLitereButton);
            this.Controls.Add(this.jocMemorieButton);
            this.Controls.Add(this.labelUtilizator);
            this.Name = "AlegeJoc";
            this.Text = "Alege Joc";
            this.Load += new System.EventHandler(this.AlegeJoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRezultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilizator;
        private System.Windows.Forms.Button primQRButton;
        private System.Windows.Forms.Button jocLitereButton;
        private System.Windows.Forms.Button jocMemorieButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRezultate;
        private System.Windows.Forms.Button buttonExit;
    }
}