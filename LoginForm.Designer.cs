
namespace Assignment4c_
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1Email = new TextBox();
            textBox2Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1Login = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1Email
            // 
            textBox1Email.Location = new Point(239, 79);
            textBox1Email.Name = "textBox1Email";
            textBox1Email.Size = new Size(350, 39);
            textBox1Email.TabIndex = 0;
            // 
            // textBox2Password
            // 
            textBox2Password.Location = new Point(239, 192);
            textBox2Password.Name = "textBox2Password";
            textBox2Password.Size = new Size(350, 39);
            textBox2Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 2;
            label1.Text = "EMAIL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 195);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD :";
            // 
            // button1Login
            // 
            button1Login.Location = new Point(674, 535);
            button1Login.Name = "button1Login";
            button1Login.Size = new Size(391, 108);
            button1Login.TabIndex = 4;
            button1Login.Text = "  LOGIN";
            button1Login.UseVisualStyleBackColor = true;
            button1Login.Click += button1Login_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2Password);
            groupBox1.Controls.Add(textBox1Email);
            groupBox1.Location = new Point(60, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 420);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREDENTIAL DETAILS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 701);
            Controls.Add(groupBox1);
            Controls.Add(button1Login);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TextBox textBox1Email;
        private TextBox textBox2Password;
        private Label label1;
        private Label label2;
        private Button button1Login;
        private GroupBox groupBox1;
    }
}
