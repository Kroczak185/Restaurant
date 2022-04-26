
namespace Restauracja.Widok.Waiter
{
    partial class OrderToDeliver
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
            this.orderID = new System.Windows.Forms.Label();
            this.orderListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.price = new System.Windows.Forms.Label();
            this.tableNumber = new System.Windows.Forms.Label();
            this.buttonDelivered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderID
            // 
            this.orderID.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderID.Location = new System.Drawing.Point(10, 10);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(327, 37);
            this.orderID.TabIndex = 0;
            this.orderID.Text = "Order ID:";
            this.orderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderListPanel
            // 
            this.orderListPanel.AutoScroll = true;
            this.orderListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderListPanel.Location = new System.Drawing.Point(10, 47);
            this.orderListPanel.Name = "orderListPanel";
            this.orderListPanel.Size = new System.Drawing.Size(327, 152);
            this.orderListPanel.TabIndex = 1;
            // 
            // price
            // 
            this.price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.price.Location = new System.Drawing.Point(10, 238);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(327, 45);
            this.price.TabIndex = 2;
            this.price.Text = "Price:";
            this.price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableNumber
            // 
            this.tableNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableNumber.Location = new System.Drawing.Point(10, 199);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(327, 39);
            this.tableNumber.TabIndex = 3;
            this.tableNumber.Text = "TableId:";
            this.tableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelivered
            // 
            this.buttonDelivered.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDelivered.Location = new System.Drawing.Point(10, 283);
            this.buttonDelivered.Name = "buttonDelivered";
            this.buttonDelivered.Size = new System.Drawing.Size(327, 52);
            this.buttonDelivered.TabIndex = 4;
            this.buttonDelivered.Text = "Delivered";
            this.buttonDelivered.UseVisualStyleBackColor = true;
            // 
            // OrderToDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 345);
            this.Controls.Add(this.orderListPanel);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.price);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.buttonDelivered);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "OrderToDeliver";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "OrderToDeliver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.FlowLayoutPanel orderListPanel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label tableNumber;
        public System.Windows.Forms.Button buttonDelivered;
    }
}