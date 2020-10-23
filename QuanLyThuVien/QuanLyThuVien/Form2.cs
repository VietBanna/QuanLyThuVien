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
        }

        private void btn_hocvien_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 2);
            pn_sach.Visible = false;
        }

        private void btn_dausach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 69);
            pn_sach.Visible = false;
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 136);
            pn_sach.Visible = true;
        }

        private void btn_muonsach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 203);
            pn_sach.Visible = false;
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 270);
            pn_sach.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
}
