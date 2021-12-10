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
    public partial class MainForm : Form
    {
        public string Username { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataGrid(string username)
        {
            dataGridViewInfo.Rows.Clear();
            foreach (UserPasswordInfo upi in Database.GetPasswordInfo())
            {
                if (upi.Owner == username)
                {
                    Console.WriteLine("Here");
                    dataGridViewInfo.Rows.Add(upi.Title, upi.Username, upi.Password, upi.DateCreated, upi.DateLastViewed, upi.Note);
                }
            }

        }

        public void LabelViewing(string username)
        {
            labelViewingUser.Text = username;
        }

        // Will generate a random number and depending on the user's choice of added keys will add that key to the password
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!checkBoxLowercase.Checked && !checkBoxNumbers.Checked && !checkBoxSpecialKeys.Checked && !checkBoxUppercase.Checked)
            {
                MessageBox.Show("Please select at least one property");
                return;
            }
            if (Convert.ToInt32(textBoxLength.Text) < 1)
            {
                MessageBox.Show("Enter a length greater than 1");
                return;
            }

            Random r = new Random();
            string password = "";
            for (int i = 0; i < Convert.ToInt32(textBoxLength.Text); i++)
            {
                int rand = r.Next(1, 5);

                switch (rand)
                {
                    case 1:
                        {
                            if (checkBoxLowercase.Checked)
                            {
                                password += GetLetter("lowercase", r.Next(0, 26));
                                break;
                            }
                            else
                            {
                                i -= 1;
                                break;
                            }
                        }
                    case 2:
                        {
                            if (checkBoxUppercase.Checked)
                            {
                                password += GetLetter("uppercase", r.Next(0, 26));
                                break;
                            }
                            else
                            {
                                i -= 1;
                                break;
                            }
                        }
                    case 3:
                        {
                            if (checkBoxNumbers.Checked)
                            {
                                password += r.Next(0, 9).ToString();
                                break;
                            }
                            else
                            {
                                i -= 1;
                                break;
                            }
                        }
                    case 4:
                        {
                            if (checkBoxSpecialKeys.Checked)
                            {
                                password += GetSpecialKey(r.Next(0, 31));
                                break;
                            }
                            else
                            {
                                i -= 1;
                                break;
                            }
                        }

                }
                
            }

            textBoxPassword.Text = password;

        }

        // Returns a random letter uppercase or lowercase
        public static char GetLetter(string type, int rand)
        {
            string chars;
            if (type == "uppercase")
            {
                chars = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            }
            else
            {
                chars = "abcdefghijklmnopqrstuvwxyz";
            }
            return chars[rand];
        }

        // Returns a random special key
        public static char GetSpecialKey(int num)
        {
            string chars = "~`!@#$%^&*()-_=+{[}]|\\:;\"'<,>.?/'";
            return chars[num];
        }

        // Saves the users info to the database
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("You need a title and password");
            }
            else
            {
                UserPasswordInfo upi = new UserPasswordInfo();
                upi.Title = textBoxTitle.Text;
                upi.Username = textBoxUsername.Text;
                upi.Password = textBoxPassword.Text;
                upi.DateCreated = DateTime.Now.ToString("M/d/yyyy");
                upi.DateLastViewed = DateTime.Now.ToString("M/d/yyyy");              // Will need method that tracks when a user logs into an account, then saves it to db under their username
                upi.Note = textBoxNote.Text;
                upi.Owner = Username;
                Database.SavePasswordInfo(upi);

                // Clears the textboxes
                textBoxNote.Text = "";
                textBoxPassword.Text = "";
                textBoxTitle.Text = "";
                textBoxUsername.Text = "";

                // Loads the datagrid
                LoadDataGrid(this.Username);

            }

        }

        // Will set the password length textbox to the trackbar's value
        private void trackBarPasswordLength_Scroll(object sender, EventArgs e)
        {
            textBoxLength.Text = trackBarPasswordLength.Value.ToString();
        }
        
        public void PostPastebin()
        {
            string Cmdtext = @"curl -X POST -d 'api_dev_key = GiC4c4DVEoTWBqYOhxhLD8KHdz7ReDVd' -d 'api_paste_code = test' -d 'api_option = paste' 'https://pastebin.com/api/api_post.php'";
            System.Diagnostics.Process.Start("CMD.exe", Cmdtext);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
