
namespace Restauracja.Widok.Customer
{
    partial class Tables
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
            this.label = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.labelTableId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.labelPlacesToSeat = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Left;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 45);
            this.label.TabIndex = 1;
            this.label.Text = "TableView id:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.label.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.labelTableId);
            this.topPanel.Controls.Add(this.label);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(15, 14);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(200, 45);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.topPanel.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // labelTableId
            // 
            this.labelTableId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTableId.Location = new System.Drawing.Point(97, 0);
            this.labelTableId.Name = "labelTableId";
            this.labelTableId.Size = new System.Drawing.Size(103, 45);
            this.labelTableId.TabIndex = 2;
            this.labelTableId.Text = "0";
            this.labelTableId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTableId.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.labelTableId.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Places to seat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Restauracja.Properties.Resources.stolik2;
            this.pictureBox.Location = new System.Drawing.Point(15, 59);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 152);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.labelPlacesToSeat);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(15, 211);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(200, 57);
            this.bottomPanel.TabIndex = 4;
            this.bottomPanel.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.bottomPanel.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // labelPlacesToSeat
            // 
            this.labelPlacesToSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlacesToSeat.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlacesToSeat.Location = new System.Drawing.Point(97, 0);
            this.labelPlacesToSeat.Name = "labelPlacesToSeat";
            this.labelPlacesToSeat.Size = new System.Drawing.Size(103, 57);
            this.labelPlacesToSeat.TabIndex = 4;
            this.labelPlacesToSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlacesToSeat.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.labelPlacesToSeat.MouseLeave += new System.EventHandler(this.Tables_Leave);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 282);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tables";
            this.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.MouseEnter += new System.EventHandler(this.Tables_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Tables_Leave);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Label labelTableId;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel bottomPanel;
        public System.Windows.Forms.Label labelPlacesToSeat;
    }
}