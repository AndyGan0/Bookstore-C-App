
namespace Bookstore
{
    partial class MainMenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainName = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.help_button = new System.Windows.Forms.Button();
            this.messags_Button = new System.Windows.Forms.Button();
            this.CartButon = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(17, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 727);
            this.panel1.TabIndex = 0;
            // 
            // MainName
            // 
            this.MainName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainName.AutoSize = true;
            this.MainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainName.ForeColor = System.Drawing.Color.IndianRed;
            this.MainName.Location = new System.Drawing.Point(340, 17);
            this.MainName.Name = "MainName";
            this.MainName.Size = new System.Drawing.Size(343, 55);
            this.MainName.TabIndex = 5;
            this.MainName.Text = "ΒΙΒΛΙΟΦΑΓΟΙ";
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackgroundImage = global::Bookstore.Properties.Resources.user;
            this.pictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_user.Image = global::Bookstore.Properties.Resources.user;
            this.pictureBox_user.Location = new System.Drawing.Point(17, 9);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(49, 50);
            this.pictureBox_user.TabIndex = 7;
            this.pictureBox_user.TabStop = false;
            // 
            // help_button
            // 
            this.help_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.help_button.BackgroundImage = global::Bookstore.Properties.Resources.help_icon;
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(947, 1);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(53, 62);
            this.help_button.TabIndex = 6;
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // messags_Button
            // 
            this.messags_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.messags_Button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.messags_Button.BackgroundImage = global::Bookstore.Properties.Resources.MessageIcon;
            this.messags_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.messags_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messags_Button.Location = new System.Drawing.Point(819, 1);
            this.messags_Button.Margin = new System.Windows.Forms.Padding(2);
            this.messags_Button.Name = "messags_Button";
            this.messags_Button.Size = new System.Drawing.Size(60, 62);
            this.messags_Button.TabIndex = 3;
            this.messags_Button.UseVisualStyleBackColor = false;
            this.messags_Button.Click += new System.EventHandler(this.messages_Button_Click);
            // 
            // CartButon
            // 
            this.CartButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartButon.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CartButon.BackgroundImage = global::Bookstore.Properties.Resources.CartButton;
            this.CartButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CartButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButon.Location = new System.Drawing.Point(890, 1);
            this.CartButon.Margin = new System.Windows.Forms.Padding(2);
            this.CartButon.Name = "CartButon";
            this.CartButon.Size = new System.Drawing.Size(48, 62);
            this.CartButon.TabIndex = 2;
            this.CartButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CartButon.UseVisualStyleBackColor = false;
            this.CartButon.Click += new System.EventHandler(this.CartButon_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Back_button.BackgroundImage = global::Bookstore.Properties.Resources.BackIcon;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(-44, 15);
            this.Back_button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(187, 44);
            this.Back_button.TabIndex = 1;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Visible = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(83, 23);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 24);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "label1";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1041, 804);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.messags_Button);
            this.Controls.Add(this.CartButon);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainName);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookstore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button CartButon;
        private System.Windows.Forms.Button messags_Button;
        private System.Windows.Forms.Label MainName;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_name;
    }
}

