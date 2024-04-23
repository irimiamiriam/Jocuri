namespace Jocuri.Forms
{
    partial class PrimQR
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
            this.codQRPictureBox = new System.Windows.Forms.PictureBox();
            this.primButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.codQRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codQRPictureBox
            // 
            this.codQRPictureBox.Location = new System.Drawing.Point(139, 142);
            this.codQRPictureBox.Name = "codQRPictureBox";
            this.codQRPictureBox.Size = new System.Drawing.Size(444, 415);
            this.codQRPictureBox.TabIndex = 0;
            this.codQRPictureBox.TabStop = false;
            // 
            // primButton
            // 
            this.primButton.BackColor = System.Drawing.Color.DarkCyan;
            this.primButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primButton.Location = new System.Drawing.Point(701, 325);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(375, 71);
            this.primButton.TabIndex = 7;
            this.primButton.Text = "Punctaj prim";
            this.primButton.UseVisualStyleBackColor = false;
            this.primButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // PrimQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1210, 701);
            this.Controls.Add(this.primButton);
            this.Controls.Add(this.codQRPictureBox);
            this.Name = "PrimQR";
            this.Text = "PrimQR";
            ((System.ComponentModel.ISupportInitialize)(this.codQRPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox codQRPictureBox;
        private System.Windows.Forms.Button primButton;
    }
}