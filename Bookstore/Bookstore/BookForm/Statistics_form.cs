using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.BookForm
{
    public partial class Statistics_form : Form
    {
        List<DateTime> Purchases_dates = new List<DateTime>();


        public Statistics_form(int Book_id)
        {
            InitializeComponent();
            Purchases_dates = Database.returnDatesOfBookPurchases(Book_id);

            if (Purchases_dates.Count == 0)
            {
                chart1.Hide();
                chart2.Hide();
                overall_critiques_label.Hide();
                no_purchases_label.Show();
                return;
            }

            //  Making the chart for the purchases
            SortedDictionary<DateTime, int> number_of_purchases_each_day = new SortedDictionary<DateTime, int>();
            foreach ( DateTime d in Purchases_dates) {
                if ( ! number_of_purchases_each_day.ContainsKey(d) )
                {
                    number_of_purchases_each_day.Add(d, 1);
                }
                else
                {
                    number_of_purchases_each_day[d] += 1;
                }
                chart1.Series["purchases"].Points.AddXY(d, number_of_purchases_each_day[d]);
            }

            


            //  Making the chart for likes
            List<Classes.Critique> critiques = Database.retrieveCritiquesForBook(Book_id);

            if (critiques.Count == 0)
            {
                chart2.Hide();
                overall_critiques_label.Hide();
                no_comments_label.Show();
                return;
            }

            overall_critiques_label.Text += critiques.Count;

            SortedDictionary<int, int> stars_count = new SortedDictionary<int, int>();
            stars_count.Add(0, 0);
            stars_count.Add(1, 0);
            stars_count.Add(2, 0);
            stars_count.Add(3, 0);
            stars_count.Add(4, 0);
            stars_count.Add(5, 0);

            foreach (Classes.Critique c in critiques)
            {
                stars_count[c.Stars] += 1;
            }


            chart2.Series["Score"].Points.Clear();
            for (int i=0; i<=5; i++ )
            {
                chart2.Series["Score"].Points.AddXY(i,stars_count[i]);                
            }







        }




    }
}
