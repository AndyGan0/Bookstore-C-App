
namespace Bookstore
{
    partial class Start_up_Form
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
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.Location = new System.Drawing.Point(229, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Καλώς Ορίσατε!";
            // 
            // register_button
            // 
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.Location = new System.Drawing.Point(292, 218);
            this.register_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(211, 50);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Εγγραφή";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Location = new System.Drawing.Point(292, 289);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(211, 50);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Σύνδεση";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Start_up_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(793, 525);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Start_up_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
    }
}