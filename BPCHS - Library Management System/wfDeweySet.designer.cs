namespace BPCHS___Library_Management_System
{
    partial class wfDeweySet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDeweySet));
            this.bnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.bnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(221, 76);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 3;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(66, 20);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(88, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(140, 76);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(75, 23);
            this.bnSave.TabIndex = 2;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(164, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(190, 20);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(88, 20);
            this.txtTo.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(66, 48);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(212, 20);
            this.txtClass.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // wfDeweySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BPCHS___Library_Management_System.Properties.Resources.bago;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 111);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDeweySet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dewey Decimal System";
            this.Load += new System.EventHandler(this.wfDeweySet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
    }
}