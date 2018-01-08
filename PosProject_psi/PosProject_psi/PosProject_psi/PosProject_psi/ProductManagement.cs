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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            product_grid.ColumnCount = 6;
            product_grid.Columns[0].Name = "NO";
            product_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_grid.Columns[1].Name = "상품명";
            product_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_grid.Columns[2].Name = "재고";
            product_grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_grid.Columns[3].Name = "종류";
            product_grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_grid.Columns[4].Name = "가격";
            product_grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_grid.Columns[5].Name = "단가";
            product_grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
