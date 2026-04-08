using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace BTH3_NLayer
{
    public partial class GUI_SinhVien : Form
    {
        BUS_SinhVien busSV = new BUS_SinhVien();
        public GUI_SinhVien()
        {
            InitializeComponent();
        }

        //CLICK THOAT
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            dgvSV.DataSource = busSV.getSinhVien();
        }

        //THEM SINH VIEN
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtEmail.Text != null && txtSDT.Text != null)
            {
                DTO_SinhVien sv = new DTO_SinhVien(0, txtName.Text, txtSDT.Text, txtEmail.Text);

                if (busSV.themSinhVien(sv))
                {
                    MessageBox.Show("Them thanh cong");
                    dgvSV.DataSource = busSV.getSinhVien();
                }
                else MessageBox.Show("Them khong thanh cong");
            }
            else MessageBox.Show("Yeu cau nhap day du!");
        }

        //chuyen du lieu tu selected row len cac textbox khi cellclick
        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSV.SelectedRows[0];

            txtName.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
        }
        //SUA SINH VIEN
        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                if (txtName.Text != null && txtEmail.Text != null && txtSDT.Text != null)
                {
                    DataGridViewRow row = dgvSV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    DTO_SinhVien sv = new DTO_SinhVien(ID, txtName.Text, txtSDT.Text, txtEmail.Text);

                    if (busSV.suaSinhVien(sv))
                    {
                        MessageBox.Show("Sua thanh cong");
                        dgvSV.DataSource = busSV.getSinhVien();
                    }
                    else MessageBox.Show("Sua khong thanh cong");
                }
                else MessageBox.Show("Yeu cau nhap day du!");
            }
            else MessageBox.Show("Hãy chọn thành viên muốn sửa");
        }

        //XOA SINH VIEN
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSV.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                if (busSV.xoaSinhVien(ID))
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgvSV.DataSource = busSV.getSinhVien();
                }
                else MessageBox.Show("Xoa khong thanh cong");
            }
            else MessageBox.Show("Hay chon thanh vien muon xoa");
        }

    }
}
