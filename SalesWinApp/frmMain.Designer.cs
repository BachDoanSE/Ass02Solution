namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SALES MANAGEMENT";
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderManagement.Location = new System.Drawing.Point(88, 133);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(220, 36);
            this.btnOrderManagement.TabIndex = 1;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemberManagement.Location = new System.Drawing.Point(454, 133);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Size = new System.Drawing.Size(220, 36);
            this.btnMemberManagement.TabIndex = 2;
            this.btnMemberManagement.Text = "Member Management";
            this.btnMemberManagement.UseVisualStyleBackColor = true;
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductManagement.Location = new System.Drawing.Point(270, 245);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(220, 36);
            this.btnProductManagement.TabIndex = 3;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(632, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.btnMemberManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnOrderManagement;
        private Button btnMemberManagement;
        private Button btnProductManagement;
        private Button btnLogout;
    }
}