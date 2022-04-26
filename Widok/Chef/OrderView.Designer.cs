
using System;
using System.Collections.Generic;

namespace Restauracja.Widok.Chef
{
    partial class OrderView
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
            this.components = new System.ComponentModel.Container();
            this.labelOberNumberText = new System.Windows.Forms.Label();
            this.labelIdZamowienia = new System.Windows.Forms.Label();
            this.Zmowienie = new System.Windows.Forms.Panel();
            this.labelCzas = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDol = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Zmowienie.SuspendLayout();
            this.panelDol.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOberNumberText
            // 
            this.labelOberNumberText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOberNumberText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOberNumberText.Location = new System.Drawing.Point(0, 0);
            this.labelOberNumberText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelOberNumberText.Name = "labelOberNumberText";
            this.labelOberNumberText.Size = new System.Drawing.Size(146, 54);
            this.labelOberNumberText.TabIndex = 0;
            this.labelOberNumberText.Text = "Order number:";
            this.labelOberNumberText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdZamowienia
            // 
            this.labelIdZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIdZamowienia.Location = new System.Drawing.Point(146, 0);
            this.labelIdZamowienia.Name = "labelIdZamowienia";
            this.labelIdZamowienia.Size = new System.Drawing.Size(140, 54);
            this.labelIdZamowienia.TabIndex = 1;
            this.labelIdZamowienia.Text = "1";
            this.labelIdZamowienia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Zmowienie
            // 
            this.Zmowienie.Controls.Add(this.labelIdZamowienia);
            this.Zmowienie.Controls.Add(this.labelOberNumberText);
            this.Zmowienie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Zmowienie.Location = new System.Drawing.Point(5, 5);
            this.Zmowienie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zmowienie.Name = "Zmowienie";
            this.Zmowienie.Size = new System.Drawing.Size(286, 54);
            this.Zmowienie.TabIndex = 2;
            // 
            // labelCzas
            // 
            this.labelCzas.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCzas.Location = new System.Drawing.Point(0, 0);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(146, 57);
            this.labelCzas.TabIndex = 3;
            this.labelCzas.Text = "13:00";
            this.labelCzas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderList
            // 
            this.orderList.AutoScroll = true;
            this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderList.Location = new System.Drawing.Point(5, 59);
            this.orderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(286, 217);
            this.orderList.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(146, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDol
            // 
            this.panelDol.Controls.Add(this.button1);
            this.panelDol.Controls.Add(this.labelCzas);
            this.panelDol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDol.Location = new System.Drawing.Point(5, 276);
            this.panelDol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDol.Name = "panelDol";
            this.panelDol.Size = new System.Drawing.Size(286, 57);
            this.panelDol.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(296, 338);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.panelDol);
            this.Controls.Add(this.Zmowienie);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OrderView";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "OrderView";
            this.Zmowienie.ResumeLayout(false);
            this.panelDol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelOberNumberText;
        private System.Windows.Forms.Label labelIdZamowienia;
        private System.Windows.Forms.Panel Zmowienie;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.FlowLayoutPanel orderList;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDol;
        private System.Windows.Forms.Timer timer1;
    }
}