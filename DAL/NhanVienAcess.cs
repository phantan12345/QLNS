using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienAcess : DatabaseAccess
    {
        public string CheckLogic(NhanVien taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;

        }
        public NhanVien nhanVien(string username)
        {
            NhanVien nv = new NhanVien();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from NhanVien where username = @username";
            command.Parameters.AddWithValue("@username", username);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    string hoten = reader.GetString(1);
                    string email = reader.GetString(21);
                    string maNv = reader.GetString(0);
                    DateTime ns = reader.GetDateTime(5);
                    string cccd = reader.GetString(8);
                    string sdt = reader.GetString(15);
                    string pb = reader.GetString(3);
                    string cv = reader.GetString(10);
                    bool gt = reader.GetBoolean(6);
                    //DateTime ngayki = reader.GetDateTime(13);

                    nv.username = username; 
                    nv.hoten = hoten;
                    nv.email = email;
                    nv.maNV = maNv;
                    nv.ngaySinh = ns;
                    nv.cccd = cccd;
                    nv.sdt = sdt;
                    nv.maPhong = pb;
                    nv.chucVu = cv;
                    nv.gioiTinh = gt;
                    //nv.ngayKy = ngayki;
                }
                reader.Close();
                conn.Close();

            }
            else
            {
                Console.WriteLine("Không có dữ liệu");
            }
            return nv;

        }

    }
}
