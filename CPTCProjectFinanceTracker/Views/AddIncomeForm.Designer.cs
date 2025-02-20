namespace CPTCProjectFinanceTracker
{
    partial class AddIncomeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddIncomeTransaction = new Button();
            label5 = new Label();
            dtpIncomeDate = new DateTimePicker();
            txtbxIncomeAmount = new TextBox();
            txtbxIncomeDescription = new TextBox();
            cmboBxIncomeCategory = new ComboBox();
            btnManageCategories = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 67);
            label1.TabIndex = 0;
            label1.Text = "Income Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(54, 179);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 46);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(54, 274);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 46);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(54, 384);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(213, 46);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // btnAddIncomeTransaction
            // 
            btnAddIncomeTransaction.FlatAppearance.BorderSize = 4;
            btnAddIncomeTransaction.FlatStyle = FlatStyle.Flat;
            btnAddIncomeTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddIncomeTransaction.Location = new Point(316, 579);
            btnAddIncomeTransaction.Margin = new Padding(5);
            btnAddIncomeTransaction.Name = "btnAddIncomeTransaction";
            btnAddIncomeTransaction.Size = new Size(496, 112);
            btnAddIncomeTransaction.TabIndex = 4;
            btnAddIncomeTransaction.Text = "Add Item to Income";
            btnAddIncomeTransaction.UseVisualStyleBackColor = true;
            btnAddIncomeTransaction.Click += btnAddIncomeTransaction_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 474);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 46);
            label5.TabIndex = 5;
            label5.Text = "Date:";
            // 
            // dtpIncomeDate
            // 
            dtpIncomeDate.Format = DateTimePickerFormat.Short;
            dtpIncomeDate.Location = new Point(330, 474);
            dtpIncomeDate.Margin = new Padding(5);
            dtpIncomeDate.Name = "dtpIncomeDate";
            dtpIncomeDate.Size = new Size(274, 47);
            dtpIncomeDate.TabIndex = 4;
            // 
            // txtbxIncomeAmount
            // 
            txtbxIncomeAmount.Location = new Point(330, 274);
            txtbxIncomeAmount.Margin = new Padding(5);
            txtbxIncomeAmount.Name = "txtbxIncomeAmount";
            txtbxIncomeAmount.Size = new Size(252, 47);
            txtbxIncomeAmount.TabIndex = 2;
            // 
            // txtbxIncomeDescription
            // 
            txtbxIncomeDescription.Location = new Point(330, 379);
            txtbxIncomeDescription.Margin = new Padding(5);
            txtbxIncomeDescription.Name = "txtbxIncomeDescription";
            txtbxIncomeDescription.Size = new Size(813, 47);
            txtbxIncomeDescription.TabIndex = 3;
            // 
            // cmboBxIncomeCategory
            // 
            cmboBxIncomeCategory.FormattingEnabled = true;
            cmboBxIncomeCategory.Location = new Point(326, 185);
            cmboBxIncomeCategory.Name = "cmboBxIncomeCategory";
            cmboBxIncomeCategory.Size = new Size(302, 49);
            cmboBxIncomeCategory.TabIndex = 1;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(647, 185);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(339, 49);
            btnManageCategories.TabIndex = 11;
            btnManageCategories.Text = "⚙ Manage Categories ";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // AddIncomeForm
            // 
            AcceptButton = btnAddIncomeTransaction;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 738);
            Controls.Add(btnManageCategories);
            Controls.Add(cmboBxIncomeCategory);
            Controls.Add(txtbxIncomeDescription);
            Controls.Add(txtbxIncomeAmount);
            Controls.Add(dtpIncomeDate);
            Controls.Add(label5);
            Controls.Add(btnAddIncomeTransaction);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "AddIncomeForm";
            Text = "Add Income Transaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddIncomeTransaction;
        private Label label5;
        private DateTimePicker dtpIncomeDate;
        private TextBox txtbxIncomeAmount;
        private TextBox txtbxIncomeDescription;
        private ComboBox cmboBxIncomeCategory;
        private Button btnManageCategories;
    }
}