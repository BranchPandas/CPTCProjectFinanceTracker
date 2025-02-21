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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 49);
            label1.Name = "label1";
            label1.Size = new Size(273, 60);
            label1.TabIndex = 0;
            label1.Text = "Select a User";
            // 
            // cbxUserSelection
            // 
            cbxUserSelection.FormattingEnabled = true;
            cbxUserSelection.Location = new Point(225, 164);
            cbxUserSelection.Name = "cbxUserSelection";
            cbxUserSelection.Size = new Size(308, 33);
            cbxUserSelection.TabIndex = 1;
            // 
            // btnEnterApp
            // 
            btnEnterApp.Location = new Point(288, 297);
            btnEnterApp.Name = "btnEnterApp";
            btnEnterApp.Size = new Size(169, 63);
            btnEnterApp.TabIndex = 2;
            btnEnterApp.Text = "Enter the Application";
            btnEnterApp.UseVisualStyleBackColor = true;
            btnEnterApp.Click += btnEnterApp_Click;
            // 
            // UserSelectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}