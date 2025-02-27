namespace CPTCProjectFinanceTracker
{
    partial class HomeScreen
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
            label1 = new Label();
            btnAddIncome = new Button();
            btnAddExpense = new Button();
            txtCurrentBalance = new TextBox();
            grpBxTransactions = new GroupBox();
            dgvRecentTransactions = new DataGridView();
            label2 = new Label();
            grpBxTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 46);
            label1.TabIndex = 0;
            label1.Text = "Current Balance: ";
            // 
            // btnAddIncome
            // 
            btnAddIncome.FlatAppearance.BorderSize = 4;
            btnAddIncome.FlatStyle = FlatStyle.Flat;
            btnAddIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddIncome.Location = new Point(1495, 1116);
            btnAddIncome.Margin = new Padding(4, 3, 4, 3);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(322, 73);
            btnAddIncome.TabIndex = 2;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // btnAddExpense
            // 
            btnAddExpense.FlatAppearance.BorderSize = 4;
            btnAddExpense.FlatStyle = FlatStyle.Flat;
            btnAddExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpense.Location = new Point(1836, 1116);
            btnAddExpense.Margin = new Padding(4, 3, 4, 3);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(339, 73);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Enabled = false;
            txtCurrentBalance.Location = new Point(360, 135);
            txtCurrentBalance.Margin = new Padding(4, 3, 4, 3);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(860, 52);
            txtCurrentBalance.TabIndex = 6;
            // 
            // grpBxTransactions
            // 
            grpBxTransactions.Controls.Add(dgvRecentTransactions);
            grpBxTransactions.FlatStyle = FlatStyle.Popup;
            grpBxTransactions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxTransactions.Location = new Point(29, 206);
            grpBxTransactions.Margin = new Padding(4, 3, 4, 3);
            grpBxTransactions.Name = "grpBxTransactions";
            grpBxTransactions.Padding = new Padding(4, 3, 4, 3);
            grpBxTransactions.Size = new Size(2150, 870);
            grpBxTransactions.TabIndex = 7;
            grpBxTransactions.TabStop = false;
            grpBxTransactions.Text = "Recent Transaction";
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.AllowUserToAddRows = false;
            dgvRecentTransactions.AllowUserToDeleteRows = false;
            dgvRecentTransactions.AllowUserToOrderColumns = true;
            dgvRecentTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.Dock = DockStyle.Fill;
            dgvRecentTransactions.Location = new Point(4, 48);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvRecentTransactions.RowHeadersWidth = 62;
            dgvRecentTransactions.Size = new Size(2142, 819);
            dgvRecentTransactions.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 25);
            label2.Name = "label2";
            label2.Size = new Size(308, 67);
            label2.TabIndex = 8;
            label2.Text = "Home Form";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2208, 1221);
            Controls.Add(label2);
            Controls.Add(grpBxTransactions);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnAddExpense);
            Controls.Add(btnAddIncome);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeScreen";
            Text = "Finance Tracker";
            grpBxTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddIncome;
        private Button btnAddExpense;
        private TextBox txtCurrentBalance;
        private GroupBox grpBxTransactions;
        private Label label2;
    }
}
