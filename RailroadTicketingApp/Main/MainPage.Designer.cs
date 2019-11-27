namespace RailroadTicketingApp
{
    partial class MainPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.StatusButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.QuitButton1 = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.TimetableButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IDButton = new System.Windows.Forms.Button();
            this.QuitButton2 = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSet11 = new RailroadTicketingApp.DataSet1();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.flowLayoutPanel5);
            this.panel1.Controls.Add(this.StatusButton);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.QuitButton1);
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.ReservationButton);
            this.panel1.Controls.Add(this.TimetableButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 681);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1, 353);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(11, 71);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // StatusButton
            // 
            this.StatusButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.StatusButton.FlatAppearance.BorderSize = 0;
            this.StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StatusButton.ForeColor = System.Drawing.Color.White;
            this.StatusButton.Image = global::RailroadTicketingApp.Properties.Resources.price_tag;
            this.StatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusButton.Location = new System.Drawing.Point(12, 353);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(250, 71);
            this.StatusButton.TabIndex = 0;
            this.StatusButton.Text = "예약 현황";
            this.StatusButton.UseVisualStyleBackColor = false;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.TimeLabel.Font = new System.Drawing.Font("NanumSquare Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(72, 99);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(168, 20);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "현재시각";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("NanumSquare Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-2, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재시각";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RailroadTicketingApp.Properties.Resources.Norfolk_Southern_logo_Inverted;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 101);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 631);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(11, 40);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 585);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(11, 40);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 276);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(11, 71);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 199);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(11, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 122);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(11, 71);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 122);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(250, 71);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "홈";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // QuitButton1
            // 
            this.QuitButton1.BackColor = System.Drawing.Color.Crimson;
            this.QuitButton1.FlatAppearance.BorderSize = 0;
            this.QuitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.QuitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.QuitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton1.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.QuitButton1.ForeColor = System.Drawing.Color.White;
            this.QuitButton1.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton1.Image")));
            this.QuitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuitButton1.Location = new System.Drawing.Point(12, 631);
            this.QuitButton1.Name = "QuitButton1";
            this.QuitButton1.Size = new System.Drawing.Size(250, 40);
            this.QuitButton1.TabIndex = 0;
            this.QuitButton1.Text = "종료";
            this.QuitButton1.UseVisualStyleBackColor = false;
            this.QuitButton1.Click += new System.EventHandler(this.QuitButton1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.White;
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AdminButton.ForeColor = System.Drawing.Color.Black;
            this.AdminButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminButton.Image")));
            this.AdminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButton.Location = new System.Drawing.Point(12, 585);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(250, 40);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "관리자 모드";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.ReservationButton.FlatAppearance.BorderSize = 0;
            this.ReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReservationButton.ForeColor = System.Drawing.Color.White;
            this.ReservationButton.Image = ((System.Drawing.Image)(resources.GetObject("ReservationButton.Image")));
            this.ReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationButton.Location = new System.Drawing.Point(12, 276);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(250, 71);
            this.ReservationButton.TabIndex = 0;
            this.ReservationButton.Text = "예매하기";
            this.ReservationButton.UseVisualStyleBackColor = false;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // TimetableButton
            // 
            this.TimetableButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.TimetableButton.FlatAppearance.BorderSize = 0;
            this.TimetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimetableButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimetableButton.ForeColor = System.Drawing.Color.White;
            this.TimetableButton.Image = ((System.Drawing.Image)(resources.GetObject("TimetableButton.Image")));
            this.TimetableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimetableButton.Location = new System.Drawing.Point(12, 199);
            this.TimetableButton.Name = "TimetableButton";
            this.TimetableButton.Size = new System.Drawing.Size(250, 71);
            this.TimetableButton.TabIndex = 0;
            this.TimetableButton.Text = "전체 시간표";
            this.TimetableButton.UseVisualStyleBackColor = false;
            this.TimetableButton.Click += new System.EventHandler(this.TimetableButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.IDButton);
            this.panel3.Controls.Add(this.QuitButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 32);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOME";
            // 
            // IDButton
            // 
            this.IDButton.FlatAppearance.BorderSize = 0;
            this.IDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDButton.Font = new System.Drawing.Font("NanumSquare", 12.75F);
            this.IDButton.Location = new System.Drawing.Point(695, 0);
            this.IDButton.Name = "IDButton";
            this.IDButton.Size = new System.Drawing.Size(259, 32);
            this.IDButton.TabIndex = 0;
            this.IDButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton2
            // 
            this.QuitButton2.BackColor = System.Drawing.Color.Crimson;
            this.QuitButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitButton2.BackgroundImage")));
            this.QuitButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QuitButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitButton2.FlatAppearance.BorderSize = 0;
            this.QuitButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.QuitButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.QuitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton2.Location = new System.Drawing.Point(960, 0);
            this.QuitButton2.Name = "QuitButton2";
            this.QuitButton2.Size = new System.Drawing.Size(64, 32);
            this.QuitButton2.TabIndex = 0;
            this.QuitButton2.UseVisualStyleBackColor = false;
            this.QuitButton2.Click += new System.EventHandler(this.QuitButton1_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.SystemColors.Control;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(240, 32);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1024, 649);
            this.Container.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NON-STOP Railroad Reservation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TimetableButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Button QuitButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button QuitButton2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button IDButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.Label label2;
    }
}

