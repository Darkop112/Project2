namespace FinalProject
{
    partial class ManageSalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView salesDataGridView;
        private Button editButton, deleteButton, addButton, searchButton;
        private TextBox searchTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            salesDataGridView = new DataGridView();
            editButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            manageSalesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // salesDataGridView
            // 
            salesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGridView.Location = new Point(14, 55);
            salesDataGridView.Margin = new Padding(3, 4, 3, 4);
            salesDataGridView.Name = "salesDataGridView";
            salesDataGridView.RowHeadersWidth = 51;
            salesDataGridView.Size = new Size(887, 467);
            salesDataGridView.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Location = new Point(14, 543);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(86, 31);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(106, 543);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(199, 543);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(815, 16);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(86, 31);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(579, 16);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(228, 27);
            searchTextBox.TabIndex = 5;
            // 
            // manageSalesButton
            // 
            manageSalesButton.Location = new Point(300, 545);
            manageSalesButton.Name = "manageSalesButton";
            manageSalesButton.Size = new Size(94, 29);
            manageSalesButton.TabIndex = 6;
            manageSalesButton.Text = "Manage";
            manageSalesButton.UseVisualStyleBackColor = true;
            manageSalesButton.Click += manageSalesButton_Click;
            // 
            // ManageSalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 584);
            ControlBox = false;
            Controls.Add(manageSalesButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(salesDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageSalesForm";
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button manageSalesButton;
    }
}
