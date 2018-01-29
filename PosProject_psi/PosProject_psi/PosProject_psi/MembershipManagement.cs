using PosProject_psi;
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

namespace CommonProject
{
    public partial class MembershipManagement : Form
    {
        DataSet ds;
        DataGridView myView;
        DataTable memberTable;
        List<Users> list = new List<Users>();
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public MembershipManagement()
        {
            InitializeComponent();
        }

        private void MembershipManagement_Load(object sender, EventArgs e)
        {
            ResetGridView();
        }

        /// <summary>
        /// 그리드뷰 초기화
        /// </summary>
        private void ResetGridView()
        {
            #region 싱글톤 이전 버전
            /*
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("MemberLoad", con);

                ds = new DataSet();
                adapter.Fill(ds);
                MemberView(ds);
            }
            */
            #endregion

            // 싱글톤 수정
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("MemberLoad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            MemberView(ds);
        }

        /// <summary>
        /// 그리드뷰 설정
        /// </summary>
        /// <param name="ds"></param>
        private void MemberView(DataSet ds)
        {
            MemberGridView.Rows.Clear();

            myView = new DataGridView();

            MemberGridView.ColumnCount = 6;
            MemberGridView.Columns[0].HeaderText = "NO";
            MemberGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[1].HeaderText = "회원명";
            MemberGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[2].HeaderText = "연령대";
            MemberGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[3].HeaderText = "생년월일";
            MemberGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[4].HeaderText = "성별";
            MemberGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[5].HeaderText = "포인트";
            MemberGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            memberTable = ds.Tables[0];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString().Substring(0,10), dr[4].ToString(), dr[5].ToString()
                };
                MemberGridView.Rows.Add(row);
            }
        }

        /// <summary>
        /// 회원 등록 폼 불러오기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            new MemberAdd().Show();
            this.Hide();
            MembershipManagement msm = new MembershipManagement();
            this.Close();
        }

        /// <summary>
        /// 회원 수정 폼 불러오기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modi_Click(object sender, EventArgs e)
        {
            new MemberModi().Show();
            this.Hide();
            MembershipManagement msm = new MembershipManagement();
            this.Close();
        }

        /// <summary>
        /// 전화 번호 검색 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("MemberSearchPhone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
            con.Open();
            var sdr = cmd.ExecuteReader();

            if (!sdr.HasRows)
            {
                MessageBox.Show("휴대전화 번호를 다시 한 번 입력해주세요.");
                return;
            }
            else
            {
                while (sdr.Read())
                {
                    DataGridViewCell MemberGrideView_Search = MemberGridView.Rows[int.Parse(sdr["user_num"].ToString())].Cells[0];
                    MemberGridView.FirstDisplayedCell = MemberGrideView_Search;
                    MemberGridView.CurrentCell = MemberGrideView_Search;
                }
                sdr.Close();
            }
        }

    /// <summary>
    /// 회원 삭제 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.MemberGridView.CurrentRow.Cells[1].Value.ToString() + " 를(을) 삭제 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region 싱글톤 이전 버전
                /*
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("MemberDelete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@user_name", this.MemberGridView.CurrentRow.Cells[1].Value.ToString());
                        con.Open();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다. 
                        if (i == 1)
                        {
                            MessageBox.Show("회원이 삭제 되었습니다.");
                            ResetGridView();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("회원 삭제 실패하였습니다.");
                            return;
                        }
                    }
                }
                */
                #endregion

                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("MemberDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", this.MemberGridView.CurrentRow.Cells[1].Value.ToString());
                con.Open();
                int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다. 
                if (i == 1)
                {
                    MessageBox.Show("회원이 삭제 되었습니다.");
                    ResetGridView();
                    return;
                }
                else
                {
                    MessageBox.Show("회원 삭제 실패하였습니다.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("회원을 다시 선택해주세요");
            }
        }
    }
}