using Jocuri.Models;
using Jocuri.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;

namespace Jocuri.Forms
{
    public partial class Autentificare : Form
    {
        bool autificareQr = false;

        public Autentificare()
        {
            InitializeComponent();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            {
                user.Email= emailtextBox.Text;
                user.Password = parolatextBox.Text;
            }
            UserModel userGasit = DatabaseHelper.SearchUser(user);
            if(userGasit.Name != null)
            {
                AlegeJoc alegeJoc = new AlegeJoc();
                alegeJoc.user= userGasit;
                this.Hide();
                alegeJoc.ShowDialog();
                if (Application.OpenForms.Count != 0) { this.Show(); }
            }
            else
            {
                MessageBox.Show("Date de autentificare invalide!");
                emailtextBox.Text = "";
                parolatextBox.Text = "";
            }
        }

        private void singUpButton_Click(object sender, EventArgs e)
        {
            Inregistrare inregistrare = new Inregistrare();
            this.Hide();
            inregistrare.ShowDialog();
            this.Show();
        }

        private void qrButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" ;
            openFileDialog.InitialDirectory = "C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\Jocuri\\Resurse\\QRCode\\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                codeQRPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }

            MessagingToolkit.QRCode.Codec.QRCodeDecoder qRCodeDecoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
            string mesCodad = qRCodeDecoder.decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(codeQRPictureBox.Image as Bitmap)); 
            string[] split= mesCodad.Split('\n');
            emailtextBox.Text= split[1];
            parolatextBox.Text= split[2];
            autificareQr = true;
        }
    }
}
