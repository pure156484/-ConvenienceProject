using CommonProject;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            itemGrid.ColumnCount = 6;
            itemGrid.Columns[0].Name = "NO";
            itemGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[1].Name = "상 품 명";
            itemGrid.Columns[2].Name = "상 품 코 드";
            itemGrid.Columns[3].Name = "단 가";
            itemGrid.Columns[4].Name = "수 량";
            itemGrid.Columns[5].Name = "할 인";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Close();
            new GarbageProd().Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.Month + "월 " + DateTime.Now.Day + "일 " + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Validate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Setting().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MembershipManagement().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Receipt().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Events().Show();
        }
            private void button10_Click(object sender, EventArgs e)
            {
                new ProductManagement().Show();
            }
        
    } }
