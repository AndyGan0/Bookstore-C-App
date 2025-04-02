
namespace Bookstore.BookForm
{
    partial class QuestionForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(898, 320);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.submit.Location = new System.Drawing.Point(951, 627);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(220, 72);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit Question";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AuthorLabel.Location = new System.Drawing.Point(267, 117);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(90, 32);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Προς:";
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BookLabel.Location = new System.Drawing.Point(267, 177);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(277, 32);
            this.BookLabel.TabIndex = 2;
            this.BookLabel.Text = "Σχετικά με το βιβλίο:";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1459, 937);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label BookLabel;
    }
}