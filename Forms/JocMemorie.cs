using Jocuri.Models;
using Jocuri.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.XPath;

namespace Jocuri.Forms
{
    public partial class JocMemorie : Form
    {
        public UserModel user = new UserModel();
        int nrpanouri = 0;
        int punctaj = 0;
        int n = 3;
        int time = 100;
        int panouriClick = 0;
        int panouriGhicite = 0;
        string[] imaginipath;
        Label labelClicked=new Label();
        PictureBox pictureClicked;
        private string[] imaginiPtPanouri;
        private string[] fisierPtPanouri;

        public JocMemorie()
        {
            InitializeComponent();
        
          
        }

        private void JocMemorie_Load(object sender, EventArgs e)
        {
            
            string workingdirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingdirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Imagini");
            imaginipath = Directory.GetFiles(path);
           
        }

        private void ResetJoc()
        {   
            panelPanouri.Controls.Clear(); 
            buttonStart.Enabled = false;
            timerGame.Start();
            panouriGhicite = 0;
            time = 100;
            labelTimeLeft.Text = 10.ToString();
            timerGame.Start();
            timerTimeLeft.Start();
            labelClicked = new Label();
            pictureClicked= new PictureBox();
            panouriClick = 0;
            nrpanouri = 2 * GenerareNumarPanouri(n);
            ImaginiPanouri(nrpanouri/2);
           
        }

        private int GenerareNumarPanouri(int nr)
        {
            if (nr <= 2) { return 1; }
            else return GenerareNumarPanouri(nr - 1)+ GenerareNumarPanouri(nr - 2);
        }

        private void ImaginiPanouri(int n)
        {
            
           
            Random rnd = new Random();
           
            var imaginiRandom = imaginipath.OrderBy(i => (rnd.Next())).ToList();
           

             imaginiPtPanouri = imaginiRandom.Take(n).ToArray();
             fisierPtPanouri = imaginiPtPanouri.OrderBy(i => (rnd.Next())).ToArray();
         
            int x = 77;
            int y = 38;

            for(int i=0; i<n; i++) 
            {   
                string[] fisier1 = fisierPtPanouri[i].Split(new string[] {@"\"}, StringSplitOptions.None);
                string[] fisier2 = imaginiPtPanouri[i].Split(new string[] { @"\" }, StringSplitOptions.None);

                PictureBox panou  = new PictureBox();
                panou.Width = 70;
                panou.Height = 60;
                panou.Location = new Point(x,y);
                panou.SizeMode= PictureBoxSizeMode.StretchImage;
                panou.Tag= fisier2[fisier2.Length - 1];
                panou.BackColor= Color.Cyan;
                panou.MouseClick += pictureBox1_MouseClick;
                panelPanouri.Controls.Add(panou);
                

                Label panouCuvant = new Label();
                panouCuvant.Width = 70;
                panouCuvant.Height = 60;
                panouCuvant.Location = new Point(x, y+80);
                panouCuvant.BackColor = Color.Cyan;
                panouCuvant.ForeColor= Color.White;
                panouCuvant.Tag = fisier1[fisier1.Length-1];
                panouCuvant.MouseClick += label1_MouseClick;
                panelPanouri.Controls.Add(panouCuvant);
                
                x += 70 + 10;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panouriClick++;
            PictureBox panou = (PictureBox)sender;
            string workingdirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingdirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Imagini", panou.Tag.ToString());
            panou.Image= Image.FromFile(path);
            if (panouriClick != 2)
            {
                pictureClicked = panou;
            }
            else
            {
                panouriClick = 0;
             if (labelClicked.Text == panou.Tag.ToString())
                {
                    for (int i = 0; i < nrpanouri; i++)
                    {
                        string[] fisier = imaginiPtPanouri[i].Split(new string[] { @"\" }, StringSplitOptions.None);
                        if (fisier[fisier.Length - 1] == labelClicked.Text)
                        {
                            punctaj += 2;
                            panouriGhicite += 2;
                            labelClicked.Text = i + "-" + labelClicked.Text;
                            
                            panou.Enabled = false;
                            labelClicked.Enabled = false;
                            break;

                        }

                    }
                   
                }
                else
                {
                    panou.Text = "";
                    pictureClicked.Image = null;
                }

            }
            if (panouriGhicite == nrpanouri)
            {
                timerGame.Stop();
                timerTimeLeft.Stop();
                AnimatieCastig animatieCastig = new AnimatieCastig(); 
                this.Hide();
                animatieCastig.ShowDialog();
                this.Show();
                buttonStart.Enabled = true;
                n++;
                if (n == 7)
                {
                    MessageBox.Show("Ai castigat toate rundele!");
                    DatabaseHelper.InsertNewRezultat(0, user, punctaj);

                    this.Close();
                }
                else
                {
                    ResetJoc();
                }

            }


        }
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {   panouriClick++;
            Label panou = (Label)sender;
            panou.Text = panou.Tag.ToString();
           
            if (panouriClick != 2)
            {
                labelClicked= panou;
            }else
            {
                panouriClick = 0;
               

                if (panou.Text == pictureClicked.Tag.ToString())
                {
                    for(int i=0; i<nrpanouri; i++)
                    {
                        string[] fisier = imaginiPtPanouri[i].Split(new string[] { @"\" }, StringSplitOptions.None);
                        if(fisier[fisier.Length - 1] == panou.Text)
                        {

                            punctaj += 2;
                            panouriGhicite += 2; panou.Text= i+ "-" + panou.Text;
                            panou.Enabled = false;
                            pictureClicked.Enabled= false;
                            break;
                           
                        }

                    }
                   
                } else
                    {
                        panou.Text = "";
                        pictureClicked.Image = null;
                    }
            }
            if(panouriGhicite==nrpanouri) {
              
                timerGame.Stop();
                timerTimeLeft.Stop();
                AnimatieCastig animatieCastig = new AnimatieCastig();
                this.Hide();
                animatieCastig.ShowDialog();
                this.Show();
                buttonStart.Enabled = true;
                n++;
                if (n == 7)
                {
                    MessageBox.Show("Ai castigat toate rundele!");
                    DatabaseHelper.InsertNewRezultat(0, user, punctaj);

                    this.Close();
                }
                else {
                    ResetJoc(); }
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        { 
            timerTimeLeft.Stop();
            MessageBox.Show("Ai pierdut!");
            n = 3;
            panelPanouri.Controls.Clear();
            DatabaseHelper.InsertNewRezultat(0,user, punctaj);
            this.Close();
        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            time--;
            labelTimeLeft.Text = time.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetJoc();
        }
    }
}
