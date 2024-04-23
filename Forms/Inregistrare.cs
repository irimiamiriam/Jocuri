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

namespace Jocuri.Forms
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private bool ValidEmail(string email)
        {

            if (email != null) {
                string[] splitByA = email.Split('@');
                if(splitByA.Length ==2 && !string.IsNullOrEmpty(splitByA[0]) && !string.IsNullOrEmpty(splitByA[1])) { 
                    foreach(char c in splitByA[0])
                    {
                        if(!char.IsLetterOrDigit(c) && c!='.' &&c!='_'&&c!='-')
                        { 
                            return false;
                        }
                    }
                    string[] splitByP = splitByA[1].Split('.');
                    if(splitByP.Length != 2 || !string.IsNullOrEmpty(splitByP[0]) || !string.IsNullOrEmpty(splitByP[1]) || splitByA[0].First()=='.'||splitByA[0].Last() == '.')
                    {
                        return false;
                    }

                }else { return false; }
            }else { return false;}
            return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
                if(ValidEmail(emailtextBox.Text)&&!(DatabaseHelper.EmailExists(emailtextBox.Text).Name!=null)&&conftextBox.Text==parolatextBox.Text)
                {
                   UserModel user = new UserModel();
                {
                    user.Name= numetextBox.Text;
                    user.Email= emailtextBox.Text;
                    user.Password   = parolatextBox.Text;
                }
                DatabaseHelper.InsertNewUser(user);
                this.Close();
                }
        }
    }
}
