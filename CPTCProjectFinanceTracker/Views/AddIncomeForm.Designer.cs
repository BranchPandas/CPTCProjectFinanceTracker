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
            txtbxIncomeName = new TextBox();
            txtbxIncomeAmount = new TextBox();
            txtbxIncomeDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 26);
            label1.Name = "label1";
            label1.Size = new Size(202, 41);
            label1.TabIndex = 0;
            label1.Text = "Income Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(32, 167);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(32, 234);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // btnAddIncomeTransaction
            // 
            btnAddIncomeTransaction.FlatAppearance.BorderSize = 4;
            btnAddIncomeTransaction.FlatStyle = FlatStyle.Flat;
            btnAddIncomeTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddIncomeTransaction.Location = new Point(186, 353);
            btnAddIncomeTransaction.Name = "btnAddIncomeTransaction";
            btnAddIncomeTransaction.Size = new Size(292, 68);
            btnAddIncomeTransaction.TabIndex = 4;
            btnAddIncomeTransaction.Text = "Add Item to Income";
            btnAddIncomeTransaction.UseVisualStyleBackColor = true;
            btnAddIncomeTransaction.Click += btnAddIncomeTransaction_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 289);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 5;
            label5.Text = "Date:";
            // 
            // dtpIncomeDate
            // 
            dtpIncomeDate.Format = DateTimePickerFormat.Short;
            dtpIncomeDate.Location = new Point(194, 289);
            dtpIncomeDate.Name = "dtpIncomeDate";
            dtpIncomeDate.Size = new Size(163, 31);
            dtpIncomeDate.TabIndex = 6;
            // 
            // txtbxIncomeName
            // 
            txtbxIncomeName.Location = new Point(194, 114);
            txtbxIncomeName.Name = "txtbxIncomeName";
            txtbxIncomeName.Size = new Size(268, 31);
            txtbxIncomeName.TabIndex = 7;
            // 
            // txtbxIncomeAmount
            // 
            txtbxIncomeAmount.Location = new Point(194, 167);
            txtbxIncomeAmount.Name = "txtbxIncomeAmount";
            txtbxIncomeAmount.Size = new Size(150, 31);
            txtbxIncomeAmount.TabIndex = 8;
            // 
            // txtbxIncomeDescription
            // 
            txtbxIncomeDescription.Location = new Point(194, 231);
            txtbxIncomeDescription.Name = "txtbxIncomeDescription";
            txtbxIncomeDescription.Size = new Size(480, 31);
            txtbxIncomeDescription.TabIndex = 9;
            // 
            // AddIncomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(txtbxIncomeDescription);
            Controls.Add(txtbxIncomeAmount);
            Controls.Add(txtbxIncomeName);
            Controls.Add(dtpIncomeDate);
            Controls.Add(label5);
            Controls.Add(btnAddIncomeTransaction);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddIncomeForm";
            Text = "AddIncomeForm";
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
        private TextBox txtbxIncomeName;
        private TextBox txtbxIncomeAmount;
        private TextBox txtbxIncomeDescription;
    }
}