
namespace Bookstore
{
    partial class CartForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNoCartItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Complete_purchase_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.labelNoCartItems);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(81, 92);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(841, 358);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // labelNoCartItems
            // 
            this.labelNoCartItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNoCartItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelNoCartItems.Location = new System.Drawing.Point(2, 0);
            this.labelNoCartItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoCartItems.Name = "labelNoCartItems";
            this.labelNoCartItems.Size = new System.Drawing.Size(807, 200);
            this.labelNoCartItems.TabIndex = 0;
            this.labelNoCartItems.Text = "          Το καλάθι σας είναι άδειο!";
            this.labelNoCartItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(81, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 44);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(552, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Τίτλος";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(552, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(253, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Τιμή";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Location = new System.Drawing.Point(81, 477);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 44);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "          Σύνολο:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PriceLabel.Location = new System.Drawing.Point(592, 0);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(215, 42);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Χ";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Complete_purchase_button
            // 
            this.Complete_purchase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Complete_purchase_button.AutoSize = true;
            this.Complete_purchase_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Complete_purchase_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Complete_purchase_button.Location = new System.Drawing.Point(656, 546);
            this.Complete_purchase_button.Margin = new System.Windows.Forms.Padding(2);
            this.Complete_purchase_button.MinimumSize = new System.Drawing.Size(234, 47);
            this.Complete_purchase_button.Name = "Complete_purchase_button";
            this.Complete_purchase_button.Size = new System.Drawing.Size(234, 47);
            this.Complete_purchase_button.TabIndex = 3;
            this.Complete_purchase_button.Text = "Ολοκλήρωση Παραγγελίας";
            this.Complete_purchase_button.UseVisualStyleBackColor = true;
            this.Complete_purchase_button.Click += new System.EventHandler(this.complete_purchase_button_click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(979, 696);
            this.Controls.Add(this.Complete_purchase_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(995, 735);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button Complete_purchase_button;
        private System.Windows.Forms.Label labelNoCartItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}