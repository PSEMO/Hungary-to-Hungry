using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace From_Hungary_for_hungry
{
    public partial class Form1 : Form
    {
        bool isRegistering = false;

        string location = "";

        public Form1()
        {
            InitializeComponent();
        }

        //db connection string
        public static string dbconnection = "Data Source=DESKTOP-2EBNC0D\\SQLEXPRESS;Initial Catalog=hthDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(dbconnection);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Mail
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Remember me
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Login button at the start
        private void button3_Click(object sender, EventArgs e)
        {
            isRegistering = false;
            NextPage();
        }

        //Register button at the start
        private void button2_Click(object sender, EventArgs e)
        {
            isRegistering = true;
            NextPage();
        }

        private void NextPage()
        {
            if (isRegistering)
                LoginLabel.Text = "Register";
            else
                LoginLabel.Text = "Login";

            button4.Visible = true;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        //Ok button at the login/register page
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string password = textBox2.Text;

            if (isMailValid(mail) && isPasswordValid(password))
            {
                if (isRegistering)
                {
                    Register(mail, password);
                }
                else
                {
                    Login(mail, password);
                }
            }
            else
            {
                if (!isMailValid(mail))
                {
                    MessageBox.Show("Please enter a valid e-mail", "Invalid", MessageBoxButtons.OK);
                }
                if (!isPasswordValid(password))
                {
                    MessageBox.Show("Your password needs to be at least 8 characters long", "Invalid", MessageBoxButtons.OK);
                }
            }
        }

        private static string HashPassword(string password)
        {
            //method for hashing password to secure accounts
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hashedPassword;
            }
        }

        bool isMailValid(string mail)
        {
            var trimmedEmail = mail.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        bool isPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        void Register(string mail, string password)
        {
            if (UserWithMailExists(mail))
            {
                GoBack();
                MessageBox.Show("An Account with this mail address exists", "Account Exists", MessageBoxButtons.OK);
            }
            else
            {
                //add strings to save file
                //Register

                //Hash the password
                string hashedPassword = HashPassword(password);

                string q = "INSERT INTO tb_accounts (email, password, type, membershipStatus) VALUES (@email, @password, 'Customer', 'false')";

                using (SqlCommand command = new SqlCommand(q, con))
                {
                    command.Parameters.AddWithValue("@email", mail);
                    command.Parameters.AddWithValue("@password", password);

                    con.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("User created successfully!");

                isRegistering = false;
                NextPage();
                con.Close();

            }
        }

        string GetUserAccountType(string mail)
        {
            string accountType = "Customer";

            // Query the database to get the account type based on the email
            string q = "SELECT type FROM tb_accounts WHERE email = @email";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                command.Parameters.AddWithValue("@email", mail);

                con.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        accountType = reader["type"].ToString();
                    }
                }

                con.Close();
            }

            return accountType;
        }


        void Login(string mail, string password)
        {
            if (UserAndMailMatches(mail, password))
            {
                //Login
                // Determine the account type of the logged-in user
                string accountType = GetUserAccountType(mail);

                // Redirect to different forms based on the account type
                if (accountType == "Customer")
                {
                    MessageBox.Show("Login successful!");
                    // Redirect to customer form
                    CustomerForm customerForm = new CustomerForm();
                    this.Hide();
                    customerForm.Show();
                }
                else if (accountType == "Admin")
                {
                    MessageBox.Show("Login successful!");
                    // Redirect to admin form
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else if (accountType == "Restaurant")
                {
                    //MessageBox.Show("Login successful!");
                    // Redirect to restaurant form
                    /*RestaurantForm restaurantForm = new RestaurantForm();
                     * this.Hide();
                    restaurantForm.Show();*/
                }
                else
                {
                    // Invalid or unrecognized account type
                    MessageBox.Show("Invalid account type! Please contact support.");
                }

            }
            else
            {
                //Show error
                //Show up a error message and say mail or password is wrong
                MessageBox.Show("Mail or password is wrong!! Try again.");
            }
        }

        bool UserWithMailExists(string mail)
        {
            //see if it has a legitimed @ and .com combination

            // Query the database to check if a user with the given email exists
            string q = "SELECT COUNT(*) FROM tb_accounts WHERE email = @email";
            int count = 0;

            using (SqlCommand command = new SqlCommand(q, con))
            {
                command.Parameters.AddWithValue("@email", mail);

                con.Open();
                count = (int)command.ExecuteScalar();
                con.Close();
            }

            // If count is greater than 0, a user with the email already exists
            return count > 0;
        }

        bool UserAndMailMatches(string mail, string password)
        {
            //Check if there is a user with this password and mail exists
            string q = "SELECT COUNT(*) FROM tb_accounts WHERE email = @email AND password = @password";
            int count = 0;

            using (SqlCommand command = new SqlCommand(q, con))
            {
                command.Parameters.AddWithValue("@email", mail);
                command.Parameters.AddWithValue("@password", password);

                con.Open();
                count = (int)command.ExecuteScalar();
                con.Close();
            }

            // If count is greater than 0, a user with the email and password exists
            return count > 0;
        }

        //Back button
        private void button4_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        void GoBack()
        {
            button4.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;

            textBox1.Text = null;
            textBox2.Text = null;

            checkBox1.Checked = false;
        }

        #region Admin functions
        void AGoToMenu()
        {

        }
        void GiveMembership(string id)
        {

        }
        void DeleteAccount(string id)
        {

        }
        void ViewRestaurantAccounts()
        {

        }
        void ViewCustomerAccounts()
        {

        }
        #endregion

        #region Customer functions
        void CGoToMenu()
        {

        }
        void PlaceOrder(Order order)
        {

        }
        void OrderTrackerMenu()
        {

        }
        #endregion

        #region Restaurant functions
        void RGoToMenu()
        {

        }
        void ViewOrders()
        {

        }
        void OrderDelivered(Order order)
        {

        }
        void AddProduct(Product product)
        {

        }
        void DeleteProduct(Product product)
        {

        }
        void EditProduct(Product product)
        {

        }
        #endregion


    }
}