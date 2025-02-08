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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 90);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 0;
            label1.Text = "Current Balance: ";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(102, 566);
            btnAddIncome.Margin = new Padding(5, 5, 5, 5);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(260, 107);
            btnAddIncome.TabIndex = 2;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(666, 566);
            btnAddExpense.Margin = new Padding(5, 5, 5, 5);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(260, 107);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Enabled = false;
            txtCurrentBalance.Location = new Point(294, 90);
            txtCurrentBalance.Margin = new Padding(5, 5, 5, 5);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(252, 47);
            txtCurrentBalance.TabIndex = 6;
            // 
            // grpBxTransactions
            // 
            grpBxTransactions.Location = new Point(66, 243);
            grpBxTransactions.Margin = new Padding(5, 5, 5, 5);
            grpBxTransactions.Name = "grpBxTransactions";
            grpBxTransactions.Padding = new Padding(5, 5, 5, 5);
            grpBxTransactions.Size = new Size(507, 266);
            grpBxTransactions.TabIndex = 7;
            grpBxTransactions.TabStop = false;
            grpBxTransactions.Text = "Recent Transactions";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 738);
            Controls.Add(grpBxTransactions);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnAddExpense);
            Controls.Add(btnAddIncome);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "HomeScreen";
            Text = "Finance Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddIncome;
        private Button btnAddExpense;
        private TextBox txtCurrentBalance;
        private GroupBox grpBxTransactions;
    }
}
