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
        public Passport()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillPasport flFillPasport = new FillPasport(this);
            this.Enabled = false;
            flFillPasport.Show();
        }
    }
}
