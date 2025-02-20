namespace CPTCProjectFinanceTracker.Views
{
    partial class formManageCategories
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "test", "test2", "test 3" });
            listBox1.Location = new Point(24, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(747, 414);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 503);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Create or Update by selecting from the list";
            textBox1.Size = new Size(747, 47);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 2;
            label1.Text = "Expense Categories";
            // 
            // button1
            // 
            button1.Location = new Point(24, 562);
            button1.Name = "button1";
            button1.Size = new Size(747, 49);
            button1.TabIndex = 3;
            button1.Text = "Create Category";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(24, 624);
            button2.Name = "button2";
            button2.Size = new Size(747, 49);
            button2.TabIndex = 4;
            button2.Text = "Delete Category";
            button2.UseVisualStyleBackColor = true;
            // 
            // formManageCategories
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 685);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "formManageCategories";
            Text = "Manage Expense Categories ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}