using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        NhanVien nv = new NhanVien();
        NhanVienBLL TKBLL = new NhanVienBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            nv.username = txtTaiKhoan.Text;
            nv.password = txtMatKhau.Text;
            nv.role = 1;

            string getuser = TKBLL.CheckLogic(nv);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }


            MainUser user = new MainUser(nv);
            user.ShowDialog();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            nv.username = txtTaiKhoan.Text;
            nv.password = txtMatKhau.Text;
            nv.role = 0;

            string getuser = TKBLL.CheckLogic(nv);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }


            MainUser user = new MainUser(nv);
            user.ShowDialog();

        }



        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
