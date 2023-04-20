using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private Form curentFormChild;

        public MainUser(NhanVien nv) : this()
        {
            
            
            NhanVienBLL nvBLL = new NhanVienBLL();
            NhanVien _nv = new NhanVien();
            _nv = nvBLL.nhanVienBLL(nv.username);

            lb_user.Text = "Tài khoản: " + _nv.username;
            lb_email.Text = "Email: " + _nv.email;
            lb_name.Text = "Họ tên: " + _nv.hoten;
            lb_manv.Text = "Mã nhân viên: " + _nv.maNV;
            lb_cccd.Text = "CCCD: " + _nv.cccd;
            lb_pb.Text = "Phòng ban: " + _nv.maPhong;
            lb_cv.Text = "Chức vụ: " + _nv.chucVu;
            lb_sdt.Text = "SĐT: " + _nv.sdt;
             
            if ( _nv.gioiTinh)
            {
                pb_imgnv.Image = Image.FromFile("D:\\Projects\\Nodejs\\src\\images\\female.png");
            }
            else
            {
                pb_imgnv.Image = Image.FromFile("D:\\Projects\\Nodejs\\src\\images\\male.png");
            }
            lb_ngaysinh.Text = "Ngày sinh: " + _nv.ngaySinh;

        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
