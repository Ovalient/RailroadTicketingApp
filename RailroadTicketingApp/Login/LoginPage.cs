using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailroadTicketingApp
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();

            SignInControl signInControl = new SignInControl();
            Container.Controls.Add(signInControl);
        }

        private void QuitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MainPage Main = new MainPage();
            Main.Show();
        }

        private void panel8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nscorp.com/content/nscorp/en.html");
        }
    }
}
