namespace CPTCProjectFinanceTracker.Views
{
    partial class UserSelectionForm
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
            cbxUserSelection = new ComboBox();
            btnEnterApp = new Button();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 156);
            label1.Name = "label1";
            label1.Size = new Size(273, 60);
            label1.TabIndex = 0;
            label1.Text = "Select a User";
            // 
            // cbxUserSelection
            // 
            cbxUserSelection.FormattingEnabled = true;
            cbxUserSelection.Location = new Point(329, 271);
            cbxUserSelection.Name = "cbxUserSelection";
            cbxUserSelection.Size = new Size(308, 33);
            cbxUserSelection.TabIndex = 1;
            // 
            // btnEnterApp
            // 
            btnEnterApp.Location = new Point(392, 404);
            btnEnterApp.Name = "btnEnterApp";
            btnEnterApp.Size = new Size(169, 63);
            btnEnterApp.TabIndex = 2;
            btnEnterApp.Text = "Enter the Application";
            btnEnterApp.UseVisualStyleBackColor = true;
            btnEnterApp.Click += btnEnterApp_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(117, 39);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(159, 72);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add a User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(392, 39);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(159, 72);
            btnUpdateUser.TabIndex = 4;
            btnUpdateUser.Text = "Update a User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(675, 39);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(159, 72);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Delete a User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // UserSelectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 609);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnEnterApp);
            Controls.Add(cbxUserSelection);
            Controls.Add(label1);
            Name = "UserSelectionForm";
            Text = "UserSelectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxUserSelection;
        private Button btnEnterApp;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
    }
}