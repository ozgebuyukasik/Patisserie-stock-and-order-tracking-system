
namespace PastaneStokVeSiparişTakibi
{
    partial class CashierHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHomePage));
            this.GetCheckButton = new System.Windows.Forms.Button();
            this.MoveCheckButton = new System.Windows.Forms.Button();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.OrderListButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.createOrder1 = new CreatingOrderPage.CreateOrder();
            this.DesksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DesksLabel = new System.Windows.Forms.Label();
            this.Desk1Button = new System.Windows.Forms.Button();
            this.Desk2Button = new System.Windows.Forms.Button();
            this.Desk3Button = new System.Windows.Forms.Button();
            this.Desk4Button = new System.Windows.Forms.Button();
            this.Desk5Button = new System.Windows.Forms.Button();
            this.Desk6Button = new System.Windows.Forms.Button();
            this.Desk7Button = new System.Windows.Forms.Button();
            this.Desk8Button = new System.Windows.Forms.Button();
            this.Desk9Button = new System.Windows.Forms.Button();
            this.Desk10Button = new System.Windows.Forms.Button();
            this.Desk11Button = new System.Windows.Forms.Button();
            this.Desk12Button = new System.Windows.Forms.Button();
            this.Desk13Button = new System.Windows.Forms.Button();
            this.Desk14Button = new System.Windows.Forms.Button();
            this.Desk15Button = new System.Windows.Forms.Button();
            this.ProductsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.OrdersFlowLayoutPanel.SuspendLayout();
            this.DesksFlowLayoutPanel.SuspendLayout();
            this.ProductsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetCheckButton
            // 
            this.GetCheckButton.AutoSize = true;
            this.GetCheckButton.Location = new System.Drawing.Point(323, 3);
            this.GetCheckButton.Name = "GetCheckButton";
            this.GetCheckButton.Size = new System.Drawing.Size(136, 52);
            this.GetCheckButton.TabIndex = 2;
            this.GetCheckButton.Text = "Hesap Al";
            this.GetCheckButton.UseVisualStyleBackColor = true;
            this.GetCheckButton.Click += new System.EventHandler(this.GetCheckButton_Click);
            // 
            // MoveCheckButton
            // 
            this.MoveCheckButton.AutoSize = true;
            this.MoveCheckButton.Location = new System.Drawing.Point(465, 3);
            this.MoveCheckButton.Name = "MoveCheckButton";
            this.MoveCheckButton.Size = new System.Drawing.Size(136, 52);
            this.MoveCheckButton.TabIndex = 3;
            this.MoveCheckButton.Text = "Hesabı Taşı";
            this.MoveCheckButton.UseVisualStyleBackColor = true;
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.AutoSize = true;
            this.UpdateOrderButton.Location = new System.Drawing.Point(181, 3);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(136, 52);
            this.UpdateOrderButton.TabIndex = 1;
            this.UpdateOrderButton.Text = "Sistemi Güncelle";
            this.UpdateOrderButton.UseVisualStyleBackColor = true;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservationButton.AutoSize = true;
            this.ReservationButton.Location = new System.Drawing.Point(607, 3);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(136, 52);
            this.ReservationButton.TabIndex = 4;
            this.ReservationButton.Text = "Rezervasyon Yap";
            this.ReservationButton.UseVisualStyleBackColor = true;
            // 
            // OrderListButton
            // 
            this.OrderListButton.AutoSize = true;
            this.OrderListButton.Location = new System.Drawing.Point(3, 3);
            this.OrderListButton.Name = "OrderListButton";
            this.OrderListButton.Size = new System.Drawing.Size(172, 52);
            this.OrderListButton.TabIndex = 0;
            this.OrderListButton.Text = "Siparişleri Görüntüle";
            this.OrderListButton.UseVisualStyleBackColor = true;
            this.OrderListButton.Click += new System.EventHandler(this.OrderListButton_Click_1);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 6;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayoutPanel.Controls.Add(this.UpdateOrderButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.GetCheckButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.MoveCheckButton, 3, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.OrderListButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ReservationButton, 4, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.button1, 5, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(1120, 100);
            this.ButtonsTableLayoutPanel.TabIndex = 5;
            // 
            // OrdersFlowLayoutPanel
            // 
            this.OrdersFlowLayoutPanel.Controls.Add(this.OrdersLabel);
            this.OrdersFlowLayoutPanel.Controls.Add(this.elementHost1);
            this.OrdersFlowLayoutPanel.Location = new System.Drawing.Point(4, 103);
            this.OrdersFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OrdersFlowLayoutPanel.Name = "OrdersFlowLayoutPanel";
            this.OrdersFlowLayoutPanel.Size = new System.Drawing.Size(440, 1000);
            this.OrdersFlowLayoutPanel.TabIndex = 6;
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersFlowLayoutPanel.SetFlowBreak(this.OrdersLabel, true);
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersLabel.Location = new System.Drawing.Point(3, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(90, 20);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Siparişler";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.elementHost1.Location = new System.Drawing.Point(0, 20);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(493, 1000);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.createOrder1;
            // 
            // DesksFlowLayoutPanel
            // 
            this.DesksFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesksFlowLayoutPanel.Controls.Add(this.DesksLabel);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk1Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk2Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk3Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk4Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk5Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk6Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk7Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk8Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk9Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk10Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk11Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk12Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk13Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk14Button);
            this.DesksFlowLayoutPanel.Controls.Add(this.Desk15Button);
            this.DesksFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesksFlowLayoutPanel.Location = new System.Drawing.Point(450, 104);
            this.DesksFlowLayoutPanel.Name = "DesksFlowLayoutPanel";
            this.DesksFlowLayoutPanel.Size = new System.Drawing.Size(670, 293);
            this.DesksFlowLayoutPanel.TabIndex = 7;
            // 
            // DesksLabel
            // 
            this.DesksLabel.AutoSize = true;
            this.DesksFlowLayoutPanel.SetFlowBreak(this.DesksLabel, true);
            this.DesksLabel.Location = new System.Drawing.Point(3, 0);
            this.DesksLabel.Name = "DesksLabel";
            this.DesksLabel.Size = new System.Drawing.Size(76, 20);
            this.DesksLabel.TabIndex = 0;
            this.DesksLabel.Text = "Masalar";
            // 
            // Desk1Button
            // 
            this.Desk1Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk1Button.Location = new System.Drawing.Point(3, 84);
            this.Desk1Button.Name = "Desk1Button";
            this.Desk1Button.Size = new System.Drawing.Size(150, 75);
            this.Desk1Button.TabIndex = 1;
            this.Desk1Button.Text = "1";
            this.Desk1Button.UseVisualStyleBackColor = false;
            // 
            // Desk2Button
            // 
            this.Desk2Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk2Button.Location = new System.Drawing.Point(159, 84);
            this.Desk2Button.Name = "Desk2Button";
            this.Desk2Button.Size = new System.Drawing.Size(150, 75);
            this.Desk2Button.TabIndex = 2;
            this.Desk2Button.Text = "2";
            this.Desk2Button.UseVisualStyleBackColor = false;
            // 
            // Desk3Button
            // 
            this.Desk3Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk3Button.Location = new System.Drawing.Point(315, 84);
            this.Desk3Button.Name = "Desk3Button";
            this.Desk3Button.Size = new System.Drawing.Size(150, 75);
            this.Desk3Button.TabIndex = 3;
            this.Desk3Button.Text = "3";
            this.Desk3Button.UseVisualStyleBackColor = false;
            // 
            // Desk4Button
            // 
            this.Desk4Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk4Button.Location = new System.Drawing.Point(471, 84);
            this.Desk4Button.Name = "Desk4Button";
            this.Desk4Button.Size = new System.Drawing.Size(150, 75);
            this.Desk4Button.TabIndex = 4;
            this.Desk4Button.Text = "4";
            this.Desk4Button.UseVisualStyleBackColor = false;
            // 
            // Desk5Button
            // 
            this.Desk5Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk5Button.Location = new System.Drawing.Point(3, 165);
            this.Desk5Button.Name = "Desk5Button";
            this.Desk5Button.Size = new System.Drawing.Size(150, 75);
            this.Desk5Button.TabIndex = 5;
            this.Desk5Button.Text = "5";
            this.Desk5Button.UseVisualStyleBackColor = false;
            // 
            // Desk6Button
            // 
            this.Desk6Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk6Button.Location = new System.Drawing.Point(159, 165);
            this.Desk6Button.Name = "Desk6Button";
            this.Desk6Button.Size = new System.Drawing.Size(150, 75);
            this.Desk6Button.TabIndex = 6;
            this.Desk6Button.Text = "6";
            this.Desk6Button.UseVisualStyleBackColor = false;
            // 
            // Desk7Button
            // 
            this.Desk7Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk7Button.Location = new System.Drawing.Point(315, 165);
            this.Desk7Button.Name = "Desk7Button";
            this.Desk7Button.Size = new System.Drawing.Size(150, 75);
            this.Desk7Button.TabIndex = 7;
            this.Desk7Button.Text = "7";
            this.Desk7Button.UseVisualStyleBackColor = false;
            // 
            // Desk8Button
            // 
            this.Desk8Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk8Button.Location = new System.Drawing.Point(471, 165);
            this.Desk8Button.Name = "Desk8Button";
            this.Desk8Button.Size = new System.Drawing.Size(150, 75);
            this.Desk8Button.TabIndex = 8;
            this.Desk8Button.Text = "8";
            this.Desk8Button.UseVisualStyleBackColor = false;
            // 
            // Desk9Button
            // 
            this.Desk9Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk9Button.Location = new System.Drawing.Point(3, 246);
            this.Desk9Button.Name = "Desk9Button";
            this.Desk9Button.Size = new System.Drawing.Size(150, 75);
            this.Desk9Button.TabIndex = 9;
            this.Desk9Button.Text = "9";
            this.Desk9Button.UseVisualStyleBackColor = false;
            // 
            // Desk10Button
            // 
            this.Desk10Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk10Button.Location = new System.Drawing.Point(159, 246);
            this.Desk10Button.Name = "Desk10Button";
            this.Desk10Button.Size = new System.Drawing.Size(150, 75);
            this.Desk10Button.TabIndex = 10;
            this.Desk10Button.Text = "10";
            this.Desk10Button.UseVisualStyleBackColor = false;
            // 
            // Desk11Button
            // 
            this.Desk11Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk11Button.Location = new System.Drawing.Point(315, 246);
            this.Desk11Button.Name = "Desk11Button";
            this.Desk11Button.Size = new System.Drawing.Size(150, 75);
            this.Desk11Button.TabIndex = 11;
            this.Desk11Button.Text = "11";
            this.Desk11Button.UseVisualStyleBackColor = false;
            // 
            // Desk12Button
            // 
            this.Desk12Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk12Button.Location = new System.Drawing.Point(471, 246);
            this.Desk12Button.Name = "Desk12Button";
            this.Desk12Button.Size = new System.Drawing.Size(150, 75);
            this.Desk12Button.TabIndex = 12;
            this.Desk12Button.Text = "12";
            this.Desk12Button.UseVisualStyleBackColor = false;
            // 
            // Desk13Button
            // 
            this.Desk13Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk13Button.Location = new System.Drawing.Point(3, 327);
            this.Desk13Button.Name = "Desk13Button";
            this.Desk13Button.Size = new System.Drawing.Size(150, 75);
            this.Desk13Button.TabIndex = 13;
            this.Desk13Button.Text = "13";
            this.Desk13Button.UseVisualStyleBackColor = false;
            // 
            // Desk14Button
            // 
            this.Desk14Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk14Button.Location = new System.Drawing.Point(159, 327);
            this.Desk14Button.Name = "Desk14Button";
            this.Desk14Button.Size = new System.Drawing.Size(150, 75);
            this.Desk14Button.TabIndex = 14;
            this.Desk14Button.Text = "14";
            this.Desk14Button.UseVisualStyleBackColor = false;
            // 
            // Desk15Button
            // 
            this.Desk15Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Desk15Button.Location = new System.Drawing.Point(315, 327);
            this.Desk15Button.Name = "Desk15Button";
            this.Desk15Button.Size = new System.Drawing.Size(150, 75);
            this.Desk15Button.TabIndex = 15;
            this.Desk15Button.Text = "15";
            this.Desk15Button.UseVisualStyleBackColor = false;
            // 
            // ProductsFlowLayoutPanel
            // 
            this.ProductsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsFlowLayoutPanel.AutoSize = true;
            this.ProductsFlowLayoutPanel.Controls.Add(this.ProductsLabel);
            this.ProductsFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsFlowLayoutPanel.Location = new System.Drawing.Point(450, 404);
            this.ProductsFlowLayoutPanel.Name = "ProductsFlowLayoutPanel";
            this.ProductsFlowLayoutPanel.Size = new System.Drawing.Size(670, 445);
            this.ProductsFlowLayoutPanel.TabIndex = 8;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsFlowLayoutPanel.SetFlowBreak(this.ProductsLabel, true);
            this.ProductsLabel.Location = new System.Drawing.Point(0, 0);
            this.ProductsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(71, 20);
            this.ProductsLabel.TabIndex = 0;
            this.ProductsLabel.Text = "Ürünler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kullanıcı Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1120, 894);
            this.Controls.Add(this.ProductsFlowLayoutPanel);
            this.Controls.Add(this.DesksFlowLayoutPanel);
            this.Controls.Add(this.OrdersFlowLayoutPanel);
            this.Controls.Add(this.ButtonsTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierHomePage";
            this.Text = "Kasiyer Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierHomePage_Load);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.PerformLayout();
            this.OrdersFlowLayoutPanel.ResumeLayout(false);
            this.OrdersFlowLayoutPanel.PerformLayout();
            this.DesksFlowLayoutPanel.ResumeLayout(false);
            this.DesksFlowLayoutPanel.PerformLayout();
            this.ProductsFlowLayoutPanel.ResumeLayout(false);
            this.ProductsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetCheckButton;
        private System.Windows.Forms.Button MoveCheckButton;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Button OrderListButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel OrdersFlowLayoutPanel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.FlowLayoutPanel DesksFlowLayoutPanel;
        private System.Windows.Forms.Label DesksLabel;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowLayoutPanel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button Desk1Button;
        private System.Windows.Forms.Button Desk2Button;
        private System.Windows.Forms.Button Desk3Button;
        private System.Windows.Forms.Button Desk4Button;
        private System.Windows.Forms.Button Desk5Button;
        private System.Windows.Forms.Button Desk6Button;
        private System.Windows.Forms.Button Desk7Button;
        private System.Windows.Forms.Button Desk8Button;
        private System.Windows.Forms.Button Desk9Button;
        private System.Windows.Forms.Button Desk10Button;
        private System.Windows.Forms.Button Desk11Button;
        private System.Windows.Forms.Button Desk12Button;
        private System.Windows.Forms.Button Desk13Button;
        private System.Windows.Forms.Button Desk14Button;
        private System.Windows.Forms.Button Desk15Button;
        private CreatingOrderPage.CreateOrder createOrder;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private CreatingOrderPage.CreateOrder createOrder1;
        private System.Windows.Forms.Button button1;
    }
}