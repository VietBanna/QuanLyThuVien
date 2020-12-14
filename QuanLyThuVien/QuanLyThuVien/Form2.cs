﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyThuVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panelHV.Visible = false;
        }
        string sql;
        string chuoiketnoi = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

            ketnoi = new SqlConnection(chuoiketnoi);
            //Hienthi();
        }
        private void btn_hocvien_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 2);
            panelHV.Visible = true;
            panelHV.Dock = DockStyle.Fill;
        }

        private void btn_dausach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 69);
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 136);
        }

        private void btn_muonsach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 203);

            pn_muonsach.Visible = true;
            pn_muonsach.Dock = DockStyle.Fill;
            panelHV.Visible = false;
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 270);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelHV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_control_Click(object sender, EventArgs e)
        {

        }

        private void pn_trangchu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoaHv_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            try
            {
                ketnoi.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                DialogResult a = MessageBox.Show("Bạn muốn xóa học viên này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    //sql = "delete from NHANVIEN where(MANV = '" + cbManv.Text + "')";
                    sql = "EXEC DELETE_HV '" + txtMAHV.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    DialogResult b = MessageBox.Show("Xóa thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (b == DialogResult.OK)
                    {
                        ketnoi.Close();
                    }
                }
                if (a == DialogResult.No)
                {
                    ketnoi.Close();
                }
            }
        }

        private void btnSuathongtinNv_Click(object sender, EventArgs e)
        {
            grb_TK.Visible = false;
            panel_suathongtin_HV.Visible = true;
            panel_themthongtin_HV.Visible = false;
        }

        private void btnThemNv_Click(object sender, EventArgs e)
        {
            grb_TK.Visible = false;
            txtThem_mahv.Text = null;
            txtthem_Tenhv.Text = null;
            txtthem_Donvihv.Text = null;
            txtthem_Sdthv.Text = null;
            ckbNam_themHv.Checked = false;
            ckbNu_themHv.Checked = false;
            panel_themthongtin_HV.Visible = true;
            panel_suathongtin_HV.Visible = false;
        }

        private void btnCNDS_Click(object sender, EventArgs e)
        {
            Hienthi();
        }
        public void Hienthi()
        {
            listViewDSHV.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "SELECT * FROM HOCVIEN";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {

                string ng_sinh = Convert.ToDateTime(docdulieu[3].ToString()).ToString("dd/MM/yyyy");

                listViewDSHV.Items.Add(docdulieu[0].ToString());
                listViewDSHV.Items[i].SubItems.Add(docdulieu[1].ToString());
                listViewDSHV.Items[i].SubItems.Add(docdulieu[2].ToString());
                listViewDSHV.Items[i].SubItems.Add(ng_sinh);
                listViewDSHV.Items[i].SubItems.Add(docdulieu[4].ToString());
                listViewDSHV.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnExit_form_suathongtin_Click(object sender, EventArgs e)
        {
            panel_suathongtin_HV.Visible = false;
            panelHV.Enabled = true;
            grb_TK.Visible = true;
        }

        private void btnCap_nhat_Hocvien_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            try
            {

                sql = "update HOCVIEN set TENHV=N'" + txtSua_Tenhv.Text + "' where MAHV ='" + cbSua_Manv.Text + "'" +
                      "update HOCVIEN set NGAYSINH ='" + dtpSua_Ngaysinh.Value.ToString("yyyy/MM/dd") + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update HOCVIEN set DONVI =N'" + txtSua_Donvihv.Text + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update HOCVIEN set SDT ='" + txtSua_Sdthv.Text + "' where MANV ='" + cbSua_Manv.Text + "'";

                if (ckbNam_suathongtin.Checked == true)
                {
                    sql += "update HOCVIEN set GIOITINH =N'" + ckbNam_suathongtin.Text + "' where MAHV ='" + cbSua_Manv.Text + "'";
                }
                if (ckbNu_suathongtin.Checked == true)
                {
                    sql += "update HOCVIEN set GIOITINH =N'" + ckbNu_suathongtin.Text + "' where MAHV ='" + cbSua_Manv.Text + "'";
                }

                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

            }
            finally
            {
                DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK) panel_suathongtin_HV.Visible = false;
            }
            ketnoi.Close();
            grb_TK.Visible = true;
        }

        private void ckbNam_suathongtin_CheckedChanged(object sender, EventArgs e)
        {
            ckbNu_suathongtin.Checked = false;
        }

        private void ckbNu_suathongtin_CheckedChanged(object sender, EventArgs e)
        {
            ckbNam_suathongtin.Checked = false;
        }

        private void ckbNam_themnv_CheckedChanged(object sender, EventArgs e)
        {
            ckbNu_themHv.Checked = false;
        }

        private void ckbNu_themnv_CheckedChanged(object sender, EventArgs e)
        {
            ckbNam_themHv.Checked = false;
        }

        private void btnThem_nv_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            try
            {
                if (ckbNam_themHv.Checked == true)
                {
                    //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                    //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNam_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                    //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                    sql = "EXEC INSERT_HV   @MANV = '" + txtThem_mahv.Text + "',@TENNV = N'" + txtthem_Tenhv.Text + "',@SDT = '" + txtthem_Sdthv.Text + "'," + "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd"
                         + "',@DONVI = '" + txtthem_Donvihv.Text + "'," + "@GIOITINH = N'" + ckbNam_themHv.Text);

                }
                if (ckbNu_themHv.Checked == true)
                {
                    //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                    //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNu_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                    //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                    sql = "EXEC INSERT_HV   @MANV = '" + txtThem_mahv.Text + "',@TENNV = N'" + txtthem_Tenhv.Text + "',@SDT = '" + txtthem_Sdthv.Text + "'," + "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd"
                         + "',@DONVI = '" + txtthem_Donvihv.Text + "'," + "@GIOITINH = N'" + ckbNam_themHv.Text);
                }
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                DialogResult d = MessageBox.Show("Thêm thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK)
                {
                    panel_themthongtin_HV.Visible = false;
                }
            }
            ketnoi.Close();
            grb_TK.Visible = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == null)
            {
                MessageBox.Show("Lỗi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[0].ToString())   // Tìm kiếm theo mã
                {

                    sql = "SELECT* FROM TK_HV(1, '" + txtTimkiem.Text + "')";
                }
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[1].ToString())                 // Tìm kiếm theo tên
                {

                    sql = "SELECT* FROM TK_HV(2, '" + txtTimkiem.Text + "')";
                }   // Tìm kiếm theo tên
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[2].ToString())                 // Tìm kiếm theo sđt
                {

                    sql = "SELECT* FROM TK_HV(3, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo sđt
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[3].ToString())                 // Tìm kiếm theo ngày sinh
                {

                    sql = "SELECT* FROM TK_HV(4, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo ngày sinh

                if (cbDanhmucTK.Text == cbDanhmucTK.Items[4].ToString())                 // Tìm kiếm theo đơn vị
                {

                    sql = "SELECT* FROM TK_HV(5, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo đơn vị

                if (cbDanhmucTK.Text == cbDanhmucTK.Items[5].ToString())                 // Tìm kiếm theo giới tính
                {

                    sql = "SELECT* FROM TK_HV(6, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo giới tính
                listViewDSHV.Items.Clear();
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    string ng_sinh = Convert.ToDateTime(docdulieu[3].ToString()).ToString("dd/MM/yyyy");

                    listViewDSHV.Items.Add(docdulieu[0].ToString());
                    listViewDSHV.Items[i].SubItems.Add(docdulieu[1].ToString());
                    listViewDSHV.Items[i].SubItems.Add(docdulieu[2].ToString());
                    listViewDSHV.Items[i].SubItems.Add(ng_sinh);
                    listViewDSHV.Items[i].SubItems.Add(docdulieu[4].ToString());
                    listViewDSHV.Items[i].SubItems.Add(docdulieu[5].ToString());
                    i++;
                }
                ketnoi.Close();
            }
        }

        private void listViewDSHV_Click_1(object sender, EventArgs e)
        {
            txtMAHV.Text = listViewDSHV.SelectedItems[0].SubItems[0].Text;
            txtTENHV.Text = listViewDSHV.SelectedItems[0].SubItems[1].Text;
            txtDONVI.Text = listViewDSHV.SelectedItems[0].SubItems[4].Text; ;
            txtSDT.Text = listViewDSHV.SelectedItems[0].SubItems[2].Text;
            txtGIOITINH.Text = listViewDSHV.SelectedItems[0].SubItems[5].Text;
            txtNGAYSINH.Text = listViewDSHV.SelectedItems[0].SubItems[3].Text; //-------------- New

            /// đưa dữ liệu vào panel sửa thông tin
            cbSua_Mahv.Text = listViewDSHV.SelectedItems[0].SubItems[0].Text;
            txtSua_Tenhv.Text = listViewDSHV.SelectedItems[0].SubItems[1].Text;
            txtSua_Donvihv.Text = listViewDSHV.SelectedItems[0].SubItems[3].Text; ;
            txtSua_Sdthv.Text = listViewDSHV.SelectedItems[0].SubItems[4].Text;


            if (listViewDSHV.SelectedItems[0].SubItems[5].Text == ckbNam_suathongtin.Text)
            {
                ckbNam_suathongtin.Checked = true;
                ckbNu_suathongtin.Checked = false;
            }
            else
            {
                ckbNu_suathongtin.Checked = true;
                ckbNam_suathongtin.Checked = false;
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyThuvienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanlyThuvienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanlyThuvienDataSet.MUONSACH' table. You can move, or remove it, as needed.
            this.mUONSACHTableAdapter.Fill(this.quanlyThuvienDataSet.MUONSACH);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sACHTableAdapter.FillBy(this.quanlyThuvienDataSet.SACH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sACHTableAdapter.FillBy1(this.quanlyThuvienDataSet.SACH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sACHTableAdapter.FillBy1(this.quanlyThuvienDataSet.SACH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dtgv_muonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_muonsach.Rows[e.RowIndex].Cells[2].Value.ToString() != "Còn" && e.ColumnIndex == 7)
            {
                MessageBox.Show("Sách đã hết!");
            }
            else
            {
                int a = e.ColumnIndex;
                if (a < 7)
                {
                    tb_masach_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tb_tensach_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tb_trangthai_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tb_soluong_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tb_tennxb_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tb_tentacgia_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tb_madausach_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn mượn sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        pn_add_soluong.Visible = true;

                        tb_masach_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[0].Value.ToString();
                        tb_soluong_muonsach.Text = dtgv_muonsach.Rows[e.RowIndex].Cells[3].Value.ToString();
                        tb_ma_soluongmuon.Text = tb_masach_muonsach.Text;
                        lb_soluong_con.Text = tb_soluong_muonsach.Text;

                        int num1 = Int32.Parse(tb_soluong_muonsach.Text.ToString());
                        for (int i = 1; i <= num1; i++)
                        {
                            lstbx_soluongmuon.Items.Add(i);
                        }

                    }

                }
            }
        }

        private void btn_xacnhan_muon_Click(object sender, EventArgs e)
        {
            using (ketnoi = new SqlConnection(chuoiketnoi))
            {
                ketnoi.Open();
                
                string count1 = "1";
                if (count1 == "")
                {

                }
                string count2 = lb_soluong_con.Text.ToString();
                int num1 = Int32.Parse(count1);
                int num2 = Int32.Parse(count2);
                int num = num2 - num1;
                sql = "update sach set soluong = " + num + " where MASACH = '" + tb_ma_soluongmuon.Text.ToString() + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            lstbx_soluongmuon.Items.Clear();
            pn_add_soluong.Visible = false;
        }

        private void btn_huy_muon_Click(object sender, EventArgs e)
        {
            pn_add_soluong.Visible = false;
        }

    }
}
