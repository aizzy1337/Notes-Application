namespace WinForms___UI_Learning_Project
{
    partial class loggingForm
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
            this.closeButtonLoggingPanel = new System.Windows.Forms.Button();
            this.minimizeButtonLoggingPanel = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.underLogoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButtonLoggingPanel
            // 
            this.closeButtonLoggingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonLoggingPanel.FlatAppearance.BorderSize = 0;
            this.closeButtonLoggingPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonLoggingPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButtonLoggingPanel.Image = global::WinForms___UI_Learning_Project.Properties.Resources.closeButtonViolet;
            this.closeButtonLoggingPanel.Location = new System.Drawing.Point(457, 12);
            this.closeButtonLoggingPanel.Name = "closeButtonLoggingPanel";
            this.closeButtonLoggingPanel.Size = new System.Drawing.Size(31, 31);
            this.closeButtonLoggingPanel.TabIndex = 0;
            this.closeButtonLoggingPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeButtonLoggingPanel.UseVisualStyleBackColor = true;
            this.closeButtonLoggingPanel.Click += new System.EventHandler(this.closeButtonLoggingPanel_Click);
            this.closeButtonLoggingPanel.MouseLeave += new System.EventHandler(this.closeButtonLoggingPanel_MouseLeave);
            this.closeButtonLoggingPanel.MouseHover += new System.EventHandler(this.closeButtonLoggingPanel_MouseHover);
            // 
            // minimizeButtonLoggingPanel
            // 
            this.minimizeButtonLoggingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButtonLoggingPanel.FlatAppearance.BorderSize = 0;
            this.minimizeButtonLoggingPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButtonLoggingPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButtonLoggingPanel.Image = global::WinForms___UI_Learning_Project.Properties.Resources.minimizeButtonViolet;
            this.minimizeButtonLoggingPanel.Location = new System.Drawing.Point(420, 12);
            this.minimizeButtonLoggingPanel.Name = "minimizeButtonLoggingPanel";
            this.minimizeButtonLoggingPanel.Size = new System.Drawing.Size(31, 31);
            this.minimizeButtonLoggingPanel.TabIndex = 1;
            this.minimizeButtonLoggingPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.minimizeButtonLoggingPanel.UseVisualStyleBackColor = true;
            this.minimizeButtonLoggingPanel.Click += new System.EventHandler(this.minimizeButtonLoggingPanel_Click);
            this.minimizeButtonLoggingPanel.MouseLeave += new System.EventHandler(this.minimizeButtonLoggingPanel_MouseLeave);
            this.minimizeButtonLoggingPanel.MouseHover += new System.EventHandler(this.minimizeButtonLoggingPanel_MouseHover);
            // 
            // usernameText
            // 
            this.usernameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameText.BackColor = System.Drawing.Color.Azure;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameText.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameText.ForeColor = System.Drawing.Color.Indigo;
            this.usernameText.Location = new System.Drawing.Point(75, 264);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(350, 33);
            this.usernameText.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usernameLabel.Location = new System.Drawing.Point(70, 232);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(120, 29);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordLabel.Location = new System.Drawing.Point(70, 316);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 29);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.BackColor = System.Drawing.Color.Azure;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.ForeColor = System.Drawing.Color.Indigo;
            this.passwordText.Location = new System.Drawing.Point(75, 348);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(350, 33);
            this.passwordText.TabIndex = 5;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.BackColor = System.Drawing.Color.BlueViolet;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logInButton.Location = new System.Drawing.Point(149, 438);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(200, 50);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.MouseLeave += new System.EventHandler(this.logInButton_MouseLeave);
            this.logInButton.MouseHover += new System.EventHandler(this.logInButton_MouseHover);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccountButton.BackColor = System.Drawing.Color.BlueViolet;
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createAccountButton.Location = new System.Drawing.Point(149, 504);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(200, 50);
            this.createAccountButton.TabIndex = 7;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            this.createAccountButton.MouseLeave += new System.EventHandler(this.createAccountButton_MouseLeave);
            this.createAccountButton.MouseHover += new System.EventHandler(this.createAccountButton_MouseHover);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logoLabel.Location = new System.Drawing.Point(112, 97);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(278, 58);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "Application";
            // 
            // underLogoLabel
            // 
            this.underLogoLabel.AutoSize = true;
            this.underLogoLabel.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.underLogoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.underLogoLabel.Location = new System.Drawing.Point(85, 155);
            this.underLogoLabel.Name = "underLogoLabel";
            this.underLogoLabel.Size = new System.Drawing.Size(333, 23);
            this.underLogoLabel.TabIndex = 9;
            this.underLogoLabel.Text = "A demo application by Arkadiusz Zając";
            // 
            // loggingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.underLogoLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.minimizeButtonLoggingPanel);
            this.Controls.Add(this.closeButtonLoggingPanel);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loggingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loggingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButtonLoggingPanel;
        private Button minimizeButtonLoggingPanel;
        private TextBox usernameText;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordText;
        private Button logInButton;
        private Button createAccountButton;
        private Label logoLabel;
        private Label underLogoLabel;
    }
}