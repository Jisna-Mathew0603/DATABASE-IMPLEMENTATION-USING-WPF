namespace Assignment4c_
{
    partial class AccountDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAccountDetails = new DataGridView();
            button1 = new Button();
            button2exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountDetails).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAccountDetails
            // 
            dataGridViewAccountDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccountDetails.Location = new Point(28, 57);
            dataGridViewAccountDetails.Name = "dataGridViewAccountDetails";
            dataGridViewAccountDetails.RowHeadersWidth = 82;
            dataGridViewAccountDetails.Size = new Size(1646, 489);
            dataGridViewAccountDetails.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(676, 613);
            button1.Name = "button1";
            button1.Size = new Size(413, 74);
            button1.TabIndex = 4;
            button1.Text = "TRANSACTION HISTORY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2exit
            // 
            button2exit.Location = new Point(1446, 636);
            button2exit.Name = "button2exit";
            button2exit.Size = new Size(343, 156);
            button2exit.TabIndex = 5;
            button2exit.Text = "&EXIT";
            button2exit.UseVisualStyleBackColor = true;
            button2exit.Click += button2exit_Click;
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 837);
            Controls.Add(button2exit);
            Controls.Add(button1);
            Controls.Add(dataGridViewAccountDetails);
            Name = "AccountDetailsForm";
            Text = "AccountForm";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewAccountDetails;
        private Button button1;
        private Button button2exit;
    }
}