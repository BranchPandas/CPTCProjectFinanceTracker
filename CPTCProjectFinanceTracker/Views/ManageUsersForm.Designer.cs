namespace CPTCProjectFinanceTracker.Views
{
    partial class ManageUsersForm
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
            txtbxUserName = new TextBox();
            txtbxUserEmail = new TextBox();
            txtbxUserPassword = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 102);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 197);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 300);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Password: ";
            // 
            // txtbxUserName
            // 
            txtbxUserName.Location = new Point(186, 98);
            txtbxUserName.Name = "txtbxUserName";
            txtbxUserName.Size = new Size(247, 31);
            txtbxUserName.TabIndex = 3;
            // 
            // txtbxUserEmail
            // 
            txtbxUserEmail.Location = new Point(189, 192);
            txtbxUserEmail.Name = "txtbxUserEmail";
            txtbxUserEmail.Size = new Size(244, 31);
            txtbxUserEmail.TabIndex = 4;
            // 
            // txtbxUserPassword
            // 
            txtbxUserPassword.Location = new Point(191, 297);
            txtbxUserPassword.Name = "txtbxUserPassword";
            txtbxUserPassword.Size = new Size(242, 31);
            txtbxUserPassword.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(573, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 63);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(573, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 63);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtbxUserPassword);
            Controls.Add(txtbxUserEmail);
            Controls.Add(txtbxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxUserName;
        private TextBox txtbxUserEmail;
        private TextBox txtbxUserPassword;
        private Button btnAdd;
        private Button btnUpdate;
    }
}