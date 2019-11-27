using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;

namespace RailroadTicketingApp
{
    public partial class HomeControl : UserControl
    {

        public String Passvalue
        {
            get { return this.UsernameLabel.Text; }
            set { this.UsernameLabel.Text = value; }
        }

        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            label3.Text = "초등학생 이하\n"
                + "초등학생 - 고등학생\n"
                + "60세 - 70세\n"
                + "70세 이상\n";
            label4.Text = "50%\n30%\n30%\n50%\n";
            label8.Text = "|\n|\n|\n|\n";
            label9.Text = "오전 |   3℃\n오후 | 12℃";
            button2.Text = "          '18.11.20. 오송역 단전 사고로 불편을 겪으신\n          고객 여러분께 진심으로 사과드립니다.\n";

            panel1.Location = new Point(
                this.Width / 2 - panel1.Size.Width / 2,
                this.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void GetCity()
        {
            OracleCnt.Open();

            String CityName = "";
            string cmd = "SELECT CITY FROM PASSENGER WHERE USER_ID = '" + UsernameLabel.Text + "'";
            GetCityCmd.CommandText = cmd;
            OracleDataReader reader = GetCityCmd.ExecuteReader();
            while (reader.Read())
            {
                CityName = reader["CITY"].ToString();
            }

            label7.Text = CityName;

            OracleCnt.Close();
        }

        private void UsernameLabel_TextChanged(object sender, EventArgs e)
        {
            GetCity();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://korean1.visitkorea.or.kr/kor/bz15/where/where_main_search.jsp?cid=125913");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.letskorail.com/ebizcom/event/total/EbizcomEventTotallw_cus06101_detail.do?searchKeyword2=1391");
        }
    }
}
