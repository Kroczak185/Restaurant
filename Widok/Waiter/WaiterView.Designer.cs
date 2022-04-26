namespace Restauracja.Widok
{
    partial class WaiterView
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
            this.WaiterTopLabel = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomerTopPanel = new Restauracja.GradientPanel();
            this.CustomerTopLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            this.CustomerTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // WaiterTopLabel
            // 
            this.WaiterTopLabel.Location = new System.Drawing.Point(0, 0);
            this.WaiterTopLabel.Name = "WaiterTopLabel";
            this.WaiterTopLabel.Size = new System.Drawing.Size(100, 23);
            this.WaiterTopLabel.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonOrders);
            this.panelBottom.Controls.Add(this.buttonTables);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 488);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(913, 58);
            this.panelBottom.TabIndex = 5;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Location = new System.Drawing.Point(426, 10);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(477, 38);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonTables
            // 
            this.buttonTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.Location = new System.Drawing.Point(10, 10);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(416, 38);
            this.buttonTables.TabIndex = 0;
            this.buttonTables.Text = "Tables";
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.AutoScroll = true;
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(0, 91);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(913, 397);
            this.panelDisplay.TabIndex = 6;
            // 
            // CustomerTopPanel
            // 
            this.CustomerTopPanel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.CustomerTopPanel.ColorTop = System.Drawing.Color.Yellow;
            this.CustomerTopPanel.Controls.Add(this.CustomerTopLabel);
            this.CustomerTopPanel.Controls.Add(this.back);
            this.CustomerTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerTopPanel.Name = "CustomerTopPanel";
            this.CustomerTopPanel.Padding = new System.Windows.Forms.Padding(5);
            this.CustomerTopPanel.Size = new System.Drawing.Size(913, 91);
            this.CustomerTopPanel.TabIndex = 4;
            // 
            // CustomerTopLabel
            // 
            this.CustomerTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerTopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTopLabel.Location = new System.Drawing.Point(105, 5);
            this.CustomerTopLabel.Name = "CustomerTopLabel";
            this.CustomerTopLabel.Size = new System.Drawing.Size(803, 81);
            this.CustomerTopLabel.TabIndex = 0;
            this.CustomerTopLabel.Text = "Orders to deliver";
            this.CustomerTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Image = global::Restauracja.Properties.Resources.Restaurant_Logo_White;
            this.back.Location = new System.Drawing.Point(5, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 81);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 1;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // WaiterView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(913, 546);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.CustomerTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaiterView";
            this.Text = "WaiterView";
            this.Load += new System.EventHandler(this.WaiterView_Load);
            this.panelBottom.ResumeLayout(false);
            this.CustomerTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WaiterTopLabel;
        private GradientPanel CustomerTopPanel;
        public System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label CustomerTopLabel;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.FlowLayoutPanel panelDisplay;
    }
}