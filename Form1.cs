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
    public partial class Form1 : Form
    {
        public Form1()
        {
            MainForm m = new MainForm();
            m.PostPastebin();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Submits users information
        private void button1Submit_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Boy yo stupid", "Bruh");
            }
            else
            {
                bool correct = false;
                try
                {
                    // Loops through each user in the database to see if the password they entered is correct
                    List<User> users = Database.GetUsers();
                    foreach (User user in users)
                    {
                        if (user.Username == textBoxUsername.Text)
                        {
                            if (user.Password == textBoxPassword.Text)
                            {
                                MainForm mfrm = new MainForm();
                                mfrm.Username = user.Username;
                                this.Hide();
                                mfrm.LoadDataGrid(user.Username);
                                mfrm.LabelViewing(user.Username);
                                mfrm.Show();
                                correct = true;
                            }
                        }
                    }
                    if (!correct)
                    {
                        MessageBox.Show("Try again", "Incorret");
                    }
                }
                // Will catch if the database is empty
                catch
                {
                    MessageBox.Show("Please register an account first");
                }
            }

        }
        // Opens a create an account form
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm caf = new CreateAccountForm();
            caf.Show();
        }
    }
}
