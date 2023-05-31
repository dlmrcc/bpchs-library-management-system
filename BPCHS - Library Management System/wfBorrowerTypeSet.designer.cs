namespace BPCHS___Library_Management_System
{
    partial class wfBorrowerTypeSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBorrowerTypeSet));
            this.label1 = new System.Windows.Forms.Label();
            this.cbBorrowerType = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtLimitDays = new System.Windows.Forms.TextBox();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFinesType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower Type";
            // 
            // cbBorrowerType
            // 
            this.cbBorrowerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorrowerType.FormattingEnabled = true;
            this.cbBorrowerType.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cbBorrowerType.Location = new System.Drawing.Point(156, 68);
            this.cbBorrowerType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBorrowerType.Name = "cbBorrowerType";
            this.cbBorrowerType.Size = new System.Drawing.Size(214, 22);
            this.cbBorrowerType.TabIndex = 0;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(156, 98);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(214, 20);
            this.txtRate.TabIndex = 1;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Borrow Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fines Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Limit (Days)";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(156, 126);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(214, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtLimitDays
            // 
            this.txtLimitDays.Location = new System.Drawing.Point(156, 182);
            this.txtLimitDays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLimitDays.Name = "txtLimitDays";
            this.txtLimitDays.Size = new System.Drawing.Size(214, 20);
            this.txtLimitDays.TabIndex = 4;
            this.txtLimitDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimitDays_KeyPress);
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.Font = new System.Drawing.Font("Bodoni MT Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(312, 213);
            this.bnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(72, 27);
            this.bnCancel.TabIndex = 6;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Font = new System.Drawing.Font("Bodoni MT Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(234, 213);
            this.bnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(70, 27);
            this.bnSave.TabIndex = 5;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Borrower Type Settings";
            // 
            // cbFinesType
            // 
            this.cbFinesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinesType.FormattingEnabled = true;
            this.cbFinesType.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbFinesType.Location = new System.Drawing.Point(156, 153);
            this.cbFinesType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFinesType.Name = "cbFinesType";
            this.cbFinesType.Size = new System.Drawing.Size(214, 22);
            this.cbFinesType.TabIndex = 3;
            // 
            // wfBorrowerTypeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 252);
            this.Controls.Add(this.cbFinesType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.txtLimitDays);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.cbBorrowerType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bodoni MT Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBorrowerTypeSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower Type Settings";
            this.Load += new System.EventHandler(this.BorrowerTypeSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBorrowerType;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtLimitDays;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFinesType;
    }
}