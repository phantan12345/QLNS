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

           

        }

      

      

        private void btn_ttcn_Click(object sender, EventArgs e)
        {
            Button button= (Button)sender;
            if(button.Name.Equals("btn_ttcn"))
            {
                panel_ThongTin.Visible = true;
                panel4.Visible = false;

            }
            else if(button.Name.Equals("btn_luong"))
            {
                panel4.Visible = true;
                panel_ThongTin.Visible = false;
                
            }
            else if (button.Name == "btn_ttcn")
            {

            }

        }
    }
}
