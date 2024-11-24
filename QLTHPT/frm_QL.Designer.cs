namespace QLTHPT
{
    partial class frm_QL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_QLGV1 = new QLTHPT.UC_QLGV();
            this.uC_QLDiem1 = new QLTHPT.UC_QLDiem();
            this.uC_QLTKB1 = new QLTHPT.UC_QLTKB();
            this.uC_QLHS1 = new QLTHPT.UC_QLHS();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.quanLyToolStripMenuItem1,
            this.quảnLýĐiểmToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quanLyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.quanLyToolStripMenuItem.Text = "Quản lý học sinh";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem1
            // 
            this.quanLyToolStripMenuItem1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quanLyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quanLyToolStripMenuItem1.Name = "quanLyToolStripMenuItem1";
            this.quanLyToolStripMenuItem1.Size = new System.Drawing.Size(117, 27);
            this.quanLyToolStripMenuItem1.Text = "Quản lý TKB";
            this.quanLyToolStripMenuItem1.Click += new System.EventHandler(this.quanLyToolStripMenuItem1_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quảnLýĐiểmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            this.quảnLýĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quảnLýGiáoViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(157, 27);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý giáo viên";
            this.quảnLýGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiáoViênToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_QLGV1);
            this.panel1.Controls.Add(this.uC_QLDiem1);
            this.panel1.Controls.Add(this.uC_QLTKB1);
            this.panel1.Controls.Add(this.uC_QLHS1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 566);
            this.panel1.TabIndex = 1;
            // 
            // uC_QLGV1
            // 
            this.uC_QLGV1.Location = new System.Drawing.Point(0, -3);
            this.uC_QLGV1.Name = "uC_QLGV1";
            this.uC_QLGV1.Size = new System.Drawing.Size(1041, 566);
            this.uC_QLGV1.TabIndex = 3;
            // 
            // uC_QLDiem1
            // 
            this.uC_QLDiem1.Location = new System.Drawing.Point(0, 0);
            this.uC_QLDiem1.Name = "uC_QLDiem1";
            this.uC_QLDiem1.Size = new System.Drawing.Size(1041, 566);
            this.uC_QLDiem1.TabIndex = 2;
            // 
            // uC_QLTKB1
            // 
            this.uC_QLTKB1.Location = new System.Drawing.Point(0, -3);
            this.uC_QLTKB1.Name = "uC_QLTKB1";
            this.uC_QLTKB1.Size = new System.Drawing.Size(1041, 566);
            this.uC_QLTKB1.TabIndex = 1;
            // 
            // uC_QLHS1
            // 
            this.uC_QLHS1.Location = new System.Drawing.Point(0, 0);
            this.uC_QLHS1.Name = "uC_QLHS1";
            this.uC_QLHS1.Size = new System.Drawing.Size(1041, 566);
            this.uC_QLHS1.TabIndex = 0;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng  xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frm_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_QL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QL";
            this.Load += new System.EventHandler(this.frm_QL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private UC_QLHS uC_QLHS1;
        private UC_QLTKB uC_QLTKB1;
        private UC_QLGV uC_QLGV1;
        private UC_QLDiem uC_QLDiem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}