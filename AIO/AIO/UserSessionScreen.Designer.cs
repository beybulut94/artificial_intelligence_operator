﻿namespace AIO
{
    partial class UserSessionScreen
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
            this.components = new System.ComponentModel.Container();
            this.nickLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.Transparent;
            this.nickLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickLabel.ForeColor = System.Drawing.Color.White;
            this.nickLabel.Location = new System.Drawing.Point(12, 11);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(51, 23);
            this.nickLabel.TabIndex = 0;
            this.nickLabel.Text = "User";
            this.nickLabel.Click += new System.EventHandler(this.nickLabel_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::AIO.Properties.Resources.logout;
            this.logoutBtn.Location = new System.Drawing.Point(219, 1);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutBtn.Size = new System.Drawing.Size(182, 70);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "              Oturumu Kapat";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.moneyLabel.Location = new System.Drawing.Point(17, 44);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(77, 17);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "AIO Money";
            this.moneyLabel.Click += new System.EventHandler(this.moneyLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserSessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIO.Properties.Resources.bg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(402, 73);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.nickLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 600);
            this.Name = "UserSessionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserSessionScreen";
            this.Load += new System.EventHandler(this.UserSessionScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Timer timer1;
    }
}