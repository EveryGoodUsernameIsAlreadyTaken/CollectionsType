namespace CollectionsTypeProject
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbAutoID = new System.Windows.Forms.CheckBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIDGenerate = new System.Windows.Forms.Button();
            this.btnCreateCust = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Customer";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(142, 61);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(406, 29);
            this.tbFirstName.TabIndex = 10;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(142, 115);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(406, 29);
            this.tbLastName.TabIndex = 11;
            // 
            // cbAutoID
            // 
            this.cbAutoID.AutoSize = true;
            this.cbAutoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoID.Location = new System.Drawing.Point(13, 13);
            this.cbAutoID.Name = "cbAutoID";
            this.cbAutoID.Size = new System.Drawing.Size(92, 19);
            this.cbAutoID.TabIndex = 12;
            this.cbAutoID.Text = "ID Generate";
            this.cbAutoID.UseVisualStyleBackColor = true;
            this.cbAutoID.CheckedChanged += new System.EventHandler(this.cbAutoID_CheckedChanged);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(65, 40);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(185, 29);
            this.tbID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnIDGenerate);
            this.panel1.Controls.Add(this.cbAutoID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Location = new System.Drawing.Point(22, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 101);
            this.panel1.TabIndex = 15;
            // 
            // btnIDGenerate
            // 
            this.btnIDGenerate.BackColor = System.Drawing.Color.Silver;
            this.btnIDGenerate.Enabled = false;
            this.btnIDGenerate.Location = new System.Drawing.Point(111, 9);
            this.btnIDGenerate.Name = "btnIDGenerate";
            this.btnIDGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnIDGenerate.TabIndex = 15;
            this.btnIDGenerate.Text = "Generate ID";
            this.btnIDGenerate.UseVisualStyleBackColor = false;
            this.btnIDGenerate.Click += new System.EventHandler(this.btnIDGenerate_Click);
            // 
            // btnCreateCust
            // 
            this.btnCreateCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCust.Location = new System.Drawing.Point(292, 296);
            this.btnCreateCust.Name = "btnCreateCust";
            this.btnCreateCust.Size = new System.Drawing.Size(170, 34);
            this.btnCreateCust.TabIndex = 16;
            this.btnCreateCust.Text = "Create New Customer";
            this.btnCreateCust.UseVisualStyleBackColor = true;
            this.btnCreateCust.Click += new System.EventHandler(this.btnCreateCust_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(468, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateCust);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.CheckBox cbAutoID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateCust;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIDGenerate;
    }
}