using PassportView.Controller;
using System.Windows.Forms;

namespace PassportView
{
    public partial class AddGood : Form
    {
        private RawItem ri;
        private Repositer repo = new Repositer();

        public AddGood(RawItem ri)
        {
            InitializeComponent();

            this.ri = ri;

            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DisplayMember = "Name";
            cmbCategories.DataSource = repo.GetCategories();

        }

        private void AddGood_FormClosed(object sender, FormClosedEventArgs e)
        {
            ri.Enabled = true;
            this.Dispose();
        }
    }
}
