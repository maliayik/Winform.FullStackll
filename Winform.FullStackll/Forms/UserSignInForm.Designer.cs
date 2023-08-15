namespace Winform.FullStackll.Forms
{
    partial class UserSignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignInForm));
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(242, 169);
            txtFullName.Margin = new Padding(5, 4, 5, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(293, 32);
            txtFullName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(242, 305);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.WordWrap = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(242, 387);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(293, 53);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 248);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 308);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(242, 245);
            txtUsername.Margin = new Padding(5, 4, 5, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 32);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 169);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 24);
            label3.TabIndex = 3;
            label3.Text = "İsim Soyisim :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 53);
            label4.Name = "label4";
            label4.Size = new Size(142, 24);
            label4.TabIndex = 5;
            label4.Text = "Kayıt Formu";
            // 
            // UserSignInForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(632, 500);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UserSignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Kullanıcı Kayıt Formu";
            FormClosed += UserSignInForm_FormClosed;
            Load += UserSignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtPassword;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
    }
}