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
using System.Windows.Forms.DataVisualization.Charting;

namespace Jocuri.Forms
{
    public partial class AlegeJoc : Form
    {
         public UserModel user = new UserModel();
        public AlegeJoc()
        {
            InitializeComponent();
        }

        private void AlegeJoc_Load(object sender, EventArgs e)
        {
            labelUtilizator.Text="Bine ai venit, "+ user.Name.Trim()+ " ("+ user.Email+")";

            InsertRezultate0();
            InsertRezultate1();

        }

        private void InsertRezultate1()
        {
            
            Series seriejoc1 = new Series("Popice cu litere");
            seriejoc1.ChartType = SeriesChartType.Line;
            seriejoc1.Color = Color.BlueViolet;
            var rezultate = DatabaseHelper.GetRezultateJoc(1).OrderBy(x => x.Data).GroupBy(x => x.Data).Select(x => x.Last()).ToList();
            foreach (var rez in rezultate)
            {
                seriejoc1.Points.AddXY(rez.Data, rez.Rezultate);


            }

            chartRezultate.Series.Add(seriejoc1);
            Legend legend = new Legend("Rezultate");
            legend.Docking = Docking.Bottom;
            chartRezultate.Legends.Add(legend);
            chartRezultate.Series[1].IsValueShownAsLabel = true;
        }

        private void InsertRezultate0()
        {
            chartRezultate.ChartAreas.Clear();
            chartRezultate.Series.Clear();
            chartRezultate.ChartAreas.Add(new ChartArea());
            Series seriejoc0 = new Series("Testeaza memoria"); 
            seriejoc0.Color = Color.Red;
            seriejoc0.ChartType= SeriesChartType.Line;
            var rezultate = DatabaseHelper.GetRezultateJoc(0).OrderBy(x => x.Data).GroupBy(x=>x.Data).Select(x=>x.Last()).ToList();
            foreach(var rez in  rezultate)
            {
                seriejoc0.Points.AddXY(rez.Data, rez.Rezultate);
                
              
            }
            
            chartRezultate.Series.Add(seriejoc0);
           chartRezultate.Series[0].IsValueShownAsLabel = true;

        }

        private void jocMemorieButton_Click(object sender, EventArgs e)
        {
            JocMemorie jocMemorie = new JocMemorie();
            jocMemorie.user= user;
            this.Hide();
            jocMemorie.ShowDialog();
            this.Show();
            InsertRezultate0();
            InsertRezultate1();
        }

        private void jocLitereButton_Click(object sender, EventArgs e)
        {
            JocLitere jocLitere = new JocLitere();
            jocLitere.user= user;
            this.Hide();
            jocLitere.ShowDialog();
            this.Show();
            InsertRezultate0();
            InsertRezultate1();
        }

        private void primQRButton_Click(object sender, EventArgs e)
        {
            PrimQR jocQR = new PrimQR();
            this.Hide(); 
            jocQR.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
