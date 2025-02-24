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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 0;
            label1.Text = "Current Balance: ";
            // 
            // btnAddIncome
            // 
            btnAddIncome.FlatAppearance.BorderSize = 4;
            btnAddIncome.FlatStyle = FlatStyle.Flat;
            btnAddIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddIncome.Location = new Point(72, 459);
            btnAddIncome.Margin = new Padding(4, 3, 4, 3);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(184, 73);
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
            btnAddExpense.Location = new Point(470, 459);
            btnAddExpense.Margin = new Padding(4, 3, 4, 3);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(184, 73);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Enabled = false;
            txtCurrentBalance.Location = new Point(270, 135);
            txtCurrentBalance.Margin = new Padding(4, 3, 4, 3);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(179, 34);
            txtCurrentBalance.TabIndex = 6;
            // 
            // grpBxTransactions
            // 
            grpBxTransactions.FlatStyle = FlatStyle.Popup;
            grpBxTransactions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxTransactions.Location = new Point(29, 206);
            grpBxTransactions.Margin = new Padding(4, 3, 4, 3);
            grpBxTransactions.Name = "grpBxTransactions";
            grpBxTransactions.Padding = new Padding(4, 3, 4, 3);
            grpBxTransactions.Size = new Size(420, 204);
            grpBxTransactions.TabIndex = 7;
            grpBxTransactions.TabStop = false;
            grpBxTransactions.Text = "Recent Transaction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 26);
            label2.Name = "label2";
            label2.Size = new Size(183, 41);
            label2.TabIndex = 8;
            label2.Text = "Home Form";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 605);
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
