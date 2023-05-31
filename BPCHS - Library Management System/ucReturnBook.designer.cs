namespace BPCHS___Library_Management_System
{
    partial class ucReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgBorrower = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbRemainingFines = new System.Windows.Forms.Label();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotalFines = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalDaysBorrowed = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgBookReturn = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bnLost = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookReturn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgBorrower);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(517, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 419);
            this.panel1.TabIndex = 0;
            // 
            // dgBorrower
            // 
            this.dgBorrower.AllowUserToAddRows = false;
            this.dgBorrower.AllowUserToDeleteRows = false;
            this.dgBorrower.AllowUserToResizeColumns = false;
            this.dgBorrower.AllowUserToResizeRows = false;
            this.dgBorrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrower.BackgroundColor = System.Drawing.Color.White;
            this.dgBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBorrower.Location = new System.Drawing.Point(0, 31);
            this.dgBorrower.Name = "dgBorrower";
            this.dgBorrower.ReadOnly = true;
            this.dgBorrower.RowHeadersVisible = false;
            this.dgBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBorrower.Size = new System.Drawing.Size(292, 175);
            this.dgBorrower.TabIndex = 2;
            this.dgBorrower.SelectionChanged += new System.EventHandler(this.dgBorrower_SelectionChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 31);
            this.panel5.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(151, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borrower";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 213);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbRemainingFines);
            this.panel7.Controls.Add(this.lbTotalPayment);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.lbTotalFines);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lbTotalDaysBorrowed);
            this.panel7.Controls.Add(this.lbChange);
            this.panel7.Controls.Add(this.lbBalance);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtCash);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(5, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 188);
            this.panel7.TabIndex = 6;
            // 
            // lbRemainingFines
            // 
            this.lbRemainingFines.BackColor = System.Drawing.Color.Transparent;
            this.lbRemainingFines.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemainingFines.ForeColor = System.Drawing.Color.Black;
            this.lbRemainingFines.Location = new System.Drawing.Point(181, 90);
            this.lbRemainingFines.Name = "lbRemainingFines";
            this.lbRemainingFines.Size = new System.Drawing.Size(89, 16);
            this.lbRemainingFines.TabIndex = 331;
            this.lbRemainingFines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPayment.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayment.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPayment.Location = new System.Drawing.Point(181, 66);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(89, 16);
            this.lbTotalPayment.TabIndex = 330;
            this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(41, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 329;
            this.label14.Text = "Remaining Fines";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(53, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 328;
            this.label13.Text = "Total Payment";
            // 
            // lbTotalFines
            // 
            this.lbTotalFines.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalFines.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFines.ForeColor = System.Drawing.Color.Black;
            this.lbTotalFines.Location = new System.Drawing.Point(181, 42);
            this.lbTotalFines.Name = "lbTotalFines";
            this.lbTotalFines.Size = new System.Drawing.Size(89, 16);
            this.lbTotalFines.TabIndex = 327;
            this.lbTotalFines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(74, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 326;
            this.label11.Text = "Total Fines";
            // 
            // lbTotalDaysBorrowed
            // 
            this.lbTotalDaysBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalDaysBorrowed.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDaysBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lbTotalDaysBorrowed.Location = new System.Drawing.Point(181, 18);
            this.lbTotalDaysBorrowed.Name = "lbTotalDaysBorrowed";
            this.lbTotalDaysBorrowed.Size = new System.Drawing.Size(89, 16);
            this.lbTotalDaysBorrowed.TabIndex = 324;
            this.lbTotalDaysBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.Color.Transparent;
            this.lbChange.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.Black;
            this.lbChange.Location = new System.Drawing.Point(184, 162);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(89, 16);
            this.lbChange.TabIndex = 321;
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbBalance.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.ForeColor = System.Drawing.Color.Black;
            this.lbBalance.Location = new System.Drawing.Point(184, 138);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(89, 16);
            this.lbBalance.TabIndex = 320;
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(92, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Change";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(89, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(149, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Php";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(184, 111);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(89, 22);
            this.txtCash.TabIndex = 6;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyDown);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Days Borrowed";
            // 
            // dgBookReturn
            // 
            this.dgBookReturn.AllowUserToAddRows = false;
            this.dgBookReturn.AllowUserToDeleteRows = false;
            this.dgBookReturn.AllowUserToResizeColumns = false;
            this.dgBookReturn.AllowUserToResizeRows = false;
            this.dgBookReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgBookReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBookReturn.Location = new System.Drawing.Point(0, 47);
            this.dgBookReturn.MultiSelect = false;
            this.dgBookReturn.Name = "dgBookReturn";
            this.dgBookReturn.ReadOnly = true;
            this.dgBookReturn.RowHeadersVisible = false;
            this.dgBookReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBookReturn.Size = new System.Drawing.Size(517, 387);
            this.dgBookReturn.TabIndex = 1;
            this.dgBookReturn.SelectionChanged += new System.EventHandler(this.dgBookReturn_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 47);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.bnLost);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 32);
            this.panel3.TabIndex = 3;
            // 
            // bnLost
            // 
            this.bnLost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnLost.Location = new System.Drawing.Point(318, 3);
            this.bnLost.Name = "bnLost";
            this.bnLost.Size = new System.Drawing.Size(193, 23);
            this.bnLost.TabIndex = 0;
            this.bnLost.Text = "Mark as Lost";
            this.bnLost.UseVisualStyleBackColor = true;
            this.bnLost.Click += new System.EventHandler(this.bnLost_Click);
            // 
            // ucReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgBookReturn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucReturnBook";
            this.Size = new System.Drawing.Size(809, 466);
            this.Load += new System.EventHandler(this.ucReturnBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookReturn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgBorrower;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgBookReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bnLost;
        private System.Windows.Forms.Label lbTotalDaysBorrowed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalFines;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbRemainingFines;
        private System.Windows.Forms.Label lbTotalPayment;
    }
}
