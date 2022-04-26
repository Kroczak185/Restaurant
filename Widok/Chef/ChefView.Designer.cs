using Restauracja.Widok.Chef;
using System.Collections.Generic;

namespace Restauracja.Widok
{
    partial class ChefView
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
            this.panelZamowienia = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomerTopPanel = new Restauracja.GradientPanel();
            this.back = new System.Windows.Forms.PictureBox();
            this.CustomerTopLabel = new System.Windows.Forms.Label();
            this.CustomerTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // panelZamowienia
            // 
            this.panelZamowienia.AutoScroll = true;
            this.panelZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZamowienia.Location = new System.Drawing.Point(0, 91);
            this.panelZamowienia.Name = "panelZamowienia";
            this.panelZamowienia.Size = new System.Drawing.Size(892, 412);
            this.panelZamowienia.TabIndex = 1;
            // 
            // CustomerTopPanel
            // 
            this.CustomerTopPanel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.CustomerTopPanel.ColorTop = System.Drawing.Color.Yellow;
            this.CustomerTopPanel.Controls.Add(this.back);
            this.CustomerTopPanel.Controls.Add(this.CustomerTopLabel);
            this.CustomerTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerTopPanel.Name = "CustomerTopPanel";
            this.CustomerTopPanel.Padding = new System.Windows.Forms.Padding(5);
            this.CustomerTopPanel.Size = new System.Drawing.Size(892, 91);
            this.CustomerTopPanel.TabIndex = 3;
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
            // CustomerTopLabel
            // 
            this.CustomerTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerTopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTopLabel.Location = new System.Drawing.Point(5, 5);
            this.CustomerTopLabel.Name = "CustomerTopLabel";
            this.CustomerTopLabel.Size = new System.Drawing.Size(882, 81);
            this.CustomerTopLabel.TabIndex = 0;
            this.CustomerTopLabel.Text = "ORDERS";
            this.CustomerTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChefView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(892, 503);
            this.Controls.Add(this.panelZamowienia);
            this.Controls.Add(this.CustomerTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefView";
            this.Text = "ChefView";
            this.CustomerTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelZamowienia;
        private GradientPanel CustomerTopPanel;
        public System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label CustomerTopLabel;
    }
}