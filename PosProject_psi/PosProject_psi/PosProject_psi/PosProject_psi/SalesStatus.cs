using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class SalesStatus : Form
    {
        int arraySize;
        SqlDataAdapter adapter;
        List<Sales> Slist = new List<Sales>();
        List<Sales> moneyList = new List<Sales>();
        List<Sales> cardList = new List<Sales>();
        DataSet ds;
        DataGridView myView;
        DataTable EventsTable;
        DataRowCollection rows;
        public SalesStatus()
        {
            InitializeComponent();
        }

        // 시간별 차트
        private void TimesChart_Click(object sender, EventArgs e)
        {
            new TChart().Show();
        }

        // 일별 차트
        private void DaysChart_Click(object sender, EventArgs e)
        {
            int Day1 = 0;
            int Day2 = 0;
            int Day3 = 0;
            int Day4 = 0;
            int Day5 = 0;
            int Day6 = 0;
            int Day7 = 0;
            int Day8 = 0;
            int Day9 = 0;
            int Day10 = 0;
            int Day11 = 0;
            int Day12 = 0;
            int Day13 = 0;
            int Day14 = 0;
            int Day15 = 0;
            int Day16 = 0;
            int Day17 = 0;
            int Day18 = 0;
            int Day19 = 0;
            int Day20 = 0;
            int Day21 = 0;
            int Day22 = 0;
            int Day23 = 0;
            int Day24 = 0;
            int Day25 = 0;
            int Day26 = 0;
            int Day27 = 0;
            int Day28 = 0;
            int Day29 = 0;
            int Day30 = 0;
            int Day31 = 0;

            foreach (var item in Slist)
            {
                switch (item.Sell_Date.Month.ToString())
                {
                    case "1":
                        Day1 += item.Sell_All_Amount;
                        break;
                    case "2":
                        Day2 += item.Sell_All_Amount;
                        break;
                    case "3":
                        Day3 += item.Sell_All_Amount;
                        break;
                    case "4":
                        Day4 += item.Sell_All_Amount;
                        break;
                    case "5":
                        Day5 += item.Sell_All_Amount;
                        break;
                    case "6":
                        Day6 += item.Sell_All_Amount;
                        break;
                    case "7":
                        Day7 += item.Sell_All_Amount;
                        break;
                    case "8":
                        Day8 += item.Sell_All_Amount;
                        break;
                    case "9":
                        Day9 += item.Sell_All_Amount;
                        break;
                    case "10":
                        Day10 += item.Sell_All_Amount;
                        break;
                    case "11":
                        Day11 += item.Sell_All_Amount;
                        break;
                    case "12":
                        Day12 += item.Sell_All_Amount;
                        break;
                    case "13":
                        Day13 += item.Sell_All_Amount;
                        break;
                    case "14":
                        Day14 += item.Sell_All_Amount;
                        break;
                    case "15":
                        Day15 += item.Sell_All_Amount;
                        break;
                    case "16":
                        Day16 += item.Sell_All_Amount;
                        break;
                    case "17":
                        Day17 += item.Sell_All_Amount;
                        break;
                    case "18":
                        Day18 += item.Sell_All_Amount;
                        break;
                    case "19":
                        Day19 += item.Sell_All_Amount;
                        break;
                    case "20":
                        Day20 += item.Sell_All_Amount;
                        break;
                    case "21":
                        Day21 += item.Sell_All_Amount;
                        break;
                    case "22":
                        Day22 += item.Sell_All_Amount;
                        break;
                    case "23":
                        Day23 += item.Sell_All_Amount;
                        break;
                    case "24":
                        Day24 += item.Sell_All_Amount;
                        break;
                    case "25":
                        Day25 += item.Sell_All_Amount;
                        break;
                    case "26":
                        Day26 += item.Sell_All_Amount;
                        break;
                    case "27":
                        Day27 += item.Sell_All_Amount;
                        break;
                    case "28":
                        Day28 += item.Sell_All_Amount;
                        break;
                    case "29":
                        Day29 += item.Sell_All_Amount;
                        break;
                    case "31":
                        Day31 += item.Sell_All_Amount;
                        break;
                }
            }
            DChart dc = new DChart();
            dc.Show();
            dc.chart1.Series["판매액(원)"].Points.AddXY("1일", Day1);
            dc.chart1.Series["판매액(원)"].Points.AddXY("2일", Day2);
            dc.chart1.Series["판매액(원)"].Points.AddXY("3일", Day3);
            dc.chart1.Series["판매액(원)"].Points.AddXY("4일", Day4);
            dc.chart1.Series["판매액(원)"].Points.AddXY("5일", Day5);
            dc.chart1.Series["판매액(원)"].Points.AddXY("6일", Day6);
            dc.chart1.Series["판매액(원)"].Points.AddXY("7일", Day7);
            dc.chart1.Series["판매액(원)"].Points.AddXY("8일", Day8);
            dc.chart1.Series["판매액(원)"].Points.AddXY("9일", Day9);
            dc.chart1.Series["판매액(원)"].Points.AddXY("10일", Day10);
            dc.chart1.Series["판매액(원)"].Points.AddXY("11일", Day11);
            dc.chart1.Series["판매액(원)"].Points.AddXY("12일", Day12);
            dc.chart1.Series["판매액(원)"].Points.AddXY("13일", Day13);
            dc.chart1.Series["판매액(원)"].Points.AddXY("14일", Day14);
            dc.chart1.Series["판매액(원)"].Points.AddXY("15일", Day15);
            dc.chart1.Series["판매액(원)"].Points.AddXY("16일", Day16);
            dc.chart1.Series["판매액(원)"].Points.AddXY("17일", Day17);
            dc.chart1.Series["판매액(원)"].Points.AddXY("18일", Day18);
            dc.chart1.Series["판매액(원)"].Points.AddXY("19일", Day19);
            dc.chart1.Series["판매액(원)"].Points.AddXY("20일", Day20);
            dc.chart1.Series["판매액(원)"].Points.AddXY("21일", Day21);
            dc.chart1.Series["판매액(원)"].Points.AddXY("22일", Day22);
            dc.chart1.Series["판매액(원)"].Points.AddXY("23일", Day23);
            dc.chart1.Series["판매액(원)"].Points.AddXY("24일", Day24);
            dc.chart1.Series["판매액(원)"].Points.AddXY("25일", Day25);
            dc.chart1.Series["판매액(원)"].Points.AddXY("26일", Day26);
            dc.chart1.Series["판매액(원)"].Points.AddXY("27일", Day27);
            dc.chart1.Series["판매액(원)"].Points.AddXY("28일", Day28);
            dc.chart1.Series["판매액(원)"].Points.AddXY("29일", Day29);
            dc.chart1.Series["판매액(원)"].Points.AddXY("30일", Day30);
            dc.chart1.Series["판매액(원)"].Points.AddXY("31일", Day31);
        }

        // 월별 차트
        private void MonthsChart_Click(object sender, EventArgs e)
        {
            int month1 = 0;
            int month2 = 0;
            int month3 = 0;
            int month4 = 0;
            int month5 = 0;
            int month6 = 0;
            int month7 = 0;
            int month8 = 0;
            int month9 = 0;
            int month10 = 0;
            int month11 = 0;
            int month12 = 0;

            foreach (var item in Slist)
            {
                switch (item.Sell_Date.Month.ToString())
                {
                    case "1":
                        month1 += item.Sell_All_Amount;
                        break;
                    case "2":
                        month2 += item.Sell_All_Amount;
                        break;
                    case "3":
                        month3 += item.Sell_All_Amount;
                        break;
                    case "4":
                        month4 += item.Sell_All_Amount;
                        break;
                    case "5":
                        month5 += item.Sell_All_Amount;
                        break;
                    case "6":
                        month6 += item.Sell_All_Amount;
                        break;
                    case "7":
                        month7 += item.Sell_All_Amount;
                        break;
                    case "8":
                        month8 += item.Sell_All_Amount;
                        break;
                    case "9":
                        month9 += item.Sell_All_Amount;
                        break;
                    case "10":
                        month10 += item.Sell_All_Amount;
                        break;
                    case "11":
                        month11 += item.Sell_All_Amount;
                        break;
                    case "12":
                        month12 += item.Sell_All_Amount;
                        break;
                }
            }
            MChart mc = new MChart();
            mc.Show();
            mc.chart1.Series["판매액(원)"].Points.AddXY("1월", month1);
            mc.chart1.Series["판매액(원)"].Points.AddXY("2월", month2);
            mc.chart1.Series["판매액(원)"].Points.AddXY("3월", month3);
            mc.chart1.Series["판매액(원)"].Points.AddXY("4월", month4);
            mc.chart1.Series["판매액(원)"].Points.AddXY("5월", month5);
            mc.chart1.Series["판매액(원)"].Points.AddXY("6월", month6);
            mc.chart1.Series["판매액(원)"].Points.AddXY("7월", month7);
            mc.chart1.Series["판매액(원)"].Points.AddXY("8월", month8);
            mc.chart1.Series["판매액(원)"].Points.AddXY("9월", month9);
            mc.chart1.Series["판매액(원)"].Points.AddXY("10월", month10);
            mc.chart1.Series["판매액(원)"].Points.AddXY("11월", month11);
            mc.chart1.Series["판매액(원)"].Points.AddXY("12월", month12);
        }

        // 연도별 차트
        private void YearsChart_Click(object sender, EventArgs e)
        {
            new YChart().Show();
        }

        // 매출 현황 그리드뷰에 띄우기
        private void SalesStatus_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SellCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    ds = new DataSet();
                    con.Open();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    rows = pro.Rows;
                    foreach (DataRow er in rows)
                    {
                        arraySize = int.Parse(er[0].ToString());
                    }
                }
            }

            string[] sell_date = new string[arraySize];
            string[] sell_all_amount = new string[arraySize];
            string[] sell_pure = new string[arraySize];
            string[] sell_select = new string[arraySize];

            // 판매 날짜
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SalesDate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    ds = new DataSet();
                    con.Open();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    DataRowCollection rows = pro.Rows;

                    for (int i = 0; i < rows.Count; i++)
                    {
                        sell_date[i] = rows[i].ItemArray[0].ToString();
                    }
                }
            }

            // 판매 총액
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                for (int i = 1; i <= sell_date.Length; i++)
                {
                    var cmd = new SqlCommand("SalesAll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@i", i);
                    ds = new DataSet();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    DataRowCollection rows = pro.Rows;
                    sell_all_amount[i - 1] = rows[0].ItemArray[0].ToString();
                    ds.Clear();
                }
            }

            // 판매 순수익
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                for (int i = 1; i <= sell_date.Length; i++)
                {
                    var cmd = new SqlCommand("SalesPure", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@i", i);
                    ds = new DataSet();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    DataRowCollection rows = pro.Rows;
                    sell_pure[i - 1] = rows[0].ItemArray[0].ToString();
                    ds.Clear();
                }
            }

            // 결제 수단
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SalesSelect", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    ds = new DataSet();
                    con.Open();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    DataRowCollection rows = pro.Rows;

                    for (int i = 0; i < rows.Count; i++)
                    {
                        sell_select[i] = rows[i].ItemArray[0].ToString();
                    }
                }
            }

            // 리스트에 넣기
            for (int i = 0; i < sell_all_amount.Length; i++)
            {
                Slist.Add(new Sales { Sell_Date = DateTime.Parse(sell_date[i].ToString()), Sell_All_Amount = int.Parse(sell_all_amount[i]), Sell_pure_Money = int.Parse(sell_pure[i]), Sell_Select = sell_select[i].ToString() });
            }

            SStatusGridView.DataSource = Slist;
            SStatusGridView.Columns[0].HeaderText = "날짜";
            SStatusGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView.Columns[1].HeaderText = "판매액";
            SStatusGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView.Columns[2].HeaderText = "순수익";
            SStatusGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView.Columns[3].HeaderText = "결제수단";
            SStatusGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < SStatusGridView.RowCount; i++)
            {
                if (SStatusGridView.Rows[i].Cells[3].Value.ToString() == "money")
                {
                    moneyList.Add(new Sales { Sell_Date = DateTime.Parse(SStatusGridView.Rows[i].Cells[0].Value.ToString()), Sell_All_Amount = int.Parse(SStatusGridView.Rows[i].Cells[1].Value.ToString()), Sell_pure_Money = int.Parse(SStatusGridView.Rows[i].Cells[2].Value.ToString()), Sell_Select = SStatusGridView.Rows[i].Cells[3].Value.ToString() });
                }
                else if (SStatusGridView.Rows[i].Cells[3].Value.ToString() == "card")
                {
                    cardList.Add(new Sales { Sell_Date = DateTime.Parse(SStatusGridView.Rows[i].Cells[0].Value.ToString()), Sell_All_Amount = int.Parse(SStatusGridView.Rows[i].Cells[1].Value.ToString()), Sell_pure_Money = int.Parse(SStatusGridView.Rows[i].Cells[2].Value.ToString()), Sell_Select = SStatusGridView.Rows[i].Cells[3].Value.ToString() });
                }
            }
        }

        // 그리드뷰 현금 보기
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SStatusGridView.DataSource = moneyList;
            }
        }

        // 그리드뷰 카드 보기
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                SStatusGridView.DataSource = cardList;
            }
        }

        // 그리드뷰 전체 보기
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                SStatusGridView.DataSource = Slist;
            }
        }

        // 데이터 타임 피커
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string[] sell_date = new string[arraySize];
            string[] sell_all_amount = new string[arraySize];
            string[] sell_pure = new string[arraySize];
            string[] sell_select = new string[arraySize];

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();
                dateTimePicker1.Value.ToShortDateString();

                var cmd = new SqlCommand("SalesTimePicker", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sell_date", dateTimePicker1.Value.ToShortDateString());
                ds = new DataSet();
                adapter = DbMan.DbAdap(adapter);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                DataTable pro = ds.Tables[0];
                DataRowCollection rows = pro.Rows;

                ds.Clear();
                con.Close();

                List<Sales> temp =new List<Sales>();
                SStatusGridView.DataSource = null;
                foreach (var item in Slist)
                {
                    int flag = DateTime.Compare(DateTime.Parse(item.Sell_Date.ToShortDateString()), DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
                    if (flag == 0)
                    {
                        temp.Add(new Sales { Sell_Date = item.Sell_Date, Sell_All_Amount = item.Sell_All_Amount, Sell_pure_Money = item.Sell_pure_Money, Sell_Select =item.Sell_Select });                 
                    }
                }
          
                SStatusGridView.DataSource = temp;
                SStatusGridView.Columns[0].HeaderText = "날짜";
                SStatusGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SStatusGridView.Columns[1].HeaderText = "판매액";
                SStatusGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SStatusGridView.Columns[2].HeaderText = "순수익";
                SStatusGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SStatusGridView.Columns[3].HeaderText = "결제수단";
                SStatusGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}