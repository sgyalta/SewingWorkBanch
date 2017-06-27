namespace PassportView
{
    partial class FillPasport
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
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpExpiress = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTatalCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(12, 25);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.ReadOnly = true;
            this.tbNumberOrder.Size = new System.Drawing.Size(151, 20);
            this.tbNumberOrder.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата окончания срока";
            // 
            // dtpExpiress
            // 
            this.dtpExpiress.Location = new System.Drawing.Point(326, 25);
            this.dtpExpiress.Name = "dtpExpiress";
            this.dtpExpiress.Size = new System.Drawing.Size(149, 20);
            this.dtpExpiress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Себестоимость";
            // 
            // tbTatalCost
            // 
            this.tbTatalCost.Location = new System.Drawing.Point(12, 291);
            this.tbTatalCost.Name = "tbTatalCost";
            this.tbTatalCost.ReadOnly = true;
            this.tbTatalCost.Size = new System.Drawing.Size(151, 20);
            this.tbTatalCost.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Заказчик";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(169, 25);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(151, 21);
            this.cmbCustomer.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить паспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.Location = new System.Drawing.Point(12, 118);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(463, 95);
            this.lbProduct.TabIndex = 27;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(12, 226);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(463, 39);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "Удалить паспорт";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(283, 271);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(192, 40);
            this.btnAddOrder.TabIndex = 29;
            this.btnAddOrder.Text = "Сформировать ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // FillPasport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 324);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTatalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExpiress);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.label2);
            this.Name = "FillPasport";
            this.Text = "FillPasport";
            this.EnabledChanged += new System.EventHandler(this.FillPasport_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpExpiress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTatalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddOrder;
    }
}