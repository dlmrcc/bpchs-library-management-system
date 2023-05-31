namespace BPCHS___Library_Management_System
{
    partial class wfPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPayment));
            this.dgBookReturn = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.bnLost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBorrower = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookReturn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dgBookReturn.Size = new System.Drawing.Size(896, 480);
            this.dgBookReturn.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lbTotalPayment);
            this.panel3.Controls.Add(this.bnLost);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 32);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(734, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.AutoSize = true;
            this.lbTotalPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayment.Location = new System.Drawing.Point(8, 9);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(45, 16);
            this.lbTotalPayment.TabIndex = 1;
            this.lbTotalPayment.Text = "label6";
            // 
            // bnLost
            // 
            this.bnLost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLost.Location = new System.Drawing.Point(812, 3);
            this.bnLost.Name = "bnLost";
            this.bnLost.Size = new System.Drawing.Size(79, 25);
            this.bnLost.TabIndex = 0;
            this.bnLost.Text = "Close";
            this.bnLost.UseVisualStyleBackColor = true;
            this.bnLost.Click += new System.EventHandler(this.bnLost_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbUser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbBorrower);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtFrom);
            this.panel2.Controls.Add(this.dtTo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 47);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "User";
            // 
            // cbUser
            // 
            this.cbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(173, 10);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(164, 24);
            this.cbUser.TabIndex = 7;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Borrower";
            // 
            // cbBorrower
            // 
            this.cbBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBorrower.FormattingEnabled = true;
            this.cbBorrower.Location = new System.Drawing.Point(399, 10);
            this.cbBorrower.Name = "cbBorrower";
            this.cbBorrower.Size = new System.Drawing.Size(164, 24);
            this.cbBorrower.TabIndex = 5;
            this.cbBorrower.SelectedIndexChanged += new System.EventHandler(this.cbBorrower_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "MMM. dd, yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(602, 11);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(128, 22);
            this.dtFrom.TabIndex = 2;
            this.dtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFrom_KeyDown);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CustomFormat = "MMM. dd, yyyy";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(755, 11);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(128, 22);
            this.dtTo.TabIndex = 1;
            this.dtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // wfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.dgBookReturn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfPayment";
            this.Load += new System.EventHandler(this.wfPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookReturn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBookReturn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bnLost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBorrower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalPayment;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}