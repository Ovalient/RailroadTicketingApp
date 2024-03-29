﻿namespace RailroadTicketingApp
{
    partial class AdminPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitButton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.QuitButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 32);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN PAGE";
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
            this.QuitButton2.Location = new System.Drawing.Point(736, 0);
            this.QuitButton2.Name = "QuitButton2";
            this.QuitButton2.Size = new System.Drawing.Size(64, 32);
            this.QuitButton2.TabIndex = 0;
            this.QuitButton2.UseVisualStyleBackColor = false;
            this.QuitButton2.Click += new System.EventHandler(this.QuitButton2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SaddleBrown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::RailroadTicketingApp.Properties.Resources.user_outline_invert;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(472, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "통계       ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::RailroadTicketingApp.Properties.Resources.calendar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(315, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "배차 정보  ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RailroadTicketingApp.Properties.Resources.direction_signs;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(158, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "구간 정보  ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("NanumSquare Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::RailroadTicketingApp.Properties.Resources.golf_flag;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(1, 1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(151, 37);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "역 정보    ";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 15;
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 69);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(800, 531);
            this.Container.TabIndex = 15;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuitButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Container;
    }
}