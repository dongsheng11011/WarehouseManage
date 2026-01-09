namespace SupermarketGoodsManangerSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本地服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsManager = new System.Windows.Forms.ToolStripMenuItem();
            this.统计商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过期商品统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品种类管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.本地服务ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1371, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加用户ToolStripMenuItem.Text = "添加新用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 本地服务ToolStripMenuItem
            // 
            this.本地服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoodsManager,
            this.统计商品ToolStripMenuItem,
            this.过期商品统计ToolStripMenuItem,
            this.商品种类管理ToolStripMenuItem});
            this.本地服务ToolStripMenuItem.Name = "本地服务ToolStripMenuItem";
            this.本地服务ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.本地服务ToolStripMenuItem.Text = "本地服务";
            // 
            // GoodsManager
            // 
            this.GoodsManager.Name = "GoodsManager";
            this.GoodsManager.Size = new System.Drawing.Size(182, 26);
            this.GoodsManager.Text = "商品信息管理";
            this.GoodsManager.Click += new System.EventHandler(this.GoodsMananger_Click);
            // 
            // 统计商品ToolStripMenuItem
            // 
            this.统计商品ToolStripMenuItem.Name = "统计商品ToolStripMenuItem";
            this.统计商品ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.统计商品ToolStripMenuItem.Text = "商品统计";
            this.统计商品ToolStripMenuItem.Click += new System.EventHandler(this.统计商品ToolStripMenuItem_Click);
            // 
            // 过期商品统计ToolStripMenuItem
            // 
            this.过期商品统计ToolStripMenuItem.Name = "过期商品统计ToolStripMenuItem";
            this.过期商品统计ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.过期商品统计ToolStripMenuItem.Text = "过期商品统计";
            this.过期商品统计ToolStripMenuItem.Click += new System.EventHandler(this.过期商品统计ToolStripMenuItem_Click);
            // 
            // 商品种类管理ToolStripMenuItem
            // 
            this.商品种类管理ToolStripMenuItem.Name = "商品种类管理ToolStripMenuItem";
            this.商品种类管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.商品种类管理ToolStripMenuItem.Text = "商品种类管理";
            this.商品种类管理ToolStripMenuItem.Click += new System.EventHandler(this.商品种类管理ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "超市商品管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本地服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsManager;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过期商品统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品种类管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}

