namespace AppleShopForms.View
{
    partial class SearchForm
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
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGridView
            // 
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.PriceColumn,
            this.ColorColumn});
            this.productsGridView.Location = new System.Drawing.Point(12, 27);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersWidth = 62;
            this.productsGridView.RowTemplate.Height = 28;
            this.productsGridView.Size = new System.Drawing.Size(875, 362);
            this.productsGridView.TabIndex = 0;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 8;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 150;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Товар";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 150;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 8;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 150;
            // 
            // ColorColumn
            // 
            this.ColorColumn.DataPropertyName = "Color";
            this.ColorColumn.HeaderText = "Цвет";
            this.ColorColumn.MinimumWidth = 8;
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.Width = 150;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(763, 420);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(124, 45);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 505);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.productsGridView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.Button openButton;
    }
}