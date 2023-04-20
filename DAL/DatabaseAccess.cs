﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=.;Initial Catalog=NhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public string CheckLogicDTO(NhanVien nv)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", nv.username);
            command.Parameters.AddWithValue("@pass", nv.password);
            command.Parameters.AddWithValue("@role", nv.role);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            } else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
             
            return user;
        }
    }
}
