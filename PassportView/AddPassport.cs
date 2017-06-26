using PassportView.BusinessModel;
using PassportView.Controller;
using PassportView.Model;
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
    public partial class AddPassport : Form
    {
        Repositer repo = new Repositer();
        BusinessModelRepo bmrepo = new BusinessModelRepo();
        DbPassportContext Connect = new DbPassportContext();

        BindingSource bsSelectedMaterial = new BindingSource();

        public List<SelectedMaterial> selectedMaterial;

        public AddPassport()
        {
            InitializeComponent();

            cmbCutting.DataSource = repo.GetEmployee(1);
            cmbCutting.ValueMember = "EmployeeId";
            cmbCutting.DisplayMember = "Name";

            cmbSewing.DataSource = repo.GetEmployee(2);
            cmbSewing.ValueMember = "EmployeeId";
            cmbSewing.DisplayMember = "Name";

            cmbFittings.DataSource = repo.GetEmployee(3);
            cmbFittings.ValueMember = "EmployeeId";
            cmbFittings.DisplayMember = "Name";

            cmbProductType.DataSource = repo.GetProductType();
            cmbProductType.ValueMember = "ProductTypeId";
            cmbProductType.DisplayMember = "Name";

            cmbColor.DataSource = repo.GetColor();
            cmbColor.ValueMember = "ColorId";
            cmbColor.DisplayMember = "Name";

            cmbSize.DataSource = repo.GetSize();
            cmbSize.ValueMember = "SizeId";
            cmbSize.DisplayMember = "SizeName";

            selectedMaterial = new List<SelectedMaterial>();
            bsSelectedMaterial.DataSource = selectedMaterial;
            lbSelectedMaterial.DataSource = bsSelectedMaterial;


            // panel0.Visible = true;
            UpdateTabControl();
        }

        private void UpdateTabControl()
        {
            tabMaterial.TabPages.Clear();
            int index = 0;
            foreach (var page in repo.GetCategories())
            {
                tabMaterial.TabPages.Add(page.Name);
                ListBox l = new ListBox { Size = new System.Drawing.Size(271, 472) };
                tabMaterial.TabPages[index].Controls.Add(l);

                l.DataSource = bmrepo.GetWarehouseMaterials(page.Name);
                index++;
                l.DoubleClick += L_DoubleClick;
            }
        }

        private void L_DoubleClick(object sender, EventArgs e)
        {
            ListBox l = (ListBox)sender;
            WarehouseMaterials res = (WarehouseMaterials)l.SelectedItem;

            SelectedMaterial sl = new SelectedMaterial { MaterialId = res.MaterialId, Category = res.Category, Name = res.Name, CoastPrice = res.CoastPrice };
            AddMaterial addMaterial = new AddMaterial(sl);
            DialogResult dr = addMaterial.ShowDialog();
            if(dr == DialogResult.OK)
            {
                bsSelectedMaterial.Add(sl);

                Material m = Connect.Materials.FirstOrDefault(x => x.MaterialId == res.MaterialId);
                m.Quantity -= sl.Quantity;
                Connect.SaveChanges();
                UpdateTabControl();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
