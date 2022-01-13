using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyLibrary
{
    public partial class Login : Form
    {
        private XElement usersAndPasswords;

        public event EventHandler UserLoggedIn;
        public Login()
        {
            InitializeComponent();
            var filename = "korisnici.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var usernameAndPasswordsFilepath = Path.Combine(currentDirectory, filename);

            usersAndPasswords = XElement.Load(usernameAndPasswordsFilepath);
        }

        private bool UserIsValid()
        {
            var username = this.textBoxUsername.Text;
            var password = this.textBoxPassword.Text;

            var users = usersAndPasswords.Elements().Select(el => new
                { username = (string)el.Element("korisnickoIme"), password = (string)el.Element("lozinka") });

            if (!users.Any(user => user.username.Equals(username)))
                return false;

            return users.Where(user => string.Compare(user.username, username, true) == 0 && string.Compare(user.password, password, true) == 0).Any();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserIsValid())
            {
                this.Close();
                UserLoggedIn?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(this, "Invalid username or password", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
