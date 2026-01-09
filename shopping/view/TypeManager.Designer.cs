namespace shopping.view
{
    partial class TypeManager
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labTypeId = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.viewType = new System.Windows.Forms.DataGridView();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQuery.Location = new System.Drawing.Point(391, 241);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(166, 39);
            this.txtQuery.TabIndex = 4;
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("宋体", 14F);
            this.txtAdd.Location = new System.Drawing.Point(391, 295);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(166, 39);
            this.txtAdd.TabIndex = 7;
            // 
            // txtDel
            // 
            this.txtDel.Enabled = false;
            this.txtDel.Font = new System.Drawing.Font("宋体", 14F);
            this.txtDel.Location = new System.Drawing.Point(392, 349);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(165, 39);
            this.txtDel.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::shopping.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(563, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = global::shopping.Properties.Resources.query;
            this.btnQuery.Location = new System.Drawing.Point(563, 241);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(42, 42);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::shopping.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(563, 349);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(42, 42);
            this.btnDel.TabIndex = 3;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labTypeId
            // 
            this.labTypeId.AutoSize = true;
            this.labTypeId.Font = new System.Drawing.Font("宋体", 14F);
            this.labTypeId.Location = new System.Drawing.Point(382, 68);
            this.labTypeId.Name = "labTypeId";
            this.labTypeId.Size = new System.Drawing.Size(110, 28);
            this.labTypeId.TabIndex = 9;
            this.labTypeId.Text = "种类Id:";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("宋体", 14F);
            this.labType.Location = new System.Drawing.Point(382, 117);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(82, 28);
            this.labType.TabIndex = 10;
            this.labType.Text = "种类:";
            // 
            // viewType
            // 
            this.viewType.AllowUserToAddRows = false;
            this.viewType.AllowUserToDeleteRows = false;
            this.viewType.AllowUserToResizeColumns = false;
            this.viewType.AllowUserToResizeRows = false;
            this.viewType.AutoGenerateColumns = false;
            this.viewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIDDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.viewType.DataSource = this.productTypeBindingSource;
            this.viewType.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewType.EnableHeadersVisualStyles = false;
            this.viewType.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewType.Location = new System.Drawing.Point(0, 0);
            this.viewType.MultiSelect = false;
            this.viewType.Name = "viewType";
            this.viewType.ReadOnly = true;
            this.viewType.RowHeadersVisible = false;
            this.viewType.RowHeadersWidth = 62;
            this.viewType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewType.RowTemplate.Height = 30;
            this.viewType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewType.Size = new System.Drawing.Size(375, 530);
            this.viewType.TabIndex = 11;
            this.viewType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewType_CellClick);
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "种类Id";
            this.typeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "种类";
            this.typeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(shopping.entity.ProductType);
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("宋体", 14F);
            this.labId.Location = new System.Drawing.Point(481, 68);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 28);
            this.labId.TabIndex = 12;
            // 
            // TypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 530);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.viewType);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labTypeId);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnDel);
            this.Name = "TypeManager";
            this.Text = "商品种类管理";
            ((System.ComponentModel.ISupportInitialize)(this.viewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.Label labTypeId;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.DataGridView viewType;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labId;
    }
}