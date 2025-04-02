
namespace Bookstore
{
    partial class Register_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_password_confirm = new System.Windows.Forms.TextBox();
            this.radioButton_customer = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_Author = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Εγγραφή";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_name.Location = new System.Drawing.Point(268, 143);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(199, 29);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TabStop = false;
            // 
            // register_button
            // 
            this.register_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.register_button.Location = new System.Drawing.Point(201, 548);
            this.register_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(150, 38);
            this.register_button.TabIndex = 9;
            this.register_button.TabStop = false;
            this.register_button.Text = "Εγγραφή";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(147, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Όνομα:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(128, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Επώνυμο:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(123, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_surname.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_surname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_surname.Location = new System.Drawing.Point(268, 186);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(199, 29);
            this.textBox_surname.TabIndex = 2;
            this.textBox_surname.TabStop = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_username.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_username.Location = new System.Drawing.Point(268, 233);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(199, 29);
            this.textBox_username.TabIndex = 3;
            this.textBox_username.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(153, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_email.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_email.Location = new System.Drawing.Point(268, 279);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(199, 29);
            this.textBox_email.TabIndex = 4;
            this.textBox_email.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(135, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Κωδικός:";
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_password.Location = new System.Drawing.Point(268, 320);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(199, 29);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(46, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Επαλήθευση Κωδικού:";
            // 
            // textBox_password_confirm
            // 
            this.textBox_password_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password_confirm.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_password_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password_confirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_password_confirm.Location = new System.Drawing.Point(268, 359);
            this.textBox_password_confirm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_password_confirm.Name = "textBox_password_confirm";
            this.textBox_password_confirm.PasswordChar = '*';
            this.textBox_password_confirm.Size = new System.Drawing.Size(199, 29);
            this.textBox_password_confirm.TabIndex = 6;
            this.textBox_password_confirm.TabStop = false;
            // 
            // radioButton_customer
            // 
            this.radioButton_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_customer.AutoSize = true;
            this.radioButton_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_customer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButton_customer.Location = new System.Drawing.Point(268, 409);
            this.radioButton_customer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton_customer.Name = "radioButton_customer";
            this.radioButton_customer.Size = new System.Drawing.Size(84, 24);
            this.radioButton_customer.TabIndex = 7;
            this.radioButton_customer.Text = "Πελάτης";
            this.radioButton_customer.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(150, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ρόλος:";
            // 
            // radioButton_Author
            // 
            this.radioButton_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Author.AutoSize = true;
            this.radioButton_Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Author.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButton_Author.Location = new System.Drawing.Point(268, 435);
            this.radioButton_Author.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton_Author.Name = "radioButton_Author";
            this.radioButton_Author.Size = new System.Drawing.Size(110, 24);
            this.radioButton_Author.TabIndex = 8;
            this.radioButton_Author.Text = "Συγγραφέας";
            this.radioButton_Author.UseVisualStyleBackColor = true;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(554, 631);
            this.Controls.Add(this.radioButton_Author);
            this.Controls.Add(this.radioButton_customer);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.textBox_password_confirm);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1000, 670);
            this.MinimumSize = new System.Drawing.Size(570, 670);
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_password_confirm;
        private System.Windows.Forms.RadioButton radioButton_customer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton_Author;
    }
}