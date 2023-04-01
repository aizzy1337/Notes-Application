namespace WinForms___UI_Learning_Project
{
    partial class mainApplicationForm
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
            this.controlMainPanel = new System.Windows.Forms.Panel();
            this.logoMainPanel = new System.Windows.Forms.Label();
            this.minimizeButtonMainPanel = new System.Windows.Forms.Button();
            this.closeButtonMainPanel = new System.Windows.Forms.Button();
            this.menuMainPanel = new System.Windows.Forms.Panel();
            this.controlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlMainPanel
            // 
            this.controlMainPanel.BackColor = System.Drawing.Color.Navy;
            this.controlMainPanel.Controls.Add(this.logoMainPanel);
            this.controlMainPanel.Controls.Add(this.minimizeButtonMainPanel);
            this.controlMainPanel.Controls.Add(this.closeButtonMainPanel);
            this.controlMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.controlMainPanel.Name = "controlMainPanel";
            this.controlMainPanel.Size = new System.Drawing.Size(1280, 30);
            this.controlMainPanel.TabIndex = 0;
            // 
            // logoMainPanel
            // 
            this.logoMainPanel.AutoSize = true;
            this.logoMainPanel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoMainPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoMainPanel.Location = new System.Drawing.Point(587, 4);
            this.logoMainPanel.Name = "logoMainPanel";
            this.logoMainPanel.Size = new System.Drawing.Size(106, 23);
            this.logoMainPanel.TabIndex = 3;
            this.logoMainPanel.Text = "Application";
            // 
            // minimizeButtonMainPanel
            // 
            this.minimizeButtonMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButtonMainPanel.FlatAppearance.BorderSize = 0;
            this.minimizeButtonMainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButtonMainPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButtonMainPanel.Image = global::WinForms___UI_Learning_Project.Properties.Resources.minimizeButtonViolet;
            this.minimizeButtonMainPanel.Location = new System.Drawing.Point(1212, 0);
            this.minimizeButtonMainPanel.Name = "minimizeButtonMainPanel";
            this.minimizeButtonMainPanel.Size = new System.Drawing.Size(31, 31);
            this.minimizeButtonMainPanel.TabIndex = 2;
            this.minimizeButtonMainPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.minimizeButtonMainPanel.UseVisualStyleBackColor = true;
            this.minimizeButtonMainPanel.Click += new System.EventHandler(this.minimizeButtonMainPanel_Click);
            // 
            // closeButtonMainPanel
            // 
            this.closeButtonMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButtonMainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButtonMainPanel.FlatAppearance.BorderSize = 0;
            this.closeButtonMainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonMainPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButtonMainPanel.Image = global::WinForms___UI_Learning_Project.Properties.Resources.closeButtonViolet;
            this.closeButtonMainPanel.Location = new System.Drawing.Point(1249, 0);
            this.closeButtonMainPanel.Name = "closeButtonMainPanel";
            this.closeButtonMainPanel.Size = new System.Drawing.Size(31, 30);
            this.closeButtonMainPanel.TabIndex = 1;
            this.closeButtonMainPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeButtonMainPanel.UseVisualStyleBackColor = true;
            this.closeButtonMainPanel.Click += new System.EventHandler(this.closeButtonMainPanel_Click);
            // 
            // menuMainPanel
            // 
            this.menuMainPanel.BackColor = System.Drawing.Color.Navy;
            this.menuMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMainPanel.Location = new System.Drawing.Point(0, 30);
            this.menuMainPanel.Name = "menuMainPanel";
            this.menuMainPanel.Size = new System.Drawing.Size(275, 690);
            this.menuMainPanel.TabIndex = 1;
            // 
            // mainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.menuMainPanel);
            this.Controls.Add(this.controlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainApplicationForm";
            this.controlMainPanel.ResumeLayout(false);
            this.controlMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel controlMainPanel;
        private Button closeButtonMainPanel;
        private Button minimizeButtonMainPanel;
        private Label logoMainPanel;
        private Panel menuMainPanel;
    }
}