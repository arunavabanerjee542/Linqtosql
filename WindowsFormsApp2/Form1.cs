using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        RestaurantDBDataContext dc;

        List<Restaurant> l;

        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* RestaurantDBDataContext dc = new RestaurantDBDataContext();
             dataGridView1.DataSource = dc.Restaurants; */

            dc = new RestaurantDBDataContext();

            l = dc.Restaurants.ToList();

            disp();

        }


        public void disp()
        {
            idbox.Text = l[index].Id.ToString();
            roombox.Text = l[index].rooms.ToString();
            namebox.Text = l[index].name.ToString();
            citybox.Text = l[index].city.ToString();



        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index< l.Count()-1)
            {
                index++;
                disp();
            }

            else
            {
                MessageBox.Show(" No More Records ");
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (index > 0)
            {
                index--;
                disp();
            }

            else
            {
                MessageBox.Show(" No Previous Records ");
            }




        }
    }
}
