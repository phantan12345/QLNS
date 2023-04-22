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
using static System.Net.WebRequestMethods;

namespace GUI
{
    public partial class MainFr : Form
    {
        public MainFr()
        {
            InitializeComponent();
        }

        private Form curentFormChild;

        public MainFr(NhanVien nv) : this()
        {


            NhanVienBLL nvBLL = new NhanVienBLL();
            NhanVien _nv = new NhanVien();
            _nv = nvBLL.nhanVienBLL(nv.username);

           

        }

        private void btn_ttcn_Click(object sender, EventArgs e)
        {
            Employee em=new Employee();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            em.TopLevel = false;
            em.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(em);
            em.Show();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            salary sa = new salary();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            sa.TopLevel = false;
            sa.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(sa);
            sa.Show();
        }
    }
}
