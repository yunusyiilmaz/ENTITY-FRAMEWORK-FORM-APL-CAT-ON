namespace EntityFrameworkDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProduct = new System.Windows.Forms.GroupBox();
            this.txbStockAmount = new System.Windows.Forms.TextBox();
            this.txbUnitPrice = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.txbUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.txbNameUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.Controls.Add(this.txbStockAmount);
            this.addProduct.Controls.Add(this.txbUnitPrice);
            this.addProduct.Controls.Add(this.txbName);
            this.addProduct.Controls.Add(this.tbxStockAmount);
            this.addProduct.Controls.Add(this.tbxUnitPrice);
            this.addProduct.Controls.Add(this.tbxName);
            this.addProduct.Location = new System.Drawing.Point(37, 229);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(200, 100);
            this.addProduct.TabIndex = 0;
            this.addProduct.TabStop = false;
            this.addProduct.Text = "Add a product";
            // 
            // txbStockAmount
            // 
            this.txbStockAmount.Location = new System.Drawing.Point(83, 68);
            this.txbStockAmount.Name = "txbStockAmount";
            this.txbStockAmount.Size = new System.Drawing.Size(100, 20);
            this.txbStockAmount.TabIndex = 5;
            // 
            // txbUnitPrice
            // 
            this.txbUnitPrice.Location = new System.Drawing.Point(83, 39);
            this.txbUnitPrice.Name = "txbUnitPrice";
            this.txbUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txbUnitPrice.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(83, 16);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 3;
            this.txbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.AutoSize = true;
            this.tbxStockAmount.Location = new System.Drawing.Point(3, 71);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(74, 13);
            this.tbxStockAmount.TabIndex = 2;
            this.tbxStockAmount.Text = "Stock Amount";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.AutoSize = true;
            this.tbxUnitPrice.Location = new System.Drawing.Point(3, 42);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.tbxUnitPrice.TabIndex = 1;
            this.tbxUnitPrice.Text = "Unit Price";
            // 
            // tbxName
            // 
            this.tbxName.AutoSize = true;
            this.tbxName.Location = new System.Drawing.Point(3, 16);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(35, 13);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(595, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbStockAmountUpdate);
            this.groupBox1.Controls.Add(this.txbUnitPriceUpdate);
            this.groupBox1.Controls.Add(this.txbNameUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(512, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a product";
            // 
            // txbStockAmountUpdate
            // 
            this.txbStockAmountUpdate.Location = new System.Drawing.Point(83, 68);
            this.txbStockAmountUpdate.Name = "txbStockAmountUpdate";
            this.txbStockAmountUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbStockAmountUpdate.TabIndex = 5;
            // 
            // txbUnitPriceUpdate
            // 
            this.txbUnitPriceUpdate.Location = new System.Drawing.Point(83, 39);
            this.txbUnitPriceUpdate.Name = "txbUnitPriceUpdate";
            this.txbUnitPriceUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbUnitPriceUpdate.TabIndex = 4;
            // 
            // txbNameUpdate
            // 
            this.txbNameUpdate.Location = new System.Drawing.Point(83, 16);
            this.txbNameUpdate.Name = "txbNameUpdate";
            this.txbNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbNameUpdate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addProduct.ResumeLayout(false);
            this.addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addProduct;
        private System.Windows.Forms.TextBox txbStockAmount;
        private System.Windows.Forms.TextBox txbUnitPrice;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label tbxStockAmount;
        private System.Windows.Forms.Label tbxUnitPrice;
        private System.Windows.Forms.Label tbxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbStockAmountUpdate;
        private System.Windows.Forms.TextBox txbUnitPriceUpdate;
        private System.Windows.Forms.TextBox txbNameUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
    }
}

