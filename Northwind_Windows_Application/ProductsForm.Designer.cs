namespace Northwind_Windows_Application
{
    partial class ProductsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chck_Satis = new System.Windows.Forms.CheckBox();
            this.nu_UnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nu_reorderLevel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nu_stock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_qpu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Supplier = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_UnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_reorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.chck_Satis);
            this.groupBox1.Controls.Add(this.nu_UnitsOnOrder);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nu_reorderLevel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nu_stock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nud_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_qpu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_productName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Supplier);
            this.groupBox1.Controls.Add(this.cb_Category);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(796, 85);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Formu Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(692, 85);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Ürün Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // chck_Satis
            // 
            this.chck_Satis.AutoSize = true;
            this.chck_Satis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chck_Satis.Location = new System.Drawing.Point(684, 50);
            this.chck_Satis.Name = "chck_Satis";
            this.chck_Satis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chck_Satis.Size = new System.Drawing.Size(89, 17);
            this.chck_Satis.TabIndex = 4;
            this.chck_Satis.Text = "Satış Durum :";
            this.chck_Satis.UseVisualStyleBackColor = true;
            // 
            // nu_UnitsOnOrder
            // 
            this.nu_UnitsOnOrder.Location = new System.Drawing.Point(470, 98);
            this.nu_UnitsOnOrder.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nu_UnitsOnOrder.Name = "nu_UnitsOnOrder";
            this.nu_UnitsOnOrder.Size = new System.Drawing.Size(180, 20);
            this.nu_UnitsOnOrder.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sipariş Edilen Stok:";
            // 
            // nu_reorderLevel
            // 
            this.nu_reorderLevel.Location = new System.Drawing.Point(470, 73);
            this.nu_reorderLevel.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nu_reorderLevel.Name = "nu_reorderLevel";
            this.nu_reorderLevel.Size = new System.Drawing.Size(180, 20);
            this.nu_reorderLevel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Güvenlik Stoğu:";
            // 
            // nu_stock
            // 
            this.nu_stock.Location = new System.Drawing.Point(470, 48);
            this.nu_stock.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nu_stock.Name = "nu_stock";
            this.nu_stock.Size = new System.Drawing.Size(180, 20);
            this.nu_stock.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stok:";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Location = new System.Drawing.Point(758, 23);
            this.nud_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(124, 20);
            this.nud_price.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat:";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(72, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(277, 20);
            this.tb_id.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID:";
            // 
            // tb_qpu
            // 
            this.tb_qpu.Location = new System.Drawing.Point(470, 22);
            this.tb_qpu.Name = "tb_qpu";
            this.tb_qpu.Size = new System.Drawing.Size(180, 20);
            this.tb_qpu.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Paketleme:";
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(72, 75);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(277, 20);
            this.tb_productName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tedarikçi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori:";
            // 
            // cb_Supplier
            // 
            this.cb_Supplier.FormattingEnabled = true;
            this.cb_Supplier.Location = new System.Drawing.Point(72, 101);
            this.cb_Supplier.Name = "cb_Supplier";
            this.cb_Supplier.Size = new System.Drawing.Size(277, 21);
            this.cb_Supplier.TabIndex = 0;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(72, 48);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(277, 21);
            this.cb_Category.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsForm";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_UnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_reorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Supplier;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.NumericUpDown nu_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nu_UnitsOnOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nu_reorderLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_qpu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chck_Satis;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}