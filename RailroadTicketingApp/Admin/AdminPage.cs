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
    public partial class AdminPage : Form
    {
        StationControl stationControl = new StationControl();
        SectionControl sectionControl = new SectionControl();
        IntervalControl intervalControl = new IntervalControl();
        CalculateControl calculateControl = new CalculateControl();

        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            Container.Controls.Add(stationControl);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(stationControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(sectionControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(intervalControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(calculateControl);
        }

        private void QuitButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
