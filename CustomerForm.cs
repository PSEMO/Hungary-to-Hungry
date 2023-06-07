using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Hungary_for_hungry
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show selected restaurants menu on the MenuPanel
            //do it by creating listbox within that panel
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            //Add selected products from "created listbox" to a listbox that is in CartPanel
        }

        //Remove button
        private void button2_Click(object sender, EventArgs e)
        {
            //Remove from the last listbox
        }
    }
}
