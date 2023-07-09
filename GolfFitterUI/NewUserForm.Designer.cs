namespace GolfTrackerUI
{
    partial class NewUserForm
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
            createpasswordLabel = new Label();
            createusernameLabel = new Label();
            passwordbox = new TextBox();
            usernamebox = new TextBox();
            createAccountButton = new Button();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            LastNameBox = new TextBox();
            FirstNameBox = new TextBox();
            HandicapLabel = new Label();
            EmailLabel = new Label();
            HandicapBox = new TextBox();
            EmailBox = new TextBox();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            TitleLabel.Location = new Point(8, 9);
            TitleLabel.Margin = new Padding(8, 0, 8, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 47);
            TitleLabel.TabIndex = 11;
            TitleLabel.Text = "Golf Tracker";
            // 
            // createpasswordLabel
            // 
            createpasswordLabel.AutoSize = true;
            createpasswordLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            createpasswordLabel.ForeColor = Color.FromArgb(0, 64, 0);
            createpasswordLabel.Location = new Point(66, 223);
            createpasswordLabel.Name = "createpasswordLabel";
            createpasswordLabel.Size = new Size(157, 30);
            createpasswordLabel.TabIndex = 15;
            createpasswordLabel.Text = "Create Password";
            // 
            // createusernameLabel
            // 
            createusernameLabel.AutoSize = true;
            createusernameLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            createusernameLabel.ForeColor = Color.FromArgb(0, 64, 0);
            createusernameLabel.Location = new Point(66, 165);
            createusernameLabel.Name = "createusernameLabel";
            createusernameLabel.Size = new Size(164, 30);
            createusernameLabel.TabIndex = 14;
            createusernameLabel.Text = "Create Username";
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(66, 256);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(173, 23);
            passwordbox.TabIndex = 13;
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(66, 196);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(173, 23);
            usernamebox.TabIndex = 12;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(335, 317);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(103, 35);
            createAccountButton.TabIndex = 16;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.FromArgb(0, 64, 0);
            LastNameLabel.Location = new Point(303, 223);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(106, 30);
            LastNameLabel.TabIndex = 20;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.FromArgb(0, 64, 0);
            FirstNameLabel.Location = new Point(303, 165);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(107, 30);
            FirstNameLabel.TabIndex = 19;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(303, 256);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(173, 23);
            LastNameBox.TabIndex = 18;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(303, 196);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(173, 23);
            FirstNameBox.TabIndex = 17;
            // 
            // HandicapLabel
            // 
            HandicapLabel.AutoSize = true;
            HandicapLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            HandicapLabel.ForeColor = Color.FromArgb(0, 64, 0);
            HandicapLabel.Location = new Point(541, 223);
            HandicapLabel.Name = "HandicapLabel";
            HandicapLabel.Size = new Size(95, 30);
            HandicapLabel.TabIndex = 24;
            HandicapLabel.Text = "Handicap";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            EmailLabel.ForeColor = Color.FromArgb(0, 64, 0);
            EmailLabel.Location = new Point(541, 165);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(132, 30);
            EmailLabel.TabIndex = 23;
            EmailLabel.Text = "Email Address";
            // 
            // HandicapBox
            // 
            HandicapBox.Location = new Point(541, 256);
            HandicapBox.Name = "HandicapBox";
            HandicapBox.Size = new Size(173, 23);
            HandicapBox.TabIndex = 22;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(541, 196);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(173, 23);
            EmailBox.TabIndex = 21;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(HandicapLabel);
            Controls.Add(EmailLabel);
            Controls.Add(HandicapBox);
            Controls.Add(EmailBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(createAccountButton);
            Controls.Add(createpasswordLabel);
            Controls.Add(createusernameLabel);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            Controls.Add(TitleLabel);
            Name = "NewUserForm";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label createpasswordLabel;
        private Label createusernameLabel;
        private TextBox passwordbox;
        private TextBox usernamebox;
        private Button createAccountButton;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private TextBox LastNameBox;
        private TextBox FirstNameBox;
        private Label HandicapLabel;
        private Label EmailLabel;
        private TextBox HandicapBox;
        private TextBox EmailBox;
    }
}