namespace BPCHS___Library_Management_System
{
    partial class wfHome
    {
        /// <summary>
        /// Required designer v.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfHome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnCon = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bnBorrower = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bnBorrowBooks = new System.Windows.Forms.ToolStripButton();
            this.bnReturnBooks = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbUser = new System.Windows.Forms.ToolStripLabel();
            this.lbDate = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerTypeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deweyDecimalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ni
            // 
            this.ni.Text = "notifyIcon1";
            this.ni.Visible = true;
            this.ni.DoubleClick += new System.EventHandler(this.ni_DoubleClick);
            // 
            // pnCon
            // 
            this.pnCon.BackColor = System.Drawing.SystemColors.Control;
            this.pnCon.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.pnCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCon.Location = new System.Drawing.Point(0, 52);
            this.pnCon.Name = "pnCon";
            this.pnCon.Size = new System.Drawing.Size(899, 531);
            this.pnCon.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.bnBorrower,
            this.toolStripButton4,
            this.bnBorrowBooks,
            this.bnReturnBooks});
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(899, 26);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::BPCHS___Library_Management_System.Properties.Resources.Log_Out_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(101, 23);
            this.toolStripButton2.Text = "Log - Out";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // bnBorrower
            // 
            this.bnBorrower.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBorrower.Image = global::BPCHS___Library_Management_System.Properties.Resources.Groups_Meeting_Dark_icon1;
            this.bnBorrower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBorrower.Name = "bnBorrower";
            this.bnBorrower.Size = new System.Drawing.Size(103, 23);
            this.bnBorrower.Text = "Borrower";
            this.bnBorrower.Click += new System.EventHandler(this.bnBorrower_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::BPCHS___Library_Management_System.Properties.Resources.Books_icon1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 23);
            this.toolStripButton4.Text = "Book";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // bnBorrowBooks
            // 
            this.bnBorrowBooks.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBorrowBooks.Image = global::BPCHS___Library_Management_System.Properties.Resources.books_icon2;
            this.bnBorrowBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBorrowBooks.Name = "bnBorrowBooks";
            this.bnBorrowBooks.Size = new System.Drawing.Size(137, 23);
            this.bnBorrowBooks.Text = "Borrow Books";
            this.bnBorrowBooks.Click += new System.EventHandler(this.bnBorrowBooks_Click);
            // 
            // bnReturnBooks
            // 
            this.bnReturnBooks.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnReturnBooks.Image = global::BPCHS___Library_Management_System.Properties.Resources.returnrbook;
            this.bnReturnBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnReturnBooks.Name = "bnReturnBooks";
            this.bnReturnBooks.Size = new System.Drawing.Size(133, 23);
            this.bnReturnBooks.Text = "Return Books";
            this.bnReturnBooks.Click += new System.EventHandler(this.bnReturnBooks_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbUser,
            this.lbDate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 583);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbUser
            // 
            this.lbUser.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(126, 22);
            this.lbUser.Text = "toolStripLabel1";
            this.lbUser.ToolTipText = "The current user";
            // 
            // lbDate
            // 
            this.lbDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbDate.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(126, 22);
            this.lbDate.Text = "toolStripLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.listOfBorrowedBooksToolStripMenuItem,
            this.logHistoryToolStripMenuItem,
            this.borrowerTypeSettingToolStripMenuItem,
            this.bookReportToolStripMenuItem,
            this.paymentReportToolStripMenuItem,
            this.changeUserSettingToolStripMenuItem,
            this.deweyDecimalSettingsToolStripMenuItem,
            this.holidaysToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources.Folder_Closed_Red;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.editToolStripMenuItem.Text = "Settings";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources.borrower;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.staffToolStripMenuItem.Text = "User Settings";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // listOfBorrowedBooksToolStripMenuItem
            // 
            this.listOfBorrowedBooksToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources.listboorrower;
            this.listOfBorrowedBooksToolStripMenuItem.Name = "listOfBorrowedBooksToolStripMenuItem";
            this.listOfBorrowedBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listOfBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.listOfBorrowedBooksToolStripMenuItem.Text = "List of Borrowed Books";
            this.listOfBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.listOfBorrowedBooksToolStripMenuItem_Click);
            // 
            // logHistoryToolStripMenuItem
            // 
            this.logHistoryToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources._out;
            this.logHistoryToolStripMenuItem.Name = "logHistoryToolStripMenuItem";
            this.logHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.logHistoryToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.logHistoryToolStripMenuItem.Text = "Log History";
            this.logHistoryToolStripMenuItem.Click += new System.EventHandler(this.logHistoryToolStripMenuItem_Click);
            // 
            // borrowerTypeSettingToolStripMenuItem
            // 
            this.borrowerTypeSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrowerTypeSettingToolStripMenuItem.Image")));
            this.borrowerTypeSettingToolStripMenuItem.Name = "borrowerTypeSettingToolStripMenuItem";
            this.borrowerTypeSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.borrowerTypeSettingToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.borrowerTypeSettingToolStripMenuItem.Text = "Borrower Type Setting";
            this.borrowerTypeSettingToolStripMenuItem.Click += new System.EventHandler(this.borrowerTypeSettingToolStripMenuItem_Click);
            // 
            // bookReportToolStripMenuItem
            // 
            this.bookReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookReportToolStripMenuItem.Image")));
            this.bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            this.bookReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bookReportToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.bookReportToolStripMenuItem.Text = "Book Report";
            this.bookReportToolStripMenuItem.Click += new System.EventHandler(this.bookReportToolStripMenuItem_Click);
            // 
            // paymentReportToolStripMenuItem
            // 
            this.paymentReportToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources.address_book_icon;
            this.paymentReportToolStripMenuItem.Name = "paymentReportToolStripMenuItem";
            this.paymentReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.paymentReportToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.paymentReportToolStripMenuItem.Text = "Payment Report";
            this.paymentReportToolStripMenuItem.Click += new System.EventHandler(this.paymentReportToolStripMenuItem_Click);
            // 
            // changeUserSettingToolStripMenuItem
            // 
            this.changeUserSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeUserSettingToolStripMenuItem.Image")));
            this.changeUserSettingToolStripMenuItem.Name = "changeUserSettingToolStripMenuItem";
            this.changeUserSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.changeUserSettingToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.changeUserSettingToolStripMenuItem.Text = "Change User Setting";
            this.changeUserSettingToolStripMenuItem.Click += new System.EventHandler(this.changeUserSettingToolStripMenuItem_Click);
            // 
            // deweyDecimalSettingsToolStripMenuItem
            // 
            this.deweyDecimalSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deweyDecimalSettingsToolStripMenuItem.Image")));
            this.deweyDecimalSettingsToolStripMenuItem.Name = "deweyDecimalSettingsToolStripMenuItem";
            this.deweyDecimalSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deweyDecimalSettingsToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.deweyDecimalSettingsToolStripMenuItem.Text = "Dewey Decimal Settings";
            this.deweyDecimalSettingsToolStripMenuItem.Click += new System.EventHandler(this.deweyDecimalSettingsToolStripMenuItem_Click);
            // 
            // holidaysToolStripMenuItem
            // 
            this.holidaysToolStripMenuItem.Image = global::BPCHS___Library_Management_System.Properties.Resources.holiday_icon;
            this.holidaysToolStripMenuItem.Name = "holidaysToolStripMenuItem";
            this.holidaysToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.holidaysToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.holidaysToolStripMenuItem.Text = "Hollidays";
            this.holidaysToolStripMenuItem.Click += new System.EventHandler(this.holidaysToolStripMenuItem_Click);
            // 
            // wfHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 608);
            this.Controls.Add(this.pnCon);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wfHome";
            this.Text = "BPCHS - Library Management System - Home Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbUser;
        private System.Windows.Forms.ToolStripLabel lbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon ni;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel pnCon;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnBorrower;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem borrowerTypeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnBorrowBooks;
        private System.Windows.Forms.ToolStripMenuItem deweyDecimalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnReturnBooks;
        private System.Windows.Forms.ToolStripMenuItem listOfBorrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidaysToolStripMenuItem;
    }
}