using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class datathanhvien: SQLconnect
    {
        public DataTable GetData()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM thanhvien", Conn);
            DataTable datathanhvien = new DataTable();
            da.Fill(datathanhvien);
            return datathanhvien;
        }


        public bool themThanhVien(tbthanhvien tv)
        {
            try {
                Conn.Open();
                
                string SQL = "insert into thanhvien(hoten,phone,email) values(@hoten, @phone, @email)";
                
                SqlCommand cmd = new SqlCommand(SQL,Conn);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tv.Hoten1;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = tv.Phone1;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tv.Email1;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {

                Conn.Close();
            }

            return false;
        }

        public bool suaThanhVien(tbthanhvien tv)
        {
            try
            {
                Conn.Open();
                
                string SQL = "UPDATE THANHVIEN SET hoten = @hoten, phone = @phone, email = @email WHERE id = @id";
                
                SqlCommand cmd = new SqlCommand(SQL, Conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tv.ID1;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tv.Hoten1;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = tv.Phone1;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tv.Email1;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
               
                Conn.Close();
            }

            return false;
        }

        public bool xoaThanhVien(tbthanhvien tv)
        {
            try
            {
                Conn.Open();

                string SQL = "DELETE FROM THANHVIEN WHERE id =@id";

                SqlCommand cmd = new SqlCommand(SQL, Conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tv.ID1;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                Conn.Close();
            }

            return false;
        }
    }
}
