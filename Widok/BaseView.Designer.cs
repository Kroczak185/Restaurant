
namespace Restauracja.Widok
{
    partial class BaseView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseView));
            this.basePanelCustomer = new System.Windows.Forms.Panel();
            this.basePictoreboxCustomer = new System.Windows.Forms.PictureBox();
            this.baseLabelCustomer = new System.Windows.Forms.Label();
            this.basePanelChef = new System.Windows.Forms.Panel();
            this.basePictureboxChef = new System.Windows.Forms.PictureBox();
            this.baseLabelChef = new System.Windows.Forms.Label();
            this.basePanelWaiter = new System.Windows.Forms.Panel();
            this.basePictureboxWaiter = new System.Windows.Forms.PictureBox();
            this.baseLabelWaiter = new System.Windows.Forms.Label();
            this.baseBase = new System.Windows.Forms.Panel();
            this.basePanelTop = new System.Windows.Forms.Panel();
            this.baseLabelTop2 = new System.Windows.Forms.Label();
            this.baseLabelTop = new System.Windows.Forms.Label();
            this.basePanelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basePictoreboxCustomer)).BeginInit();
            this.basePanelChef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basePictureboxChef)).BeginInit();
            this.basePanelWaiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basePictureboxWaiter)).BeginInit();
            this.baseBase.SuspendLayout();
            this.basePanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanelCustomer
            // 
            this.basePanelCustomer.BackColor = System.Drawing.Color.White;
            this.basePanelCustomer.Controls.Add(this.basePictoreboxCustomer);
            this.basePanelCustomer.Controls.Add(this.baseLabelCustomer);
            this.basePanelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanelCustomer.Location = new System.Drawing.Point(298, 150);
            this.basePanelCustomer.Name = "basePanelCustomer";
            this.basePanelCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.basePanelCustomer.Size = new System.Drawing.Size(297, 353);
            this.basePanelCustomer.TabIndex = 1;
            // 
            // basePictoreboxCustomer
            // 
            this.basePictoreboxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.basePictoreboxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePictoreboxCustomer.Image = global::Restauracja.Properties.Resources.BaseCustomer;
            this.basePictoreboxCustomer.Location = new System.Drawing.Point(10, 10);
            this.basePictoreboxCustomer.Name = "basePictoreboxCustomer";
            this.basePictoreboxCustomer.Size = new System.Drawing.Size(277, 271);
            this.basePictoreboxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basePictoreboxCustomer.TabIndex = 1;
            this.basePictoreboxCustomer.TabStop = false;
            this.basePictoreboxCustomer.Click += new System.EventHandler(this.basePictoreboxCustomer_Click);
            this.basePictoreboxCustomer.MouseEnter += new System.EventHandler(this.basePictoreboxCustomer_MouseEnter);
            this.basePictoreboxCustomer.MouseLeave += new System.EventHandler(this.basePictoreboxCustomer_MouseLeave);
            // 
            // baseLabelCustomer
            // 
            this.baseLabelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.baseLabelCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseLabelCustomer.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabelCustomer.Location = new System.Drawing.Point(10, 281);
            this.baseLabelCustomer.Name = "baseLabelCustomer";
            this.baseLabelCustomer.Size = new System.Drawing.Size(277, 62);
            this.baseLabelCustomer.TabIndex = 0;
            this.baseLabelCustomer.Text = "CUSTOMER";
            this.baseLabelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baseLabelCustomer.Click += new System.EventHandler(this.basePictoreboxCustomer_Click);
            this.baseLabelCustomer.MouseEnter += new System.EventHandler(this.basePictoreboxCustomer_MouseEnter);
            this.baseLabelCustomer.MouseLeave += new System.EventHandler(this.basePictoreboxCustomer_MouseLeave);
            // 
            // basePanelChef
            // 
            this.basePanelChef.Controls.Add(this.basePictureboxChef);
            this.basePanelChef.Controls.Add(this.baseLabelChef);
            this.basePanelChef.Dock = System.Windows.Forms.DockStyle.Right;
            this.basePanelChef.Location = new System.Drawing.Point(595, 150);
            this.basePanelChef.Name = "basePanelChef";
            this.basePanelChef.Padding = new System.Windows.Forms.Padding(10);
            this.basePanelChef.Size = new System.Drawing.Size(297, 353);
            this.basePanelChef.TabIndex = 2;
            // 
            // basePictureboxChef
            // 
            this.basePictureboxChef.BackColor = System.Drawing.Color.Transparent;
            this.basePictureboxChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePictureboxChef.Image = global::Restauracja.Properties.Resources.BaseChef;
            this.basePictureboxChef.Location = new System.Drawing.Point(10, 10);
            this.basePictureboxChef.Name = "basePictureboxChef";
            this.basePictureboxChef.Size = new System.Drawing.Size(277, 271);
            this.basePictureboxChef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basePictureboxChef.TabIndex = 1;
            this.basePictureboxChef.TabStop = false;
            this.basePictureboxChef.Click += new System.EventHandler(this.basePictureboxChef_Click);
            this.basePictureboxChef.MouseEnter += new System.EventHandler(this.basePictureboxChef_MouseEnter);
            this.basePictureboxChef.MouseLeave += new System.EventHandler(this.basePictureboxChef_MouseLeave);
            // 
            // baseLabelChef
            // 
            this.baseLabelChef.BackColor = System.Drawing.Color.Transparent;
            this.baseLabelChef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseLabelChef.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabelChef.Location = new System.Drawing.Point(10, 281);
            this.baseLabelChef.Name = "baseLabelChef";
            this.baseLabelChef.Size = new System.Drawing.Size(277, 62);
            this.baseLabelChef.TabIndex = 0;
            this.baseLabelChef.Text = "CHEF";
            this.baseLabelChef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baseLabelChef.Click += new System.EventHandler(this.basePictureboxChef_Click);
            this.baseLabelChef.MouseEnter += new System.EventHandler(this.basePictureboxChef_MouseEnter);
            this.baseLabelChef.MouseLeave += new System.EventHandler(this.basePictureboxChef_MouseLeave);
            // 
            // basePanelWaiter
            // 
            this.basePanelWaiter.Controls.Add(this.basePictureboxWaiter);
            this.basePanelWaiter.Controls.Add(this.baseLabelWaiter);
            this.basePanelWaiter.Dock = System.Windows.Forms.DockStyle.Left;
            this.basePanelWaiter.Location = new System.Drawing.Point(0, 150);
            this.basePanelWaiter.Name = "basePanelWaiter";
            this.basePanelWaiter.Padding = new System.Windows.Forms.Padding(10);
            this.basePanelWaiter.Size = new System.Drawing.Size(298, 353);
            this.basePanelWaiter.TabIndex = 3;
            // 
            // basePictureboxWaiter
            // 
            this.basePictureboxWaiter.BackColor = System.Drawing.Color.Transparent;
            this.basePictureboxWaiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePictureboxWaiter.Image = global::Restauracja.Properties.Resources.BaseWaiter;
            this.basePictureboxWaiter.Location = new System.Drawing.Point(10, 10);
            this.basePictureboxWaiter.Name = "basePictureboxWaiter";
            this.basePictureboxWaiter.Size = new System.Drawing.Size(278, 271);
            this.basePictureboxWaiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basePictureboxWaiter.TabIndex = 1;
            this.basePictureboxWaiter.TabStop = false;
            this.basePictureboxWaiter.Click += new System.EventHandler(this.basePictureboxWaiter_Click);
            this.basePictureboxWaiter.MouseEnter += new System.EventHandler(this.basePictureboxWaiter_MouseEnter);
            this.basePictureboxWaiter.MouseLeave += new System.EventHandler(this.basePictureboxWaiter_MouseLeave);
            // 
            // baseLabelWaiter
            // 
            this.baseLabelWaiter.BackColor = System.Drawing.Color.Transparent;
            this.baseLabelWaiter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseLabelWaiter.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabelWaiter.Location = new System.Drawing.Point(10, 281);
            this.baseLabelWaiter.Name = "baseLabelWaiter";
            this.baseLabelWaiter.Size = new System.Drawing.Size(278, 62);
            this.baseLabelWaiter.TabIndex = 0;
            this.baseLabelWaiter.Text = "WAITER";
            this.baseLabelWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baseLabelWaiter.Click += new System.EventHandler(this.basePictureboxWaiter_Click);
            this.baseLabelWaiter.MouseEnter += new System.EventHandler(this.basePictureboxWaiter_MouseEnter);
            this.baseLabelWaiter.MouseLeave += new System.EventHandler(this.basePictureboxWaiter_MouseLeave);
            // 
            // baseBase
            // 
            this.baseBase.Controls.Add(this.basePanelCustomer);
            this.baseBase.Controls.Add(this.basePanelWaiter);
            this.baseBase.Controls.Add(this.basePanelChef);
            this.baseBase.Controls.Add(this.basePanelTop);
            this.baseBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseBase.Location = new System.Drawing.Point(0, 0);
            this.baseBase.Margin = new System.Windows.Forms.Padding(0);
            this.baseBase.Name = "baseBase";
            this.baseBase.Size = new System.Drawing.Size(892, 503);
            this.baseBase.TabIndex = 2;
            // 
            // basePanelTop
            // 
            this.basePanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.basePanelTop.Controls.Add(this.baseLabelTop2);
            this.basePanelTop.Controls.Add(this.baseLabelTop);
            this.basePanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.basePanelTop.Location = new System.Drawing.Point(0, 0);
            this.basePanelTop.Name = "basePanelTop";
            this.basePanelTop.Size = new System.Drawing.Size(892, 150);
            this.basePanelTop.TabIndex = 0;
            // 
            // baseLabelTop2
            // 
            this.baseLabelTop2.BackColor = System.Drawing.Color.Transparent;
            this.baseLabelTop2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseLabelTop2.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabelTop2.Location = new System.Drawing.Point(0, 97);
            this.baseLabelTop2.Name = "baseLabelTop2";
            this.baseLabelTop2.Size = new System.Drawing.Size(892, 53);
            this.baseLabelTop2.TabIndex = 1;
            this.baseLabelTop2.Text = "WHO ARE YOU";
            this.baseLabelTop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseLabelTop
            // 
            this.baseLabelTop.BackColor = System.Drawing.Color.Transparent;
            this.baseLabelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseLabelTop.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabelTop.ForeColor = System.Drawing.Color.White;
            this.baseLabelTop.Location = new System.Drawing.Point(0, 0);
            this.baseLabelTop.Name = "baseLabelTop";
            this.baseLabelTop.Size = new System.Drawing.Size(892, 94);
            this.baseLabelTop.TabIndex = 0;
            this.baseLabelTop.Text = "RESTAURANT";
            this.baseLabelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 503);
            this.Controls.Add(this.baseBase);
            this.Font = new System.Drawing.Font("EA Font v1.5 by Ghettoshark", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(910, 550);
            this.Name = "BaseView";
            this.Text = "Restaurant";
            this.basePanelCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basePictoreboxCustomer)).EndInit();
            this.basePanelChef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basePictureboxChef)).EndInit();
            this.basePanelWaiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basePictureboxWaiter)).EndInit();
            this.baseBase.ResumeLayout(false);
            this.basePanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel basePanelCustomer;
        private System.Windows.Forms.Label baseLabelCustomer;
        private System.Windows.Forms.PictureBox basePictoreboxCustomer;
        private System.Windows.Forms.Panel basePanelChef;
        private System.Windows.Forms.Label baseLabelChef;
        private System.Windows.Forms.PictureBox basePictureboxChef;
        private System.Windows.Forms.Panel basePanelWaiter;
        private System.Windows.Forms.Panel baseBase;
        private System.Windows.Forms.Panel basePanelTop;
        private System.Windows.Forms.Label baseLabelTop2;
        private System.Windows.Forms.Label baseLabelTop;
        private System.Windows.Forms.PictureBox basePictureboxWaiter;
        private System.Windows.Forms.Label baseLabelWaiter;
    }
}

