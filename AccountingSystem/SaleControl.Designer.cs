namespace AccountingSystem
{
    partial class SaleControl
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.panelInvoiceInfo = new System.Windows.Forms.Panel();
            this.lblIDate = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceNumberValue = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelProductSearch = new System.Windows.Forms.Panel();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.panelInvoiceSummary = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelInvoiceInfo.SuspendLayout();
            this.panelProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnNewInvoice);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelHeader.Size = new System.Drawing.Size(736, 75);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(504, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "المبيعات والفواتير";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNewInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.Location = new System.Drawing.Point(298, 14);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(135, 42);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.Text = "فاتورة جديد";
            this.btnNewInvoice.UseVisualStyleBackColor = false;
            this.btnNewInvoice.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelInvoiceInfo
            // 
            this.panelInvoiceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelInvoiceInfo.Controls.Add(this.comboBox1);
            this.panelInvoiceInfo.Controls.Add(this.lblInvoiceNumberValue);
            this.panelInvoiceInfo.Controls.Add(this.lblInvoiceNumber);
            this.panelInvoiceInfo.Controls.Add(this.lblDateValue);
            this.panelInvoiceInfo.Controls.Add(this.lblCustomer);
            this.panelInvoiceInfo.Controls.Add(this.lblIDate);
            this.panelInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInvoiceInfo.Location = new System.Drawing.Point(0, 75);
            this.panelInvoiceInfo.Name = "panelInvoiceInfo";
            this.panelInvoiceInfo.Size = new System.Drawing.Size(736, 94);
            this.panelInvoiceInfo.TabIndex = 1;
            // 
            // lblIDate
            // 
            this.lblIDate.AutoSize = true;
            this.lblIDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDate.Location = new System.Drawing.Point(609, 61);
            this.lblIDate.Name = "lblIDate";
            this.lblIDate.Size = new System.Drawing.Size(60, 19);
            this.lblIDate.TabIndex = 0;
            this.lblIDate.Text = ":التاريخ";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(578, 19);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(101, 19);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = ":رقم الفاتورة";
            // 
            // lblInvoiceNumberValue
            // 
            this.lblInvoiceNumberValue.AutoSize = true;
            this.lblInvoiceNumberValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumberValue.Location = new System.Drawing.Point(473, 19);
            this.lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            this.lblInvoiceNumberValue.Size = new System.Drawing.Size(86, 19);
            this.lblInvoiceNumberValue.TabIndex = 0;
            this.lblInvoiceNumberValue.Text = "INV-0001";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateValue.Location = new System.Drawing.Point(481, 61);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(87, 19);
            this.lblDateValue.TabIndex = 0;
            this.lblDateValue.Text = "2026/9/3";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(276, 14);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 19);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = ":العميل";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nasr",
            "Oday",
            "Ahmed"});
            this.comboBox1.Location = new System.Drawing.Point(102, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // panelProductSearch
            // 
            this.panelProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelProductSearch.Controls.Add(this.btnAdd);
            this.panelProductSearch.Controls.Add(this.label1);
            this.panelProductSearch.Controls.Add(this.txtProductSearch);
            this.panelProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductSearch.Location = new System.Drawing.Point(0, 169);
            this.panelProductSearch.Name = "panelProductSearch";
            this.panelProductSearch.Size = new System.Drawing.Size(736, 75);
            this.panelProductSearch.TabIndex = 2;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(280, 23);
            this.txtProductSearch.Multiline = true;
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductSearch.Size = new System.Drawing.Size(315, 35);
            this.txtProductSearch.TabIndex = 0;
            this.txtProductSearch.Text = "ابحث عن المنتج او امسح الباركود";
            this.txtProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = ":مربع البحث";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = " + إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(0, 244);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.Size = new System.Drawing.Size(736, 312);
            this.dgvInvoiceItems.TabIndex = 3;
            // 
            // panelInvoiceSummary
            // 
            this.panelInvoiceSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelInvoiceSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInvoiceSummary.Location = new System.Drawing.Point(0, 244);
            this.panelInvoiceSummary.Name = "panelInvoiceSummary";
            this.panelInvoiceSummary.Size = new System.Drawing.Size(736, 28);
            this.panelInvoiceSummary.TabIndex = 4;
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInvoiceSummary);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.panelProductSearch);
            this.Controls.Add(this.panelInvoiceInfo);
            this.Controls.Add(this.panelHeader);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(736, 556);
            this.Load += new System.EventHandler(this.SaleControl_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInvoiceInfo.ResumeLayout(false);
            this.panelInvoiceInfo.PerformLayout();
            this.panelProductSearch.ResumeLayout(false);
            this.panelProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelInvoiceInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblInvoiceNumberValue;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblIDate;
        private System.Windows.Forms.Panel panelProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Panel panelInvoiceSummary;
    }
}
