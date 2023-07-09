namespace GolfTrackerUI
{
    partial class SessionForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.datesesLabel = new System.Windows.Forms.Label();
            this.snLabel = new System.Windows.Forms.Label();
            this.clubLabel = new System.Windows.Forms.Label();
            this.bsLabel = new System.Windows.Forms.Label();
            this.chLabel = new System.Windows.Forms.Label();
            this.laLabel = new System.Windows.Forms.Label();
            this.srLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TitleLabel.Location = new System.Drawing.Point(19, 12);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(242, 60);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Golf Tracker";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(78, 191);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 392);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessionLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.sessionLabel.Location = new System.Drawing.Point(19, 75);
            this.sessionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(161, 60);
            this.sessionLabel.TabIndex = 17;
            this.sessionLabel.Text = "Session";
            // 
            // datesesLabel
            // 
            this.datesesLabel.AutoSize = true;
            this.datesesLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datesesLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.datesesLabel.Location = new System.Drawing.Point(168, 75);
            this.datesesLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.datesesLabel.Name = "datesesLabel";
            this.datesesLabel.Size = new System.Drawing.Size(277, 60);
            this.datesesLabel.TabIndex = 18;
            this.datesesLabel.Text = "<dd/mm/yy>";
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Location = new System.Drawing.Point(78, 167);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(97, 20);
            this.snLabel.TabIndex = 19;
            this.snLabel.Text = "Shot Number";
            // 
            // clubLabel
            // 
            this.clubLabel.AutoSize = true;
            this.clubLabel.Location = new System.Drawing.Point(186, 167);
            this.clubLabel.Name = "clubLabel";
            this.clubLabel.Size = new System.Drawing.Size(39, 20);
            this.clubLabel.TabIndex = 20;
            this.clubLabel.Text = "Club";
            // 
            // bsLabel
            // 
            this.bsLabel.AutoSize = true;
            this.bsLabel.Location = new System.Drawing.Point(245, 167);
            this.bsLabel.Name = "bsLabel";
            this.bsLabel.Size = new System.Drawing.Size(80, 20);
            this.bsLabel.TabIndex = 21;
            this.bsLabel.Text = "Ball Speed";
            // 
            // chLabel
            // 
            this.chLabel.AutoSize = true;
            this.chLabel.Location = new System.Drawing.Point(362, 167);
            this.chLabel.Name = "chLabel";
            this.chLabel.Size = new System.Drawing.Size(125, 20);
            this.chLabel.TabIndex = 22;
            this.chLabel.Text = "Club Head Speed";
            // 
            // laLabel
            // 
            this.laLabel.AutoSize = true;
            this.laLabel.Location = new System.Drawing.Point(509, 167);
            this.laLabel.Name = "laLabel";
            this.laLabel.Size = new System.Drawing.Size(98, 20);
            this.laLabel.TabIndex = 23;
            this.laLabel.Text = "Launch Angle";
            // 
            // srLabel
            // 
            this.srLabel.AutoSize = true;
            this.srLabel.Location = new System.Drawing.Point(645, 167);
            this.srLabel.Name = "srLabel";
            this.srLabel.Size = new System.Drawing.Size(72, 20);
            this.srLabel.TabIndex = 24;
            this.srLabel.Text = "Spin Rate";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(762, 167);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(66, 20);
            this.dLabel.TabIndex = 25;
            this.dLabel.Text = "Distance";
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.srLabel);
            this.Controls.Add(this.laLabel);
            this.Controls.Add(this.chLabel);
            this.Controls.Add(this.bsLabel);
            this.Controls.Add(this.clubLabel);
            this.Controls.Add(this.snLabel);
            this.Controls.Add(this.datesesLabel);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SessionForm";
            this.Text = "SessionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private ListView listView1;
        private Label sessionLabel;
        private Label datesesLabel;
        private Label snLabel;
        private Label clubLabel;
        private Label bsLabel;
        private Label chLabel;
        private Label laLabel;
        private Label srLabel;
        private Label dLabel;
    }
}