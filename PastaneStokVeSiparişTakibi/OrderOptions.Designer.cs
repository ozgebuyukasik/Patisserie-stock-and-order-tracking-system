
namespace PastaneStokVeSiparişTakibi
{
    partial class OrderOptions
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
            this.AllOrdersLabel = new System.Windows.Forms.Label();
            this.OrdersListView = new System.Windows.Forms.ListView();
            this.OrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.ProductsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllOrdersLabel
            // 
            this.AllOrdersLabel.AutoSize = true;
            this.AllOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrdersLabel.Location = new System.Drawing.Point(180, 27);
            this.AllOrdersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllOrdersLabel.Name = "AllOrdersLabel";
            this.AllOrdersLabel.Size = new System.Drawing.Size(132, 20);
            this.AllOrdersLabel.TabIndex = 0;
            this.AllOrdersLabel.Text = "Tüm Siparişler";
            // 
            // OrdersListView
            // 
            this.OrdersListView.CheckBoxes = true;
            this.OrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNumber,
            this.OrderAddress,
            this.OrderDate});
            this.OrdersListView.FullRowSelect = true;
            this.OrdersListView.HideSelection = false;
            this.OrdersListView.Location = new System.Drawing.Point(13, 66);
            this.OrdersListView.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersListView.Name = "OrdersListView";
            this.OrdersListView.Size = new System.Drawing.Size(602, 444);
            this.OrdersListView.TabIndex = 1;
            this.OrdersListView.UseCompatibleStateImageBehavior = false;
            this.OrdersListView.View = System.Windows.Forms.View.Details;
            this.OrdersListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.OrdersListView_ItemChecked);
            this.OrdersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OrdersListView_ItemSelectionChanged);
            // 
            // OrderNumber
            // 
            this.OrderNumber.Text = "Sipariş No";
            this.OrderNumber.Width = 114;
            // 
            // OrderAddress
            // 
            this.OrderAddress.Text = "Adres";
            this.OrderAddress.Width = 328;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Tarih";
            this.OrderDate.Width = 200;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(745, 66);
            this.OrderItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(141, 20);
            this.OrderItemsLabel.TabIndex = 2;
            this.OrderItemsLabel.Text = "Sipariş Ürünleri";
            // 
            // OrderItemsListView
            // 
            this.OrderItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemPrice});
            this.OrderItemsListView.FullRowSelect = true;
            this.OrderItemsListView.HideSelection = false;
            this.OrderItemsListView.Location = new System.Drawing.Point(699, 112);
            this.OrderItemsListView.Margin = new System.Windows.Forms.Padding(4);
            this.OrderItemsListView.Name = "OrderItemsListView";
            this.OrderItemsListView.Size = new System.Drawing.Size(248, 241);
            this.OrderItemsListView.TabIndex = 3;
            this.OrderItemsListView.UseCompatibleStateImageBehavior = false;
            this.OrderItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Ürün Adı";
            this.ItemName.Width = 174;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Fiyat";
            this.ItemPrice.Width = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Fiyat: ";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(1134, 134);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.TotalPriceLabel.TabIndex = 5;
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.AutoSize = true;
            this.ProductsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductsPanel.Location = new System.Drawing.Point(0, 636);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(1204, 0);
            this.ProductsPanel.TabIndex = 6;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(986, 240);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(142, 52);
            this.DeleteProductButton.TabIndex = 7;
            this.DeleteProductButton.Text = "Seçili Ürünü Sil";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(1076, 8);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(127, 59);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Kullanıcı Değiştir";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OrderOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1204, 636);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ProductsPanel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderItemsListView);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.OrdersListView);
            this.Controls.Add(this.AllOrdersLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderOptions";
            this.Text = "Sipariş Kontrol ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllOrdersLabel;
        private System.Windows.Forms.ListView OrdersListView;
        private System.Windows.Forms.ColumnHeader OrderNumber;
        private System.Windows.Forms.ColumnHeader OrderAddress;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListView OrderItemsListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.FlowLayoutPanel ProductsPanel;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}