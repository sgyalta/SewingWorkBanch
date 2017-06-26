using PassportView.BusinessModel;
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
    public partial class AddMaterial : Form
    {
        SelectedMaterial sl;

        public AddMaterial(SelectedMaterial sl)
        {
            InitializeComponent();
            this.sl = sl;

            tbMaterial.DataBindings.Add("Text", sl, "Name");
            tbCoastPrice.Text = "0";
        }

        private void numericQuant_ValueChanged(object sender, EventArgs e)
        {
            sl.Quantity = (double)numericQuant.Value;
            tbCoastPrice.Text = $"{sl.CalcTotalСost()}";
        }
    }
}
