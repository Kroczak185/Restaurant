
using System.Drawing;

namespace Restauracja
{
    partial class CustomerViewCart
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
            this.CartNameLabel = new System.Windows.Forms.Label();
            this.CartPrizeLabel = new System.Windows.Forms.Label();
            this.CartItemPrizePanel = new System.Windows.Forms.Panel();
            this.CartItemZlLabel = new System.Windows.Forms.Label();
            this.CartItemNumberPanel = new System.Windows.Forms.Panel();
            this.CartItemNumberLabel = new System.Windows.Forms.Label();
            this.CartItemButtonIncrement = new System.Windows.Forms.Button();
            this.CartItemButtonDecremen = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.CartPicturebox = new System.Windows.Forms.PictureBox();
            this.CartItemPrizePanel.SuspendLayout();
            this.CartItemNumberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // CartNameLabel
            // 
            this.CartNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartNameLabel.Location = new System.Drawing.Point(65, 5);
            this.CartNameLabel.Name = "CartNameLabel";
            this.CartNameLabel.Size = new System.Drawing.Size(101, 32);
            this.CartNameLabel.TabIndex = 1;
            this.CartNameLabel.Text = "BURGER";
            this.CartNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartPrizeLabel
            // 
            this.CartPrizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartPrizeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartPrizeLabel.Location = new System.Drawing.Point(0, 0);
            this.CartPrizeLabel.Name = "CartPrizeLabel";
            this.CartPrizeLabel.Size = new System.Drawing.Size(58, 67);
            this.CartPrizeLabel.TabIndex = 3;
            this.CartPrizeLabel.Text = "20";
            this.CartPrizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartItemPrizePanel
            // 
            this.CartItemPrizePanel.Controls.Add(this.CartPrizeLabel);
            this.CartItemPrizePanel.Controls.Add(this.CartItemZlLabel);
            this.CartItemPrizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartItemPrizePanel.Location = new System.Drawing.Point(166, 5);
            this.CartItemPrizePanel.Name = "CartItemPrizePanel";
            this.CartItemPrizePanel.Size = new System.Drawing.Size(85, 67);
            this.CartItemPrizePanel.TabIndex = 5;
            // 
            // CartItemZlLabel
            // 
            this.CartItemZlLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartItemZlLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartItemZlLabel.Location = new System.Drawing.Point(58, 0);
            this.CartItemZlLabel.Name = "CartItemZlLabel";
            this.CartItemZlLabel.Size = new System.Drawing.Size(27, 67);
            this.CartItemZlLabel.TabIndex = 4;
            this.CartItemZlLabel.Text = "ZŁ";
            this.CartItemZlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartItemNumberPanel
            // 
            this.CartItemNumberPanel.Controls.Add(this.CartItemNumberLabel);
            this.CartItemNumberPanel.Controls.Add(this.CartItemButtonIncrement);
            this.CartItemNumberPanel.Controls.Add(this.CartItemButtonDecremen);
            this.CartItemNumberPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartItemNumberPanel.Location = new System.Drawing.Point(65, 37);
            this.CartItemNumberPanel.Name = "CartItemNumberPanel";
            this.CartItemNumberPanel.Padding = new System.Windows.Forms.Padding(5);
            this.CartItemNumberPanel.Size = new System.Drawing.Size(101, 35);
            this.CartItemNumberPanel.TabIndex = 6;
            // 
            // CartItemNumberLabel
            // 
            this.CartItemNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartItemNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartItemNumberLabel.Location = new System.Drawing.Point(30, 5);
            this.CartItemNumberLabel.Name = "CartItemNumberLabel";
            this.CartItemNumberLabel.Size = new System.Drawing.Size(41, 25);
            this.CartItemNumberLabel.TabIndex = 2;
            this.CartItemNumberLabel.Text = "1";
            this.CartItemNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartItemButtonIncrement
            // 
            this.CartItemButtonIncrement.BackgroundImage = global::Restauracja.Properties.Resources.Plus_symbol;
            this.CartItemButtonIncrement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CartItemButtonIncrement.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartItemButtonIncrement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartItemButtonIncrement.FlatAppearance.BorderSize = 0;
            this.CartItemButtonIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartItemButtonIncrement.Location = new System.Drawing.Point(71, 5);
            this.CartItemButtonIncrement.Name = "CartItemButtonIncrement";
            this.CartItemButtonIncrement.Size = new System.Drawing.Size(25, 25);
            this.CartItemButtonIncrement.TabIndex = 1;
            this.CartItemButtonIncrement.UseVisualStyleBackColor = true;
            this.CartItemButtonIncrement.Click += new System.EventHandler(this.CartItemButtonIncrement_Click);
            // 
            // CartItemButtonDecremen
            // 
            this.CartItemButtonDecremen.BackgroundImage = global::Restauracja.Properties.Resources.Minus_symbol;
            this.CartItemButtonDecremen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CartItemButtonDecremen.Dock = System.Windows.Forms.DockStyle.Left;
            this.CartItemButtonDecremen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartItemButtonDecremen.FlatAppearance.BorderSize = 0;
            this.CartItemButtonDecremen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartItemButtonDecremen.Location = new System.Drawing.Point(5, 5);
            this.CartItemButtonDecremen.Name = "CartItemButtonDecremen";
            this.CartItemButtonDecremen.Size = new System.Drawing.Size(25, 25);
            this.CartItemButtonDecremen.TabIndex = 0;
            this.CartItemButtonDecremen.UseVisualStyleBackColor = true;
            this.CartItemButtonDecremen.Click += new System.EventHandler(this.CartItemButtonDecremen_Click);
            // 
            // CartButton
            // 
            this.CartButton.BackgroundImage = global::Restauracja.Properties.Resources.X_symbol;
            this.CartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartButton.FlatAppearance.BorderSize = 0;
            this.CartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartButton.Location = new System.Drawing.Point(251, 5);
            this.CartButton.Margin = new System.Windows.Forms.Padding(0);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(29, 67);
            this.CartButton.TabIndex = 4;
            this.CartButton.UseVisualStyleBackColor = true;
            // 
            // CartPicturebox
            // 
            this.CartPicturebox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CartPicturebox.Location = new System.Drawing.Point(5, 5);
            this.CartPicturebox.Name = "CartPicturebox";
            this.CartPicturebox.Size = new System.Drawing.Size(60, 67);
            this.CartPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartPicturebox.TabIndex = 0;
            this.CartPicturebox.TabStop = false;
            // 
            // CustomerViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 77);
            this.Controls.Add(this.CartItemNumberPanel);
            this.Controls.Add(this.CartNameLabel);
            this.Controls.Add(this.CartItemPrizePanel);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.CartPicturebox);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerViewCart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "CustomerMenuCart";
            this.CartItemPrizePanel.ResumeLayout(false);
            this.CartItemNumberPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox CartPicturebox;
        public System.Windows.Forms.Label CartNameLabel;
        public System.Windows.Forms.Label CartPrizeLabel;
        public int indexx = 0;
        public float prize = 0f;
        public System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Panel CartItemPrizePanel;
        private System.Windows.Forms.Label CartItemZlLabel;
        private System.Windows.Forms.Panel CartItemNumberPanel;
        public System.Windows.Forms.Label CartItemNumberLabel;
        private System.Windows.Forms.Button CartItemButtonIncrement;
        private System.Windows.Forms.Button CartItemButtonDecremen;
    }
}