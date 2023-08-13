namespace Winform.FullStackll.Forms
{
    partial class NavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationForm));
            btnNote = new Button();
            btnProduct = new Button();
            SuspendLayout();
            // 
            // btnNote
            // 
            btnNote.BackColor = Color.Tomato;
            btnNote.Location = new Point(52, 147);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(457, 81);
            btnNote.TabIndex = 0;
            btnNote.Text = "Yapılacaklar Listesi";
            btnNote.UseVisualStyleBackColor = false;
            btnNote.Click += btnNote_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Gold;
            btnProduct.Location = new Point(52, 35);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(457, 79);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Ürün Listesi";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(576, 279);
            Controls.Add(btnProduct);
            Controls.Add(btnNote);
            Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NavigationForm";
            Text = "NavigationForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNote;
        private Button btnProduct;
    }
}