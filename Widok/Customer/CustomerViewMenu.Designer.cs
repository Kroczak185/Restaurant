
namespace Restauracja
{
    partial class CustomerViewMenu
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
            this.ManuLabelName = new System.Windows.Forms.Label();
            this.ManuLabelPrize = new System.Windows.Forms.Label();
            this.MenuItemPicturebox = new System.Windows.Forms.PictureBox();
            this.MenuItemPanelBottom = new System.Windows.Forms.Panel();
            this.MenuZLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemPicturebox)).BeginInit();
            this.MenuItemPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManuLabelName
            // 
            this.ManuLabelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManuLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManuLabelName.Location = new System.Drawing.Point(5, 5);
            this.ManuLabelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ManuLabelName.Name = "ManuLabelName";
            this.ManuLabelName.Size = new System.Drawing.Size(178, 43);
            this.ManuLabelName.TabIndex = 1;
            this.ManuLabelName.Text = "NAME";
            this.ManuLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManuLabelName.MouseEnter += new System.EventHandler(this.MenuItemPicturebox_MouseEnter);
            this.ManuLabelName.MouseLeave += new System.EventHandler(this.MenuItemPicturebox_MouseLeave);
            // 
            // ManuLabelPrize
            // 
            this.ManuLabelPrize.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManuLabelPrize.Location = new System.Drawing.Point(0, 0);
            this.ManuLabelPrize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ManuLabelPrize.Name = "ManuLabelPrize";
            this.ManuLabelPrize.Size = new System.Drawing.Size(93, 64);
            this.ManuLabelPrize.TabIndex = 2;
            this.ManuLabelPrize.Text = "0";
            this.ManuLabelPrize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManuLabelPrize.MouseEnter += new System.EventHandler(this.MenuItemPicturebox_MouseEnter);
            this.ManuLabelPrize.MouseLeave += new System.EventHandler(this.MenuItemPicturebox_MouseLeave);
            // 
            // MenuItemPicturebox
            // 
            this.MenuItemPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuItemPicturebox.Location = new System.Drawing.Point(5, 48);
            this.MenuItemPicturebox.Margin = new System.Windows.Forms.Padding(4);
            this.MenuItemPicturebox.Name = "MenuItemPicturebox";
            this.MenuItemPicturebox.Size = new System.Drawing.Size(178, 159);
            this.MenuItemPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuItemPicturebox.TabIndex = 0;
            this.MenuItemPicturebox.TabStop = false;
            this.MenuItemPicturebox.MouseEnter += new System.EventHandler(this.MenuItemPicturebox_MouseEnter);
            this.MenuItemPicturebox.MouseLeave += new System.EventHandler(this.MenuItemPicturebox_MouseLeave);
            // 
            // MenuItemPanelBottom
            // 
            this.MenuItemPanelBottom.Controls.Add(this.MenuZLLabel);
            this.MenuItemPanelBottom.Controls.Add(this.ManuLabelPrize);
            this.MenuItemPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuItemPanelBottom.Location = new System.Drawing.Point(5, 207);
            this.MenuItemPanelBottom.Name = "MenuItemPanelBottom";
            this.MenuItemPanelBottom.Size = new System.Drawing.Size(178, 64);
            this.MenuItemPanelBottom.TabIndex = 3;
            // 
            // MenuZLLabel
            // 
            this.MenuZLLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuZLLabel.Location = new System.Drawing.Point(93, 0);
            this.MenuZLLabel.Name = "MenuZLLabel";
            this.MenuZLLabel.Size = new System.Drawing.Size(85, 64);
            this.MenuZLLabel.TabIndex = 3;
            this.MenuZLLabel.Text = "ZŁ";
            this.MenuZLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuZLLabel.MouseEnter += new System.EventHandler(this.MenuItemPicturebox_MouseEnter);
            this.MenuZLLabel.MouseLeave += new System.EventHandler(this.MenuItemPicturebox_MouseLeave);
            // 
            // CustomerMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(188, 276);
            this.Controls.Add(this.MenuItemPicturebox);
            this.Controls.Add(this.MenuItemPanelBottom);
            this.Controls.Add(this.ManuLabelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CustomerMenuItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "CustomerMenuItem";
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemPicturebox)).EndInit();
            this.MenuItemPanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox MenuItemPicturebox;
        public System.Windows.Forms.Label ManuLabelName;
        public System.Windows.Forms.Label ManuLabelPrize;
        public int indexx = 0;
        private System.Windows.Forms.Panel MenuItemPanelBottom;
        public System.Windows.Forms.Label MenuZLLabel;
    }
}