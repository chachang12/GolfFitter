namespace GolfTrackerUI
{
    partial class GolfHomePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            golfHeader = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mybagbutton = new Button();
            newsessionbutton = new Button();
            mystatsbutton = new Button();
            getfittedbutton = new Button();
            usernamelabel = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // golfHeader
            // 
            golfHeader.AutoSize = true;
            golfHeader.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            golfHeader.ForeColor = Color.FromArgb(0, 64, 0);
            golfHeader.Location = new Point(10, 7);
            golfHeader.Name = "golfHeader";
            golfHeader.Size = new Size(203, 50);
            golfHeader.TabIndex = 0;
            golfHeader.Text = "Golf Tracker";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(mybagbutton);
            flowLayoutPanel1.Controls.Add(newsessionbutton);
            flowLayoutPanel1.Controls.Add(mystatsbutton);
            flowLayoutPanel1.Controls.Add(getfittedbutton);
            flowLayoutPanel1.Location = new Point(235, 360);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(325, 79);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // mybagbutton
            // 
            mybagbutton.Location = new Point(3, 2);
            mybagbutton.Margin = new Padding(3, 2, 3, 2);
            mybagbutton.Name = "mybagbutton";
            mybagbutton.Size = new Size(75, 75);
            mybagbutton.TabIndex = 0;
            mybagbutton.Text = "My Bag";
            mybagbutton.UseVisualStyleBackColor = true;
            mybagbutton.Click += mybagbutton_Click;
            // 
            // newsessionbutton
            // 
            newsessionbutton.Location = new Point(84, 2);
            newsessionbutton.Margin = new Padding(3, 2, 3, 2);
            newsessionbutton.Name = "newsessionbutton";
            newsessionbutton.Size = new Size(75, 75);
            newsessionbutton.TabIndex = 1;
            newsessionbutton.Text = "New Session";
            newsessionbutton.UseVisualStyleBackColor = true;
            newsessionbutton.Click += newsessionbutton_Click;
            // 
            // mystatsbutton
            // 
            mystatsbutton.Location = new Point(165, 2);
            mystatsbutton.Margin = new Padding(3, 2, 3, 2);
            mystatsbutton.Name = "mystatsbutton";
            mystatsbutton.Size = new Size(75, 75);
            mystatsbutton.TabIndex = 2;
            mystatsbutton.Text = "My Stats";
            mystatsbutton.UseVisualStyleBackColor = true;
            mystatsbutton.Click += mystatsbutton_Click;
            // 
            // getfittedbutton
            // 
            getfittedbutton.Location = new Point(246, 2);
            getfittedbutton.Margin = new Padding(3, 2, 3, 2);
            getfittedbutton.Name = "getfittedbutton";
            getfittedbutton.Size = new Size(75, 75);
            getfittedbutton.TabIndex = 3;
            getfittedbutton.Text = "Get Fitted";
            getfittedbutton.UseVisualStyleBackColor = true;
            getfittedbutton.Click += getfittedbutton_Click;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelabel.ForeColor = Color.FromArgb(0, 64, 0);
            usernamelabel.Location = new Point(636, 9);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(152, 50);
            usernamelabel.TabIndex = 2;
            usernamelabel.Text = "<USER>";
            // 
            // GolfHomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(usernamelabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(golfHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GolfHomePageForm";
            Text = "golftrackerHomePage";
            Load += GolfHomePageForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label golfHeader;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button mybagbutton;
        private Button newsessionbutton;
        private Button mystatsbutton;
        private Button getfittedbutton;
        private Label usernamelabel;
    }
}