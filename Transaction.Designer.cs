namespace apotek_app
{
    partial class Transaction
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
            noFaktur = new TextBox();
            operatorName = new TextBox();
            label5 = new Label();
            groupProduct = new GroupBox();
            subTotal = new TextBox();
            label9 = new Label();
            quantity = new TextBox();
            label8 = new Label();
            productPrice = new TextBox();
            label7 = new Label();
            productName = new TextBox();
            labelProductName = new Label();
            codeProduct = new ComboBox();
            label6 = new Label();
            addProduct = new Button();
            cancelProduct = new Button();
            viewProduct = new DataGridView();
            label10 = new Label();
            total = new TextBox();
            label11 = new Label();
            amount = new TextBox();
            moneyChange = new TextBox();
            label12 = new Label();
            saveTransaction = new Button();
            Exit = new Button();
            label13 = new Label();
            label14 = new Label();
            dateFaktur = new TextBox();
            groupProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "Apotek XYZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(40, 70);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "Drugs Store and Supplier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label3.Location = new Point(53, 113);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "No Faktur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label4.Location = new Point(53, 153);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Tgl Faktur";
            // 
            // noFaktur
            // 
            noFaktur.Font = new Font("Segoe UI", 7F);
            noFaktur.Location = new Point(134, 109);
            noFaktur.Name = "noFaktur";
            noFaktur.ReadOnly = true;
            noFaktur.Size = new Size(125, 23);
            noFaktur.TabIndex = 4;
            // 
            // operatorName
            // 
            operatorName.Font = new Font("Segoe UI", 7F);
            operatorName.Location = new Point(618, 111);
            operatorName.Name = "operatorName";
            operatorName.ReadOnly = true;
            operatorName.Size = new Size(125, 23);
            operatorName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label5.Location = new Point(558, 114);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 7;
            label5.Text = "Operator";
            // 
            // groupProduct
            // 
            groupProduct.Controls.Add(subTotal);
            groupProduct.Controls.Add(label9);
            groupProduct.Controls.Add(quantity);
            groupProduct.Controls.Add(label8);
            groupProduct.Controls.Add(productPrice);
            groupProduct.Controls.Add(label7);
            groupProduct.Controls.Add(productName);
            groupProduct.Controls.Add(labelProductName);
            groupProduct.Controls.Add(codeProduct);
            groupProduct.Controls.Add(label6);
            groupProduct.Location = new Point(40, 182);
            groupProduct.Name = "groupProduct";
            groupProduct.Size = new Size(721, 64);
            groupProduct.TabIndex = 8;
            groupProduct.TabStop = false;
            // 
            // subTotal
            // 
            subTotal.Font = new Font("Segoe UI", 7F);
            subTotal.Location = new Point(594, 33);
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            subTotal.Size = new Size(112, 23);
            subTotal.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label9.Location = new Point(592, 13);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 14;
            label9.Text = "Sub Total";
            // 
            // quantity
            // 
            quantity.Font = new Font("Segoe UI", 7F);
            quantity.Location = new Point(511, 33);
            quantity.Name = "quantity";
            quantity.Size = new Size(66, 23);
            quantity.TabIndex = 13;
            quantity.TextChanged += quantity_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label8.Location = new Point(510, 13);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 12;
            label8.Text = "Jml Beli";
            // 
            // productPrice
            // 
            productPrice.Font = new Font("Segoe UI", 7F);
            productPrice.Location = new Point(370, 33);
            productPrice.Name = "productPrice";
            productPrice.ReadOnly = true;
            productPrice.Size = new Size(125, 23);
            productPrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label7.Location = new Point(368, 13);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 10;
            label7.Text = "Harga Satuan";
            // 
            // productName
            // 
            productName.Font = new Font("Segoe UI", 7F);
            productName.Location = new Point(176, 33);
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Size = new Size(178, 23);
            productName.TabIndex = 9;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            labelProductName.Location = new Point(174, 13);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(84, 15);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Nama Barang ";
            // 
            // codeProduct
            // 
            codeProduct.Font = new Font("Segoe UI", 7F);
            codeProduct.FormattingEnabled = true;
            codeProduct.Location = new Point(10, 33);
            codeProduct.Name = "codeProduct";
            codeProduct.Size = new Size(151, 23);
            codeProduct.Sorted = true;
            codeProduct.TabIndex = 1;
            codeProduct.SelectedIndexChanged += codeProduct_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label6.Location = new Point(8, 13);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 0;
            label6.Text = "Kode Barang ";
            // 
            // addProduct
            // 
            addProduct.Font = new Font("Segoe UI", 7F);
            addProduct.Location = new Point(668, 258);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(94, 29);
            addProduct.TabIndex = 9;
            addProduct.Text = "Add";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // cancelProduct
            // 
            cancelProduct.Font = new Font("Segoe UI", 7F);
            cancelProduct.Location = new Point(568, 258);
            cancelProduct.Name = "cancelProduct";
            cancelProduct.Size = new Size(94, 29);
            cancelProduct.TabIndex = 10;
            cancelProduct.Text = "Cancel";
            cancelProduct.UseVisualStyleBackColor = true;
            cancelProduct.Click += cancelProduct_Click;
            // 
            // viewProduct
            // 
            viewProduct.AllowUserToAddRows = false;
            viewProduct.AllowUserToDeleteRows = false;
            viewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewProduct.Location = new Point(36, 316);
            viewProduct.Name = "viewProduct";
            viewProduct.ReadOnly = true;
            viewProduct.RowHeadersWidth = 51;
            viewProduct.Size = new Size(725, 226);
            viewProduct.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label10.Location = new Point(543, 562);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 12;
            label10.Text = "Total";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 7F);
            total.Location = new Point(618, 559);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(125, 23);
            total.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label11.Location = new Point(543, 594);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 14;
            label11.Text = "Jml Uang";
            // 
            // amount
            // 
            amount.Font = new Font("Segoe UI", 7F);
            amount.Location = new Point(618, 590);
            amount.Name = "amount";
            amount.Size = new Size(125, 23);
            amount.TabIndex = 15;
            amount.TextChanged += amount_TextChanged;
            // 
            // moneyChange
            // 
            moneyChange.Font = new Font("Segoe UI", 7F);
            moneyChange.Location = new Point(618, 621);
            moneyChange.Name = "moneyChange";
            moneyChange.ReadOnly = true;
            moneyChange.Size = new Size(125, 23);
            moneyChange.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label12.Location = new Point(543, 625);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 17;
            label12.Text = "Kembali";
            // 
            // saveTransaction
            // 
            saveTransaction.Font = new Font("Segoe UI", 7F);
            saveTransaction.Location = new Point(649, 665);
            saveTransaction.Name = "saveTransaction";
            saveTransaction.Size = new Size(94, 29);
            saveTransaction.TabIndex = 18;
            saveTransaction.Text = "Save";
            saveTransaction.UseVisualStyleBackColor = true;
            saveTransaction.Click += saveTransaction_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 7F);
            Exit.Location = new Point(53, 665);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 19;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label13.Location = new Point(52, 568);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 20;
            label13.Text = "Perhatian !";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7F);
            label14.Location = new Point(53, 594);
            label14.Name = "label14";
            label14.Size = new Size(213, 30);
            label14.TabIndex = 21;
            label14.Text = "Barang Yang Sudah Dibeli, Tidak Dapat \r\nDitukar Kembali";
            // 
            // dateFaktur
            // 
            dateFaktur.Font = new Font("Segoe UI", 7F);
            dateFaktur.Location = new Point(134, 147);
            dateFaktur.Name = "dateFaktur";
            dateFaktur.ReadOnly = true;
            dateFaktur.Size = new Size(125, 23);
            dateFaktur.TabIndex = 22;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 724);
            Controls.Add(dateFaktur);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Exit);
            Controls.Add(saveTransaction);
            Controls.Add(label12);
            Controls.Add(moneyChange);
            Controls.Add(amount);
            Controls.Add(label11);
            Controls.Add(total);
            Controls.Add(label10);
            Controls.Add(viewProduct);
            Controls.Add(cancelProduct);
            Controls.Add(addProduct);
            Controls.Add(groupProduct);
            Controls.Add(label5);
            Controls.Add(operatorName);
            Controls.Add(noFaktur);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transaction";
            Text = "Data Transaksi";
            groupProduct.ResumeLayout(false);
            groupProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox noFaktur;
        private TextBox tglFaktur;
        private TextBox operatorName;
        private Label label5;
        private GroupBox groupProduct;
        private Label labelProductName;
        private ComboBox codeProduct;
        private Label label6;
        private Label label7;
        private TextBox productName;
        private Label label8;
        private TextBox productPrice;
        private Label label9;
        private TextBox quantity;
        private TextBox subTotal;
        private Button addProduct;
        private Button cancelProduct;
        private DataGridView viewProduct;
        private Label label10;
        private TextBox total;
        private Label label11;
        private TextBox amount;
        private TextBox moneyChange;
        private Label label12;
        private Button saveTransaction;
        private Button Exit;
        private Label label13;
        private Label label14;
        private TextBox dateFaktur;
    }
}