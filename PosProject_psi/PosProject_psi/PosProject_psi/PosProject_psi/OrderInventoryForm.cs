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
    public partial class OrderInventoryForm : Form
    {
        public OrderInventoryForm()
        {
            InitializeComponent();
        }

        private void OrderInventoryForm_Load(object sender, EventArgs e)
        {
            itemGridView.ColumnCount = 4;
            itemGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGridView.Columns[0].Name = "상 품 명";
            itemGridView.Columns[1].Name = "상 품 코 드";
            itemGridView.Columns[2].Name = "단 가";
            itemGridView.Columns[3].Name = "재고수량";

            itemListGrid.ColumnCount = 4;
            itemListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[0].Name = "상 품 명";
            itemListGrid.Columns[1].Name = "상 품 코 드";
            itemListGrid.Columns[2].Name = "단 가";
            itemListGrid.Columns[3].Name = "판 매 가";
        }
    }
}
