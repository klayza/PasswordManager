// Clayton Wieberg
// 12-9-21
// Password Manager
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        // Will create a user class with username and password and save it to the database
        private void button1Submit_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Boy yo stupid", "Bruh");
            }
            else
            {
                User user = new User();
                user.Username = textBoxUsername.Text;
                user.Password = textBoxPassword.Text;
                Database.SaveUser(user);
                this.Hide();
            }
        }
    }
}
