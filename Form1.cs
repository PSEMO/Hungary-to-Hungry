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
            }
        }

        void Login(string mail, string password)
        {
            if (UserAndMailMatches(mail, password))
            {
                //Login
                //Get user location according to saved infos
            }
            else
            {
                //Show error
                //Show up a error message and say mail or password is wrong
            }
        }

        bool UserWithMailExists(string mail)
        {
            //see if it has a legitimed @ and .com combination
            return false;
        }

        bool UserAndMailMatches(string mail, string password)
        {
            //Check if there is a user with this password and mail exists
            return true;
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