using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Winform.FullStackll.Defaults;
using Winform.FullStackll.DTOS;
using Winform.FullStackll.Forms;

namespace Winform.FullStackll
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var response = GetUserWithHash(txtUserName.Text, txtPassword.Text);

                if (response != null)
                {
                    NavigationForm form = new NavigationForm(response);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Parametre olarak girilen username ve passworda karşılık,userin full name'ini döner.
        /// </summary>

        private UserLoginResponseDto GetUserWithHash(string username, string password)
        {

            UserLoginResponseDto responseDto = null;

            using (SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security = true;"))
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "select * from Users where Username=@username and PasswordHash=@password";

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                    string passwordHash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", passwordHash);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    command.Parameters.Clear();

                    while (reader.Read())
                    {
                        responseDto = new UserLoginResponseDto();
                        responseDto.Id = Convert.ToInt32(reader[0]);
                        responseDto.Fullname = Convert.ToString(reader[3]);
                    }

                    reader.Close();
                }
            }
            return responseDto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSignInForm signInForm = new UserSignInForm();

            signInForm.Show();

            this.Hide();
        }

    }
}
