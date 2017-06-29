using PassportView.BusinessModel;
using PassportView.Controller;
using PassportView.Model;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace PassportView
{
    public partial class RawItem : Form
    {
        private Passport p;
        public BindingSource bsRawMaterial { get; set; }
        private BusinessModelRepo bmr = new BusinessModelRepo();
        private DbPassportContext connect = new DbPassportContext();

        public RawItem(Passport p)
        {
            InitializeComponent();
            this.p = p;

            bsRawMaterial = new BindingSource();

            bsRawMaterial.DataSource = bmr.GetRawMaterials();
            dtvRawMaterial.DataSource = bsRawMaterial;

            bsRawMaterial.CurrentChanged += BsRawMaterial_CurrentChanged;
        }

        private void BsRawMaterial_CurrentChanged(object sender, System.EventArgs e)
        {
            labelError.Text = "";
        }

        private void btnAddMaterials_Click(object sender, System.EventArgs e)
        {
            AddGood ag = new AddGood(this);
            this.Enabled = false;
            if (ag.ShowDialog() == DialogResult.OK)
            {
                int MaterialId = NewMaterial(ag).MaterialId;

                bsRawMaterial.Add(bmr.GetRawMaterial(MaterialId));
            }
        }

        private Material NewMaterial(AddGood ag)
        {
            Material m = new Material
            {
                Quantity = (double)ag.Quantity,
                BarCode = ag.BarCode,
                ColorId = ag.ColorId,
                ProviderId = ag.ProviderId,
                CoastPrice = ag.CoastPrice,
                CategoryId = ag.CategoryId,
                Name = ag.MaterialName
            };

            connect.Materials.AddOrUpdate(m);
            connect.SaveChanges();

            return m;
        }

        private Material UpdateMaterial(AddGood ag, Material m)
        {
            m.Quantity = (double)ag.Quantity;
            m.BarCode = ag.BarCode;
            m.ColorId = ag.ColorId;
            m.ProviderId = ag.ProviderId;
            m.CoastPrice = ag.CoastPrice;
            m.CategoryId = ag.CategoryId;
            m.Name = ag.MaterialName;

            connect.Materials.AddOrUpdate(m);
            connect.SaveChanges();

            return m;
        }



        private void RawItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Enabled = true;
            this.Dispose();
        }

        private void dtvRawMaterial_DoubleClick(object sender, System.EventArgs e)
        {
            RawMaterial rm = (RawMaterial)bsRawMaterial.Current;
            Material m = connect.Materials.Find(rm.MaterialId);

            AddGood ag = new AddGood(this);
            this.Enabled = false;
            ag.MaterialName = m.Name;
            ag.CategoryId = m.CategoryId;
            ag.ProviderId = m.ProviderId;
            ag.Quantity = (decimal)m.Quantity;
            ag.ColorId = (int)m.ColorId;
            ag.CoastPrice = m.CoastPrice;

            if (ag.ShowDialog() == DialogResult.OK)
            {
                int MaterialId = UpdateMaterial(ag, m).MaterialId;
                RawMaterial updateRm = bmr.GetRawMaterial(MaterialId);
                rm.Name = updateRm.Name;
                rm.BarCode = updateRm.BarCode;
                rm.Quantity = updateRm.Quantity;
                rm.ColorName = updateRm.ColorName;
                rm.CategoryName = updateRm.CategoryName;
                rm.ProviderName = updateRm.ProviderName;
                bsRawMaterial.ResetBindings(true);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                RawMaterial rm = (RawMaterial)bsRawMaterial.Current;
                Material m = connect.Materials.Find(rm.MaterialId);
                connect.Materials.Remove(m);
                connect.SaveChanges();
                bsRawMaterial.Remove(rm);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                labelError.Text = "Удаление материала невозможно, так как этот материал используется.";
                labelError.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }
}
