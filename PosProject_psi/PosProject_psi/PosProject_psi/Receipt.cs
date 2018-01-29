using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeepAutomation.Barcode.Bean;
using BusinessRefinery.Barcode;

namespace PosProject_psi
{
    public partial class Receipt : Form
    {
        List<SellItem> sellList = new List<SellItem>();
        MainForm m = new MainForm();
        string gender = "";
        string cardcomDis = "";
        bool pay; // 현금
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        DataSet ds;
        string[] sellBar = new string[1000];
        string[] SellDate;
        string[] SellSelect;
        int[] SellTotMoney;
        public Receipt()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            ReceiptGridView.ColumnCount = 4;
            ReceiptGridView.Columns[0].Name = "NO";
            ReceiptGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[1].Name = "거래시간";
            ReceiptGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[2].Name = "거래형태";
            ReceiptGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[3].Name = "금액";
            ReceiptGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            SellGrid();
            SellGridTime();
            SellGridMoney();
            for (int i = 0; i < SellSelect.Length; i++)
            {
                ReceiptGridView.Rows.Add(sellBar[i].ToString(), SellDate[i].ToString(), SellSelect[i].ToString(),SellTotMoney[i].ToString());
            }
            ReceiptViewList();
        }

        // 리스트에 그리드뷰 내용 추가하기
        private void ReceiptViewList()
        {
            for (int i = 0; i < ReceiptGridView.Rows.Count; i++)
            {
                sellList.Add(new SellItem() { Sellbarcode = ReceiptGridView.Rows[i].Cells[0].Value.ToString(), Selldate = ReceiptGridView.Rows[i].Cells[1].Value.ToString(), SellPaySel = ReceiptGridView.Rows[i].Cells[2].Value.ToString(), SellPayTot = int.Parse(ReceiptGridView.Rows[i].Cells[3].Value.ToString()) });
                
            }
        }

        // 총금액 조회
        private void SellGridMoney()
        {
            int j = 0;
            SellTotMoney = new int[SellDate.Length];
            for (int i = 0; i < SellDate.Length; i++)
            {
                using (var con = DbMan.Dbcon(sqlcon))
                {
                    using (var cmd = new SqlCommand("SellBarcodeSelect3", con))
                    {
                        cmd.Parameters.AddWithValue("@sellbar", sellBar[i].ToString());
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        adapter = DbMan.DbAdap(adapter);
                        adapter.SelectCommand = cmd;
                        ds = DbMan.DbDs(ds);
                        adapter.Fill(ds);
                        DataTable pro = ds.Tables[0];
                        DataRowCollection rows = pro.Rows;
                        foreach (DataRow ed in rows)
                        {
                                SellTotMoney[j] += int.Parse(ed[0].ToString());
                        }
                        j++;
                    }
                }
            }
        }

