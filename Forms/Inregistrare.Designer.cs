namespace Jocuri.Forms
{
    partial class Inregistrare
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
            this.parolatextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.conftextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parolatextBox
            // 
            this.parolatextBox.Location = new System.Drawing.Point(394, 276);
            this.parolatextBox.Name = "parolatextBox";
            this.parolatextBox.PasswordChar = '*';
            this.parolatextBox.Size = new System.Drawing.Size(296, 31);
            this.parolatextBox.TabIndex = 8;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(394, 202);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(296, 31);
            this.emailtextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(149, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parola:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.CadetBlue;
            this.label.Location = new System.Drawing.Point(149, 193);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(238, 40);
            this.label.TabIndex = 5;
            this.label.Text = "Adresa de email:";
            // 
            // conftextBox
            // 
            this.conftextBox.Location = new System.Drawing.Point(394, 347);
            this.conftextBox.Name = "conftextBox";
            this.conftextBox.PasswordChar = '*';
            this.conftextBox.Size = new System.Drawing.Size(296, 31);
            this.conftextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(149, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Repetare parola:";
            // 
            // numetextBox
            // 
            this.numetextBox.Location = new System.Drawing.Point(394, 132);
            this.numetextBox.Name = "numetextBox";
            this.numetextBox.Size = new System.Drawing.Size(296, 31);
            this.numetextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(149, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nume:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkCyan;
            this.exitButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(420, 441);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(173, 71);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Renunta";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.DarkCyan;
            this.logInButton.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(236, 441);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(173, 71);
            this.logInButton.TabIndex = 13;
            this.logInButton.Text = "Inregistrare";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(854, 566);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.numetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conftextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parolatextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parolatextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox conftextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logInButton;
    }
}