namespace GolfFitterUI
{
    partial class ClubFitterForm
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
            usernamelabel = new Label();
            handicaplabel = new Label();
            avgballspeedlabel = new Label();
            avgspinlabel = new Label();
            listView1 = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            RCCheadLabel = new Label();
            RCCSLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fitmebutton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            TitleLabel.Location = new Point(9, 9);
            TitleLabel.Margin = new Padding(8, 0, 8, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 47);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Golf Tracker";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelabel.ForeColor = Color.FromArgb(0, 64, 0);
            usernamelabel.Location = new Point(17, 192);
            usernamelabel.Margin = new Padding(8, 0, 8, 0);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(212, 47);
            usernamelabel.TabIndex = 15;
            usernamelabel.Text = "<username>";
            // 
            // handicaplabel
            // 
            handicaplabel.AutoSize = true;
            handicaplabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            handicaplabel.ForeColor = Color.FromArgb(0, 64, 0);
            handicaplabel.Location = new Point(17, 298);
            handicaplabel.Margin = new Padding(8, 0, 8, 0);
            handicaplabel.Name = "handicaplabel";
            handicaplabel.Size = new Size(201, 47);
            handicaplabel.TabIndex = 16;
            handicaplabel.Text = "<handicap>";
            // 
            // avgballspeedlabel
            // 
            avgballspeedlabel.AutoSize = true;
            avgballspeedlabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            avgballspeedlabel.ForeColor = Color.FromArgb(0, 64, 0);
            avgballspeedlabel.Location = new Point(17, 404);
            avgballspeedlabel.Margin = new Padding(8, 0, 8, 0);
            avgballspeedlabel.Name = "avgballspeedlabel";
            avgballspeedlabel.Size = new Size(271, 47);
            avgballspeedlabel.TabIndex = 17;
            avgballspeedlabel.Text = "<avgclubspeed>";
            // 
            // avgspinlabel
            // 
            avgspinlabel.AutoSize = true;
            avgspinlabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            avgspinlabel.ForeColor = Color.FromArgb(0, 64, 0);
            avgspinlabel.Location = new Point(17, 510);
            avgspinlabel.Margin = new Padding(8, 0, 8, 0);
            avgspinlabel.Name = "avgspinlabel";
            avgspinlabel.Size = new Size(236, 47);
            avgspinlabel.TabIndex = 18;
            avgspinlabel.Text = "<avgspinrate>";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader6 });
            listView1.Location = new Point(438, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(300, 400);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Brand";
            columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Club Head Model";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Loft";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 75;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Location = new Point(835, 169);
            listView2.Name = "listView2";
            listView2.Size = new Size(300, 400);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Shaft Model";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Shaft Brand";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Flex";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Weight";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Spec";
            // 
            // RCCheadLabel
            // 
            RCCheadLabel.AutoSize = true;
            RCCheadLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RCCheadLabel.ForeColor = Color.FromArgb(0, 64, 0);
            RCCheadLabel.Location = new Point(438, 134);
            RCCheadLabel.Margin = new Padding(8, 0, 8, 0);
            RCCheadLabel.Name = "RCCheadLabel";
            RCCheadLabel.Size = new Size(293, 32);
            RCCheadLabel.TabIndex = 23;
            RCCheadLabel.Text = "Recommended Club Heads:";
            // 
            // RCCSLabel
            // 
            RCCSLabel.AutoSize = true;
            RCCSLabel.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RCCSLabel.ForeColor = Color.FromArgb(0, 64, 0);
            RCCSLabel.Location = new Point(835, 134);
            RCCSLabel.Margin = new Padding(8, 0, 8, 0);
            RCCSLabel.Name = "RCCSLabel";
            RCCSLabel.Size = new Size(292, 32);
            RCCSLabel.TabIndex = 24;
            RCCSLabel.Text = "Recommended Club Shafts:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(17, 457);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 47);
            label1.TabIndex = 28;
            label1.Text = "Average Spin Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(17, 351);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 47);
            label2.TabIndex = 27;
            label2.Text = "Average Club Speed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(17, 245);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 47);
            label3.TabIndex = 26;
            label3.Text = "Handicap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(17, 139);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 47);
            label4.TabIndex = 25;
            label4.Text = "User Name";
            // 
            // fitmebutton
            // 
            fitmebutton.BackColor = Color.White;
            fitmebutton.Location = new Point(701, 593);
            fitmebutton.Name = "fitmebutton";
            fitmebutton.Size = new Size(176, 74);
            fitmebutton.TabIndex = 29;
            fitmebutton.Text = "Fit Me";
            fitmebutton.UseVisualStyleBackColor = false;
            fitmebutton.Click += fitmebutton_Click;
            // 
            // ClubFitterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1184, 681);
            Controls.Add(fitmebutton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(RCCSLabel);
            Controls.Add(RCCheadLabel);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(avgspinlabel);
            Controls.Add(avgballspeedlabel);
            Controls.Add(handicaplabel);
            Controls.Add(usernamelabel);
            Controls.Add(TitleLabel);
            Name = "ClubFitterForm";
            Text = "ClubFitterForm";
            Load += ClubFitterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label usernamelabel;
        private Label handicaplabel;
        private Label avgballspeedlabel;
        private Label avgspinlabel;
        private ListView listView1;
        private ListView listView2;
        private Label RCCheadLabel;
        private Label RCCSLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button fitmebutton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader6;
    }
}