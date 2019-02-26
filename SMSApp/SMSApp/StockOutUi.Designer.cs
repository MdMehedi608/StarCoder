namespace SMSApp
{
    partial class StockOutUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.abailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LostButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stockOutQuantityTextBox);
            this.groupBox1.Controls.Add(this.abailableQuantityTextBox);
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(213, 197);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Out Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reorder Level";
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(120, 159);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(169, 20);
            this.stockOutQuantityTextBox.TabIndex = 3;
            // 
            // abailableQuantityTextBox
            // 
            this.abailableQuantityTextBox.Location = new System.Drawing.Point(120, 124);
            this.abailableQuantityTextBox.Name = "abailableQuantityTextBox";
            this.abailableQuantityTextBox.Size = new System.Drawing.Size(169, 20);
            this.abailableQuantityTextBox.TabIndex = 3;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(120, 90);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(169, 20);
            this.reorderLevelTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource1;
            this.itemComboBox.DisplayMember = "ItemName";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(120, 55);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(169, 21);
            this.itemComboBox.TabIndex = 0;
            this.itemComboBox.ValueMember = "ID";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(SMSApp.Models.Item);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(120, 23);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(169, 21);
            this.companyComboBox.TabIndex = 0;
            this.companyComboBox.ValueMember = "ID";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMSApp.Models.Company);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SMSApp.Models.Item);
            // 
            // LostButton
            // 
            this.LostButton.Location = new System.Drawing.Point(321, 422);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(75, 23);
            this.LostButton.TabIndex = 2;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(159, 422);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 2;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(240, 422);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(75, 23);
            this.DamageButton.TabIndex = 2;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.CompanyID,
            this.ItemID,
            this.StockOutQuantity});
            this.dataGridView.Location = new System.Drawing.Point(23, 284);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(373, 123);
            this.dataGridView.TabIndex = 3;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.Width = 30;
            // 
            // CompanyID
            // 
            this.CompanyID.DataPropertyName = "CompanyID";
            this.CompanyID.HeaderText = "Company";
            this.CompanyID.Name = "CompanyID";
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item";
            this.ItemID.Name = "ItemID";
            // 
            // StockOutQuantity
            // 
            this.StockOutQuantity.DataPropertyName = "StockOutQuantity";
            this.StockOutQuantity.HeaderText = "Quantity";
            this.StockOutQuantity.Name = "StockOutQuantity";
            // 
            // StockOutUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 457);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOutUi";
            this.Text = "StockOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.TextBox abailableQuantityTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button LostButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutQuantity;
    }
}