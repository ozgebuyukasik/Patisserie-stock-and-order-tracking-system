
namespace PastaneStokVeSiparişTakibi
{
    partial class CheckPage
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
            this.deskNumberTextBox = new System.Windows.Forms.TextBox();
            this.getCheckButton = new System.Windows.Forms.Button();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.moveDeskTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCheckLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa No:";
            // 
            // deskNumberTextBox
            // 
            this.deskNumberTextBox.Location = new System.Drawing.Point(197, 31);
            this.deskNumberTextBox.Name = "deskNumberTextBox";
            this.deskNumberTextBox.Size = new System.Drawing.Size(126, 22);
            this.deskNumberTextBox.TabIndex = 1;
            // 
            // getCheckButton
            // 
            this.getCheckButton.Location = new System.Drawing.Point(197, 92);
            this.getCheckButton.Name = "getCheckButton";
            this.getCheckButton.Size = new System.Drawing.Size(105, 39);
            this.getCheckButton.TabIndex = 2;
            this.getCheckButton.Text = "Hesap Al";
            this.getCheckButton.UseVisualStyleBackColor = true;
            this.getCheckButton.Click += new System.EventHandler(this.getCheckButton_Click);
            // 
            // OrderListView
            // 
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItem,
            this.price});
            this.OrderListView.FullRowSelect = true;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(151, 197);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(194, 198);
            this.OrderListView.TabIndex = 3;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.View = System.Windows.Forms.View.Details;
            // 
            // orderItem
            // 
            this.orderItem.Text = "Ürün Adı";
            this.orderItem.Width = 135;
            // 
            // price
            // 
            this.price.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Masa:";
            // 
            // moveDeskTextBox
            // 
            this.moveDeskTextBox.Location = new System.Drawing.Point(518, 30);
            this.moveDeskTextBox.Name = "moveDeskTextBox";
            this.moveDeskTextBox.Size = new System.Drawing.Size(112, 22);
            this.moveDeskTextBox.TabIndex = 5;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(503, 92);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(115, 38);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Hesap Taşı";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam Hesap:";
            // 
            // TotalCheckLabel
            // 
            this.TotalCheckLabel.AutoSize = true;
            this.TotalCheckLabel.Location = new System.Drawing.Point(491, 215);
            this.TotalCheckLabel.Name = "TotalCheckLabel";
            this.TotalCheckLabel.Size = new System.Drawing.Size(0, 17);
            this.TotalCheckLabel.TabIndex = 8;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(383, 275);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(130, 52);
            this.PayButton.TabIndex = 9;
            this.PayButton.Text = "Öde";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CheckPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.TotalCheckLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveDeskTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.getCheckButton);
            this.Controls.Add(this.deskNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CheckPage";
            this.Text = "Hesap Ayarları";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CheckPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deskNumberTextBox;
        private System.Windows.Forms.Button getCheckButton;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moveDeskTextBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalCheckLabel;
        private System.Windows.Forms.Button PayButton;
    }
}