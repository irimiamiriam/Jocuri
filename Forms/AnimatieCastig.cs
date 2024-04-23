using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Forms
{
    public partial class AnimatieCastig : Form
    {
        int nextImage = 0;
        string[] filepaths;
        public AnimatieCastig()
        {
            InitializeComponent();
        }

        private void AnimatieCastig_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Artificii");
            filepaths = Directory.GetFiles(path);
            timerFinal.Start();
            timerNext.Start();
         
        }

        private void timerNext_Tick(object sender, EventArgs e)
        {
                foreach (Control pictureBox in Controls)
                {
                    if (pictureBox is PictureBox)
                    {
                       
                        pictureBox.BackgroundImage = Image.FromFile(filepaths[nextImage]);
                    }
                }

            nextImage++;
        }

        private void timerFinal_Tick(object sender, EventArgs e)
        {
            timerFinal.Stop();
            timerNext.Stop();
            this.Close();
        }
    }
}
