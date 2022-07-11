namespace SalesWinApp.Admin.AdminProduct
{
    partial class frmMemberManagement
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtUnitslnStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 203);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(160, 203);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(435, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(92, 253);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.Size = new System.Drawing.Size(749, 233);
            this.dgvProductList.TabIndex = 21;
            this.dgvProductList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentDoubleClick);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(658, 54);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(183, 27);
            this.txtWeight.TabIndex = 20;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(658, 102);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(183, 27);
            this.txtUnitPrice.TabIndex = 19;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(234, 102);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(184, 27);
            this.txtCategoryID.TabIndex = 18;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(234, 54);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(184, 27);
            this.txtProductID.TabIndex = 17;
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(92, 105);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(84, 20);
            this.lbCategoryID.TabIndex = 16;
            this.lbCategoryID.Text = "CategoryID";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(532, 57);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 15;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(532, 105);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(68, 20);
            this.lbUnitPrice.TabIndex = 14;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(92, 57);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 13;
            this.lbProductID.Text = "Product ID";
            // 
            // txtUnitslnStock
            // 
            this.txtUnitslnStock.Location = new System.Drawing.Point(658, 149);
            this.txtUnitslnStock.Name = "txtUnitslnStock";
            this.txtUnitslnStock.Size = new System.Drawing.Size(183, 27);
            this.txtUnitslnStock.TabIndex = 29;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(234, 149);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 27);
            this.txtProductName.TabIndex = 28;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(92, 152);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 27;
            this.lbProductName.Text = "Product Name";
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(532, 152);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(90, 20);
            this.lbUnitslnStock.TabIndex = 26;
            this.lbUnitslnStock.Text = "UnitslnStock";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 530);
            this.Controls.Add(this.txtUnitslnStock);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbUnitslnStock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbProductID);
            this.Name = "frmMemberManagement";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnSearch;
        private Button btnInsert;
        private Button btnBack;
        private DataGridView dgvProductList;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtCategoryID;
        private TextBox txtProductID;
        private Label lbCategoryID;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbProductID;
        private TextBox txtUnitslnStock;
        private TextBox txtProductName;
        private Label lbProductName;
        private Label lbUnitslnStock;
    }
}