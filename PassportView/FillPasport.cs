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
using PassportView.BusinessModel;
using PassportView.Model;
using System.Data.Entity.Migrations;

namespace PassportView
{
    public partial class FillPasport : Form
    {
        private Passport _passport;
        private BusinessModelRepo bmr = new BusinessModelRepo();
        private DbPassportContext Connect = new DbPassportContext();
        private Repositer _repository = new Repositer();
        private BindingSource _bgCustumers = new BindingSource();
        private List<ProductInfo> productInfo;
        public BindingSource bsProduct = new BindingSource();


        public FillPasport(Passport p)
        {
            InitializeComponent();

            productInfo = new List<BusinessModel.ProductInfo>();
            _passport = p;
           
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "CustumerId";
            _bgCustumers.DataSource = _repository.GetCustomers();
            cmbCustomer.DataSource = _bgCustumers;
            cmbCustomer.SelectedIndex = 0;

            bsProduct.DataSource = productInfo;
            lbProduct.DataSource = bsProduct;

            tbTatalCost.Text = "0";

            Random r = new Random();
            tbNumberOrder.Text = r.Next(1000, 1000000000).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassport addPassport = new AddPassport(this);
            this.Enabled = false;
            addPassport.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ProductInfo pi = (ProductInfo)bsProduct.Current;

            //foreach (var it in pi.SelectedMaterial)
            //{
            //    Material m = Connect.Materials.Find(it.MaterialId);
            //    m.Quantity += it.Quantity;
            //    Connect.SaveChanges();
            //}

            ReturnMaterial(pi.SelectedMaterial);

            bsProduct.Remove(pi);
            UpdateCoast();

        }

        private void ReturnMaterial(List<SelectedMaterial> sm)
        {
            foreach (var it in sm)
            {
                Material m = Connect.Materials.Find(it.MaterialId);
                m.Quantity += it.Quantity;
                Connect.SaveChanges();
            }
        }

        private void FillPasport_EnabledChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            UpdateCoast();
        }

        private void UpdateCoast()
        {
            tbTatalCost.Text = productInfo.Sum(x => x.CostPrice).ToString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lbProduct.Items.Count > 0)
            {
                Order o = new Order
                {
                    OrderNumber = tbNumberOrder.Text,
                    CustomerId = (int)cmbCustomer.SelectedValue,
                    DateBegin = DateTime.Now,
                    Expiress = dtpExpiress.Value,
                    ProductStatusId = 1,
                    CostPriceOrder = Convert.ToDecimal(tbTatalCost.Text)
                };

                Connect.Orders.AddOrUpdate(o);
                Connect.SaveChanges();

                int OrderId = o.OrderId;

                foreach (var product in productInfo)
                {
                    ProductProperty pp = new ProductProperty { ColorId = product.IdColor, SizeId = product.IdSize, ProductTypeId = product.ProductType.ProductTypeId };
                    Connect.ProductProperties.AddOrUpdate(pp);
                    Connect.SaveChanges();

                    int PropertiId = pp.ProductPropertyId;

                    Product pr = new Product
                    {
                        Description = product.Description,
                        BarCode = product.BarCode,
                        PropertyId = PropertiId,
                        CostPrice = product.CostPrice,
                        Quantity = (int)product.Quantity,
                        StatusId = 1,
                        IsMade = false,
                        SCU = product.SCU
                    };

                    Connect.Products.AddOrUpdate(pr);
                    Connect.SaveChanges();

                    int ProductId = pr.ProductId;

                    foreach(var emp in product.AssignedEmployees)
                    {
                        ProductMaker pm = new ProductMaker
                        {
                            EmloyeeId = emp.Employee.EmployeeId,
                            ExperiesDay = emp.ExperiesDay,
                            ProductId = ProductId
                        };

                        Connect.ProductMakers.AddOrUpdate(pm);
                        Connect.SaveChanges();
                    }

                    foreach(var material in product.SelectedMaterial)
                    {
                        MaterialUsed mu = new MaterialUsed
                        {
                            MaterialId = material.MaterialId,
                            Quant = material.Quantity,
                            TotalCoast = (decimal)material.CoastPrice,
                            ProductId = ProductId
                        };

                        Connect.MaterialUseds.AddOrUpdate(mu);
                        Connect.SaveChanges();
                    }

                    OrderProduct op = new OrderProduct
                    {
                        ProductId = ProductId,
                        OrderId = OrderId
                    };

                    Connect.OrderProducts.AddOrUpdate(op);
                    Connect.SaveChanges();

                    _passport.BsOrderModels.Add(bmr.GetOrdersModel(OrderId));

                    _passport.Enabled = true;
                    this.Close();
                }
            }
        }

        private void FillPasport_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var product in productInfo)
                ReturnMaterial(product.SelectedMaterial);

            _passport.Enabled = true;
            this.Dispose();
        }
    }
}
