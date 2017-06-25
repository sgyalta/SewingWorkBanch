using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassportView.Controller;

namespace PassportView
{
    public partial class FillPasport : Form
    {
        private Passport _passport;
        Repository _repository = new Repository();
        BindingSource _bgCustumers = new BindingSource();

        public FillPasport(Passport p)
        {
            InitializeComponent();
            _passport = p;

            _bgCustumers.DataSource = _repository.GetCustomers();
            comboBox5.DataSource = _bgCustumers;
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "CustumerId";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassport addPassport = new AddPassport();
            this.Enabled = false;
            addPassport.Show();
        }
    }
}
