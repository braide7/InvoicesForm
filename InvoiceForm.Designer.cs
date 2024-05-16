namespace InvoicesComp
{
    partial class InvoiceForm
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
            this.rBtnName = new System.Windows.Forms.RadioButton();
            this.rBtnCustID = new System.Windows.Forms.RadioButton();
            this.rBtnInvID = new System.Windows.Forms.RadioButton();
            this.rBtnInvCost = new System.Windows.Forms.RadioButton();
            this.rTextLeft = new System.Windows.Forms.RichTextBox();
            this.rBtnInvoices = new System.Windows.Forms.RadioButton();
            this.rBtnInvSold = new System.Windows.Forms.RadioButton();
            this.rBtnInvCust = new System.Windows.Forms.RadioButton();
            this.rTextRight = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rBtnName
            // 
            this.rBtnName.AutoSize = true;
            this.rBtnName.Location = new System.Drawing.Point(69, 28);
            this.rBtnName.Name = "rBtnName";
            this.rBtnName.Size = new System.Drawing.Size(142, 17);
            this.rBtnName.TabIndex = 1;
            this.rBtnName.Text = "Customers by Last Name";
            this.rBtnName.UseVisualStyleBackColor = true;
            this.rBtnName.CheckedChanged += new System.EventHandler(this.rBtnName_CheckedChanged);
            // 
            // rBtnCustID
            // 
            this.rBtnCustID.AutoSize = true;
            this.rBtnCustID.Location = new System.Drawing.Point(69, 51);
            this.rBtnCustID.Name = "rBtnCustID";
            this.rBtnCustID.Size = new System.Drawing.Size(102, 17);
            this.rBtnCustID.TabIndex = 2;
            this.rBtnCustID.Text = "Customers by ID";
            this.rBtnCustID.UseVisualStyleBackColor = true;
            this.rBtnCustID.CheckedChanged += new System.EventHandler(this.rBtnCustID_CheckedChanged);
            // 
            // rBtnInvID
            // 
            this.rBtnInvID.AutoSize = true;
            this.rBtnInvID.Location = new System.Drawing.Point(69, 74);
            this.rBtnInvID.Name = "rBtnInvID";
            this.rBtnInvID.Size = new System.Drawing.Size(97, 17);
            this.rBtnInvID.TabIndex = 3;
            this.rBtnInvID.Text = "Inventory by ID";
            this.rBtnInvID.UseVisualStyleBackColor = true;
            this.rBtnInvID.CheckedChanged += new System.EventHandler(this.rBtnInvID_CheckedChanged);
            // 
            // rBtnInvCost
            // 
            this.rBtnInvCost.AutoSize = true;
            this.rBtnInvCost.Location = new System.Drawing.Point(69, 97);
            this.rBtnInvCost.Name = "rBtnInvCost";
            this.rBtnInvCost.Size = new System.Drawing.Size(106, 17);
            this.rBtnInvCost.TabIndex = 4;
            this.rBtnInvCost.Text = "Inventory by cost";
            this.rBtnInvCost.UseVisualStyleBackColor = true;
            this.rBtnInvCost.CheckedChanged += new System.EventHandler(this.rBtnInvCost_CheckedChanged);
            // 
            // rTextLeft
            // 
            this.rTextLeft.Location = new System.Drawing.Point(12, 120);
            this.rTextLeft.Name = "rTextLeft";
            this.rTextLeft.Size = new System.Drawing.Size(252, 318);
            this.rTextLeft.TabIndex = 4;
            this.rTextLeft.Text = "";
            // 
            // rBtnInvoices
            // 
            this.rBtnInvoices.AutoSize = true;
            this.rBtnInvoices.Location = new System.Drawing.Point(357, 18);
            this.rBtnInvoices.Name = "rBtnInvoices";
            this.rBtnInvoices.Size = new System.Drawing.Size(65, 17);
            this.rBtnInvoices.TabIndex = 5;
            this.rBtnInvoices.Text = "Invoices";
            this.rBtnInvoices.UseVisualStyleBackColor = true;
            this.rBtnInvoices.CheckedChanged += new System.EventHandler(this.rBtnInvoices_CheckedChanged);
            // 
            // rBtnInvSold
            // 
            this.rBtnInvSold.AutoSize = true;
            this.rBtnInvSold.Location = new System.Drawing.Point(479, 18);
            this.rBtnInvSold.Name = "rBtnInvSold";
            this.rBtnInvSold.Size = new System.Drawing.Size(93, 17);
            this.rBtnInvSold.TabIndex = 6;
            this.rBtnInvSold.Text = "Inventory Sold";
            this.rBtnInvSold.UseVisualStyleBackColor = true;
            this.rBtnInvSold.CheckedChanged += new System.EventHandler(this.rBtnInvSold_CheckedChanged);
            // 
            // rBtnInvCust
            // 
            this.rBtnInvCust.AutoSize = true;
            this.rBtnInvCust.Location = new System.Drawing.Point(607, 18);
            this.rBtnInvCust.Name = "rBtnInvCust";
            this.rBtnInvCust.Size = new System.Drawing.Size(121, 17);
            this.rBtnInvCust.TabIndex = 7;
            this.rBtnInvCust.Text = "Invoice by Customer";
            this.rBtnInvCust.UseVisualStyleBackColor = true;
            this.rBtnInvCust.CheckedChanged += new System.EventHandler(this.rBtnInvCust_CheckedChanged);
            // 
            // rTextRight
            // 
            this.rTextRight.Location = new System.Drawing.Point(317, 51);
            this.rTextRight.Name = "rTextRight";
            this.rTextRight.Size = new System.Drawing.Size(445, 387);
            this.rTextRight.TabIndex = 8;
            this.rTextRight.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer/Inventory";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTextRight);
            this.Controls.Add(this.rBtnInvCust);
            this.Controls.Add(this.rBtnInvSold);
            this.Controls.Add(this.rBtnInvoices);
            this.Controls.Add(this.rTextLeft);
            this.Controls.Add(this.rBtnInvCost);
            this.Controls.Add(this.rBtnInvID);
            this.Controls.Add(this.rBtnCustID);
            this.Controls.Add(this.rBtnName);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm by Braiden Pedersen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnName;
        private System.Windows.Forms.RadioButton rBtnCustID;
        private System.Windows.Forms.RadioButton rBtnInvID;
        private System.Windows.Forms.RadioButton rBtnInvCost;
        private System.Windows.Forms.RichTextBox rTextLeft;
        private System.Windows.Forms.RadioButton rBtnInvoices;
        private System.Windows.Forms.RadioButton rBtnInvSold;
        private System.Windows.Forms.RadioButton rBtnInvCust;
        private System.Windows.Forms.RichTextBox rTextRight;
        private System.Windows.Forms.Label label1;
    }
}

