namespace GolfTrackerUI
{
    partial class LoginPageForm
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
            usernamebox = new TextBox();
            passwordbox = new TextBox();
            usernamelabel = new Label();
            passwordlabel = new Label();
            loginbutton = new Button();
            TitleLabel = new Label();
            newUserButton = new Button();
            NewUserLabel = new Label();
            SuspendLayout();
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(172, 204);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(173, 23);
            usernamebox.TabIndex = 0;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(172, 263);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(173, 23);
            passwordbox.TabIndex = 1;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            usernamelabel.ForeColor = Color.FromArgb(0, 64, 0);
            usernamelabel.Location = new Point(172, 172);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(101, 30);
            usernamelabel.TabIndex = 2;
            usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            passwordlabel.ForeColor = Color.FromArgb(0, 64, 0);
            passwordlabel.Location = new Point(172, 230);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(94, 30);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password";
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(217, 305);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(85, 24);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
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
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Golf Tracker";
            // 
            // newUserButton
            // 
            newUserButton.Location = new Point(523, 232);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(103, 35);
            newUserButton.TabIndex = 17;
            newUserButton.Text = "Create Account";
            newUserButton.UseVisualStyleBackColor = true;
            newUserButton.Click += newUserButton_Click;
            // 
            // NewUserLabel
            // 
            NewUserLabel.AutoSize = true;
            NewUserLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NewUserLabel.ForeColor = Color.FromArgb(0, 64, 0);
            NewUserLabel.Location = new Point(523, 195);
            NewUserLabel.Name = "NewUserLabel";
            NewUserLabel.Size = new Size(108, 30);
            NewUserLabel.TabIndex = 18;
            NewUserLabel.Text = "New User?";
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(NewUserLabel);
            Controls.Add(newUserButton);
            Controls.Add(TitleLabel);
            Controls.Add(loginbutton);
            Controls.Add(passwordlabel);
            Controls.Add(usernamelabel);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            ForeColor = Color.Black;
            Name = "LoginPageForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernamebox;
        private TextBox passwordbox;
        private Label usernamelabel;
        private Label passwordlabel;
        private Button loginbutton;
        private Label TitleLabel;
        private Button newUserButton;
        private Label NewUserLabel;
    }
}