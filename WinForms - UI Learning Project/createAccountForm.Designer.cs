namespace WinForms___UI_Learning_Project
{
    partial class createAccountForm
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
            this.closeButtonRegisterPanel = new System.Windows.Forms.Button();
            this.passwordRegisterText = new System.Windows.Forms.TextBox();
            this.passwordRegisterLabel = new System.Windows.Forms.Label();
            this.usernameRegisterLabel = new System.Windows.Forms.Label();
            this.usernameRegisterText = new System.Windows.Forms.TextBox();
            this.passwordRepeatText = new System.Windows.Forms.TextBox();
            this.passwordRepeatLabel = new System.Windows.Forms.Label();
            this.createAccountRegisterButton = new System.Windows.Forms.Button();
            this.validUsernameLabel = new System.Windows.Forms.Label();
            this.validPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButtonRegisterPanel
            // 
            this.closeButtonRegisterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonRegisterPanel.FlatAppearance.BorderSize = 0;
            this.closeButtonRegisterPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonRegisterPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButtonRegisterPanel.Image = global::WinForms___UI_Learning_Project.Properties.Resources.closeButtonViolet;
            this.closeButtonRegisterPanel.Location = new System.Drawing.Point(457, 12);
            this.closeButtonRegisterPanel.Name = "closeButtonRegisterPanel";
            this.closeButtonRegisterPanel.Size = new System.Drawing.Size(31, 31);
            this.closeButtonRegisterPanel.TabIndex = 1;
            this.closeButtonRegisterPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeButtonRegisterPanel.UseVisualStyleBackColor = true;
            this.closeButtonRegisterPanel.Click += new System.EventHandler(this.closeButtonRegisterPanel_Click);
            // 
            // passwordRegisterText
            // 
            this.passwordRegisterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordRegisterText.BackColor = System.Drawing.Color.Azure;
            this.passwordRegisterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRegisterText.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordRegisterText.ForeColor = System.Drawing.Color.Indigo;
            this.passwordRegisterText.Location = new System.Drawing.Point(84, 252);
            this.passwordRegisterText.Name = "passwordRegisterText";
            this.passwordRegisterText.Size = new System.Drawing.Size(350, 33);
            this.passwordRegisterText.TabIndex = 9;
            this.passwordRegisterText.UseSystemPasswordChar = true;
            this.passwordRegisterText.Click += new System.EventHandler(this.passwordRegisterText_Click);
            this.passwordRegisterText.TextChanged += new System.EventHandler(this.passwordRegisterText_TextChanged);
            // 
            // passwordRegisterLabel
            // 
            this.passwordRegisterLabel.AutoSize = true;
            this.passwordRegisterLabel.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordRegisterLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordRegisterLabel.Location = new System.Drawing.Point(79, 220);
            this.passwordRegisterLabel.Name = "passwordRegisterLabel";
            this.passwordRegisterLabel.Size = new System.Drawing.Size(117, 29);
            this.passwordRegisterLabel.TabIndex = 8;
            this.passwordRegisterLabel.Text = "Password";
            // 
            // usernameRegisterLabel
            // 
            this.usernameRegisterLabel.AutoSize = true;
            this.usernameRegisterLabel.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameRegisterLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usernameRegisterLabel.Location = new System.Drawing.Point(79, 136);
            this.usernameRegisterLabel.Name = "usernameRegisterLabel";
            this.usernameRegisterLabel.Size = new System.Drawing.Size(120, 29);
            this.usernameRegisterLabel.TabIndex = 7;
            this.usernameRegisterLabel.Text = "Username";
            // 
            // usernameRegisterText
            // 
            this.usernameRegisterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameRegisterText.BackColor = System.Drawing.Color.Azure;
            this.usernameRegisterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameRegisterText.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameRegisterText.ForeColor = System.Drawing.Color.Indigo;
            this.usernameRegisterText.Location = new System.Drawing.Point(84, 168);
            this.usernameRegisterText.Name = "usernameRegisterText";
            this.usernameRegisterText.Size = new System.Drawing.Size(350, 33);
            this.usernameRegisterText.TabIndex = 6;
            this.usernameRegisterText.Click += new System.EventHandler(this.usernameRegisterText_Click);
            this.usernameRegisterText.TextChanged += new System.EventHandler(this.usernameRegisterText_TextChanged);
            // 
            // passwordRepeatText
            // 
            this.passwordRepeatText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordRepeatText.BackColor = System.Drawing.Color.Azure;
            this.passwordRepeatText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRepeatText.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordRepeatText.ForeColor = System.Drawing.Color.Indigo;
            this.passwordRepeatText.Location = new System.Drawing.Point(84, 337);
            this.passwordRepeatText.Name = "passwordRepeatText";
            this.passwordRepeatText.Size = new System.Drawing.Size(350, 33);
            this.passwordRepeatText.TabIndex = 11;
            this.passwordRepeatText.UseSystemPasswordChar = true;
            // 
            // passwordRepeatLabel
            // 
            this.passwordRepeatLabel.AutoSize = true;
            this.passwordRepeatLabel.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordRepeatLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordRepeatLabel.Location = new System.Drawing.Point(79, 305);
            this.passwordRepeatLabel.Name = "passwordRepeatLabel";
            this.passwordRepeatLabel.Size = new System.Drawing.Size(196, 29);
            this.passwordRepeatLabel.TabIndex = 10;
            this.passwordRepeatLabel.Text = "Repeat Password";
            // 
            // createAccountRegisterButton
            // 
            this.createAccountRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccountRegisterButton.BackColor = System.Drawing.Color.BlueViolet;
            this.createAccountRegisterButton.FlatAppearance.BorderSize = 0;
            this.createAccountRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountRegisterButton.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountRegisterButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createAccountRegisterButton.Location = new System.Drawing.Point(153, 419);
            this.createAccountRegisterButton.Name = "createAccountRegisterButton";
            this.createAccountRegisterButton.Size = new System.Drawing.Size(200, 50);
            this.createAccountRegisterButton.TabIndex = 12;
            this.createAccountRegisterButton.Text = "Create Account";
            this.createAccountRegisterButton.UseVisualStyleBackColor = false;
            this.createAccountRegisterButton.Click += new System.EventHandler(this.createAccountRegisterButton_Click);
            // 
            // validUsernameLabel
            // 
            this.validUsernameLabel.AutoSize = true;
            this.validUsernameLabel.Location = new System.Drawing.Point(84, 488);
            this.validUsernameLabel.Name = "validUsernameLabel";
            this.validUsernameLabel.Size = new System.Drawing.Size(0, 19);
            this.validUsernameLabel.TabIndex = 13;
            this.validUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validPasswordLabel
            // 
            this.validPasswordLabel.AutoSize = true;
            this.validPasswordLabel.Location = new System.Drawing.Point(84, 521);
            this.validPasswordLabel.Name = "validPasswordLabel";
            this.validPasswordLabel.Size = new System.Drawing.Size(0, 19);
            this.validPasswordLabel.TabIndex = 14;
            this.validPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.validPasswordLabel);
            this.Controls.Add(this.validUsernameLabel);
            this.Controls.Add(this.createAccountRegisterButton);
            this.Controls.Add(this.passwordRepeatText);
            this.Controls.Add(this.passwordRepeatLabel);
            this.Controls.Add(this.passwordRegisterText);
            this.Controls.Add(this.passwordRegisterLabel);
            this.Controls.Add(this.usernameRegisterLabel);
            this.Controls.Add(this.usernameRegisterText);
            this.Controls.Add(this.closeButtonRegisterPanel);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "createAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButtonRegisterPanel;
        private TextBox passwordRegisterText;
        private Label passwordRegisterLabel;
        private Label usernameRegisterLabel;
        private TextBox usernameRegisterText;
        private TextBox passwordRepeatText;
        private Label passwordRepeatLabel;
        private Button createAccountRegisterButton;
        private Label validUsernameLabel;
        private Label validPasswordLabel;
    }
}