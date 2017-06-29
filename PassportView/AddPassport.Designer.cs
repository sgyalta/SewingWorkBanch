namespace PassportView
{
    partial class AddPassport
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
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCutting = new System.Windows.Forms.TextBox();
            this.cmbCutting = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFittings = new System.Windows.Forms.DateTimePicker();
            this.dtpSewing = new System.Windows.Forms.DateTimePicker();
            this.dtpCutting = new System.Windows.Forms.DateTimePicker();
            this.cmbFittings = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFittings = new System.Windows.Forms.TextBox();
            this.cmbSewing = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSewing = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSelectedMaterial = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCostPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbBarCode = new System.Windows.Forms.PictureBox();
            this.pbProducteType = new System.Windows.Forms.PictureBox();
            this.panel0 = new System.Windows.Forms.Panel();
            this.tabMaterial = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducteType)).BeginInit();
            this.panel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбранный материал";
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(21, 257);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(127, 21);
            this.cmbProductType.TabIndex = 18;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название одежды";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(238, 265);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(148, 21);
            this.cmbColor.TabIndex = 25;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Цвет";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(238, 307);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(148, 21);
            this.cmbSize.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Размер";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(464, 265);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(196, 231);
            this.tbDesc.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Количество";
            // 
            // numericQuant
            // 
            this.numericQuant.Location = new System.Drawing.Point(154, 257);
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(60, 20);
            this.numericQuant.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 36;
            // 
            // tbCutting
            // 
            this.tbCutting.Location = new System.Drawing.Point(9, 59);
            this.tbCutting.Name = "tbCutting";
            this.tbCutting.ReadOnly = true;
            this.tbCutting.Size = new System.Drawing.Size(185, 20);
            this.tbCutting.TabIndex = 35;
            // 
            // cmbCutting
            // 
            this.cmbCutting.FormattingEnabled = true;
            this.cmbCutting.Location = new System.Drawing.Point(9, 32);
            this.cmbCutting.Name = "cmbCutting";
            this.cmbCutting.Size = new System.Drawing.Size(185, 21);
            this.cmbCutting.TabIndex = 37;
            this.cmbCutting.SelectedIndexChanged += new System.EventHandler(this.cmbCutting_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Раскройечный цех";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFittings);
            this.groupBox1.Controls.Add(this.dtpSewing);
            this.groupBox1.Controls.Add(this.dtpCutting);
            this.groupBox1.Controls.Add(this.cmbFittings);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbFittings);
            this.groupBox1.Controls.Add(this.cmbSewing);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbSewing);
            this.groupBox1.Controls.Add(this.cmbCutting);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCutting);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 221);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мастера";
            // 
            // dtpFittings
            // 
            this.dtpFittings.Location = new System.Drawing.Point(198, 167);
            this.dtpFittings.Name = "dtpFittings";
            this.dtpFittings.Size = new System.Drawing.Size(123, 20);
            this.dtpFittings.TabIndex = 47;
            // 
            // dtpSewing
            // 
            this.dtpSewing.Location = new System.Drawing.Point(200, 99);
            this.dtpSewing.Name = "dtpSewing";
            this.dtpSewing.Size = new System.Drawing.Size(123, 20);
            this.dtpSewing.TabIndex = 46;
            // 
            // dtpCutting
            // 
            this.dtpCutting.Location = new System.Drawing.Point(198, 33);
            this.dtpCutting.Name = "dtpCutting";
            this.dtpCutting.Size = new System.Drawing.Size(123, 20);
            this.dtpCutting.TabIndex = 45;
            // 
            // cmbFittings
            // 
            this.cmbFittings.FormattingEnabled = true;
            this.cmbFittings.Location = new System.Drawing.Point(9, 166);
            this.cmbFittings.Name = "cmbFittings";
            this.cmbFittings.Size = new System.Drawing.Size(185, 21);
            this.cmbFittings.TabIndex = 43;
            this.cmbFittings.SelectedIndexChanged += new System.EventHandler(this.cmbFittings_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Фурнитура";
            // 
            // tbFittings
            // 
            this.tbFittings.Location = new System.Drawing.Point(9, 193);
            this.tbFittings.Name = "tbFittings";
            this.tbFittings.ReadOnly = true;
            this.tbFittings.Size = new System.Drawing.Size(185, 20);
            this.tbFittings.TabIndex = 42;
            // 
            // cmbSewing
            // 
            this.cmbSewing.FormattingEnabled = true;
            this.cmbSewing.Location = new System.Drawing.Point(9, 98);
            this.cmbSewing.Name = "cmbSewing";
            this.cmbSewing.Size = new System.Drawing.Size(185, 21);
            this.cmbSewing.TabIndex = 40;
            this.cmbSewing.SelectedIndexChanged += new System.EventHandler(this.cmbSewing_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Швейный цех";
            // 
            // tbSewing
            // 
            this.tbSewing.Location = new System.Drawing.Point(9, 125);
            this.tbSewing.Name = "tbSewing";
            this.tbSewing.ReadOnly = true;
            this.tbSewing.Size = new System.Drawing.Size(185, 20);
            this.tbSewing.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSelectedMaterial);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbCostPrice);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pbBarCode);
            this.panel1.Controls.Add(this.pbProducteType);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericQuant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDesc);
            this.panel1.Controls.Add(this.cmbProductType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbColor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 509);
            this.panel1.TabIndex = 40;
            // 
            // dgvSelectedMaterial
            // 
            this.dgvSelectedMaterial.AllowUserToAddRows = false;
            this.dgvSelectedMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedMaterial.Location = new System.Drawing.Point(352, 28);
            this.dgvSelectedMaterial.Name = "dgvSelectedMaterial";
            this.dgvSelectedMaterial.ReadOnly = true;
            this.dgvSelectedMaterial.Size = new System.Drawing.Size(308, 205);
            this.dgvSelectedMaterial.TabIndex = 48;
            this.dgvSelectedMaterial.DoubleClick += new System.EventHandler(this.dgvSelectedMaterial_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 47;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.Location = new System.Drawing.Point(238, 461);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.ReadOnly = true;
            this.tbCostPrice.Size = new System.Drawing.Size(95, 20);
            this.tbCostPrice.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Себестоимость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Штрих-код";
            // 
            // pbBarCode
            // 
            this.pbBarCode.Location = new System.Drawing.Point(238, 359);
            this.pbBarCode.Name = "pbBarCode";
            this.pbBarCode.Size = new System.Drawing.Size(206, 66);
            this.pbBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarCode.TabIndex = 43;
            this.pbBarCode.TabStop = false;
            // 
            // pbProducteType
            // 
            this.pbProducteType.BackColor = System.Drawing.SystemColors.Control;
            this.pbProducteType.Location = new System.Drawing.Point(21, 298);
            this.pbProducteType.Name = "pbProducteType";
            this.pbProducteType.Size = new System.Drawing.Size(193, 195);
            this.pbProducteType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducteType.TabIndex = 42;
            this.pbProducteType.TabStop = false;
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.tabMaterial);
            this.panel0.Location = new System.Drawing.Point(688, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(288, 509);
            this.panel0.TabIndex = 41;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Location = new System.Drawing.Point(3, 3);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.SelectedIndex = 0;
            this.tabMaterial.Size = new System.Drawing.Size(281, 503);
            this.tabMaterial.TabIndex = 0;
            // 
            // AddPassport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 509);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "AddPassport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPassport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducteType)).EndInit();
            this.panel0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericQuant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCutting;
        private System.Windows.Forms.ComboBox cmbCutting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFittings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFittings;
        private System.Windows.Forms.ComboBox cmbSewing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSewing;
        private System.Windows.Forms.DateTimePicker dtpFittings;
        private System.Windows.Forms.DateTimePicker dtpSewing;
        private System.Windows.Forms.DateTimePicker dtpCutting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.PictureBox pbProducteType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbBarCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCostPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabMaterial;
        private System.Windows.Forms.DataGridView dgvSelectedMaterial;
    }
}