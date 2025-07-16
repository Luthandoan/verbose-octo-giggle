using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GymS1
{
    public partial class LoginForm : Form
    {
        private int failedAttempts = 0;
        private const int MAX_FAILED_ATTEMPTS = 3;
        public LoginForm()
        {

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsValidLogin(username, password))
            {
                // Open the main application form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                failedAttempts++;
                MessageBox.Show("Invalid username or password. Attempts left: " + (MAX_FAILED_ATTEMPTS - failedAttempts));

                if (failedAttempts >= MAX_FAILED_ATTEMPTS)
                {
                    // Lock the account
                    MessageBox.Show("Your account has been locked. Please contact the admin to unlock it.");
                    // Disable the login controls
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    btnLogin.Enabled = true;
                }
            }

        }

        private bool IsValidLogin(string username, string password)
        {
            var credentials = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines("Information.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    credentials[parts[0]] = parts[1];
                }
            }

            return credentials.TryGetValue(username, out string storedPassword) && storedPassword == password;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
