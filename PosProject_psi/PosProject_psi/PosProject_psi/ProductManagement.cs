using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class ProductManagement : Form
    {
        string barcode = "";
        DataSet ds;
        private SqlConnection con = null;
        string imgFileName;
        byte[] bImg = null;
        byte[] img = null;
<<<<<<< HEAD
=======
        Bitmap DownloadImage;
>>>>>>> LWS
        List<productAdd> list = new List<productAdd>();
        public ProductManagement()
        {
            InitializeComponent();
        }
        private SqlConnection DBConnector() // 싱글턴 만들기 
        {
            if (con == null)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString);
            }
            else
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString);
            }
            return con;
        }
        private void Rests()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("ConvenienceLoad", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    con.Close();

                    ds = new DataSet();
                    adapter.Fill(ds);
                    this.product_grid.DataSource = ds.Tables[0];

                    product_grid.Columns[0].HeaderText = "바코드";
                    product_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[1].HeaderText = "제품";
                    product_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[2].HeaderText = "종류";
                    product_grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[3].HeaderText = "원가";
                    product_grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[4].HeaderText = "가격";
                    product_grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
<<<<<<< HEAD
                    //product_grid.Columns[5].HeaderText = "이미지";
                    //product_grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[6].HeaderText = "이벤트";
                    product_grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[7].HeaderText = "수량";
=======
                    product_grid.Columns[6].HeaderText = "이벤트";
                    product_grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[7].HeaderText = "회사";
>>>>>>> LWS
                    product_grid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    product_grid.Columns[5].Visible = false;

                }
            }
            //// 그리드 뷰에 출력
<<<<<<< HEAD
            string uevent = this.product_count.Text.Trim();
=======
            string uevent = this.product_company.Text.Trim();
>>>>>>> LWS
            /// 콤보박스에 이벤트 종류 출력
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("ConvenienceEvent", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uevent", uevent);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    ds = new DataSet();
                    adapter.Fill(ds);
                    product_event.Items.Clear();     // 콤보박스에 겹치는 현상 제거
                    DataRowCollection dataRow = ds.Tables[0].Rows;
                    foreach (DataRow row in dataRow)
                    {
<<<<<<< HEAD

                        this.product_event.Items.Add(row.ItemArray[0].ToString());
                    }
                    this.product_event.Items.Add("없음");
                    dataRow.Clear();

=======
                        this.product_event.Items.Add(row.ItemArray[0].ToString());
                    }
                  //  this.product_event.Items.Add("없음");
                    dataRow.Clear();

>>>>>>> LWS
                    con.Close();
                }
            }
            

        }


        private void ProductManagement_Load(object sender, EventArgs e)
        {
            product__image.Image = Properties.Resources.no_image;
            Rests();
            SeclctProd();
<<<<<<< HEAD

=======
            CompanyProd();
>>>>>>> LWS
        }
        private void CompanyProd()
        {
            //string uCompany = this.product_company.Text.Trim();
            /// 콤보박스에 이벤트 종류 출력
            //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            //{
            //    using (var cmd = new SqlCommand("ConvenienceCompany", con))
            //    {
            //        con.Open();
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@ucompanyName", uCompany);

            //        SqlDataAdapter adapter = new SqlDataAdapter();
            //        adapter.SelectCommand = cmd;
            //        ds = new DataSet();
            //        adapter.Fill(ds);
            //        product_company.Items.Clear();     // 콤보박스에 겹치는 현상 제거
            //        DataRowCollection dataRow = ds.Tables[0].Rows;
            //        foreach (DataRow row in dataRow)
            //        {
            //            this.product_company.Items.Add(row.ItemArray[0].ToString());
            //        }
            //        dataRow.Clear();

            //        con.Close();
            //    }
            //}
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("ConvenienceCompany", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

<<<<<<< HEAD
=======
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    con.Close();

                    ds = new DataSet();
                    adapter.Fill(ds);
                    DataRowCollection dataRow = ds.Tables[0].Rows;
                    foreach (DataRow row in dataRow)
                    {
                        this.product_company.Items.Add(row[0].ToString());
                    }


                }
            }
        }