        // 바코드 번호 조회 그리드뷰 띄우기
        private void SellGrid()
        {
            using (var con = DbMan.Dbcon(sqlcon))
            {
                using (var cmd = new SqlCommand("SellBarcodeSelect", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = DbMan.DbAdap(adapter);
                    adapter.SelectCommand = cmd;
                    ds = DbMan.DbDs(ds);
                    adapter.Fill(ds);
                    DataTable pro = ds.Tables[0];
                    DataRowCollection rows = pro.Rows;
                    foreach (DataRow ed in rows)
                    {
                        ReceiptGridView.Rows.Add(ed[0].ToString());
                    }

                    for (int i = 0; i < ReceiptGridView.Rows.Count; i++)
                    {
                        sellBar[i] = ReceiptGridView.Rows[i].Cells[0].Value.ToString();
                    }
                    ReceiptGridView.Rows.Clear();
                }
            }
        }

        // 바코드 번호로 시간 지불방법 조회 띄우기
        private void SellGridTime()
        {
            int j = 0;
            int count = 0;
            for (int i = 0; i < sellBar.Length; i++)
            {
                if (sellBar[i] != null)
                {
                    count = i + 1;
                }
            }
            SellDate = new string[count];
            SellSelect = new string[count];
            //MessageBox.Show(sellBar[0].ToString());
            for (int i = 0; i < SellDate.Length; i++)
            {
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("SellBarcodeSelect2", con);
                cmd.Parameters.AddWithValue("@sellbar", sellBar[i].ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                adapter = DbMan.DbAdap(adapter);
                adapter.SelectCommand = cmd;
                ds = DbMan.DbDs(ds);
                adapter.Fill(ds);
                DataTable pro = ds.Tables[0];
                DataRowCollection rows = pro.Rows;
                foreach (DataRow ed in rows)
                {
                        SellDate[j] = ed[0].ToString();
                        SellSelect[j] = ed[1].ToString();
                }
                j++;
            }
        }

        // 그리드뷰 클릭시 영수증 표출
        private void ReceiptGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //기본정보
            txtReceipt.Text = "";
            Setting st = new Setting();
            txtReceipt.Text += "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            txtReceipt.Text += "********************************************";
            txtReceipt.Text += "****************영수증발행인쇄**************\r\n";
            txtReceipt.Text += "********************************************";
            txtReceipt.Text += st.txtShopName.Text + "\r\n";
            txtReceipt.Text += "사업자등록번호 : " + st.txtCeoNum.Text + "\r\n";
            txtReceipt.Text += st.txtAddr.Text + "\r\n";
            txtReceipt.Text += st.txtCeoName.Text + "  TEL : " + st.txtPhone.Text + "\r\n";
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "정부방침에 의해 12년7월1일부터 현금 결제 취소시, 영수증이 없으면 교환/환불이 불가합니다.\r\n";
            txtReceipt.Text += "\r\n";
            ReceiptView(); // 날짜 띄우기 및 결제수단판별
            txtReceipt.Text += "\r\n";
            if (pay)
            {
                CardPayReceipt();
            }
            else if (!pay)
            {
                MoneyPayReceipt();
            }
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "환불 : 30일내 영수증/카드지참시 가능\r\n";
            txtReceipt.Text += "객층 : " + gender + "      담당 : " + m.label4.Text + "  " + DateTime.Now.ToShortTimeString();
            ReceiptBarcodePic();
            ReceiptBarcodeQR();
        }

        // 현금결제 영수증 표출
        private void MoneyPayReceipt()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ReceiptMoneyPay", con);
            cmd.Parameters.AddWithValue("@sellbar", ReceiptGridView.CurrentRow.Cells[0].Value.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;
            string view = "";
            foreach (DataRow ed in rows)
            {
                if ((ed[0].ToString() + "                                          ").Length > 18)
                {
                    view = (ed[0].ToString() + "                                        ").Substring(0, 20);
                }
                txtReceipt.Text += view + "      " + ed[1].ToString() + "                " + ed[2].ToString() + "\r\n";
            }
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "********************현 금******************\r\n";
            txtReceipt.Text += "총 구 매 액                 ";
            int count = 0;
            foreach (DataRow ed in rows)
            {
                count += int.Parse(ed[4].ToString());
                gender = ed[3].ToString();
            }
            txtReceipt.Text += count.ToString();
            txtReceipt.Text += "                " + ReceiptGridView.CurrentRow.Cells[3].Value.ToString();
            txtReceipt.Text += "\r\n--------------------------------------------\r\n";
            txtReceipt.Text += "내   실   돈                                  " + ReceiptGridView.CurrentRow.Cells[3].Value.ToString();
            txtReceipt.Text += "\r\n받 은 금 액                                  ";
            string givmoney = "";
            foreach (DataRow ed in rows)
            {
                givmoney = ed[5].ToString();
            }
            txtReceipt.Text += givmoney;
            txtReceipt.Text += "\r\n거 스 름 돈                                  " + (int.Parse(givmoney) - int.Parse(ReceiptGridView.CurrentRow.Cells[3].Value.ToString())).ToString();
        }

        // 영수증 QR코드 생성
        private void ReceiptBarcodeQR()
        {
            QRCode barcode = new QRCode();
            string url = ReceiptGridView.CurrentRow.Cells[0].Value.ToString().Trim();
            barcode.Code = url;
            barcode.ModuleSize = 6.0f;
            barcode.Resolution = 300;
            pictureBox3.Image = new Bitmap(barcode.drawBarcodeOnBitmap());
        }

        // 영수증 바코드 생성
        private void ReceiptBarcodePic()
        {
            BarCode barcode = new BarCode();
            barcode.Symbology = KeepAutomation.Barcode.Symbology.Code128A;
            barcode.CodeToEncode = ReceiptGridView.CurrentRow.Cells[0].Value.ToString().Trim();
            barcode.ChecksumEnabled = true;
            barcode.X = 1;
            barcode.Y = 50;
            barcode.BarCodeWidth = 100;
            barcode.BarCodeHeight = 70;
            barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree90;
            barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
            barcode.DPI = 72;
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Gif;
            //barcode.generateBarcodeToImageFile(@"C:\Users\gd3-12\Desktop\barcode-code39-csharp.gif");
            Bitmap b = new Bitmap(barcode.generateBarcodeToBitmap());
            b.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = b;
            
        }

        // 카드결제 영수증 표출
        private void CardPayReceipt()
        { 
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ReceiptCardPay", con);
            cmd.Parameters.AddWithValue("@sellbar", ReceiptGridView.CurrentRow.Cells[0].Value.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;
            string view = "";
            foreach (DataRow ed in rows)
            {
                if ((ed[2].ToString() + "                                          ").Length > 18)
                {
                    view = (ed[2].ToString() + "                                        ").Substring(0, 20);
                }
                txtReceipt.Text += view + "      " + ed[3].ToString() + "                " + ed[4].ToString() + "\r\n";
            }
            txtReceipt.Text += "\r\n*****************신 용 카 드***************\r\n";
            string cardnum = "";
            string cardcom = "";
            foreach (DataRow ed in rows)
            {
                cardnum = ed[0].ToString();
                cardcom = ed[1].ToString();
            }
            txtReceipt.Text += "카드번호 : " + cardnum;
            txtReceipt.Text += "\r\n카드회사 : " + cardcom;
            txtReceipt.Text += "\r\n할부개월 : 00                  승인번호 : " + Math.Abs(cardnum.GetHashCode());
            txtReceipt.Text += "\r\n--------------------------------------------\r\n";
            txtReceipt.Text += "총 구 매 액                 ";
            int count = 0;
            foreach (DataRow ed in rows)
            {
                count += int.Parse(ed[6].ToString());
                gender = ed[5].ToString();
            }
            txtReceipt.Text += count.ToString();
            txtReceipt.Text += "                " + ReceiptGridView.CurrentRow.Cells[3].Value.ToString();
            txtReceipt.Text += "\r\n--------------------------------------------\r\n";
            txtReceipt.Text += "내   실   돈                                  ";
            CardSelectCase(cardcom);
            string givcard = "";
            foreach (DataRow ed in rows)
            {
                givcard = ed[7].ToString();
            }
            txtReceipt.Text += givcard + "\r\n";
            txtReceipt.Text += "신 용 카 드                                  " + givcard;
            txtReceipt.Text += "\r\n\t\t" + cardcom + cardcomDis + "\r\n";
        }

        // 카드회사 구별로 할인파악
        private void CardSelectCase(string cardcomDis2)
        {
            switch (cardcomDis2)
            {
                case "신한카드":
                    cardcomDis = " 3% 할인!";
                    break;
                case "BC카드":
                    cardcomDis = " 2% 할인!";
                    break;
                case "비씨카드":
                    cardcomDis = " 5% 할인!";
                    break;
                case "NH농협카드":
                    cardcomDis = " 2% 할인!";
                    break;
                case "KB카드":
                    cardcomDis = " 1% 할인!";
                    break;
                case "롯데카드":
                    cardcomDis = " 3% 할인!";
                    break;
                case "삼성카드":
                    cardcomDis = " 1% 할인!";
                    break;
                default:
                    cardcomDis = " 할인없음!";
                    break;
            }
        }

        // 날짜 띄우기 및 결제수단판별
        private void ReceiptView()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("SellBarcodeSelect2", con);
            cmd.Parameters.AddWithValue("@sellbar", ReceiptGridView.CurrentRow.Cells[0].Value.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;
            foreach (DataRow ed in rows)
            {
                txtReceipt.Text += txtReceipt.GetHashCode().ToString() + "       " + ed[0].ToString() + "\r\n";
                if (ed[1].ToString() != "money")
                {
                    pay = true;
                }
                else
                {
                    pay = false;
                }
            }
        }

        // 바코드로 검색하기 
        private void btnBarcodeSearch_Click(object sender, EventArgs e)
        {
            ReceiptGridView.Rows.Clear();
            foreach (var item in sellList)
            {
                if(txtbarcode.Text.Trim() == item.Sellbarcode.Trim())
                {
                    ReceiptGridView.Rows.Add(item.Sellbarcode, item.Selldate, item.SellPaySel, item.SellPayTot);
                }
            }
        }

        // 현재시각
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        // 시간으로 조회하기
        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            if(cboTime1.Text  == "" || cboTime2.Text == "")
            {
                MessageBox.Show("시간을 모두 입력해주세요");
                return;
            }
            string timeSel = "오전";
            string timeSel2 = "오전";
            int time1 = 0;
            int time2 = 0;

            if (int.Parse(cboTime1.Text.Substring(0, 2)) > 12)
            {
                timeSel = "오후";
                time1 = int.Parse(cboTime1.Text.Substring(0, 2));
            }
            else
            {
                timeSel = "오전";
                time1 = int.Parse(cboTime1.Text.Substring(0, 2));
            }

            if (int.Parse(cboTime2.Text.Substring(0, 2)) > 12)
            {
                timeSel2 = "오후";
                time2 = int.Parse(cboTime2.Text.Substring(0, 2));
            }
            else
            {
                timeSel2 = "오전";
                time2 = int.Parse(cboTime2.Text.Substring(0, 2));
            }

            if (int.Parse(cboTime1.Text.Substring(0, 2)) > int.Parse(cboTime2.Text.Substring(0, 2)))
            {
                MessageBox.Show("시간을 알맞게 입력해주세요");
                return;
            }
            foreach (var item in sellList)
            {
                
                if (item.Selldate.Substring(0,10) == dateTimePicker1.Value.ToShortDateString())
                {
                    int datetime = 0;
                    if (item.Selldate.Substring(11, 2) == "오후")
                    {
                        datetime = (int.Parse(item.Selldate.Substring(14, 2).Replace(":", ""))) + 12; 
                    }
                    else
                    {
                        datetime = (int.Parse(item.Selldate.Substring(14, 2).Replace(":", "")));
                    }

                    if (datetime >= time1 && datetime <= time2)
                    {
                        ReceiptGridView.Rows.Clear();
                        ReceiptGridView.Rows.Add(item.Sellbarcode, item.Selldate, item.SellPaySel, item.SellPayTot);
                    }
                }
                else
                {
                    MessageBox.Show("조회항목이 없습니다.");
                    return;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(txtReceipt.Width, txtReceipt.Height);
            //Bitmap bmp = new Bitmap(this.Width, this.Height);
            //this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            //bmp.Save(@"C:\Users\gd3-12\Desktop\test.png");
            Bitmap bt = new Bitmap(txtReceipt.Width, txtReceipt.Height);
            Graphics g = Graphics.FromImage(bt);
            Point xp = PointToScreen(new Point(txtReceipt.Location.X, 0));
            Point yp = PointToScreen(new Point(0, txtReceipt.Location.Y));
            //여기서 시작 포지션...그리고 0,0 하고 사이즈 정해주면 그 만큼 캡쳐를함
            //이때 좌표를 프로세스 내 좌표를 할 지 스크린 좌표로 할 지 그것만 정하면 됨
            g.CopyFromScreen(
                xp.X,
                yp.Y,
                0,//this.Location.X + this.Width,
                0,//this.Location.Y + this.Height,
                new Size(bt.Width, bt.Height));
            bt.Save(@"C:\Users\gd3-12\Desktop\test.png", System.Drawing.Imaging.ImageFormat.Bmp);
            ReceiptPrint rp = new ReceiptPrint();
            rp.pictureBox1.Image = bt;
            rp.StartPosition = this.StartPosition;
            rp.Show();
            Clipboard.SetImage((Image)bt);
        }

        private void btn_Refund_Click(object sender, EventArgs e)
        {

        }
    }
}
