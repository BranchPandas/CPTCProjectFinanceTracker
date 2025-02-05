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
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Current Balance: ";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(60, 345);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(153, 65);
            btnAddIncome.TabIndex = 2;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(392, 345);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(153, 65);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Enabled = false;
            txtCurrentBalance.Location = new Point(173, 55);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(150, 31);
            txtCurrentBalance.TabIndex = 6;
            // 
            // grpBxTransactions
            // 
            grpBxTransactions.Location = new Point(39, 148);
            grpBxTransactions.Name = "grpBxTransactions";
            grpBxTransactions.Size = new Size(298, 162);
            grpBxTransactions.TabIndex = 7;
            grpBxTransactions.TabStop = false;
            grpBxTransactions.Text = "Recent Transactions";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(grpBxTransactions);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnAddExpense);
            Controls.Add(btnAddIncome);
            Controls.Add(label1);
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
