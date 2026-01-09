namespace SupermarketGoodsManangerSystem
{
    partial class InquireGoods
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btn_Inquire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProductName.Location = new System.Drawing.Point(158, 58);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(165, 35);
            this.txtProductName.TabIndex = 1;
            // 
            // btn_Inquire
            // 
            this.btn_Inquire.Location = new System.Drawing.Point(127, 145);
            this.btn_Inquire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Inquire.Name = "btn_Inquire";
            this.btn_Inquire.Size = new System.Drawing.Size(89, 33);
            this.btn_Inquire.TabIndex = 3;
            this.btn_Inquire.Text = "确认";
            this.btn_Inquire.UseVisualStyleBackColor = true;
            this.btn_Inquire.Click += new System.EventHandler(this.btn_Inquire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "商品名称 : ";
            // 
            // InquireGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Inquire);
            this.Controls.Add(this.txtProductName);
            this.Name = "InquireGoods";
            this.Text = "查询商品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btn_Inquire;
        private System.Windows.Forms.Label label1;
    }
}