using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailroadTicketingApp
{
    public partial class SignInControl : UserControl
    {
        String UserID;
        String Password;

        MainPage mainPage = new MainPage();
        HomeControl homeControl = new HomeControl();
        Boolean SignInSucceed = false;
        DataTable dataTable;

        public SignInControl()
        {
            InitializeComponent();

            WarningLabel.Visible = false;
        }

        private void SignInControl_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleDataAdapter1.Fill(dataSet11, "PASSENGER");
            oracleConnection1.Close();

            panel1.Location = new Point(
                this.Width / 2 - panel1.Size.Width / 2,
                this.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            UserIDTextBox.Location = new Point(
                panel2.Width / 2 - UserIDTextBox.Size.Width / 2,
                panel2.Height / 2 - UserIDTextBox.Size.Height / 2);
            UserIDTextBox.Anchor = AnchorStyles.None;

            panel5.Location = new Point(
                panel2.Width / 2 - panel5.Size.Width / 2,
                panel2.Height / 2 - panel5.Size.Height / 2);
            panel5.Anchor = AnchorStyles.None;

            PasswordTextBox.Location = new Point(
                panel3.Width / 2 - PasswordTextBox.Size.Width / 2,
                panel3.Height / 2 - PasswordTextBox.Size.Height / 2);
            PasswordTextBox.Anchor = AnchorStyles.None;

            panel7.Location = new Point(
                panel2.Width / 2 - panel7.Size.Width / 2,
                panel2.Height / 2 - panel7.Size.Height / 2);
            panel7.Anchor = AnchorStyles.None;

            SignInButton.Location = new Point(
                panel4.Width / 2 - SignInButton.Size.Width / 2,
                53);
            SignInButton.Anchor = AnchorStyles.None;

            ForgotPasswordButton.Location = new Point(
                panel8.Width / 2 - ForgotPasswordButton.Size.Width / 2,
                panel8.Height / 2 - ForgotPasswordButton.Size.Height / 2);
            ForgotPasswordButton.Anchor = AnchorStyles.None;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            dataTable = dataSet11.Tables["PASSENGER"];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                UserID = dataRow["USER_ID"].ToString();
                Password = dataRow["USER_PW"].ToString();

                if (UserIDTextBox.Text == UserID && PasswordTextBox.Text == Password)
                    SignInSucceed = true;
            }

            if (SignInSucceed == true)
            {
                ((Form)this.TopLevelControl).Visible = false;
                mainPage.Passvalue = UserIDTextBox.Text;
                mainPage.ShowDialog();
            }
            else
                WarningLabel.Visible = true;

            SignInSucceed = false;
        }

        private void UserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignInButton_Click(sender, e);
        }
    }
}
