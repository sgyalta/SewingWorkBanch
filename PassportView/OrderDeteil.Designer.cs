namespace PassportView
{
    partial class OrderDeteil
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
            this.dgvOrderDeteil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDeteil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDeteil
            // 
            this.dgvOrderDeteil.AllowUserToAddRows = false;
            this.dgvOrderDeteil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDeteil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDeteil.Location = new System.Drawing.Point(12, 12);
            this.dgvOrderDeteil.Name = "dgvOrderDeteil";
            this.dgvOrderDeteil.Size = new System.Drawing.Size(638, 396);
            this.dgvOrderDeteil.TabIndex = 11;
            // 
            // OrderDeteil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.dgvOrderDeteil);
            this.MinimizeBox = false;
            this.Name = "OrderDeteil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDeteil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderDeteil_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDeteil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrderDeteil;
    }
}