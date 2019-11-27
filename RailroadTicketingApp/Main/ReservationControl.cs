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
    public partial class ReservationControl : UserControl
    {
        bool Toggle = false;

        public String Passvalue
        {
            get { return this.UserIDLabel.Text; }
            set { this.UserIDLabel.Text = value; }
        }

        public ReservationControl()
        {
            InitializeComponent();
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            LineDirectionBox.Checked = true;
            InformationPanel.Visible = false;
            DecideButton.Enabled = false;
            TrainPanel.Visible = false;
            panel2.Visible = false;

            WarningLabel.Text = "원하는 열차를 선택하면 예약 상태가 표시됩니다.";

            ReservationPanel.Location = new Point(
                this.Width / 2 - ReservationPanel.Size.Width / 2,
                this.Height / 2 - ReservationPanel.Size.Height / 2);
            ReservationPanel.Anchor = AnchorStyles.None;

            panel2.Location = new Point(
                this.Width / 2 - panel2.Size.Width / 2,
                this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;

            OracleCnt.Open();
            string cmd = "SELECT STATION_NAME FROM STATION";
            oracleCommand1.CommandText = cmd;
            OracleDataReader reader = oracleCommand1.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["STATION_NAME"].ToString());
                comboBox2.Items.Add(reader["STATION_NAME"].ToString());
            }
            OracleCnt.Close();
            Toggle = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DecideButton.Enabled = false;
            WarningLabel.Text = "원하는 열차를 선택하면 예약 상태가 표시됩니다.";

            AlertLabel.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            if (LineDirectionBox.Text == "↑상행선 ")
            {
                LineDirectionBox.Text = "↓하행선 ";
                OracleCnt.Open();

                string cmd = "SELECT STATION_NAME FROM STATION";
                oracleCommand1.CommandText = cmd;
                OracleDataReader reader = oracleCommand1.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["STATION_NAME"].ToString());
                }
                OracleCnt.Close();
                Toggle = true;
            }
            else
            {
                LineDirectionBox.Text = "↑상행선 ";
                OracleCnt.Open();

                string cmd = "SELECT STATION_NAME FROM STATION";
                oracleCommand1.CommandText = cmd;
                OracleDataReader reader = oracleCommand1.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["STATION_NAME"].ToString());
                }
                OracleCnt.Close();
                Toggle = false;
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (CheckBox c in panel1.Controls)
                {
                    c.BackColor = Color.RoyalBlue;
                    c.Checked = false;
                }

                if (Toggle) // 하행선
                {
                    string cmd1 = "SELECT TT1.TRAIN_ID AS 열차번호, TT2.DEPART_STN_NAME AS 출발역, TO_CHAR(TT2.DEPART_TIME, 'HH24:MI') AS 출발시간, TT1.ARRIVE_STN_NAME AS 도착역, TO_CHAR(TT1.ARRIVE_TIME, 'HH24:MI') AS 도착시간 "
                        + "FROM TIMETABLE TT1, TIMETABLE TT2 "
                        + "WHERE TT1.TRAIN_ID = TT2.TRAIN_ID "
                        + "AND TT2.DEPART_STN_NAME = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "AND TT1.ARRIVE_STN_NAME = '" + comboBox2.SelectedItem.ToString() + "' "
                        + "AND TT1.DIRECTION = 'down'";

                    OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd1, OracleCnt);
                    DataSet dataSet1 = new DataSet();
                    dataAdapter1.Fill(dataSet1);

                    dataGridView1.DataSource = dataSet1.Tables[0];
                }
                else // 상행선
                {
                    string cmd1 = "SELECT TT1.TRAIN_ID AS 열차번호, TT2.DEPART_STN_NAME AS 출발역, TO_CHAR(TT2.DEPART_TIME, 'HH24:MI') AS 출발시간, TT1.ARRIVE_STN_NAME AS 도착역, TO_CHAR(TT1.ARRIVE_TIME, 'HH24:MI') AS 도착시간 "
                        + "FROM TIMETABLE TT1, TIMETABLE TT2 "
                        + "WHERE TT1.TRAIN_ID = TT2.TRAIN_ID "
                        + "AND TT2.DEPART_STN_NAME = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "AND TT1.ARRIVE_STN_NAME = '" + comboBox2.SelectedItem.ToString() + "' "
                        + "AND TT1.DIRECTION = 'up'";

                    OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd1, OracleCnt);
                    DataSet dataSet1 = new DataSet();
                    dataAdapter1.Fill(dataSet1);

                    dataGridView1.DataSource = dataSet1.Tables[0];
                }
                DecideButton.Enabled = true;
            }
            catch (Exception ex)
            {
                AlertLabel.Text = "이용할 역을 선택해주세요.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DecideButton.Enabled = false;
            WarningLabel.Text = "원하는 열차를 선택하면 예약 상태가 표시됩니다.";
            AlertLabel.Text = "";
            foreach (CheckBox c in panel1.Controls)
            {
                c.Checked = false;
            }

            if (Toggle) // 하행선
            {
                comboBox2.Items.Clear();
                string selected = comboBox1.SelectedItem.ToString();

                dataGridView1.DataSource = null;

                OracleCnt.Open();

                string cmd = "SELECT STATION_NAME FROM STATION";
                oracleCommand1.CommandText = cmd;
                OracleDataReader reader = oracleCommand1.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["STATION_NAME"].ToString());
                }
                OracleCnt.Close();

                /*switch (selected)
                {
                    case "서울":
                        comboBox2.Items.Add("천안");
                        comboBox2.Items.Add("대전");
                        comboBox2.Items.Add("대구");
                        comboBox2.Items.Add("부산");
                        break;
                    case "천안":
                        comboBox2.Items.Add("대전");
                        comboBox2.Items.Add("대구");
                        comboBox2.Items.Add("부산");
                        break;
                    case "대전":
                        comboBox2.Items.Add("대구");
                        comboBox2.Items.Add("부산");
                        break;
                    case "대구":
                        comboBox2.Items.Add("부산");
                        break;
                }*/
            }
            else
            {
                comboBox2.Items.Clear();
                string selected = comboBox1.SelectedItem.ToString();

                dataGridView1.DataSource = null;

                OracleCnt.Open();

                string cmd = "SELECT STATION_NAME FROM STATION";
                oracleCommand1.CommandText = cmd;
                OracleDataReader reader = oracleCommand1.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["STATION_NAME"].ToString());
                }
                OracleCnt.Close();

                /*switch (selected)
                {
                    case "부산":
                        comboBox2.Items.Add("대구");
                        comboBox2.Items.Add("대전");
                        comboBox2.Items.Add("천안");
                        comboBox2.Items.Add("서울");
                        break;
                    case "대구":
                        comboBox2.Items.Add("대전");
                        comboBox2.Items.Add("천안");
                        comboBox2.Items.Add("서울");
                        break;
                    case "대전":
                        comboBox2.Items.Add("천안");
                        comboBox2.Items.Add("서울");
                        break;
                    case "천안":
                        comboBox2.Items.Add("서울");
                        break;
                }*/
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleCnt.Open();

            TrainPanel.Visible = true;
            ReservationPanel.Location = new Point(15, 15);
            InformationPanel.Visible = true;
            TrainNumber.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString() + "번";

            string cmd = "SELECT SEAT_ID FROM BOOKING WHERE TRAIN_ID = " + dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            BookStatusCmd.CommandText = cmd;
            OracleDataReader reader = BookStatusCmd.ExecuteReader();
            while (reader.Read())
            {
                foreach (CheckBox c in panel1.Controls)
                {
                    if (c.Text == reader["SEAT_ID"].ToString())
                    {
                        c.BackColor = Color.Crimson;
                    }
                }
            }
            reader.Close();
            OracleCnt.Close();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;            

            if (checkBox.BackColor == Color.RoyalBlue)
            {
                OracleCnt.Open();

                List<String> list = new List<String>();
                String str = "";
                var checkedBoxes = 0;

                WarningLabel.Text = "원하는 열차를 선택하면 예약 상태가 표시됩니다.";
                TrainNumberLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
                DepartStnLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                DepartTimeLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString();
                ArriveStnLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString();
                ArriveTimeLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString();

                string cmd1 = "SELECT AGE FROM PASSENGER WHERE USER_ID = '" + UserIDLabel.Text + "'";

                AgeCmd.CommandText = cmd1;

                OracleDataReader reader1 = AgeCmd.ExecuteReader();
                while (reader1.Read())
                    AgeLabel.Text = reader1["AGE"].ToString();
                reader1.Close();

                foreach (CheckBox c in panel1.Controls)
                {
                    if (c.Checked)
                    {
                        list.Add(c.Text);
                        str += c.Text + ", ";
                        checkedBoxes++;
                    }
                }
                try
                {
                    str = str.Trim();
                    str = str.Substring(0, str.Length - 1);
                    SeatNumberLabel.Text = str;
                }
                catch (Exception ex)
                {
                    SeatNumberLabel.Text = "";
                }

                if (Toggle) // 하행선
                {
                    string cmd2 = "WITH DESTINATIONS (DEPART_STN, ARRIVE_STN, COST) AS "
                        + "(SELECT A.DEPART_STN, A.ARRIVE_STN, PRICE "
                        + "FROM SECTION_DESC A "
                        + "WHERE A.DEPART_STN = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "UNION ALL "
                        + "SELECT R.DEPART_STN, B.ARRIVE_STN, R.COST + B.PRICE "
                        + "FROM DESTINATIONS R, SECTION_DESC B "
                        + "WHERE R.ARRIVE_STN = B.DEPART_STN) "
                        + "SELECT DEPART_STN DEPARTURE, ARRIVE_STN ARRIVAL, COST "
                        + "FROM DESTINATIONS "
                        + "WHERE ARRIVE_STN = '" + comboBox2.SelectedItem.ToString() + "'";

                    CostDescCmd.CommandText = cmd2;

                    OracleDataReader reader2 = CostDescCmd.ExecuteReader();
                    while (reader2.Read())
                    {
                        int Cost = Convert.ToInt32(reader2["COST"]);
                        int Age = Convert.ToInt32(AgeLabel.Text);

                        if (Age < 20 && Age > 13) // 나이에 따른 가격 할인
                        {
                            CostLabel.Text = (Cost * 0.7 * checkedBoxes).ToString();
                        }
                        else if (Age < 70 && Age > 60)
                        {
                            CostLabel.Text = (Cost * 0.7 * checkedBoxes).ToString();
                        }
                        else if (Age >= 70)
                        {
                            CostLabel.Text = (Cost * 0.5 * checkedBoxes).ToString();
                        }
                        else if (Age <= 13)
                        {
                            CostLabel.Text = (Cost * 0.5 * checkedBoxes).ToString();
                        }
                        else
                        {
                            CostLabel.Text = Convert.ToString(Cost * checkedBoxes);
                        }
                    }
                    reader2.Close();
                }
                else
                {
                    string cmd3 = "WITH DESTINATIONS (DEPART_STN, ARRIVE_STN, COST) AS "
                        + "(SELECT A.DEPART_STN, A.ARRIVE_STN, PRICE "
                        + "FROM SECTION_ASC A "
                        + "WHERE A.DEPART_STN = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "UNION ALL "
                        + "SELECT R.DEPART_STN, B.ARRIVE_STN, R.COST + B.PRICE "
                        + "FROM DESTINATIONS R, SECTION_ASC B "
                        + "WHERE R.ARRIVE_STN = B.DEPART_STN) "
                        + "SELECT DEPART_STN DEPARTURE, ARRIVE_STN ARRIVAL, COST "
                        + "FROM DESTINATIONS "
                        + "WHERE ARRIVE_STN = '" + comboBox2.SelectedItem.ToString() + "'";

                    CostAscCmd.CommandText = cmd3;

                    OracleDataReader reader3 = CostAscCmd.ExecuteReader();
                    while (reader3.Read())
                    {
                        int Cost = Convert.ToInt32(reader3["COST"]);
                        int Age = Convert.ToInt32(AgeLabel.Text);

                        if (Age < 20 && Age > 13) // 나이에 따른 가격 할인
                        {
                            CostLabel.Text = (Cost * 0.7 * checkedBoxes).ToString();
                        }
                        else if (Age < 70 && Age > 60)
                        {
                            CostLabel.Text = (Cost * 0.7 * checkedBoxes).ToString();
                        }
                        else if (Age >= 70)
                        {
                            CostLabel.Text = (Cost * 0.5 * checkedBoxes).ToString();
                        }
                        else if (Age <= 13)
                        {
                            CostLabel.Text = (Cost * 0.5 * checkedBoxes).ToString();
                        }
                        else
                        {
                            CostLabel.Text = Convert.ToString(Cost * checkedBoxes);
                        }
                    }
                    reader3.Close();
                }
                OracleCnt.Close();
            }
            else
            {
                foreach (CheckBox c in panel1.Controls)
                {
                    c.Checked = false;
                }
                InformationPanel.Visible = false;
                WarningLabel.Text = "예약할 수 없는 좌석입니다.";
            }
        }

        private void DecideButton_Click(object sender, EventArgs e)
        {
            OracleCnt.Open();

            var checkedBoxes = 0;

            foreach (CheckBox c in panel1.Controls)
            {
                if (c.Checked)
                {
                    checkedBoxes++;
                }
            }

            foreach (CheckBox c in panel1.Controls)
            {
                if (c.Checked)
                {
                    string cmd = "INSERT INTO BOOKING VALUES(:PARAM1, :PARAM2, :PARAM3, :PARAM4, :PARAM5, :PARAM6, :PARAM7, :PARAM8, BOOK_SEQ.NEXTVAL)";

                    DecideCmd.CommandText = cmd;

                    DecideCmd.Parameters["PARAM1"].Value = UserIDLabel.Text;
                    DecideCmd.Parameters["PARAM2"].Value = TrainNumberLabel.Text;
                    DecideCmd.Parameters["PARAM3"].Value = c.Text;
                    DecideCmd.Parameters["PARAM4"].Value = DepartStnLabel.Text;
                    DecideCmd.Parameters["PARAM5"].Value = ArriveStnLabel.Text;
                    DecideCmd.Parameters["PARAM6"].Value = DepartTimeLabel.Text;
                    DecideCmd.Parameters["PARAM7"].Value = ArriveTimeLabel.Text;
                    DecideCmd.Parameters["PARAM8"].Value = (Convert.ToInt32(CostLabel.Text) / checkedBoxes).ToString();

                    DecideCmd.ExecuteNonQuery();
                }
            }
            panel2.Visible = true;

            OracleCnt.Close();

            ReservationPanel.Location = new Point(
                this.Width / 2 - ReservationPanel.Size.Width / 2,
                this.Height / 2 - ReservationPanel.Size.Height / 2);
            ReservationPanel.Anchor = AnchorStyles.None;

            InformationPanel.Visible = false;
            LineDirectionBox.Checked = true;
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == Color.RoyalBlue)
            {
                OracleCnt.Open();

                ReservationPanel.Location = new Point(15, 15);
                InformationPanel.Visible = true;
                WarningLabel.Text = "원하는 열차를 선택하면 예약 상태가 표시됩니다.";

                /*string cmd1 = "SELECT AGE FROM PASSENGER WHERE USER_ID = '" + UserIDLabel.Text + "'";

                AgeCmd.CommandText = cmd1;

                OracleDataReader reader1 = AgeCmd.ExecuteReader();
                while(reader1.Read())
                    AgeLabel.Text = reader1["AGE"].ToString();
                reader1.Close();*/

                TrainNumberLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
                SeatNumberLabel.Text = button.Text;

                DepartStnLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                DepartTimeLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString();
                ArriveStnLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString();
                ArriveTimeLabel.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString();

                if (Toggle) // 하행선
                {
                    string cmd2 = "WITH DESTINATIONS (DEPART_STN, ARRIVE_STN, COST) AS "
                        + "(SELECT A.DEPART_STN, A.ARRIVE_STN, PRICE "
                        + "FROM SECTION_DESC A "
                        + "WHERE A.DEPART_STN = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "UNION ALL "
                        + "SELECT R.DEPART_STN, B.ARRIVE_STN, R.COST + B.PRICE "
                        + "FROM DESTINATIONS R, SECTION_DESC B "
                        + "WHERE R.ARRIVE_STN = B.DEPART_STN) "
                        + "SELECT DEPART_STN DEPARTURE, ARRIVE_STN ARRIVAL, COST "
                        + "FROM DESTINATIONS "
                        + "WHERE ARRIVE_STN = '" + comboBox2.SelectedItem.ToString() + "'";

                    CostDescCmd.CommandText = cmd2;

                    OracleDataReader reader2 = CostDescCmd.ExecuteReader();
                    while (reader2.Read())
                    {
                        int Cost = Convert.ToInt32(reader2["COST"]);
                        int Age = Convert.ToInt32(AgeLabel.Text);

                        if (Age < 20 && Age > 13) // 나이에 따른 가격 할인
                        {
                            CostLabel.Text = (Cost * 0.7).ToString();
                        }
                        else if (Age < 70 && Age > 60)
                        {
                            CostLabel.Text = (Cost * 0.7).ToString();
                        }
                        else if (Age >= 70)
                        {
                            CostLabel.Text = (Cost * 0.5).ToString();
                        }
                        else if (Age <= 13)
                        {
                            CostLabel.Text = (Cost * 0.5).ToString();
                        }
                        else
                        {
                            CostLabel.Text = Convert.ToString(Cost);
                        }
                    }
                    reader2.Close();
                }
                else
                {
                    string cmd3 = "WITH DESTINATIONS (DEPART_STN, ARRIVE_STN, COST) AS "
                        + "(SELECT A.DEPART_STN, A.ARRIVE_STN, PRICE "
                        + "FROM SECTION_ASC A "
                        + "WHERE A.DEPART_STN = '" + comboBox1.SelectedItem.ToString() + "' "
                        + "UNION ALL "
                        + "SELECT R.DEPART_STN, B.ARRIVE_STN, R.COST + B.PRICE "
                        + "FROM DESTINATIONS R, SECTION_ASC B "
                        + "WHERE R.ARRIVE_STN = B.DEPART_STN) "
                        + "SELECT DEPART_STN DEPARTURE, ARRIVE_STN ARRIVAL, COST "
                        + "FROM DESTINATIONS "
                        + "WHERE ARRIVE_STN = '" + comboBox2.SelectedItem.ToString() + "'";

                    CostAscCmd.CommandText = cmd3;

                    OracleDataReader reader3 = CostAscCmd.ExecuteReader();
                    while (reader3.Read())
                    {
                        int Cost = Convert.ToInt32(reader3["COST"]);
                        int Age = Convert.ToInt32(AgeLabel.Text);

                        if (Age < 20 && Age > 13) // 나이에 따른 가격 할인
                        {
                            CostLabel.Text = (Cost * 0.7).ToString();
                        }
                        else if (Age < 70 && Age > 60)
                        {
                            CostLabel.Text = (Cost * 0.7).ToString();
                        }
                        else if (Age >= 70)
                        {
                            CostLabel.Text = (Cost * 0.5).ToString();
                        }
                        else if (Age <= 13)
                        {
                            CostLabel.Text = (Cost * 0.5).ToString();
                        }
                        else
                        {
                            CostLabel.Text = Convert.ToString(Cost);
                        }
                    }
                    reader3.Close();
                }
                OracleCnt.Close();
            }
            else
            {
                InformationPanel.Visible = false;
                WarningLabel.Text = "예약할 수 없는 좌석입니다.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}