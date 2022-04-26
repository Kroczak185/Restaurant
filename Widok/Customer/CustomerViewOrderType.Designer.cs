
namespace Restauracja.Widok.Customer
{
    partial class CustomerViewOrderType
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftLabel = new System.Windows.Forms.Label();
            this.leftPicturebox = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightPicturebox = new System.Windows.Forms.PictureBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPicturebox)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftLabel);
            this.leftPanel.Controls.Add(this.leftPicturebox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(7);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.leftPanel.Size = new System.Drawing.Size(434, 412);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.MouseEnter += new System.EventHandler(this.left_MouseEnter);
            this.leftPanel.MouseLeave += new System.EventHandler(this.left_MouseLeave);
            // 
            // leftLabel
            // 
            this.leftLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftLabel.Location = new System.Drawing.Point(22, 332);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(390, 57);
            this.leftLabel.TabIndex = 1;
            this.leftLabel.Text = "IN RESTAURANT";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.leftLabel.MouseEnter += new System.EventHandler(this.left_MouseEnter);
            this.leftLabel.MouseLeave += new System.EventHandler(this.left_MouseLeave);
            // 
            // leftPicturebox
            // 
            this.leftPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPicturebox.Image = global::Restauracja.Properties.Resources.in_restaurant;
            this.leftPicturebox.Location = new System.Drawing.Point(22, 23);
            this.leftPicturebox.Margin = new System.Windows.Forms.Padding(7);
            this.leftPicturebox.Name = "leftPicturebox";
            this.leftPicturebox.Size = new System.Drawing.Size(390, 366);
            this.leftPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPicturebox.TabIndex = 0;
            this.leftPicturebox.TabStop = false;
            this.leftPicturebox.MouseEnter += new System.EventHandler(this.left_MouseEnter);
            this.leftPicturebox.MouseLeave += new System.EventHandler(this.left_MouseLeave);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightPicturebox);
            this.rightPanel.Controls.Add(this.rightLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(434, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(7);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.rightPanel.Size = new System.Drawing.Size(458, 412);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.MouseEnter += new System.EventHandler(this.right_MouseEnter);
            this.rightPanel.MouseLeave += new System.EventHandler(this.right_MouseLeave);
            // 
            // rightPicturebox
            // 
            this.rightPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPicturebox.Image = global::Restauracja.Properties.Resources.takeaway;
            this.rightPicturebox.Location = new System.Drawing.Point(22, 23);
            this.rightPicturebox.Margin = new System.Windows.Forms.Padding(7);
            this.rightPicturebox.Name = "rightPicturebox";
            this.rightPicturebox.Size = new System.Drawing.Size(414, 309);
            this.rightPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPicturebox.TabIndex = 1;
            this.rightPicturebox.TabStop = false;
            this.rightPicturebox.Click += new System.EventHandler(this.rightPicturebox_Click);
            this.rightPicturebox.MouseEnter += new System.EventHandler(this.right_MouseEnter);
            this.rightPicturebox.MouseLeave += new System.EventHandler(this.right_MouseLeave);
            // 
            // rightLabel
            // 
            this.rightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightLabel.Location = new System.Drawing.Point(22, 332);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(414, 57);
            this.rightLabel.TabIndex = 0;
            this.rightLabel.Text = "DELIVERY";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rightLabel.MouseEnter += new System.EventHandler(this.right_MouseEnter);
            this.rightLabel.MouseLeave += new System.EventHandler(this.right_MouseLeave);
            // 
            // CustomerViewOrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 412);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CustomerViewOrderType";
            this.Text = "CustomerViewOrderType";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftPicturebox)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftPanel;
        public System.Windows.Forms.Label leftLabel;
        public System.Windows.Forms.PictureBox leftPicturebox;
        public System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.PictureBox rightPicturebox;
        public System.Windows.Forms.Label rightLabel;
    }
}