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
    public partial class GarbageProd : Form
    {
        public GarbageProd()
        {
            InitializeComponent();
        }

        private void GarbageProd_Load(object sender, EventArgs e)
        {
            itemGrid.ColumnCount = 5;
            itemGrid.Columns[0].Name = "NO";
            itemGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[1].Name = "상 품 명";
            itemGrid.Columns[2].Name = "상 품 코 드";
            itemGrid.Columns[3].Name = "단 가";
            itemGrid.Columns[4].Name = "수 량";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Month + "월 " + DateTime.Now.Day + "일 " + DateTime.Now.ToLongTimeString();
        }
    }
}
