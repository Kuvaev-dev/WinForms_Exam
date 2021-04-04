using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamojka
{
    public partial class FirstCalc : Form
    {
        public FirstCalc()
        {
            InitializeComponent();
        }

        private void calcType1_Click(object sender, EventArgs e)
        {
            endCost1.Text = Convert.ToString((Convert.ToInt32(cost_1.Text) / Convert.ToInt32(dvigatel1.Text)) * (Convert.ToInt32(year.Text) / 100));
        }
    }
}
