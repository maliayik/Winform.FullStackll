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
using Winform.FullStackll.Defaults;
using Winform.FullStackll.Entities;

namespace Winform.FullStackll.Forms
{
    public partial class ProductsForm : Form
    {
        string userFullname;

        Product selectedProduct;


        /// <summary>
        /// Bu form ancak ve ancak userFullname ile örneklenebilir.
        /// </summary>

        public ProductsForm(string userFullname)
        {
            InitializeComponent();
            this.userFullname = userFullname;

            Reload();
        }

        public void Reload()
        {
            var notes = ListProduct();
            ProductList.DataSource = null;
            ProductList.DataSource = notes;
            ProductList.DisplayMember = "Name";
            ProductList.ValueMember = "Id";

        }

        /// <summary>
        /// Bu metot veri tabanından list halinde productları listelemeye yarar.
        /// </summary>

        private List<Product> ListProduct()
        {
            var ProductList = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);


                ProductList.Add(product);
            }

            reader.Close();
            connection.Close();

            return ProductList;

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var item = ProductList.SelectedItem as Product;

            lblUser.Text = userFullname;
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(txtStock.Text) && !string.IsNullOrEmpty(txtProductName.Text))
                {
                    if (int.TryParse(txtStock.Text, out int stockValue))
                    {
                        UpdateProduct(new Product { Name = txtProductName.Text, Stock = stockValue, Id = selectedProduct.Id });
                        Reload();
                    }
                    else
                    {
                        MessageBox.Show("Stok değeri rakam olmalıdır");
                    }

                }
            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELLECTED);
            }

        }


        /// <summary>
        /// Bu metot veritabanımızaki ürünleri ürün adı ve stok sayısını güncellemeye yarar.
        /// </summary>

        private int UpdateProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Update Products set Name=@name,Stock=@stock where Id=@id";

            command.Parameters.AddWithValue("@name", updatedProduct.Name);
            command.Parameters.AddWithValue("@stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@id", updatedProduct.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();
            connection.Close();

            return effectedRows;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtStock.Text = string.Empty;
            selectedProduct = null;
        }

        /// <summary>
        /// Bu metot veritabanımıza ürün adı ve stok sayısı ile birlikte yeni ürün eklemeye yarar.
        /// </summary>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                if (int.TryParse(txtStock.Text, out int stockValue))
                {
                    SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Products VALUES (@name, @stock)";
                    command.Parameters.AddWithValue("@name", txtProductName.Text);
                    command.Parameters.AddWithValue("@stock", stockValue);

                    connection.Open();
                    var effectedRows = command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();

                    if (effectedRows > 0)
                    {
                        MessageBox.Show("Kayıt başarılı bir şekilde eklendi");
                        Reload();
                        ClearText();
                    }

                }
                else
                {
                    MessageBox.Show("Stok değeri rakam olmalıdır.");
                }

            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database= TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "delete from Products where Id=@id";

                command.Parameters.AddWithValue("@id", selectedProduct.Id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();
                Reload();
                ClearText();
            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELLECTED);
            }
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem != null)
            {
                selectedProduct = ProductList.SelectedItem as Product;
                txtStock.Text = selectedProduct.Stock + "";
                txtProductName.Text = selectedProduct.Name;
            }
        }
    }
}

