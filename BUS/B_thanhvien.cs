using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class B_thanhvien
    {
        datathanhvien dalThanhVien = new datathanhvien();
        public DataTable GetAllThanhVien()
        {
            return dalThanhVien.GetData();
        }

        public bool themThanhVien(tbthanhvien tv)
        {
            return dalThanhVien.themThanhVien(tv);
        }

        public bool xoaThanhVien(tbthanhvien tv)
        {
            return dalThanhVien.xoaThanhVien(tv);
        }

        public bool suaThanhVien(tbthanhvien tv)
        {
            return dalThanhVien.suaThanhVien(tv);
        }

    }
}
