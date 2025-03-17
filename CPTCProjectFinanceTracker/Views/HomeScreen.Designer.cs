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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            label1 = new Label();
            btnAddIncome = new Button();
            btnAddExpense = new Button();
            txtCurrentBalance = new TextBox();
            grpBxTransactions = new GroupBox();
            dgvRecentTransactions = new DataGridView();
            label2 = new Label();
            toolStrip2 = new ToolStrip();
            toolStripDropdown_Graphs = new ToolStripDropDownButton();
            toolStripMenuItem_graph1 = new ToolStripMenuItem();
            ToolStripMenuItem_Graph2 = new ToolStripMenuItem();
            grpBxTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 195);
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
            txtCurrentBalance.Location = new Point(360, 195);
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
            grpBxTransactions.Location = new Point(29, 267);
            grpBxTransactions.Margin = new Padding(4, 3, 4, 3);
            grpBxTransactions.Name = "grpBxTransactions";
            grpBxTransactions.Padding = new Padding(4, 3, 4, 3);
            grpBxTransactions.Size = new Size(2150, 809);
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
            dgvRecentTransactions.Size = new Size(2142, 758);
            dgvRecentTransactions.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(308, 67);
            label2.TabIndex = 8;
            label2.Text = "Home Form";
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(40, 40);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropdown_Graphs });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(2208, 52);
            toolStrip2.TabIndex = 12;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropdown_Graphs
            // 
            toolStripDropdown_Graphs.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_graph1, ToolStripMenuItem_Graph2 });
            toolStripDropdown_Graphs.Image = (Image)resources.GetObject("toolStripDropdown_Graphs.Image");
            toolStripDropdown_Graphs.ImageTransparentColor = Color.Magenta;
            toolStripDropdown_Graphs.Name = "toolStripDropdown_Graphs";
            toolStripDropdown_Graphs.Size = new Size(178, 45);
            toolStripDropdown_Graphs.Text = "Graphs";
            // 
            // toolStripMenuItem_graph1
            // 
            toolStripMenuItem_graph1.Name = "toolStripMenuItem_graph1";
            toolStripMenuItem_graph1.RightToLeftAutoMirrorImage = true;
            toolStripMenuItem_graph1.Size = new Size(448, 54);
            toolStripMenuItem_graph1.Text = "Graph 1";
            toolStripMenuItem_graph1.Click += toolStripMenuItem_graph1_Click;
            // 
            // ToolStripMenuItem_Graph2
            // 
            ToolStripMenuItem_Graph2.Name = "ToolStripMenuItem_Graph2";
            ToolStripMenuItem_Graph2.Size = new Size(448, 54);
            ToolStripMenuItem_Graph2.Text = "Graph 2";
            ToolStripMenuItem_Graph2.Click += ToolStripMenuItem_Graph2_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2208, 1221);
            Controls.Add(toolStrip2);
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
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
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
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton toolStripDropdown_Graphs;
        private ToolStripMenuItem toolStripMenuItem_graph1;
        private ToolStripMenuItem ToolStripMenuItem_Graph2;
    }
}
