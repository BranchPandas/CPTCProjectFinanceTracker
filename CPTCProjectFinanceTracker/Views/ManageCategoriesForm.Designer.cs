namespace CPTCProjectFinanceTracker.Views
{
    partial class formManageCategories
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
            lstBxCategories = new ListBox();
            txtBxCategoryName = new TextBox();
            label1 = new Label();
            btnUpsertCategory = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lstBxCategories
            // 
            lstBxCategories.FormattingEnabled = true;
            lstBxCategories.Items.AddRange(new object[] { "test", "test2", "test 3" });
            lstBxCategories.Location = new Point(24, 67);
            lstBxCategories.Name = "lstBxCategories";
            lstBxCategories.ScrollAlwaysVisible = true;
            lstBxCategories.Size = new Size(747, 414);
            lstBxCategories.TabIndex = 0;
            // 
            // txtBxCategoryName
            // 
            txtBxCategoryName.Location = new Point(24, 503);
            txtBxCategoryName.Name = "txtBxCategoryName";
            txtBxCategoryName.PlaceholderText = "Create or Update by selecting from the list";
            txtBxCategoryName.Size = new Size(747, 47);
            txtBxCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 2;
            label1.Text = "Expense Categories";
            // 
            // btnUpsertCategory
            // 
            btnUpsertCategory.Location = new Point(24, 562);
            btnUpsertCategory.Name = "btnUpsertCategory";
            btnUpsertCategory.Size = new Size(747, 49);
            btnUpsertCategory.TabIndex = 3;
            btnUpsertCategory.Text = "Create Category";
            btnUpsertCategory.UseVisualStyleBackColor = true;
            btnUpsertCategory.Click += btnUpsertCategory_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(24, 624);
            button2.Name = "button2";
            button2.Size = new Size(747, 49);
            button2.TabIndex = 4;
            button2.Text = "Delete Category";
            button2.UseVisualStyleBackColor = true;
            // 
            // formManageCategories
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 685);
            Controls.Add(button2);
            Controls.Add(btnUpsertCategory);
            Controls.Add(label1);
            Controls.Add(txtBxCategoryName);
            Controls.Add(lstBxCategories);
            Name = "formManageCategories";
            Text = "Manage Expense Categories ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBxCategories;
        private TextBox txtBxCategoryName;
        private Label label1;
        private Button btnUpsertCategory;
        private Button button2;
    }
}