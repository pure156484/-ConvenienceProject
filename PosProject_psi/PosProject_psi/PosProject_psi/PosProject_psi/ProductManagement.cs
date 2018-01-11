﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class ProductManagement : Form
    {
        DataSet ds;
        private SqlConnection con = null;
        string imgFileName;
        byte[] bImg = null;
        byte[] img = null;
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
                string query = "select * from Product";
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, con);
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
                //   product_grid.Columns[5].HeaderText = "이미지";
                // product_grid.Columns[5].Visible = false;
                product_grid.Columns[5].HeaderText = "이미지";
                product_grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                product_grid.Columns[6].HeaderText = "이벤트";
                product_grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                product_grid.Columns[7].HeaderText = "수량";
                product_grid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //// 그리드 뷰에 출력
            string uevent = this.product_count.Text.Trim();
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

                    DataRowCollection dataRow = ds.Tables[0].Rows;
                    foreach (DataRow row in dataRow)
                    {
                        this.product_event.Items.Add(row.ItemArray[0].ToString());
                    }
                    this.product_event.Items.Add("없음");
                    con.Close();
                }
             //   string query = "select event_name from Event";
                

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)  // 쌤쌤
                //{
                //    this.product_event.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                //}
            }
        }


        private void ProductManagement_Load(object sender, EventArgs e)
        {
            Rests();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

 // 저장
        private void btn_enroll_Click(object sender, EventArgs e)
        {
            string ubarcode = this.product_barcode.Text.Trim();
            string uname = this.product_name.Text.Trim();
            string uselect = this.product_select.Text.Trim();
            string uunit_price = this.product__unit_price.Text.Trim();
            string ucust_price = this.product_cust_price.Text.Trim();
            string ucount = this.product_count.Text.Trim();
            string uevent = this.product_count.Text.Trim();

            if (product_event.Text == "없음")
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {

                    using (var cmd = new SqlCommand("ConvenienceItemsEventNull", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        ImageConverter converter = new ImageConverter();
                        byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));

                        switch (uselect)
                        {
                            case "제과":
                                cmd.Parameters.AddWithValue("@uselects", 1);
                                break;
                            case "라면":
                                cmd.Parameters.AddWithValue("@uselects", 2);
                                break;
                            case "음료":
                                cmd.Parameters.AddWithValue("@uselects", 3);
                                break;
                        }
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


                        if (bImg != null)
                        {
                            cmd.Parameters.AddWithValue("@uimage", bImg); 
                        }
                        else
                        {
                            MessageBox.Show("이미지를 등록해주세요.");
                        }


                        con.Open();

                        int i = cmd.ExecuteNonQuery();
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

                    using (var cmd = new SqlCommand("ConvenienceItems", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        ImageConverter converter = new ImageConverter();
                        byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));

                        switch (uselect)
                        {
                            case "제과":
                                cmd.Parameters.AddWithValue("@uselects", 1);
                                break;
                            case "라면":
                                cmd.Parameters.AddWithValue("@uselects", 2);
                                break;
                            case "음료":
                                cmd.Parameters.AddWithValue("@uselects", 3);
                                break;
                        }
                        cmd.Parameters.AddWithValue("@uunit_price", uunit_price);
                        cmd.Parameters.AddWithValue("@ucust_price", ucust_price);
                        cmd.Parameters.AddWithValue("@ucounts", ucount);
                        //   (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString();
                        if (product_event.Text == "없음")
                        {
                            cmd.Parameters.AddWithValue("@uevent", null);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString());
                        }


                        if (bImg != null)
                        {
                            cmd.Parameters.AddWithValue("@uimage", bImg);
                        }
                        else
                        {
                            MessageBox.Show("이미지를 등록해주세요.");
                        }
                        con.Open();

                        int i = cmd.ExecuteNonQuery();
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
               product_event.Text = product_count.Text = "";
          //  product__image = null;
        }

 // 그리드 뷰 클릭하면 정보 출력
        private void product_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //product_barcode.Text = product_grid.CurrentRow.Cells[0].Value.ToString();
            //product_name.Text = product_grid.CurrentRow.Cells[1].Value.ToString();
            ////switch (int.Parse(product_select.Text))
            ////{
            ////    case 1:
            ////        product_select.Text = "제과";
            ////        product_select.Text = product_grid.CurrentRow.Cells[2].Value.ToString();
            ////        break;
            ////    case 2:
            ////        product_select.Text = "라면";
            ////        product_select.Text = product_grid.CurrentRow.Cells[2].Value.ToString();
            ////        break;
            ////    case 3:
            ////        product_select.Text = "음료";
            ////        product_select.Text = product_grid.CurrentRow.Cells[2].Value.ToString();
            ////        break;
            ////}
            //product_select.Text = product_grid.CurrentRow.Cells[2].Value.ToString();

            //product__unit_price.Text = product_grid.CurrentRow.Cells[3].Value.ToString();
            //product_cust_price.Text = product_grid.CurrentRow.Cells[4].Value.ToString();
            //product__image.Image = new Bitmap(new MemoryStream((byte[])product_grid.CurrentRow.Cells[5].Value));
            //product_count.Text = product_grid.CurrentRow.Cells[6].Value.ToString();
            
        }

 // 수정
        private void btn_modified_Click(object sender, EventArgs e)
        {
            string ubarcode = this.product_barcode.Text.Trim();
            string uname = this.product_name.Text.Trim();
            string uselect = this.product_select.Text.Trim();
            string uunit_price = this.product__unit_price.Text.Trim();
            string ucust_price = this.product_cust_price.Text.Trim();
            string ucount = this.product_count.Text.Trim();

            if (product_event.Text == "없음")
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("adjustConvenienceltemsEventNull", con))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        ImageConverter converter = new ImageConverter();
                        byte[] bImg = (byte[])converter.ConvertTo(product__image.Image, typeof(byte[]));
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        switch (uselect)
                        {
                            case "제과":
                                cmd.Parameters.AddWithValue("@uselects", 1);
                                break;
                            case "라면":
                                cmd.Parameters.AddWithValue("@uselects", 2);
                                break;
                            case "음료":
                                cmd.Parameters.AddWithValue("@uselects", 3);
                                break;
                        }
                        //  cmd.Parameters.AddWithValue("@uselects", uselect);
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
                        switch (uselect)
                        {
                            case "제과":
                                cmd.Parameters.AddWithValue("@uselects", 1);
                                break;
                            case "라면":
                                cmd.Parameters.AddWithValue("@uselects", 2);
                                break;
                            case "음료":
                                cmd.Parameters.AddWithValue("@uselects", 3);
                                break;
                        }
                        //  cmd.Parameters.AddWithValue("@uselects", uselect);
                        cmd.Parameters.AddWithValue("@uevent", (int.Parse(product_event.SelectedIndex.ToString()) + 1).ToString());
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

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode);

                    adapter.DeleteCommand = cmd;

                   // adapter.SelectCommand(ds);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("삭제 되었습니다.");
                        Rests();
                        ComponentInit();
                     //   Reset();
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
            switch (product_grid.CurrentRow.Cells[2].Value.ToString())
            {
                case "1":
                    product_select.Text = "제과";
                    break;
                case "2":
                    product_select.Text = "라면";
                    break;
                case "3":
                    product_select.Text = "음료";
                    break;
            }

            product__unit_price.Text = product_grid.CurrentRow.Cells[3].Value.ToString();
            product_cust_price.Text = product_grid.CurrentRow.Cells[4].Value.ToString();
            product_event.Text = product_grid.CurrentRow.Cells[6].Value.ToString();
            
            product_count.Text = product_grid.CurrentRow.Cells[7].Value.ToString();

            try
            {

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
                }
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