>>>>>>> LWS
        private void SeclctProd()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("CategoryCombo", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    con.Close();

                    ds = new DataSet();
                    adapter.Fill(ds);
                    DataRowCollection dataRow = ds.Tables[0].Rows;
                    foreach (DataRow row in dataRow)
                    {
                        this.product_select.Items.Add(row[0].ToString());
                    }


                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

<<<<<<< HEAD
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

=======
>>>>>>> LWS

        }
        // 저장
        private void btn_enroll_Click(object sender, EventArgs e)
        {
            string ubarcode = this.product_barcode.Text.Trim();
            string uname = this.product_name.Text.Trim();
            string uselect = this.product_select.Text.Trim();
            string uunit_price = this.product__unit_price.Text.Trim();
            string ucust_price = this.product_cust_price.Text.Trim();
            //string ucount = this.product_company.Text.Trim();
            string uevent = this.product_event.Text.Trim();
            string ucompany = this.product_company.Text.Trim();


            try
            {
<<<<<<< HEAD
                if (product_event.Text == "없음")
                {
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                    {
                        //ConvenienceItems
                        using (var cmd = new SqlCommand("ConvenienceItemsEventNull", con))
                        {
                            //  ConvenienceItemsEventNull
                            cmd.CommandType = CommandType.StoredProcedure;
                            if (ubarcode == null)
                            {
                                MessageBox.Show("바코드를 입력해주세요");
                            }
                            cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                            cmd.Parameters.AddWithValue("@uname", uname);
                            ImageConverter converter = new ImageConverter();
                            byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));

                            //switch (uselect)
                            //{
                            //    case "제과":
                            //        cmd.Parameters.AddWithValue("@uselects", 1);
                            //        break;
                            //    case "라면":
                            //        cmd.Parameters.AddWithValue("@uselects", 2);
                            //        break;
                            //    case "음료":
                            //        cmd.Parameters.AddWithValue("@uselects", 3);
                            //        break;
                            //}
                            cmd.Parameters.AddWithValue("@uselects", (int.Parse(product_select.SelectedIndex.ToString()) + 1).ToString());
                            cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                            cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                            cmd.Parameters.AddWithValue("@ucounts", ucount);

                            //if (product_event.Text == "없음")
                            //{
                            //    cmd.Parameters.AddWithValue("@uevent", null);
                            //}
                            //else
                            //{
                            //    cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString());
                            //}

                            if (product__image != null)
                            {
                                cmd.Parameters.AddWithValue("@uimage", bImg);
                            }
                            else
                            {
                                //product__image.Image = new Bitmap(@"C:\Users\gd3-18\Desktop\PosProject_psi\PosProject_psi\PosProject_psi\Resources\no_image.png");

                                //cmd.Parameters.AddWithValue("@uimage", bImg);
                            }
                            con.Open();

                            int i = cmd.ExecuteNonQuery();
                            if (i == 1 && product__image != null)
                            {
                                MessageBox.Show("저장 되었습니다.");
                                Rests();
                                ComponentInit();
                                return;
                            }
                            else if (product__image == null)
                            {
                                MessageBox.Show("이미지를 등록해주세요.");
                            }
                            else
                            {
                                MessageBox.Show("저장 실패");
                                return;
                            }
                        }
=======
                using (var cmd = new SqlCommand("ConvenienceItems", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode); 

                    cmd.Parameters.AddWithValue("@uname", uname);
                    ImageConverter converter = new ImageConverter();
                    byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                    cmd.Parameters.AddWithValue("@uselects", uselect);
                    cmd.Parameters.AddWithValue("@ucounts", 0);
                    cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                    cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                    cmd.Parameters.AddWithValue("@ucompany", ucompany);

                    cmd.Parameters.AddWithValue("@uevent", uevent);

                    if (product__image != null)
                    {
                        cmd.Parameters.AddWithValue("@uimage", bImg);
>>>>>>> LWS
                    }
                }
                else
                {
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                    {
<<<<<<< HEAD
                        using (var cmd = new SqlCommand("ConvenienceItems", con))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;

                            if (ubarcode != product_grid.Columns[0].ToolTipText) // 중복때 예외안나게 고쳐야함
                            {
                                cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                            }
                            //else
                            //{
                            //    MessageBox.Show("바코드를 입력해주세요");
                            //}
                            cmd.Parameters.AddWithValue("@uname", uname);
                            ImageConverter converter = new ImageConverter();
                            byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));

                            //switch (uselect)
                            //{
                            //    case "제과":
                            //        cmd.Parameters.AddWithValue("@uselects", 1);
                            //        break;
                            //    case "라면":
                            //        cmd.Parameters.AddWithValue("@uselects", 2);
                            //        break;
                            //    case "음료":
                            //        cmd.Parameters.AddWithValue("@uselects", 3);
                            //        break;
                            //}
                            cmd.Parameters.AddWithValue("@uselects", (int.Parse(product_select.SelectedIndex.ToString()) + 1).ToString());
                            if (uunit_price != null)
                            {
                                cmd.Parameters.AddWithValue("@uunit_price", uunit_price);

                            }
                            else
                            {
                                MessageBox.Show("판매가격을 입력해주세요");
                            }

                            cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                            cmd.Parameters.AddWithValue("@ucounts", ucount);
                            //   (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString();
                            if (product_event.Text == "없음")
                            {
                                cmd.Parameters.AddWithValue("@uevent", null);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString()); //(int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString()
                            }


                            if (product__image != null)
                            {
                                cmd.Parameters.AddWithValue("@uimage", bImg);
                            }
                            else
                            {
                                product__image.Image = Properties.Resources.no_image;
                            }
                            con.Open();

                            int i = cmd.ExecuteNonQuery();
                            if (i == 1 && product__image != null)
                            {
                                MessageBox.Show("저장 되었습니다.");
                                Rests();
                                ComponentInit();
                                return;
                            }
                            else if (product__image == null)
                            {
                                MessageBox.Show("이미지를 등록해주세요.");
                            }
                            else
                            {
                                MessageBox.Show("저장 실패");
                                return;
                            }


                            //if (i == 1)
                            //{
                            //    MessageBox.Show("저장 되었습니다.");
                            //    Rests();
                            //    ComponentInit();
                            //    return;
                            //}
                            //else
                            //{
                            //    MessageBox.Show("저장 실패");
                            //    return;
                            //}
                        }
