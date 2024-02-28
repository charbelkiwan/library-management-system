namespace Library
{
    partial class AdminForm
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
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.btnShowBooksAdmin = new System.Windows.Forms.Button();
            this.btnBackAdmintoStart = new System.Windows.Forms.Button();
            this.listBox_booksadmin = new System.Windows.Forms.ListBox();
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnSortByPrice = new System.Windows.Forms.Button();
            this.btnAsyncShowEmails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_title.Location = new System.Drawing.Point(89, 77);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(121, 23);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(89, 106);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(121, 23);
            this.textBox_author.TabIndex = 1;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(89, 135);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(121, 23);
            this.textBox_price.TabIndex = 2;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(89, 164);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(121, 23);
            this.textBox_code.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(37, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(135, 222);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AllowDrop = true;
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "romance",
            "action",
            "scifi",
            "comedy",
            "horror"});
            this.comboBox_type.Location = new System.Drawing.Point(89, 193);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 23);
            this.comboBox_type.TabIndex = 11;
            // 
            // btnShowBooksAdmin
            // 
            this.btnShowBooksAdmin.Location = new System.Drawing.Point(405, 222);
            this.btnShowBooksAdmin.Name = "btnShowBooksAdmin";
            this.btnShowBooksAdmin.Size = new System.Drawing.Size(128, 23);
            this.btnShowBooksAdmin.TabIndex = 13;
            this.btnShowBooksAdmin.Text = "Show available books";
            this.btnShowBooksAdmin.UseVisualStyleBackColor = true;
            this.btnShowBooksAdmin.Click += new System.EventHandler(this.btnShowBooksAdmin_Click);
            // 
            // btnBackAdmintoStart
            // 
            this.btnBackAdmintoStart.Location = new System.Drawing.Point(785, 272);
            this.btnBackAdmintoStart.Name = "btnBackAdmintoStart";
            this.btnBackAdmintoStart.Size = new System.Drawing.Size(75, 23);
            this.btnBackAdmintoStart.TabIndex = 14;
            this.btnBackAdmintoStart.Text = "Back";
            this.btnBackAdmintoStart.UseVisualStyleBackColor = true;
            this.btnBackAdmintoStart.Click += new System.EventHandler(this.btnBackAdmintoStart_Click);
            // 
            // listBox_booksadmin
            // 
            this.listBox_booksadmin.FormattingEnabled = true;
            this.listBox_booksadmin.ItemHeight = 15;
            this.listBox_booksadmin.Location = new System.Drawing.Point(242, 76);
            this.listBox_booksadmin.Name = "listBox_booksadmin";
            this.listBox_booksadmin.Size = new System.Drawing.Size(291, 139);
            this.listBox_booksadmin.TabIndex = 15;
            this.listBox_booksadmin.SelectedIndexChanged += new System.EventHandler(this.listBox_booksadmin_SelectedIndexChanged);
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 15;
            this.listBox_users.Location = new System.Drawing.Point(569, 76);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new System.Drawing.Size(291, 139);
            this.listBox_users.TabIndex = 16;
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(646, 221);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(214, 23);
            this.btnShowUsers.TabIndex = 17;
            this.btnShowUsers.Text = "Show borrowed books and their users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnSortByPrice
            // 
            this.btnSortByPrice.Location = new System.Drawing.Point(450, 47);
            this.btnSortByPrice.Name = "btnSortByPrice";
            this.btnSortByPrice.Size = new System.Drawing.Size(83, 23);
            this.btnSortByPrice.TabIndex = 18;
            this.btnSortByPrice.Text = "Sort by Price";
            this.btnSortByPrice.UseVisualStyleBackColor = true;
            this.btnSortByPrice.Click += new System.EventHandler(this.btnSortByPrice_Click);
            // 
            // btnAsyncShowEmails
            // 
            this.btnAsyncShowEmails.Location = new System.Drawing.Point(744, 47);
            this.btnAsyncShowEmails.Name = "btnAsyncShowEmails";
            this.btnAsyncShowEmails.Size = new System.Drawing.Size(116, 23);
            this.btnAsyncShowEmails.TabIndex = 19;
            this.btnAsyncShowEmails.Text = "Async show emails";
            this.btnAsyncShowEmails.UseVisualStyleBackColor = true;
            this.btnAsyncShowEmails.Click += new System.EventHandler(this.btnAsyncShowEmails_Click);
            // 
            // AdminForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(892, 361);
            this.Controls.Add(this.btnAsyncShowEmails);
            this.Controls.Add(this.btnSortByPrice);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.listBox_users);
            this.Controls.Add(this.listBox_booksadmin);
            this.Controls.Add(this.btnBackAdmintoStart);
            this.Controls.Add(this.btnShowBooksAdmin);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.textBox_title);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_title;
        private TextBox textBox_author;
        private TextBox textBox_price;
        private TextBox textBox_code;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddBook;
        private ComboBox comboBox_type;
        private Button btnShowBooksAdmin;
        private Button btnBackAdmintoStart;
        private ListBox listBox_booksadmin;
        private ListBox listBox_users;
        private Button btnShowUsers;
        private Button btnSortByPrice;
        private Button btnAsyncShowEmails;
    }
}