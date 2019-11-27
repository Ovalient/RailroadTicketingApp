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
    public partial class SectionControl : UserControl
    {
        public SectionControl()
        {
            InitializeComponent();
        }

        private void SectionControl_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            panel2.Location = new Point(
                this.Width / 2 - panel2.Size.Width / 2,
                this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;

            GetDown();
        }

        private void GetDown()
        {
            OracleCnt.Open();
            string cmd1 = "SELECT DEPART_STN AS 출발역, ARRIVE_STN AS 도착역, TIME AS 소요시간, PRICE AS 구간요금 FROM SECTION_ASC";

            OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd1, OracleCnt);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);

            dataGridView1.DataSource = dataSet1.Tables[0];
            OracleCnt.Close();
        }

        private void GetUp()
        {
            OracleCnt.Open();
            string cmd1 = "SELECT DEPART_STN AS 출발역, ARRIVE_STN AS 도착역, TIME AS 소요시간, PRICE AS 구간요금 FROM SECTION_DESC";

            OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd1, OracleCnt);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);

            dataGridView1.DataSource = dataSet1.Tables[0];
            OracleCnt.Close();
        }

        private void LineDirectionBox_CheckedChanged(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;
            label10.Text = "정보 입력 후, 저장 버튼을 눌러주세요.";
            DepartLabel.Text = "";
            ArriveLabel.Text = "";
            TimeTextBox.Text = "";
            PriceTextBox.Text = "";

            if (LineDirectionBox.Checked) // 상행선
            {
                LineDirectionBox.Text = "↑상행선 ";

                GetDown();
            }
            else
            {
                LineDirectionBox.Text = "↓하행선 ";

                GetUp();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DepartLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            ArriveLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TimeTextBox.Text != "" && PriceTextBox.Text != "")
            {
                OracleCnt.Open();

                if (LineDirectionBox.Checked)
                {
                    string cmd1 = "UPDATE SECTION_ASC SET TIME = '" + TimeTextBox.Text + "', PRICE = '" + PriceTextBox.Text + "' "
                        + "WHERE DEPART_STN = '" + DepartLabel.Text + "' AND ARRIVE_STN = '" + ArriveLabel.Text + "'";
                    UpdateCmd.CommandText = cmd1;
                    UpdateCmd.ExecuteNonQuery();

                    string cmd2 = "UPDATE SECTION_DESC SET TIME = '" + TimeTextBox.Text + "', PRICE = '" + PriceTextBox.Text + "' "
                        + "WHERE DEPART_STN = '" + ArriveLabel.Text + "' AND ARRIVE_STN = '" + DepartLabel.Text + "'";
                    UpdateCmd1.CommandText = cmd2;
                    UpdateCmd1.ExecuteNonQuery();
                }
                else
                {
                    string cmd1 = "UPDATE SECTION_DESC SET TIME = '" + TimeTextBox.Text + "', PRICE = '" + PriceTextBox.Text + "' "
                        + "WHERE DEPART_STN = '" + DepartLabel.Text + "' AND ARRIVE_STN = '" + ArriveLabel.Text + "'";
                    UpdateCmd.CommandText = cmd1;
                    UpdateCmd.ExecuteNonQuery();

                    string cmd2 = "UPDATE SECTION_ASC SET TIME = '" + TimeTextBox.Text + "', PRICE = '" + PriceTextBox.Text + "' "
                        + "WHERE DEPART_STN = '" + ArriveLabel.Text + "' AND ARRIVE_STN = '" + DepartLabel.Text + "'";
                    UpdateCmd1.CommandText = cmd2;
                    UpdateCmd1.ExecuteNonQuery();
                }

                OracleCnt.Close();
                panel2.Visible = true;
                LineDirectionBox.Checked = true;
                GetDown();
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
    }
}
