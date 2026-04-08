using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_SinhVien
    {
        private int _SINHVIEN_ID;
        private string _SINHVIEN_NAME;
        private string _SINHVIEN_PHONE;
        private string _SINHVIEN_EMAIL;
        
        //================GETTER/SETTER===============
        public int SINHVIEN_ID
        {
            get
            {
                return _SINHVIEN_ID;
            }

            set
            {
                _SINHVIEN_ID = value;
            }
        }

        public string SINHVIEN_NAME
        {
            get
            {
                return _SINHVIEN_NAME;
            }

            set
            {
                _SINHVIEN_NAME = value;
            }
        }

        public string SINHVIEN_PHONE
        {
            get
            {
                return _SINHVIEN_PHONE;
            }

            set
            {
                _SINHVIEN_PHONE = value;
            }
        }

        public string SINHVIEN_EMAIL
        {
            get
            {
                return _SINHVIEN_EMAIL;
            }

            set
            {
                _SINHVIEN_EMAIL = value;
            }
        }

        //==================CONSTRUSTOR=====================
        public DTO_SinhVien()
        {
        }
        public DTO_SinhVien(int id, string name, string phone, string email)
        {
            this._SINHVIEN_ID = id;
            this._SINHVIEN_NAME = name;
            this._SINHVIEN_PHONE = phone;
            this._SINHVIEN_EMAIL = email;
        }
    }    
}
