namespace BPCHS___Library_Management_System
{
    partial class ucBorrowBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBorrowBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgAvail = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bnAddBook = new System.Windows.Forms.Button();
            this.bnBorrowBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.pnBorrower = new System.Windows.Forms.Panel();
            this.rtAddress = new System.Windows.Forms.RichTextBox();
            this.lbBDate = new System.Windows.Forms.Label();
            this.lbBorrowerType = new System.Windows.Forms.Label();
            this.lbBorrowerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvail)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowedBooks)).BeginInit();
            this.pnBorrower.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 45);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Borrow Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 32);
            this.panel2.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Title",
            "Publisher",
            "Source",
            "Book Class",
            "Author"});
            this.cbCategory.Location = new System.Drawing.Point(559, 6);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(128, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(492, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(745, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(692, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available Books";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgAvail);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 260);
            this.panel4.TabIndex = 4;
            // 
            // dgAvail
            // 
            this.dgAvail.AllowUserToAddRows = false;
            this.dgAvail.AllowUserToDeleteRows = false;
            this.dgAvail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAvail.BackgroundColor = System.Drawing.Color.White;
            this.dgAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAvail.Location = new System.Drawing.Point(0, 0);
            this.dgAvail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgAvail.Name = "dgAvail";
            this.dgAvail.ReadOnly = true;
            this.dgAvail.RowHeadersVisible = false;
            this.dgAvail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAvail.Size = new System.Drawing.Size(896, 228);
            this.dgAvail.TabIndex = 5;
            this.dgAvail.SelectionChanged += new System.EventHandler(this.dgAvail_SelectionChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.bnAddBook);
            this.panel8.Controls.Add(this.bnBorrowBook);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 228);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(896, 32);
            this.panel8.TabIndex = 6;
            // 
            // bnAddBook
            // 
            this.bnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAddBook.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAddBook.Location = new System.Drawing.Point(691, 3);
            this.bnAddBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bnAddBook.Name = "bnAddBook";
            this.bnAddBook.Size = new System.Drawing.Size(86, 23);
            this.bnAddBook.TabIndex = 5;
            this.bnAddBook.Text = "Add Book";
            this.bnAddBook.UseVisualStyleBackColor = true;
            this.bnAddBook.Click += new System.EventHandler(this.bnAddBook_Click);
            // 
            // bnBorrowBook
            // 
            this.bnBorrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBorrowBook.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBorrowBook.Location = new System.Drawing.Point(784, 3);
            this.bnBorrowBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bnBorrowBook.Name = "bnBorrowBook";
            this.bnBorrowBook.Size = new System.Drawing.Size(104, 23);
            this.bnBorrowBook.TabIndex = 4;
            this.bnBorrowBook.Text = "Borrow Book";
            this.bnBorrowBook.UseVisualStyleBackColor = true;
            this.bnBorrowBook.Click += new System.EventHandler(this.bnBorrowBook_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Borrower";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 337);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 187);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgBorrowedBooks);
            this.panel6.Controls.Add(this.pnBorrower);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(896, 187);
            this.panel6.TabIndex = 7;
            // 
            // dgBorrowedBooks
            // 
            this.dgBorrowedBooks.AllowUserToAddRows = false;
            this.dgBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrowedBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBorrowedBooks.Location = new System.Drawing.Point(339, 32);
            this.dgBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgBorrowedBooks.Name = "dgBorrowedBooks";
            this.dgBorrowedBooks.ReadOnly = true;
            this.dgBorrowedBooks.RowHeadersVisible = false;
            this.dgBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBorrowedBooks.Size = new System.Drawing.Size(557, 155);
            this.dgBorrowedBooks.TabIndex = 2;
            // 
            // pnBorrower
            // 
            this.pnBorrower.BackColor = System.Drawing.Color.Transparent;
            this.pnBorrower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBorrower.BackgroundImage")));
            this.pnBorrower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBorrower.Controls.Add(this.rtAddress);
            this.pnBorrower.Controls.Add(this.lbBDate);
            this.pnBorrower.Controls.Add(this.lbBorrowerType);
            this.pnBorrower.Controls.Add(this.lbBorrowerName);
            this.pnBorrower.Controls.Add(this.label7);
            this.pnBorrower.Controls.Add(this.label6);
            this.pnBorrower.Controls.Add(this.label5);
            this.pnBorrower.Controls.Add(this.label4);
            this.pnBorrower.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBorrower.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBorrower.ForeColor = System.Drawing.Color.Black;
            this.pnBorrower.Location = new System.Drawing.Point(0, 32);
            this.pnBorrower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnBorrower.Name = "pnBorrower";
            this.pnBorrower.Size = new System.Drawing.Size(339, 155);
            this.pnBorrower.TabIndex = 1;
            // 
            // rtAddress
            // 
            this.rtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtAddress.Location = new System.Drawing.Point(91, 81);
            this.rtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtAddress.Name = "rtAddress";
            this.rtAddress.ReadOnly = true;
            this.rtAddress.Size = new System.Drawing.Size(242, 64);
            this.rtAddress.TabIndex = 11;
            this.rtAddress.Text = "";
            // 
            // lbBDate
            // 
            this.lbBDate.AutoSize = true;
            this.lbBDate.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBDate.ForeColor = System.Drawing.Color.Black;
            this.lbBDate.Location = new System.Drawing.Point(91, 60);
            this.lbBDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBDate.Name = "lbBDate";
            this.lbBDate.Size = new System.Drawing.Size(0, 16);
            this.lbBDate.TabIndex = 10;
            // 
            // lbBorrowerType
            // 
            this.lbBorrowerType.AutoSize = true;
            this.lbBorrowerType.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowerType.ForeColor = System.Drawing.Color.Black;
            this.lbBorrowerType.Location = new System.Drawing.Point(91, 39);
            this.lbBorrowerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorrowerType.Name = "lbBorrowerType";
            this.lbBorrowerType.Size = new System.Drawing.Size(0, 16);
            this.lbBorrowerType.TabIndex = 9;
            // 
            // lbBorrowerName
            // 
            this.lbBorrowerName.AutoSize = true;
            this.lbBorrowerName.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowerName.ForeColor = System.Drawing.Color.Black;
            this.lbBorrowerName.Location = new System.Drawing.Point(91, 18);
            this.lbBorrowerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorrowerName.Name = "lbBorrowerName";
            this.lbBorrowerName.Size = new System.Drawing.Size(0, 16);
            this.lbBorrowerName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Borrower Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtBorrower);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(896, 32);
            this.panel7.TabIndex = 0;
            // 
            // txtBorrower
            // 
            this.txtBorrower.Location = new System.Drawing.Point(73, 4);
            this.txtBorrower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.Size = new System.Drawing.Size(143, 20);
            this.txtBorrower.TabIndex = 0;
            this.txtBorrower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrower_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(330, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book(s) Borrowed";
            // 
            // ucBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucBorrowBook";
            this.Size = new System.Drawing.Size(896, 524);
            this.Load += new System.EventHandler(this.ucBorrowBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAvail)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowedBooks)).EndInit();
            this.pnBorrower.ResumeLayout(false);
            this.pnBorrower.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAvail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgBorrowedBooks;
        private System.Windows.Forms.Panel pnBorrower;
        private System.Windows.Forms.RichTextBox rtAddress;
        private System.Windows.Forms.Label lbBDate;
        private System.Windows.Forms.Label lbBorrowerType;
        private System.Windows.Forms.Label lbBorrowerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnAddBook;
        private System.Windows.Forms.Button bnBorrowBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBorrower;
    }
}