=======
                        product__image.Image = Properties.Resources.no_image;
>>>>>>> LWS
                    }
                    con.Open();

                    //try
                    //{
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1 && product__image != null)
                        {
                            MessageBox.Show("저장 되었습니다.");
                            Rests();
                            ComponentInit();
                            return;
                        }
                        else if (product__image == null)
                        {
                            MessageBox.Show("이미지를 등록해주세요.");
                        }
                        else
                        {
                            MessageBox.Show("저장 실패");
                            return;
                        }
                   // }
                    //catch (System.Data.SqlClient.SqlException)
                    //{
                    //    MessageBox.Show("바코드를 수정할 수는 없습니다. 삭제 후 새로 저장해주세요");
                    //    return;
                    //}

                }
            }
<<<<<<< HEAD
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("바코드를 확인해주세요!");
            }

=======
>>>>>>> LWS
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                //  product__image.Image = new Bitmap(openFileDialog1.FileName);
                //  imgFileName = openFileDialog1.FileName;
                imgFileName = openFileDialog1.FileName;
                product__image.Image = new Bitmap(imgFileName);
            }
        }

        private void ComponentInit()
        {
            product_barcode.Text = product_name.Text = product_select.Text = product__unit_price.Text = product_cust_price.Text =
<<<<<<< HEAD
               product_event.Text = product_count.Text = "";
            product__image.Image = Properties.Resources.no_image;
        }

        // 그리드 뷰 클릭하면 정보 출력
        private void product_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

=======
               product_event.Text = product_company.Text = "";
            product__image.Image = Properties.Resources.no_image;
        }

