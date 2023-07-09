namespace GolfTrackerUI
{
    partial class MyBagForm
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
            clubbagLabel = new Label();
            myclubslistbox = new ListBox();
            createclubbuttoon = new Button();
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
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Golf Tracker";
            // 
            // clubbagLabel
            // 
            clubbagLabel.AutoSize = true;
            clubbagLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            clubbagLabel.ForeColor = Color.FromArgb(0, 64, 0);
            clubbagLabel.Location = new Point(279, 69);
            clubbagLabel.Name = "clubbagLabel";
            clubbagLabel.Size = new Size(107, 32);
            clubbagLabel.TabIndex = 13;
            clubbagLabel.Text = "My Clubs";
            // 
            // myclubslistbox
            // 
            myclubslistbox.FormattingEnabled = true;
            myclubslistbox.ItemHeight = 15;
            myclubslistbox.Location = new Point(88, 104);
            myclubslistbox.Name = "myclubslistbox";
            myclubslistbox.Size = new Size(479, 289);
            myclubslistbox.TabIndex = 14;
            // 
            // createclubbuttoon
            // 
            createclubbuttoon.Location = new Point(588, 193);
            createclubbuttoon.Name = "createclubbuttoon";
            createclubbuttoon.Size = new Size(200, 100);
            createclubbuttoon.TabIndex = 15;
            createclubbuttoon.Text = "Add New Club";
            createclubbuttoon.UseVisualStyleBackColor = true;
            createclubbuttoon.Click += createclubbuttoon_Click;
            // 
            // MyBagForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(createclubbuttoon);
            Controls.Add(myclubslistbox);
            Controls.Add(clubbagLabel);
            Controls.Add(TitleLabel);
            Name = "MyBagForm";
            Text = "MyBagForm";
            Load += MyBagForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TitleLabel;
        private Label clubbagLabel;
        private ListBox myclubslistbox;
        private Button createclubbuttoon;
    }
}