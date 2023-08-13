namespace Winform.FullStackll.Forms
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            lblUser = new Label();
            label2 = new Label();
            txtProductName = new RichTextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            ListProducts = new ListBox();
            txtStock = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            ProductList = new ListBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.BurlyWood;
            lblUser.Location = new Point(803, 660);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 24);
            lblUser.TabIndex = 16;
            lblUser.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(511, 660);
            label2.Name = "label2";
            label2.Size = new Size(286, 24);
            label2.TabIndex = 15;
            label2.Text = "Giriş Yapan Kullanıcı :";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Silver;
            txtProductName.Location = new Point(614, 92);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(303, 51);
            txtProductName.TabIndex = 13;
            txtProductName.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Location = new Point(459, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(191, 54);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Silver;
            btnEdit.Location = new Point(728, 263);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(189, 54);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Coral;
            btnRemove.Location = new Point(459, 476);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(458, 48);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // ListProducts
            // 
            ListProducts.FormattingEnabled = true;
            ListProducts.ItemHeight = 24;
            ListProducts.Location = new Point(12, 80);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(399, 604);
            ListProducts.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.Silver;
            txtStock.Location = new Point(614, 163);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(303, 50);
            txtStock.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 179);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 16;
            label1.Text = "Stok sayısı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(478, 106);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 16;
            label3.Text = "Ürün Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, -294);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 16;
            label4.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 36);
            label5.Name = "label5";
            label5.Size = new Size(190, 24);
            label5.TabIndex = 16;
            label5.Text = "Ürünler Listesi";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(459, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(458, 52);
            btnClear.TabIndex = 18;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 24;
            ProductList.Location = new Point(12, 92);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(403, 580);
            ProductList.TabIndex = 19;
            ProductList.SelectedIndexChanged += ProductList_SelectedIndexChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(938, 705);
            Controls.Add(ProductList);
            Controls.Add(btnClear);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Font = new Font("Consolas", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed;
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private RichTextBox txtProductName;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private ListBox ListProducts;
        private TextBox txtStock;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClear;
        private ListBox listBox1;
        private ListBox ProductList;
    }
}