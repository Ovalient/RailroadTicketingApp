using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;

namespace RailroadTicketingApp
{
    public partial class MainPage : Form
    {
        HomeControl homeControl = new HomeControl();
        TimetableControl timetableControl = new TimetableControl();
        ReservationControl reservationControl = new ReservationControl();
        StatusControl statusControl = new StatusControl();

        AdminPage adminPage = new AdminPage();

        public String Passvalue
        {
            get { return this.IDButton.Text; }
            set { this.IDButton.Text = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            timer1.Start();
            Container.Controls.Add(homeControl);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            homeControl.Passvalue = IDButton.Text;

            if (IDButton.Text == "Administrator")
            {
                flowLayoutPanel3.Visible = true;
                AdminButton.Visible = true;
            }
            else
            {
                flowLayoutPanel3.Visible = false;
                AdminButton.Visible = false;
            }
        }

        private void QuitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(homeControl);
            label2.Text = "HOME";
        }

        private void TimetableButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(timetableControl);
            label2.Text = "TIMETABLE";
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(reservationControl);
            reservationControl.Passvalue = IDButton.Text;
            label2.Text = "TICKETING";
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(statusControl);
            statusControl.Passvalue = IDButton.Text;
            label2.Text = "RESERVATION STATUS";
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            adminPage.Visible = true;
        }
    }
}
