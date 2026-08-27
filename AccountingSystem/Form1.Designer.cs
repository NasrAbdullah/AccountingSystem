namespace AccountingSystem
{
    partial class MainForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnSpend = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.المشترياتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.المصروفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.panellogo);
            this.panelSidebar.Controls.Add(this.btnMain);
            this.panelSidebar.Controls.Add(this.btnClients);
            this.panelSidebar.Controls.Add(this.btnVendor);
            this.panelSidebar.Controls.Add(this.btnProduct);
            this.panelSidebar.Controls.Add(this.btnsales);
            this.panelSidebar.Controls.Add(this.btnBuy);
            this.panelSidebar.Controls.Add(this.btnSpend);
            this.panelSidebar.Controls.Add(this.btnArticle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(868, 28);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(213, 557);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Akhbar MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(2, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "النظام المحاسبي الذكي";
            // 
            // btnArticle
            // 
            this.btnArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnArticle.Location = new System.Drawing.Point(0, 459);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(213, 49);
            this.btnArticle.TabIndex = 0;
            this.btnArticle.Text = "التقارير";
            this.btnArticle.UseVisualStyleBackColor = false;
            // 
            // btnSpend
            // 
            this.btnSpend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSpend.Location = new System.Drawing.Point(0, 400);
            this.btnSpend.Name = "btnSpend";
            this.btnSpend.Size = new System.Drawing.Size(213, 49);
            this.btnSpend.TabIndex = 0;
            this.btnSpend.Text = "المصروفات";
            this.btnSpend.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuy.Location = new System.Drawing.Point(0, 344);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(213, 49);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "المشتريات";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsales.Location = new System.Drawing.Point(0, 292);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(213, 49);
            this.btnsales.TabIndex = 0;
            this.btnsales.Text = "المبيعات";
            this.btnsales.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProduct.Location = new System.Drawing.Point(0, 237);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(213, 49);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "المنتجات";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnVendor
            // 
            this.btnVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVendor.Location = new System.Drawing.Point(0, 183);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(213, 49);
            this.btnVendor.TabIndex = 0;
            this.btnVendor.Text = "الموردون";
            this.btnVendor.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClients.Location = new System.Drawing.Point(0, 133);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(213, 49);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "العملاء";
            this.btnClients.UseVisualStyleBackColor = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMain.Location = new System.Drawing.Point(0, 83);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(213, 49);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "الرئيسية";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(868, 557);
            this.panelContent.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.المنتجاتToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.الموردونToolStripMenuItem,
            this.التقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // المنتجاتToolStripMenuItem
            // 
            this.المنتجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المبيعاتToolStripMenuItem1,
            this.المشترياتToolStripMenuItem1,
            this.المصروفاتToolStripMenuItem});
            this.المنتجاتToolStripMenuItem.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.المنتجاتToolStripMenuItem.Name = "المنتجاتToolStripMenuItem";
            this.المنتجاتToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.المنتجاتToolStripMenuItem.Text = "المنتجات";
            // 
            // المبيعاتToolStripMenuItem1
            // 
            this.المبيعاتToolStripMenuItem1.Name = "المبيعاتToolStripMenuItem1";
            this.المبيعاتToolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.المبيعاتToolStripMenuItem1.Text = "المبيعات";
            // 
            // المشترياتToolStripMenuItem1
            // 
            this.المشترياتToolStripMenuItem1.Name = "المشترياتToolStripMenuItem1";
            this.المشترياتToolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.المشترياتToolStripMenuItem1.Text = "المشتريات";
            // 
            // المصروفاتToolStripMenuItem
            // 
            this.المصروفاتToolStripMenuItem.Name = "المصروفاتToolStripMenuItem";
            this.المصروفاتToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.المصروفاتToolStripMenuItem.Text = "المصروفات";
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // الموردونToolStripMenuItem
            // 
            this.الموردونToolStripMenuItem.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.الموردونToolStripMenuItem.Name = "الموردونToolStripMenuItem";
            this.الموردونToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.الموردونToolStripMenuItem.Text = "الموردون";
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.lblTitle);
            this.panellogo.Location = new System.Drawing.Point(6, 3);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 69);
            this.panellogo.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 585);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام محاسبي";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnSpend;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem المشترياتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem المصروفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.Panel panellogo;
    }
}

