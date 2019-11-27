namespace RailroadTicketingApp
{
    partial class SectionControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ArriveLabel = new System.Windows.Forms.Label();
            this.DepartLabel = new System.Windows.Forms.Label();
            this.LineDirectionBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OracleCnt = new Oracle.DataAccess.Client.OracleConnection();
            this.UpdateCmd = new Oracle.DataAccess.Client.OracleCommand();
            this.UpdateCmd1 = new Oracle.DataAccess.Client.OracleCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.label4.TabIndex = 38;
            this.label4.Text = "구간 정보";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(445, 373);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.TimeTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ArriveLabel);
            this.panel1.Controls.Add(this.DepartLabel);
            this.panel1.Controls.Add(this.LineDirectionBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(471, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 373);
            this.panel1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 53);
            this.label10.TabIndex = 51;
            this.label10.Text = "정보 입력 후, 저장 버튼을 눌러주세요.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(196, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 50;
            this.button6.Text = "저장";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button5.Location = new System.Drawing.Point(12, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 24);
            this.button5.TabIndex = 49;
            this.button5.Text = "가격";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PriceTextBox.Location = new System.Drawing.Point(146, 240);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(150, 22);
            this.PriceTextBox.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button2.Location = new System.Drawing.Point(12, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 24);
            this.button2.TabIndex = 47;
            this.button2.Text = "소요시간";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeTextBox.Location = new System.Drawing.Point(146, 210);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(150, 22);
            this.TimeTextBox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button1.Location = new System.Drawing.Point(112, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 45;
            this.button1.Text = "도착역";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F);
            this.button4.Location = new System.Drawing.Point(112, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 24);
            this.button4.TabIndex = 44;
            this.button4.Text = "출발역";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ArriveLabel
            // 
            this.ArriveLabel.BackColor = System.Drawing.Color.White;
            this.ArriveLabel.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ArriveLabel.Location = new System.Drawing.Point(109, 159);
            this.ArriveLabel.Name = "ArriveLabel";
            this.ArriveLabel.Size = new System.Drawing.Size(187, 30);
            this.ArriveLabel.TabIndex = 43;
            this.ArriveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DepartLabel
            // 
            this.DepartLabel.BackColor = System.Drawing.Color.White;
            this.DepartLabel.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DepartLabel.Location = new System.Drawing.Point(109, 122);
            this.DepartLabel.Name = "DepartLabel";
            this.DepartLabel.Size = new System.Drawing.Size(187, 30);
            this.DepartLabel.TabIndex = 41;
            this.DepartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LineDirectionBox
            // 
            this.LineDirectionBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LineDirectionBox.BackColor = System.Drawing.Color.Firebrick;
            this.LineDirectionBox.Checked = true;
            this.LineDirectionBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LineDirectionBox.FlatAppearance.BorderSize = 0;
            this.LineDirectionBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.LineDirectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineDirectionBox.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LineDirectionBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineDirectionBox.Location = new System.Drawing.Point(13, 122);
            this.LineDirectionBox.Name = "LineDirectionBox";
            this.LineDirectionBox.Size = new System.Drawing.Size(90, 67);
            this.LineDirectionBox.TabIndex = 42;
            this.LineDirectionBox.Text = "↑상행선 ";
            this.LineDirectionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LineDirectionBox.UseVisualStyleBackColor = false;
            this.LineDirectionBox.CheckedChanged += new System.EventHandler(this.LineDirectionBox_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔스퀘어", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 30);
            this.button3.TabIndex = 41;
            this.button3.Text = "구간 정보 수정";
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
            // UpdateCmd1
            // 
            this.UpdateCmd1.Connection = this.OracleCnt;
            this.UpdateCmd1.Transaction = null;
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
            this.panel2.Location = new System.Drawing.Point(137, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 175);
            this.panel2.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "성공적으로 저장되었습니다.";
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
            // SectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "SectionControl";
            this.Size = new System.Drawing.Size(800, 531);
            this.Load += new System.EventHandler(this.SectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox LineDirectionBox;
        private System.Windows.Forms.Label ArriveLabel;
        private System.Windows.Forms.Label DepartLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private Oracle.DataAccess.Client.OracleConnection OracleCnt;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd;
        private Oracle.DataAccess.Client.OracleCommand UpdateCmd1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
    }
}
