namespace PassportView
{
    partial class AddMaterial
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCoastPrice = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Материал";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(12, 26);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.ReadOnly = true;
            this.tbMaterial.Size = new System.Drawing.Size(100, 20);
            this.tbMaterial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во";
            // 
            // numericQuant
            // 
            this.numericQuant.Location = new System.Drawing.Point(129, 27);
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(45, 20);
            this.numericQuant.TabIndex = 3;
            this.numericQuant.ValueChanged += new System.EventHandler(this.numericQuant_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Себестоимость";
            // 
            // tbCoastPrice
            // 
            this.tbCoastPrice.Location = new System.Drawing.Point(194, 27);
            this.tbCoastPrice.Name = "tbCoastPrice";
            this.tbCoastPrice.ReadOnly = true;
            this.tbCoastPrice.Size = new System.Drawing.Size(85, 20);
            this.tbCoastPrice.TabIndex = 5;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(12, 53);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(267, 37);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 108);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbCoastPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericQuant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericQuant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCoastPrice;
        private System.Windows.Forms.Button btOk;
    }
}