namespace GolfTrackerUI
{
    partial class ShotTrackerForm
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
            CurrentSessionLabel = new Label();
            CurrentShotLabel = new Label();
            BSLLabel = new Label();
            CHSLLabel = new Label();
            LALLabel = new Label();
            SRLLabel = new Label();
            previousshotsview = new ListView();
            BallSpeed = new ColumnHeader();
            ClubHeadSpeed = new ColumnHeader();
            LaunchAngle = new ColumnHeader();
            SpinRate = new ColumnHeader();
            PreviousShotsLabel = new Label();
            SaveShotButton = new Button();
            DeleteShotButton = new Button();
            HomeButton = new Button();
            BallSpeedBox = new TextBox();
            ClubSpeedBox = new TextBox();
            LaunchBox = new TextBox();
            SpinBox = new TextBox();
            ClubSelectComboBox = new ComboBox();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Margin = new Padding(8, 0, 8, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 47);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Golf Tracker";
            // 
            // CurrentSessionLabel
            // 
            CurrentSessionLabel.AutoSize = true;
            CurrentSessionLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentSessionLabel.ForeColor = Color.FromArgb(0, 64, 0);
            CurrentSessionLabel.Location = new Point(222, 9);
            CurrentSessionLabel.Margin = new Padding(8, 0, 8, 0);
            CurrentSessionLabel.Name = "CurrentSessionLabel";
            CurrentSessionLabel.Size = new Size(250, 47);
            CurrentSessionLabel.TabIndex = 10;
            CurrentSessionLabel.Text = "Current Session";
            // 
            // CurrentShotLabel
            // 
            CurrentShotLabel.AutoSize = true;
            CurrentShotLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentShotLabel.ForeColor = Color.FromArgb(0, 64, 0);
            CurrentShotLabel.Location = new Point(12, 65);
            CurrentShotLabel.Margin = new Padding(8, 0, 8, 0);
            CurrentShotLabel.Name = "CurrentShotLabel";
            CurrentShotLabel.Size = new Size(207, 47);
            CurrentShotLabel.TabIndex = 11;
            CurrentShotLabel.Text = "Current Shot";
            // 
            // BSLLabel
            // 
            BSLLabel.AutoSize = true;
            BSLLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BSLLabel.ForeColor = Color.FromArgb(0, 64, 0);
            BSLLabel.Location = new Point(12, 271);
            BSLLabel.Name = "BSLLabel";
            BSLLabel.Size = new Size(104, 30);
            BSLLabel.TabIndex = 0;
            BSLLabel.Text = "Ball Speed";
            // 
            // CHSLLabel
            // 
            CHSLLabel.AutoSize = true;
            CHSLLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CHSLLabel.ForeColor = Color.FromArgb(0, 64, 0);
            CHSLLabel.Location = new Point(12, 364);
            CHSLLabel.Margin = new Padding(8, 0, 8, 0);
            CHSLLabel.Name = "CHSLLabel";
            CHSLLabel.Size = new Size(168, 30);
            CHSLLabel.TabIndex = 15;
            CHSLLabel.Text = "Club Head Speed";
            // 
            // LALLabel
            // 
            LALLabel.AutoSize = true;
            LALLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LALLabel.ForeColor = Color.FromArgb(0, 64, 0);
            LALLabel.Location = new Point(12, 457);
            LALLabel.Margin = new Padding(8, 0, 8, 0);
            LALLabel.Name = "LALLabel";
            LALLabel.Size = new Size(132, 30);
            LALLabel.TabIndex = 17;
            LALLabel.Text = "Launch Angle";
            // 
            // SRLLabel
            // 
            SRLLabel.AutoSize = true;
            SRLLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SRLLabel.ForeColor = Color.FromArgb(0, 64, 0);
            SRLLabel.Location = new Point(12, 550);
            SRLLabel.Margin = new Padding(8, 0, 8, 0);
            SRLLabel.Name = "SRLLabel";
            SRLLabel.Size = new Size(95, 30);
            SRLLabel.TabIndex = 19;
            SRLLabel.Text = "Spin Rate";
            // 
            // previousshotsview
            // 
            previousshotsview.Columns.AddRange(new ColumnHeader[] { BallSpeed, ClubHeadSpeed, LaunchAngle, SpinRate });
            previousshotsview.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            previousshotsview.Location = new Point(501, 238);
            previousshotsview.Name = "previousshotsview";
            previousshotsview.Size = new Size(660, 365);
            previousshotsview.TabIndex = 20;
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
            // PreviousShotsLabel
            // 
            PreviousShotsLabel.AutoSize = true;
            PreviousShotsLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousShotsLabel.ForeColor = Color.FromArgb(0, 64, 0);
            PreviousShotsLabel.Location = new Point(718, 170);
            PreviousShotsLabel.Margin = new Padding(8, 0, 8, 0);
            PreviousShotsLabel.Name = "PreviousShotsLabel";
            PreviousShotsLabel.Size = new Size(234, 47);
            PreviousShotsLabel.TabIndex = 25;
            PreviousShotsLabel.Text = "Previous Shots";
            // 
            // SaveShotButton
            // 
            SaveShotButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveShotButton.Location = new Point(249, 614);
            SaveShotButton.Name = "SaveShotButton";
            SaveShotButton.Size = new Size(120, 35);
            SaveShotButton.TabIndex = 26;
            SaveShotButton.Text = "Save Shot";
            SaveShotButton.UseVisualStyleBackColor = true;
            SaveShotButton.Click += SaveShotButton_Click;
            // 
            // DeleteShotButton
            // 
            DeleteShotButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteShotButton.Location = new Point(797, 609);
            DeleteShotButton.Name = "DeleteShotButton";
            DeleteShotButton.Size = new Size(120, 35);
            DeleteShotButton.TabIndex = 27;
            DeleteShotButton.Text = "Delete Shot";
            DeleteShotButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.Location = new Point(1072, 12);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(100, 100);
            HomeButton.TabIndex = 29;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // BallSpeedBox
            // 
            BallSpeedBox.Location = new Point(222, 260);
            BallSpeedBox.Name = "BallSpeedBox";
            BallSpeedBox.Size = new Size(175, 54);
            BallSpeedBox.TabIndex = 30;
            // 
            // ClubSpeedBox
            // 
            ClubSpeedBox.Location = new Point(222, 354);
            ClubSpeedBox.Name = "ClubSpeedBox";
            ClubSpeedBox.Size = new Size(175, 54);
            ClubSpeedBox.TabIndex = 31;
            // 
            // LaunchBox
            // 
            LaunchBox.Location = new Point(222, 448);
            LaunchBox.Name = "LaunchBox";
            LaunchBox.Size = new Size(175, 54);
            LaunchBox.TabIndex = 32;
            // 
            // SpinBox
            // 
            SpinBox.Location = new Point(222, 542);
            SpinBox.Name = "SpinBox";
            SpinBox.Size = new Size(175, 54);
            SpinBox.TabIndex = 33;
            // 
            // ClubSelectComboBox
            // 
            ClubSelectComboBox.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ClubSelectComboBox.FormattingEnabled = true;
            ClubSelectComboBox.Location = new Point(131, 162);
            ClubSelectComboBox.Name = "ClubSelectComboBox";
            ClubSelectComboBox.Size = new Size(364, 40);
            ClubSelectComboBox.TabIndex = 35;
            // 
            // ShotTrackerForm
            // 
            AutoScaleDimensions = new SizeF(18F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1184, 681);
            Controls.Add(previousshotsview);
            Controls.Add(ClubSelectComboBox);
            Controls.Add(SpinBox);
            Controls.Add(LaunchBox);
            Controls.Add(ClubSpeedBox);
            Controls.Add(BallSpeedBox);
            Controls.Add(HomeButton);
            Controls.Add(DeleteShotButton);
            Controls.Add(SaveShotButton);
            Controls.Add(PreviousShotsLabel);
            Controls.Add(SRLLabel);
            Controls.Add(LALLabel);
            Controls.Add(CHSLLabel);
            Controls.Add(BSLLabel);
            Controls.Add(CurrentShotLabel);
            Controls.Add(CurrentSessionLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            Name = "ShotTrackerForm";
            Text = "ShotTrackerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label CurrentSessionLabel;
        private Label CurrentShotLabel;
        private Label label3;
        private Label label2;
        private Label BSLLabel;
        private Label CHSLLabel;
        private Label LALLabel;
        private Label SRLLabel;
        private Label PreviousShotsLabel;
        private Button SaveShotButton;
        private Button DeleteShotButton;
        private Button HomeButton;
        private Label label4;
        private ListView previousshotsview;
        private TextBox BallSpeedBox;
        private TextBox ClubSpeedBox;
        private TextBox LaunchBox;
        private TextBox SpinBox;
        private ComboBox ClubSelectComboBox;
        private ColumnHeader BallSpeed;
        private ColumnHeader ClubHeadSpeed;
        private ColumnHeader LaunchAngle;
        private ColumnHeader SpinRate;
    }
}