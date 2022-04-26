
namespace Restauracja.Widok.Customer
{
    partial class CustomerViewEnd
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
            this.labelEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnd
            // 
            this.labelEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnd.Location = new System.Drawing.Point(0, 0);
            this.labelEnd.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(892, 412);
            this.labelEnd.TabIndex = 0;
            this.labelEnd.Text = "Have a nice day! Click to make new order :)";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerViewEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 412);
            this.Controls.Add(this.labelEnd);
            this.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "CustomerViewEnd";
            this.Text = "CustomerViewEnd";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelEnd;
    }
}