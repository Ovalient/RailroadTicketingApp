namespace RailroadTicketingApp
{
    partial class StationControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.DecideButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StationIDTextBox = new System.Windows.Forms.TextBox();
            this.LegTimeTextBox = new System.Windows.Forms.TextBox();
            this.StationNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.OracleCnt = new Oracle.DataAccess.Client.OracleConnection();
            this.UpdateCmd = new Oracle.DataAccess.Client.OracleCommand();
            this.InsertCmd = new Oracle.DataAccess.Client.OracleCommand();
            this.InsertCmd1 = new Oracle.DataAccess.Client.OracleCommand();
            this.UpdateCmd1 = new Oracle.DataAccess.Client.OracleCommand();
            this.InsertCmd2 = new Oracle.DataAccess.Client.OracleCommand();
            this.UpdateCmd2 = new Oracle.DataAccess.Client.OracleCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.DeleteCmd = new Oracle.DataAccess.Client.OracleCommand();
            this.UpdateCmd3 = new Oracle.DataAccess.Client.OracleCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "역 정보";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.DecideButton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.StationIDTextBox);
            this.panel1.Controls.Add(this.LegTimeTextBox);
            this.panel1.Controls.Add(this.StationNameTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(408, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 303);
            this.panel1.TabIndex = 38;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(113, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 39;
            this.button5.Text = "추가";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DecideButton
            // 
            this.DecideButton.BackColor = System.Drawing.Color.Crimson;
            this.DecideButton.FlatAppearance.BorderSize = 0;
            this.DecideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecideButton.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DecideButton.ForeColor = System.Drawing.Color.White;
            this.DecideButton.Location = new System.Drawing.Point(219, 259);
            this.DecideButton.Name = "DecideButton";
            this.DecideButton.Size = new System.Drawing.Size(100, 30);
            this.DecideButton.TabIndex = 38;
            this.DecideButton.Text = "삭제";
            this.DecideButton.UseVisualStyleBackColor = false;
            this.DecideButton.Click += new System.EventHandler(this.DecideButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button4.Location = new System.Drawing.Point(16, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 24);
            this.button4.TabIndex = 37;
            this.button4.Text = "정차시간";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button2.Location = new System.Drawing.Point(16, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 24);
            this.button2.TabIndex = 36;
            this.button2.Text = "순서";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button1.Location = new System.Drawing.Point(16, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 24);
            this.button1.TabIndex = 35;
            this.button1.Text = "역 이름";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StationIDTextBox
            // 
            this.StationIDTextBox.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StationIDTextBox.Location = new System.Drawing.Point(169, 161);
            this.StationIDTextBox.Name = "StationIDTextBox";
            this.StationIDTextBox.Size = new System.Drawing.Size(150, 22);
            this.StationIDTextBox.TabIndex = 34;
            // 
            // LegTimeTextBox
            // 
            this.LegTimeTextBox.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LegTimeTextBox.Location = new System.Drawing.Point(169, 189);
            this.LegTimeTextBox.Name = "LegTimeTextBox";
            this.LegTimeTextBox.Size = new System.Drawing.Size(150, 22);
            this.LegTimeTextBox.TabIndex = 33;
            // 
            // StationNameTextBox
            // 
            this.StationNameTextBox.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StationNameTextBox.Location = new System.Drawing.Point(169, 125);
            this.StationNameTextBox.Name = "StationNameTextBox";
            this.StationNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.StationNameTextBox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(332, 53);
            this.label10.TabIndex = 31;
            this.label10.Text = "정보 입력 후, 추가/삭제 버튼을 눌러주세요.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔스퀘어", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "역 정보 추가 / 삭제";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // OracleCnt
            // 
            this.OracleCnt.ConnectionString = "DATA SOURCE=ORAORA;PERSIST SECURITY INFO=True;USER ID=A5171671;PASSWORD=5171671";
            // 
            // UpdateCmd
            // 
            this.UpdateCmd.Connection = this.OracleCnt;
            this.UpdateCmd.Transaction = null;
            // 
            // InsertCmd
            // 
            this.InsertCmd.Connection = this.OracleCnt;
            this.InsertCmd.Transaction = null;
            // 
            // InsertCmd1
            // 
            this.InsertCmd1.Connection = this.OracleCnt;
            this.InsertCmd1.Transaction = null;
            // 
            // UpdateCmd1
            // 
            this.UpdateCmd1.Connection = this.OracleCnt;
            this.UpdateCmd1.Transaction = null;
            // 
            // InsertCmd2
            // 
            this.InsertCmd2.Connection = this.OracleCnt;
            this.InsertCmd2.Transaction = null;
            // 
            // UpdateCmd2
            // 
            this.UpdateCmd2.Connection = this.OracleCnt;
            this.UpdateCmd2.Transaction = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Location = new System.Drawing.Point(184, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 175);
            this.panel2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "성공적으로 추가되었습니다.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Chocolate;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(475, 10);
            this.panel7.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Chocolate;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 175);
            this.panel6.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Chocolate;
            this.panel5.Location = new System.Drawing.Point(0, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 10);
            this.panel5.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Location = new System.Drawing.Point(465, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 175);
            this.panel4.TabIndex = 38;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(165, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 35);
            this.button8.TabIndex = 37;
            this.button8.Text = "확인";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DeleteCmd
            // 
            this.DeleteCmd.Connection = this.OracleCnt;
            this.DeleteCmd.Transaction = null;
            // 
            // UpdateCmd3
            // 
            this.UpdateCmd3.Connection = this.OracleCnt;
            this.UpdateCmd3.Transaction = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Location = new System.Drawing.Point(184, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 175);
            this.panel3.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(133, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 14);
            this.label3.TabIndex = 45;
            this.label3.Text = "삭제한 역 정보는 복구할 수 없습니다.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "정말 삭제하겠습니까?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(240, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 35);
            this.button6.TabIndex = 43;
            this.button6.Text = "취소";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Chocolate;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(475, 10);
            this.panel8.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(165, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 35);
            this.button7.TabIndex = 42;
            this.button7.Text = "확인";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Chocolate;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 175);
            this.panel9.TabIndex = 39;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Chocolate;
            this.panel10.Location = new System.Drawing.Point(0, 165);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(475, 10);
            this.panel10.TabIndex = 39;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Chocolate;
            this.panel11.Location = new System.Drawing.Point(465, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 175);
            this.panel11.TabIndex = 38;
            // 
            // StationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StationControl";
            this.Size = new System.Drawing.Size(800, 531);
            this.Load += new System.EventHandler(this.SectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private Oracle.DataAccess.Client.OracleConnection OracleCnt;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd;
        private System.Windows.Forms.TextBox StationNameTextBox;
        private System.Windows.Forms.TextBox StationIDTextBox;
        private System.Windows.Forms.TextBox LegTimeTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button DecideButton;
        private Oracle.DataAccess.Client.OracleCommand InsertCmd;
        private Oracle.DataAccess.Client.OracleCommand InsertCmd1;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd1;
        private Oracle.DataAccess.Client.OracleCommand InsertCmd2;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private Oracle.DataAccess.Client.OracleCommand DeleteCmd;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
