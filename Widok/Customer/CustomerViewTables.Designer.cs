
using System.Windows.Forms;

namespace Restauracja.Widok.Customer
{
    partial class CustomerViewTables
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.topPanel = new System.Windows.Forms.Panel();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 30);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(892, 326);
            this.flowPanel.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(0, 0);
            this.datePicker.MinDate = new System.DateTime(2022, 1, 9, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(892, 24);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2022, 1, 9, 0, 0, 0, 0);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.datePicker);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(892, 30);
            this.topPanel.TabIndex = 3;
            // 
            // buttonEnd
            // 
            this.buttonEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Location = new System.Drawing.Point(0, 356);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(892, 56);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = "next";
            this.buttonEnd.UseVisualStyleBackColor = true;
            // 
            // CustomerViewTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 412);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerViewTables";
            this.Text = "CustomerViewTables";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        public System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Button buttonEnd;
    }
}