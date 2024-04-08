using Assignment4c_.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment4c_
{
    public partial class TransactionForm2 : Form
    {
        // Declare private variables
        
        private DateTime transactionDate;
        private decimal amount;
        private string description;
        private int accountId;

        // Constructor
        public TransactionForm2()
        {
            InitializeComponent();
        }

        // Load event handler
        private void TransactionForm2_Load(object sender, EventArgs e)
        {

        }
        // Method to display transaction history
        // This method retrieves the transaction history for a selected account
        // and displays the transactions in the DataGridView     
       
        public void transactionhistory(int accountId)
        {
            // Retrieve the transactions for the selected account
            try
            {
                var dbContext = new MMABooksContext();
                textBox1accid.Text = accountId.ToString();
                

                List<TransactionHistory> transactiondetails = dbContext.TransactionHistories
                    .Where(a => a.AccountId == accountId)
                    .ToList();

                dataGridView1.DataSource = transactiondetails;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Button click event handler FOR ADD
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2transactiondate.Text) || string.IsNullOrEmpty(textBox3amount.Text) ||
                string.IsNullOrEmpty(textBox4description.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            transactionDate = DateTime.Parse(textBox2transactiondate.Text);
            amount = Convert.ToDecimal(textBox3amount.Text);
            description = textBox4description.Text;
            accountId = int.Parse(textBox1accid.Text);

            using (var dbContext = new MMABooksContext())
            {
                // Create a new transaction object
                var newTransaction = new TransactionHistory
                {
                    AccountId = accountId,
                    TransactionDate = transactionDate,
                    Amount = amount,
                    Description = description
                };

                // Add the new transaction to the database
                dbContext.TransactionHistories.Add(newTransaction);
                dbContext.SaveChanges();

                // Refresh transaction history view
                transactionhistory(accountId);
              MessageBox.Show("Transaction added successfully.");
            }
        }

        // Button click event handler FOR UPDATE
        private void button3update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int transactionId = Convert.ToInt32(selectedRow.Cells["TransactionId"].Value);

            // Extract values from input fields
            transactionDate = DateTime.Parse(textBox2transactiondate.Text);
            amount = Convert.ToDecimal(textBox3amount.Text);
            description = textBox4description.Text;

            using (var dbContext = new MMABooksContext())
            {
                // Find the transaction to update
                var transactionToUpdate = dbContext.TransactionHistories.Find(transactionId);
                if (transactionToUpdate != null)
                {
                    // Update transaction properties
                    transactionToUpdate.TransactionDate = transactionDate;
                    transactionToUpdate.Amount = amount;
                    transactionToUpdate.Description = description;

                    dbContext.SaveChanges();

                    // Refresh transaction history view
                    transactionhistory(accountId);
                    MessageBox.Show("Transaction updated successfully.");
                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }
            }

        }

        // Button click event handler FOR DELETE
        private void button2delete_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MMABooksContext())
            {
                accountId = int.Parse(textBox1accid.Text);
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int transactionId = Convert.ToInt32(selectedRow.Cells["TransactionId"].Value);
                    var transaction = dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
                    if (transaction != null)
                    {
                        // Remove the transaction from the DbSet
                        dbContext.TransactionHistories.Remove(transaction);
                        dbContext.SaveChanges();
                        List<TransactionHistory> accountTransactions = dbContext.TransactionHistories
                                .Where(t => t.AccountId == accountId)
                                .ToList();

                        //credit this amount from main balance
                        var currentBalance = (from a in dbContext.Accounts
                                              join t in dbContext.TransactionHistories
                                              on a.AccountId equals t.AccountId
                                              where t.AccountId == accountId
                                              select a.CurrentBalance).FirstOrDefault();
                        Console.WriteLine(currentBalance);
                        decimal newBalance = (decimal)currentBalance + amount;
                        //update the balance in the account table
                        var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == accountId);
                        if (account != null)
                        {
                            account.CurrentBalance = (double)newBalance;
                            dbContext.SaveChanges();
                        }

                        // Bind the list of transactions to the DataGridView
                        dataGridView1.DataSource = accountTransactions;
                        MessageBox.Show("Transaction deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Transaction not found.");
                    }
                }
                else
                {
                   MessageBox.Show("Please select a transaction to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
