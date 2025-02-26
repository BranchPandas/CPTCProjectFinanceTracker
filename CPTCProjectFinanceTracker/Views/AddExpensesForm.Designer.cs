namespace CPTCProjectFinanceTracker
{
    partial class AddExpensesForm
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
            txtbxExpenseDescription = new TextBox();
            txtbxExpenseAmount = new TextBox();
            dtpExpenseDate = new DateTimePicker();
            btnAddExpenseTransaction = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmboBxExpenseCategory = new ComboBox();
            btnManageCategories = new Button();
            SuspendLayout();
            // 
            // txtbxExpenseDescription
            // 
            txtbxExpenseDescription.Location = new Point(384, 322);
            txtbxExpenseDescription.Name = "txtbxExpenseDescription";
            txtbxExpenseDescription.Size = new Size(885, 47);
            txtbxExpenseDescription.TabIndex = 3;
            // 
            // txtbxExpenseAmount
            // 
            txtbxExpenseAmount.Location = new Point(388, 216);
            txtbxExpenseAmount.Name = "txtbxExpenseAmount";
            txtbxExpenseAmount.Size = new Size(250, 47);
            txtbxExpenseAmount.TabIndex = 2;
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Format = DateTimePickerFormat.Short;
            dtpExpenseDate.Location = new Point(384, 436);
            dtpExpenseDate.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(250, 47);
            dtpExpenseDate.TabIndex = 4;
            dtpExpenseDate.Value = new DateTime(2025, 2, 7, 13, 18, 10, 0);
            // 
            // btnAddExpenseTransaction
            // 
            btnAddExpenseTransaction.FlatAppearance.BorderSize = 4;
            btnAddExpenseTransaction.FlatStyle = FlatStyle.Flat;
            btnAddExpenseTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddExpenseTransaction.Location = new Point(384, 530);
            btnAddExpenseTransaction.Name = "btnAddExpenseTransaction";
            btnAddExpenseTransaction.Size = new Size(457, 93);
            btnAddExpenseTransaction.TabIndex = 4;
            btnAddExpenseTransaction.Text = "Add Item to Expenses";
            btnAddExpenseTransaction.UseVisualStyleBackColor = true;
            btnAddExpenseTransaction.Click += btnAddExpenseTransaction_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(75, 116);
            label1.Name = "label1";
            label1.Size = new Size(174, 46);
            label1.TabIndex = 5;
            label1.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(71, 322);
            label2.Name = "label2";
            label2.Size = new Size(213, 46);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(75, 216);
            label3.Name = "label3";
            label3.Size = new Size(160, 46);
            label3.TabIndex = 7;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(75, 436);
            label4.Name = "label4";
            label4.Size = new Size(103, 46);
            label4.TabIndex = 8;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(422, 21);
            label5.Name = "label5";
            label5.Size = new Size(380, 67);
            label5.TabIndex = 9;
            label5.Text = "Expenses Form";
            // 
            // cmboBxExpenseCategory
            // 
            cmboBxExpenseCategory.DisplayMember = "CategoryName";
            cmboBxExpenseCategory.FormattingEnabled = true;
            cmboBxExpenseCategory.Location = new Point(384, 116);
            cmboBxExpenseCategory.Name = "cmboBxExpenseCategory";
            cmboBxExpenseCategory.Size = new Size(302, 49);
            cmboBxExpenseCategory.TabIndex = 1;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(718, 116);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(339, 49);
            btnManageCategories.TabIndex = 10;
            btnManageCategories.Text = "⚙ Manage Categories ";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // AddExpensesForm
            // 
            AcceptButton = btnAddExpenseTransaction;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 635);
            Controls.Add(btnManageCategories);
            Controls.Add(cmboBxExpenseCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddExpenseTransaction);
            Controls.Add(dtpExpenseDate);
            Controls.Add(txtbxExpenseAmount);
            Controls.Add(txtbxExpenseDescription);
            Name = "AddExpensesForm";
            Text = "Add Expense Transaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbxExpenseDescription;
        private TextBox txtbxExpenseAmount;
        private DateTimePicker dtpExpenseDate;
        private Button btnAddExpenseTransaction;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmboBxExpenseCategory;
        private Button btnManageCategories;
    }
}