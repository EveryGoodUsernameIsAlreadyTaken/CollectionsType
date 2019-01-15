namespace CollectionsTypeProject
{
    partial class Form1
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnHashT = new System.Windows.Forms.Button();
            this.btnLinkedL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(12, 113);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(160, 34);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List Type";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnStack
            // 
            this.btnStack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.Location = new System.Drawing.Point(12, 160);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(160, 34);
            this.btnStack.TabIndex = 1;
            this.btnStack.Text = "Stack Type";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(12, 207);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(160, 34);
            this.btnQueue.TabIndex = 2;
            this.btnQueue.Text = "Queue Type";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnDict
            // 
            this.btnDict.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDict.Location = new System.Drawing.Point(12, 254);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(160, 34);
            this.btnDict.TabIndex = 3;
            this.btnDict.Text = "Dictionary Type";
            this.btnDict.UseVisualStyleBackColor = true;
            this.btnDict.Click += new System.EventHandler(this.btnDict_Click);
            // 
            // btnHashT
            // 
            this.btnHashT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashT.Location = new System.Drawing.Point(12, 301);
            this.btnHashT.Name = "btnHashT";
            this.btnHashT.Size = new System.Drawing.Size(160, 34);
            this.btnHashT.TabIndex = 4;
            this.btnHashT.Text = "HashTable Type";
            this.btnHashT.UseVisualStyleBackColor = true;
            this.btnHashT.Click += new System.EventHandler(this.btnHashT_Click);
            // 
            // btnLinkedL
            // 
            this.btnLinkedL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkedL.Location = new System.Drawing.Point(12, 348);
            this.btnLinkedL.Name = "btnLinkedL";
            this.btnLinkedL.Size = new System.Drawing.Size(160, 34);
            this.btnLinkedL.TabIndex = 5;
            this.btnLinkedL.Text = "Linked List Type";
            this.btnLinkedL.UseVisualStyleBackColor = true;
            this.btnLinkedL.Click += new System.EventHandler(this.btnLinkedL_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Customer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(201, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.63576F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 270);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.CustFName,
            this.CustLName});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(1, 40);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomers.Size = new System.Drawing.Size(711, 229);
            this.dgvCustomers.TabIndex = 0;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "CustID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CustID.Width = 135;
            // 
            // CustFName
            // 
            this.CustFName.HeaderText = "First Name";
            this.CustFName.Name = "CustFName";
            this.CustFName.ReadOnly = true;
            this.CustFName.Width = 285;
            // 
            // CustLName
            // 
            this.CustLName.HeaderText = "Last Name";
            this.CustLName.Name = "CustLName";
            this.CustLName.ReadOnly = true;
            this.CustLName.Width = 290;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(711, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewCust
            // 
            this.btnNewCust.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.Location = new System.Drawing.Point(12, 66);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(160, 34);
            this.btnNewCust.TabIndex = 8;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 411);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLinkedL);
            this.Controls.Add(this.btnHashT);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnDict;
        private System.Windows.Forms.Button btnHashT;
        private System.Windows.Forms.Button btnLinkedL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustLName;
        private System.Windows.Forms.Button btnNewCust;
    }
}

