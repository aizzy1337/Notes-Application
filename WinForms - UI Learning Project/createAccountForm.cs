using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___UI_Learning_Project
{
    public partial class createAccountForm : Form
    {

        bool validUsername = false;
        bool validPassword = false;
        bool validRepeatPassword = false;

        public createAccountForm()
        {
            InitializeComponent();
        }

        private void closeButtonRegisterPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButtonRegisterPanel_Click(object sender, EventArgs e)
        {

        }

        private void createAccountRegisterButton_Click(object sender, EventArgs e)
        {
            if(validUsername && validPassword && validRepeatPassword)
            {
                MessageBox.Show("Pomyślnie utworzono konto!");
                database.uploadData(usernameRegisterText.Text, passwordRegisterText.Text);
                this.Close();
            }
        }

        private void usernameRegisterText_Click(object sender, EventArgs e)
        {
            usernameRegisterText.BackColor = Color.Tomato;
            usernameRegisterText.ForeColor = Color.White;
        }

        private void usernameRegisterText_TextChanged(object sender, EventArgs e)
        {
            int validFlag = 0;
            validUsername = false;

            usernameRegisterText.BackColor = Color.Tomato;

            if (usernameRegisterText.Text.Length < 5)
            {
                validUsernameLabel.ForeColor = Color.Tomato;
                validUsernameLabel.Text = "Nazwa użytkownika: Długość tekstu mniejsza niż 5";
            }
            else validFlag++;

            if (Regex.IsMatch(usernameRegisterText.Text, @"^\d"))
            {
                validUsernameLabel.ForeColor = Color.Tomato;
                validUsernameLabel.Text = "Nazwa użytkownika: Powinna się zaczynać od litery";
            }
            else validFlag++;

            if (Regex.IsMatch(usernameRegisterText.Text, @"^[0-9]+$"))
            {
                validUsernameLabel.ForeColor = Color.Tomato;
                validUsernameLabel.Text = "Nazwa użytkownika: Przynajmniej jedna litera";
            }
            else validFlag++;

            if (usernameRegisterText.Text.Length == 0)
            {
                validUsernameLabel.ForeColor = Color.Tomato;
                validUsernameLabel.Text = "Nazwa użytkownika: Długość tekstu (0)";
            }
            else validFlag++;

            if (validFlag == 4)
            {
                validUsername = true;
                usernameRegisterText.BackColor = Color.Green;
                validUsernameLabel.ForeColor = Color.Green;
                validUsernameLabel.Text = "Nazwa użytkownika: Poprawna";
            }

        }

        private void passwordRegisterText_Click(object sender, EventArgs e)
        {
            passwordRegisterText.BackColor = Color.Tomato;
            passwordRegisterText.ForeColor = Color.White;
        }

        private void passwordRegisterText_TextChanged(object sender, EventArgs e)
        {
            int validFlag = 0;
            validPassword = false;

            passwordRegisterText.BackColor = Color.Tomato;

            int specialCharacterFlag = 0;
            for (int i = 0; i < passwordRegisterText.TextLength; i++)
            {
                if (!Char.IsLetterOrDigit(passwordRegisterText.Text[i]))
                {
                    specialCharacterFlag++;
                }
            }

            if (specialCharacterFlag == 0)
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Przynajmniej jeden znak specjalny";
            }
            else validFlag++;

            if (passwordRegisterText.Text.Length < 8)
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Długość hasła mniejsza niż 8";
            }
            else validFlag++;

            if (!passwordRegisterText.Text.Any(char.IsDigit))
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Przynajmniej jedna cyfra";
            }
            else validFlag++;

            if (!passwordRegisterText.Text.Any(char.IsUpper))
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Przynajmniej jedna duża litera";
            }
            else validFlag++;

            if (!passwordRegisterText.Text.Any(char.IsLower))
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Przynajmniej jedna mała litera";
            }
            else validFlag++;

            if (passwordRegisterText.Text.Length == 0)
            {
                validPasswordLabel.ForeColor = Color.Tomato;
                validPasswordLabel.Text = "Hasło: Długość tekstu (0)";
            }
            else validFlag++;

            if (validFlag == 6)
            {
                validPassword = true;
                passwordRegisterText.BackColor = Color.Green;
                validPasswordLabel.ForeColor = Color.Green;
                validPasswordLabel.Text = "Hasło: Poprawne";
            }
        }

        private void passwordRepeatText_TextChanged(object sender, EventArgs e)
        {
            validRepeatPassword = false;

            if(passwordRegisterText.Text == passwordRepeatText.Text)
            {
                validRepeatPassword = true;
                passwordRepeatText.BackColor = Color.Green;
                validRepeatLabel.ForeColor = Color.Green;
                validRepeatLabel.Text = "Hasło powtórzone: Tak";
            }
            else
            {
                passwordRepeatText.BackColor = Color.Tomato;
                validRepeatLabel.ForeColor = Color.Tomato;
                validRepeatLabel.Text = "Hasło powtórzone: Nie";
            }
        }

        private void passwordRepeatText_Click(object sender, EventArgs e)
        {
            passwordRepeatText.BackColor = Color.Tomato;
            passwordRepeatText.ForeColor = Color.White;
        }
    }
}
