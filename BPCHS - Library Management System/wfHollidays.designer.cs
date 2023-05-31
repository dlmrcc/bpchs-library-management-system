namespace BPCHS___Library_Management_System
{
    partial class wfHollidays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfHollidays));
            this.bnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dAct = new System.Windows.Forms.DataGridView();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dAct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(467, 400);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 27);
            this.bnCancel.TabIndex = 0;
            this.bnCancel.Text = "Close";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activity";
            // 
            // txtAct
            // 
            this.txtAct.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAct.Location = new System.Drawing.Point(15, 333);
            this.txtAct.Multiline = true;
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(269, 56);
            this.txtAct.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MMM. dd, yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(61, 18);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(174, 27);
            this.dtFrom.TabIndex = 3;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dAct
            // 
            this.dAct.AllowUserToAddRows = false;
            this.dAct.AllowUserToDeleteRows = false;
            this.dAct.BackgroundColor = System.Drawing.Color.White;
            this.dAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dAct.Location = new System.Drawing.Point(12, 49);
            this.dAct.Name = "dAct";
            this.dAct.ReadOnly = true;
            this.dAct.RowHeadersVisible = false;
            this.dAct.Size = new System.Drawing.Size(530, 257);
            this.dAct.TabIndex = 4;
            // 
            // bnEdit
            // 
            this.bnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnEdit.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEdit.Location = new System.Drawing.Point(301, 400);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(75, 27);
            this.bnEdit.TabIndex = 5;
            this.bnEdit.Text = "Edit";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(384, 400);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(75, 27);
            this.bnSave.TabIndex = 6;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(290, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MMM. dd, yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(61, 44);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(174, 27);
            this.dtTo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // bnAdd
            // 
            this.bnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAdd.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdd.Location = new System.Drawing.Point(219, 400);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(75, 27);
            this.bnAdd.TabIndex = 8;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "School Activities";
            // 
            // cbSy
            // 
            this.cbSy.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSy.FormattingEnabled = true;
            this.cbSy.Location = new System.Drawing.Point(421, 16);
            this.cbSy.Name = "cbSy";
            this.cbSy.Size = new System.Drawing.Size(121, 27);
            this.cbSy.TabIndex = 12;
            this.cbSy.SelectedIndexChanged += new System.EventHandler(this.cbSy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "School Year";
            // 
            // wfHollidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.dAct);
            this.Controls.Add(this.txtAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfHollidays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Activities Form";
            this.Load += new System.EventHandler(this.wfHollidays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dAct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DataGridView dAct;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSy;
        private System.Windows.Forms.Label label5;
    }
}