using PassportView.Controller;
using System.Windows.Forms;

namespace PassportView
{
    public partial class RawItem : Form
    {
        private Passport p;
        public BindingSource bsRawMaterial { get; set; }
        private BusinessModelRepo bmr = new BusinessModelRepo();

        public RawItem(Passport p)
        {
            InitializeComponent();
            this.p = p;

            bsRawMaterial = new BindingSource();

            bsRawMaterial.DataSource = bmr.GetRawMaterials();
            dtvRawMaterial.DataSource = bsRawMaterial;
        }

        private void btnAddMaterials_Click(object sender, System.EventArgs e)
        {
            AddGood ag = new AddGood(this);
            this.Enabled = false;
            ag.Show();
        }

        private void RawItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Enabled = true;
            this.Dispose();
        }
    }
}
