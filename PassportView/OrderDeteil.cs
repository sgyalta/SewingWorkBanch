using PassportView.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassportView
{
    public partial class OrderDeteil : Form
    {
        private Passport p;
        private BindingSource bsOrderDeteil = new BindingSource();
        private BusinessModelRepo bmr = new BusinessModelRepo();

        private int OrderId;

        public OrderDeteil(Passport p, int OrderId)
        {
            InitializeComponent();
            this.p = p;
            this.OrderId = OrderId;

            bsOrderDeteil.DataSource = bmr.GetOrderProductsDeteil(OrderId);
            dgvOrderDeteil.DataSource = bsOrderDeteil;

        }

        private void OrderDeteil_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Enabled = true;
        }
    }
}
