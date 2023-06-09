﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnMonHoc.GUI
{
    public partial class frmDonHang : Form
    {
        DAL.XuLyDuLieu xldl = new DAL.XuLyDuLieu();
        DataTable dtViewDonHang, dtNV, dtKH, dtDV, dtDonHang;
        DataColumn[] key = new DataColumn[1];

        OracleConnection connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=xe)));User Id=C##hdaz;Password=123;");
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {



        }

        private void btnHuyDH_Click(object sender, EventArgs e)
        {


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void cbxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDatHang_Leave(object sender, EventArgs e)
        {

        }

        private void txtTrongLuong_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenNguoiNhan_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = false;

            txtMaDH.DataBindings.Clear();
            cbxTenDV.DataBindings.Clear();
            cbxTenKH.DataBindings.Clear();
            cbxTenNV.DataBindings.Clear();
            txtTenNguoiNhan.DataBindings.Clear();
            cbxTrangThai.DataBindings.Clear();
            dtpNgayDatHang.DataBindings.Clear();
            txtDiaChiGiao.DataBindings.Clear();
            txtSDTNguoiNhan.DataBindings.Clear();
            txtTrongLuong.DataBindings.Clear();
            txtSDTNguoiGui.DataBindings.Clear();
            txtGiaDonHang.DataBindings.Clear();


            txtMaDH.Text = string.Empty;
            cbxTenDV.SelectedIndex = 0;
            cbxTenKH.SelectedIndex = -1;
            cbxTenNV.SelectedIndex = 0;
            txtTenNguoiNhan.Text = string.Empty;
            cbxTrangThai.SelectedIndex = 0;
            dtpNgayDatHang.Value = DateTime.Today;
            txtDiaChiGiao.Text = string.Empty;
            txtSDTNguoiNhan.Text = string.Empty;
            txtTrongLuong.Text = string.Empty;
            txtSDTNguoiGui.Text = string.Empty;
            txtGiaDonHang.Text = string.Empty;


        }

        List<int> listdoanhso = new List<int>();
        List<string> listmakh = new List<string>();
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDH.Text))
            {
                if (cbxTenKH.SelectedIndex != -1)
                {
                    if (int.TryParse(txtGiaDonHang.Text, out int value1))
                    {
                        listdoanhso.Add(value1);
                    }

                    if (!string.IsNullOrEmpty(cbxTenKH.SelectedValue.ToString()))
                    {
                        listmakh.Add(cbxTenKH.SelectedValue.ToString());
                    }

                }

                string input = txtMaDH.Text.Trim();
                bool isDuplicate = false;
                foreach (DataRow row in dtViewDonHang.Rows)
                {
                    if (row[0].ToString().Trim() == input)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    MessageBox.Show("Mã đơn hàng đã tồn tại!");
                    txtMaDH.Clear();
                    txtMaDH.Focus();
                }
                else
                {
                    DataRow newRow = dtViewDonHang.NewRow();
                    newRow["madonhang"] = txtMaDH.Text;
                    newRow["tendv"] = cbxTenDV.Text;
                    if (cbxTenKH.SelectedIndex != -1)
                        newRow["tenKH"] = cbxTenKH.Text;
                    else
                        newRow["tenKH"] = DBNull.Value;
                    newRow["tenNV"] = cbxTenNV.Text;
                    newRow["trangThai"] = cbxTrangThai.GetItemText(cbxTrangThai.SelectedItem);
                    newRow["tennguoinhan"] = txtTenNguoiNhan.Text;
                    newRow["ngaydathang"] = dtpNgayDatHang.Value.ToString();
                    newRow["diaChi"] = txtDiaChiGiao.Text;
                    newRow["sdtNguoiNhan"] = txtSDTNguoiNhan.Text;
                    newRow["sdt_kh"] = txtSDTNguoiGui.Text;
                    newRow["trongluong"] = txtTrongLuong.Text;
                    //newRow["gia_donhang"] = txtGiaDonHang.Text;
                    newRow["gia_donhang"] = int.Parse(txtGiaDonHang.Text);
                    dtViewDonHang.Rows.Add(newRow);

                    //tableDH
                    DataRow newRowDH = dtDonHang.NewRow();
                    newRowDH["madonhang"] = txtMaDH.Text;
                    newRowDH["madv"] = cbxTenDV.SelectedValue.ToString();
                    if (cbxTenKH.SelectedIndex != -1)
                        newRowDH["maKH"] = cbxTenKH.SelectedValue.ToString();
                    else
                        newRowDH["maKH"] = DBNull.Value;
                    newRowDH["manv"] = cbxTenNV.SelectedValue.ToString();
                    newRowDH["trangThai"] = cbxTrangThai.GetItemText(cbxTrangThai.SelectedItem);
                    newRowDH["tennguoinhan"] = txtTenNguoiNhan.Text;
                    newRowDH["ngaydathang"] = dtpNgayDatHang.Value.ToString();
                    newRowDH["diaChi"] = txtDiaChiGiao.Text;
                    newRowDH["sdtNguoiNhan"] = txtSDTNguoiNhan.Text;
                    newRowDH["trongluong"] = txtTrongLuong.Text;
                    newRowDH["gia_donhang"] = txtGiaDonHang.Text;
                    newRowDH["ngayhuydon"] = DBNull.Value;
                    dtDonHang.Rows.Add(newRowDH);



                    txtMaDH.Text = string.Empty;
                    cbxTenDV.SelectedIndex = 0;
                    cbxTenKH.SelectedIndex = -1;
                    cbxTenNV.SelectedIndex = 0;
                    txtTenNguoiNhan.Text = string.Empty;
                    cbxTrangThai.Text = string.Empty;
                    dtpNgayDatHang.Value = DateTime.Today;
                    txtDiaChiGiao.Text = string.Empty;
                    txtSDTNguoiNhan.Text = string.Empty;
                    txtTrongLuong.Text = string.Empty;
                    txtSDTNguoiGui.Text = string.Empty;
                    txtGiaDonHang.Text = string.Empty;
                    button1.Focus();

                    btnCapNhat.Enabled = true;
                    btnThem.Enabled = false;
                    dataGridView1.Enabled = true;


                    //THEM DOANH SO KH
                    //if (connection.State == ConnectionState.Closed)
                    //    connection.Open();

                    //string sql = "update khachhang set doanhso = doanhso + :ds where makh = :makh";
                    //OracleCommand cmd = new OracleCommand(sql, connection);
                    //cmd.Parameters.Add(new OracleParameter(":ds", txtGiaDonHang.Text));
                    //cmd.Parameters.Add(new OracleParameter(":makh", cbxTenKH.SelectedValue.ToString()));
                    //cmd.ExecuteNonQuery();
                    //if (cmd.ExecuteNonQuery() > 0)
                    //    connection.Close();



                    DonHangBinding();
                }
            }
            else
            {
                MessageBox.Show(this, "Điền đầy đủ thông tin");
                txtMaDH.Focus();
            }
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);

                    }

                    DataRow delrow = dtDonHang.Rows.Find(txtMaDH.Text);
                    if (delrow != null)
                    {
                        delrow.Delete();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }

                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }

            }
            else
                MessageBox.Show(this, "Chọn 1 dòng để xóa");
        }

        List<int> listtrudoanhso = new List<int>();
        List<string> listtrumakh = new List<string>();
        List<string> listmadonhang = new List<string>();

        private void btnHuyDH_Click_1(object sender, EventArgs e)
        {
            listtrudoanhso.Add(int.Parse(txtGiaDonHang.Text));
            listtrumakh.Add(cbxTenKH.SelectedValue.ToString());
            listmadonhang.Add(txtMaDH.Text.ToString());
            btnCapNhat.Enabled=true;
            
            foreach (DataRow row in dtViewDonHang.Rows)
            {
                if (row["madonhang"].ToString().Equals(txtMaDH.Text))
                {
                    row["ngayhuydon"] = DateTime.Now;
                    row["trangthai"] = cbxTrangThai.Items[3].ToString();
                    MessageBox.Show("Đã hủy đơn hàng " + txtMaDH.Text.Trim());
                }
            }
            
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (xldl.CAPNHAT("select * from donhang", dtDonHang) > 0)
            {
                MessageBox.Show("Cap Nhat Thanh Cong");
                btnCapNhat.Enabled = false;
            }

            //them doanh so kh
            
            if(listdoanhso.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                for (int i = 0; i < listdoanhso.Count; i++)
                {
                    string updateDoanhSoKH = "UPDATE khachhang SET doanhso = doanhso + :value WHERE makh = :makh";
                    OracleCommand command = new OracleCommand(updateDoanhSoKH, connection);
                    command.Parameters.Add(":value", OracleDbType.Int32).Value = listdoanhso[i];
                    command.Parameters.Add(":makh", OracleDbType.Varchar2).Value = listmakh[i];
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Thành công");
                listdoanhso.Clear();
                listmakh.Clear();
                connection.Close();
            }

            if(listtrudoanhso.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                for (int i = 0; i < listtrudoanhso.Count; i++)
                {
                    string updatetruDoanhSoKH = "BEGIN update_trudoanhso_kh(:ds,:makh);END;";
                    OracleCommand command = new OracleCommand(updatetruDoanhSoKH, connection);
                    command.Parameters.Add(":ds", OracleDbType.Int32).Value = listtrudoanhso[i];
                    command.Parameters.Add(":makh", OracleDbType.Varchar2).Value = listtrumakh[i];
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Thành công");
                listtrudoanhso.Clear();
                listtrudoanhso.Clear();
                connection.Close();
            }
            if (listmadonhang.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                for (int i = 0; i < listmadonhang.Count; i++)
                {
                    OracleCommand command = new OracleCommand("BEGIN trangThaiHuy(:madh); END;", connection);
                    command.Parameters.Add(":madh", OracleDbType.Varchar2).Value = listmadonhang[i];
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Thành Công");
                listmadonhang.Clear();
                connection.Close();
            }
            if(listmadonhang_DangGiao.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                for (int i = 0; i < listmadonhang.Count; i++)
                {
                    OracleCommand command = new OracleCommand("BEGIN trangThaiDangGiao(:madh); END;", connection);
                    command.Parameters.Add(":madh", OracleDbType.Char).Value = listmadonhang_DangGiao[i];
                    command.ExecuteNonQuery();

                }
                MessageBox.Show("Thành Công");
                listmadonhang_DangGiao.Clear();
                connection.Close();
            }
            if (listDonHang_DaGiao.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                for (int i = 0; i < listmadonhang.Count; i++)
                {
                    OracleCommand command = new OracleCommand("BEGIN trangThaiDaGiao(':madh');END;", connection);
                    command.Parameters.Add(":madh", OracleDbType.Char).Value = listDonHang_DaGiao[i];
                    command.ExecuteNonQuery();

                }
                MessageBox.Show("Thành Công");
                listmadonhang_DangGiao.Clear();
                connection.Close();
            }


        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuyDH.Enabled = true;
        }

        private void txtTrongLuong_Leave_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTrongLuong.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrongLuong.Clear();
                txtTrongLuong.Focus();
            }
            else
            {
                string madichvu = cbxTenDV.SelectedValue.ToString();
                string tiendichvu = "select gia from dichvu where madv = '" + madichvu + "'";
                int tiendv = 0;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                OracleCommand cmd = new OracleCommand(tiendichvu, connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tiendv = int.Parse(reader.GetString(0));
                    reader.Close();
                    connection.Close();

                }
                double tienthua = 0;
                int tongtien = 0;
                double cannang = Convert.ToDouble(txtTrongLuong.Text.ToString());


                if (cbxTenDV.SelectedIndex != 0)
                {
                    if (cannang > 3.0)
                    {
                        double kithua = cannang - 3;
                        tienthua = kithua * 5000;
                    }
                    else
                        tienthua = 0;
                }
                else
                    tienthua = 0;


                tongtien = (int)(tiendv * cannang + tienthua);
                txtGiaDonHang.Text = tongtien.ToString();

            }
        }

        private void cbxTenKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxTenKH.SelectedValue != null && cbxTenKH.SelectedValue != DBNull.Value)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string masokh = cbxTenKH.SelectedValue.ToString();


                string ketnoikh = "SELECT sdt FROM khachhang WHERE makh = '" + masokh + "'";
                OracleCommand cmd = new OracleCommand(ketnoikh, connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtSDTNguoiGui.Text = reader.GetString(0).ToString();
                    reader.Close();
                    connection.Close();

                }

                else
                {

                }



            }
        }

        private void dtpNgayDatHang_Leave_1(object sender, EventArgs e)
        {
            if (dtpNgayDatHang.Value > DateTime.Now)
            {
                MessageBox.Show(this, "Không được lớn hơn ngày hiện tại");
                dtpNgayDatHang.Value = DateTime.Now;
            }
        }

        private void cbxTenKH_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenNguoiNhan_Leave_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox1 không rỗng
            if (!string.IsNullOrEmpty(txtTenNguoiNhan.Text))
            {
                // Kiểm tra chuỗi có phải là chữ không
                if (!txtTenNguoiNhan.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Vui lòng không nhập vào chữ số.");
                    txtTenNguoiNhan.Clear(); // Xóa nội dung của textbox
                    txtTenNguoiNhan.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        List<string> listmadonhang_DangGiao = new List<string>();

        private void button2_Click_1(object sender, EventArgs e)
        {
            string madonhang = txtMaDH.Text.Trim();
            listmadonhang_DangGiao.Add(madonhang);
            foreach (DataRow row in dtViewDonHang.Rows)
            {
                if (row["madonhang"].ToString().Equals(txtMaDH.Text))
                {
                    row["trangthai"] = cbxTrangThai.Items[1].ToString();
                    MessageBox.Show("Đơn hàng " + madonhang + "đang giao");
                }
            }
            btnCapNhat.Enabled = true;


            
            

        }

        private void button2_Click_2(object sender, EventArgs e)
        {









        }

        private void FormDonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }

        private void FormDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        List<string> listDonHang_DaGiao = new List<string>();

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            string madonhang = txtMaDH.Text.Trim();
            listDonHang_DaGiao.Add(madonhang);
            foreach (DataRow row in dtViewDonHang.Rows)
            {
                if (row["madonhang"].ToString().Equals(txtMaDH.Text))
                {
                    row["trangthai"] = cbxTrangThai.Items[2].ToString();
                    MessageBox.Show("Đơn hàng " + madonhang + " đã giao");
                }
            }
            btnCapNhat.Enabled = true;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            dtViewDonHang = xldl.LayDuLieu("select * from view_donhang_2");
            key[0] = dtViewDonHang.Columns[0];
            dtViewDonHang.PrimaryKey = key;


            dtKH = xldl.LayDuLieu("select * from khachhang");
            key[0] = dtKH.Columns[0];
            dtKH.PrimaryKey = key;

            dtNV = xldl.LayDuLieu("select * from nhanvien");
            key[0] = dtNV.Columns[0];
            dtNV.PrimaryKey = key;

            dtDV = xldl.LayDuLieu("select * from dichvu");
            key[0] = dtDV.Columns[0];
            dtDV.PrimaryKey = key;

            dtDonHang = xldl.LayDuLieu("select * from donhang");
            key[0] = dtDonHang.Columns[0];
            dtDonHang.PrimaryKey = key;


            dataGridView1.DataSource = dtViewDonHang;

            LoadButton();
            LoadCombobox();
            DonHangBinding();
        }
        private void LoadButton()
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuyDH.Enabled = false;
            btnCapNhat.Enabled = false;
            cbxTenDV.Focus();
        }


        void DonHangBinding()
        {
            txtMaDH.DataBindings.Add("Text", dtViewDonHang, "madonhang");
            cbxTenDV.DataBindings.Add("Text", dtViewDonHang, "tendv");
            cbxTenKH.DataBindings.Add("Text", dtViewDonHang, "tenkh");
            cbxTenNV.DataBindings.Add("Text", dtViewDonHang, "tennv");
            txtTenNguoiNhan.DataBindings.Add("Text", dtViewDonHang, "tennguoinhan");
            cbxTrangThai.DataBindings.Add("Text", dtViewDonHang, "trangthai");
            dtpNgayDatHang.DataBindings.Add("Text", dtViewDonHang, "ngaydathang");
            txtDiaChiGiao.DataBindings.Add("Text", dtViewDonHang, "diachi");
            txtSDTNguoiNhan.DataBindings.Add("Text", dtViewDonHang, "sdtnguoinhan");
            txtTrongLuong.DataBindings.Add("Text", dtViewDonHang, "trongluong");
            txtSDTNguoiGui.DataBindings.Add("Text", dtViewDonHang, "sdt_kh");
            txtGiaDonHang.DataBindings.Add("Text", dtViewDonHang, "gia_donhang");
        }
        public void LoadCombobox()
        {
            cbxTenDV.DataSource = dtDV;
            cbxTenDV.DisplayMember = "tendv";
            cbxTenDV.ValueMember = "madv";
            cbxTenDV.SelectedIndex = 0;

            cbxTenKH.DataSource = dtKH;
            cbxTenKH.DisplayMember = "tenkh";
            cbxTenKH.ValueMember = "makh";
            cbxTenKH.SelectedIndex = -1;




            cbxTenNV.DataSource = dtNV;
            cbxTenNV.DisplayMember = "tennv";
            cbxTenNV.ValueMember = "manv";
            cbxTenNV.SelectedIndex = 0;

            cbxTrangThai.Items.Add("Chưa giao");
            cbxTrangThai.Items.Add("Đang giao");
            cbxTrangThai.Items.Add("Đã giao");
            cbxTrangThai.Items.Add("Đã hủy");
            cbxTrangThai.SelectedIndex = 0;
        }
    }
}
