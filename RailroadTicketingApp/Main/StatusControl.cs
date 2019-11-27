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
    public partial class StatusControl : UserControl
    {
        public String Passvalue
        {
            get { return this.UserIDLabel.Text; }
            set { this.UserIDLabel.Text = value; }
        }

        public StatusControl()
        {
            InitializeComponent();
        }

        private void StatusControl_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            DecideButton.Enabled = false;
            button4.Visible = false;

            panel1.Location = new Point(
                this.Width / 2 - panel1.Size.Width / 2,
                this.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel2.Location = new Point(
                this.Width / 2 - panel2.Size.Width / 2,
                this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }

        private DataSet GetData()
        {
            string cmd = "SELECT SEQ AS 예매번호, USER_ID AS 사용자ID, TRAIN_ID AS 열차번호, SEAT_ID AS 좌석, DEPART_STN AS 출발역, DEPART_TIME AS 출발시간, ARRIVE_TIME AS 도착역, ARRIVE_STN AS 도착시간, TOTAL_FEE AS 요금 "
                + "FROM BOOKING "
                + "WHERE USER_ID = '" + UserIDLabel.Text + "' "
                + "ORDER BY TRAIN_ID";

            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd, OracleCnt);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        private void UserIDLabel_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = GetData();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void DecideButton_Click(object sender, EventArgs e)
        {
            label2.Text = "정말 취소하겠습니까?";
            DecideButton.Enabled = false;
            label2.Visible = true;
            panel2.Visible = true;
            label3.Visible = true;
            button4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "성공적으로 취소되었습니다.";
            label3.Visible = false;
            button4.Visible = true;

            OracleCnt.Open();

            string cmd = "DELETE FROM BOOKING WHERE SEQ = " + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString() + "";
            DeleteCmd.CommandText = cmd;
            DeleteCmd.ExecuteNonQuery();
            OracleCnt.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            DataSet dataSet = GetData();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DecideButton.Enabled = true;
        }
    }
}
