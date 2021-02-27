
namespace PastaneStokVeSiparişTakibi
{
    partial class AdminHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.NoStockListView = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productAmountTextBox = new System.Windows.Forms.TextBox();
            this.addToStockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CreateProductButton = new System.Windows.Forms.Button();
            this.newProductNameTextBox = new System.Windows.Forms.TextBox();
            this.NewProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.NewProductCategoryTextBox = new System.Windows.Forms.TextBox();
            this.NewProductStockTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imagePickerButton = new System.Windows.Forms.Button();
            this.imgPathLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.totalGainTextBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stokta Bulunmayan Ürünler";
            // 
            // NoStockListView
            // 
            this.NoStockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName});
            this.NoStockListView.HideSelection = false;
            this.NoStockListView.Location = new System.Drawing.Point(110, 157);
            this.NoStockListView.Name = "NoStockListView";
            this.NoStockListView.Size = new System.Drawing.Size(247, 304);
            this.NoStockListView.TabIndex = 1;
            this.NoStockListView.UseCompatibleStateImageBehavior = false;
            this.NoStockListView.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Ürün Adı";
            this.productName.Width = 239;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mevcut Ürün Stoğu Yenile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Miktarı:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(695, 173);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(118, 22);
            this.productNameTextBox.TabIndex = 5;
            // 
            // productAmountTextBox
            // 
            this.productAmountTextBox.Location = new System.Drawing.Point(695, 226);
            this.productAmountTextBox.Name = "productAmountTextBox";
            this.productAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.productAmountTextBox.TabIndex = 6;
            // 
            // addToStockButton
            // 
            this.addToStockButton.Location = new System.Drawing.Point(642, 294);
            this.addToStockButton.Name = "addToStockButton";
            this.addToStockButton.Size = new System.Drawing.Size(96, 33);
            this.addToStockButton.TabIndex = 7;
            this.addToStockButton.Text = "Ürünü Ekle";
            this.addToStockButton.UseVisualStyleBackColor = true;
            this.addToStockButton.Click += new System.EventHandler(this.addToStockButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(998, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menüye Yeni Ürün Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ürün Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(998, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ürün Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(967, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ürün Kategorisi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(998, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ürün Stoğu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(977, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ürün Fotoğrafı:";
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(1082, 397);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(119, 42);
            this.CreateProductButton.TabIndex = 14;
            this.CreateProductButton.Text = "Ürün Oluştur";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Location = new System.Drawing.Point(1141, 155);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(159, 22);
            this.newProductNameTextBox.TabIndex = 15;
            // 
            // NewProductPriceTextBox
            // 
            this.NewProductPriceTextBox.Location = new System.Drawing.Point(1141, 196);
            this.NewProductPriceTextBox.Name = "NewProductPriceTextBox";
            this.NewProductPriceTextBox.Size = new System.Drawing.Size(159, 22);
            this.NewProductPriceTextBox.TabIndex = 16;
            // 
            // NewProductCategoryTextBox
            // 
            this.NewProductCategoryTextBox.Location = new System.Drawing.Point(1141, 231);
            this.NewProductCategoryTextBox.Name = "NewProductCategoryTextBox";
            this.NewProductCategoryTextBox.Size = new System.Drawing.Size(159, 22);
            this.NewProductCategoryTextBox.TabIndex = 17;
            // 
            // NewProductStockTextBox
            // 
            this.NewProductStockTextBox.Location = new System.Drawing.Point(1141, 269);
            this.NewProductStockTextBox.Name = "NewProductStockTextBox";
            this.NewProductStockTextBox.Size = new System.Drawing.Size(159, 22);
            this.NewProductStockTextBox.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // imagePickerButton
            // 
            this.imagePickerButton.Location = new System.Drawing.Point(1141, 303);
            this.imagePickerButton.Name = "imagePickerButton";
            this.imagePickerButton.Size = new System.Drawing.Size(159, 38);
            this.imagePickerButton.TabIndex = 19;
            this.imagePickerButton.Text = "Select Image";
            this.imagePickerButton.UseVisualStyleBackColor = true;
            this.imagePickerButton.Click += new System.EventHandler(this.imagePickerButton_Click);
            // 
            // imgPathLabel
            // 
            this.imgPathLabel.AutoSize = true;
            this.imgPathLabel.Location = new System.Drawing.Point(1113, 361);
            this.imgPathLabel.Name = "imgPathLabel";
            this.imgPathLabel.Size = new System.Drawing.Size(0, 17);
            this.imgPathLabel.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalGainTextBox);
            this.panel1.Controls.Add(this.totalOrderNumberTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 209);
            this.panel1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Günlük Toplam Sipariş Sayısı: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Günlük Toplam Kazanç: ";
            // 
            // totalOrderNumberTextBox
            // 
            this.totalOrderNumberTextBox.Location = new System.Drawing.Point(443, 21);
            this.totalOrderNumberTextBox.Name = "totalOrderNumberTextBox";
            this.totalOrderNumberTextBox.ReadOnly = true;
            this.totalOrderNumberTextBox.Size = new System.Drawing.Size(129, 22);
            this.totalOrderNumberTextBox.TabIndex = 2;
            // 
            // totalGainTextBox
            // 
            this.totalGainTextBox.Location = new System.Drawing.Point(443, 71);
            this.totalGainTextBox.Name = "totalGainTextBox";
            this.totalGainTextBox.ReadOnly = true;
            this.totalGainTextBox.Size = new System.Drawing.Size(129, 22);
            this.totalGainTextBox.TabIndex = 3;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(1204, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(172, 47);
            this.LogoutButton.TabIndex = 22;
            this.LogoutButton.Text = "Kullanıcı Değiştir";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1366, 570);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgPathLabel);
            this.Controls.Add(this.imagePickerButton);
            this.Controls.Add(this.NewProductStockTextBox);
            this.Controls.Add(this.NewProductCategoryTextBox);
            this.Controls.Add(this.NewProductPriceTextBox);
            this.Controls.Add(this.newProductNameTextBox);
            this.Controls.Add(this.CreateProductButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addToStockButton);
            this.Controls.Add(this.productAmountTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoStockListView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminHomePage";
            this.Text = "Yönetici Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView NoStockListView;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productAmountTextBox;
        private System.Windows.Forms.Button addToStockButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.TextBox newProductNameTextBox;
        private System.Windows.Forms.TextBox NewProductPriceTextBox;
        private System.Windows.Forms.TextBox NewProductCategoryTextBox;
        private System.Windows.Forms.TextBox NewProductStockTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button imagePickerButton;
        private System.Windows.Forms.Label imgPathLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox totalOrderNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalGainTextBox;
        private System.Windows.Forms.Button LogoutButton;
    }
}