namespace GolfFitterUI
{
    partial class ClubBuilderForm
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
            HeadLabel = new Label();
            ShaftLabel = new Label();
            AddClubButton = new Button();
            HeadComboBox = new ComboBox();
            ShaftComboBox = new ComboBox();
            ClubTypeLabel = new Label();
            ClubTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            TitleLabel.Location = new Point(6, 9);
            TitleLabel.Margin = new Padding(8, 0, 8, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 47);
            TitleLabel.TabIndex = 13;
            TitleLabel.Text = "Golf Tracker";
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HeadLabel.ForeColor = Color.FromArgb(0, 64, 0);
            HeadLabel.Location = new Point(6, 98);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(120, 32);
            HeadLabel.TabIndex = 14;
            HeadLabel.Text = "Club Head";
            // 
            // ShaftLabel
            // 
            ShaftLabel.AutoSize = true;
            ShaftLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ShaftLabel.ForeColor = Color.FromArgb(0, 64, 0);
            ShaftLabel.Location = new Point(6, 248);
            ShaftLabel.Name = "ShaftLabel";
            ShaftLabel.Size = new Size(126, 32);
            ShaftLabel.TabIndex = 15;
            ShaftLabel.Text = "Shaft Label";
            // 
            // AddClubButton
            // 
            AddClubButton.Location = new Point(152, 427);
            AddClubButton.Name = "AddClubButton";
            AddClubButton.Size = new Size(155, 53);
            AddClubButton.TabIndex = 16;
            AddClubButton.Text = "Add Club To My Bag";
            AddClubButton.UseVisualStyleBackColor = true;
            AddClubButton.Click += AddClubButton_Click;
            // 
            // HeadComboBox
            // 
            HeadComboBox.FormattingEnabled = true;
            HeadComboBox.Location = new Point(182, 103);
            HeadComboBox.Name = "HeadComboBox";
            HeadComboBox.Size = new Size(202, 23);
            HeadComboBox.TabIndex = 17;
            // 
            // ShaftComboBox
            // 
            ShaftComboBox.FormattingEnabled = true;
            ShaftComboBox.Location = new Point(182, 255);
            ShaftComboBox.Name = "ShaftComboBox";
            ShaftComboBox.Size = new Size(202, 23);
            ShaftComboBox.TabIndex = 18;
            // 
            // ClubTypeLabel
            // 
            ClubTypeLabel.AutoSize = true;
            ClubTypeLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ClubTypeLabel.ForeColor = Color.FromArgb(0, 64, 0);
            ClubTypeLabel.Location = new Point(6, 173);
            ClubTypeLabel.Name = "ClubTypeLabel";
            ClubTypeLabel.Size = new Size(113, 32);
            ClubTypeLabel.TabIndex = 20;
            ClubTypeLabel.Text = "Club Type";
            // 
            // ClubTypeComboBox
            // 
            ClubTypeComboBox.FormattingEnabled = true;
            ClubTypeComboBox.Location = new Point(182, 179);
            ClubTypeComboBox.Name = "ClubTypeComboBox";
            ClubTypeComboBox.Size = new Size(107, 23);
            ClubTypeComboBox.TabIndex = 21;
            // 
            // ClubBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(440, 492);
            Controls.Add(ClubTypeComboBox);
            Controls.Add(ClubTypeLabel);
            Controls.Add(ShaftComboBox);
            Controls.Add(HeadComboBox);
            Controls.Add(AddClubButton);
            Controls.Add(ShaftLabel);
            Controls.Add(HeadLabel);
            Controls.Add(TitleLabel);
            Name = "ClubBuilderForm";
            Text = "ClubBuilderForm";
            FormClosed += ClubBuilderForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label HeadLabel;
        private Label ShaftLabel;
        private Button AddClubButton;
        private ComboBox HeadComboBox;
        private ComboBox ShaftComboBox;
        private Label ClubTypeLabel;
        private ComboBox ClubTypeComboBox;
    }
}