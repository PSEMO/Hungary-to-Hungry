using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Hungary_for_hungry
{
    public partial class AdminForm : Form
    {
        //defining login form
        Form1 f1 = new Form1();
        public AdminForm()
        {
            InitializeComponent();
            mainPnl.Visible = true;
            allAccountsPnl.Visible = false;
            allRestaurantsPnl.Visible = false;
        }

        //db connection string
        public static string dbconnection = "Data Source=DESKTOP-2EBNC0D\\SQLEXPRESS;Initial Catalog=hthDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(dbconnection);

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //for reading restaurant accounts
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id,username,businessName,rating,email,location,address,membershipStatus FROM tb_accounts WHERE type='Restaurant' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            restaurantsDt.DataSource = dt;

            //for reading all accounts
            SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT * FROM tb_accounts", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            accountsDt.DataSource = dt1;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewRestaurantsBtn_Click(object sender, EventArgs e)
        {


        }

        private void allAccountsBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = false;
            allAccountsPnl.Visible = true;
            allRestaurantsPnl.Visible = false;

            //for reading all accounts
            SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT * FROM tb_accounts", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            accountsDt.DataSource = dt1;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Logged Out!");
            //redirecting to login form
            f1.Show();
            this.Hide();
        }

        private void allRestaurantsBtn_Click(object sender, EventArgs e)
        {
            //configuring with panels
            mainPnl.Visible = false;
            allAccountsPnl.Visible = false;
            allRestaurantsPnl.Visible = true;

            //for reading restaurant accounts
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id,username,businessName,rating,email,location,address,membershipStatus FROM tb_accounts WHERE type='Restaurant' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            restaurantsDt.DataSource = dt;

        }

        private void membershipBtn_Click(object sender, EventArgs e)
        {
            if (restaurantsDt.SelectedRows.Count > 0)
            {
                //validation for if the membership status is true
                if ((string)restaurantsDt.SelectedRows[0].Cells["membershipStatus"].Value == "true")
                {
                    MessageBox.Show("The restaurant has already had a membership!");
                }
                else
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int memberId = Convert.ToInt32(restaurantsDt.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "UPDATE tb_accounts SET membershipStatus = 'true' WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", memberId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Membership has given to the restaurant!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id,username,businessName,rating,email,location,address,membershipStatus FROM tb_accounts WHERE type='Restaurant' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    restaurantsDt.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountsDt.SelectedRows.Count > 0)
            {
                //validation for if the membership status is false
                if (MessageBox.Show("Are you sure you want to delete this account?", "Delete" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int memberId = Convert.ToInt32(accountsDt.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "DELETE FROM tb_accounts WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", memberId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account has been deleted!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_accounts", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    accountsDt.DataSource = dt;

                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }
        }

        private void rmvMembershipBtn_Click(object sender, EventArgs e)
        {
            if (restaurantsDt.SelectedRows.Count > 0)
            {

                if ((string)restaurantsDt.SelectedRows[0].Cells["membershipStatus"].Value == "false")
                {
                    MessageBox.Show("The restaurant doesn't have a membership yet.");
                }
                else
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int memberId = Convert.ToInt32(restaurantsDt.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "UPDATE tb_accounts SET membershipStatus = 'false' WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", memberId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Membership has been removed from restaurant!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT id,username,businessName,rating,email,location,address,membershipStatus FROM tb_accounts WHERE type='Restaurant' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    restaurantsDt.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }

        }
    }
}
