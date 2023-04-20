using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Runtime.InteropServices.ComTypes;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAcess tkAccess = new NhanVienAcess();
        DatabaseAccess dbAccess = new DatabaseAccess();
        public string CheckLogic(NhanVien nv)
        {
            // Kiểm tra nghiệp vụ
            if (nv.username == "")
            {
                return "requeid_taikhoan";
            }

            if (nv.password == "")
            {
                return "requeid_password";
            }

            //string info = tkAccess.CheckLogic(nv);
            string info1 = dbAccess.CheckLogicDTO(nv);
            return info1;
        }
        
        public NhanVien nhanVienBLL(string user)
        {
            return tkAccess.nhanVien(user);
        }
    }

    
}
