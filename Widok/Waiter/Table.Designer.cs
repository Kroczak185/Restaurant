
namespace Restauracja.Widok.Waiter
{
    partial class TableView
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
            this.labelID = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttonFree = new System.Windows.Forms.Button();
            this.buttonOccupied = new System.Windows.Forms.Button();
            this.buttonReserved = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelID.Location = new System.Drawing.Point(8, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(342, 42);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Id - 0";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.buttonReserved);
            this.bottomPanel.Controls.Add(this.buttonOccupied);
            this.bottomPanel.Controls.Add(this.buttonFree);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(8, 294);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(342, 71);
            this.bottomPanel.TabIndex = 1;
            // 
            // buttonFree
            // 
            this.buttonFree.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFree.Location = new System.Drawing.Point(0, 0);
            this.buttonFree.Name = "buttonFree";
            this.buttonFree.Size = new System.Drawing.Size(112, 71);
            this.buttonFree.TabIndex = 0;
            this.buttonFree.Text = "Free";
            this.buttonFree.UseVisualStyleBackColor = true;
            this.buttonFree.Click += new System.EventHandler(this.buttonFree_Click);
            // 
            // buttonOccupied
            // 
            this.buttonOccupied.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOccupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOccupied.Location = new System.Drawing.Point(230, 0);
            this.buttonOccupied.Name = "buttonOccupied";
            this.buttonOccupied.Size = new System.Drawing.Size(112, 71);
            this.buttonOccupied.TabIndex = 1;
            this.buttonOccupied.Text = "Occupied";
            this.buttonOccupied.UseVisualStyleBackColor = true;
            this.buttonOccupied.Click += new System.EventHandler(this.buttonOccupied_Click);
            // 
            // buttonReserved
            // 
            this.buttonReserved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserved.Location = new System.Drawing.Point(112, 0);
            this.buttonReserved.Name = "buttonReserved";
            this.buttonReserved.Size = new System.Drawing.Size(118, 71);
            this.buttonReserved.TabIndex = 2;
            this.buttonReserved.Text = "Reserved";
            this.buttonReserved.UseVisualStyleBackColor = true;
            this.buttonReserved.Click += new System.EventHandler(this.buttonReserved_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Location = new System.Drawing.Point(8, 245);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(342, 49);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Restauracja.Properties.Resources.stolik2;
            this.pictureBox.Location = new System.Drawing.Point(8, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(342, 195);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 373);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableView";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Text = "TableView";
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button buttonReserved;
        private System.Windows.Forms.Button buttonOccupied;
        private System.Windows.Forms.Button buttonFree;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}