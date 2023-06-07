using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace From_Hungary_for_hungry
{
    public partial class RestaurantForm : Form
    {

        //defining login form
        Form1 f1 = new Form1();

        public RestaurantForm()
        {
            InitializeComponent();
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = true;
            viewMenuPnl.Visible = false;
        }

        //db connection string
        public static string dbconnection = "Data Source=DESKTOP-2EBNC0D\\SQLEXPRESS;Initial Catalog=hthDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(dbconnection);


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out!");
            //redirecting to login form
            f1.Show();
            this.Hide();
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = true;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = false;
        }

        private void viewMenuBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = true;
        }

        private void psettingsBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = true;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = false;

        }

        void updateUser(string mail, string username)
        {

            string q = "UPDATE tb_accounts SET username = @username WHERE email = @email";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                command.Parameters.AddWithValue("@email", mail);

                if (!string.IsNullOrEmpty(username))
                    command.Parameters.AddWithValue("@username", username);
                else
                    command.Parameters.AddWithValue("@username", DBNull.Value);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            //float rating = (float)Convert.ToDouble(ratingTxtB.Text);
            string email = mailTxtB.Text;
            string username = usernameTxtB.Text;

            // Only update the user if the email is not empty
            if (!string.IsNullOrEmpty(email))
            {
                updateUser(email, username);
                MessageBox.Show("User data saved successfully!");
            }
            else
            {
                MessageBox.Show("Email is required!");
            }

        }




    }
}

