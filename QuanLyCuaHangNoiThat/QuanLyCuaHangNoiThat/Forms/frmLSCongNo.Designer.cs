namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmLSCongNo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNgaytra = new System.Windows.Forms.Label();
            this.lblTientra = new System.Windows.Forms.Label();
            this.lblMacn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNgaytra);
            this.groupBox1.Controls.Add(this.lblTientra);
            this.groupBox1.Controls.Add(this.lblMacn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Trả Nợ";
            // 
            // lblNgaytra
            // 
            this.lblNgaytra.AutoSize = true;
            this.lblNgaytra.Location = new System.Drawing.Point(217, 287);
            this.lblNgaytra.Name = "lblNgaytra";
            this.lblNgaytra.Size = new System.Drawing.Size(110, 29);
            this.lblNgaytra.TabIndex = 2;
            this.lblNgaytra.Text = "Ngày trả";
            // 
            // lblTientra
            // 
            this.lblTientra.AutoSize = true;
            this.lblTientra.Location = new System.Drawing.Point(217, 180);
            this.lblTientra.Name = "lblTientra";
            this.lblTientra.Size = new System.Drawing.Size(103, 29);
            this.lblTientra.TabIndex = 1;
            this.lblTientra.Text = "Tiền trả";
            // 
            // lblMacn
            // 
            this.lblMacn.AutoSize = true;
            this.lblMacn.Location = new System.Drawing.Point(217, 81);
            this.lblMacn.Name = "lblMacn";
            this.lblMacn.Size = new System.Drawing.Size(148, 29);
            this.lblMacn.TabIndex = 0;
            this.lblMacn.Text = "Mã công nợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiền đã trả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã công nợ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày trả :";
            // 
            // frmLSCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLSCongNo";
            this.Text = "frmLSCongNo";
            this.Load += new System.EventHandler(this.frmLSCongNo_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNgaytra;
        private System.Windows.Forms.Label lblTientra;
        private System.Windows.Forms.Label lblMacn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}