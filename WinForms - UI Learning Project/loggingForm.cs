namespace WinForms___UI_Learning_Project
{
    public partial class loggingForm : Form
    {

        private createAccountForm _createAccountForm;
        private mainApplicationForm _mainApplicationForm;

        public loggingForm()
        {
            InitializeComponent();
        }

        private void closeButtonLoggingPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButtonLoggingPanel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButtonLoggingPanel_MouseHover(object sender, EventArgs e)
        {
            closeButtonLoggingPanel.BackColor = Color.BlueViolet;
        }

        private void closeButtonLoggingPanel_MouseLeave(object sender, EventArgs e)
        {
            closeButtonLoggingPanel.BackColor = Color.Indigo;
        }

        private void minimizeButtonLoggingPanel_MouseHover(object sender, EventArgs e)
        {
            minimizeButtonLoggingPanel.BackColor = Color.BlueViolet;
        }

        private void minimizeButtonLoggingPanel_MouseLeave(object sender, EventArgs e)
        {
            minimizeButtonLoggingPanel.BackColor = Color.Indigo;
        }

        private void logInButton_MouseHover(object sender, EventArgs e)
        {
            logInButton.BackColor = Color.Indigo;
        }

        private void logInButton_MouseLeave(object sender, EventArgs e)
        {
            logInButton.BackColor = Color.BlueViolet;
        }

        private void createAccountButton_MouseHover(object sender, EventArgs e)
        {
            createAccountButton.BackColor = Color.Indigo;
        }

        private void createAccountButton_MouseLeave(object sender, EventArgs e)
        {
            createAccountButton.BackColor = Color.BlueViolet;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            _createAccountForm = new createAccountForm();
            _createAccountForm.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (databaseHandlerLogging.checkLoggingInformation(usernameText.Text, passwordText.Text))
            {
                _mainApplicationForm = new mainApplicationForm();
                _mainApplicationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }
    }
}
