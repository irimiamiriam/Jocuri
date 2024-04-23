namespace Jocuri.Forms
{
    partial class Autentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificare));
            this.codeQRPictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.parolatextBox = new System.Windows.Forms.TextBox();
            this.qrButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.singUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.codeQRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codeQRPictureBox
            // 
            this.codeQRPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeQRPictureBox.Location = new System.Drawing.Point(28, 79);
            this.codeQRPictureBox.Name = "codeQRPictureBox";
            this.codeQRPictureBox.Size = new System.Drawing.Size(559, 502);
            this.codeQRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codeQRPictureBox.TabIndex = 0;
            this.codeQRPictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.CadetBlue;
            this.label.Location = new System.Drawing.Point(621, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(238, 40);
            this.label.TabIndex = 1;
            this.label.Text = "Adresa de email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(621, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parola:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(866, 233);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(296, 31);
            this.emailtextBox.TabIndex = 3;
            // 
            // parolatextBox
            // 
            this.parolatextBox.Location = new System.Drawing.Point(866, 307);
            this.parolatextBox.Name = "parolatextBox";
            this.parolatextBox.PasswordChar = '*';
            this.parolatextBox.Size = new System.Drawing.Size(296, 31);
            this.parolatextBox.TabIndex = 4;
            // 
            // qrButton
            // 
            this.qrButton.BackColor = System.Drawing.Color.DarkCyan;
            this.qrButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrButton.Location = new System.Drawing.Point(626, 435);
            this.qrButton.Name = "qrButton";
            this.qrButton.Size = new System.Drawing.Size(173, 71);
            this.qrButton.TabIndex = 5;
            this.qrButton.Text = "QRCode";
            this.qrButton.UseVisualStyleBackColor = false;
            this.qrButton.Click += new System.EventHandler(this.qrButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.DarkCyan;
            this.logInButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(805, 435);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(173, 71);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Logare";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // singUpButton
            // 
            this.singUpButton.BackColor = System.Drawing.Color.DarkCyan;
            this.singUpButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singUpButton.Location = new System.Drawing.Point(989, 435);
            this.singUpButton.Name = "singUpButton";
            this.singUpButton.Size = new System.Drawing.Size(173, 71);
            this.singUpButton.TabIndex = 7;
            this.singUpButton.Text = "Cont Nou";
            this.singUpButton.UseVisualStyleBackColor = false;
            this.singUpButton.Click += new System.EventHandler(this.singUpButton_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1222, 721);
            this.Controls.Add(this.singUpButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.qrButton);
            this.Controls.Add(this.parolatextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.codeQRPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeQRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox codeQRPictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox parolatextBox;
        private System.Windows.Forms.Button qrButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button singUpButton;
    }
}