using System;
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
            panelSACH.Visible = false;
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
            panelSACH.Visible = false;
            panelHV.Dock = DockStyle.Fill;
        }

        private void btn_dausach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 69);
            panelHV.Visible = false;
            panelSACH.Visible = false;
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 136);
            panelSACH.Visible = true;
            panelHV.Visible = false;
            panelSACH.Dock = DockStyle.Fill;
        }

        private void btn_muonsach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 203);
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
                         sql = "EXEC INSERT_SACH   @MANV = '" + txtThem_mahv.Text + "',@TENNV = N'" + txtthem_Tenhv.Text + "',@SDT = '" + txtthem_Sdthv.Text + "'," + "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd" 
                              + "',@DONVI = '" + txtthem_Donvihv.Text + "'," + "@GIOITINH = N'" + ckbNam_themHv.Text );

                    }
                    if (ckbNu_themHv.Checked == true)
                    {
                         //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                         //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNu_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                         //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                         sql = "EXEC INSERT_SACH   @MANV = '" + txtThem_mahv.Text + "',@TENNV = N'" + txtthem_Tenhv.Text + "',@SDT = '" + txtthem_Sdthv.Text + "'," + "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd"
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
        }//752, 374

        private void btnExit_form_themthongtin_Click(object sender, EventArgs e)
        {
            panel_themthongtin_HV.Visible = false;
        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void listViewDSSACH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

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

        private void btn_thoatthemsacsh_Click(object sender, EventArgs e)
        {
            panel_themsach.Visible = false;
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

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            grb_TK.Visible = false;
            panel_suasach.Visible = true;
            panel_themsach.Visible = false;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {

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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewDSSACH_Click(object sender, EventArgs e)
        {
            txt_masach.Text = listViewDSSACH.SelectedItems[0].SubItems[0].Text;
            textBox15.Text = listViewDSSACH.SelectedItems[0].SubItems[1].Text;
            textBox14.Text = listViewDSSACH.SelectedItems[0].SubItems[2].Text; ;
            textBox18.Text = listViewDSSACH.SelectedItems[0].SubItems[3].Text;
            textBox17.Text = listViewDSSACH.SelectedItems[0].SubItems[4].Text;
            textBox16.Text = listViewDSSACH.SelectedItems[0].SubItems[5].Text;
            textBox1.Text = listViewDSSACH.SelectedItems[0].SubItems[6].Text;
            //-------------- New

            /// đưa dữ liệu vào panel sửa thông tin
            cb_MASACH.Text = listViewDSSACH.SelectedItems[0].SubItems[0].Text;
            txt_TENSACH.Text = listViewDSSACH.SelectedItems[0].SubItems[1].Text;
            txt_TRANGTHAI.Text = listViewDSSACH.SelectedItems[0].SubItems[2].Text; ;
            txt_SOLUONG.Text = listViewDSSACH.SelectedItems[0].SubItems[3].Text;
            txt_TENNXB.Text = listViewDSSACH.SelectedItems[0].SubItems[4].Text;
            txt_TENTG.Text = listViewDSSACH.SelectedItems[0].SubItems[5].Text;
            txt_MADAUSACH.Text = listViewDSSACH.SelectedItems[0].SubItems[6].Text;

            
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

        private void btnXoaSach_Click_1(object sender, EventArgs e)
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
    }
}
