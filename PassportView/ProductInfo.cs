using PassportView.Controller;
using PassportView.Model;
using System;
using System.Windows.Forms;

namespace PassportView
{
    public partial class AddGood : Form
    {
        private RawItem ri;
        private Repositer repo = new Repositer();
        private BindingSource bsCategory = new BindingSource();
        private BindingSource bsProvider = new BindingSource();
        private BindingSource bsColor = new BindingSource();

        public AddGood(RawItem ri)
        {
            InitializeComponent();

            this.ri = ri;

            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DisplayMember = "Name";
            cmbCategories.DataSource = repo.GetCategories();

            cmbProvider.ValueMember = "ProviderId";
            cmbProvider.DisplayMember = "Name";
            cmbProvider.DataSource = repo.GetProvider();

            cmdColor.ValueMember = "ColorId";
            cmdColor.DisplayMember = "Name";
            cmdColor.DataSource = repo.GetColor(); 

            Random r = new Random();
            tbBarCode.Text = r.Next(100000000, 999999999).ToString();
        }

        private void AddGood_FormClosed(object sender, FormClosedEventArgs e)
        {
            ri.Enabled = true;
            this.Close();
        }

        private void cmdColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color c = (Color)cmdColor.SelectedItem;
            pictureColor.BackColor = System.Drawing.Color.FromArgb((int)c.R, (int)c.G, (int)c.B);
        }

        public string MaterialName
        {
            get => tbMaterialName.Text;
            set => tbMaterialName.Text = value;
        }

        public int CategoryId
        {
            get => (int)cmbCategories.SelectedValue;
            set => cmbCategories.SelectedValue = value;
        }

        public int ProviderId
        {
            get => (int)cmbProvider.SelectedValue;
            set => cmbProvider.SelectedValue = value;
        }

        public string BarCode
        {
            get => tbBarCode.Text;
        }

        public decimal Quantity
        {
            get => numericQuant.Value;
            set => numericQuant.Value = value;
        }

        public int ColorId
        {
            get => (int)cmdColor.SelectedValue;
            set => cmdColor.SelectedValue = value;
        }

        public decimal CoastPrice
        {
            get => Convert.ToDecimal(tbPrice.Text);
            set
            {
                decimal price = value;
                tbPrice.Text = price.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMaterialName.Text != string.Empty && numericQuant.Value > 0 && tbPrice.Text != string.Empty)
                btnSave.DialogResult = DialogResult.OK;
        }
    }
}
