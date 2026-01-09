namespace shopping.view
{
    partial class ExpiredGoods
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labProductName = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            this.labAllPrice = new System.Windows.Forms.Label();
            this.viewProduct = new System.Windows.Forms.DataGridView();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.过期天数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labProductName);
            this.panel1.Controls.Add(this.labDay);
            this.panel1.Controls.Add(this.labAllPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1124, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 748);
            this.panel1.TabIndex = 4;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("宋体", 14F);
            this.labProductName.Location = new System.Drawing.Point(6, 68);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(130, 24);
            this.labProductName.TabIndex = 9;
            this.labProductName.Text = "商品名称：";
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Font = new System.Drawing.Font("宋体", 14F);
            this.labDay.Location = new System.Drawing.Point(6, 107);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(130, 24);
            this.labDay.TabIndex = 8;
            this.labDay.Text = "过期天数：";
            // 
            // labAllPrice
            // 
            this.labAllPrice.AutoSize = true;
            this.labAllPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.labAllPrice.Location = new System.Drawing.Point(6, 220);
            this.labAllPrice.Name = "labAllPrice";
            this.labAllPrice.Size = new System.Drawing.Size(106, 24);
            this.labAllPrice.TabIndex = 5;
            this.labAllPrice.Text = "总价值：";
            // 
            // viewProduct
            // 
            this.viewProduct.AllowUserToAddRows = false;
            this.viewProduct.AllowUserToDeleteRows = false;
            this.viewProduct.AllowUserToResizeColumns = false;
            this.viewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductTypeName});
            this.viewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProduct.Location = new System.Drawing.Point(0, 0);
            this.viewProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewProduct.Name = "viewProduct";
            this.viewProduct.ReadOnly = true;
            this.viewProduct.RowHeadersVisible = false;
            this.viewProduct.RowHeadersWidth = 62;
            this.viewProduct.RowTemplate.Height = 23;
            this.viewProduct.Size = new System.Drawing.Size(1124, 748);
            this.viewProduct.TabIndex = 5;
            // 
            // ProductTypeName
            // 
            this.ProductTypeName.DataPropertyName = "ProductTypeName";
            this.ProductTypeName.HeaderText = "类型";
            this.ProductTypeName.MinimumWidth = 8;
            this.ProductTypeName.Name = "ProductTypeName";
            this.ProductTypeName.ReadOnly = true;
            this.ProductTypeName.Width = 150;
            // 
            // ExpireGridView
            // 
            this.ExpireGridView.AllowUserToAddRows = false;
            this.ExpireGridView.AllowUserToDeleteRows = false;
            this.ExpireGridView.AllowUserToResizeColumns = false;
            this.ExpireGridView.AllowUserToResizeRows = false;
            this.ExpireGridView.AutoGenerateColumns = false;
            this.ExpireGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpireGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.商品名称,
            this.supplierNameDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.shelfLifeDaysDataGridViewTextBoxColumn,
            this.过期天数,
            this.售价,
            this.库存});
            this.ExpireGridView.DataSource = this.productBindingSource;
            this.ExpireGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpireGridView.Location = new System.Drawing.Point(0, 0);
            this.ExpireGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpireGridView.Name = "ExpireGridView";
            this.ExpireGridView.ReadOnly = true;
            this.ExpireGridView.RowHeadersVisible = false;
            this.ExpireGridView.RowHeadersWidth = 62;
            this.ExpireGridView.RowTemplate.Height = 23;
            this.ExpireGridView.Size = new System.Drawing.Size(1124, 748);
            this.ExpireGridView.TabIndex = 6;
            this.ExpireGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpireGridView_CellClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(shopping.entity.Product);
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "商品编码";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "ProductName";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.MinimumWidth = 6;
            this.商品名称.Name = "商品名称";
            this.商品名称.ReadOnly = true;
            this.商品名称.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "厂商";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shelfLifeDaysDataGridViewTextBoxColumn
            // 
            this.shelfLifeDaysDataGridViewTextBoxColumn.DataPropertyName = "ShelfLifeDays";
            this.shelfLifeDaysDataGridViewTextBoxColumn.HeaderText = "保质期";
            this.shelfLifeDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shelfLifeDaysDataGridViewTextBoxColumn.Name = "shelfLifeDaysDataGridViewTextBoxColumn";
            this.shelfLifeDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfLifeDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // 过期天数
            // 
            this.过期天数.DataPropertyName = "ExpirationDays";
            this.过期天数.HeaderText = "过期天数";
            this.过期天数.MinimumWidth = 6;
            this.过期天数.Name = "过期天数";
            this.过期天数.ReadOnly = true;
            this.过期天数.Width = 125;
            // 
            // 售价
            // 
            this.售价.DataPropertyName = "RetailPrice";
            this.售价.HeaderText = "售价";
            this.售价.MinimumWidth = 6;
            this.售价.Name = "售价";
            this.售价.ReadOnly = true;
            this.售价.Width = 125;
            // 
            // 库存
            // 
            this.库存.DataPropertyName = "ProductNumber";
            this.库存.HeaderText = "库存";
            this.库存.MinimumWidth = 6;
            this.库存.Name = "库存";
            this.库存.ReadOnly = true;
            this.库存.Width = 125;
            // 
            // ExpiredGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 748);
            this.Controls.Add(this.ExpireGridView);
            this.Controls.Add(this.viewProduct);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExpiredGoods";
            this.Text = "ExpiredGoods";
            this.Load += new System.EventHandler(this.ExpiredGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labAllPrice;
        private System.Windows.Forms.DataGridView viewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeName;
        private System.Windows.Forms.DataGridView ExpireGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 过期天数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存;
    }
}