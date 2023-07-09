namespace GolfTrackerUI
{
    partial class MyDataForm
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
            TitleLabel = new Label();
            myDataLabel = new Label();
            absLabel = new Label();
            acsLabel = new Label();
            alaLabel = new Label();
            asrLabel = new Label();
            avgDriverLabel = new Label();
            previousshotsview = new ListView();
            BallSpeed = new ColumnHeader();
            ClubHeadSpeed = new ColumnHeader();
            LaunchAngle = new ColumnHeader();
            SpinRate = new ColumnHeader();
            avgspinrate = new Label();
            avglaunchangle = new Label();
            avgclubheadspeed = new Label();
            avgballspeed = new Label();
            recentshotslabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            TitleLabel.Location = new Point(17, 9);
            TitleLabel.Margin = new Padding(8, 0, 8, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 47);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Golf Tracker";
            // 
            // myDataLabel
            // 
            myDataLabel.AutoSize = true;
            myDataLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            myDataLabel.ForeColor = Color.FromArgb(0, 64, 0);
            myDataLabel.Location = new Point(17, 56);
            myDataLabel.Margin = new Padding(8, 0, 8, 0);
            myDataLabel.Name = "myDataLabel";
            myDataLabel.Size = new Size(143, 47);
            myDataLabel.TabIndex = 15;
            myDataLabel.Text = "My Data";
            // 
            // absLabel
            // 
            absLabel.AutoSize = true;
            absLabel.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            absLabel.Location = new Point(17, 178);
            absLabel.Name = "absLabel";
            absLabel.Size = new Size(143, 40);
            absLabel.TabIndex = 20;
            absLabel.Text = "Ball Speed";
            // 
            // acsLabel
            // 
            acsLabel.AutoSize = true;
            acsLabel.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            acsLabel.Location = new Point(17, 296);
            acsLabel.Name = "acsLabel";
            acsLabel.Size = new Size(326, 40);
            acsLabel.TabIndex = 21;
            acsLabel.Text = "Average Clubhead Speed";
            // 
            // alaLabel
            // 
            alaLabel.AutoSize = true;
            alaLabel.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            alaLabel.Location = new Point(17, 414);
            alaLabel.Name = "alaLabel";
            alaLabel.Size = new Size(292, 40);
            alaLabel.TabIndex = 22;
            alaLabel.Text = "Average Launch Angle";
            // 
            // asrLabel
            // 
            asrLabel.AutoSize = true;
            asrLabel.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            asrLabel.Location = new Point(17, 532);
            asrLabel.Name = "asrLabel";
            asrLabel.Size = new Size(239, 40);
            asrLabel.TabIndex = 23;
            asrLabel.Text = "Average Spin Rate";
            // 
            // avgDriverLabel
            // 
            avgDriverLabel.AutoSize = true;
            avgDriverLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            avgDriverLabel.ForeColor = Color.FromArgb(0, 64, 0);
            avgDriverLabel.Location = new Point(17, 103);
            avgDriverLabel.Margin = new Padding(8, 0, 8, 0);
            avgDriverLabel.Name = "avgDriverLabel";
            avgDriverLabel.Size = new Size(253, 50);
            avgDriverLabel.TabIndex = 25;
            avgDriverLabel.Text = "Average Driver";
            // 
            // previousshotsview
            // 
            previousshotsview.Columns.AddRange(new ColumnHeader[] { BallSpeed, ClubHeadSpeed, LaunchAngle, SpinRate });
            previousshotsview.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            previousshotsview.Location = new Point(444, 237);
            previousshotsview.Name = "previousshotsview";
            previousshotsview.Size = new Size(660, 365);
            previousshotsview.TabIndex = 26;
            previousshotsview.UseCompatibleStateImageBehavior = false;
            previousshotsview.View = View.Details;
            // 
            // BallSpeed
            // 
            BallSpeed.Text = "Ball Speed";
            BallSpeed.Width = 160;
            // 
            // ClubHeadSpeed
            // 
            ClubHeadSpeed.Text = "Club Head Speed";
            ClubHeadSpeed.Width = 180;
            // 
            // LaunchAngle
            // 
            LaunchAngle.Text = "Launch Angle";
            LaunchAngle.Width = 160;
            // 
            // SpinRate
            // 
            SpinRate.Text = "Spin Rate";
            SpinRate.Width = 160;
            // 
            // avgspinrate
            // 
            avgspinrate.AutoSize = true;
            avgspinrate.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            avgspinrate.Location = new Point(17, 591);
            avgspinrate.Name = "avgspinrate";
            avgspinrate.Size = new Size(152, 40);
            avgspinrate.TabIndex = 30;
            avgspinrate.Text = "<spinrate>";
            // 
            // avglaunchangle
            // 
            avglaunchangle.AutoSize = true;
            avglaunchangle.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            avglaunchangle.Location = new Point(17, 473);
            avglaunchangle.Name = "avglaunchangle";
            avglaunchangle.Size = new Size(203, 40);
            avglaunchangle.TabIndex = 29;
            avglaunchangle.Text = "<launchangle>";
            // 
            // avgclubheadspeed
            // 
            avgclubheadspeed.AutoSize = true;
            avgclubheadspeed.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            avgclubheadspeed.Location = new Point(17, 355);
            avgclubheadspeed.Name = "avgclubheadspeed";
            avgclubheadspeed.Size = new Size(240, 40);
            avgclubheadspeed.TabIndex = 28;
            avgclubheadspeed.Text = "<clubheadspeed>";
            // 
            // avgballspeed
            // 
            avgballspeed.AutoSize = true;
            avgballspeed.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            avgballspeed.Location = new Point(17, 237);
            avgballspeed.Name = "avgballspeed";
            avgballspeed.Size = new Size(170, 40);
            avgballspeed.TabIndex = 27;
            avgballspeed.Text = "<ballspeed>";
            // 
            // recentshotslabel
            // 
            recentshotslabel.AutoSize = true;
            recentshotslabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            recentshotslabel.ForeColor = Color.FromArgb(0, 64, 0);
            recentshotslabel.Location = new Point(648, 178);
            recentshotslabel.Margin = new Padding(8, 0, 8, 0);
            recentshotslabel.Name = "recentshotslabel";
            recentshotslabel.Size = new Size(222, 50);
            recentshotslabel.TabIndex = 31;
            recentshotslabel.Text = "Recent Shots";
            // 
            // MyDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1184, 681);
            Controls.Add(recentshotslabel);
            Controls.Add(avgspinrate);
            Controls.Add(avglaunchangle);
            Controls.Add(avgclubheadspeed);
            Controls.Add(avgballspeed);
            Controls.Add(previousshotsview);
            Controls.Add(avgDriverLabel);
            Controls.Add(asrLabel);
            Controls.Add(alaLabel);
            Controls.Add(acsLabel);
            Controls.Add(absLabel);
            Controls.Add(myDataLabel);
            Controls.Add(TitleLabel);
            Name = "MyDataForm";
            Text = "My Data";
            Load += MyDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label myDataLabel;
        private Label absLabel;
        private Label acsLabel;
        private Label alaLabel;
        private Label asrLabel;
        private Label avgDriverLabel;
        private ListView previousshotsview;
        private ColumnHeader BallSpeed;
        private ColumnHeader ClubHeadSpeed;
        private ColumnHeader LaunchAngle;
        private ColumnHeader SpinRate;
        private Label avgspinrate;
        private Label avglaunchangle;
        private Label avgclubheadspeed;
        private Label avgballspeed;
        private Label recentshotslabel;
    }
}