namespace BookInfoApp
{
    partial class BookInfoUI
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnNumTextBox = new System.Windows.Forms.TextBox();
            this.bookInfoTextBox = new System.Windows.Forms.TextBox();
            this.bookInfoLabel = new System.Windows.Forms.Label();
            this.addBookInfoButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.isbnSearchLabel = new System.Windows.Forms.Label();
            this.isbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookInfoSearchTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.searchBookInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(138, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(111, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add Book Info";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(38, 50);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(32, 13);
            this.isbnLabel.TabIndex = 1;
            this.isbnLabel.Text = "ISBN";
            // 
            // isbnNumTextBox
            // 
            this.isbnNumTextBox.Location = new System.Drawing.Point(99, 50);
            this.isbnNumTextBox.Name = "isbnNumTextBox";
            this.isbnNumTextBox.Size = new System.Drawing.Size(164, 20);
            this.isbnNumTextBox.TabIndex = 2;
            // 
            // bookInfoTextBox
            // 
            this.bookInfoTextBox.Location = new System.Drawing.Point(99, 95);
            this.bookInfoTextBox.Multiline = true;
            this.bookInfoTextBox.Name = "bookInfoTextBox";
            this.bookInfoTextBox.Size = new System.Drawing.Size(164, 58);
            this.bookInfoTextBox.TabIndex = 3;
            // 
            // bookInfoLabel
            // 
            this.bookInfoLabel.AutoSize = true;
            this.bookInfoLabel.Location = new System.Drawing.Point(26, 117);
            this.bookInfoLabel.Name = "bookInfoLabel";
            this.bookInfoLabel.Size = new System.Drawing.Size(67, 13);
            this.bookInfoLabel.TabIndex = 4;
            this.bookInfoLabel.Text = "Book Details";
            // 
            // addBookInfoButton
            // 
            this.addBookInfoButton.Location = new System.Drawing.Point(187, 176);
            this.addBookInfoButton.Name = "addBookInfoButton";
            this.addBookInfoButton.Size = new System.Drawing.Size(75, 23);
            this.addBookInfoButton.TabIndex = 5;
            this.addBookInfoButton.Text = "Add";
            this.addBookInfoButton.UseVisualStyleBackColor = true;
            this.addBookInfoButton.Click += new System.EventHandler(this.addBookInfoButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(114, 238);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(133, 20);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search Book Info";
            // 
            // isbnSearchLabel
            // 
            this.isbnSearchLabel.AutoSize = true;
            this.isbnSearchLabel.Location = new System.Drawing.Point(41, 278);
            this.isbnSearchLabel.Name = "isbnSearchLabel";
            this.isbnSearchLabel.Size = new System.Drawing.Size(32, 13);
            this.isbnSearchLabel.TabIndex = 7;
            this.isbnSearchLabel.Text = "ISBN";
            // 
            // isbnSearchTextBox
            // 
            this.isbnSearchTextBox.Location = new System.Drawing.Point(99, 278);
            this.isbnSearchTextBox.Name = "isbnSearchTextBox";
            this.isbnSearchTextBox.Size = new System.Drawing.Size(164, 20);
            this.isbnSearchTextBox.TabIndex = 8;
            // 
            // bookInfoSearchTextBox
            // 
            this.bookInfoSearchTextBox.Location = new System.Drawing.Point(99, 322);
            this.bookInfoSearchTextBox.Multiline = true;
            this.bookInfoSearchTextBox.Name = "bookInfoSearchTextBox";
            this.bookInfoSearchTextBox.Size = new System.Drawing.Size(164, 64);
            this.bookInfoSearchTextBox.TabIndex = 9;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(26, 325);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(67, 13);
            this.detailsLabel.TabIndex = 10;
            this.detailsLabel.Text = "Book Details";
            // 
            // searchBookInfoButton
            // 
            this.searchBookInfoButton.Location = new System.Drawing.Point(186, 410);
            this.searchBookInfoButton.Name = "searchBookInfoButton";
            this.searchBookInfoButton.Size = new System.Drawing.Size(75, 23);
            this.searchBookInfoButton.TabIndex = 11;
            this.searchBookInfoButton.Text = "Search";
            this.searchBookInfoButton.UseVisualStyleBackColor = true;
            this.searchBookInfoButton.Click += new System.EventHandler(this.searchBookInfoButton_Click);
            // 
            // BookInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 480);
            this.Controls.Add(this.searchBookInfoButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.bookInfoSearchTextBox);
            this.Controls.Add(this.isbnSearchTextBox);
            this.Controls.Add(this.isbnSearchLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.addBookInfoButton);
            this.Controls.Add(this.bookInfoLabel);
            this.Controls.Add(this.bookInfoTextBox);
            this.Controls.Add(this.isbnNumTextBox);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "BookInfoUI";
            this.Text = "BookInfoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbnNumTextBox;
        private System.Windows.Forms.TextBox bookInfoTextBox;
        private System.Windows.Forms.Label bookInfoLabel;
        private System.Windows.Forms.Button addBookInfoButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label isbnSearchLabel;
        private System.Windows.Forms.TextBox isbnSearchTextBox;
        private System.Windows.Forms.TextBox bookInfoSearchTextBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button searchBookInfoButton;
    }
}

