using System.Windows.Forms;

namespace SupermarketGoodsManangerSystem
{
    partial class StatisticalGoods
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
            this.labMinPrice = new System.Windows.Forms.Label();
            this.labMaxPrice = new System.Windows.Forms.Label();
            this.labtotalType = new System.Windows.Forms.Label();
            this.labAvgPrice = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.viewProduct = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labMinPrice);
            this.panel1.Controls.Add(this.labMaxPrice);
            this.panel1.Controls.Add(this.labtotalType);
            this.panel1.Controls.Add(this.labAvgPrice);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1264, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 898);
            this.panel1.TabIndex = 1;
            // 
            // labMinPrice
            // 
            this.labMinPrice.AutoSize = true;
            this.labMinPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.labMinPrice.Location = new System.Drawing.Point(35, 456);
            this.labMinPrice.Name = "labMinPrice";
            this.labMinPrice.Size = new System.Drawing.Size(138, 28);
            this.labMinPrice.TabIndex = 6;
            this.labMinPrice.Text = "最低价格:";
            // 
            // labMaxPrice
            // 
            this.labMaxPrice.AutoSize = true;
            this.labMaxPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.labMaxPrice.Location = new System.Drawing.Point(35, 409);
            this.labMaxPrice.Name = "labMaxPrice";
            this.labMaxPrice.Size = new System.Drawing.Size(138, 28);
            this.labMaxPrice.TabIndex = 5;
            this.labMaxPrice.Text = "最高价格:";
            // 
            // labtotalType
            // 
            this.labtotalType.AutoSize = true;
            this.labtotalType.Font = new System.Drawing.Font("宋体", 14F);
            this.labtotalType.Location = new System.Drawing.Point(7, 538);
            this.labtotalType.Name = "labtotalType";
            this.labtotalType.Size = new System.Drawing.Size(166, 28);
            this.labtotalType.TabIndex = 4;
            this.labtotalType.Text = "商品种类数:";
            // 
            // labAvgPrice
            // 
            this.labAvgPrice.AutoSize = true;
            this.labAvgPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.labAvgPrice.Location = new System.Drawing.Point(35, 497);
            this.labAvgPrice.Name = "labAvgPrice";
            this.labAvgPrice.Size = new System.Drawing.Size(138, 28);
            this.labAvgPrice.TabIndex = 3;
            this.labAvgPrice.Text = "平均价格:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(46, 694);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(195, 74);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询商品";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // viewProduct
            // 
            this.viewProduct.AllowUserToAddRows = false;
            this.viewProduct.AllowUserToDeleteRows = false;
            this.viewProduct.AllowUserToResizeColumns = false;
            this.viewProduct.AllowUserToResizeRows = false;
            this.viewProduct.AutoGenerateColumns = false;
            this.viewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.ProductTypeName,
            this.supplierNameDataGridViewTextBoxColumn,
            this.retailPriceDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.shelfLifeDaysDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn});
            this.viewProduct.DataSource = this.productBindingSource;
            this.viewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProduct.Location = new System.Drawing.Point(0, 0);
            this.viewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.viewProduct.Name = "viewProduct";
            this.viewProduct.ReadOnly = true;
            this.viewProduct.RowHeadersVisible = false;
            this.viewProduct.RowHeadersWidth = 62;
            this.viewProduct.RowTemplate.Height = 23;
            this.viewProduct.Size = new System.Drawing.Size(1264, 898);
            this.viewProduct.TabIndex = 2;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "商品编码";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 125;
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
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "厂商";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // retailPriceDataGridViewTextBoxColumn
            // 
            this.retailPriceDataGridViewTextBoxColumn.DataPropertyName = "RetailPrice";
            this.retailPriceDataGridViewTextBoxColumn.HeaderText = "售价";
            this.retailPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.retailPriceDataGridViewTextBoxColumn.Name = "retailPriceDataGridViewTextBoxColumn";
            this.retailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shelfLifeDaysDataGridViewTextBoxColumn
            // 
            this.shelfLifeDaysDataGridViewTextBoxColumn.DataPropertyName = "ShelfLifeDays";
            this.shelfLifeDaysDataGridViewTextBoxColumn.HeaderText = "保质期";
            this.shelfLifeDaysDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shelfLifeDaysDataGridViewTextBoxColumn.Name = "shelfLifeDaysDataGridViewTextBoxColumn";
            this.shelfLifeDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfLifeDaysDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "库存";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(shopping.entity.Product);
            // 
            // StatisticalGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 898);
            this.Controls.Add(this.viewProduct);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticalGoods";
            this.Text = "统计商品";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatisticalGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView viewProduct;
        private System.Windows.Forms.Label labAvgPrice;
        private System.Windows.Forms.Label labtotalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductTypeName;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn retailPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shelfLifeDaysDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private Label labMinPrice;
        private Label labMaxPrice;
    }
}