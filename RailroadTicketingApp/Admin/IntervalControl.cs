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
    public partial class IntervalControl : UserControl
    {
        int max = 0;

        public IntervalControl()
        {
            InitializeComponent();
        }

        private void IntervalControl_Load(object sender, EventArgs e)
        {
            GetView();
            GetMax();

            panel2.Visible = false;
            panel3.Visible = false;

            panel2.Location = new Point(
                this.Width / 2 - panel2.Size.Width / 2,
                this.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;

            panel3.Location = new Point(
                this.Width / 2 - panel3.Size.Width / 2,
                this.Height / 2 - panel3.Size.Height / 2);
            panel3.Anchor = AnchorStyles.None;
        }

        private void GetView() 
        {
            this.tIMETABLE3TableAdapter.Fill(this.dataSet1.TIMETABLE3);
        }

        private void GetMax()
        {
            OracleCnt.Open();

            string cmd1 = "SELECT MAX(STATION_ID) FROM STATION";
            MaxCmd.CommandText = cmd1;
            OracleDataReader reader = MaxCmd.ExecuteReader();
            while (reader.Read())
            {
                max = Convert.ToInt32(reader["MAX(STATION_ID)"]);
            }
            OracleCnt.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            int j = 1;

            if (TrainNumberTextBox.Text != "" && comboBox1.SelectedItem != null && HourTextBox.Text != "" && MinuteTextBox.Text != "")
            {
                OracleCnt.Open();

                if (comboBox1.SelectedItem.ToString() == "서울")
                {
                    string cmd1 = "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                        + "VALUES(" + TrainNumberTextBox.Text + ", '부산', NULL, 'up', '부산', '서울', TO_DATE('20181204 " + HourTextBox.Text + MinuteTextBox.Text + "', 'YYYY/MM/DD HH24:MI'), NULL, " + i + ")";
                    InsertCmd.CommandText = cmd1;
                    InsertCmd.ExecuteNonQuery();

                    /*string cmd2 = "DECLARE CNT NUMBER := " + i + "; BEGIN LOOP "
                            + "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                            + "VALUES(" + TrainNumberTextBox.Text + ", (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (i + 1) + "), (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (i + 1) + "), 'up', '부산', '서울', "
                            + "(SELECT MAX(DEPART_TIME + ((SELECT TIME FROM SECTION_ASC WHERE DEPART_ID = " + i + ") + (SELECT LEG_TIME FROM STATION WHERE STATION_ID = " + (i + 1) + ")) / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), "
                            + "(SELECT MAX(DEPART_TIME + (SELECT TIME FROM SECTION_ASC WHERE DEPART_ID = " + i + ") / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), " + (i + 1) + "); "
                            + "CNT := CNT + 1; EXIT WHEN CNT > " + (max - 2) + "; END LOOP; END;";*/
                    for (i = 1; i < (max - 1); i++)
                    {
                        string cmd2 = "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                                + "VALUES(" + TrainNumberTextBox.Text + ", (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (i + 1) + "), (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (i + 1) + "), 'up', '부산', '서울', "
                                + "(SELECT MAX(DEPART_TIME + ((SELECT TIME FROM SECTION_ASC WHERE DEPART_ID = " + i + ") + (SELECT LEG_TIME FROM STATION WHERE STATION_ID = " + (i + 1) + ")) / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), "
                                + "(SELECT MAX(DEPART_TIME + (SELECT TIME FROM SECTION_ASC WHERE DEPART_ID = " + i + ") / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), " + (i + 1) + ")";
                        InsertCmd1.CommandText = cmd2;
                        InsertCmd1.ExecuteNonQuery();
                    }

                    string cmd3 = "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                       + "VALUES(" + TrainNumberTextBox.Text + ", NULL, (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + max + "), 'up', '부산', '서울', NULL, (SELECT MAX(DEPART_TIME + (SELECT TIME FROM SECTION_ASC WHERE ARRIVE_ID = " + max + ") / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + (max - 1) + "), " + max + ")";
                    InsertCmd2.CommandText = cmd3;
                    InsertCmd2.ExecuteNonQuery();

                    string cmd4 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1A')";
                    SeatCmd.CommandText = cmd4;
                    SeatCmd.ExecuteNonQuery();
                    string cmd5 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1B')";
                    SeatCmd.CommandText = cmd5;
                    SeatCmd.ExecuteNonQuery();
                    string cmd6 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1C')";
                    SeatCmd.CommandText = cmd6;
                    SeatCmd.ExecuteNonQuery();
                    string cmd7 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1D')";
                    SeatCmd.CommandText = cmd7;
                    SeatCmd.ExecuteNonQuery();
                    string cmd8 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2A')";
                    SeatCmd.CommandText = cmd8;
                    SeatCmd.ExecuteNonQuery();
                    string cmd9 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2B')";
                    SeatCmd.CommandText = cmd9;
                    SeatCmd.ExecuteNonQuery();
                    string cmd10 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2C')";
                    SeatCmd.CommandText = cmd10;
                    SeatCmd.ExecuteNonQuery();
                    string cmd11 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2D')";
                    SeatCmd.CommandText = cmd11;
                    SeatCmd.ExecuteNonQuery();

                    i = 1;
                }
                else
                {
                    string cmd1 = "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                        + "VALUES(" + TrainNumberTextBox.Text + ", '서울', NULL, 'down', '서울', '부산', TO_DATE('20181204 " + HourTextBox.Text + MinuteTextBox.Text + "', 'YYYY/MM/DD HH24:MI'), NULL, " + i + ")";
                    InsertCmd3.CommandText = cmd1;
                    InsertCmd3.ExecuteNonQuery();

                    for (j = max; j >= 2; j--)
                    {
                        string cmd2 = "INSERT INTO TIMETABLE(TRAIN_ID, DEPART_STN_NAME, ARRIVE_STN_NAME, DIRECTION, DEPARTURE, ARRIVAL, DEPART_TIME, ARRIVE_TIME, TIMETABLE_ID) "
                                + "VALUES(" + TrainNumberTextBox.Text + ", (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (j - 1) + "), (SELECT STATION_NAME FROM STATION WHERE STATION_ID = " + (j - 1) + "), 'down', '서울', '부산', "                                
                                + "(SELECT MAX(DEPART_TIME + ((SELECT TIME FROM SECTION_DESC WHERE DEPART_ID = " + j + ") + (SELECT LEG_TIME FROM STATION WHERE STATION_ID = " + (j - 1) + ")) / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), "
                                + "(SELECT MAX(DEPART_TIME + (SELECT TIME FROM SECTION_DESC WHERE DEPART_ID = " + j + ") / (24 * 60)) FROM TIMETABLE WHERE TIMETABLE_ID = " + i + "), " + (i + 1) + ")";
                        InsertCmd4.CommandText = cmd2;
                        InsertCmd4.ExecuteNonQuery();
                        i++;
                    }

                    string cmd3 = "UPDATE TIMETABLE SET DEPART_STN_NAME = NULL, DEPART_TIME = NULL WHERE TRAIN_ID = " + TrainNumberTextBox.Text + " AND TIMETABLE_ID = " + max + "";
                    UpdateCmd.CommandText = cmd3;
                    UpdateCmd.ExecuteNonQuery();

                    string cmd4 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1A')";
                    SeatCmd.CommandText = cmd4;
                    SeatCmd.ExecuteNonQuery();
                    string cmd5 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1B')";
                    SeatCmd.CommandText = cmd5;
                    SeatCmd.ExecuteNonQuery();
                    string cmd6 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1C')";
                    SeatCmd.CommandText = cmd6;
                    SeatCmd.ExecuteNonQuery();
                    string cmd7 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '1D')";
                    SeatCmd.CommandText = cmd7;
                    SeatCmd.ExecuteNonQuery();
                    string cmd8 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2A')";
                    SeatCmd.CommandText = cmd8;
                    SeatCmd.ExecuteNonQuery();
                    string cmd9 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2B')";
                    SeatCmd.CommandText = cmd9;
                    SeatCmd.ExecuteNonQuery();
                    string cmd10 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2C')";
                    SeatCmd.CommandText = cmd10;
                    SeatCmd.ExecuteNonQuery();
                    string cmd11 = "INSERT INTO TRAIN_SEAT(TRAIN_ID, SEAT_ID) VALUES(" + TrainNumberTextBox.Text + ", '2D')";
                    SeatCmd.CommandText = cmd11;
                    SeatCmd.ExecuteNonQuery();

                    i = 1;
                }
                OracleCnt.Close();
                GetView();
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
            string cmd = "DELETE FROM TIMETABLE WHERE TRAIN_ID = " + TrainNumberTextBox + "";
            DeleteCmd.CommandText = cmd;
            DeleteCmd.ExecuteNonQuery();
            GetView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
