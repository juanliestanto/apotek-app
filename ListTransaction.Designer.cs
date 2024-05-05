namespace apotek_app
{
    partial class ListTransaction
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
            transactionList = new DataGridView();
            add = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(267, 45);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "Apotek XYZ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(282, 101);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 1;
            label2.Text = "Transaction List";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(282, 81);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 2;
            label3.Text = "Drugs Store and Supplier";
            // 
            // transactionList
            // 
            transactionList.AllowUserToAddRows = false;
            transactionList.AllowUserToDeleteRows = false;
            transactionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionList.Location = new Point(38, 175);
            transactionList.Name = "transactionList";
            transactionList.ReadOnly = true;
            transactionList.RowHeadersWidth = 51;
            transactionList.Size = new Size(652, 256);
            transactionList.TabIndex = 3;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add.Location = new Point(517, 140);
            add.Name = "add";
            add.Size = new Size(173, 29);
            add.TabIndex = 4;
            add.Text = "Add Transaction";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // ListTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 485);
            Controls.Add(add);
            Controls.Add(transactionList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ListTransaction";
            Text = "Transaction List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)transactionList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView transactionList;
        private Button add;
    }
}