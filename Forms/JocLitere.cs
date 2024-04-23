using Jocuri.Models;
using Jocuri.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Jocuri.Forms
{
    public partial class JocLitere : Form
    {
        public UserModel user = new UserModel();
        string cuvant1;
        string cuvant2;
        string cuvantales;
        int indLitera = 1;
        bool firstBall = true;
        bool cuvantRamas = true;
        int time = 100;
        Point initialLocation;
        public JocLitere()
        {
            InitializeComponent();
        }

        private void JocLitere_Load(object sender, EventArgs e)
        {
            initialLocation= pictureBoxMinge.Location;
            labelCuvant.Text = "";
            labelTimpRamas.Text = 100.ToString();
            timerGame.Start();
            timerLeft.Start();
            string workingdirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingdirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Imagini");
            var imaginipath = Directory.GetFiles(path);
            Random rnd = new Random();
            var imaginiRandom = imaginipath.OrderBy(i => (rnd.Next())).ToList();
            var imaginiPtPanouri = imaginiRandom.Take(2).ToArray();
            pictureBox1.Image = Image.FromFile(imaginiPtPanouri[0]);
            pictureBox2.Image = Image.FromFile(imaginiPtPanouri[1]);
            string[] fisierSplit1 = imaginiPtPanouri[0].Split(new string[] { @"\" }, StringSplitOptions.None);
            string[] fisierSplit2 = imaginiPtPanouri[1].Split(new string[] { @"\" }, StringSplitOptions.None);
            cuvant1= fisierSplit1[fisierSplit1.Length-1].Split('.').First();
            cuvant2 = fisierSplit2[fisierSplit2.Length - 1].Split('.').First();
            string cuvinteCombined = cuvant1+cuvant2;
            List<char> litere = new List<char>();
            foreach(char c in cuvinteCombined)
            {
                litere.Add(c);
            }
            litere = litere.OrderBy(i=> (rnd.Next())).ToList();
            int x = (panelJoc.Width -( litere.Count() * (pictureBoxMinge.Width *2)))/2;
            foreach (char c in litere)
            {   
                Label litera = new Label();
                litera.Width = pictureBoxMinge.Width;
                litera.Height = pictureBoxMinge.Height;
                litera.Text = c.ToString();
                litera.Font = label1.Font;
                litera.Location = new Point(x, 10);
                x += 2* pictureBoxMinge.Width;
                panelJoc.Controls.Add(litera);
            }

        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            time--;
            labelTimpRamas.Text = time.ToString();
        }

        private void JocLitere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBoxMinge.Left > pictureBoxMinge.Width)
                {
                    pictureBoxMinge.Left -= 10;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBoxMinge.Left < panelJoc.Width- pictureBoxMinge.Width)
                {
                    pictureBoxMinge.Left += 10;
                }
            }
            if(e.KeyCode == Keys.Up)
            {
                while(pictureBoxMinge.Top > 0)
                {
                    pictureBoxMinge.Top -= 10;
                    Task.Delay(50).Wait();
                    foreach(Control c in panelJoc.Controls)
                    {
                        if(c is Label)
                        {
                            if (pictureBoxMinge.Bounds.IntersectsWith(c.Bounds))
                            {
                                if (firstBall == true)
                                {
                                    if (c.Text[0] == cuvant1[0])
                                    {
                                        cuvantales = cuvant1; 
                                        labelCuvant.Text += c.Text;
                                        panelJoc.Controls.Remove(c);
                                        firstBall=false;

                                    }
                                   else  if (c.Text[0] == cuvant2[0])
                                    {
                                        cuvantales = cuvant2;
                                        labelCuvant.Text += c.Text;
                                        panelJoc.Controls.Remove(c);
                                        firstBall = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ai pierdut!");
                                        DatabaseHelper.InsertNewRezultat(1, user, 0);
                                        pictureBoxMinge.Location = initialLocation;
                                        this.Close();
                                        timerGame.Stop();
                                        timerLeft.Stop();
                                    }
                                }
                                else
                                {
                                    if(c.Text[0] == cuvantales[indLitera])
                                    {
                                        labelCuvant.Text += c.Text;
                                        panelJoc.Controls.Remove(c);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ai pierdut!");
                                        DatabaseHelper.InsertNewRezultat(1, user, 0);
                                        pictureBoxMinge.Location = initialLocation;
                                        this.Close();
                                        timerGame.Stop();
                                        timerLeft.Stop();
                                    }
                                    indLitera++;
                                }
                                if(labelCuvant.Text== cuvantales)
                                {
                                    if (cuvantRamas == true)
                                    {
                                        if (cuvant1 == cuvantales)
                                        {
                                           Controls.Remove(pictureBox1);
                                            cuvantales = cuvant2;
                                            labelCuvant.Text = "";
                                            cuvantRamas = false;
                                            firstBall=true;
                                            indLitera = 1;

                                        }
                                        else
                                        {
                                           Controls.Remove(pictureBox2);
                                            cuvantales = cuvant1;
                                            labelCuvant.Text = "";
                                            cuvantRamas = false;
                                            firstBall = true;
                                            indLitera = 1;
                                        }
                                    }else
                                    {
                                        if (cuvant1 == cuvantales)
                                        {
                                            Controls.Remove(pictureBox1);
                                            labelCuvant.Text = "";
                                           

                                        }
                                        else
                                        {
                                            Controls.Remove(pictureBox2);
                                        }
                                        MessageBox.Show("Ai castigat!");
                                        DatabaseHelper.InsertNewRezultat(1, user, time);
                                        timerGame.Stop();
                                        timerLeft.Stop();
                                        this.Close();
                                    }
                                }
                               
                               
                            }
                        }
                    }
                }
                pictureBoxMinge.Location= initialLocation;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            timerGame.Stop();
            timerLeft.Stop();
            MessageBox.Show("Ai pierdut!");
            DatabaseHelper.InsertNewRezultat(1, user, 0);

        }
    }
}
