namespace BPCHS___Library_Management_System
{
    partial class ucBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBook));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bnAddBook = new System.Windows.Forms.Button();
            this.bnEditBook = new System.Windows.Forms.Button();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bnNewOld = new System.Windows.Forms.Button();
            this.bnAvail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(761, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 20);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bnAddBook
            // 
            this.bnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAddBook.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAddBook.Location = new System.Drawing.Point(653, 3);
            this.bnAddBook.Name = "bnAddBook";
            this.bnAddBook.Size = new System.Drawing.Size(131, 30);
            this.bnAddBook.TabIndex = 14;
            this.bnAddBook.Text = "Add Book";
            this.bnAddBook.UseVisualStyleBackColor = true;
            this.bnAddBook.Click += new System.EventHandler(this.bnAddBook_Click);
            // 
            // bnEditBook
            // 
            this.bnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnEditBook.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEditBook.Location = new System.Drawing.Point(792, 3);
            this.bnEditBook.Name = "bnEditBook";
            this.bnEditBook.Size = new System.Drawing.Size(131, 30);
            this.bnEditBook.TabIndex = 15;
            this.bnEditBook.Text = "Edit Book";
            this.bnEditBook.UseVisualStyleBackColor = true;
            this.bnEditBook.Click += new System.EventHandler(this.bnEditBook_Click);
            // 
            // dgBook
            // 
            this.dgBook.AllowUserToAddRows = false;
            this.dgBook.AllowUserToDeleteRows = false;
            this.dgBook.AllowUserToResizeColumns = false;
            this.dgBook.AllowUserToResizeRows = false;
            this.dgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBook.BackgroundColor = System.Drawing.Color.White;
            this.dgBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBook.Location = new System.Drawing.Point(0, 78);
            this.dgBook.Name = "dgBook";
            this.dgBook.ReadOnly = true;
            this.dgBook.RowHeadersVisible = false;
            this.dgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBook.Size = new System.Drawing.Size(926, 347);
            this.dgBook.TabIndex = 27;
            this.dgBook.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bnPrint);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 40);
            this.panel2.TabIndex = 29;
            // 
            // bnPrint
            // 
            this.bnPrint.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPrint.Location = new System.Drawing.Point(6, 4);
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(94, 28);
            this.bnPrint.TabIndex = 31;
            this.bnPrint.Text = "Print";
            this.bnPrint.UseVisualStyleBackColor = true;
            this.bnPrint.Click += new System.EventHandler(this.bnPrint_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(706, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 38);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.bnNewOld);
            this.panel3.Controls.Add(this.bnAvail);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.bnAddBook);
            this.panel3.Controls.Add(this.bnEditBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 36);
            this.panel3.TabIndex = 30;
            // 
            // bnNewOld
            // 
            this.bnNewOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnNewOld.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNewOld.Location = new System.Drawing.Point(445, 3);
            this.bnNewOld.Name = "bnNewOld";
            this.bnNewOld.Size = new System.Drawing.Size(96, 30);
            this.bnNewOld.TabIndex = 33;
            this.bnNewOld.Text = "Change to";
            this.bnNewOld.UseVisualStyleBackColor = true;
            this.bnNewOld.Click += new System.EventHandler(this.bnNewOld_Click);
            // 
            // bnAvail
            // 
            this.bnAvail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAvail.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAvail.Location = new System.Drawing.Point(549, 3);
            this.bnAvail.Name = "bnAvail";
            this.bnAvail.Size = new System.Drawing.Size(96, 30);
            this.bnAvail.TabIndex = 32;
            this.bnAvail.Text = "Change to";
            this.bnAvail.UseVisualStyleBackColor = true;
            this.bnAvail.Click += new System.EventHandler(this.bnAvail_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, -382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(926, 461);
            this.Load += new System.EventHandler(this.UcBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bnAddBook;
        private System.Windows.Forms.Button bnEditBook;
        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnNewOld;
        private System.Windows.Forms.Button bnAvail;

    }
}
