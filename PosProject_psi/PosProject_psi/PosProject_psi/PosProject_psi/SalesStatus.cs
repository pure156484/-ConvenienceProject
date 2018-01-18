using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class SalesStatus : Form
    {
        public SalesStatus()
        {
            InitializeComponent();
        }

        private void TimesChart_Click(object sender, EventArgs e)
        {
            new TChart().Show();
        }

        private void DaysChart_Click(object sender, EventArgs e)
        {
            new DChart().Show();
        }

        private void MonthsChart_Click(object sender, EventArgs e)
        {
            new MChart().Show();
        }

        private void YearsChart_Click(object sender, EventArgs e)
        {
            new YChart().Show();
        }
    }
}
