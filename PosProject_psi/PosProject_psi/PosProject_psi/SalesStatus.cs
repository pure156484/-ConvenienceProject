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
using Excel = Microsoft.Office.Interop.Excel;

namespace PosProject_psi
{
    public partial class SalesStatus : Form
    {
        DataSet ds;
        DataGridView myView;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        string dayValue = null;

        public SalesStatus()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 일별 차트 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DaysChart_Click(object sender, EventArgs e)
        {
            ChartDay cd = new ChartDay();
            cd.StartPosition = this.StartPosition;
            cd.Show();
        }

        /// <summary>
        /// 월별 차트 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonthsChart_Click(object sender, EventArgs e)
        {
            ChartMonth cm = new ChartMonth();
            cm.StartPosition = this.StartPosition;
            cm.Show();
        }
        
        /// <summary>
        /// 연도별 차트 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearsChart_Click(object sender, EventArgs e)
        {
            ChartYear cy = new ChartYear();
            cy.StartPosition = this.StartPosition;
            cy.Show();
        }


        /// <summary>
        /// 매출 현황 날짜검색 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            dayValue = dtpDaySearch.Value.ToString("yyyyMMdd");
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewSellDateDay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dayValue", dayValue);
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);

            if (rboAll.Checked) // 전체 라디오 버튼 체크
            {
                SStatusGridView_Date_Setting(ds,0);
            }
            else if (rboCard.Checked) // 카드 라디오 버튼 체크
            {
                SStatusGridView_Date_Setting(ds,2);
            }
            else if (rboMoney.Checked) // 카드 라디오 버튼 체크
            {
                SStatusGridView_Date_Setting(ds,1);
            }
            else
            {
                MessageBox.Show("결제 수단을 선택 해 주세요.");
            }
        }

        /// <summary>
        /// 매출 현황 그리드 뷰 설정
        /// </summary>
        /// <param name="ds"></param>
        private void SStatusGridView_Date_Setting(DataSet ds, int selectNum)
        {
            SStatusGridView_Date.Rows.Clear();

            myView = new DataGridView();

            SStatusGridView_Date.ColumnCount = 7;
            SStatusGridView_Date.Columns[0].HeaderText = "날짜";
            SStatusGridView_Date.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[1].HeaderText = "바코드";
            SStatusGridView_Date.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[2].HeaderText = "상품명";
            SStatusGridView_Date.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[3].HeaderText = "판매액";
            SStatusGridView_Date.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[4].HeaderText = "순수익";
            SStatusGridView_Date.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[5].HeaderText = "결제수단";
            SStatusGridView_Date.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_Date.Columns[6].Visible = false;

            memberTable = ds.Tables[selectNum];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString()
                };
                SStatusGridView_Date.Rows.Add(row);
            }
        }

        /// <summary>
        /// 성별/연령대 데이터 가져오기
        /// </summary>
        private void AgeGenderView()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewSellDateAgeGender_All", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            SStatusGridView_GenderAge_Setting(ds);
        }

        /// <summary>
        /// 성별 연령대 그리드뷰 설정
        /// </summary>
        /// <param name="ds"></param>
        private void SStatusGridView_GenderAge_Setting(DataSet ds)
        {
            SStatusGridView_GenderAge.Rows.Clear();

            myView = new DataGridView();

            SStatusGridView_GenderAge.ColumnCount = 9;
            SStatusGridView_GenderAge.Columns[0].HeaderText = "날짜";
            SStatusGridView_GenderAge.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[1].HeaderText = "바코드";
            SStatusGridView_GenderAge.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[2].HeaderText = "상품명";
            SStatusGridView_GenderAge.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[3].HeaderText = "판매액";
            SStatusGridView_GenderAge.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[4].HeaderText = "순수익";
            SStatusGridView_GenderAge.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[5].HeaderText = "결제수단";
            SStatusGridView_GenderAge.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[6].HeaderText = "성별";
            SStatusGridView_GenderAge.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[7].HeaderText = "연령대";
            SStatusGridView_GenderAge.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SStatusGridView_GenderAge.Columns[8].Visible = false;

            memberTable = ds.Tables[0];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr_p in rows)
            {
                string[] row =
                {
                    dr_p[0].ToString(), dr_p[1].ToString(), dr_p[2].ToString(), dr_p[3].ToString(), dr_p[4].ToString(), dr_p[5].ToString(), dr_p[6].ToString(), dr_p[7].ToString()
                };
                SStatusGridView_GenderAge.Rows.Add(row);
            }
        }

        /// <summary>
        /// 성별/연령대 조건 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgeGender_Click(object sender, EventArgs e)
        {
            if (CheckCbo())
            {
                string gender = "";

                if (cboGender.SelectedIndex == 0)
                {
                    gender = "(남)";
                }
                else if (cboGender.SelectedIndex == 1)
                {
                    gender = "(여)";
                }

                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("NewSellDateAgeGender_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@age", this.cboAge.Text);
                adapter = DbMan.DbAdap(adapter);
                adapter.SelectCommand = cmd;
                ds = DbMan.DbDs(ds);
                adapter.Fill(ds);
                SStatusGridView_GenderAge_Setting(ds); 
            }
        }

        /// <summary>
        /// 성별/연령대 콤보박스 유효성 검사
        /// </summary>
        /// <returns></returns>
        private bool CheckCbo()
        {
            if (cboGender.Text == "")
            {
                MessageBox.Show("성별을 선택해 주세요.");
                return false;
            }
            else if (cboAge.Text == "")
            {
                MessageBox.Show("나이를 선택해 주세요.");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// 성별 차트 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genderChart_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 성별/연령대 탭 메뉴 클릭 이벤트 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesTab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) // 성별/연령대 페이지 클릭시 이벤트 발생
            {
                AgeGenderView();
            }
        }

        /// <summary>
        /// 매출 현황 엑셀 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save as Excel File";
            sfd.Filter = "Excel Files|*.xls";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataGridView_ExportToExcel(sfd.FileName, SStatusGridView_Date);
            }
        }

        /// <summary>
        /// 엑셀 변환 저장
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="dgv"></param>
        private void dataGridView_ExportToExcel(string fileName, DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("엑셀이 설치되지 않았습니다");
                return;
            }
            Excel.Workbook wb = excelApp.Workbooks.Add(true);
            Excel._Worksheet workSheet = wb.Worksheets.get_Item(1) as Excel._Worksheet;
            workSheet.Name = "C#";

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("출력할 데이터가 없습니다");
                return;
            }

            // 헤더 출력
            for (int i = 0; i < dgv.Columns.Count - 1; i++)
            {
                workSheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            //내용 출력
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int i = 0; i < dgv.Columns.Count - 1; i++)
                {
                    workSheet.Cells[r + 2, i + 1] = dgv.Rows[r].Cells[i].Value;
                }
            }

            // 엑셀 2003 으로만 저장이 됨
            wb.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            wb.Close(Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
            releaseObject(excelApp);
            releaseObject(workSheet);
            releaseObject(wb);
        }

        /// <summary>
        /// 엑셀 변환 저장 후 메모리 정리
        /// </summary>
        /// <param name="obj"></param>
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception e)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// 연령/연령대별 엑설 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgeGenderSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save as Excel File";
            sfd.Filter = "Excel Files|*.xls";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataGridView_ExportToExcel(sfd.FileName, SStatusGridView_GenderAge);
            }
        }

        /// <summary>
        /// 매출 현황 현금 라디오 버튼 체크 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rboMoney_Click(object sender, EventArgs e)
        {
            if (dayValue != null)
            {
                SStatusGridView_Date_Setting(ds, 1);
            }
        }

        /// <summary>
        /// 매출 현황 카드 라디오 버튼 체크 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rboCard_Click(object sender, EventArgs e)
        {
            if (dayValue != null)
            {
                SStatusGridView_Date_Setting(ds, 2);
            }
        }

        /// <summary>
        /// 매출 현황 전체 결제수단 라디오 버튼 체크 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rboAll_Click(object sender, EventArgs e)
        {
            if (dayValue != null)
            {
                SStatusGridView_Date_Setting(ds, 0);
            }
        }

        /// <summary>
        /// 연령대 차트 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oldChart_Click(object sender, EventArgs e)
        {

        }
    }
}