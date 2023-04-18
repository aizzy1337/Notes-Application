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
            this.tasksButton = new System.Windows.Forms.Button();
            this.tasksButtonsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.dateTaskPicker = new System.Windows.Forms.DateTimePicker();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.showTasksLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.tasksListBox = new System.Windows.Forms.CheckedListBox();
            this.doneTasksListBox = new System.Windows.Forms.ListBox();
            this.controlMainPanel.SuspendLayout();
            this.menuMainPanel.SuspendLayout();
            this.tasksButtonsLayoutPanel.SuspendLayout();
            this.showTasksLayout.SuspendLayout();
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
            this.menuMainPanel.Controls.Add(this.tasksButton);
            this.menuMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMainPanel.Location = new System.Drawing.Point(0, 30);
            this.menuMainPanel.Name = "menuMainPanel";
            this.menuMainPanel.Size = new System.Drawing.Size(275, 690);
            this.menuMainPanel.TabIndex = 1;
            // 
            // tasksButton
            // 
            this.tasksButton.AutoSize = true;
            this.tasksButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.tasksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksButton.FlatAppearance.BorderSize = 0;
            this.tasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tasksButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksButton.Location = new System.Drawing.Point(0, 0);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(275, 48);
            this.tasksButton.TabIndex = 0;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            this.tasksButton.MouseHover += new System.EventHandler(this.tasksButton_MouseHover);
            // 
            // tasksButtonsLayoutPanel
            // 
            this.tasksButtonsLayoutPanel.Controls.Add(this.taskNameLabel);
            this.tasksButtonsLayoutPanel.Controls.Add(this.taskNameTextBox);
            this.tasksButtonsLayoutPanel.Controls.Add(this.taskDateLabel);
            this.tasksButtonsLayoutPanel.Controls.Add(this.dateTaskPicker);
            this.tasksButtonsLayoutPanel.Controls.Add(this.addTaskButton);
            this.tasksButtonsLayoutPanel.Controls.Add(this.deleteTaskButton);
            this.tasksButtonsLayoutPanel.Controls.Add(this.completeTaskButton);
            this.tasksButtonsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tasksButtonsLayoutPanel.Location = new System.Drawing.Point(276, 30);
            this.tasksButtonsLayoutPanel.Name = "tasksButtonsLayoutPanel";
            this.tasksButtonsLayoutPanel.Size = new System.Drawing.Size(500, 690);
            this.tasksButtonsLayoutPanel.TabIndex = 2;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskNameLabel.Location = new System.Drawing.Point(100, 100);
            this.taskNameLabel.Margin = new System.Windows.Forms.Padding(100, 100, 3, 0);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(105, 25);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task Name";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskNameTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.taskNameTextBox.Location = new System.Drawing.Point(100, 130);
            this.taskNameTextBox.Margin = new System.Windows.Forms.Padding(100, 5, 3, 3);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PlaceholderText = "Write a task name...";
            this.taskNameTextBox.Size = new System.Drawing.Size(300, 33);
            this.taskNameTextBox.TabIndex = 0;
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskDateLabel.Location = new System.Drawing.Point(100, 186);
            this.taskDateLabel.Margin = new System.Windows.Forms.Padding(100, 20, 3, 0);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(53, 25);
            this.taskDateLabel.TabIndex = 2;
            this.taskDateLabel.Text = "Date";
            // 
            // dateTaskPicker
            // 
            this.dateTaskPicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTaskPicker.CustomFormat = "dd.MM.yyyy, HH:mm";
            this.dateTaskPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTaskPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTaskPicker.Location = new System.Drawing.Point(100, 216);
            this.dateTaskPicker.Margin = new System.Windows.Forms.Padding(100, 5, 3, 3);
            this.dateTaskPicker.Name = "dateTaskPicker";
            this.dateTaskPicker.Size = new System.Drawing.Size(300, 33);
            this.dateTaskPicker.TabIndex = 3;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTaskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTaskButton.Location = new System.Drawing.Point(100, 302);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(300, 35);
            this.addTaskButton.TabIndex = 4;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.deleteTaskButton.FlatAppearance.BorderSize = 0;
            this.deleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTaskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteTaskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteTaskButton.Location = new System.Drawing.Point(100, 390);
            this.deleteTaskButton.Margin = new System.Windows.Forms.Padding(100, 50, 3, 3);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(300, 35);
            this.deleteTaskButton.TabIndex = 5;
            this.deleteTaskButton.Text = "Delete task";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.completeTaskButton.FlatAppearance.BorderSize = 0;
            this.completeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTaskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completeTaskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.completeTaskButton.Location = new System.Drawing.Point(100, 438);
            this.completeTaskButton.Margin = new System.Windows.Forms.Padding(100, 10, 3, 3);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(300, 35);
            this.completeTaskButton.TabIndex = 6;
            this.completeTaskButton.Text = "Mark as completed";
            this.completeTaskButton.UseVisualStyleBackColor = false;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // showTasksLayout
            // 
            this.showTasksLayout.Controls.Add(this.taskLabel);
            this.showTasksLayout.Controls.Add(this.tasksListBox);
            this.showTasksLayout.Controls.Add(this.doneTasksListBox);
            this.showTasksLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.showTasksLayout.Location = new System.Drawing.Point(780, 30);
            this.showTasksLayout.Name = "showTasksLayout";
            this.showTasksLayout.Size = new System.Drawing.Size(500, 690);
            this.showTasksLayout.TabIndex = 3;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskLabel.Location = new System.Drawing.Point(215, 20);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(215, 20, 3, 50);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(71, 32);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Tasks";
            // 
            // tasksListBox
            // 
            this.tasksListBox.BackColor = System.Drawing.Color.Indigo;
            this.tasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tasksListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(3, 105);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(497, 420);
            this.tasksListBox.TabIndex = 1;
            this.tasksListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tasksListBox_ItemCheck);
            // 
            // doneTasksListBox
            // 
            this.doneTasksListBox.BackColor = System.Drawing.Color.Indigo;
            this.doneTasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doneTasksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.doneTasksListBox.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.doneTasksListBox.FormattingEnabled = true;
            this.doneTasksListBox.ItemHeight = 25;
            this.doneTasksListBox.Location = new System.Drawing.Point(3, 531);
            this.doneTasksListBox.Name = "doneTasksListBox";
            this.doneTasksListBox.Size = new System.Drawing.Size(497, 125);
            this.doneTasksListBox.TabIndex = 2;
            // 
            // mainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.showTasksLayout);
            this.Controls.Add(this.tasksButtonsLayoutPanel);
            this.Controls.Add(this.menuMainPanel);
            this.Controls.Add(this.controlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainApplicationForm";
            this.controlMainPanel.ResumeLayout(false);
            this.controlMainPanel.PerformLayout();
            this.menuMainPanel.ResumeLayout(false);
            this.menuMainPanel.PerformLayout();
            this.tasksButtonsLayoutPanel.ResumeLayout(false);
            this.tasksButtonsLayoutPanel.PerformLayout();
            this.showTasksLayout.ResumeLayout(false);
            this.showTasksLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel controlMainPanel;
        private Button closeButtonMainPanel;
        private Button minimizeButtonMainPanel;
        private Label logoMainPanel;
        private Panel menuMainPanel;
        private Button tasksButton;
        private FlowLayoutPanel tasksButtonsLayoutPanel;
        private TextBox textBox1;
        private TextBox taskNameTextBox;
        private Label taskNameLabel;
        private Label taskDateLabel;
        private DateTimePicker dateTaskPicker;
        private Button addTaskButton;
        private Button deleteTaskButton;
        private Button completeTaskButton;
        private FlowLayoutPanel showTasksLayout;
        private Label taskLabel;
        private CheckedListBox tasksListBox;
        private ListBox doneTasksListBox;
    }
}