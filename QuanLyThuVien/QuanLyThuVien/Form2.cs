using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
<<<<<<< HEAD
using System.Configuration;
=======

>>>>>>> parent of 71d7b68... Như push QLTV
namespace QuanLyThuVien
{
    public partial class Form2 : Form
    {
        private string link = @"DESKTOP-FV6UJS5\SQLEXPRESS;Initial Catalog=qltv;Integrated Security=True";
        private SqlConnection connect;
        private SqlCommand command;
        public Form2()
        {
            InitializeComponent();
<<<<<<< HEAD
            panelHV.Visible = false;
               pn_TraSach.Visible = false;
               pn_muonsach.Visible = false;
               panelSACH.Visible = false;
               pn_DauSach.Visible = false;
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
        private void btn_hocvien_Click(object sender, EventArgs e) // button hoc vien
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 2);
            panelHV.Visible = true;
               pn_TraSach.Visible = false;
               pn_muonsach.Visible = false;
               panelSACH.Visible = false;
               pn_DauSach.Visible = false;
               panelHV.Dock = DockStyle.Fill;
            
=======
        }

        private void btn_hocvien_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 2);
            pn_sach.Visible = false;
>>>>>>> parent of 71d7b68... Như push QLTV
        }

        private void btn_dausach_Click(object sender, EventArgs e) // button dau sach
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 69);
<<<<<<< HEAD
               panelHV.Visible = false;
               pn_TraSach.Visible = false;
               pn_muonsach.Visible = false;
               panelSACH.Visible = false;
               pn_DauSach.Visible = true;
               pn_DauSach.Dock = DockStyle.Fill;
          }
=======
            pn_sach.Visible = false;
        }
>>>>>>> parent of 71d7b68... Như push QLTV

        private void btn_sach_Click(object sender, EventArgs e) // button sach
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 136);
<<<<<<< HEAD
               panelHV.Visible = false;
               pn_TraSach.Visible = false;
               pn_muonsach.Visible = false;
               panelSACH.Visible = true;
               pn_DauSach.Visible = false;
               panelSACH.Dock = DockStyle.Fill;
          }
=======
            pn_sach.Visible = true;
        }
>>>>>>> parent of 71d7b68... Như push QLTV

        private void btn_muonsach_Click(object sender, EventArgs e) // muon sach
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 203);
<<<<<<< HEAD
               panelHV.Visible = false;
               pn_TraSach.Visible = false;
               
               panelSACH.Visible = false;
               pn_DauSach.Visible = false;
               
               pn_muonsach.Visible = true;
            pn_muonsach.Dock = DockStyle.Fill;
            panelHV.Visible = false;
=======
            pn_sach.Visible = false;
>>>>>>> parent of 71d7b68... Như push QLTV
        }

        private void btn_trasach_Click(object sender, EventArgs e) // tra sach
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 270);
<<<<<<< HEAD
               panelHV.Visible = false;
               
               pn_muonsach.Visible = false;
               panelSACH.Visible = false;
               pn_DauSach.Visible = false;
               
               pn_TraSach.Visible = true;
            pn_TraSach.Dock = DockStyle.Fill;
=======
            pn_sach.Visible = false;
>>>>>>> parent of 71d7b68... Như push QLTV
        }

        private void btn_exit_Click(object sender, EventArgs e) // thoat
        {
            this.Dispose();
        }

