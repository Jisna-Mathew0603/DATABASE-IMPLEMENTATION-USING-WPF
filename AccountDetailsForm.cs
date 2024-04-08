using Assignment4c_.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment4c_
{
    public partial class AccountDetailsForm : Form
        // This form displays the account details and
        // allows the user to view the transaction history for a selected account.
    {
        private TransactionForm2 transactionForm2;
        private MMABooksContext dbContext;

        // Constructor
        public AccountDetailsForm(TransactionForm2 transactionForm2)
        {
            InitializeComponent();
            this.transactionForm2 = transactionForm2; // Assign the transactionForm2 object to the private variable
            dbContext = new MMABooksContext();// Create a new instance of the MMABooksContext class
        }

        // Load event handler
        private void AccountForm_Load(object sender, EventArgs e)
        {
            // Load the account details into the DataGridView
            
            try
            {
                var accounts = dbContext.Accounts.ToList();
                dataGridViewAccountDetails.DataSource = accounts;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            // If a row is selected, get the AccountId value from the selected row
            // Check if a transaction exists for the selected account
            // If a transaction exists, open the TransactionForm2 form
            // If no transaction exists, show a message box
            // If no row is selected, show a message box
            
            if (dataGridViewAccountDetails.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAccountDetails.SelectedRows[0];
                int accountId = Convert.ToInt32(selectedRow.Cells["AccountId"].Value);

                var transactionExists = dbContext.TransactionHistories.Any(t => t.AccountId == accountId);
                if (transactionExists)
                {
                    TransactionForm2 form2 = new TransactionForm2();
                    form2.transactionhistory(accountId); // Pass accountId to transactionhistory method
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No transactions found for the selected account.");
                }
            }
            else
            {
                MessageBox.Show("Please select an account.");
            }
        }

        // Button click event handler

        private void button2exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
