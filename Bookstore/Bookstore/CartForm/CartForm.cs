using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class CartForm : Form
    {

        
        User LoggedUser;
        MainMenuForm mainmenu;
        // THIS LIST IS USED TO DELETE OLD RESULTS FROM CART IF USER LOOKS AT HIS CART AGAIN
        List<Panel> panels_in_cart = new List<Panel>();
        

        public CartForm(MainMenuForm mainmenu, User LoggedUser)
        {
            InitializeComponent();
            this.LoggedUser = LoggedUser;
            this.mainmenu = mainmenu;
        }



        public void refreshCart()
        {
            // Remove old items
            foreach (Panel p in panels_in_cart)
            {
                foreach (Control c in p.Controls)
                {
                    c.Dispose();
                }
                p.Dispose();
            }
            panels_in_cart.Clear();


            if (LoggedUser.cart.getCartItems().Count() == 0)
            {
                labelNoCartItems.Show();
                Complete_purchase_button.Enabled = false;
            }
            else
            {
                labelNoCartItems.Hide();
                Complete_purchase_button.Enabled = true;
            }

            int index = 0;
            Double sum = 0;
            foreach(Book b in LoggedUser.cart.getCartItems())
            {
                Panel TempPanel = new Panel();
                TempPanel.Size = panel1.Size;
                TempPanel.BorderStyle = BorderStyle.FixedSingle;
                TempPanel.AutoSize = false;
                TempPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                TempPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                flowLayoutPanel1.Controls.Add(TempPanel);

                Label TempLabel = new Label();
                TempPanel.Controls.Add(TempLabel);
                TempLabel.Text = b.Title;
                TempLabel.AutoSize = false;
                TempLabel.TextAlign = ContentAlignment.MiddleLeft;
                TempLabel.Dock = DockStyle.Fill;
                TempLabel.Font = new Font("Microsoft Sans Serif", 12);
                TempLabel.Name = b.ID.ToString();
                TempLabel.Cursor = Cursors.Hand;
                TempLabel.Click += showBook;

                Label TempLabel2 = new Label();
                TempPanel.Controls.Add(TempLabel2);
                TempLabel2.Text = b.Price + "€";
                TempLabel2.AutoSize = false;
                TempLabel2.TextAlign = ContentAlignment.MiddleCenter;
                TempLabel2.Dock = DockStyle.Right;
                TempLabel2.Size = new Size(200, 98);
                TempLabel2.Font = new Font("Microsoft Sans Serif", 12);

                sum += b.Price;
                
                // Button name will be the index of the item in the cart
                Button TempButton = new Button();
                TempButton.BackgroundImage = Properties.Resources.delete;
                TempButton.BackgroundImageLayout = ImageLayout.Zoom;
                TempButton.Click += removeItemFromCart;
                TempButton.Name = index.ToString();
                TempButton.FlatStyle = FlatStyle.Flat;
                TempButton.Cursor = Cursors.Hand;
                TempButton.BackColor = Color.MediumAquamarine;
                TempButton.Size = new Size(100, 100);
                TempButton.Dock = DockStyle.Right;
                TempPanel.Controls.Add(TempButton);

                index++;
                panels_in_cart.Add(TempPanel);
            }

            PriceLabel.Text = sum + " €";


        }

        private void showBook(object sender, EventArgs e)
        {
            String ObjectName = ((Label)sender).Name;

            mainmenu.showBook(Int32.Parse(ObjectName));
        }

        private void removeItemFromCart(object sender, EventArgs e)
        {
            // Delete button will have as a name the index of the item to delete from the cart
            int index = Int32.Parse(((Button)sender).Name);

            LoggedUser.cart.removeBook(index);
            refreshCart();

            
        }

        private void complete_purchase_button_click(object sender, EventArgs e)
        {
            Double sum = 0;
            foreach(Book b in LoggedUser.cart.getCartItems())
            {
                sum += b.Price;
            }

            if (sum == 0) return;


            
            BankSystemForm purchaseCompleteForm = new BankSystemForm(sum, this);
            purchaseCompleteForm.ShowDialog();

            

        }



        public void purchaseCompleted()
        {
            List<Book> ItemsPurchased = LoggedUser.cart.getCartItems();
            foreach (Book b in ItemsPurchased)
            {
                Database.userBoughtBook(LoggedUser.Username, b.ID);
            }
            LoggedUser.cart.clearCart();
            refreshCart();
        }


        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            labelNoCartItems.Size = new Size(panel1.Size.Width, 200);
            foreach (Panel p in panels_in_cart) {
                p.Size = new Size(panel1.Size.Width, p.Size.Height);
            }
        }
    }
}
