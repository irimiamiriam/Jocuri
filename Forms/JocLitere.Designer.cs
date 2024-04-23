namespace Jocuri.Forms
{
    partial class JocLitere
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocLitere));
            this.panelJoc = new System.Windows.Forms.Panel();
            this.pictureBoxMinge = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimpRamas = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.labelCuvant = new System.Windows.Forms.Label();
            this.panelJoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJoc
            // 
            this.panelJoc.BackColor = System.Drawing.Color.AliceBlue;
            this.panelJoc.Controls.Add(this.pictureBoxMinge);
            this.panelJoc.Location = new System.Drawing.Point(1, 133);
            this.panelJoc.Name = "panelJoc";
            this.panelJoc.Size = new System.Drawing.Size(2213, 518);
            this.panelJoc.TabIndex = 0;
            // 
            // pictureBoxMinge
            // 
            this.pictureBoxMinge.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinge.Image")));
            this.pictureBoxMinge.Location = new System.Drawing.Point(1268, 399);
            this.pictureBoxMinge.Name = "pictureBoxMinge";
            this.pictureBoxMinge.Size = new System.Drawing.Size(74, 70);
            this.pictureBoxMinge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinge.TabIndex = 0;
            this.pictureBoxMinge.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 659);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(237, 659);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timp ramas:                         de secunde";
            // 
            // labelTimpRamas
            // 
            this.labelTimpRamas.AutoSize = true;
            this.labelTimpRamas.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimpRamas.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTimpRamas.Location = new System.Drawing.Point(250, 50);
            this.labelTimpRamas.Name = "labelTimpRamas";
            this.labelTimpRamas.Size = new System.Drawing.Size(36, 27);
            this.labelTimpRamas.TabIndex = 4;
            this.labelTimpRamas.Text = "    ";
            this.labelTimpRamas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 100000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 1000;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // labelCuvant
            // 
            this.labelCuvant.AutoSize = true;
            this.labelCuvant.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuvant.Location = new System.Drawing.Point(933, 693);
            this.labelCuvant.Name = "labelCuvant";
            this.labelCuvant.Size = new System.Drawing.Size(57, 39);
            this.labelCuvant.TabIndex = 5;
            this.labelCuvant.Text = "     ";
            // 
            // JocLitere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(2213, 1335);
            this.Controls.Add(this.labelCuvant);
            this.Controls.Add(this.labelTimpRamas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelJoc);
            this.KeyPreview = true;
            this.Name = "JocLitere";
            this.Text = "Popice cu litere";
            this.Load += new System.EventHandler(this.JocLitere_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JocLitere_KeyDown);
            this.panelJoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJoc;
        private System.Windows.Forms.PictureBox pictureBoxMinge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimpRamas;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Label labelCuvant;
    }
}