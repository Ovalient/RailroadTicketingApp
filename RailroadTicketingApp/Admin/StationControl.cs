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
    public partial class StationControl : UserControl
    {
        public StationControl()
        {
            InitializeComponent();
        }

        private void SectionControl_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(
                this.Width / 2 - panel2.Size.Width / 2,
                this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;

            panel3.Location = new Point(
                this.Width / 2 - panel3.Size.Width / 2,
                this.Height / 2 - panel3.Size.Height / 2);
            panel3.Anchor = AnchorStyles.None;

            panel2.Visible = false;
            panel3.Visible = false;
            GetView();
        }

        private void GetView()
        {
            label10.Text = "정보 입력 후, 추가/삭제 버튼을 눌러주세요.";
            string cmd1 = "SELECT STATION_ID AS 순서, STATION_NAME AS 역이름, LEG_TIME AS 정차시간 FROM STATION ORDER BY STATION_ID";

            OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd1, OracleCnt);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);

            dataGridView1.DataSource = dataSet1.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.ForeColor = Color.Black;
            label10.Text = "'" + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString() + "'역 다음에 추가합니다.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (StationNameTextBox.Text != "" && StationIDTextBox.Text != "" && LegTimeTextBox.Text != "")
            {
                OracleCnt.Open();

                string cmd1 = "UPDATE STATION SET STATION_ID = STATION_ID + 1 WHERE STATION_ID > " + Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString()) + "";
                UpdateCmd.CommandText = cmd1;
                UpdateCmd.ExecuteNonQuery();

                string cmd2 = "INSERT INTO STATION (STATION_NAME, LEG_TIME, STATION_ID) VALUES ('" + StationNameTextBox.Text + "', " + LegTimeTextBox.Text + ", " + StationIDTextBox.Text + ")";
                InsertCmd.CommandText = cmd2;
                InsertCmd.ExecuteNonQuery();

                // SECTION_ASC
                string cmd3 = "INSERT INTO SECTION_ASC (DEPART_STN, ARRIVE_STN, TIME, PRICE) "
                    + "SELECT '" + StationNameTextBox.Text + "', ARRIVE_STN, TIME, PRICE "
                    + "FROM SECTION_ASC "
                    + "WHERE DEPART_STN = '" + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString() + "'";
                InsertCmd1.CommandText = cmd3;
                InsertCmd1.ExecuteNonQuery();

                string cmd4 = "UPDATE SECTION_ASC SET ARRIVE_STN = '" + StationNameTextBox.Text + "' WHERE DEPART_STN = '" + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString() + "'";
                UpdateCmd1.CommandText = cmd4;
                UpdateCmd1.ExecuteNonQuery();

                // SECTION_DESC
                string cmd5 = "INSERT INTO SECTION_DESC (DEPART_STN, ARRIVE_STN, TIME, PRICE) "
                    + "SELECT DEPART_STN, '" + StationNameTextBox.Text + "', TIME, PRICE "
                    + "FROM SECTION_DESC "
                    + "WHERE ARRIVE_STN = '" + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString() + "'";
                InsertCmd2.CommandText = cmd5;
                InsertCmd2.ExecuteNonQuery();

                string cmd6 = "UPDATE SECTION_DESC SET DEPART_STN = '" + StationNameTextBox.Text + "' WHERE ARRIVE_STN = '" + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString() + "'";
                UpdateCmd2.CommandText = cmd6;
                UpdateCmd2.ExecuteNonQuery();

                OracleCnt.Close();
                panel2.Visible = true;
                GetView();
            }
            else
            {
                label10.ForeColor = Color.Red;
                label10.Text = "정보를 정확히 입력해주세요.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void DecideButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int StationID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString());
            OracleCnt.Open();

            string cmd1 = "DELETE FROM STATION WHERE STATION_ID = " + StationID + "";
            DeleteCmd.CommandText = cmd1;
            DeleteCmd.ExecuteNonQuery();

            string cmd2 = "UPDATE STATION SET STATION_ID = STATION_ID - 1 WHERE STATION_ID > " + StationID + "";
            UpdateCmd3.CommandText = cmd2;
            UpdateCmd3.ExecuteNonQuery();

            OracleCnt.Close();
            panel3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
