namespace Winform.FullStackll.Forms
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            ListNotes = new CheckedListBox();
            lblUser = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Coral;
            btnRemove.Location = new Point(557, 433);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(336, 59);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Temizle";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Silver;
            btnEdit.Location = new Point(745, 298);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 59);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Location = new Point(557, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 59);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(557, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 10;
            label2.Text = "Not :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(224, 224, 224);
            txtDescription.Location = new Point(557, 114);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 100);
            txtDescription.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 8;
            label1.Text = "Yapılacaklar Listesi";
            // 
            // ListNotes
            // 
            ListNotes.AccessibleName = "checkedListBox1";
            ListNotes.BackColor = Color.FromArgb(224, 224, 224);
            ListNotes.FormattingEnabled = true;
            ListNotes.HorizontalScrollbar = true;
            ListNotes.Location = new Point(47, 69);
            ListNotes.MaximumSize = new Size(453, 0);
            ListNotes.MinimumSize = new Size(453, 650);
            ListNotes.Name = "ListNotes";
            ListNotes.Size = new Size(453, 652);
            ListNotes.TabIndex = 7;
            ListNotes.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.BurlyWood;
            lblUser.Location = new Point(830, 697);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 24);
            lblUser.TabIndex = 18;
            lblUser.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BurlyWood;
            label3.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(527, 697);
            label3.Name = "label3";
            label3.Size = new Size(286, 24);
            label3.TabIndex = 17;
            label3.Text = "Giriş Yapan Kullanıcı :";
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 759);
            Controls.Add(lblUser);
            Controls.Add(label3);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(ListNotes);
            Font = new Font("Consolas", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "NotesForm";
            Text = "Yapılacaklar Listesi";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        public CheckedListBox ListNotes;
        private Label lblUser;
        private Label label3;
    }
}