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
    public partial class Passport : Form
    {
        BusinessModelRepo bmr = new BusinessModelRepo();

        public BindingSource BsOrderModels { get; set; }

        public Passport()
        {
            InitializeComponent();
            BsOrderModels = new BindingSource();

            BsOrderModels.DataSource = bmr.GetOrdersModels();
            dgwOrderModels.DataSource = BsOrderModels;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillPasport flFillPasport = new FillPasport(this);
            this.Enabled = false;
            flFillPasport.Show();
        }

        private void btnRawMaterial_Click(object sender, EventArgs e)
        {
            RawItem ri = new RawItem(this);
            this.Enabled = false;
            ri.Show();
        }
    }
}
