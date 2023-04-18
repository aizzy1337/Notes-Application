using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___UI_Learning_Project
{
    public partial class mainApplicationForm : Form
    {
        public mainApplicationForm()
        {
            InitializeComponent();
            tasksButtonsLayoutPanel.Visible = false;
            showTasksLayout.Visible = false;
        }

        private void closeButtonMainPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButtonMainPanel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tasksButton_MouseHover(object sender, EventArgs e)
        {

        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            tasksButton.ForeColor = Color.Indigo;
            tasksButtonsLayoutPanel.Visible = true;
            showTasksLayout.Visible = true;
            showTasks();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if(taskNameTextBox.Text.Length != 0)
            {
                databaseHandlerTasks.insertTasksData(taskNameTextBox.Text, dateTaskPicker.Value);
                showTasks();
            }
            else
            {
                MessageBox.Show("Task name must be at least one character");
            }
        }

        private void showTasks()
        {
            tasksListBox.Items.Clear();
            doneTasksListBox.Items.Clear();

            int i = 0;
            foreach (var item in databaseHandlerTasks.getTasksData())
            {

                if (!item.isChecked)
                {

                    tasksListBox.Items.Add(item.name + " - " + item.time.ToString("dd.MM.yyyy, HH:mm"));

                }
                else if (item.isChecked && i < 5)
                {
                    doneTasksListBox.Items.Add(item.name + " - " + item.time.ToString("dd.MM.yyyy, HH:mm"));
                    i++;
                }

            }

            if (databaseHandlerTasks.getTasksData().Count == 0)
            {
                tasksListBox.Visible = false;
                Label noDataLabel = new Label();
                noDataLabel.Text = "No data...";
                noDataLabel.ForeColor = Color.White;
                showTasksLayout.Controls.Add(noDataLabel);
            }

        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if(tasksListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Check a task which you want to delete.");
            }
            else
            {
                var results = databaseHandlerTasks.getTasksData();

                foreach (var item in results) {

                    var split = tasksListBox.CheckedItems[0].ToString().Split(' ');
                    if (item.name == split[0] && item.time.ToString("dd.MM.yyyy, HH:mm") == (split[2] + ' ' + split[3]))
                    {
                        databaseHandlerTasks.deleteTask(item.taskId);
                    }

                }

                showTasks();
            }
        }

        private void tasksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < tasksListBox.Items.Count; ++ix)
                    if (e.Index != ix) tasksListBox.SetItemChecked(ix, false);
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Check a task which you want to complete.");
            }
            else
            {

                var results = databaseHandlerTasks.getTasksData();

                foreach (var item in results)
                {

                    var split = tasksListBox.CheckedItems[0].ToString().Split(' ');
                    if (item.name == split[0] && item.time.ToString("dd.MM.yyyy, HH:mm") == (split[2] + ' ' + split[3]))
                    {
                        databaseHandlerTasks.updateTask(item.taskId);
                    }

                }

                showTasks();

            }
        }
    }
}
