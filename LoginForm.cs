using Assignment4c_.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace Assignment4c_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1Login_Click(object sender, EventArgs e)
        {
            string email = textBox1Email.Text;
            string password = textBox2Password.Text;

            //email - Humber123@gmail.com and password - Password
            

            // Check if the user exists in the database
            // If the user exists, open the AccountDetailsForm
            // If the user does not exist, show an error message
            // If the user exists, but the password is incorrect, show an error message
            using (var dbContext = new MMABooksContext())
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Login successful.");
                  //open the AccountDetailsForm
                  //open the transaction form
                    TransactionForm2 form2 = new TransactionForm2();
                    AccountDetailsForm form1 = new AccountDetailsForm(form2);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This method could be used for initialization
        }
    }
}
