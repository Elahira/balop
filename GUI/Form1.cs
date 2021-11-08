using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        B_thanhvien btv = new B_thanhvien();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridthanhvien.DataSource = btv.GetAllThanhVien();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (txthoten2.Text != "" && txtPhone2.Text != "" && txtemail.Text != "")
            {
                tbthanhvien tv = new tbthanhvien();
                tv.Hoten1 = txthoten2.Text;
                tv.Phone1 = txtPhone2.Text;
                tv.Email1 = txtemail.Text;

                if (btv.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridthanhvien.DataSource = btv.GetAllThanhVien();
                }

                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (dataGridthanhvien.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dataGridthanhvien.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                tbthanhvien tv = new tbthanhvien();
                tv.ID1 = ID;
                tv.Hoten1 = txthoten2.Text;
                tv.Phone1 = txtPhone2.Text;
                tv.Email1 = txtemail.Text;

                if (btv.xoaThanhVien(tv))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridthanhvien.DataSource = btv.GetAllThanhVien();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }

        }

        private void dataGridthanhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txthoten2.Text = dataGridthanhvien.Rows[index].Cells["Hoten"].Value.ToString();
                txtPhone2.Text = dataGridthanhvien.Rows[index].Cells["Phone"].Value.ToString();
                txtemail.Text = dataGridthanhvien.Rows[index].Cells["Email"].Value.ToString();
            }
          
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (dataGridthanhvien.SelectedRows.Count > 0)
            {
                if (txtemail.Text != "" && txthoten2.Text != "" && txtPhone2.Text != "")
                {
                    
                    DataGridViewRow row = dataGridthanhvien.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    
                    tbthanhvien tv = new tbthanhvien();
                    tv.ID1 = ID;
                    tv.Hoten1 = txthoten2.Text;
                    tv.Phone1 = txtPhone2.Text;
                    tv.Email1 = txtemail.Text;

                    if (btv.suaThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridthanhvien.DataSource = btv.GetAllThanhVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

    }
    
}
