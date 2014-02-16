using System;
using System.Windows.Forms;
using RPG.Account;

namespace RPGGame
{
    public partial class LoginScreen : Form
    {
        private const string empty = "Please, enter a username.";
        private const string taken = "There is already a user with this username.";

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                MessageBox.Show(empty);
            }


            // TODO Check existing usernames

            Player player = new Player(usernameBox.Text);
           this.Close();
        }
    }
}
