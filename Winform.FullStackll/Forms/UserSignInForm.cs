using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Winform.FullStackll.Defaults;

namespace Winform.FullStackll.Forms
{
    public partial class UserSignInForm : Form
    {
        public UserSignInForm()
        {
            InitializeComponent();
        }



        private void UserSignInForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username =txtUsername.Text;
            string password = txtPassword.Text;
            string Fullname = txtFullName.Text;

            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(Fullname))
            {


                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                    string passwordHash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();


                    SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;

                    command.CommandText = "INSERT INTO Users (Username, PasswordHash,Fullname) VALUES (@Username, @PasswordHash,@Fullname)";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    command.Parameters.AddWithValue("@Fullname", Fullname);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show(MessageDefaults.SUCCESS);

                    UserLoginForm userLoginForm = new UserLoginForm();
                    userLoginForm.Show();

                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanlarını doldurunuz.");
            }

        }

        private void UserSignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