>>>>>>> LWS
        // 수정
        private void btn_modified_Click(object sender, EventArgs e)
        {
            string ubarcode = this.product_barcode.Text.Trim();
            string uname = this.product_name.Text.Trim();
            string uselect = this.product_select.Text.Trim();
            string uunit_price = this.product__unit_price.Text.Trim();
            string ucust_price = this.product_cust_price.Text.Trim();
<<<<<<< HEAD
            string ucount = this.product_count.Text.Trim();

            if (product_event.Text == "없음")
=======
            string ucompany = this.product_company.Text.Trim();
            string uevent = this.product_event.Text.Trim();
           
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
>>>>>>> LWS
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
<<<<<<< HEAD
                    using (var cmd = new SqlCommand("adjustConvenienceltemsEventNull", con))
=======
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    ImageConverter converter = new ImageConverter();
                    byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                    cmd.Parameters.AddWithValue("@uname", uname);
                    
                    cmd.Parameters.AddWithValue("@uselects", uselect);
                    cmd.Parameters.AddWithValue("@uevent", uevent);  
                    cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                    cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                    if (bImg != null)
                    {
                        cmd.Parameters.AddWithValue("@uimage", bImg);
                    }
                    else
                    {
                        MessageBox.Show("이미지를 등록해주세요.");
                    }
                    cmd.Parameters.AddWithValue("@ucompany", ucompany);

                    adapter.UpdateCommand = cmd;
                    int i;
                    i = cmd.ExecuteNonQuery();
                    
                    if (i == 1)
>>>>>>> LWS
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        ImageConverter converter = new ImageConverter();
                        byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        //switch (uselect)
                        //{
                        //    case "제과":
                        //        cmd.Parameters.AddWithValue("@uselects", 1);
                        //        break;
                        //    case "라면":
                        //        cmd.Parameters.AddWithValue("@uselects", 2);
                        //        break;
                        //    case "음료":
                        //        cmd.Parameters.AddWithValue("@uselects", 3);
                        //        break;
                        //}
                        cmd.Parameters.AddWithValue("@uselects", (int.Parse(product_select.SelectedIndex.ToString()) + 1).ToString());
                        //   cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString());
                        cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                        cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                        if (bImg != null)
                        {
                            cmd.Parameters.AddWithValue("@uimage", bImg);
                        }
                        else
                        {
                            MessageBox.Show("이미지를 등록해주세요.");
                        }
                        cmd.Parameters.AddWithValue("@ucounts", ucount);

                        adapter.UpdateCommand = cmd;
                        int i;
                        //  adapter.Update(ds);
                        try
                        {
                            i = cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {

                            cmd.Parameters.AddWithValue("@uevent", null);
                            i = cmd.ExecuteNonQuery();
                        }
                        if (i == 1)
                        {
                            MessageBox.Show("저장 되었습니다.");
                            Rests();
                            ComponentInit();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("저장 실패");
                            return;
                        }
                    }
                }
            }
            else
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("adjustConvenienceItems", con))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        ImageConverter converter = new ImageConverter();
                        byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        //switch (uselect)
                        //{
                        //    case "제과":
                        //        cmd.Parameters.AddWithValue("@uselects", 1);
                        //        break;
                        //    case "라면":
                        //        cmd.Parameters.AddWithValue("@uselects", 2);
                        //        break;
                        //    case "음료":
                        //        cmd.Parameters.AddWithValue("@uselects", 3);
                        //        break;
                        //}
                        cmd.Parameters.AddWithValue("@uselects", (int.Parse(product_select.SelectedIndex.ToString()) + 1).ToString());
                        cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString());  //(int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString()
                        cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                        cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                        if (bImg != null)
                        {
                            cmd.Parameters.AddWithValue("@uimage", bImg);
                        }
                        else
                        {
                            MessageBox.Show("이미지를 등록해주세요.");
                        }
                        cmd.Parameters.AddWithValue("@ucounts", ucount);

                        adapter.UpdateCommand = cmd;
                        int i;
                        //  adapter.Update(ds);
                        try
                        {
                            i = cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {

                            //cmd.Parameters.AddWithValue("@uevent", null);
                            i = cmd.ExecuteNonQuery();
                        }
                        if (i == 1)
                        {
                            MessageBox.Show("저장 되었습니다.");
                            Rests();
                            ComponentInit();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("저장 실패");
                            return;
                        }
                    }
                }
            }
<<<<<<< HEAD
=======
            
>>>>>>> LWS



        }

        // 삭제
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string ubarcode = this.product_barcode.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("deleteConvenienceItems", con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    ImageConverter converter = new ImageConverter();
                    byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode);

                    adapter.DeleteCommand = cmd;

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("삭제 되었습니다.");
                        Rests();
                        ComponentInit();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");

                        return;
                    }
                }
            }

        }


        private void product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            product_barcode.Text = product_grid.CurrentRow.Cells[0].Value.ToString();
            product_name.Text = product_grid.CurrentRow.Cells[1].Value.ToString();
<<<<<<< HEAD
            //switch (product_grid.CurrentRow.Cells[2].Value.ToString())
            //{
            //    case "1":
            //        product_select.Text = "제과";
            //        break;
            //    case "2":
            //        product_select.Text = "라면";
            //        break;
            //    case "3":
            //        product_select.Text = "음료";
            //        break;
            //}
=======
>>>>>>> LWS
            product_select.Text = product_grid.CurrentRow.Cells[2].Value.ToString();
            product__unit_price.Text = product_grid.CurrentRow.Cells[3].Value.ToString();
            product_cust_price.Text = product_grid.CurrentRow.Cells[4].Value.ToString();
            product_event.Text = product_grid.CurrentRow.Cells[6].Value.ToString();

