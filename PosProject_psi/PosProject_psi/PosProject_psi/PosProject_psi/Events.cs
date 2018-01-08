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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            EventsGridView.ColumnCount = 5;
            EventsGridView.Columns[0].Name = "NO";
            EventsGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventsGridView.Columns[1].Name = "상품명";
            EventsGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventsGridView.Columns[2].Name = "행사이름";
            EventsGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventsGridView.Columns[3].Name = "행사기간";
            EventsGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventsGridView.Columns[4].Name = "행사설명";
            EventsGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new EventsAdd().Show();
        }
    }
}
