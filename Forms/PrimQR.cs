using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Jocuri.Models;
using Jocuri.SqlDataAccess;
using MessagingToolkit.QRCode.Codec.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Jocuri.Forms
{
    public partial class PrimQR : Form
    {
        public PrimQR()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
           

            List<RezultateModel> rezultate = DatabaseHelper.GetAllRezultate();
            List<RezultateModel> rezultateOrdonate = rezultate.OrderByDescending(i=>i.Email).ToList();
            int distMax = 0;
            int dist = 0;
            string emailGasit="";
            foreach(var rez in rezultateOrdonate)
            {
                int nr = rez.Rezultate + 1;
                bool prim = false;
                while (prim == false)
                {
                    int d = 1;
                    for(int i=1; i< Math.Sqrt(nr); i++)
                    {
                        if (nr % i == 0) { d++; }
                    }
                    if(d==2)
                    {
                        prim = true;
                    }
                    nr++;
                }
                dist = nr- rez.Rezultate;
                if(dist>distMax)
                {
                    distMax= dist;
                    emailGasit = rez.Email;
                }
            }
            UserModel user = DatabaseHelper.EmailExists(emailGasit);
            string msjCodat = user.Name.Trim() + "\n" + user.Email.Trim() + "\n" + user.Password.Trim();
            
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 8;
            Bitmap bmp = encoder.Encode(msjCodat);
            codQRPictureBox.Image = bmp;
            Image logo = Image.FromFile(@"C:\Users\Miriam\Documents\Aplicatii C\CSHARP Nationala\Jocuri\Resurse\Logo_C#.ico");
            Bitmap qr = new Bitmap(codQRPictureBox.Image);
            Graphics graphics = Graphics.FromImage(qr);
            graphics.DrawImage(logo, codQRPictureBox.Width / 2 - 25, codQRPictureBox.Height / 2 - 25, 50, 50);
            codQRPictureBox.Image = qr;
        }
    }
}
