namespace Assignment4c_
{
    partial class TransactionForm2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1accid = new TextBox();
            textBox2transactiondate = new TextBox();
            textBox3amount = new TextBox();
            textBox4description = new TextBox();
            dataGridView1 = new DataGridView();
            button1add = new Button();
            button2delete = new Button();
            button3update = new Button();
            button4exit = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 59);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "ACCOUNT ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 141);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 1;
            label2.Text = "TRANSACTION DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 231);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "AMOUNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 323);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 3;
            label4.Text = "DESCRIPTION";
            // 
            // textBox1accid
            // 
            textBox1accid.Location = new Point(280, 52);
            textBox1accid.Name = "textBox1accid";
            textBox1accid.Size = new Size(219, 39);
            textBox1accid.TabIndex = 4;
            // 
            // textBox2transactiondate
            // 
            textBox2transactiondate.Location = new Point(280, 141);
            textBox2transactiondate.Name = "textBox2transactiondate";
            textBox2transactiondate.Size = new Size(219, 39);
            textBox2transactiondate.TabIndex = 5;
            // 
            // textBox3amount
            // 
            textBox3amount.Location = new Point(280, 228);
            textBox3amount.Name = "textBox3amount";
            textBox3amount.Size = new Size(219, 39);
            textBox3amount.TabIndex = 6;
            // 
            // textBox4description
            // 
            textBox4description.Location = new Point(280, 323);
            textBox4description.Name = "textBox4description";
            textBox4description.Size = new Size(219, 39);
            textBox4description.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(592, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1496, 534);
            dataGridView1.TabIndex = 8;
            // 
            // button1add
            // 
            button1add.Location = new Point(30, 701);
            button1add.Name = "button1add";
            button1add.Size = new Size(353, 82);
            button1add.TabIndex = 9;
            button1add.Text = "ADD";
            button1add.UseVisualStyleBackColor = true;
            button1add.Click += button1_Click;
            // 
            // button2delete
            // 
            button2delete.Location = new Point(944, 701);
            button2delete.Name = "button2delete";
            button2delete.Size = new Size(347, 82);
            button2delete.TabIndex = 10;
            button2delete.Text = "DELETE";
            button2delete.UseVisualStyleBackColor = true;
            button2delete.Click += button2delete_Click;
            // 
            // button3update
            // 
            button3update.Location = new Point(523, 701);
            button3update.Name = "button3update";
            button3update.Size = new Size(304, 82);
            button3update.TabIndex = 11;
            button3update.Text = "UPDATE";
            button3update.UseVisualStyleBackColor = true;
            button3update.Click += button3update_Click;
            // 
            // button4exit
            // 
            button4exit.Location = new Point(1811, 628);
            button4exit.Name = "button4exit";
            button4exit.Size = new Size(257, 82);
            button4exit.TabIndex = 12;
            button4exit.Text = "&EXIT";
            button4exit.UseVisualStyleBackColor = true;
            button4exit.Click += button4exit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1accid);
            groupBox1.Controls.Add(textBox2transactiondate);
            groupBox1.Controls.Add(textBox4description);
            groupBox1.Controls.Add(textBox3amount);
            groupBox1.Location = new Point(24, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 407);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction";
            // 
            // TransactionForm2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2142, 1013);
            Controls.Add(groupBox1);
            Controls.Add(button4exit);
            Controls.Add(button3update);
            Controls.Add(button2delete);
            Controls.Add(button1add);
            Controls.Add(dataGridView1);
            Name = "TransactionForm2";
            Text = "TransactionForm2";
            Load += TransactionForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1accid;
        private TextBox textBox2transactiondate;
        private TextBox textBox3amount;
        private TextBox textBox4description;
        private DataGridView dataGridView1;
        private Button button1add;
        private Button button2delete;
        private Button button3update;
        private Button button4exit;
        private GroupBox groupBox1;
    }
}