<<<<<<< HEAD
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

        private void btnXoaHv_Click(object sender, EventArgs e)    // chuc nang xoa hoc vien
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

        private void btnThemNv_Click(object sender, EventArgs e)  // chuc nang them nhan vien
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
        public void Hienthi()                           // Hien thi danh sach hoc vien
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

        private void btnCap_nhat_Hocvien_Click(object sender, EventArgs e)   // cap nhat dan sach hoc vien
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

        private void btnThem_nv_Click(object sender, EventArgs e)   // Chuc nang them nhan vien
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

        private void btnTimKiem_Click(object sender, EventArgs e)  // chuc nang tim kiem hoc vien
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
            // TODO: This line of code loads data into the 'quanlyThuvienDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter1.Fill(this.quanlyThuvienDataSet1.SACH);
            while (data_phieumuon.Rows.Count != 0)
            {
                data_phieumuon.Rows.RemoveAt(0);
            }
            using (ketnoi = new SqlConnection(chuoiketnoi))
            {
                ketnoi.Open();
                SqlCommand command = new SqlCommand("select MAPHIEU, MASACH, TRANGTHAI, NGAYHENTRA from MUONSACH where NGAYTRA is null", ketnoi);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                DateTime time;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        time = (DateTime)data[3];
                        data_phieumuon.Rows.Add(data[0].ToString(), data[1].ToString(), data[2].ToString(), time.ToString("dd/MM/yyyy"));
                    }
                        
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                pn_xacnhantrasach.Visible = true;
                lb_MaPhieu.Text = data_phieumuon.Rows[e.RowIndex].Cells[0].Value.ToString();
                lb_MaSach.Text = data_phieumuon.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_OKtrasach_Click(object sender, EventArgs e)   /// tra sach
        {
            pn_xacnhantrasach.Visible = false;
            using (ketnoi = new SqlConnection(chuoiketnoi))
            {
                ketnoi.Open();
                string time = DateTime.Now.ToString();
                SqlCommand command = new SqlCommand("update MUONSACH set NGAYTRA = '" + DateTime.Now.ToString("MM/dd/yyyy") + "', TRANGTHAITRA = N'OK' where MAPHIEU = '" + lb_MaPhieu.Text + "' and MASACH = '" + lb_MaSach.Text + "'", ketnoi);
                command.ExecuteNonQuery();
            }
            Form2_Load_1(sender, e);
        }

        private void btn_cancelTS_Click(object sender, EventArgs e)
        {
            pn_xacnhantrasach.Visible = false;
        }

        private void mUONSACHBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void dtgv_muonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)   // muon sach
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

        private void btn_xacnhan_muon_Click(object sender, EventArgs e)   // xac nhan muon
        {
            using (ketnoi = new SqlConnection(chuoiketnoi))
            {
                ketnoi.Open();

                string count1 = "1";
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

        private void btn_suasach_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            try
            {

                sql = "update SACH set TENSACH=N'" + txt_TENSACH.Text + "' where MAHV ='" + cb_MASACH.Text + "'" +
                      "update SACH set TRANGTHAI=N'" + txt_TRANGTHAI.Text + "' where MAHV ='" + cb_MASACH.Text + "'" +
                      "update SACH set SOLUONG=N'" + txt_SOLUONG.Text + "' where MAHV ='" + cb_MASACH.Text + "'" +
                      "update SACH set TENNXB=N'" + txt_TENNXB.Text + "' where MAHV ='" + cb_MASACH.Text + "'" +
                      "update SACH set TENTG =N'" + txt_TENTG.Text + "' where MANV ='" + cb_MASACH.Text + "'" +
                      "update SACH set MADAUSACH ='" + txt_MADAUSACH.Text + "' where MANV ='" + cb_MASACH.Text + "'";


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

        private void button3_Click(object sender, EventArgs e)
        {
            panel_suasach.Visible = false;
            panelHV.Enabled = true;
            grb_TK.Visible = true;
        }

        private void btn_themSACH_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            try
            {

                //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNu_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                sql = "EXEC INSERT_SACH   @MANV = '" + txtThem_mahv.Text + "',@TENNV = N'" + txtthem_Tenhv.Text + "',@SDT = '" + txtthem_Sdthv.Text + "'," + "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd"
                     + "',@DONVI = '" + txtthem_Donvihv.Text + "'," + "@GIOITINH = N'" + ckbNam_themHv.Text);

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

        private void btn_thoatthemsacsh_Click(object sender, EventArgs e)
        {
            panel_themsach.Visible = false;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            grb_TK.Visible = false;
            txtMASACH.Text = null;
            txtTENSACH.Text = null;
            txtTRANGTHAI.Text = null;
            txtSOLUONG.Text = null;
            txtTENNXB.Text = null;
            txtTENTG.Text = null;
            txtMADAUSACH.Text = null;

            panel_themsach.Visible = true;
            panel_suathongtin_HV.Visible = false;
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            grb_TK.Visible = false;
            panel_suasach.Visible = true;
            panel_themsach.Visible = false;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
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
                DialogResult a = MessageBox.Show("Bạn muốn xóa sách này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    //sql = "delete from NHANVIEN where(MANV = '" + cbManv.Text + "')";
                    sql = "EXEC DELETE_SACH '" + txtMASACH.Text + "'";
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

        private void button10_Click(object sender, EventArgs e)
        {
            Hienthisach();
        }
        public void Hienthisach()
        {
            listViewDSHV.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "SELECT * FROM SACH";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listViewDSSACH.Items.Add(docdulieu[0].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[1].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[2].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[3].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[4].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[5].ToString());
                listViewDSSACH.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void cbDanhmucTK1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimkiem1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtTimkiem1.Text == null)
            {
                MessageBox.Show("Lỗi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[0].ToString())   // Tìm kiếm theo mã
                {

                    sql = "SELECT* FROM TK_SACH(1, '" + txtTimkiem1.Text + "')";
                }
                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[1].ToString())                 // Tìm kiếm theo tên
                {

                    sql = "SELECT* FROM TK_SACH(2, '" + txtTimkiem1.Text + "')";
                }   // Tìm kiếm theo tên
                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[2].ToString())                 // Tìm kiếm theo sđt
                {

                    sql = "SELECT* FROM TK_SACH(3, '" + txtTimkiem1.Text + "')";
                }  // Tìm kiếm theo sđt
                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[3].ToString())                 // Tìm kiếm theo ngày sinh
                {

                    sql = "SELECT* FROM TK_SACH(4, '" + txtTimkiem1.Text + "')";
                }  // Tìm kiếm theo ngày sinh

                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[4].ToString())                 // Tìm kiếm theo đơn vị
                {

                    sql = "SELECT* FROM TK_SACH(5, '" + txtTimkiem1.Text + "')";
                }  // Tìm kiếm theo đơn vị

                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[5].ToString())                 // Tìm kiếm theo giới tính
                {

                    sql = "SELECT* FROM TK_SACH(6, '" + txtTimkiem1.Text + "')";
                }  // Tìm kiếm theo giới tính
                if (cbDanhmucTK1.Text == cbDanhmucTK1.Items[6].ToString())                 // Tìm kiếm theo giới tính
                {

                    sql = "SELECT* FROM TK_SACH(7, '" + txtTimkiem1.Text + "')";
                }  // Tìm kiếm theo giới tính
                listViewDSHV.Items.Clear();
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {


                    listViewDSSACH.Items.Add(docdulieu[0].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[1].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[2].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[2].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[4].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[5].ToString());
                    listViewDSSACH.Items[i].SubItems.Add(docdulieu[6].ToString());
                    i++;
                }
                ketnoi.Close();
            }
        }

          
          public void HienthiDausach()
          {
               listViewDauSach.Items.Clear();
               ketnoi = new SqlConnection(chuoiketnoi);
               ketnoi.Open();
               sql = "SELECT * FROM DAUSACH";
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader();
               i = 0;
               while (docdulieu.Read())
               {
                    listViewDauSach.Items.Add(docdulieu[0].ToString());
                    listViewDauSach.Items[i].SubItems.Add(docdulieu[1].ToString());
                    i++;
               }
               ketnoi.Close();
          }

          private void listViewDauSach_Click(object sender, EventArgs e)
          {
               txtMaDS.Text = listViewDauSach.SelectedItems[0].SubItems[0].Text;
               txtTenDS.Text = listViewDauSach.SelectedItems[0].SubItems[1].Text;
                //-------------- New

               /// đưa dữ liệu vào panel sửa thông tin
               comboBox_suaDS.Text = listViewDauSach.SelectedItems[0].SubItems[0].Text;
               txt_SuaDS.Text = listViewDauSach.SelectedItems[0].SubItems[1].Text;
               
          }

          private void btn_SuaDS_Click(object sender, EventArgs e)
          {
               ketnoi = new SqlConnection(chuoiketnoi);
               ketnoi.Open();
               try
               {

                    sql = "update DAUSACH set TENDAUSACH=N'" + txt_SuaDS.Text + "' where MADAUSACH ='" + comboBox_suaDS.Text + "'";

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
                    if (d == DialogResult.OK) panel_suadausach.Visible = false;
               }
               ketnoi.Close();
               gb_TK_DS.Visible = true;
          }

          private void button15_Click(object sender, EventArgs e)
          {
               ketnoi = new SqlConnection(chuoiketnoi);
               ketnoi.Open();
               try
               {

                    sql = "INSERT INTO DAUSACH VALUES('" + txtThemMaDS.Text + "',N'" + txtThemTenDS.Text + "'";
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
                         panel_themdausach.Visible = false;
                    }
               }
               ketnoi.Close();
               gb_TK_DS.Visible = true;
          }

          private void button20_Click(object sender, EventArgs e)
          {
               panel_themdausach.Visible = true;
               panel_suadausach.Visible = false;
          }

          private void button19_Click(object sender, EventArgs e)
          {
               panel_themdausach.Visible = false;
               panel_suadausach.Visible = true;
          }

          private void button18_Click(object sender, EventArgs e)
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
                         sql = "delete DAUSACH WHERE MADAUSACH = '" + txtMaDS.Text + "'";
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

          private void btn_CNDS_DS_Click_1(object sender, EventArgs e)
          {
               listViewDauSach.Parent = groupBox20;
               HienthiDausach();
          }

          private void groupBox20_Enter(object sender, EventArgs e)
          {

          }

          private void button16_Click(object sender, EventArgs e)
          {
               if (txtTimkiem.Text == null)
               {
                    MessageBox.Show("Lỗi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                    if (cbDanhmucTK.Text == cbDanhmucTK.Items[0].ToString())   // Tìm kiếm theo mã
                    {

                         sql = "SELECT* FROM TK_DAUSACH(1, '" + txt_TK_DauSach.Text + "')";
                    }
                    if (cbDanhmucTK.Text == cbDanhmucTK.Items[1].ToString())                 // Tìm kiếm theo tên
                    {

                         sql = "SELECT* FROM TK_DAUSACH(2, '" + txt_TK_DauSach.Text + "')";
                    }   // Tìm kiếm theo tên
                    
                    listViewDSHV.Items.Clear();
                    ketnoi = new SqlConnection(chuoiketnoi);
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    while (docdulieu.Read())
                    {
                         
                         listViewDSHV.Items.Add(docdulieu[0].ToString());
                         listViewDSHV.Items[i].SubItems.Add(docdulieu[1].ToString());
                         
                         i++;
                    }
                    ketnoi.Close();
               }
          }
     }
=======
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                panel3.Visible = true;

                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                //pn_sua_tkb.BringToFront();415, 393
            }
            else
            {
                if (e.ColumnIndex == 8)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from SACH where MASACH = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        Form2_Load(sender, e);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qltvDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qltvDataSet1.SACH);

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert SACH values('" + textBox3.Text + "', N'" + textBox14.Text + "', '" + textBox13.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text + "')", connect);
                command.ExecuteNonQuery();
            }
            panel1.Visible = false;
            Form2_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update SACH set MASACH = N'" + textBox3.Text + "', TENSACH = '" + textBox14.Text + "', TRANGTHAI = '" + textBox13.Text + "', SOLUONG = '" + textBox2.Text + "',TENNXB = '" + textBox6.Text + "',TENTG = '" + textBox5.Text + "',MADAUSANH = '" + textBox4.Text + "'" +
                    "where MASACH = '" + textBox3.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            panel3.Visible = false;
            Form2_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
>>>>>>> parent of 71d7b68... Như push QLTV
}
