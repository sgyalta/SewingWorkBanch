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
        FillPasport fp;
        BusinessModelRepo bmrepo = new BusinessModelRepo();
        DbPassportContext Connect = new DbPassportContext();

        BindingSource bsSelectedMaterial = new BindingSource();
        ProductInfo prodInfo;
        List<BindingSource> bsMaterial;
        List<AssignedEmployees> assignedEmployees;
        public List<SelectedMaterial> selectedMaterial;

        public AddPassport(FillPasport fp)
        {
            InitializeComponent();
            this.fp = fp;
            prodInfo = new ProductInfo();
            bsMaterial = new List<BindingSource>();
            assignedEmployees = new List<AssignedEmployees>();

            selectedMaterial = new List<SelectedMaterial>();
            bsSelectedMaterial.DataSource = selectedMaterial;
            dgvSelectedMaterial.DataSource = bsSelectedMaterial;
            dgvSelectedMaterial.Columns["MaterialId"].Visible = false;

            cmbCutting.ValueMember = "EmployeeId";
            cmbCutting.DisplayMember = "Name";
            cmbCutting.DataSource = repo.GetEmployee(1);
            cmbCutting.SelectedIndex = 0;

            cmbSewing.ValueMember = "EmployeeId";
            cmbSewing.DisplayMember = "Name";
            cmbSewing.DataSource = repo.GetEmployee(2);
            cmbSewing.SelectedIndex = 0;

            cmbFittings.ValueMember = "EmployeeId";
            cmbFittings.DisplayMember = "Name";
            cmbFittings.DataSource = repo.GetEmployee(3);
            cmbFittings.SelectedIndex = 0;

            cmbProductType.ValueMember = "ProductTypeId";
            cmbProductType.DisplayMember = "Name";
            cmbProductType.DataSource = repo.GetProductType();
            cmbProductType.SelectedIndex = 0;

            cmbColor.ValueMember = "ColorId";
            cmbColor.DisplayMember = "Name";
            cmbColor.DataSource = repo.GetColor();
            cmbColor.SelectedIndex = 0;

            cmbSize.ValueMember = "SizeId";
            cmbSize.DisplayMember = "SizeName";
            cmbSize.DataSource = repo.GetSize();
            cmbSize.SelectedIndex = 0;

            pbBarCode.Image = Image.FromFile(@"..\\..\\..\\Img\\barcode.png");

            UpdateTabControl();
        }

        private void UpdateTabControl()
        {
            tabMaterial.TabPages.Clear();
            int index = 0;
            foreach (var page in repo.GetCategories())
            {
                tabMaterial.TabPages.Add(page.Name);
                DataGridView dg = new DataGridView { Size = new System.Drawing.Size(271, 472) };
                tabMaterial.TabPages[index].Controls.Add(dg);

                bsMaterial.Add(new BindingSource());
                bsMaterial[index].DataSource = bmrepo.GetWarehouseMaterials(page.CategoryId);
                dg.DataSource = bsMaterial[index];
                dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dg.Columns["MaterialId"].Visible = false;
                dg.ReadOnly = true;
                dg.AllowUserToAddRows = false;

                dg.DoubleClick += Dg_DoubleClick;
                index++;
            }
        }

        private void Dg_DoubleClick(object sender, EventArgs e)
        {
            WarehouseMaterials res = (WarehouseMaterials)bsMaterial[tabMaterial.SelectedIndex].Current;
            bsMaterial[tabMaterial.SelectedIndex].ResetBindings(true);
            if (res.Quantity <= 0)
                return;

            SelectedMaterial sl = new SelectedMaterial { MaterialId = res.MaterialId, Name = res.Name, Price = res.CoastPrice, CategoryId = res.CategoryId };
            AddMaterial addMaterial = new AddMaterial(sl);
            DialogResult dr = addMaterial.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bsSelectedMaterial.ResetBindings(true);
                SelectedMaterial verification = selectedMaterial.FirstOrDefault(x => x.MaterialId == sl.MaterialId);
                if (verification!=null)
                {
                    if (res.Quantity < sl.Quantity)
                    {
                        verification.Quantity += res.Quantity;
                        res.Quantity = 0;
                        UpdateCoast();
                        return;
                    }

                    verification.Quantity += sl.Quantity;
                    res.Quantity -= sl.Quantity;
                    UpdateCoast();
                    return;
                }
                if(res.Quantity < sl.Quantity)
                {
                    sl.Quantity = res.Quantity;
                    res.Quantity = 0;
                    bsSelectedMaterial.Add(sl);
                    UpdateCoast();
                    return;
                }
                bsSelectedMaterial.Add(sl);
                res.Quantity -= sl.Quantity;
            }
            UpdateCoast();
        }

        private void UpdateCoast()
        {
            tbCostPrice.Text = selectedMaterial.Sum(x => x.CoastPrice).ToString();
        }

        private void dgvSelectedMaterial_DoubleClick(object sender, EventArgs e)
        {
            SelectedMaterial sm = (SelectedMaterial)bsSelectedMaterial.Current;
            List<WarehouseMaterials> lm = new List<WarehouseMaterials>();
            bsMaterial[sm.CategoryId - 1].ResetBindings(true);
            var listbsMaterial = bsMaterial[sm.CategoryId-1];
            foreach (var i in listbsMaterial)
                lm.Add((WarehouseMaterials)i);

            WarehouseMaterials wm = lm.FirstOrDefault(x => x.MaterialId == sm.MaterialId);
            wm.Quantity += sm.Quantity;
            bsSelectedMaterial.Remove(sm);
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
           int idProductType = (int)cmbProductType.SelectedValue;
           string path = Connect.ProductTypes.Where(x => x.ProductTypeId == idProductType).Select(x => x.Repository.Path).FirstOrDefault();
           pbProducteType.Image = Image.FromFile(path);
            ProductType p = Connect.ProductTypes.Find(idProductType);
            prodInfo.ProductType = p;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idColor = (int)cmbColor.SelectedValue;
            Model.Color c = Connect.Colors.Find(idColor);
            pbProducteType.BackColor = System.Drawing.Color.FromArgb((int)c.R, (int)c.G, (int)c.B);
            prodInfo.IdColor = idColor;
        }

        private void cmbCutting_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee em = (Employee)cmbCutting.SelectedItem;
            tbCutting.Text = em.Name;
        }

        private void cmbSewing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee em = (Employee)cmbSewing.SelectedItem;
            tbSewing.Text = em.Name;
        }

        private void cmbFittings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee em = (Employee)cmbFittings.SelectedItem;
            tbFittings.Text = em.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbDesc.Text!=string.Empty && tbCostPrice.Text!=string.Empty && numericQuant.Value > 0)
            {
                prodInfo.IdSize = (int)cmbSize.SelectedValue;
                prodInfo.AssignedEmployees = new List<AssignedEmployees> {
                new AssignedEmployees { Employee = (Employee)cmbCutting.SelectedItem, ExperiesDay = dtpCutting.Value},
                new AssignedEmployees{ Employee = (Employee)cmbSewing.SelectedItem, ExperiesDay = dtpSewing.Value},
                new AssignedEmployees{ Employee = (Employee)cmbFittings.SelectedItem, ExperiesDay = dtpFittings.Value}
                };
                prodInfo.SelectedMaterial = selectedMaterial;
                prodInfo.Description = tbDesc.Text;
                prodInfo.CostPrice = Convert.ToDecimal(tbCostPrice.Text);
                prodInfo.Quantity = (double)numericQuant.Value;
                prodInfo.ProductStatusId = 1;

                Random r = new Random();
                prodInfo.SCU = r.Next(100000, 999999).ToString();
                prodInfo.BarCode = r.Next(100000000, 999999999).ToString();

                fp.bsProduct.Add(prodInfo);

                foreach(var it in selectedMaterial)
                {
                    Material m = Connect.Materials.Find(it.MaterialId);
                    m.Quantity -= it.Quantity;
                    Connect.SaveChanges();
                }

                fp.Enabled = true;
                this.Close();             
            }
            
        }

        private void AddPassport_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.Enabled = true;
            this.Dispose();     
        }
    }
}
