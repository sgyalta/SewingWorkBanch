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
        public AddPassport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel0.Visible = true;
            this.Width += panel0.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
