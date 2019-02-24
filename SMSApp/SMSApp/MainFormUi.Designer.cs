namespace SMSApp
{
    partial class MainFormUi
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
            this.CategoryButton = new System.Windows.Forms.Button();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.StockINButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.DateWiseSearchButton = new System.Windows.Forms.Button();
            this.StockInSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(13, 13);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryButton.TabIndex = 0;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(94, 13);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyButton.TabIndex = 0;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(175, 13);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(75, 23);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item";
            this.ItemButton.UseVisualStyleBackColor = true;
            // 
            // StockINButton
            // 
            this.StockINButton.Location = new System.Drawing.Point(256, 13);
            this.StockINButton.Name = "StockINButton";
            this.StockINButton.Size = new System.Drawing.Size(75, 23);
            this.StockINButton.TabIndex = 0;
            this.StockINButton.Text = "Stock In";
            this.StockINButton.UseVisualStyleBackColor = true;
            this.StockINButton.Click += new System.EventHandler(this.StockINButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(337, 13);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(75, 23);
            this.StockOutButton.TabIndex = 0;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            // 
            // DateWiseSearchButton
            // 
            this.DateWiseSearchButton.Location = new System.Drawing.Point(499, 13);
            this.DateWiseSearchButton.Name = "DateWiseSearchButton";
            this.DateWiseSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DateWiseSearchButton.TabIndex = 0;
            this.DateWiseSearchButton.Text = "Search2";
            this.DateWiseSearchButton.UseVisualStyleBackColor = true;
            // 
            // StockInSearchButton
            // 
            this.StockInSearchButton.Location = new System.Drawing.Point(418, 12);
            this.StockInSearchButton.Name = "StockInSearchButton";
            this.StockInSearchButton.Size = new System.Drawing.Size(75, 23);
            this.StockInSearchButton.TabIndex = 0;
            this.StockInSearchButton.Text = "Search";
            this.StockInSearchButton.UseVisualStyleBackColor = true;
            // 
            // MainFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 50);
            this.Controls.Add(this.StockInSearchButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.DateWiseSearchButton);
            this.Controls.Add(this.StockINButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.CategoryButton);
            this.Name = "MainFormUi";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button StockINButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button DateWiseSearchButton;
        private System.Windows.Forms.Button StockInSearchButton;
    }
}