<<<<<<< HEAD
            product_count.Text = product_grid.CurrentRow.Cells[7].Value.ToString();
=======
            product_company.Text = product_grid.CurrentRow.Cells[7].Value.ToString();

            using (con = DBConnector())
            {
                using (var cmd = new SqlCommand("ConvenienceIMG", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", product_barcode.Text);

                    con.Open();
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {

                        while (sdr.Read())
                        {
                            if (sdr["product_image"] != null)
                            {
                                try
                                {
                                    bImg = (byte[])sdr["product_image"];
                                    img = (byte[])sdr["product_image"];
                                    product__image.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    //product__image.Image = new Bitmap(@"C:\Users\gd3-18\source\repos\pic\no_image.png");
                                }
                            }

                        }
                    }
                    else
                    {
                        return;
                    }
                    sdr.Close();
                }
            }

>>>>>>> LWS

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ComponentInit();
            // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Category().ShowDialog();

        }

        private void ProductManagement_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void btn_barcode_search_Click(object sender, EventArgs e)
        {
            if (CheckBarcodeNull())
            {
<<<<<<< HEAD

                //   product__image.Image = new Bitmap(new MemoryStream((byte[])product_grid.CurrentRow.Cells[5].Value));
                //  product__image.Image = new Bitmap(new MemoryStream((byte[])product_grid.CurrentRow.Cells[5].Value));
            }
            catch (System.NullReferenceException)
            {
                //   System.InvalidCastException
                // System.NullReferenceException
            }

            using (con = DBConnector())
            {
                using (var cmd = new SqlCommand("ConvenienceIMG", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", product_barcode.Text);

                    con.Open();
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {

                        while (sdr.Read())
                        {
                            if (sdr["product_image"] != null)
                            {
                                try
                                {
                                    bImg = (byte[])sdr["product_image"];
                                    img = (byte[])sdr["product_image"];
                                    product__image.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    //product__image.Image = new Bitmap(@"C:\Users\gd3-18\source\repos\pic\no_image.png");
                                }
                            }

                        }
                    }
                    else
                    {
                        return;
                    }
                    sdr.Close();
=======
                barcode_image();
                barcode_info();
            }
        }

        private void barcode_info()
        {
            var html = @"http://www.cvslove.com/product/product_view.asp?pcode=" + this.product_barcode.Text;

            HtmlWeb web = new HtmlWeb();

            web.OverrideEncoding = Encoding.Default;

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//center//form");

            string[] result = Regex.Split(node.InnerText, "\r\n");
            for (int i = 0; i < result.Length; i++)
            {
                switch (i)
                {
                    case 11:
                        this.product_name.Text = result[i].Trim();
                        break;
                    case 27:
                        string product_price = Regex.Replace(result[i].Trim(), @"\D", "");
                        this.product_cust_price.Text = product_price;
                        break;
>>>>>>> LWS
                }
            }
        }

        private void barcode_image()
        {
            var html = @"http://www.cvslove.com/product/product_view.asp?pcode=" + this.product_barcode.Text;

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//center/img");

            string barcode_search_image_url = node.OuterHtml;
            string barcode_search_image = null;

            Regex rxImages = new Regex("<img.+?src=[\"'](.+?)[\"'].+?>",
            RegexOptions.IgnoreCase & RegexOptions.IgnorePatternWhitespace);
            MatchCollection mc = rxImages.Matches(barcode_search_image_url);
            foreach (Match m in mc)
            {
                barcode_search_image += m.Groups[1].Value;
            }
            try
            {
                product__image.Load(barcode_search_image);

                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(barcode_search_image);
                DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            }
            catch (Exception)
            {
                MessageBox.Show("상품 정보가 없습니다. \n상품 정보를 입력하여 등록해주세요.");
            }
        }

        private bool CheckBarcodeNull()
        {
<<<<<<< HEAD
            ComponentInit();
            // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Category().Show();
        }

        private void ProductManagement_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void product_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(((TextBox)sender).Text);
=======
            if (this.product_barcode.Text == "")
            {
                product__image.Image = Properties.Resources.no_image;
                MessageBox.Show("바코드를 입력해주세요.");
                return false;
            }
            else if (this.product_barcode.Text.Length > 14 && this.product_barcode.Text.Length < 18)
            {
                MessageBox.Show("바코드 길이가 맞지 않습니다.");
                return false;
            }
            else
            {
                return true;
>>>>>>> LWS
            }
        }

    }
}
