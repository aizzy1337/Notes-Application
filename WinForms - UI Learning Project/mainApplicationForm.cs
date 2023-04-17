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
        }
    }
}
